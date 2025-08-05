using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployDetailes.NewFolder
{
    public class EmpLogin
    {
        public static string Id(string Empid)
        {
            int id;
            bool isid = int.TryParse(Empid, out id);
            if (!isid)
            {
                Console.WriteLine("EMP ID cannot be empty or EMP ID connot be alphabet");
                return Id(Console.ReadLine());
            }
            if (id == 0)
            {
                Console.WriteLine("Enter valid id");
                return Id(Console.ReadLine());
            }
            return Empid;
        }
        public static string Name(string Empname)
        {
            return Empname;
        }
        public static string Age(string Empage)
        {
            int Ages;
            bool isage = int.TryParse(Empage, out Ages);
            if (!isage)
            {
                Console.WriteLine("ENTER VALID INTEGER");
                return Age(Console.ReadLine());
            }
            if (Ages == 0 || Ages > 100)
            {
                Console.WriteLine("Enter valid age!");
                return Age(Console.ReadLine());
            }
            return Empage;
        } 
    }
}
