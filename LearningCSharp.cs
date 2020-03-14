using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class LeaarningCSharp
    {
        static void Main(string[] args)
        {
            var program = new LeaarningCSharp();
            program.Run();
        }

        public void Run()
        {
            var calculus = new Calculus();
            calculus.Main();

        }
    }
}
