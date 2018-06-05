using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("Dan", "dan@a.com", "1234", false, true, 4.9);  //if you hover over the second student it will tell you what parameters are required to initalize
			Instructor i1 = new Instructor("U", "u@up.com", "9876", "Boot Camp Instructor", 10000, "CSharp");
			Sales sl1 = new Sales("Lisa", "l@l.com", "5555", "Sales", 150000, "US", 20000000);
			Operations o1 = new Operations("Larry", "la@La.com", "7777", "SuperOp", 3000000);

			sl1.TotalSales = 23000;

			List<Person> people = new List<Person>();
			people.Add(s1);
			people.Add(i1);
			people.Add(sl1);
			people.Add(o1);

			decimal totalSales = 0; //totalSales is the variable we're using in the method.  TotalSales is how we assign sales people a sales value
			foreach (Person person in people) {  //type(remember, classes are types!) variable name(unique to foreach loop) in collection(name of the list OR dictionary referencing)
				Sales sales = person as Sales;  //this is saying take each sales will be null for each person who is not in the class Sales
				if(sales != null) {
					totalSales += sales.TotalSales;
				}
			}
			Console.WriteLine($"Total sale is {totalSales}");

		}
	}
}
