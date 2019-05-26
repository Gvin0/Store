using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains
{
    public class TemplateProperty {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

        public virtual ProductTemplate ProductTemplate { get; set; }

        public virtual Property Property { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
