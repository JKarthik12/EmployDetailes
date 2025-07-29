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
        public void CheckData()
        {

            string Data = File.ReadAllText(@"C:\Users\VSOFT\source\repos\EmployDetailes\EmployDetailes\DataBase.json");
            Data d = JsonConvert.DeserializeObject<Data>(Data);

            //Console.WriteLine(datamodal[0]);
            string EmpId = EmpLogin.Id(Console.ReadLine());
            foreach (var item in d.Values)
            {
                if (EmpId == item.Id)
                {
                    Console.WriteLine("Name: " + item.Name + "\n" + "Age : " + item.Age);
                }
                
            }
        }
    }
}