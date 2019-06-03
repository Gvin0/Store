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

        [MaxLength(50)]
        public string Title { get; set; }

        public virtual ProductTemplate ProductTemplate { get; set; }

        public virtual Property Property { get; set; }
    }
}
