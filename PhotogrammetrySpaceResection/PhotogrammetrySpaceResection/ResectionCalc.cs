using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra.MatrixAlgebra;

namespace PhotogrammetrySpaceResection
{
    class ResectionCalc
    {
        internal static void CalcMain(List<ResectionPoint> PhotoPoint, List<ResectionPoint> GroundPoint, double m, double f, double Limit, int ReTimeLimit, ref double[,] Result, ref int ReTime, out double[,] RM, out double[,] Q)
        {           
            ResectionPoint CenterPoint = new ResectionPoint();  //摄影中心点

            //逐点计算Xs、Ys、Zs
            foreach (ResectionPoint Point in GroundPoint)
            {
                Result[0, 0] += Point.X;
                Result[1, 0] += Point.Y;
                Result[2, 0] += Point.Z;
            }
            Result[0, 0] /= GroundPoint.Count;
            Result[1, 0] /= GroundPoint.Count;
            Result[2, 0] = m * f + Result[2, 0] / GroundPoint.Count;

            //根据点的个数创建矩阵
            double[,] A = new double[2 * PhotoPoint.Count, 6];  //A矩阵，每个点2*6
            double[,] L = new double[2 * PhotoPoint.Count, 1];  //L矩阵，每个点2*1
            double[,] RotationAngles = new double[3, 1]; //角元素矩阵，3*1
            double[,] X = { { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } }; //改正数矩阵，6*1

            do
            {
                //检查迭代次数
                if (ReTime > ReTimeLimit)
                {
                    throw new Exception("迭代次数超出限制！");
                }

                //每次迭代开始对本次计算的外方位元素重新赋值
                CenterPoint.X = Result[0, 0];
                CenterPoint.Y = Result[1, 0];
                CenterPoint.Z = Result[2, 0];
                Array.Copy(Result, 3, RotationAngles, 0, 3);

                //通过三个角元素建立旋转矩阵
                RM = GetRotationMatrix(RotationAngles);

                //逐点计算并构造A，L
                int CurrentRow = 0; //当前行计数器
                for (int i = 0; i < PhotoPoint.Count; i++)
                {
                    ResectionPoint AvgPoint = GetAvg(GroundPoint[i], CenterPoint, RM);  //合并重复项，简化变量

                    //逐点获取A、L
                    double[,] ATmp = GetA(AvgPoint, RotationAngles, RM, f);
                    double[,] LTmp = GetL(PhotoPoint[i], AvgPoint, f);

                    //拷贝暂存数组
                    Array.Copy(ATmp, 0, A, A.GetLength(1) * CurrentRow, ATmp.GetLength(0) * ATmp.GetLength(1));
                    Array.Copy(LTmp, 0, L, L.GetLength(1) * CurrentRow, LTmp.GetLength(0) * LTmp.GetLength(1));
                    
                    CurrentRow += 2;    //单个点赋值完毕，当前行数+2
                }

                X = GetX(A, L); //计算改正量
                Result = MatrixComputation.Add(Result, X);  //外方位元素矩阵加改正量
                ReTime++;   //迭代次数+1
            } while (Math.Abs(X[3, 0]) > Limit || Math.Abs(X[4, 0]) > Limit || Math.Abs(X[5, 0]) > Limit);    //当改正量大于阈值时继续迭代
            Q = GetQ(A, X, L, GroundPoint.Count);   //计算完毕后的误差分析
        }

        //计算旋转矩阵
        internal static double[,] GetRotationMatrix(double[,] RotationAngles)
        {
            //RotationAngles[3, 1] = [φ; ω; к]
            double phi = RotationAngles[0, 0];
            double omega = RotationAngles[1, 0];
            double kappa = RotationAngles[2, 0];
            double[,] Rphi = { { Math.Cos(phi), 0, -Math.Sin(phi) }, { 0, 1, 0 }, { Math.Sin(phi), 0, Math.Cos(phi) } };
            double[,] Romega = { { 1, 0, 0 }, { 0, Math.Cos(omega), -Math.Sin(omega) }, { 0, Math.Sin(omega), Math.Cos(omega) } };
            double[,] Rkappa = { { Math.Cos(kappa), -Math.Sin(kappa), 0 }, { Math.Sin(kappa), Math.Cos(kappa), 0 }, { 0, 0, 1 } };
            return MatrixComputation.Multiply(MatrixComputation.Multiply(Rphi, Romega), Rkappa);           
        }

        //获取每个点的X平，Y平，Z平
        internal static ResectionPoint GetAvg(ResectionPoint GroundPoint, ResectionPoint CenterPoint, double[,] RM)
        {
            ResectionPoint AvgPoint = new ResectionPoint
            {
                X = RM[0, 0] * (GroundPoint.X - CenterPoint.X) + RM[1, 0] * (GroundPoint.Y - CenterPoint.Y) + RM[2, 0] * (GroundPoint.Z - CenterPoint.Z),
                Y = RM[0, 1] * (GroundPoint.X - CenterPoint.X) + RM[1, 1] * (GroundPoint.Y - CenterPoint.Y) + RM[2, 1] * (GroundPoint.Z - CenterPoint.Z),
                Z = RM[0, 2] * (GroundPoint.X - CenterPoint.X) + RM[1, 2] * (GroundPoint.Y - CenterPoint.Y) + RM[2, 2] * (GroundPoint.Z - CenterPoint.Z)
            };
            return AvgPoint;
        }

