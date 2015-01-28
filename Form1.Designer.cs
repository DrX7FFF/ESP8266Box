namespace ESPBox {
	partial class Form1 {
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageTag = new System.Windows.Forms.TabPage();
			this.tabPageParam = new System.Windows.Forms.TabPage();
			this.chkConnect = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.lblIP = new System.Windows.Forms.Label();
			this.eSP8266DebugBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnNotify = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageTag.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.eSP8266DebugBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtMessage);
			this.splitContainer1.Size = new System.Drawing.Size(691, 306);
			this.splitContainer1.SplitterDistance = 143;
			this.splitContainer1.TabIndex = 5;
			// 
			// txtMessage
			// 
			this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMessage.Location = new System.Drawing.Point(0, 0);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ReadOnly = true;
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMessage.Size = new System.Drawing.Size(691, 159);
			this.txtMessage.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageTag);
			this.tabControl.Controls.Add(this.tabPageParam);
			this.tabControl.Location = new System.Drawing.Point(0, 31);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(705, 338);
			this.tabControl.TabIndex = 9;
			// 
			// tabPageTag
			// 
			this.tabPageTag.Controls.Add(this.splitContainer1);
			this.tabPageTag.Location = new System.Drawing.Point(4, 22);
			this.tabPageTag.Name = "tabPageTag";
			this.tabPageTag.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTag.Size = new System.Drawing.Size(697, 312);
			this.tabPageTag.TabIndex = 1;
			this.tabPageTag.Text = "Tag";
			this.tabPageTag.UseVisualStyleBackColor = true;
			// 
			// tabPageParam
			// 
			this.tabPageParam.Location = new System.Drawing.Point(4, 22);
			this.tabPageParam.Name = "tabPageParam";
			this.tabPageParam.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageParam.Size = new System.Drawing.Size(697, 312);
			this.tabPageParam.TabIndex = 0;
			this.tabPageParam.Text = "Param";
			this.tabPageParam.UseVisualStyleBackColor = true;
			// 
			// chkConnect
			// 
			this.chkConnect.AutoSize = true;
			this.chkConnect.Location = new System.Drawing.Point(188, 8);
			this.chkConnect.Name = "chkConnect";
			this.chkConnect.Size = new System.Drawing.Size(66, 17);
			this.chkConnect.TabIndex = 17;
			this.chkConnect.Text = "Connect";
			this.chkConnect.UseVisualStyleBackColor = true;
			this.chkConnect.CheckedChanged += new System.EventHandler(this.chkConnect_CheckedChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(341, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(260, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(144, 6);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(38, 20);
			this.txtPort.TabIndex = 13;
			this.txtPort.Text = "367";
			this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(122, 9);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(26, 13);
			this.lblPort.TabIndex = 12;
			this.lblPort.Text = "Port";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(27, 6);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(89, 20);
			this.txtIP.TabIndex = 11;
			this.txtIP.Text = "192.168.0.18";
			// 
			// lblIP
			// 
			this.lblIP.AutoSize = true;
			this.lblIP.Location = new System.Drawing.Point(12, 9);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(17, 13);
			this.lblIP.TabIndex = 10;
			this.lblIP.Text = "IP";
			// 
			// eSP8266DebugBindingSource
			// 
			this.eSP8266DebugBindingSource.DataSource = typeof(ESPBox.ESP8266Debug);
			// 
			// btnNotify
			// 
			this.btnNotify.Location = new System.Drawing.Point(554, 9);
			this.btnNotify.Name = "btnNotify";
			this.btnNotify.Size = new System.Drawing.Size(111, 23);
			this.btnNotify.TabIndex = 18;
			this.btnNotify.Text = "Notify New Version";
			this.btnNotify.UseVisualStyleBackColor = true;
			this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(473, 9);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 19;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 369);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnNotify);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.chkConnect);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.lblIP);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.lblPort);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPageTag.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.eSP8266DebugBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageParam;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.TabPage tabPageTag;
		private System.Windows.Forms.CheckBox chkConnect;
		private System.Windows.Forms.BindingSource eSP8266DebugBindingSource;
		private System.Windows.Forms.Button btnNotify;
		private System.Windows.Forms.Button button3;
	}
}

