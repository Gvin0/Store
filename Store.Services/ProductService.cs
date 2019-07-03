using Store.Domain.Domains;
using Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public class ProductService : BaseService<Product, IProductRepository>, IProductService
    {
        
        public ProductService(IProductRepository productRepository) : base (productRepository)
        {
            
        }
    }
}
