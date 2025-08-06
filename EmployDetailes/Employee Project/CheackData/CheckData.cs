using EmployDetailes.NewFolder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployDetailes.Leave_Management
{
    public class CheckDetails
    {
        public bool ispresent = false;
        public void CheckData()
        {
            Data dd = new Data();
            string raw = Environment.GetEnvironmentVariable("EmpRaw");
            string path = raw;
            string Data = File.ReadAllText(path);
            Data d = JsonConvert.DeserializeObject<Data>(Data);
            string EmpId = EmpLogin.Id(Console.ReadLine());
            foreach (var item in d.Values)
            {
                if (EmpId == item.Id)
                {
                    ispresent = true;
                    Console.WriteLine("Name: " + item.Name + "\n" + "Age : " + item.Age);
                    Console.WriteLine("Press any key to Visit Menu agin...");
                    Console.ReadKey();
                    Console.Clear();
                    EmployeeMenu.Menu();
                }
                
            }
            if(!ispresent)
            {
                Console.WriteLine("Enter valid ID");
                CheckData();
            }
        }
    }
}