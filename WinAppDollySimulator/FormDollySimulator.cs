using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDollySimulator
{
    public partial class FormDollySimulator : Form
    {
        private static readonly CancellationToken _cancellation;

        public FormDollySimulator()
        {
            InitializeComponent();
        }

        private void FormDollySimulator_Load(object sender, EventArgs e)
        {
            cbDollyOrientation.SelectedIndex = 0;
        }

        private void btnStartRun_Click(object sender, EventArgs e)
        {
            if (tbRunTimes.Text.Trim() == "")
                return;
            try
            {
                int iTimes = int.Parse(tbRunTimes.Text.Trim());
                int iLeftWheelSpeed = int.Parse(tbLeftWheelSpeed.Text.Trim());
                int iRightWheelSpeed = int.Parse(tbRightWheelSpeed.Text.Trim());
            }
            catch
            {
                return;
            }
            RunDollySimulator();
        }

        private void RunDollySimulator()
        {
            const int Interval_Time = 80;

            int iTimes = int.Parse(tbRunTimes.Text.Trim());
            int iLeftWheelSpeed = int.Parse(tbLeftWheelSpeed.Text.Trim());
            int iRightWheelSpeed = int.Parse(tbRightWheelSpeed.Text.Trim());

            int iOrient = 1;
            if (cbDollyOrientation.Text.Trim() == "E")
                iOrient = 1;
            else if (cbDollyOrientation.Text.Trim() == "S")
                iOrient = 2;
            else if (cbDollyOrientation.Text.Trim() == "W")
                iOrient = 3;
            else if (cbDollyOrientation.Text.Trim() == "N")
                iOrient = 4;

            string sLeftSpeed = "";
            string sRightSpeed = "";
            for (int i=0;i<iTimes;i++)
            {
                int iLeftDeviation = 0;
                int iRightDeviation = 0;
                if ((i % 3) == 0)
                {
                    Random rd = new Random(i);
                    if ((i % 6) == 0)
                        iLeftDeviation = rd.Next() % 10 - 4;
                    else
                        iRightDeviation = rd.Next() % 10 - 4;
                }

                long dCurrentTimeStamp = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;

                Entities.EntityRbtReportStatus rbtStatus = new Entities.EntityRbtReportStatus();
                rbtStatus.LeftWheelSpeed = iLeftWheelSpeed + iLeftDeviation;
                rbtStatus.RightWheelSpeed = iRightWheelSpeed + iRightDeviation;
                rbtStatus.Orient = iOrient;
                rbtStatus.CurrentTimeStamp = dCurrentTimeStamp;
                rbtStatus.DeltaTimeMs = Interval_Time;

                string sJson = Newtonsoft.Json.JsonConvert.SerializeObject(rbtStatus); //转换对象为string
                //await SendWebSocket(sJson);
                SendWebSocket(sJson);

                sLeftSpeed += rbtStatus.LeftWheelSpeed.ToString() + ", ";
                sRightSpeed += rbtStatus.RightWheelSpeed.ToString() + ", ";

                Thread.Sleep(Interval_Time);
            }

            lbLeftSpeed.Text = sLeftSpeed;
            lbRightSpeed.Text = sRightSpeed;
        }

        private async Task SendWebSocket(string sJson)
        {
            //string strMsg = "super heros...times: " + i.ToString(); // +"\r\n";
            byte[] bsend = System.Text.Encoding.UTF8.GetBytes(sJson);

            ClientWebSocket webSocket = new ClientWebSocket();
            await webSocket.ConnectAsync(new Uri("ws://192.168.3.42:50000/"), _cancellation); //ws://192.168.3.14:50000

            Console.WriteLine(sJson);
            //发送数据
            await webSocket.SendAsync(new ArraySegment<byte>(bsend), WebSocketMessageType.Binary, true, _cancellation);

            await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "1", _cancellation);

            webSocket.Dispose();
        }
    }
}
