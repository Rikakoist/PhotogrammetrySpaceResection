using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace PhotogrammetrySpaceResection
{
    class IO
    {
        //获取当前时间
        internal static string DT()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        //从文件读取点位信息
        internal static double[,] LoadFromCSV(string FileName)
        {

            //获取文本
            string Thoroughly = File.ReadAllText(FileName);

            //拆分文本至行
            Thoroughly = Thoroughly.Replace('\n', '\r');
            string[] Lines = Thoroughly.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //统计行列数
            int RowCount = Lines.Length;
            int ColCount = Lines[0].Split(',').Length;

            //根据行列数建立新数组
            double[,] TempArray = new double[RowCount, ColCount];

            //将文本填充进数组
            for (int Row = 0; Row < RowCount; Row++)
            {
                string[] ArrayLine = Lines[Row].Split(',');
                for (int Col = 0; Col < ColCount; Col++)
                {
                    TempArray[Row, Col] = Convert.ToDouble(ArrayLine[Col]);
                }
            }
            return TempArray;
        }

        internal static double[,] LoadFromXML(string FilePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FilePath);
            DataSet DS = new DataSet();
            DS.ReadXml(new StringReader(doc.InnerXml));
            DataTable DT = DS.Tables[0];
            double[,] Data = new double[DT.Rows.Count, DT.Columns.Count];

            int row = 0;
            foreach (DataRow DR in DT.Rows)
            {
                for (int col = 0; col < DR.ItemArray.Count(); col++)
                {
                    Data[row, col] = Convert.ToDouble(DR[col]);
                }
                row++;
            }
            return Data;
        }

        //保存计算结果至文件
        internal static void SaveToFile(string FilePath, List<ResectionPoint> PhotoPoint, List<ResectionPoint> GroundPoint, string Ratio, string X, string Y, string f, string Result, string Limit)
        {
            using (StreamWriter sw = File.CreateText(FilePath))
            {
                sw.WriteLine("点号, 像点x (mm), 像点y (mm), 地面x (m), 地面y (m), 地面z (m)");
                //对csv文件逐行写入
                for (int i = 0; i < PhotoPoint.Count; i++)
                {
                    sw.WriteLine(Convert.ToString(i + 1) + ", " + Convert.ToString(PhotoPoint[i].X) + ", " + Convert.ToString(PhotoPoint[i].Y) + ", " + Convert.ToString(GroundPoint[i].X) + ", " + Convert.ToString(GroundPoint[i].Y) + ", " + Convert.ToString(GroundPoint[i].Z));
                }
                sw.WriteLine("像片比例尺：1:" + Ratio);
                sw.WriteLine("内方位元素：x0 = " + X + "，y0 = " + Y + "，f = " + f + "（mm）");
                sw.WriteLine("限差为" + Limit + "″");
                sw.WriteLine("计算结果为：\r\n" + Result);
            }
            MessageBox.Show("计算结果成功保存至" + FilePath, "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //角度转文本
        internal static string DMS2Str(AngleDMS DMS)
        {
            if (DMS.Degree < 0 || DMS.Minute < 0 || DMS.Second < 0)
            {
                return "-" + Convert.ToString(Math.Abs(DMS.Degree) + "° " + Math.Abs(DMS.Minute) + "′ " + Math.Abs(DMS.Second).ToString("0.0000") + "″");
            }
            else
            {
                return Convert.ToString(DMS.Degree + "° " + DMS.Minute + "′ " + DMS.Second.ToString("0.0000") + "″");
            }
        }
        #region 角度转换
        //十进制转弧度
        public static double DEC2ARC(AngleDEC DEC)
        {
            return DEC.DEC * Math.PI / 180;
        }

        //弧度转十进制
        public static double ARC2DEC(double ARC)
        {
            return (ARC / Math.PI * 180);
        }

        //度分秒转十进制
        public static double DMS2DEC(AngleDMS DMS)
        {
            double Result = DMS.Degree + DMS.Minute / 60.0 + DMS.Second / 3600.0;
            return Result;
        }

        //十进制转度分秒
        public static AngleDMS DEC2DMS(double X)
        {
            AngleDMS Result = new AngleDMS
            {
                Degree = (int)X
            };
            Result.Minute = (int)((X - Result.Degree) * 60);
            Result.Second = (((X - Result.Degree) * 60 - Result.Minute) * 60);
            while (Result.Second >= 60)
            {
                Result.Second -= 60;
                Result.Minute += 1;
                while (Result.Minute >= 60)
                {
                    Result.Minute -= 60;
                    Result.Degree += 1;
                }
            }
            return Result;
        }

        //度分秒转弧度
        public static double DMS2ARC(AngleDMS DMS)
        {
            AngleDEC TempDEC = new AngleDEC();
            AngleARC Result = new AngleARC();
            TempDEC.DEC = DMS2DEC(DMS);
            Result.ARC = DEC2ARC(TempDEC);
            return Result.ARC;
        }

        //弧度转度分秒
        public static AngleDMS ARC2DMS(double ARC)
        {
            double Temp = ARC2DEC(ARC);
            AngleDMS Result = DEC2DMS(Temp);
            return Result;
        }
        #endregion
    }
}
