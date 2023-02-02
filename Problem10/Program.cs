using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=6;
           
            Console.WriteLine("Next prime number is : " + primeNumb(num));
        }
            public static int primeNumb(int num)
        {

        
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0){num++; i = 2;}
            }
            return num;
         }
        }
    }

