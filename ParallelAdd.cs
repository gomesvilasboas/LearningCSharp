using System;
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks;
using System.Threading;

namespace LearningCSharp
{
    class ParallelAdd
    {

        private int[] CreateRandonArray(int n)
        {
            int i;
            int[] v = new int[n];

            Random rand = new Random();
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            for (i = 0; i < n; i++)
            {
                v[i] = 1;
            }
            stopWatch.Stop();
            Console.WriteLine("Array creation time: " + stopWatch.ElapsedMilliseconds.ToString());
            return v;
        }

        private int[] AddSerial(int[] a, int[] b, int n)
        {
            int i;
            int[] c = new int[n];
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            for (i = 0; i < n; i++)
            {
                c[i] = (int)Math.Pow(a[i] - b[i], 2);
            }
            stopWatch.Stop();
            Console.WriteLine("Serial Add time: " + stopWatch.ElapsedMilliseconds.ToString());

            Console.WriteLine("Added!");
            return c;
        }

        private int[] AddParallel(int[] a, int[] b, int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            int[] c = new int[n];

            stopWatch.Start();
            Parallel.For(0, n, i =>
            {
                c[i] = (int)Math.Pow(a[i] - b[i], 2);
            });

            stopWatch.Stop();
            Console.WriteLine("Parallel Add time: " + stopWatch.ElapsedMilliseconds.ToString());
            return c;
        }

        private void RealProof(int[] a, int[] b, int n)
        {
            int i;
            int sum = 0;
            for (i = 0; i < n; i++)
            {
                sum += a[i] - b[i];
            }
            Console.WriteLine("The real proof is: " + sum);
        }

        internal void Main(string[] Args)
        {
            int n = 100000000;
            ParallelAdd v = new ParallelAdd();
            int[] a = v.CreateRandonArray(n), b = v.CreateRandonArray(n);
            int[] vr = new int[n];//, vr = new int[n];
            vr = v.AddSerial(a, b, n);
            vr = v.AddParallel(a, b, n);
            //v.RealProof(sr, vr, n);

            Thread.Sleep(5000);
            //Console.ReadLine();
        }
    }
}
