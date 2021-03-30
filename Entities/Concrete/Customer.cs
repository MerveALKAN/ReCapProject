using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
    }
}
