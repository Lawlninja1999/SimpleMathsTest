using SimpleMathsTest.WorkerClassAndFactory.Interface;
using SimpleMathsTest.WorkerClassAndFactory.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathsTest.WorkerClassAndFactory.Factory
{
    public class FactoryClass
    {
        public Icalculations GetIcalculations(int number)
        {
            Icalculations obj = null;
            if (number==1)
            {
                //the implementation of the super class is done in the child class
                //superclass object= new subclass
                obj = new Add();
            }
            else if (number==2)
            {
                //the implementation of the super class is done in the child class
                //superclass object= new subclass
                obj = new Sub();
            }
            else if (number == 3)
            {
                //the implementation of the super class is done in the child class
                //superclass object= new subclass
                obj = new multiply();
            }
            else if (number == 4)
            {
                //the implementation of the super class is done in the child class
                //superclass object= new subclass
                obj = new Harder();
            }

            return obj;
        }
    }
}
