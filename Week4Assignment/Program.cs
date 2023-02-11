/* 
    *  Author: Eduardo Alcala
    *  Course: COMP-003A
    *  Purpose: Code for Assignment 4
    */

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.WriteLine("Enter a whole postive number: ");

            int limit = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= limit; i++) ;
            {

            }



            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all friends in an array");
            Console.WriteLine("".PadRight(50, '*'));


            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (var friend in friends)
            {
                Console.WriteLine($"{friend}");

            }


            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5's");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;

            do
            {
                Console.WriteLine($"\t {counter}");
                counter += 5;
            } while (counter <= 50);


            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisble by 2, output Foo");
            Console.WriteLine("If the number is divisble by 5, output Bar");
            Console.WriteLine("If the number is divisble by both 2 and 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));



            int counter2 = 1;

            while (counter2 <= 20)
            {

                if (counter2 % 2 == 0)
                { Console.WriteLine("Foo");

                if (counter2 % 5 == 0)
                    { Console.WriteLine("Bar"); }

                if ((counter2 % 2 == 0) || (counter2 % 5 == 0))
                    { Console.WriteLine("FooBar"); }


              else
                    {
                        Console.WriteLine($"{counter2}");


                    }

                }

                counter2++;
            }
        }
    }
}
