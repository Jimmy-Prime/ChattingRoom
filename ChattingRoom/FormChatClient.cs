using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChattingRoom
{
    public partial class FormChatClient : Form
    {
        ChatSocket client;
        StrHandler msgHandler;

        public FormChatClient()
        {
            InitializeComponent();

            msgHandler = this.addMsg;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendMsg();
        }
		
		private void textBoxMsg_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
				sendMsg();
		}

        public String user() {
            return textBoxUser.Text.Trim();
        }

        public String msg() {
            return textBoxMsg.Text;
        }

        public void sendMsg()
        {
            if (user().Length == 0)
            {
                MessageBox.Show("請輸入使用者名稱!");
                return;
            }
            if (client == null) {
                client = ChatSocket.connect(ChatSetting.serverIp);
                client.newListener(processMsgComeIn);
                client.send(user() + " : 新使用者進入!");
                textBoxUser.Enabled = false;
            }
            if (msg().Length > 0) {
                client.send(user()+" : "+msg());
				textBoxMsg.Text = "";
			}
        }

        public String processMsgComeIn(String msg)
        {
            this.Invoke(msgHandler, new Object[] { msg });
            return "OK";
        }

        public String addMsg(String msg)
        {
            richTextBoxBoard.AppendText(msg + "\n");
            return "OK";
        }
    }
}