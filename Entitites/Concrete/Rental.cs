using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entitites.Concrete
{
    public class Rental:IEntity
    {
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        [JsonIgnore]
        public Car? Car { get; set; }
        public Customer? Customer { get; set; }

    }
}
