using System;
using EmployDetailes.Employee_Project.EmployeLogin;
using EmployDetailes.Employee_Project.LeaveData;
using EmployDetailes.Leave_Management;
using EmployDetailes.NewFolder;

namespace EmployDetailes.Company
{
    public class Company
    {
        public static void Main(string[] args)
        {
            string[] options = {
                "Join the company",
                "View details",
                "Request leave",
                "Exit"
            };

            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.WriteLine("Use UP and DOWN arrows to navigate and Enter to select:\n");

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("→ ");
                    }
                    else
                    {
                        Console.Write("  ");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.WriteLine(options[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex + 1) % options.Length;
                }

            }
            while (key != ConsoleKey.Enter);

            Console.ResetColor();
            Console.Clear();
            Logindata log = new Logindata();
            CheckDetails Chkdata = new CheckDetails();
            Leave leave = new Leave();
            switch (selectedIndex)
            {
                case 0:
                    Console.WriteLine("Welcome to the company!");
                    log.login();
                    break;
                case 1:
                    Console.WriteLine("Enter ID to view the details:");
                    Chkdata.CheckData();
                    break;
                case 2:
                    Console.WriteLine("Enter your ID to verify:");
                    leave.RequesrLeave();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    return;
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
