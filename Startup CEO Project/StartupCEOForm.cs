/* 
 * Name: Nicholas Cullen
 * Date: 3/24/2020
 * Program Name: Startup Company Benefits Calcuator
 * Program Description: Allows you to calculate several employee benefits for a company, such as their Raise, their Vacation days, and their bonus
 * Estimated Total Development Time: 5 hours
 * 
 * Time Log:
 * [
 *      20 Minutes : 3/24/2020 : Initial Setup of Project
 *      1 Hour:  3/25/2020 : Designed Functions that will serve as the employee calculations, such as raise, Vacation days, and bonus
 *      1.75 Hours: 3/25/2020 : Designed the GUI and Event Functions for each UI Element
 *      45 Minutes: 3/25/2020 : Polished GUI and Code. Applied Commenting
 * ]
 * 
 * Total Hours : ~3.83 Hours
 * 
 * Notes
 * [
 *      Since this was the first GUI project I have ever made using Windows Forms, I did not have a gauge on how
 *      long it would take for me to complete this project. As a result, I ended up overestimating how long It would
 *      take me to complete it. However, I was quickly able learn the ropes of the designer interface, and I feel confident
 *      that I could design the interfaces more quickly in the future, perhaps in about 2 hours less from estimate.
 * ]
 * 
 * 
 * Credits:
 *      Icon: http://www.iconarchive.com/show/small-n-flat-icons-by-paomedia/calculator-icon.html
 *      
 *      
 */
