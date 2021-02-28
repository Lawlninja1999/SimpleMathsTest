using SimpleMathsTest.WorkerClassAndFactory.Factory;
using SimpleMathsTest.WorkerClassAndFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathsTest
{
    class Program
    {
        static void Main(string[] args)
        {



            
           
            Console.Clear();
            int wrong = 3;
            int score = 0;
            Console.WriteLine("what is your Username?");
           string Username= Console.ReadLine();
            Console.WriteLine("what is your Password?");
            string Password = Console.ReadLine();
            Console.Clear();
            while (wrong>0)
            {
               
                
                Random random = new Random();
               int whaa=1;
                int value1 = random.Next(1, 10);
                int value2 = random.Next(1, 10);
               
                if (score>=3)
                {
                     whaa = 3;
                    value1 = random.Next(2, 10);
                    value2 = random.Next(2, 10);
                }
                 if (score>=6)
                {
                    whaa = 2;
                    value1 = random.Next(1, 20);
                    value2 = random.Next(1, 20);
                }
                 if (score>=9)
                {
                    whaa = 4;
                    value1 = random.Next(3, 10);
                    value2 = random.Next(3, 10);
                }
                FactoryClass factoryMethod = new FactoryClass();
                Icalculations obj = factoryMethod.GetIcalculations(whaa);
               
               
                if (value1 < value2)
                {
                    int temp = value2;
                    value2 = value1;
                    value1 = temp;
                }
                obj.calculate(value1, value2);
                Console.WriteLine($"{wrong} tries to go");
                Console.WriteLine($"your current score is {score}");
                Console.WriteLine("Enter Answer");
                int num;
                int.TryParse(Console.ReadLine(), out num);
             
                if (num == value2 + value1 && whaa == 1 || num == value1 - value2 && whaa == 2 ||
                    num == value2 * value1 && whaa == 3 ||
                    num == value1+(value1* value2)- value1 && whaa == 4)
                {
                    Console.Clear();
                   
                    
                    score++;
                }
                else
                {
                    Console.Clear();
                    wrong--;
                    if(wrong==0)
                    {
                        Console.WriteLine($"Hello {Username}, Your final score was {score}, try again next time"); 
                    }
                   
                }
              
               
                
            }
            
           
                   
                }
            }
        }
