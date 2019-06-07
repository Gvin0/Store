using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Domains {
	public abstract class ProductList {

		public int ID { get; set; }

		public virtual User User { get; set; }
	}

	public class WishList : ProductList {
		public string Title { get; set; }
		
		public virtual ICollection<Product> Products { get; set; }
	}

	public class Cart : ProductList {
		public virtual ICollection<CartProduct> Products { get; set; }
	}
}
