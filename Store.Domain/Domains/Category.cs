using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
    public class Category {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [ForeignKey("Parent")]
        public int ParentId { get; set; }

        public virtual Category Parent { get; set; }

        public virtual ICollection<Property> Properties { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
