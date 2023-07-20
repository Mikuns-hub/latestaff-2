using System;

namespace lateStaff
{
    public class Program
    {
        static void Main(string[] args)
        {
            var office = new Office();
            office.GetStaffById(0);

            Console.WriteLine("Enter the letter below:\n");

            Console.WriteLine("L: To Log staff arrrival");
            Console.WriteLine("R: To retrieve staff arrival\n");

            var userinput = Console.ReadLine();

            switch (userinput)
            {
                case "L":
                    Console.WriteLine("Enter staff ID:");
                    Console.ReadLine();
                    break;

                case "R":
                    Console.WriteLine("Enter Arrival time:");
                    Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Staff ID dose not exist");
                    break;


            }
        }
    }
}

