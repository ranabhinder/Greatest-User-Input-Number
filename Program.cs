using System;

namespace Greatest_User_Input_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Please enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b & a > c)
            {
                Console.WriteLine("a is the gratest number");

            }

            else if (b > a & b > c)

            {
                Console.WriteLine("b is the gratest number");

            }

            else if (c > a & c > b)

            {
                Console.WriteLine("c is the gratest number");
                Console.ReadLine();


            }


        }

    }
}




