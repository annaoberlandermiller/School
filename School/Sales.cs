using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Sales : Employee
	{
		public decimal TotalSales { get; set; }
		public string Region { get; set; }
		public decimal Quota { get; set;}

		public Sales(string name, string email, string phone, string title, decimal salary, string region, decimal quota) :
			base(name, email, phone, title, salary)
		{
			Region = region;
			Quota = quota;
			TotalSales = 0;
		}
		public Sales() { } //remember:  keep inside the class
	}
	
	
}
