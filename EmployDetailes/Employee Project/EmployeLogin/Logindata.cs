using EmployDetailes.NewFolder;
using Newtonsoft.Json;

namespace EmployDetailes.Employee_Project.EmployeLogin
{
    internal class Logindata
    {
        public void login()
        {
            Data dd = new Data();
            string? raw = Environment.GetEnvironmentVariable("EmpRaw");
            string value = raw ?? "default";

            if (File.Exists(value))
            {
                string data = File.ReadAllText(value);
                dd = JsonConvert.DeserializeObject<Data>(data);
            }

            Db v = new Db();

            int newEmpId = 1;
            if (dd.Values != null && dd.Values.Count > 0)
            {
                newEmpId = dd.Values.Max(emp => int.TryParse(emp.Id, out var id) ? id : 0) + 1;
            }
            v.Id = newEmpId.ToString();

            Console.WriteLine("Generated Employee ID: " + v.Id);

            Console.WriteLine(dd.inputs.EmpName);
            v.Name = EmpLogin.Name(Console.ReadLine());

            Console.WriteLine(dd.inputs.EmpAge);
            v.Age = EmpLogin.DOB(Console.ReadLine());

            DateTime dt = DateTime.Now;
            Console.WriteLine("Uploading date and time: " + dt);
            Console.WriteLine("ID: " + v.Id + "\nName: " + v.Name + "\nAge: " + v.Age);
            Console.WriteLine("Congrats, your data has been uploaded.");
            string Jsonloc = value;
            string Datamodale;
            if (File.Exists(Jsonloc))
            {
                Datamodale = File.ReadAllText(Jsonloc);
                dd = JsonConvert.DeserializeObject<Data>(Datamodale);
            }
            else
            {
                Console.WriteLine("Re-enter your data.");
            }
            dd.Values.Add(v);
            string final = JsonConvert.SerializeObject(dd, Formatting.Indented);
            File.WriteAllText(Jsonloc, final);
            Console.WriteLine("Please do not forget your Employee ID!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            EmployeeMenu.Menu();
        }
    }
}
