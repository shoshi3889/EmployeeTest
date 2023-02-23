using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Test
{
    static class DemoDB
    {
        public static List<Employee> loadData()
        {
            if (File.Exists(@"..\..\..\json1.json"))
            {
                String JSON = File.ReadAllText(@"..\..\..\json1.json");
                List<Employee> model = JsonConvert.DeserializeObject<List<Employee>>(JSON);
                return model;
                
            }
            return new List<Employee>();
        }
    }
}
