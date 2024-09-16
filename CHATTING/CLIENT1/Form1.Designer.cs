namespace CLIENT1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // messageListBox
            // 
            this.messageListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 18;
            this.messageListBox.Location = new System.Drawing.Point(23, 36);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(421, 310);
            this.messageListBox.TabIndex = 10;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.connectButton.Location = new System.Drawing.Point(646, 49);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(127, 39);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect ";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            this.connectButton.MouseLeave += new System.EventHandler(this.ConnectButtonColorUnchanged);
            this.connectButton.MouseHover += new System.EventHandler(this.ConnectButtonColorChanged);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.Control;
            this.sendButton.Image = global::CLIENT1.Properties.Resources.send;
            this.sendButton.Location = new System.Drawing.Point(402, 374);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(154, 70);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            this.sendButton.MouseLeave += new System.EventHandler(this.SendButton_MouseLeave);
            this.sendButton.MouseHover += new System.EventHandler(this.SendButton_MouseHover);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputTextBox.Location = new System.Drawing.Point(41, 397);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(328, 29);
            this.inputTextBox.TabIndex = 7;
            this.inputTextBox.Text = "Recipient | Message";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(461, 51);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 27);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Text = "Enter Your Name";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(423, 36);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 316);
            this.vScrollBar1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " TALAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

