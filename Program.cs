using System;

namespace demo01.variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            int score = 92;

            Console.WriteLine("There is " + money + " Bahts in your wallet.");
            if (score > 90)
            {
                money += 100;
                Console.WriteLine("Your score is " + score + ".");
                Console.WriteLine("You got the prize for 100 Baht.");
            }
            else if (score >= 80)
            {
                money += 50;
                Console.WriteLine("Your score is " + score + ".");
                Console.WriteLine("You got the prize for 50 Baht.");
            }
            else if (score >= 70)
            {
                money += 30;
                Console.WriteLine("Your score is " + score + ".");
                Console.WriteLine("You got the prize for 30 Baht.");
            }
            else if (score >= 50)
            {
                money += 10;
                Console.WriteLine("Your score is " + score + ".");
                Console.WriteLine("You got the prize for 10 Baht.");
            }
            else
            {
                money += 5;
                Console.WriteLine("Your score is " + score + ".");
                Console.WriteLine("You got the prize for 5 Baht.");
            }

            Console.WriteLine("Now,You have " + money + " Baht in your wallet.");
        }
    }
}

