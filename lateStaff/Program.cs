using System;

namespace lateStaff
{
    public class Program
    {
        static void Main(string[] args)
        {
            var office = new Office();

            Console.WriteLine("Enter the letter below:\n");

            Console.WriteLine("L: To Log staff arrrival");
            Console.WriteLine("R: To retrieve staff arrival\n");

            var userinput = Console.ReadLine();

            switch (userinput)
            {
                case "L":
                    Console.WriteLine("Enter staff ID:");
                    var staffIdNumber = (Console.ReadLine());

                    bool success = int.TryParse(staffIdNumber, out var staffId);

                    if(!success)
                    {
                        Console.WriteLine("Invid StaffId");
                    }
                  
                   var gettingStaffId = office.GetStaffById(staffId);

                   if (gettingStaffId == null)
                    {
                        Console.WriteLine("Staff does not exist");
                    }
                    else
                    {
                        Console.WriteLine("Successfull");

                        office.LogArrivalTime(staffId);
                    }
                    
                    break;

                case "R":
                    Console.WriteLine("Enter Arrival time:");
                    var arrivalTime = Convert.ToDouble(Console.ReadLine());
                    break;


            }
        }
    }
}

