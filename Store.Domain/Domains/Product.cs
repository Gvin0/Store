using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
    public class Product {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "money"), Required]
        public decimal Price { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        public int Quantity { get; set; }

        public virtual ProductTemplate ProductTemplate { get; set; }

        public virtual ICollection<ProductList> WishLists { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual ICollection<RelatedProducts> RelatedProducts { get; set; }
    }
}
