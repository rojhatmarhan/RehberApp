using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        //Rehberin birden fazla detayı olabilir.
        public ICollection<Detail> Details { get; set; }
    }
}
