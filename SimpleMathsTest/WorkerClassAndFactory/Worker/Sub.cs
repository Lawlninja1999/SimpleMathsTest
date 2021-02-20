using SimpleMathsTest.WorkerClassAndFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathsTest.WorkerClassAndFactory.Worker
{
    public class Sub : Icalculations
    {
        public void calculate(int a, int b)
        {
            Console.WriteLine($"{a}-{b}");
        }
    }
}
