using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAS.WebApp.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string CodeDiscount { get; set; }
		public Product()
		{

		}

		public void Show()
		{
			Console.WriteLine("Giam gia 50%");
		}
	}
}
