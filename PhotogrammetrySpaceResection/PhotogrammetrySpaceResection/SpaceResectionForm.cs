using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace PhotogrammetrySpaceResection
{
    public partial class SpaceResectionForm : CCSkinMain
    {
        //是否拖拽文件至应用程序图标初始化
        bool IsDragFileOpen = false;

        //初始化参数
        List<ResectionPoint> PhotoPoint = new List<ResectionPoint>();
        List<ResectionPoint> GroundPoint = new List<ResectionPoint>();
        double m, f, x0, y0;
        int ReTime = 0;

        //应用程序初始化
        public SpaceResectionForm(string[] args)
        {
            InitializeComponent();
            try
            {
                //拖拽文件至图标启动
                if (args.GetLength(0) > 0)
                {
                    ReadFile(args);
                    IsDragFileOpen = true;
                }
                else
                {
                    IsDragFileOpen = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //窗体初始化
        private void SpaceResectionForm_Load(object sender, EventArgs e)
        {
            try
            {
                //若为拖拽文件启动则定位到文件所在文件夹
                if (!IsDragFileOpen)
                {
                    FilePathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                SaveToFileButton.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Err", err.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //拖动数据文件到窗体来打开
        private void DragToOpenFile(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                ReadFile(files);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //编辑表 
        private void InputDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //新建行添加行标
                if (InputDataGridView.CurrentRow.Cells[1].Value != null || InputDataGridView.CurrentRow.Cells[2].Value != null || InputDataGridView.CurrentRow.Cells[3].Value != null || InputDataGridView.CurrentRow.Cells[4].Value != null || InputDataGridView.CurrentRow.Cells[5].Value != null)
                {
                    InputDataGridView.CurrentRow.Cells[0].Value = InputDataGridView.CurrentRow.Index + 1;
                }
                //移除已创建（有行标）的行
                else if (InputDataGridView[0, e.RowIndex].Value != null && InputDataGridView.Rows.Count > 0)
                {
                    InputDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //清空表
        private void ClearDataGridView(object sender, EventArgs e)
        {
            InputDataGridView.Rows.Clear();
            SaveToFileButton.Enabled = false;
            ResultGifBox.Visible = true;
        }

        //计算
        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                if(InputDataGridView.RowCount < 5)
                {
                    throw new Exception("小于四个点算个毛线啊！");
                }

                ReTime = 0; //迭代次数归零
                
                //读取文本框
                m = Convert.ToDouble(RatioTextBox.Text);    //像片比例尺
                f = Convert.ToDouble(InnerFTextBox.Text);   //主距
                x0 = Convert.ToDouble(InnerXTextBox.Text);  //内方位元素
                y0 = Convert.ToDouble(InnerYTextBox.Text);
                int ReTimeLimit = Convert.ToInt32(ReTimeLimitTextBox.Text); //迭代次数上限

                //限差转成十进制度
                AngleDMS Limit = new AngleDMS
                {
                    Degree = 0,
                    Minute = 0,
                    Second = Convert.ToDouble(LimitTextBox.Text)
                };

                //清空点位记录
                PhotoPoint.Clear();
                GroundPoint.Clear();
                ResultTextBox.Text = "这里什么都没有，好冷清啊。快点击“计算”吧！";

                //逐行写入点位记录
                for (int i = 0; i < InputDataGridView.RowCount - 1; i++)
                {
                    PhotoPoint.Add(new ResectionPoint
                    {
                        X = (Convert.ToDouble(InputDataGridView[1, i].Value) - x0) / 1000,
                        Y = (Convert.ToDouble(InputDataGridView[2, i].Value) - y0) / 1000,
                        Z = -f / 1000
                    });

                    GroundPoint.Add(new ResectionPoint
                    {
                        X = Convert.ToDouble(InputDataGridView[3, i].Value),
                        Y = Convert.ToDouble(InputDataGridView[4, i].Value),
                        Z = Convert.ToDouble(InputDataGridView[5, i].Value)
                    });
                }

                double[,] Result = { { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } };    //初始化结果矩阵
                double[,] RM = new double[3, 3];    //初始化旋转矩阵
                double[,] Q = new double[6, 6];     //初始化中误差矩阵

                ResectionCalc.CalcMain(PhotoPoint, GroundPoint, m, f / 1000, IO.DMS2DEC(Limit), ReTimeLimit, ref Result, ref ReTime, out RM, out Q);  //求外方位元素

                //转换并输出               
                string ResultXs = Result[0, 0].ToString("0.0000");
                string ResultYs = Result[1, 0].ToString("0.0000");
                string ResultZs = Result[2, 0].ToString("0.0000");
                string Resultphi = IO.DMS2Str(IO.DEC2DMS(Result[3, 0]));
                string ResultOmega = IO.DMS2Str(IO.DEC2DMS(Result[4, 0]));
                string Resultkappa = IO.DMS2Str(IO.DEC2DMS(Result[5, 0]));
                string Diffphi = IO.DMS2Str(IO.DEC2DMS(Q[3, 3]));
                string DiffOmega = IO.DMS2Str(IO.DEC2DMS(Q[4, 4]));
                string Diffkappa = IO.DMS2Str(IO.DEC2DMS(Q[5, 5]));
                string ResultRM = "";

                //旋转矩阵转文本
                for (int i = 0; i < RM.GetLength(0); i++)
                {
                    for (int j = 0; j < RM.GetLength(1); j++)
                    {
                        ResultRM += RM[i, j].ToString("0.0000") + ", ";
                    }
                    ResultRM += "\r\n";
                }

                //设置文本框文本
                ResultTextBox.Text = "Xs = " + ResultXs + " (m)\r\nYs = " + ResultYs + " (m)\r\nZs = " + ResultZs + " (m)\r\nφ = " + Resultphi + "\r\nω = " + ResultOmega + "\r\nк = " + Resultkappa + "\r\n旋转矩阵为：\r\n" + ResultRM + "共迭代 " + Convert.ToString(ReTime) + " 次" + "\r\nXs精度为：" + Q[0, 0].ToString("0.0000") + " (m)\r\nYs精度为：" + Q[1, 1].ToString("0.0000") + " (m)\r\nZs精度为：" + Q[2, 2].ToString("0.0000") + " (m)\r\nφ精度为：" + Diffphi + "\r\nω精度为：" + DiffOmega + "\r\nк精度为：" + Diffkappa;
                
                //控件设置
                SaveToFileButton.Enabled = true;
                ResultGifBox.Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //文件管理
        private void FileManagement(object sender, EventArgs e)
        {
            try
            {
                //从文件读取
                if (sender == ReadFromFileButton)
                {
                    double[,] Points;
                    if (CSVRadioButton.Checked) //读取csv
                    {
                        string st = FilePathTextBox.Text + "\\ResectionPoints.csv";
                        Points = IO.LoadFromCSV(st);
                    }
                    else   //读取xml
                    {
                        string st = FilePathTextBox.Text + "\\ResectionPoints.xml";
                        Points = IO.LoadFromXML(st);
                    }
                    InputDataGridView.Rows.Clear(); //读取后写入前清空数据表

                    //将读取的数据写入数据表
                    for (int i = 0; i < Points.GetLength(0); i++)
                    {
                        InputDataGridView.Rows.Add();
                        for (int j = 0; j < Points.GetLength(1); j++)
                        {
                            InputDataGridView[j, i].Value = Convert.ToString(Points[i, j]);
                        }
                    }

                    //读取后操作
                    SaveToFileButton.Enabled = false;
                    ResultGifBox.Visible = true;
                    ResultTextBox.Text = "这里什么都没有，好冷清啊。快点击“计算”吧！";
                }

                //改路径
                if (sender == ChangeFilePathButton)
                {
                    FolderBrowserDialog ChangeFilePath = new FolderBrowserDialog();
                    if (ChangeFilePath.ShowDialog() == DialogResult.OK)
                    {
                        FilePathTextBox.Text = ChangeFilePath.SelectedPath;
                    }
                    ChangeFilePath.Dispose();
                }

                //存结果
                if (sender == SaveToFileButton)
                {
                    //计算用的数据单位与输入单位不一致，若需保存结果需重新保存点位数据
                    PhotoPoint.Clear();
                    GroundPoint.Clear();
                    for (int i = 0; i < InputDataGridView.RowCount - 1; i++)
                    {
                        PhotoPoint.Add(new ResectionPoint
                        {
                            X = Convert.ToDouble(InputDataGridView[1, i].Value),
                            Y = Convert.ToDouble(InputDataGridView[2, i].Value),
                            Z = -f
                        });

                        GroundPoint.Add(new ResectionPoint
                        {
                            X = Convert.ToDouble(InputDataGridView[3, i].Value),
                            Y = Convert.ToDouble(InputDataGridView[4, i].Value),
                            Z = Convert.ToDouble(InputDataGridView[5, i].Value)
                        });
                    }
                    string st = FilePathTextBox.Text + "\\ResectionPoints_" + IO.DT() + ".txt";
                    IO.SaveToFile(st, PhotoPoint, GroundPoint, RatioTextBox.Text, InnerXTextBox.Text, InnerYTextBox.Text, InnerFTextBox.Text, ResultTextBox.Text, LimitTextBox.Text);
                }

                //开文件夹
                if (sender == OpenFileLocationButton)
                {
                    System.Diagnostics.Process.Start("explorer.exe", FilePathTextBox.Text);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //读取文件类
        internal void ReadFile(string[] files)
        {
            if (files.GetLength(0) > 1)
            {
                throw new Exception("每次仅可加载一个数据文件！");
            }
            var Extension = System.IO.Path.GetExtension(files[0]);
            if (Extension.Equals(".csv", StringComparison.CurrentCultureIgnoreCase) || Extension.Equals(".xml", StringComparison.CurrentCultureIgnoreCase))
            {
                double[,] Points;
                FilePathTextBox.Text = System.IO.Path.GetDirectoryName(files[0]);   //定位到当前文件夹
                //扩展名比对
                if (Extension.Equals(".csv", StringComparison.CurrentCultureIgnoreCase))
                {
                    Points = IO.LoadFromCSV(System.IO.Path.GetFullPath(files[0]));
                    CSVRadioButton.Checked = true;
                }
                else
                {
                    Points = IO.LoadFromXML(System.IO.Path.GetFullPath(files[0]));
                    XMLRadioButton.Checked = true;
                }
                InputDataGridView.Rows.Clear(); //清空数据表并重新添加
                for (int i = 0; i < Points.GetLength(0); i++)
                {
                    InputDataGridView.Rows.Add();
                    for (int j = 0; j < Points.GetLength(1); j++)
                    {
                        InputDataGridView[j, i].Value = Convert.ToString(Points[i, j]);
                    }
                }
                SaveToFileButton.Enabled = false;
                ResultGifBox.Visible = true;              
                ResultTextBox.Text = "这里什么都没有，好冷清啊。快点击“计算”吧！";
            }
            else
            {
                throw new Exception("请选择.csv或.xml文件！");
            }
        }

        //退出程序
        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //作者信息
        private void Author(object sender, EventArgs e)
        {
            MessageBox.Show("单像空间后方交会程序, 由Rikakoist编写，界面皮肤使用CSkin", "LOL!");
        }
    }
}
