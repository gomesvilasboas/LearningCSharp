using System;

namespace LearningCSharp
{
    class Point
    {
        private double x, y, z;
        private Tuple<double, double, double> point;

        public double EuclidianNorm()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public Tuple<double, double, double> Space
        {
            get
            {
                point = Tuple.Create(x, y, z);
                return point;
            }
            set
            {
                this.x = value.Item1;
                this.y = value.Item2;
                this.z = value.Item3;
            }
        }
    }

    class Calculus
    {
        public void Main()
        {
            int n = 1000;
            Random rand = new Random();
            Point[] p = new Point[n];

            for (int i = 0; i < n - 1; i++)
            {
                Tuple<double, double, double> q;
                q = Tuple.Create((double)rand.Next(0, 10), (double)rand.Next(0, 10), (double)rand.Next(0, 10));
                p[i] = new Point();
                p[i].Space = q;
                Console.Write("Dist: " + p[i].EuclidianNorm() + "\n");
                Console.Write("Space: " + p[i].Space + "\n");
                q = Tuple.Create((double)rand.Next(0, 10), (double)rand.Next(0, 10), (double)rand.Next(0, 10));
                p[i].Space = q;
                Console.Write("New space: " + p[i].Space + "\n");
            }   
            Console.ReadLine();
        }
    }
}
