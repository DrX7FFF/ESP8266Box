using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System;

namespace ESPBox {
	public class ESP8266Tag {
		public string label = "";
		public int adress = 0;
		public int len = 0;
		bool fixe = false;
		List<ESP8266TagValue> lstValue = new List<ESP8266TagValue>();

		public ESP8266Tag() {
		}

		public ESP8266Tag(int adress, int len, string label){
			this.adress = adress;
			this.len = len;
			this.label = label;
		}

		public ESP8266TagValue AddValue(byte[] value){
			ESP8266TagValue tagVal = new ESP8266TagValue(this, value);
			lstValue.Add(tagVal);
			return tagVal;
		}
	}

	public class ESP8266TagValue {
		ESP8266Tag tag;
		DateTime dt = DateTime.Now; 
		byte[] value;

		public string valueString() {
			return string.Format("{0} {1:X4}[{2:D}] = ", tag.label, tag.adress, tag.len) + BitConverter.ToString(value);
		}
		public ESP8266TagValue(ESP8266Tag tag, byte[] value) {
			this.tag = tag;
			//this.value = new byte[tag.len];
			//value.CopyTo(this.value, 0);
			this.value = value;
		}
	}

	public class ESP8266Debug {
		Thread espThread = null;
		Socket tcpClient;
		string ip;
		int port;
		static ManualResetEvent exit = new ManualResetEvent(false);

		public Dictionary<string, ESP8266Tag> lstTag = new Dictionary<string, ESP8266Tag>();
		List<ESP8266TagValue> histValue = new List<ESP8266TagValue>();

		public delegate void dlgOnValue(ESP8266TagValue tagValue);
		public dlgOnValue onValue;
		public delegate void dlgOnMessage(string message);
		public dlgOnMessage onMessage;

		public void newValue(int adress, int len, byte[] value, string label) {
			ESP8266Tag tag = null;
			string name = string.Format("{0:X4}[{1:D}]", adress, len);
			if (!lstTag.TryGetValue(name, out tag)) {
				tag = new ESP8266Tag(adress, len, label);
				lstTag.Add(name, tag);
			}
			ESP8266TagValue tagValue = tag.AddValue(value);
			histValue.Add(tagValue);
			if (onValue != null)
				onValue(tagValue);
		}

		public void newMessage(string message) {
			if (onMessage != null)
				onMessage(message);
		}

		public void start(string ip, int port) {
			if (espThread != null)
				return;
			this.ip = ip;
			this.port = port;
			espThread = new Thread(new ThreadStart(ThreadESP));
			espThread.Start();
		}

		public void stop() {
			if (espThread == null)
				return;
			exit.Set();
			if (tcpClient != null)
				tcpClient.Close();
			espThread = null;
		}

		public void send(byte val) {
			if (tcpClient != null && tcpClient.Connected){
				byte[] data = new byte[1];
				data[0] = val;
				tcpClient.Send(data);
			}
		}

		private void ThreadESP() {
			byte[] buffer = new byte[9];
			exit.Reset();
			newMessage("[System] start");
			do {
				tcpClient = new Socket(SocketType.Stream, ProtocolType.Tcp);
				tcpClient.ReceiveTimeout = 10000;
				newMessage("[System] connecting ...");
				try {
					tcpClient.Connect(ip, port);
					newMessage("[System] connected");
					while (tcpClient.Connected) {
						int receiveLen = tcpClient.Receive(buffer, 9, SocketFlags.None);
						if (receiveLen == 0) 
							tcpClient.Close();					
						else {
							if (buffer[0] == 0) {
								int adr = BitConverter.ToInt32(buffer, 1);
								int len = BitConverter.ToInt32(buffer, 5);
								byte[] val = new byte[len];
								tcpClient.Receive(val, len, SocketFlags.None);
								newValue(adr,
										len,
										val,
										"temp");
							}
							else
								newMessage(System.Text.Encoding.ASCII.GetString(buffer));
						}
					}
				}
				catch {
					exit.WaitOne(2000);
				}
				tcpClient = null;
			} while (!exit.WaitOne(0));
			newMessage("[System] stop");
		}
	}
}
