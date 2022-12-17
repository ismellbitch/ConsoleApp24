using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Algorithm
    {
        private int n;
        private int x;
        
        public Algorithm(int n, int x)
        {
            this.n = n;
            this.x = x;
        }
        public int N 
        { 
            get { return n; } 
            set { if (n > 0) n = value; }
        }
        public int X
        {
            get { return x; }
        }

        public double GetAlgorithm(double K = 1)
        {
            for (int i = 1; i < N + 1; i++)
            {
                double Factorial = 1;
                int FactorialMult = 1;
                do
                {
                    Factorial *= FactorialMult;
                    FactorialMult++;
                } while (FactorialMult <= i);
                K += ((i * i + 1) / Factorial) * Math.Pow((X / 2), i);
            }
            return K;
        }
    }
}
