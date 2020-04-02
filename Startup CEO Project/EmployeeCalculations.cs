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
* ]
* 
* Total Time Spent: 
* 
* Notes:
* 
*      
*/
#endregion



using System;

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