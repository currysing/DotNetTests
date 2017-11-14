using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
	public delegate bool DelegateIsPromotable(Employee emp);
	public delegate string DelegateFormatName(Employee emp);


	public static class Employees
	{
		public static List<Employee> ReturnSampleEmployeeList()
		{
			var Employees = new List<Employee>();
			Employees.Add(new Employee { ID = 1, YearExperience = 10, Name = "User1", Salary = 10000, StartDate = new DateTime(2010, 10, 01) });
			Employees.Add(new Employee { ID = 2, YearExperience = 15, Name = "User2", Salary = 15000, StartDate = new DateTime(2005, 9, 01) });
			Employees.Add(new Employee { ID = 3, YearExperience = 19, Name = "User3", Salary = 16000, StartDate = new DateTime(2009, 11, 01) });
			Employees.Add(new Employee { ID = 4, YearExperience = 25, Name = "User4", Salary = 25000, StartDate = new DateTime(2001, 1, 01) });

			return Employees;
		}
	}


	public class Employee
	{
		public int ID;
		public int YearExperience;
		public string Name;
		public int Salary;
		public DateTime StartDate;

		public static void Promotion(List<Employee> Employees)
		{
			foreach (var e in Employees)
			{
				// generalize the promotion logic
				if (e.YearExperience > 10)
				{ e.Salary += 1000; };
			}
		}

		//the following take in a delegate function
		public static void Promotion(List<Employee> Employees, DelegateIsPromotable delegFn)
		{
			foreach (var e in Employees)
			{
				// generalize the promotion logic
				if (delegFn(e))
				{
					e.Salary += 1000;
				};
			}
		}


		//public static void Promotion(List<Employee> Employees, Delegates.EmployeeDelegates.IsPromotable2 delegFn)
		//{
		//	foreach (var e in Employees)
		//	{
		//		// generalize the promotion logic
		//		if (delegFn(e))
		//		{
		//			e.Salary += 1000;

		//		};
		//	}
		//}

			
		public string ToStringUseFunc(Func<Employee, string> format)
		{
			if (format != null)
				return format(this);
			return this.ToString();
		}

		public string ToString(DelegateFormatName format)
		{
			if (format != null)
				return format(this);
			return this.ToString();
		}

		public override string ToString()
		{
			return string.Format("{0} - ({1})", Name, StartDate);
		}
	}
}
