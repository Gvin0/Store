using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
	public class CartProduct {
		public int ID { get; set; }
		public int Quantity { get; set; }
		public virtual Product Product { get; set; }
		public virtual Cart Cart { get; set; }
	}
}
