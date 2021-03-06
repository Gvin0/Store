﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Repository;

namespace Store.Test {
	public class Program {
		static void Main(string[] args) {
			List<Category> list = new List<Category>();

			Category category = new Category() {
				Name = "Computer Tech."
			};
			list.Add(category);
			ProductTemplate productTemplate = new ProductTemplate() {
				Name = "PC",
				Categories = list
			};
			Property property = new Property() {
				Title = "Brand Name",
				Type = 0
			};
			TemplateProperty templateProperty = new TemplateProperty() {
				ProductTemplate = productTemplate,
				Property = property
			};
			Product product = new Product() {
				Name = "G05_PC",
				Price = 1600.99m,
				Description = "Only the best PC builds",
				Quantity = 8,
				ProductTemplate = productTemplate
			};
			PropertyValue propertyValue = new PropertyValue() {
				TextValue = "G05",
				Product = product,
				TemplateProperty = templateProperty
			};
			StoreDbContext storeDbContext = new StoreDbContext();

			CategoryRepository c = new CategoryRepository(storeDbContext);

			c.Save(category);
			//c.Commit();
			Console.ReadKey();
		}
	}
}
