﻿namespace WinFormsExample {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSendLED13ON = new System.Windows.Forms.Button();
            this.buttonSendLED13OFF = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxFree = new System.Windows.Forms.TextBox();
            this.buttonSendText = new System.Windows.Forms.Button();
            this.txtLEDState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSendLED13ON
            // 
            this.buttonSendLED13ON.Location = new System.Drawing.Point(13, 53);
            this.buttonSendLED13ON.Name = "buttonSendLED13ON";
            this.buttonSendLED13ON.Size = new System.Drawing.Size(104, 23);
            this.buttonSendLED13ON.TabIndex = 0;
            this.buttonSendLED13ON.Text = "LED 13 ON";
            this.buttonSendLED13ON.UseVisualStyleBackColor = true;
            this.buttonSendLED13ON.Click += new System.EventHandler(this.buttonSendCommand1_Click);
            // 
            // buttonSendLED13OFF
            // 
            this.buttonSendLED13OFF.Location = new System.Drawing.Point(123, 53);
            this.buttonSendLED13OFF.Name = "buttonSendLED13OFF";
            this.buttonSendLED13OFF.Size = new System.Drawing.Size(99, 23);
            this.buttonSendLED13OFF.TabIndex = 1;
            this.buttonSendLED13OFF.Text = "LED 13 OFF";
            this.buttonSendLED13OFF.UseVisualStyleBackColor = true;
            this.buttonSendLED13OFF.Click += new System.EventHandler(this.buttonSendCommand2_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(13, 13);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(254, 21);
            this.portComboBox.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(273, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(89, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 108);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(350, 170);
            this.textBox.TabIndex = 6;
            // 
            // textBoxFree
            // 
            this.textBoxFree.Location = new System.Drawing.Point(13, 82);
            this.textBoxFree.Name = "textBoxFree";
            this.textBoxFree.Size = new System.Drawing.Size(271, 20);
            this.textBoxFree.TabIndex = 7;
            // 
            // buttonSendText
            // 
            this.buttonSendText.Location = new System.Drawing.Point(290, 81);
            this.buttonSendText.Name = "buttonSendText";
            this.buttonSendText.Size = new System.Drawing.Size(72, 20);
            this.buttonSendText.TabIndex = 8;
            this.buttonSendText.Text = "Send";
            this.buttonSendText.UseVisualStyleBackColor = true;
            this.buttonSendText.Click += new System.EventHandler(this.buttonSendText_Click);
            // 
            // txtLEDState
            // 
            this.txtLEDState.Location = new System.Drawing.Point(248, 50);
            this.txtLEDState.Name = "txtLEDState";
            this.txtLEDState.ReadOnly = true;
            this.txtLEDState.Size = new System.Drawing.Size(114, 20);
            this.txtLEDState.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSendText;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 289);
            this.Controls.Add(this.txtLEDState);
            this.Controls.Add(this.buttonSendText);
            this.Controls.Add(this.textBoxFree);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.buttonSendLED13OFF);
            this.Controls.Add(this.buttonSendLED13ON);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialCommunicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSendLED13ON;
		private System.Windows.Forms.Button buttonSendLED13OFF;
		private System.Windows.Forms.ComboBox portComboBox;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TextBox textBoxFree;
		private System.Windows.Forms.Button buttonSendText;
        private System.Windows.Forms.TextBox txtLEDState;
    }
}

