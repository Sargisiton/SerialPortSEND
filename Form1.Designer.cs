namespace SerialPortSend
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.ClosePortButton = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortName = new System.Windows.Forms.TextBox();
            this.EnterPortButton = new System.Windows.Forms.Button();
            this.MessageEnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(32, 182);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ClosePortButton
            // 
            this.ClosePortButton.Location = new System.Drawing.Point(292, 182);
            this.ClosePortButton.Name = "ClosePortButton";
            this.ClosePortButton.Size = new System.Drawing.Size(75, 23);
            this.ClosePortButton.TabIndex = 1;
            this.ClosePortButton.Text = "ClosePort";
            this.ClosePortButton.UseVisualStyleBackColor = true;
            this.ClosePortButton.Click += new System.EventHandler(this.ClosePortButton_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(86, 52);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(212, 22);
            this.Message.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PortName";
            // 
            // PortName
            // 
            this.PortName.Location = new System.Drawing.Point(86, 91);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(212, 22);
            this.PortName.TabIndex = 5;
            // 
            // EnterPortButton
            // 
            this.EnterPortButton.Location = new System.Drawing.Point(304, 91);
            this.EnterPortButton.Name = "EnterPortButton";
            this.EnterPortButton.Size = new System.Drawing.Size(75, 23);
            this.EnterPortButton.TabIndex = 6;
            this.EnterPortButton.Text = "Enter";
            this.EnterPortButton.UseVisualStyleBackColor = true;
            this.EnterPortButton.Click += new System.EventHandler(this.EnterPortButton_Click);
            // 
            // MessageEnterButton
            // 
            this.MessageEnterButton.Location = new System.Drawing.Point(304, 50);
            this.MessageEnterButton.Name = "MessageEnterButton";
            this.MessageEnterButton.Size = new System.Drawing.Size(75, 23);
            this.MessageEnterButton.TabIndex = 7;
            this.MessageEnterButton.Text = "Enter";
            this.MessageEnterButton.UseVisualStyleBackColor = true;
            this.MessageEnterButton.Click += new System.EventHandler(this.MessageEnterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 232);
            this.Controls.Add(this.MessageEnterButton);
            this.Controls.Add(this.EnterPortButton);
            this.Controls.Add(this.PortName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ClosePortButton);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ClosePortButton;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortName;
        private System.Windows.Forms.Button EnterPortButton;
        private System.Windows.Forms.Button MessageEnterButton;
    }
}

