using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Operations : Employee
	{
		public int MyProperty { get; set; }

		public Operations(string name, string email, string phone, string title, decimal salary) :
			base(name, email, phone, title, salary)
		{
			
		}

		public Operations() { }
	}
}
