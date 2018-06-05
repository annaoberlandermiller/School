using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	abstract class Person  //we're setting this as a abstract class because it's our base class- it's not desiged to be used by itself
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool IsEmployee { get; set; }

		public Person(string name, string email, string phone, bool isEmployee)  //this is a constructor 
		{
			Name = name;   //we're doing this so we don't get confused
			Email = email;
			Phone = phone;
			IsEmployee = isEmployee;
		}
		public Person()     //this is a constructor 
		{

		}
	}//Because we set up these 2 parameters, when we create a new instance, we either need all 4 paramters (like in the first one) or no parameters(like the last one)
}
