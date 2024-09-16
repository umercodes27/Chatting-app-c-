namespace SERVER
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // messageListBox
            // 
            this.messageListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 29;
            this.messageListBox.Location = new System.Drawing.Point(38, 112);
            this.messageListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(792, 410);
            this.messageListBox.TabIndex = 15;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.connectButton.Location = new System.Drawing.Point(640, 18);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(190, 60);
            this.connectButton.TabIndex = 14;
            this.connectButton.Text = "Connect ";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.Control;
            this.sendButton.Image = global::SERVER.Properties.Resources.send1;
            this.sendButton.Location = new System.Drawing.Point(612, 566);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(228, 62);
            this.sendButton.TabIndex = 13;
            this.sendButton.Text = "Send Message";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputTextBox.Location = new System.Drawing.Point(38, 566);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(564, 56);
            this.inputTextBox.TabIndex = 12;
            this.inputTextBox.Text = "Recipient | Message";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(38, 18);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(592, 58);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.Text = "Enter Your Name";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(804, 112);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 410);
            this.vScrollBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Nadir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.sendButton_Click_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

