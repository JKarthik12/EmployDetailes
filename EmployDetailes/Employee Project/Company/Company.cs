using EmployDetailes.Leave_Management;
using EmployDetailes.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployDetailes.Company
{
    public class Company
    {
        public static void Main(string[] args)
        {
            //Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("1.join the company");
            Console.WriteLine("2.viwe detalis");
            Console.WriteLine("3.Request leave");
            String intput;
            
            EmpLogin log = new EmpLogin();
            CheckDetails Chkdata = new CheckDetails();

            int c;
            c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1:
                    Console.WriteLine("Well come to the company");
                    log.login();
                    break;
                case 2:
                    Console.WriteLine("enter Id to view the detalis");
                    Chkdata.CheckData();
                    break;
                case 3:
                    Console.WriteLine("Ask a leave");
                    break;
            }
        }
    }
}
