using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
       
            public void calculate_sum(int n1, int n2)
            {
                int result = n1 + n2;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            static void Main(string[] args)
            {

                Program objpg = new Program();
                objpg.calculate_sum(10, 25);

            }
        }

    }
    

