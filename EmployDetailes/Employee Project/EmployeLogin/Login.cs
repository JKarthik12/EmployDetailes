using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

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
                Console.WriteLine("EMP ID cannot be empty or EMP ID cannot be alphabet");
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

        public static string DOB(string EmpDOB)
        {
            // Accepting format as yyyy-MM-dd
            DateTime dob;
            bool isValid = DateTime.TryParseExact(EmpDOB, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dob);

            if (!isValid)
            {
                Console.WriteLine("Invalid date format. Please use yyyy-MM-dd (e.g., 1990-05-25).");
                return DOB(Console.ReadLine());
            }

            // Optional: prevent future dates
            if (dob > DateTime.Today)
            {
                Console.WriteLine("DOB cannot be in the future. Please enter a valid date.");
                return DOB(Console.ReadLine());
            }

            return dob.ToString("yyyy-MM-dd");
        }
    }
}
