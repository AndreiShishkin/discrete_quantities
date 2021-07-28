using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_WindowsForms
{
    class Class1
    {
        static public double N = 100;
        static public double p = 1 / N;
        static public double[] Arr = new double[10];
        static public double[] rMatrix = new double[100];
        static double next = Environment.TickCount;

        public double getRand()
        {
            double a = 1103515245;
            double m = 2147483648;
            double c = 12345;
            double x;
            next = (a * next + c) % m;
            x = Math.Round(next / m, 4);
            return x;
            // next = next * 1103515245 + 12345;
            // return (int)(next / 65536) % (32767 + 1);
        }

        /* public void srand(uint seed)
         {
             next = seed;
         }*/

        public string Array()
        {
            string mas = " ";

            for (int i = 0; i < rMatrix.Length; i++)
            {
                rMatrix[i] = getRand();
                mas += rMatrix[i] + "\t";

            }
            return mas;
        }
        public double MathExp()
        {

            // double p = 0.01;
            double M = 0;
            for (int i = 0; i < rMatrix.Length; i++)
            {
                M += rMatrix[i] * p;
            }
            return M;
        }
        public double Dispersion()
        {
            double D1 = 0;
            double D;
            //double p = 0.1;
            string d = " ";
            for (int i = 0; i < rMatrix.Length; i++)
            {
                D1 += Math.Pow(rMatrix[i], 2);
            }
            D = p * D1 - Math.Pow(MathExp(), 2);
            return D;
        }
        public double Mean_square_deviation()
        {
            double Q;
            Q = Math.Sqrt(Dispersion());
            return Q;
        }
        public double Сoefficient_of_variation()
        {
            double V;
            V = Math.Abs(Mean_square_deviation() / MathExp());
            return V;
        }
        public string periodicity()
        {
            int count = 0;
            // for (int i = 1; i < 10; i++)
            // {
            string tr = "";
            ;
            double z = rMatrix[0];
            while (z != getRand())

            {
                count++;

                if (count > 9999)
                {
                    tr = "Больше";
                    tr += count;
                    break;
                }
                else
                {
                    tr = Convert.ToString(count);
                }
            }

            // }
            return tr;
        }

        public void uniformity()
        {
            int j = 0;
            double count = 0;
            double Q = 0;
            double Q1 = 0.1;
            for (; Q <= 1 && Q1 <= 1;)
            {
                for (int i = 1; i < rMatrix.Length; i++)
                {
                    if (rMatrix[i] >= Q && rMatrix[i] < Q1)
                    {
                        count++;
                    }
                }
                Arr[j] = count;
                count = 0;
                j++;
                Q += 0.1;
                Q1 += 0.1;
            }
        }
        public double Pearson_test()
        {
            double pj = 0.1;
            double sum = 0;
            double Q = 0;
            double Q1 = 0.1;
            int count = 0;
            for (; Q <= 1 && Q1 <= 1;)
            {
                for (int i = 1; i < rMatrix.Length; i++)
                {
                    if (rMatrix[i] >= Q && rMatrix[i] < Q1)
                    {
                        count++;
                    }
                }
                sum += Math.Pow(count, 2) / pj - N;
                count = 0;
                Q += 0.1;
                Q1 += 0.1;
            }
            sum /= N;
            return sum;
        }
        public double Correlation_Coef()
        {
            double avgX = 0;
            double avgY = 0;
            double sum_chisl = 0;
            int z = 1;
            double[] ArrY = new double[100];
            for (int i = 0; i < ArrY.Length; i++)
            {
                ArrY[i] = z;
                avgY += ArrY[i];
                z++;
            }
            for (int i = 0; i < rMatrix.Length; i++)
            {
                avgX += rMatrix[i];
            }
            avgX /= 100;
            avgY /= 100;
            // Расчет числителя:
            for (int i = 0; i < 100; i++)
            {
                double chisl;
                chisl = (rMatrix[i] - avgX) * (ArrY[i] - avgY);
                sum_chisl += chisl;
            }
            // Рассчет знаменателя:
            double sumX = 0;
            for (int i = 0; i < rMatrix.Length; i++)
            {
                double X_down;
                X_down = Math.Pow(rMatrix[i] - avgX, 2);
                sumX += X_down;
            }
            double sumY = 0;
            for (int i = 0; i < ArrY.Length; i++)
            {
                double Y_down;
                Y_down = Math.Pow(ArrY[i] - avgY, 2);
                sumY += Y_down;
            }
            double znam = Math.Sqrt(sumX * sumY);
            double r = sum_chisl / znam;
            return r;
        }

    }
}
