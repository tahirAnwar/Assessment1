using System;
using System.Collections.Generic;


namespace FibbonacciSumOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstNum = 1;
            double SecondNum = 2;
            double sum = 0;
            double EvenNumberSum = 2;
            List<double> FibbonacciNumbers=new List<double>();
            List<double> FibbonacciEvenNumbers = new List<double>();

            FibbonacciNumbers.Add(1);
            FibbonacciNumbers.Add(2);

            while(sum<=4000000)
            {
                sum=FirstNum + SecondNum;
                FibbonacciNumbers.Add(sum);
                if (sum%2==0)
                {
                    FibbonacciEvenNumbers.Add(sum);
                    EvenNumberSum += sum;
                }

                FirstNum = SecondNum;
                SecondNum = sum;
            }

            int count = 0;
            Console.WriteLine("\n\n List of fibbonacci Numbers\n\n");
            while(count!= FibbonacciNumbers.Count)
            {
                Console.WriteLine(FibbonacciNumbers[count]);
                count++;
            }

            count = 0;

            Console.WriteLine("\n\n List of Even Numbers in fibbonacci Numbers\n\n");
            while (count != FibbonacciEvenNumbers.Count)
            {
                Console.WriteLine(FibbonacciEvenNumbers[count]);
                count++;
            }

            Console.WriteLine("\n\n Sum of Even Numbers in Fibbonacci Series upto Four Miilion = " + EvenNumberSum + "\n\n");

            Console.ReadKey();
        }
       
    }
}
