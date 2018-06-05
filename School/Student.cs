using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Student : Person
	{
		private static int nextID = 1; // It's static because we don't want 2 students to have the same ID.

		public bool IsVet { get; set; } = false; //this is setting false as the default
		public int StudentId { get; set; }
		public double GPA { get; set; }

		public Student(string name, string email, string phone, bool isEmployee, bool isVet, double gpa)   // The parameters are saying to initalize/create a new student this is the data that is required. we're accessing these from the Person class.  
			: base(name, email, phone, isEmployee)  //this is saying let the person constuctor initialize these
		{
			IsVet = isVet; //these are the parameters that are not in base class construtor
			GPA = gpa;
		}
		public Student() { }
	}
}
