using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entitites.Concrete
{
    public class Customer : User
    {
        public int UserId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        [JsonIgnore]
        public string City { get; set; }
    }
}
