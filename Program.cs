using System;

namespace Speed
{
    class Program
    {
        static string CheckSpeed(double speed)
        {
            // YOUR CODE HERE
            if (speed > 65)
            {
                return "too fast";
            }
            else if (speed < 45)
            {
                return "too slow";
            }
            else
            {
                return "speed OK";
            }
        }

        static void Main(string[] args)
        {
            // This should print "too slow".
            Console.WriteLine(CheckSpeed(44));
            // This should print "too fast".
            Console.WriteLine(CheckSpeed(88));
            // This should print "speed OK".
            Console.WriteLine(CheckSpeed(55));
        }
    }
}
