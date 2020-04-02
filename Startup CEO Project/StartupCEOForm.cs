#region Program Description
/* 
* Name: Nicholas Cullen
* Date: 3/24/2020
* Program Name: Startup Company Benefits Calcuator
* Program Description: Allows you to calculate several employee benefits for a company, such as their Raise, their Vacation days, and their bonus
*/
#endregion
#region Initial Setup Week 1
/*
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
#endregion
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
#region Week 2 - Addition of Loops, File I/O, And Random Number Generator
/*
*-----EXCEPTION HANLDING ADDON-----
* Estimated Total Development Time:: 2 Hours
* 
* TimeLog:
* [
*   20 Minutes: 3/30/2020 : Added a "Save to File" Button and make it so that it saves the results to a user-specified file
*   20 Minutes: 3/31/2020 : Began work on new results system
*   18 Minutes: 3/31/2020 : Redesigned ResultsForm.ShowResults so that it can take as many results as you want
*   35 Minutes: 3/31/2020 : Refactored the code into seperate files, and added an ability to calculate everything
*   12 Minutes: 3/31/2020 : Fixed the copy and save to file buttons to work with all the textboxes in the results form
*   35 Minutes: 4/1/2020 : Made each of the calculation buttons asynchronous, and added a loop to each of them. That way, they can repeat untill the user does not want to recalculate them anymore
*   15 Minutes: 4/1/2020 : Cleanup and final touches
* ]
* 
* Total Time Spent: ~2 Hours and 35 Minutes
* 
* Notes:
*   When I first started this addition to the program and calculated my estimate, I though it wouldn't be too hard to get done,
*   since I have already implemented the random number generator from the last assignment. That left me with only two requirements to implement.
*   
*   But I did get a bit confused on how to implement the looping behaviour for displaying the results. The requirement was:
*   ' Add a loop so the user can repeat the menu until they choose the "exit" option" '
*   But I couldn't just throw in a loop in the calculation functions or else the GUI would stop responding
*   I eventually came up with a solution that used "async". Then, I could wait for the results form to close without causing the UI to hang.
*   At first, it was working quite roughly, but after cleaning it up, I consider it to be a pretty good solution
*   
*   So with these extra issues taken into account, I did go over my estimate. 
* 
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

namespace Startup_CEO_Project
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
        private async void calculateRaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The form that the results are going to be displayed in
            ResultsForm currentForm = null;
            do
            {
                //Calculate the raise
                var raiseResults = ResultCalcuations.GetRaise(this);
                //If the calculation was a success
                if (raiseResults != null)
                {
                    //Show the results and store the form that is showing the results
                    currentForm = ResultsForm.ShowResults("Raise Results", raiseResults);
                    //Wait until the form is no longer open
                    await Common.WaitUntil(() => !currentForm.IsOpen());
                }
                //If the calculation failed
                else
                {
                    //Return out of the function
                    return;
                }
            }
            //Loop until the user does not want to recalculate anymore
            while (currentForm.WantsToRecalculate());
        }

        //Called when the "Calculate Vacation Days" Menu Item is clicked
        private async void calculateVacationDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The form that the results are going to be displayed in
            ResultsForm currentForm = null;
            do
            {
                //Calculate the vacation days
                var vacationDaysResults = ResultCalcuations.GetVacationDays(this);
                //If the calculation was a success
                if (vacationDaysResults != null)
                {
                    //Show the results and store the form that is showing the results
                    currentForm = ResultsForm.ShowResults("Vacation Days Results", vacationDaysResults);
                    //Wait until the form is no longer open
                    await Common.WaitUntil(() => !currentForm.IsOpen());
                }
                //If the calculation failed
                else
                {
                    //Return out of the function
                    return;
                }
            }
            //Loop until the user does not want to recalculate anymore
            while (currentForm.WantsToRecalculate());
        }

        //Called when the "Calculate Bonus" Menu Item is clicked
        private async void calculateBonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The form that the results are going to be displayed in
            ResultsForm currentForm = null;
            do
            {
                //Calculate the bonus
                var bonusResults = ResultCalcuations.GetBonus(this);
                //If the calculation was a success
                if (bonusResults != null)
                {
                    //Show the results and store the form that is showing the results
                    currentForm = ResultsForm.ShowResults("Bonus Results", bonusResults);
                    //Wait until the form is no longer open
                    await Common.WaitUntil(() => !currentForm.IsOpen());
                }
                //If the calculation failed
                else
                {
                    //Return out of the function
                    return;
                }
            }
            //Loop until the user does not want to recalculate anymore
            while (currentForm.WantsToRecalculate());
        }


        private async void calculateEverythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The form that the results are going to be displayed in
            ResultsForm currentForm = null;
            do
            {
                //The list the stores all the results to be shown
                List<ResultsPair> AllResults = new List<ResultsPair>();

                //Attempt to calculate the raise. If the raise calculation succeeded, then add the results of the calculation to the list of results
                if (!AllResults.AddIfNotNull(ResultCalcuations.GetRaise(this)))
                {
                    //If the calculation failed, then return out of the function
                    return;
                }
                //Attempt to calculate the vacation days. If the vacation days calculation succeeded, then add the results of the calculation to the list of results
                if (!AllResults.AddIfNotNull(ResultCalcuations.GetVacationDays(this)))
                {
                    //If the calculation failed, then return out of the function
                    return;
                }
                //Attempt to calculate the bonus. If the bonus calculation succeeded, then add the results of the calculation to the list of results
                if (!AllResults.AddIfNotNull(ResultCalcuations.GetBonus(this)))
                {
                    //If the calculation failed, then return out of the function
                    return;
                }
                //Show the results and store the form that is showing the results
                currentForm = ResultsForm.ShowResults("All Results", AllResults);
                //Wait until the form is no longer open
                await Common.WaitUntil(() => !currentForm.IsOpen());
            }
            //Loop until the user does not want to recalculate anymore
            while (currentForm.WantsToRecalculate());
        }


        //Gets the salary of the employee. Returns false if it was unable to retrieve it
        //This function uses the TryParse function for its error checking
        public bool GetSalary(out double result)
        {
            //Attempt to parse the employee salary text into a floating-point number, and store the result in the "result" parameter
            if (double.TryParse(EmployeeSalaryTextBox.Text, NumberStyles.Currency, new CultureInfo("en-US"), out result))
            {
                //If the salary entered is negative
                if (result < 0.0)
                {
                    //Display an error that the salary shouldn't be negative
                    Common.DisplayErrorMessage("Salary Error", "A negative salary is not valid");
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
                    Common.DisplayErrorMessage("Salary Error", "There is nothing entered for employee's salary. Please enter a number.");
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the entered text is not a number
                    Common.DisplayErrorMessage("Salary Error", "The entered value for the employee's salary is not a valid decimal number. Please enter an decimal number and try again.");
                }
                //Return false signifying a failure
                return false;
            }
        }

        //Get the amount of years the employee worked. Returns false if it was unable to retrieve it
        //This function uses a try and catch block for its error checking
        public bool GetYearsWorked(out uint output)
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
                    Common.DisplayErrorMessage("Years Worked Error", "There is nothing entered for employee's years worked. Please enter a number.");
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the entered text is not a number
                    Common.DisplayErrorMessage("Years Worked Error", "The entered value for years worked is not a valid integer number. Please enter an integer number and try again.");
                }
                //Set the output to 0
                output = 0;
                //Return false signifying a failure
                return false;
            }
        }

        //Get the age of the employee. Returns false if it was unable to retrieve it
        //This function uses the TryParse function for its error checking
        public bool GetEmployeeAge(out uint output)
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
                    Common.DisplayErrorMessage("Years Worked Error", "The age of the employee should not be under 16");
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
                    Common.DisplayErrorMessage("Years Worked Error", "There is nothing entered for employee's age. Please enter a number.");
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the textbox does not have a valid number
                    Common.DisplayErrorMessage("Employee Age Error", "The entered value for employee's age is not a valid integer number. Please enter an integer number and try again.");
                }
                return false;
             }
        }
    }
}