#region Exception Handling Addon - Timelog
/*
*-----EXCEPTION HANLDING ADDON-----
* Estimated Total Development Time:: 30 Minutes
* 
* TimeLog:
* [
*      35 Minutes: 3/25/2020 : Added error checking to several functions that retrieve data from the text fields. Modified the comments to reflect the changes
* ]
* 
* Total Time Spent: 35 Minutes
* 
* Notes:
*   This wasn't a diffult thing for me to implement, mostly because both catching exceptions and using TryParse functions
*   are features that I have worked with for years.
*      
*/
#endregion



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Startup_Company_Benefits
{
    //The main form for calculating the employee benefits
	public partial class StartupCEOForm : Form
	{
		public StartupCEOForm()
		{
			InitializeComponent();
		}

        //Called when the "Clear" button is clicked
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the employee salary textbox
            EmployeeSalaryTextBox.Clear();
            //Clear the employee years worked textbox
            YearsWorkedTextbox.Clear();
            //Clear the employee age textbox
            AgeBox.Clear();
        }

        //Called when the "Calculate Raise" Menu Item is clicked
        private void calculateRaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attempt to get the years worked and the salary
            if (GetYearsWorked(out uint yearsWorked) && GetSalary(out double salary))
            {
                //Calculate the raise
                double raise = EmployeeCalculations.CalculateRaise(yearsWorked);

                //Calculate the salary with the raise applied
                double salaryWithRaise = EmployeeCalculations.CalculateSalaryWithRaise(salary, raise);

                //If we were able to get both the years worked and the salary
                //Compute the employee's raise
                double raisePercent = EmployeeCalculations.CalculateRaise(yearsWorked);

                //Shows the results of the calculation
                ResultsForm.ShowResults("Raise Results", "Raise", PercentageToString(raisePercent), "Salary With Raise", DollarAmountToString(salaryWithRaise));
            }
        }

        //Called when the "Calculate Vacation Days" Menu Item is clicked
        private void calculateVacationDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attempt to get the employee's age and store it in the "employeeAge" variable
            if (GetEmployeeAge(out uint employeeAge))
            {
                //If we are able to get the employee's age
                //Calculate the amount of vacation days the employee has
                uint vacationDays = EmployeeCalculations.CalculateVacationDays(employeeAge);

                //Show the results of the calculation
                ResultsForm.ShowResults("Vacation Days Results", "Vacation Days", vacationDays.ToString());
            }
        }

        //Called when the "Calculate Bonus" Menu Item is clicked
        private void calculateBonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attempt to get the employee's age and store it in the "employeeAge" variable
            if (GetEmployeeAge(out uint employeeAge))
            {
                //If we were able to get the employee's age
                //Calculate the employee's bonus
                double bonus = EmployeeCalculations.CalculateBonus(employeeAge);

                //Show the results of the calculation
                ResultsForm.ShowResults("Bonus Results", "Bonus", DollarAmountToString(bonus));
            }
        }


        //Gets the salary of the employee. Returns false if it was unable to retrieve it
        //This function uses the TryParse function for its error checking
        bool GetSalary(out double result)
        {
            //Attempt to parse the employee salary text into a floating-point number, and store the result in the "result" parameter
            if (double.TryParse(EmployeeSalaryTextBox.Text, NumberStyles.Currency, new CultureInfo("en-US"), out result))
            {
                //If the salary entered is negative
                if (result < 0.0)
                {
                    //Display an error that the salary shouldn't be negative
                    DisplayErrorMessage("Salary Error", "A negative salary is not valid");
                    //Return false signifying a failure
                    return false;
                }
                //If the parsing was successful, return true
                return true;
            }
            //If the parsing was not successful
            else
            {
                //Set the result to 0
                result = 0;
                //If the textbox is empty
                if (EmployeeSalaryTextBox.Text == "")
                {
                    //Display an error saying that nothing is entered
                    DisplayErrorMessage("Salary Error", "There is nothing entered for employee's salary. Please enter a number.");
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the entered text is not a number
                    DisplayErrorMessage("Salary Error", "The entered value for the employee's salary is not a valid decimal number. Please enter an decimal number and try again.");
                }
                //Return false signifying a failure
                return false;
            }
        }

        //Get the amount of years the employee worked. Returns false if it was unable to retrieve it
        //This function uses a try and catch block for its error checking
        bool GetYearsWorked(out uint output)
        {
            try
            {
                //Attempt to parse the years worked text into a positive number.
                output = uint.Parse(YearsWorkedTextbox.Text);
                //If we reached this point, then the parsing was successful, so return true
                return true;
            }
            //If an error occured during parsing
            catch (Exception)
            {
                //If the textbox is empty
                if (YearsWorkedTextbox.Text == "")
                {
                    //Display an error saying that nothing is entered
                    DisplayErrorMessage("Years Worked Error", "There is nothing entered for employee's years worked. Please enter a number.");
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the entered text is not a number
                    DisplayErrorMessage("Years Worked Error", "The entered value for years worked is not a valid integer number. Please enter an integer number and try again.");
                }
                //Set the output to 0
                output = 0;
                //Return false signifying a failure
                return false;
            }
        }

        //Get the age of the employee. Returns false if it was unable to retrieve it
        //This function uses the TryParse function for its error checking
        bool GetEmployeeAge(out uint output)
        {
            //Attempt to parse the Age Text into a positive number and store the result in the "output" parameter
            if (uint.TryParse(AgeBox.Text, out output))
            {
                //If the specified age is less than 16
                if (output < 16)
                {
                    //Set the output to 0
                    output = 0;
                    //Display an error saying that the age of the employee shouldn't be under 16
                    DisplayErrorMessage("Years Worked Error", "The age of the employee should not be under 16");
                    //Return false signifying a failure
                    return false;
                }
                //If the parsing was successful, then return true
                return true;
            }
            //If the parsing failed
            else
            {
                //Set the output to 0
                output = 0;
                //If the textbox is empty
                if (AgeBox.Text == "")
                {
                    //Display an error saying that the textbox is empty
                    DisplayErrorMessage("Years Worked Error", "There is nothing entered for employee's age. Please enter a number.");
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the textbox does not have a valid number
                    DisplayErrorMessage("Employee Age Error", "The entered value for employee's age is not a valid integer number. Please enter an integer number and try again.");
                }
                return false;
             }
        }

        //Converts a percentage value between 0 and 1 and turns it into a string
        static string PercentageToString(double percentage)
        {
            //Multiply the percentage by 100, convert to a string, and add the percent symbol at the back
            return (percentage * 100.0).ToString() + "%";
        }

        //Converts a dollar amount to a string
        static string DollarAmountToString(double dollarAmount)
        {
            //First, multiply the number by 100
            dollarAmount *= 100.0;

            //Then, round it to the nearest integer
            dollarAmount = Math.Round(dollarAmount);

            //Finally, divide the number by 100
            dollarAmount /= 100.0;

            //This three step process ensures that the decimal number only contains two decimal places

            //Return a dollar sign and the dollar amount right after it
            return "$" + dollarAmount.ToString();
        }

        //Displays an error message with the specified title text and message
        static void DisplayErrorMessage(string title, string message)
        {
            //Show a message box with the specified message and title
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    public static class EmployeeCalculations
    {
        //Calculates the raise percentage based on how many years the employee worked
        public static double CalculateRaise(uint yearsWorked)
        {
            //If the employee worked for less than or equal to 2 years
            if (yearsWorked <= 2u)
            {
                //No raise is to be given out
                return 0.0;
            }
            //If the employee has worked for more than two years, but less than 10
            else if (yearsWorked > 2u && yearsWorked < 10u)
            {
                //Return a 2% raise multiplied by the years worked
                return 0.02 * yearsWorked;
            }
            //If the employee worked for more than 10 years
            else
            {
                //Return a 20% raise
                return 0.2;
            }
        }

        //Calculates the employee's salary but with the raise applied
        public static double CalculateSalaryWithRaise(double startingSalary, double raise)
        {
            //Increase the starting salary by the raise
            return startingSalary * (raise + 1.0);
        }

        //Calculates an employee's vacation days based on their age
        public static uint CalculateVacationDays(uint employeeAge)
        {
            //If the Employee is over 40
            if (employeeAge >= 40)
            {
                //Return the employeeAge mod 6 plus 5. This will be within the range of 5 and 10
                return (employeeAge % 6) + 5;
            }
            else
            {
                //Return the employeeAge mod 5 + 3. This will be within the range of 3 and 7
                return (employeeAge % 5) + 3;
            }
        }

        //Calculates a bonus for an employee based on their age
        public static double CalculateBonus(uint employeeAge)
        {
            //Create a random number generator, and pass in the employee's age as the seed
            //This ensures that the random generator will return the same random value if the same age is passed in
            Random randomGenerator = new Random((int)employeeAge);

            //Generate a random number between 0 and 10000 and divide it by 10.0. This will generate a random decimal value between 0 and 1000
            return randomGenerator.Next(0, 10000) / 10.0;
        }
    }
}