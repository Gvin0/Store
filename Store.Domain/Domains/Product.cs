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
        public string ProductName { get; set; }

        [Column(TypeName ="money"),Required]
        public string Price { get; set; }

        [Required, MaxLength(200)]
        public string ProductDescription { get; set; }

        public virtual ProductType ProductTypes { get; set; }

        public virtual ICollection<FeatureValue> FeatureValues { get; set; }

    }
}
