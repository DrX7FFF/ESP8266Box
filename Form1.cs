using System;
using System.Windows.Forms;

namespace ESPBox {
	public partial class Form1 : Form {
		ESP8266Debug myesp = new ESP8266Debug();

		public Form1() {
			InitializeComponent();
			myesp.onValue += onValue;
			myesp.onMessage += onMessage;
		}

		delegate void onMessageCallBack(string message);
		private void onMessage(string message) {
			if (txtMessage.InvokeRequired) {
				onMessageCallBack cb = new onMessageCallBack(onMessage);
				Invoke(cb, message);
			}
			else {
				txtMessage.AppendText(message + "\r\n");
			}
		}

		delegate void onValueCallBack(ESP8266TagValue tagValue);
		private void onValue(ESP8266TagValue tagValue) {
			if (txtMessage.InvokeRequired) {
				onValueCallBack cb = new onValueCallBack(onValue);
				Invoke(cb, tagValue);
			}
			else {
				txtMessage.AppendText(tagValue.valueString() + "\r\n");
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			myesp.send(0);
		}

		private void button2_Click(object sender, EventArgs e) {
			myesp.send(10);
		}

		private void chkConnect_CheckedChanged(object sender, EventArgs e) {
			if (chkConnect.Checked)
				myesp.start(txtIP.Text, int.Parse(txtPort.Text));
			else
				myesp.stop();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			myesp.onValue -= onValue;
			myesp.onMessage -= onMessage;
			myesp.stop();
		}
	}
}
