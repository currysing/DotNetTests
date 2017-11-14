using CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
	public delegate void SomeFunction(out string s);


	public partial class Form1 : Form
	{
		List<Employee> _employees;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Interface
			////////////////////////////////////////////////////////////
			Order order = new Order() { DatePlaced = DateTime.Now, TotalPrice = 100f };

			OrderProcessor processor = new OrderProcessor(new ShipmentCalculator());

			processor.Process(order);

			///////////////////////////////////////////////////////////

			////Delegate
			////////////////////////////////////////////////////////////
			//_employees = Employees.ReturnSampleEmployeeList();

			//SomeFunction Fn = new SomeFunction(Hello);
			//string outvalue = "somevalue";
			//Fn(out outvalue);
			//WriteToTxtBox(outvalue);

			////IsPromotable isPromo = new IsPromotable(PromotionFunction);
			////Employee.Promotion(Employees, isPromo);
			//Employee.Promotion(_employees, emp => emp.YearExperience > 10);

			//IterateEmployees(_employees);
			////////////////////////////////////////////////////////////
		}

		private void Hello(out string s)
		{
			s = "Heeelo Delegate";
		}


		void IterateEmployees(List<Employee> eList)
		{
			foreach (Employee e in eList)
			{
				//WriteToTxtBox(e.Name + " - " + e.Salary.ToString());
				WriteToTxtBox(e.ToString());
			}
		}


		void WriteToTxtBox(string s)
		{
			txtTextbox.Text += "\r\n" + s;
		}

	}


}
