using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur !")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Bu alan zorunludur !")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur !")]
        public string Phone { get; set; }

        //Rehberin birden fazla detayı olabilir.
        public ICollection<Detail> Details { get; set; }
    }
}
