using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	abstract class Employee : Person //we're making this abstract because we're just making this to group/access all the "child" classes that we're creating later
	{
		public int EmployeeId { get; set; }
		public decimal Salary { get; private set; }  //setting set to private so that we can only change in this class
		public string Title { get; set; }

		public void SetSalary(decimal NewSalary)
		{
			if(NewSalary < 0) {
				throw new ApplicationException("Salary must be positive");  //This is an exception
			}
			Salary = NewSalary;
		}

		public Employee(string name, string email, string phone, string title, decimal salary) //we're leaving out isEmployee because we know they're an employee
			: base(name, email, phone, true) //putting true here is forcing this as the value of is employee (remember, the parameters above is what is required to iniate)
		{
			SetSalary(salary);
			Title = title;
		}

		public Employee() //ALWAYS include the default constructor! The automatic one we had will disappear when we create our first constructor (the one above)
		{				// PROTIP:  Create this before you create your other ones

		}

	}
}
