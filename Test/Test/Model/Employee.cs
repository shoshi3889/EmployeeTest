using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test
{
    public class Employee
    {
      
        public string Id { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
        [JsonExtensionData]
        public Dictionary<string, JToken> AdditionalDetails { get; set; } = new Dictionary<string, JToken> { };
    }


}
