using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommonClasses;


namespace WpfApp1
{
	/// <summary>
	/// MainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class MainWindow : Window
	{
		DelegateFormatName delegateFN;
		Func<Employee, string> delegateFunc;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnButton1_Click(object sender, RoutedEventArgs e)
		{
			var emp = Employees.ReturnSampleEmployeeList();

			//this will return the override version of the ToString()
			//ListBox1.ItemsSource = Employees.ReturnSampleEmployeeList();

			//this will return the delegate version of the ToString()
			//delegateFN = FormatName;
			delegateFunc = FormatName;
			foreach (var _emp in emp)
			{
				//ListBox1.Items.Add(_emp.ToString(delegateFN));
				//ListBox1.Items.Add(_emp.ToStringUseFunc(delegateFunc));
				ListBox1.Items.Add(_emp.ToStringUseFunc(木=> 木.Name));
			}
			
		}

		private string FormatName(Employee e)
		{
			return e.Name;
		}
	}
}
