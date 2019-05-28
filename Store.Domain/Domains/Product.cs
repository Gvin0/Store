using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains
{
   public class Product {
        [Key]
        public int ID { get; set; }
        
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName ="money"),Required]
        public string Price { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        public string Quantity { get; set; }

        public virtual ProductTemplate ProductTemplate { get; set; }
    }
}
