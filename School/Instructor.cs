using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Instructor : Employee
	{
		public string Technology { get; set; }
		public bool TeachBootcamps { get; set; } = false; //We're setting the default answer to false 
														  //we could do this in the constructor instead, but this is easier to read
														  //If you want the "default" to be set depending on other factors you'll want to put it in the constructor instead
		
		public Instructor(string name, string email, string phone, string title, decimal salary, string technology) :
			base(name, email, phone, title, salary)
		{
			Technology = technology;
		}

		public Instructor()
		{

		}
	}
}
