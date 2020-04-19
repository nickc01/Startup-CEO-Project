using MetroFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Startup_CEO_Project
{
	//Represents an employee that is working for the company
	[JsonObject(MemberSerialization.Fields)]
	public class Employee
	{
		//The list of all added employees
		static List<Employee> Employees = new List<Employee>();

		string name; //The name of the employee
		double salary; //The salary of the employee
		uint yearsWorked; //How many years the employe has worked at the company
		uint age; //The age of the employee

		//The default constructor that sets default values to the fields
		public Employee()
		{
			name = "";
			salary = 0.0f;
			yearsWorked = 0;
			age = 0;
		}

		//The constructor that sets the fields the parameters specified
		public Employee(string Name, double Salary, uint YearsWorked,uint Age)
		{
			name = Name;
			salary = Salary;
			yearsWorked = YearsWorked;
			age = Age;
		}

		//The constructor that takes the parameters in string form, and then parses them into the field types
		public Employee(string Name, string Salary, string YearsWorked, string Age)
		{
			//If the name is not set
			if (Name == null || Name == "")
			{
				//Throw an error
				throw new ArgumentException("The employee's name has not been specified");
			}
			//If the years worked is not set
			if (YearsWorked == null || YearsWorked == "")
			{
				//Throw an error
				throw new ArgumentException("The amount of years worked has not been specified");
			}
			//If the age is not set
			if (Age == null || Age == "")
			{
				//Throw an error
				throw new ArgumentException("The employee's age has not been specified");
			}
			//If the salary is not set
			if (Salary == null || Salary == "")
			{
				//Throw an error
				throw new ArgumentException("The employee's salary has not been specified");
			}
			//Set the name
			name = Name;
			//Attempt to parse the salary into a double
			if (!double.TryParse(Salary,NumberStyles.Currency,CultureInfo.CurrentCulture,out salary))
			{
				//If the parse failed, throw an error
				throw new ArgumentException("The salary is not a valid decimal number");
			}
			if (!uint.TryParse(YearsWorked,out yearsWorked))
			{
				//If the parse failed, throw an error
				throw new ArgumentException("The years worked is not a valid positive integer");
			}
			if (!uint.TryParse(Age,out age))
			{
				//If the parse failed, throw an error
				throw new ArgumentException("The age is not a valid positive integer");
			}
		}

		/// <summary>
		/// Gets the name of the employee
		/// </summary>
		/// <returns>The employee's age</returns>
		public string GetName()
		{
			return name;
		}

		/// <summary>
		/// Sets the name of the employee
		/// </summary>
		/// <param name="newName">The new name</param>
		public void SetName(string newName)
		{
			name = newName;
		}

		/// <summary>
		/// Gets the salary of the employee
		/// </summary>
		/// <returns>The employee's salary</returns>
		public double GetSalary()
		{
			return salary;
		}

		/// <summary>
		/// Sets the salary of the employee
		/// </summary>
		/// <param name="newSalary">The new salary</param>
		public void SetSalary(double newSalary)
		{
			salary = newSalary;
		}

		/// <summary>
		/// Gets the amount of years the employee worked
		/// </summary>
		/// <returns>The years worked</returns>
		public uint GetYearsWorked()
		{
			return yearsWorked;
		}

		/// <summary>
		/// Sets the amount of years the employee worked
		/// </summary>
		/// <param name="newYearsWorked">The new amount of years worked</param>
		public void SetYearsWorked(uint newYearsWorked)
		{
			yearsWorked = newYearsWorked;
		}

		/// <summary>
		/// Gets the age of the employee
		/// </summary>
		/// <returns>The employee's age</returns>
		public uint GetAge()
		{
			return age;
		}

		/// <summary>
		/// Sets the age of the employee
		/// </summary>
		/// <param name="newAge">The new age of the employee</param>
		public void SetAge(uint newAge)
		{
			age = newAge;
		}

		/// <summary>
		/// Adds the Employee to the list of employees in the main form
		/// </summary>
		public void AddToList()
		{
			//Add the employee to the list
			Employees.Add(this);
			//Add the employee as a new row to the employee grid
			AddRow(this);
		}

		/// <summary>
		/// Adds an employee to the employee grid
		/// </summary>
		/// <param name="employee">The employee to add</param>
		static void AddRow(Employee employee)
		{
			//Adds a new row to the employee grid with the employee's information
			StartupCEOForm.Instance.employeesGrid.Rows.Add(employee.name, employee.age, employee.yearsWorked, employee.salary.ToString("C"));
		}

		/// <summary>
		/// Removes the employee from the list of employees in the main form
		/// </summary>
		public void RemoveFromList()
		{
			//Get the index of the employee and remove it
			RemoveEmployee(Employees.IndexOf(this));
		}

		/// <summary>
		/// Removes the employee from the list of employees in the main form
		/// </summary>
		/// <param name="index">The index of where the employee is located</param>
		public static void RemoveEmployee(int index)
		{
			//Remove the employee at the specified index
			Employees.RemoveAt(index);

			//Remove the employee row from the employee grid
			StartupCEOForm.Instance.employeesGrid.Rows.RemoveAt(index);
		}

		/// <summary>
		/// Gets the amount of employees in the employee list
		/// </summary>
		/// <returns>The employee count</returns>
		public static int EmployeesAdded()
		{
			return Employees.Count;
		}

		/// <summary>
		/// Clears the entire employee list
		/// </summary>
		public static void Clear()
		{
			//Clear the employee list
			Employees.Clear();

			//Remove all rows from the employee grid
			StartupCEOForm.Instance.employeesGrid.Rows.Clear();
		}

		/// <summary>
		/// Gets an employee from the employee list at the specified index
		/// </summary>
		/// <param name="index">The index of where the employee is located in the list</param>
		/// /// <returns>The employee at the index</returns>
		public static Employee GetEmployeeInList(int index)
		{
			return Employees[index];
		}

		/// <summary>
		/// Saves the list of employees to a file
		/// </summary>
		public static void Save()
		{
			//Create the save file dialog that will allow us to save the results to a specified file
			//Reference: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog?view=netframework-4.8
			var saveDialog = new SaveFileDialog();

			//Set the dialog's filter to only accept either text files, or any custom format
			saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			//Set the default filter to be text files
			saveDialog.FilterIndex = 2;
			//Set the title of the save dialog box
			saveDialog.Title = "Specify where you want to store the employees";
			//Set the default filename
			saveDialog.FileName = "Employees";
			//Set the default file extension
			saveDialog.DefaultExt = "txt";

			//Show the dialog, wait for the user to make a selection, and retrieve the save results
			DialogResult saveResult = saveDialog.ShowDialog();

			//If the user selected a file to save to
			if (saveResult == DialogResult.OK)
			{
				//Open the file to save to. If the file does not exist yet, then create it
				using (Stream fileStream = saveDialog.OpenFile())
				{
					//Create a writer that can write text to the opened file
					using (var writer = new StreamWriter(fileStream))
					{
						//Use Newtonsoft.Json to conver the Employee into a Json string
						//Then, write the string to the file
						writer.Write(JsonConvert.SerializeObject(Employees,Formatting.Indented));
					}
				}
			}
		}

		/// <summary>
		/// Loads a list of employees from a file
		/// </summary>
		public static void Load()
		{
			var loadDialog = new OpenFileDialog();

			//Set the dialog's filter to only accept either text files, or any custom format
			loadDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			//Set the default filter to be text files
			loadDialog.FilterIndex = 2;
			//Set the title of the save dialog box
			loadDialog.Title = "Specify the file to load the employees from";
			//Set the default filename
			loadDialog.FileName = "Employees";
			//Set the default file extension
			loadDialog.DefaultExt = "txt";

			//Show the dialog, wait for the user to make a selection, and retrieve the save results
			DialogResult loadResult = loadDialog.ShowDialog();

			if (loadResult == DialogResult.OK)
			{
				//Open the file to save to. If the file does not exist yet, then create it
				using (Stream fileStream = loadDialog.OpenFile())
				{
					//Create a reader that reads from the stream
					using (StreamReader reader = new StreamReader(fileStream))
					{
						try
						{
							//Clear the employee list
							Clear();

							//Read the json string from the input file, convert back into a list of employees, and set the employee list
							Employees = JsonConvert.DeserializeObject<List<Employee>>(reader.ReadToEnd());

							//Loop over all the employees in the list
							foreach (var employee in Employees)
							{
								//Create a row for each of them
								AddRow(employee);
							}
						}
						//If an error occured
						catch (Exception e)
						{
							//Display a messagebox
							MetroMessageBox.Show(StartupCEOForm.Instance, "This file was unable to load. It may have corrupted data", "Error Loading Employees");
						}
					}
				}
			}
		}
	}
}
