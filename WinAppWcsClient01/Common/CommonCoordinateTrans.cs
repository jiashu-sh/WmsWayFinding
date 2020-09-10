using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWcsClient01.Common
{
    class CommonCoordinateTrans
    {
        /// <summary>
        /// 获取小车多边形
        /// </summary>
        /// <param name="pDollyCenter"></param>
        /// <param name="iDollySize"></param>
        /// <param name="dDollyAngle"></param>
        /// <param name="oDollyOrientation"></param>
        /// <returns></returns>
        internal static Point[] GetDollyPoints(Point pDollyCenter, int iDollySize, double dDollyAngle, CommonDefine.Orientation oDollyOrientation)
        {
            //计算斜边长 = 1.414 * 正方形边长
            double dHypotenuse = (iDollySize / 2) * 1414 / 1000; //线段长度
            double dRadian = (45 - dDollyAngle) * Math.PI / 180;

            Point p1 = new Point((pDollyCenter.X - iDollySize / 2), (pDollyCenter.Y - iDollySize / 2));
            Point p2 = new Point((pDollyCenter.X + iDollySize / 2), (pDollyCenter.Y - iDollySize / 2));
            Point p3 = new Point((pDollyCenter.X + iDollySize / 2), (pDollyCenter.Y + iDollySize / 2));
            Point p4 = new Point((pDollyCenter.X - iDollySize / 2), (pDollyCenter.Y + iDollySize / 2));

            if ((Math.Abs(dDollyAngle)) == 45) //+-45度的时候单独处理一下
            {
                p1.X = pDollyCenter.X;
                p1.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse);
                p2.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse);
                p2.Y = pDollyCenter.Y;
                p3.X = pDollyCenter.X;
                p3.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse);
                p4.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse);
                p4.Y = pDollyCenter.Y;
                Point[] points45 =
                {
                    p1,p2,p3,p4
                };
                return points45;
            }

            switch (oDollyOrientation)
            {
                case CommonDefine.Orientation.E:
                    p1.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian)); 
                    p1.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p2.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p2.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p3.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p3.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p4.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p4.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    break;
                case CommonDefine.Orientation.S:
                    p1.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p1.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p2.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p2.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p3.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p3.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p4.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p4.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    break;
                case CommonDefine.Orientation.W:
                    p1.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p1.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p2.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p2.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p3.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p3.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p4.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p4.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    break;
                case CommonDefine.Orientation.N:
                    p1.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p1.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p2.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p2.Y = pDollyCenter.Y - Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p3.X = pDollyCenter.X + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    p3.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p4.X = pDollyCenter.X - Convert.ToInt32(dHypotenuse * Math.Sin(dRadian));
                    p4.Y = pDollyCenter.Y + Convert.ToInt32(dHypotenuse * Math.Cos(dRadian));
                    break;
                default:
                    //return pOrientation;
                    break;
            }

            Point[] pointsDolly =
                {
                    p1,p2,p3,p4
                };

            return pointsDolly;
        }

        /// <summary>
        /// 获取方向终点坐标
        /// </summary>
        /// <param name="pDollyCenter"></param>
        /// <param name="iDollySize"></param>
        /// <param name="dDollyAngle"></param>
        /// <param name="oDollyOrientation"></param>
        /// <returns></returns>
        internal static Point GetDollyOrientation(Point pDollyCenter, int iDollySize, double dDollyAngle, CommonDefine.Orientation oDollyOrientation)
        {
            Point pOrientation = new Point(pDollyCenter.X, pDollyCenter.Y + iDollySize / 2 - 7);
            double dLineLength = iDollySize / 2 - 7; //线段长度   
            double dRadian = dDollyAngle * Math.PI / 180;

            switch (oDollyOrientation)
            {
                case CommonDefine.Orientation.E:
                    
                    if (dDollyAngle == 0)
                    {
                        pOrientation.X = pDollyCenter.X + Convert.ToInt32(dLineLength);
                        pOrientation.Y = pDollyCenter.Y;
                    }
                    else
                    {
                        pOrientation.X = pDollyCenter.X + Convert.ToInt32(dLineLength * Math.Cos(dRadian));
                        pOrientation.Y = pDollyCenter.Y - Convert.ToInt32(dLineLength * Math.Sin(dRadian));
                    }
                    break;
                case CommonDefine.Orientation.S:
                    if (dDollyAngle == 0)
                    {
                        pOrientation.X = pDollyCenter.X ;
                        pOrientation.Y = pDollyCenter.Y + Convert.ToInt32(dLineLength);
                    }
                    else
                    {
                        pOrientation.X = pDollyCenter.X + Convert.ToInt32(dLineLength * Math.Sin(dRadian));
                        pOrientation.Y = pDollyCenter.Y + Convert.ToInt32(dLineLength * Math.Cos(dRadian));
                    }
                    break;
                case CommonDefine.Orientation.W:
                    if (dDollyAngle == 0)
                    {
                        pOrientation.X = pDollyCenter.X - Convert.ToInt32(dLineLength);
                        pOrientation.Y = pDollyCenter.Y ;
                    }
                    else
                    {
                        pOrientation.X = pDollyCenter.X - Convert.ToInt32(dLineLength * Math.Cos(dRadian));
                        pOrientation.Y = pDollyCenter.Y + Convert.ToInt32(dLineLength * Math.Sin(dRadian));
                    }
                    break;
                case CommonDefine.Orientation.N:
                    if (dDollyAngle == 0)
                    {
                        pOrientation.X = pDollyCenter.X;
                        pOrientation.Y = pDollyCenter.Y - Convert.ToInt32(dLineLength);
                    }
                    else
                    {
                        pOrientation.X = pDollyCenter.X - Convert.ToInt32(dLineLength * Math.Sin(dRadian));
                        pOrientation.Y = pDollyCenter.Y - Convert.ToInt32(dLineLength * Math.Cos(dRadian));
                    }
                    break;
                default:
                    //return pOrientation;
                    break;
            }


            return pOrientation;
        }
    }
}
