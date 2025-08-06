using EmployDetailes.Employee_Project.EmployeLogin;
using EmployDetailes.Employee_Project.LeaveData;
using EmployDetailes.Leave_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployDetailes
{
    public class EmployeeMenu
    {
        public static void Menu()
        {
            int x = 30;
            int y = 10;
            foreach(
                char c in "Welcome to the Employee Management System")
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(c);
                x++;
                Thread.Sleep(30); 
            }
            string[] options = {
                "Join the company",
                "View details",
                "Request leave",
                "Exit"
            };
            int selectedIndex = 0;
            ConsoleKey key;
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("Use UP and DOWN arrows to navigate and Enter to select:\n");
            int menuTop = Console.CursorTop;
            do
            {
                Console.SetCursorPosition(30, menuTop);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(30, menuTop + i);
                    Console.ForegroundColor = i == selectedIndex ? ConsoleColor.Red : ConsoleColor.Yellow;
                    string prefix = i == selectedIndex ? "→ " : "  ";
                    string paddedText = prefix + options[i] + new string(' ', Console.WindowWidth - prefix.Length - options[i].Length);
                    Console.Write(paddedText);
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
            Console.Clear();
            while (key != ConsoleKey.Enter) ;
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
