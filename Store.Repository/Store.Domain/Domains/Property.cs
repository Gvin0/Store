using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
	public class Property {
		[Key]
		public int ID { get; set; }

		[Required, MaxLength(50)]
		public string Title { get; set; }

		[Required]
		public DataType Type { get; set; }

		public virtual ICollection<Category> Categories { get; set; }

		public virtual ICollection<TemplateProperty> TemplateProperties { get; set; }
	}

	public enum DataType {
		Text = 0,
		Number = 1,
		Date = 2,
		DateTime = 3,
		YesNo = 4
	}
}
