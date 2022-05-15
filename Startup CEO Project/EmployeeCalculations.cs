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

    //Calculates how long each break will be for the employee
    public static float CalculateBreakTimes(string position,uint yearsWorked)
    {
        if (position.ToUpper().Contains("MANAGER"))
        {
            return 30.0f;
        }
        else
        {
            if (yearsWorked > 5)
            {
                return 30.0f;
            }
            else
            {
                return 15.0f;
            }
        }
    }

    //Calculates how long each break will be for the employee
    public static uint CalculateAmountOfBreaks(string position, uint yearsWorked)
    {
        if (position.ToUpper().Contains("MANAGER"))
        {
            return 3;
        }
        else
        {
            if (yearsWorked > 5)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }
    }
}