using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains
{
    public class FeatureValue {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FeatureValueName { get; set; }

        [Required, MaxLength(500)]
        public string FeatureValueDesc { get; set; }

        public virtual ICollection<Feature> Features { get; set; }

        public virtual ICollection<ProductType> ProductTypes { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