        //获取系数阵
        internal static double[,] GetA(ResectionPoint AvgPoint, double[,] RotationAngles, double[,] RM, double f)
        {
            /*
            A[2, 6] = [a11, a12, a13, a14, a15, a16; a21, a22, a23, a24, a25, a26] 
            RotationAngles[3, 1] = [φ; ω; к]
            RM[3, 3] = [a1, a2, a3; b1, b2, b3; c1, c2, c3]
            */

            //转换以防止出错
            double x = -f * (AvgPoint.X / AvgPoint.Z);
            double y = -f * (AvgPoint.Y / AvgPoint.Z);
            double phi = RotationAngles[0, 0];
            double omega = RotationAngles[1, 0];
            double kappa = RotationAngles[2, 0];

            double[,] A = new double[2, 6];

            //套系数精确值公式
            A[0, 0] = (RM[0, 0] * f + RM[0, 2] * x) / AvgPoint.Z;    //a11
            A[0, 1] = (RM[1, 0] * f + RM[1, 2] * x) / AvgPoint.Z;    //a12
            A[0, 2] = (RM[2, 0] * f + RM[2, 2] * x) / AvgPoint.Z;    //a13
            A[0, 3] = y * Math.Sin(omega) - ((x / f) * (x * Math.Cos(kappa) - y * Math.Sin(kappa)) + f * Math.Cos(kappa)) * Math.Cos(omega);   //a14
            A[0, 4] = -f * Math.Sin(kappa) - (x / f) * (x * Math.Sin(kappa) + y * Math.Cos(kappa));    //a15
            A[0, 5] = y;    //a16

            A[1, 0] = (RM[0, 1] * f + RM[0, 2] * y) / AvgPoint.Z;    //a21
            A[1, 1] = (RM[1, 1] * f + RM[1, 2] * y) / AvgPoint.Z;    //a22
            A[1, 2] = (RM[2, 1] * f + RM[2, 2] * y) / AvgPoint.Z;    //a23
            A[1, 3] = -x * Math.Sin(omega) - ((y / f) * (x * Math.Cos(kappa) - y * Math.Sin(kappa)) - f * Math.Sin(kappa)) * Math.Cos(omega);  //a24
            A[1, 4] = -f * Math.Cos(kappa) - (y / f) * (x * Math.Sin(kappa) + y * Math.Cos(kappa));    //a25
            A[1, 5] = -x;   //a26

            return A;
        }

        //求L
        internal static double[,] GetL(ResectionPoint PhotoPoint, ResectionPoint AvgPoint, double f)
        {
            double[,] L = new double[2, 1];
            L[0, 0] = PhotoPoint.X + f * (AvgPoint.X / AvgPoint.Z);
            L[1, 0] = PhotoPoint.Y + f * (AvgPoint.Y / AvgPoint.Z);
            return L;
        }

        //求改正数
        internal static double[,] GetX(double[,] A, double[,] L)
        {
            //X = (A^(T)A)^(-1)*A^(T)*L
            return MatrixComputation.Multiply(MatrixComputation.Multiply(MatrixComputation.Inverse((MatrixComputation.Multiply(MatrixComputation.Transpose(A), A))), MatrixComputation.Transpose(A)), L);
        }

        //求Q
        internal static double[,] GetQ(double[,] A, double[,] X, double[,] L, int PointCount)
        {
            /*
             平差课本
             (P130，7-3-2) 单位权中误差σ0 = √((V^(T)*PV)/r)
             P = I
             (P112，7-1-4)V = AX - L
             r = n - t
             (P132，表7-9) Qxx = NBB^(-1) = (A^(T)*PA)^(-1)
             (P133，7-3-15) σx = σ0 * √Qxx
            */

            double m0 = Math.Sqrt((MatrixComputation.Multiply(MatrixComputation.Transpose(MatrixComputation.Subtract(MatrixComputation.Multiply(A, X), L)), MatrixComputation.Subtract(MatrixComputation.Multiply(A, X), L))[0, 0] / (2 * PointCount - 6)));
            double[,] Q = MatrixComputation.Inverse(MatrixComputation.Multiply(MatrixComputation.Transpose(A), A));
            for (int i = 0; i < Q.GetLength(0); i++)
            {
                for (int j = 0; j < Q.GetLength(1); j++)
                {
                    Q[i, j] = Math.Sqrt(Q[i, j]) * m0;
                }
            }
            return Q;
        }
    }
}
