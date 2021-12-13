using System;

namespace Extra_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print1000();
            By3();
            Equal(4, 5);
            EvenOrOdd(6);
            PosiOrNO(0);
            CanVote();
            IsInRange();
            MultiTab(5);


        }

        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void By3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void Equal(int x, int y)
        {
            if (x == y)
                Console.WriteLine("They are equal.");
            else
                Console.WriteLine("They are not equal.");
        }

        public static void EvenOrOdd(int x)
        {
            if ((x % 2) == 0)
                Console.WriteLine("This number is even");
            else
                Console.WriteLine("This number is odd");

        }

        public static void PosiOrNO(int x)
        {
            if (x < 0)
                Console.WriteLine("This number is negative");
            else if (x > 0)
                Console.WriteLine("This number is positive");
            else
                Console.WriteLine("This number is zero");

        }

        public static void CanVote()
        {

            bool key = true;
            while (key)

            {
                Console.WriteLine("What is your age?");
                int age = int.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("You can vote!");
                    key = false;
                }
                else
                {
                    Console.WriteLine("You cannot vote");
                    key = true;
                }

            }


        }


        public static void IsInRange()
        {
            bool key = true;
            while (key)

            {
                Console.WriteLine("Input a number");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 <= 10 && num1 >= -10)
                {
                    Console.WriteLine("It's in our range!");
                    key = false;
                }
                else if (num1 < -10)
                {
                    Console.WriteLine("Oh darn, not in our range! Try a little higher.");
                    key = true;
                }
                else if (num1 > 10)
                {
                    Console.WriteLine("Oh darn, not in our range... Try a little lower.");
                    key = true;
                }


            }



        }

        public static void MultiTab(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    
    }

}              
