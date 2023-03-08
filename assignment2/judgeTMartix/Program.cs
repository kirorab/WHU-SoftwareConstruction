using System;

namespace judgeTMartix
{
    internal class Martix
    {
        private int[,] martix;
        private int m;
        private int n;
        public Martix(int m, int n)
        {
            martix = new int[m, n];
            this.m = m;
            this.n = n;
        }

        public void init1()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    martix[i, j] = j;
                }
            }
        }
        public void init2()
        {
            for (int i = 0; i < martix.GetLength(0); i++)
            {
                for (int j = 0; j < martix.GetLength(1); j++)
                {
                    martix[i, j] = 1;
                }
            }
        }
        public void init3()
        {
            for (int i = 0; i < martix.GetLength(0); i++)
            {
                for (int j = 0; j < martix.GetLength(1); j++)
                {
                    martix[i, j] = i - j;
                }
            }
        }

        private bool judgeDiagonal()
        {
            int i = 1;
            int j = 1;
            while (i < m && j < n)
            {
                if (martix[i-1, j-1] != martix[i, j])
                {
                    return false;
                }
                i++;
                j++;
            }
            return true;
        }
        
        
        public static void Main(string[] args)
        {
            Martix m = new Martix(3, 4);
            m.init1();
            Console.WriteLine(m.judgeDiagonal());
            m.init2();
            Console.WriteLine(m.judgeDiagonal());
            m.init3();
            Console.WriteLine(m.judgeDiagonal());
        }
    }
}