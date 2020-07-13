using System;
using System.Numerics;

namespace TaskDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 : Number divisible by 3
            NumberDivisble();
            //Exercise 2: Factorial
            Console.WriteLine("Enter a number to find its factorial");
            int number = int.Parse(Console.ReadLine());
            FactorialNumber(number);
            //Exercise 3: Series of numbers
            Console.WriteLine("Enter the series of number separated by comma ',' ");
            String seriesOfNumber = Console.ReadLine();
            NumberSeries(seriesOfNumber);
            //Exercies 4: Print Numbers
            Console.WriteLine("Enter the number to print");
            int number2= int.Parse(Console.ReadLine());
            PrintNumberOutput(number2);
            //Exercies 5 a : Print Name and its length
            Console.WriteLine("Enter your name");
            string nameOfPerson = Console.ReadLine();
            PrintName(nameOfPerson);
            //Exercise 5 b : Print 3rd word in a string/sentence.
            Console.WriteLine("Enter a sentence ");
            string sentence = Console.ReadLine();
            FindThirdString(sentence);

        }

        static void NumberDivisble()
        {
            int count = 0;
            Console.WriteLine("The Numbers between 1 to 100 and are divisible by 3 is: ");
            for(int i=1;i<=100;i++)
            {
                if(i%3==0)
                {
                    Console.Write(i+" ");
                    count++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Total numbers between 1 to 100 divisible by 3 is: "+count);
        }
        static void FactorialNumber(int number)
        {
            //using Big integer we will find factorial for any number
            BigInteger fact = new BigInteger(1);
            for(int i=number;i>=1;i--)
            {
                fact = fact * i;
            }
            Console.WriteLine($"Factorial of {number} is: " + fact);
        }
        static void NumberSeries(string seriesOfNumber)
        {
            seriesOfNumber = seriesOfNumber.Trim(',');
            String[] number = seriesOfNumber.Split(",");
            int max = 0;
            for(int i=0;i<number.Length;i++)
            {
                if (int.Parse(number[i])>max) 
                {
                    max = int.Parse(number[i]);
                }
            }
            Console.WriteLine("Max is: " + max);
        }
        static void PrintNumberOutput(int number)
        {
            for(int i=1;i<=number;i++)
            {
                Console.WriteLine($"This is Number {i}");
            }
        }
        static void PrintName(string name)
        {
            Console.WriteLine($"You have entered {name} which has length of " + name.Length);
        }
        static void FindThirdString(string sentence) 
        {
            string[] sentenceArray = sentence.Split(" ");
            int sentencelength = sentenceArray.Length;
            try
            {
                if (sentenceArray[2] != null)
                {
                    Console.WriteLine($"Hello Your Sentence {sentence} contains " + sentencelength + " words. your third word is " + sentenceArray[2]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Hello Your sentence {sentence} contains " + sentencelength + " words. There is no third word in your sentence");
            }
        }

    }
}
