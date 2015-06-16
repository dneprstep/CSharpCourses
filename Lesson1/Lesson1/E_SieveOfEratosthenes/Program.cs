using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to print prime numbers:");
            uint num=Convert.ToUInt16( Console.ReadLine() );
            Console.WriteLine(Sieve(num));
           
            Console.ReadKey();

        }
        static string Sieve(uint number)
        {
            string result=string.Empty;
            bool [] sieve= new bool[number+1] ;
            for (int i = 0; i < sieve.Length; i++)
                sieve[i] = true;

            for (int i = 2; i < number; i++)
            {
                if(sieve[i]==true)
                    for (int j = i+i; j < number; j += i)
                        sieve[j] = false;
            }

            for (int i = 0; i < sieve.Length; i++)
            {
                if(sieve[i]==true)
                    result += i.ToString() + " ";
            }

            return result;
        }
    }
}
