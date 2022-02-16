using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }

        public string Adress1 { get; set; }

        public string? Adress2 { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }


        //Birden fazla detay bir rehbere bağlı olabilir.
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
