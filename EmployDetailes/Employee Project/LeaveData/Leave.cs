using EmployDetailes.NewFolder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployDetailes.Employee_Project.LeaveData
{
    internal class Leave
    {
        public void RequesrLeave()
        {
            Data ll = new Data();

            leaveDb leaveDb = new leaveDb();
            string? raw = Environment.GetEnvironmentVariable("EmpRaw");
            string path = raw ?? "default";
            string Data = File.ReadAllText(path);
            Data? l = JsonConvert.DeserializeObject<Data>(Data);
            string EmpId = EmpLogin.Id(Console.ReadLine());

            foreach (var item in l.Values)
            {
                if (EmpId == item.Id)
                {
                    Console.WriteLine("Enter the reason");
                     leaveDb.reason = Console.ReadLine();
                     leaveDb.Id = item.Id;
                }
            }
            String Datamodale;
            var Jsonloc = path;
            if (File.Exists(Jsonloc))
            {
                Datamodale = File.ReadAllText(Jsonloc);
                ll = JsonConvert.DeserializeObject<Data>(Datamodale);
            }
            else
            {
                Console.WriteLine("re enter");
            }

            ll.leave.Add(leaveDb);
            String leaveData = JsonConvert.SerializeObject(ll, Formatting.Indented);
            File.WriteAllText(Jsonloc, leaveData);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            EmployeeMenu.Run();
        }

    }
}
