using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateOnly RequiredDate { get; set; }
        public DateOnly OrderDate { get; set; }
        public string ShipName { get; set; }
        public DateOnly? ShipDate { get; set; }
        public int Freight { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

    }
}
