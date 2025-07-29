using EmployDetailes.NewFolder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployDetailes.Employee_Project.EmployeLogin
{
    internal class Logindata
    {
        public void login()
        {
            Data dd = new Data();
            //List<Data> modal = new List<Data>(); 
            //string Data = File.ReadAllText(@"C:\Users\VSOFT\source\repos\EmployDetailes\EmployDetailes\Employee Project\EmployeLogin\Json1.json");

            if (File.Exists(@"C:\Users\VSOFT\source\repos\EmployDetailes\EmployDetailes\DataBase.json"))
            {
                string data = File.ReadAllText(@"C:\Users\VSOFT\source\repos\EmployDetailes\EmployDetailes\DataBase.json");

                //List<Datamodal> datamodal = JsonConvert.DeserializeObject<List<Datamodal>>(Data);
                dd = JsonConvert.DeserializeObject<Data>(data);
            }
            db v = new db();

            Console.WriteLine(dd.inputs.EmpId);
            v.Id = EmpLogin.Id(Console.ReadLine());

            Console.WriteLine(dd.inputs.EmpName);
            v.Name = EmpLogin.Name(Console.ReadLine());

            Console.WriteLine(dd.inputs.EmpAge);
            v.Age = EmpLogin.Age(Console.ReadLine());

            DateTime dt = DateTime.Now;
            Console.WriteLine("uploding date and time is : " + dt);
            Console.WriteLine("ID is : " + v.Id + "\n" + "name is : " + v.Name + "\n" + "age is : " + v.Age);

            Console.WriteLine("congrats your data is uploded");
            String Datamodale;

            var Jsonloc = @"C:\Users\VSOFT\source\repos\EmployDetailes\EmployDetailes\DataBase.json";
            //List<db> dbs = new List<db>();
            //List<Data> dbs = new List<Data>();
            if (File.Exists(Jsonloc))
            {
                Datamodale = File.ReadAllText(Jsonloc);
                dd = JsonConvert.DeserializeObject<Data>(Datamodale);
            }
            else
            {
                Console.WriteLine("re enter");
            }



            dd.Values.Add(v);
            String finl = JsonConvert.SerializeObject(dd, Formatting.Indented);
            File.WriteAllText(Jsonloc, finl);
            Console.WriteLine("Pleaas do not forget your ID");
        }
    }
}
