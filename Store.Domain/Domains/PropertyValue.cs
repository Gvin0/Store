using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
   public class PropertyValue {
        [Key]
        public int ID { get; set; }

        public bool BooleanValue { get; set; }

        public DateTime DateValue { get; set; }

        public int NumberValue { get; set; }

        public string TextValue { get; set; }

        public virtual Product Product { get; set; }

        public virtual TemplateProperty TemplateProperty { get; set; }
    }
}
