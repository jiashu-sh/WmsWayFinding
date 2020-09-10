using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDollySimulator.Entities
{
    class EntityRbtReportStatus
    {
        /// <summary>
        /// 当前时间戳
        /// </summary>
        public long CurrentTimeStamp { get; set; }
        /// <summary>
        /// 和上一次获取时间的差异毫秒数
        /// </summary>
        public int DeltaTimeMs { get; set; }

        public bool RbtStatusGetFlag { get; set; }
        public int LeftWheelSpeed { get; set; }

        /// <summary>
        /// 左轮方向：1向前，0向后
        /// </summary>
        public int LeftWheelDirection { get; set; }
        public int RightWheelSpeed { get; set; }

        /// <summary>
        /// 右轮方向：1向前，0向后
        /// </summary>
        public int RightWheelDirection { get; set; }

        public double AngularVelocity { get; set; }

        /// <summary>
        /// 合计z轴角度;AngularVelocity*TimeSpan 
        /// </summary>
        public double SumAngularVelocity { get; set; }

        /// <summary>
        /// 合计左轮行走距离 LeftWheelSpeed*TimeSpan 
        /// </summary>
        public int SumDistanceLeftWheel { get; set; }

        /// <summary>
        /// 合计右轮行走距离 RightWheelSpeed*TimeSpan
        /// </summary>
        public int SumDistanceRightWheel { get; set; }

        /// <summary>
        /// 行走总距离（左轮 + 右轮 平均值）
        /// </summary>
        public int SumDistance { get; set; }

        //public double SumAngularVelocityKalman { get; set; }


        public double KalmanAngleVal { get; set; }

        /// <summary>
        /// 角度：左转为正，右转为负数，暂设为x轴正向0度，右转负数角度，左转正数角度
        /// </summary>
        public double RbtAngle { get; set; }

        public int Orient { get; set; }

        public int RbtLocationNo { get; set; }


        /// <summary>
        /// 状态描述
        /// </summary>
        public string StatusDesc { get; set; }

        public EntityRbtReportStatus()
        {
            LeftWheelSpeed = 0;
            LeftWheelDirection = 1;
            RightWheelSpeed = 0;
            RightWheelDirection = 1;

            AngularVelocity = 0;
            RbtStatusGetFlag = false;
            StatusDesc = "";

            SumAngularVelocity = 0;
            SumDistanceLeftWheel = 0;
            SumDistanceRightWheel = 0;

            RbtAngle = 0;
            KalmanAngleVal = 0;
            //SumAngularVelocityKalman = 0;

            RbtLocationNo = 0;
            Orient = 1;//(E=1)东

            CurrentTimeStamp = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;
            DeltaTimeMs = 0;
        }

        public EntityRbtReportStatus(byte[] RcvDatas)
        {
            /*
            const int RcvByteLength = 8;

            LeftWheelSpeed = 0;
            LeftWheelDirection = 1;
            RightWheelSpeed = 0;
            RightWheelDirection = 1;

            AngularVelocity = 0;
            RbtStatusGetFlag = false;
            StatusDesc = "";

            SumAngularVelocity = 0;
            SumDistanceLeftWheel = 0;
            SumDistanceRightWheel = 0;
            //SumAngularVelocityKalman = 0;

            RbtAngle = 0;
            KalmanAngleVal = 0;

            RbtLocationNo = 0;

            if (RcvDatas.Length != RcvByteLength)
                return;

            byte[] bRcvHead = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            bRcvHead[0] = RcvDatas[0];
            bRcvHead[1] = RcvDatas[1];

            //bRcvCommandHead
            if (!Common.CommonUtils.BytesEquals(bRcvHead, Common.CommonDefine.bRcvCommandHead))
                return;

            LeftWheelSpeed = RcvDatas[Common.CommonDefine.iRcvLeftWheel]; // System.BitConverter.ToInt32((new byte[] { RcvDatas[Common.CommonDefine.iRcvLeftWheel] }), 0);
            LeftWheelDirection = RcvDatas[Common.CommonDefine.iRcvLeftWheelDirection]; // System.BitConverter.ToInt32((new byte[] { RcvDatas[Common.CommonDefine.iRcvLeftWheelDirection] }), 0);
            RightWheelSpeed = RcvDatas[Common.CommonDefine.iRcvRightWheel]; // System.BitConverter.ToInt32((new byte[] { RcvDatas[Common.CommonDefine.iRcvRightWheel] }), 0);
            RightWheelDirection = RcvDatas[Common.CommonDefine.iRcvLeftWheelDirection]; // System.BitConverter.ToInt32((new byte[] { RcvDatas[Common.CommonDefine.iRcvLeftWheelDirection] }), 0);

            int iAngularVelocityHith = RcvDatas[Common.CommonDefine.iRcvAngularVelocityHigh]; // System.BitConverter.ToInt32((new byte[] { RcvDatas[Common.CommonDefine.iRcvAngularVelocityHigh] }), 0);
            int iAngularVelocityLow = RcvDatas[Common.CommonDefine.iRcvAngularVelocityLow]; // System.BitConverter.ToInt32((new byte[] { RcvDatas[Common.CommonDefine.iRcvAngularVelocityLow] }), 0);
            //GyroZ = tx[4]*256 + tx[5] - 32768
            AngularVelocity = iAngularVelocityHith * 256 + iAngularVelocityLow - 32768;

            StatusDesc = "小车状态:";
            StatusDesc += "左轮(" + LeftWheelDirection.ToString() + ")" + LeftWheelSpeed + " ,";
            StatusDesc += "右轮(" + RightWheelDirection.ToString() + ")" + RightWheelSpeed + " ,";
            StatusDesc += "角度 " + AngularVelocity.ToString() + "。";
            RbtStatusGetFlag = true;
            */
        }
    }
}
