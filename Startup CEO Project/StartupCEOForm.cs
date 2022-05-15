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
#region Week 3 - Addtion of Lists, Arrays, and use of at least 3 string functions
/*
* Estimated Total Development Time:: 1 Hour 30 Minutes
* 
* TimeLog:
* [
*   12 Minutes : 4/5/2020 : Installed Metro Framework UI to make the UI look fancier : https://github.com/dennismagno/metroframework-modern-ui
*   35 Minutes : 4/5/2020 : Modified the main form to utilize the Metro UI
*   35 Minutes : 4/6/2020 : Finished new design for main form
*   25 Minutes : 4/6/2020 : Finished new design for results form
*   15 Minutes : 4/6/2020 : Changed the ShowResults function to use an array, since there wasn't a need to have a list there, and an array would suffice. Also, 1 other string function was added to the code, since two were already being used, and the assignment required 3
* ]
* 
* Total Time Spent: ~2.03 Hours
* Notes: 
*   Most of the features that this week required (such as arrays and lists) were features that I already implemented since last week.
*   But since I had some extra time this week, I decided that I wanted to spice up the UI a bit more.
*   I decided to give the UI a more modern, metro look to it by installing the metro framework gui package : https://github.com/dennismagno/metroframework-modern-ui
*   It took a while to figure out, but all I had to do was follow the tutorial online, and replace all the existing elements with their metro counterparts
*   This took a bit longer than I thought it would take, but I am pretty satisfied with how it turned out
*   After that, I was able to get the string function assignment requirement done, and do a bit of cleanup
* 
*      
*/
#endregion
#region Week 4 - Addition of two classes, each with at least 2 fields, 2 constructors, getters and setters for each field, and 3 additional methods
/*
* Estimated Total Development Time: 3.5 Hours
* 
* TimeLog:
* [
*       30 Minutes : 4/12/2020 : Created the Employee Class and began work on UI rearrangements
*       1 Hour - 15 Minutes : 4/13/2020 : Added an employee grid to the UI that stores all the added employees
*       40 Minutes : 4/13/2020 : Added a way of adding, removing, saving, and loading to/from the employee list
*       20 : 4/13/2020 : Added Newtonsoft.Json for a cleaner method of saving and loading employee data
*       1 Hour : 4/13/2020 : Added the ability to change the theme and color of all the elements in the UI
*       45 Minutes : 4/15/2020 : Commenting and Cleaup
* ]
* 
* Total Time Spent: 4.5 Hours
* Notes: 
*       There are two main reasons why I went 1 hour above my initial estimate. First, I ran into many issues when trying to set up
*       the list that displays all the employees to the user. I originally was going to have a simple text list which displayed the names.
*       Then, when you clicked on one, the parameters would be filled with whatever the employee's parameters were. I was having numorous issues trying
*       to set that up, so I thought that a better solution would be to use a grid, similar to an excel sheet. I found that solution way better,
*       since it allowed me to display all the stats to the user in a simple spreadsheet.
*       
*       The other issue I ran into was when I was setting up the theme and color settings. At first, I thought that having the style manager alone would be enough
*       to colorize the entire UI. But I quickly figured out that the style manager does not colorize everything, such as the form itself. So I had to edit the WindowColor class
*       so that it accepts both forms and other elements so that they can be colorized as well.
* 
*      
*/
#endregion
#region Week 5 - UI Adjustments
/*
* Estimated Total Development Time: 2 Hours
* 
* TimeLog:
* [
*       1 Hour : Added tab controls so the employees and settings areas are now seperated. Also did some UI rearrangements
*       30 Minutes : Added tooltips to all of the buttons in both the main form, and the results form
*       15 Minutes : Added a "recalculate" button to the results form to make recalculations easier for the user. Also did some minor cleanup
* ]
* 
* Total Time Spent: 1.75 Hours
* Notes: This wasn't super difficult to get done, mainly because I have been working alot on the interface several times before this assignment.
*        I just had to do some minor rearrangements and adjustments because the UI was mostly to where I wanted it to be. I did run into a small issue
*        where I couldn't create anything inside of the Metro Tab Control, but was able to quickly fix it by fixing the Tab Pages to be their correct types : https://github.com/dennismagno/metroframework-modern-ui/issues/38
*        
* 
* 
*      
*/
#endregion
#region Final
/*
* Estimated Total Development Time: 3 Hours
* 
* TimeLog:
* [
*       15 Minutes : Added About Section
*       1 Hour : Added 2 New Calculations, and two new parameters
* ]
* 
* Total Time Spent: 
* Notes: 
*        
* 
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
using MetroFramework.Controls;
using MetroFramework;

namespace Startup_CEO_Project
{
    //The main form for calculating the employee benefits
    public partial class StartupCEOForm : MetroFramework.Forms.MetroForm
	{
        //The singleton instance for the Startup CEO form
        public static StartupCEOForm Instance { get; private set; } = null;

        //The Colorizer used to colorize all the elements in the form
        public static WindowColor Colorizer { get; private set; } = new WindowColor();

		public StartupCEOForm()
		{
			InitializeComponent();
            //Sets the singleton
            Instance = this;
        }

        //Called when the "Clear" button is clicked
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the employee salary textbox
            EmployeeSalaryTextbox.Clear();
            //Clear the employee years worked textbox
            YearsWorkedTextbox.Clear();
            //Clear the employee age textbox
            AgeTextbox.Clear();
            //Clear the employee name textbox
            NameTextbox.Clear();
            //Clear the job position textbox
            JobPositionTextBox.Clear();
            //Clear the education textbox
            EducationTextBox.Clear();
        }

        //Called when the "Calculate Raise" Menu Item is clicked
        //The function needs to be asynchronous or else the loop will cause the GUI to hang
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
        //The function needs to be asynchronous or else the loop will cause the GUI to hang
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
        //The function needs to be asynchronous or else the loop will cause the GUI to hang
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

        //Called when the "Calculate Everything" Menu Item is clicked
        //The function needs to be asynchronous or else the loop will cause the GUI to hang
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
                //Attempt to calculate the break times. If the break time calculation succeeded, then add the results of the calculation to the list of results
                if (!AllResults.AddIfNotNull(ResultCalcuations.GetBreakTimes(this)))
                {
                    //If the calculation failed, then return out of the function
                    return;
                }
                //Attempt to calculate the amount of breaks. If the amount of breaks calculation succeeded, then add the results of the calculation to the list of results
                if (!AllResults.AddIfNotNull(ResultCalcuations.GetAmountOfBreaks(this)))
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
            if (double.TryParse(EmployeeSalaryTextbox.Text, NumberStyles.Currency, new CultureInfo("en-US"), out result))
            {
                //If the salary entered is negative
                if (result < 0.0)
                {
                    //Display an error that the salary shouldn't be negative
                    Common.DisplayErrorMessage("Salary Error", "A negative salary is not valid",this);
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
                if (EmployeeSalaryTextbox.Text == "")
                {
                    //Display an error saying that nothing is entered
                    Common.DisplayErrorMessage("Salary Error", "There is nothing entered for employee's salary. Please enter a number.",this);
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the entered text is not a number
                    Common.DisplayErrorMessage("Salary Error", "The entered value for the employee's salary is not a valid decimal number. Please enter an decimal number and try again.",this);
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
                    Common.DisplayErrorMessage("Years Worked Error", "There is nothing entered for employee's years worked. Please enter a number.",this);
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the entered text is not a number
                    Common.DisplayErrorMessage("Years Worked Error", "The entered value for years worked is not a valid integer number. Please enter an integer number and try again.",this);
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
            if (uint.TryParse(AgeTextbox.Text, out output))
            {
                //If the specified age is less than 16
                if (output < 16)
                {
                    //Set the output to 0
                    output = 0;
                    //Display an error saying that the age of the employee shouldn't be under 16
                    Common.DisplayErrorMessage("Employee Age Error", "The age of the employee should not be under 16",this);
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
                if (AgeTextbox.Text == "")
                {
                    //Display an error saying that the textbox is empty
                    Common.DisplayErrorMessage("Employee Age Error", "There is nothing entered for employee's age. Please enter a number.",this);
                }
                //If the textbox is not empty
                else
                {
                    //Display an error saying that the textbox does not have a valid number
                    Common.DisplayErrorMessage("Employee Age Error", "The entered value for employee's age is not a valid integer number. Please enter an integer number and try again.",this);
                }
                return false;
             }
        }

        //Called when the "calculations" button is clicked
        private void CalculationMenuButton_Click(object sender, EventArgs e)
        {
            //Get the mouse event arguments
            var mouseArgs = (MouseEventArgs)e;

            //Show the calculation context menu
            CalculationMenu.Show(sender as Control, mouseArgs.Location);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            //Get the salary text
            string salary = EmployeeSalaryTextbox.Text;
            //Get the years worked text
            string yearsWorked = YearsWorkedTextbox.Text;
            //Get the age text
            string age = AgeTextbox.Text;
            //Get the name text
            string name = NameTextbox.Text;
            //Get the job position text
            string jobPosition = JobPositionTextBox.Text;
            //Get the education text
            string education = EducationTextBox.Text;

            try
            {
                //Create a new employee from the parameters
                Employee newEmployee = new Employee(name, salary, yearsWorked, age,jobPosition,education);
                //Add the new employee to the list of employees
                newEmployee.AddToList();
            }
            //If an error occured
            catch (ArgumentException argumentException)
            {
                //Show a messagebox with the error
                MetroMessageBox.Show(this, argumentException.Message, "Employee Error");
            }
        }

        //Called when the selected employee in the list changes
        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            //If there is a selection active and the selection is within the employee list
            if (employeesGrid.CurrentRow != null && employeesGrid.CurrentRow.Index < Employee.EmployeesAdded())
            {
                //Enable the remove employee button
                RemoveEmployeeButton.Enabled = true;

                //Gets the row index
                int employeeIndex = employeesGrid.CurrentRow.Index;
                //Get the employee at that index
                Employee employee = Employee.GetEmployeeInList(employeeIndex);

                //Update the name textbox with the employee's
                NameTextbox.Text = employee.GetName();
                //Update the age textbox with the employee's
                AgeTextbox.Text = employee.GetAge().ToString();
                //Update the years worked textbox with the employee's
                YearsWorkedTextbox.Text = employee.GetYearsWorked().ToString();
                //Update the salary textbox with the employee's
                EmployeeSalaryTextbox.Text = employee.GetSalary().ToString("C");
                //Update the job position textbox with the employee's
                JobPositionTextBox.Text = employee.GetJobPosition();
                //Update the education textbox with the employee's
                EducationTextBox.Text = employee.GetEducation();
            }
            //If no row is selected
            else
            {
                //Disable the "Remove Employee" button
                RemoveEmployeeButton.Enabled = false;
            }

        }

        //Called when a row is added to the employee list
        private void employeesGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Enable the "Clear Employees" and "Save Employees" buttons only if there are more than 0 rows
            ClearEmployeesButton.Enabled = employeesGrid.Rows.Count > 0;
            SaveEmployeesButton.Enabled = employeesGrid.Rows.Count > 0;
        }

        private void employeesGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //Enable the "Clear Employees" and "Save Employees" buttons only if there are more than 0 rows
            ClearEmployeesButton.Enabled = employeesGrid.Rows.Count > 0;
            SaveEmployeesButton.Enabled = employeesGrid.Rows.Count > 0;
            //If there are no more rows left
            if (employeesGrid.Rows.Count == 0)
            {
                //Disable the "Remove Employee" Button
                RemoveEmployeeButton.Enabled = false;
            }
        }

        //Called when the "Remove Employee" Button is clicked
        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            //If no employees are added
            if (Employee.EmployeesAdded() == 0)
            {
                //Return out
                return;
            }
            //Get the index of the currently selected employee
            int employeeIndex = employeesGrid.CurrentRow.Index;
            //Get the employee
            Employee employee = Employee.GetEmployeeInList(employeeIndex);

            //Remove the employee
            employee.RemoveFromList();
        }

       //Called when the "Clear Employees" Button is clicked
        private void ClearEmployeesButton_Click(object sender, EventArgs e)
        {
            //If no employees were added
            if (Employee.EmployeesAdded() == 0)
            {
                //Return out
                return;
            }
            //Clear the employee list
            Employee.Clear();
        }

        //Called when the "Save Employees" Button is clicked
        private void SaveEmployeesButton_Click(object sender, EventArgs e)
        {
            //Save the employee's to a file
            Employee.Save();
        }

        //Called when the "Load Employees" button is clicked
        private void LoadEmployeesButton_Click(object sender, EventArgs e)
        {
            //Load the employees from a file
            Employee.Load();
        }

        //Called when the theme combobox has been modified
        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the theme
            Colorizer.SetTheme((string)ThemeComboBox.SelectedItem);
            //Trigger the window to redraw
            UpdateFormColor();
        }

        //Called when the color combobox has been modified
        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the color
            Colorizer.SetColor((string)ColorComboBox.SelectedItem);
            //Trigger the window to redraw
            UpdateFormColor();
        }

        //Causes the form color to update
        void UpdateFormColor()
        {
            Size = new Size(Size.Width + 1, Size.Height + 1);
            Size = new Size(Size.Width - 1, Size.Height - 1);
        }

        //Called when the Startup CEO form loads
        private void StartupCEOForm_Load(object sender, EventArgs e)
        {
            //Load the colors from the styles.txt file
            Colorizer.Load();
            //Add the Startup CEO form style manager to the list of things to colorize
            Colorizer.AddThemable(MetroStyleManager);
            //Add the Startup CEO to the list of things to colorize
            Colorizer.AddThemable(this);

            //Set the theme combo box to the currently configured theme
            ThemeComboBox.SelectedIndex = ThemeComboBox.Items.IndexOf(Colorizer.GetThemeName());
            //Set the color combo box to the currently configured color
            ColorComboBox.SelectedIndex = ColorComboBox.Items.IndexOf(Colorizer.GetColorName());
        }

        //Called when the Startup CEO form is closed
        private void StartupCEOForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save the theme and color configurations to "styles.txt"
            Colorizer.Save();
        }

        //Called when the "Reset Theme" Button is clicked
        private void resetThemeButton_Click(object sender, EventArgs e)
        {
            //Reset the theme
            Colorizer.Reset();
            //Set the theme combo box to the currently configured theme
            ThemeComboBox.SelectedIndex = ThemeComboBox.Items.IndexOf(Colorizer.GetThemeName());
            //Set the color combo box to the currently configured color
            ColorComboBox.SelectedIndex = ColorComboBox.Items.IndexOf(Colorizer.GetColorName());


        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private async void calculateBreakTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The form that the results are going to be displayed in
            ResultsForm currentForm = null;
            do
            {
                //Calculate the break times
                var breakTimesResults = ResultCalcuations.GetBreakTimes(this);
                //If the calculation was a success
                if (breakTimesResults != null)
                {
                    //Show the results and store the form that is showing the results
                    currentForm = ResultsForm.ShowResults("Break Time Results", breakTimesResults);
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

        private async void calculateAmountOfBreaksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The form that the results are going to be displayed in
            ResultsForm currentForm = null;
            do
            {
                //Calculate the amount of breaks per shift
                var amountOfBreaksResults = ResultCalcuations.GetAmountOfBreaks(this);
                //If the calculation was a success
                if (amountOfBreaksResults != null)
                {
                    //Show the results and store the form that is showing the results
                    currentForm = ResultsForm.ShowResults("Amount of Breaks Results", amountOfBreaksResults);
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
    }
}