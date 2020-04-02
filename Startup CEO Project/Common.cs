using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Startup_CEO_Project
{
	public static class Common
	{
        //Converts a percentage value between 0 and 1 and turns it into a string
        public static string PercentageToString(double percentage)
        {
            //Multiply the percentage by 100, convert to a string, and add the percent symbol at the back
            return (percentage * 100.0).ToString() + "%";
        }

        //Converts a dollar amount to a string
        public static string DollarAmountToString(double dollarAmount)
        {
            //First, convert the dollarAmount into a decimal number
            //This removes the precision issues that come with using floats for doubles
            decimal decimalMoneyValue = Convert.ToDecimal(dollarAmount);
            //Then, use string.format to convert the decimal to a string, using the C (Currency) modifier
            //Reference: https://stackoverflow.com/questions/10615405/how-to-format-string-to-money
            return String.Format("{0:C}", decimalMoneyValue);
        }

        //Displays an error message with the specified title text and message
        public static void DisplayErrorMessage(string title, string message)
        {
            //Show a message box with the specified message and title
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Adds an item to a list if the item is not null
        public static bool AddIfNotNull<T>(this List<T> list,T item)
        {
            //If the item is null
            if (item == null)
            {
                return false;
            }
            //if the item is not null
            else
            {
                //Add the item to the list
                list.Add(item);
                return true;
            }
        }

        //Adds a range of items to a list if the range is not null
        public static bool AddIfNotNull<T>(this List<T> list, IEnumerable<T> range)
        {
            //If the range is null
            if (range == null)
            {
                return false;
            }
            //If the range is not null
            else
            {
                //Add the range of items to the list
                list.AddRange(range);
                return true;
            }
        }

        //Will continously call the function asynchronously until it returns true
        public static async Task WaitUntil(Func<bool> func)
        {
            //Create a new task on a seperate thread and run it
            await Task.Run(() =>
            {
                //This while loop will continously loop untill the function returns false
                while (func() == false) { }
            });
        }
    }
}
