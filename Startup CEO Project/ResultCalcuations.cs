
using Startup_CEO_Project;

public static class ResultCalcuations
{
    //Attempts to calculate the raise results. Returns null if the calculation was unsuccessful
    public static ResultsPair[] GetRaise(StartupCEOForm mainForm)
    {
        //Attempt to get the years worked and the salary
        if (mainForm.GetYearsWorked(out uint yearsWorked) && mainForm.GetSalary(out double salary))
        {
            //Calculate the raise
            double raise = EmployeeCalculations.CalculateRaise(yearsWorked);

            //Calculate the salary with the raise applied
            double salaryWithRaise = EmployeeCalculations.CalculateSalaryWithRaise(salary, raise);

            //If we were able to get both the years worked and the salary
            //Compute the employee's raise
            double raisePercent = EmployeeCalculations.CalculateRaise(yearsWorked);

            //Return the results of the calculation
            return new ResultsPair[] { new ResultsPair("Raise", Common.PercentageToString(raisePercent)), new ResultsPair("Salary With Raise", Common.DollarAmountToString(salaryWithRaise)) };
        }

        //Return null if unsuccessful
        return null;
    }

    //Attempts to calculate the vacation days. Returns null if the calculation was unsuccessful
    public static ResultsPair GetVacationDays(StartupCEOForm mainForm)
    {
        //Attempt to get the employee's age and store it in the "employeeAge" variable
        if (mainForm.GetEmployeeAge(out uint employeeAge))
        {
            //If we are able to get the employee's age
            //Calculate the amount of vacation days the employee has
            uint vacationDays = EmployeeCalculations.CalculateVacationDays(employeeAge);

            //Show the results of the calculation

            return new ResultsPair("Vacation Days", vacationDays.ToString());

            //ResultsForm.ShowResults("Vacation Days Results", new ResultsPair("Vacation Days", vacationDays.ToString()));
        }
        return null;
    }

    //Attempts to calculate the bonus. Returns null if the calculation was unsuccessful
    public static ResultsPair GetBonus(StartupCEOForm mainForm)
    {
        //Attempt to get the employee's age and store it in the "employeeAge" variable
        if (mainForm.GetEmployeeAge(out uint employeeAge))
        {
            //If we were able to get the employee's age
            //Calculate the employee's bonus
            double bonus = EmployeeCalculations.CalculateBonus(employeeAge);

            //Return the results of the calculation
            return new ResultsPair("Bonus", Common.DollarAmountToString(bonus));
        }
        return null;
    }

    //Attempts to calculate the break times. Returns null if the calculation was unsuccessful
    public static ResultsPair GetBreakTimes(StartupCEOForm mainForm)
    {
        string jobPosition = mainForm.JobPositionTextBox.Text;
        uint yearsWorked = 0;

        if (!mainForm.GetYearsWorked(out yearsWorked))
        {
            return null;
        }

        if (jobPosition == "")
        {
            Common.DisplayErrorMessage("Job Position Error", "No job position has been entered", mainForm);
            return null;
        }

        float breakTimes = EmployeeCalculations.CalculateBreakTimes(jobPosition, yearsWorked);

        return new ResultsPair("Break Times",breakTimes.ToString() + " Minutes");
    }

    //Attempts to calculate the break times. Returns null if the calculation was unsuccessful
    public static ResultsPair GetAmountOfBreaks(StartupCEOForm mainForm)
    {
        string jobPosition = mainForm.JobPositionTextBox.Text;
        uint yearsWorked = 0;

        if (!mainForm.GetYearsWorked(out yearsWorked))
        {
            return null;
        }

        if (jobPosition == "")
        {
            Common.DisplayErrorMessage("Job Position Error", "No job position has been entered", mainForm);
            return null;
        }

        float amountOfBreaks = EmployeeCalculations.CalculateAmountOfBreaks(jobPosition, yearsWorked);

        return new ResultsPair("Amount of Breaks", amountOfBreaks.ToString());
    }
}
