namespace ChattingRoom
{
    partial class FormChatClient
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInput = new System.Windows.Forms.Panel();
            this.labelSaid = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panelPadding1 = new System.Windows.Forms.Panel();
            this.panelMsg = new System.Windows.Forms.Panel();
            this.richTextBoxBoard = new System.Windows.Forms.RichTextBox();
            this.panelInput.SuspendLayout();
            this.panelMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.labelSaid);
            this.panelInput.Controls.Add(this.textBoxUser);
            this.panelInput.Controls.Add(this.textBoxMsg);
            this.panelInput.Controls.Add(this.buttonSend);
            this.panelInput.Controls.Add(this.panelPadding1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 283);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(494, 64);
            this.panelInput.TabIndex = 0;
            // 
            // labelSaid
            // 
            this.labelSaid.AutoSize = true;
            this.labelSaid.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSaid.Location = new System.Drawing.Point(94, 17);
            this.labelSaid.Name = "labelSaid";
            this.labelSaid.Size = new System.Drawing.Size(54, 21);
            this.labelSaid.TabIndex = 4;
            this.labelSaid.Text = "說：";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(3, 17);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(88, 22);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(154, 17);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(250, 22);
            this.textBoxMsg.TabIndex = 2;
            this.textBoxMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMsg_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(410, 14);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(81, 28);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "送出";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panelPadding1
            // 
            this.panelPadding1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPadding1.Location = new System.Drawing.Point(0, 48);
            this.panelPadding1.Name = "panelPadding1";
            this.panelPadding1.Size = new System.Drawing.Size(494, 16);
            this.panelPadding1.TabIndex = 0;
            // 
            // panelMsg
            // 
            this.panelMsg.Controls.Add(this.richTextBoxBoard);
            this.panelMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMsg.Location = new System.Drawing.Point(0, 0);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.Size = new System.Drawing.Size(494, 283);
            this.panelMsg.TabIndex = 1;
            // 
            // richTextBoxBoard
            // 
            this.richTextBoxBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxBoard.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxBoard.Name = "richTextBoxBoard";
            this.richTextBoxBoard.Size = new System.Drawing.Size(494, 283);
            this.richTextBoxBoard.TabIndex = 0;
            this.richTextBoxBoard.Text = "";
            // 
            // FormChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 347);
            this.Controls.Add(this.panelMsg);
            this.Controls.Add(this.panelInput);
            this.Name = "FormChatClient";
            this.Text = "C# 聊天室";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelMsg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelMsg;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Panel panelPadding1;
        private System.Windows.Forms.RichTextBox richTextBoxBoard;
        private System.Windows.Forms.Label labelSaid;
        private System.Windows.Forms.TextBox textBoxUser;
    }
}

