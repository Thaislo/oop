using QuanLyTinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTinder
{
    internal class Message
    {
        private string messsage  = " ";

        public Message()
        {

        }
        public Message(string mess)
        {
            this.messsage = mess;
        }
        public string GuiTinNhan(string message)
        {
            if (messsage != null)
                return messsage;
            return "";
        }
        public string XoaTinNhan(string message)
        {
            if (messsage != null)
                messsage.Remove(messsage.Length);
            return message;
        }
    }
}
