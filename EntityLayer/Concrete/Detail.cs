using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Detail
    {
        public int DetailId { get; set; }
        public List<string> Adress { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        //Her detay bir rehbere bağlıdır.
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
