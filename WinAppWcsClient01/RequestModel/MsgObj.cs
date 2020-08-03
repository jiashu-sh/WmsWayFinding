using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWcsClient01.RequestModel
{
    public class MsgObj
    {
        public string MsgType { set; get; }

        public int TypeId { set; get; }

        public object MsgContent { set; get; }


        public string MacAddr { set; get; }

        public MsgObj()
        {
            MsgType = "";
            TypeId = -1;
            MsgContent = null;
            MacAddr = "";
        }
    }
}
