using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cancel = false;
            while(cancel == false)
            {
                Console.WriteLine("Hello please input the length of the classroom: ");
                string value = Console.ReadLine();
                double length = double.Parse(value);
                Console.WriteLine("Now what is the width: ");
                string input = Console.ReadLine();
                double width = double.Parse(input);

                double area = length * width;
                double perimeter = (length * 2) + (width * 2);

                Console.WriteLine($"The area of the room is {area}");
                Console.WriteLine($"The perimeter of the room is {perimeter}");

                double paint = (perimeter / 5);
                double carpet = (area / 5) / 5;

                Console.WriteLine($"The amount of cans of paint needed it {paint}");
                Console.WriteLine($"The amount of carpet needed it {carpet}");

                double volume = ((perimeter / 4) * length * width);

                Console.WriteLine($"The volume of the room is {volume}");




                bool another = false;
                while(another == false)
                {
                    Console.WriteLine("Would like to measure another classroom? (Y/N) ");
                    string again = Console.ReadLine();
                    if (again.ToLower() == "y" || again.ToLower().Contains("yes"))
                    {
                        Console.WriteLine("Again we go.");
                        another = true;
                        cancel = false;
                    }
                    else if (again.ToLower() == "n" || again.ToLower().Contains("no"))
                    {
                        Console.WriteLine("Goodbye.");
                        cancel = true;
                        another = true;
                    }
                    else
                    {
                        Console.WriteLine("Please input 'y' or 'n' ");
                        another = false;
                    }
                }
                


            }
        }
    }
}
