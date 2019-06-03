using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Repository;

namespace Store.Test {
    public class Program {
        static void Main(string[] args) {
            Category category = new Category() { Name = "Computer parts and accessories" };

            ProductTemplate productTemplate = new ProductTemplate() { Name = "PC" };

            Property property = new Property() {
                Title = "RAM"
            };

            TemplateProperty templateProperty = new TemplateProperty() {
                ProductTemplate = productTemplate,
                Property = property,
                Title = "512Mb"
            };

            Product product = new Product() {
                ProductTemplate = productTemplate,
                Name = "PC",
                Description = "G05-PC V1",
                Price = "1600",
                Quantity = "10"
            };

            PropertyValue propertyValue = new PropertyValue() {
                Product = product,
                TemplateProperty = templateProperty,
                TextValue = templateProperty.Title
            };
            

            Console.ReadKey();
        }
    }
}
