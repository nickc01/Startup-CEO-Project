using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Startup_Company_Benefits
{
	public partial class ResultsForm : Form
	{
		//The ResultsForm that is currently open
		static ResultsForm ActiveForm = null;


		public ResultsForm()
		{
			InitializeComponent();
		}

		//Shows the results in a ResultsForm
		public static Form ShowResults(string title, string resultsLabel, string results, string secondaryResultsLabel = "", string secondaryResults = "")
		{
			//If there is an active form already open
			if (ActiveForm != null)
			{
				//Close it
				ActiveForm.Close();
			}
			//Create a new form
			ActiveForm = new ResultsForm();

			//Set the ResultForm's Title to the specified title text
			ActiveForm.Text = title;
			//Set the primary Results Label to the specified label text
			ActiveForm.ResultsLabel.Text = resultsLabel;

			//Set the results textbox to the specified results text
			ActiveForm.ResultsBox.Text = results;

			//If secondary results have been specified
			if (secondaryResultsLabel != "")
			{
				//Set the secondary results label to the secondary label specified
				ActiveForm.SecondaryResultsLabel.Text = secondaryResultsLabel;
				//Set the secondary results to the secondary results specified
				ActiveForm.SecondaryResultsBox.Text = secondaryResults;
			}
			//If no secodary results have been specified
			else
			{
				//Hide the secondary results label
				ActiveForm.SecondaryResultsLabel.Visible = false;
				//Hide the secondary results textbox
				ActiveForm.SecondaryResultsBox.Visible = false;
			}

			//Show the active ResultsForm
			ActiveForm.Show();

			//Return the form
			return ActiveForm;
		}

		//Called when the "Copy" Button is pressed
		private void CopyButton_Click(object sender, EventArgs e)
		{
			//Retrieve the Results label and results in the textbox and store them neatly in a single string
			string clipboardText = $"\"{ResultsLabel.Text}\": \"{ResultsBox.Text}\"";

			//If secondary results have been specified
			if (SecondaryResultsLabel.Text != "")
			{
				//Retrieve the Secondary Results Label and the Secondary Results and add them neatly to the clipboard strings
				clipboardText += $", \"{SecondaryResultsLabel.Text}\": \"{SecondaryResultsBox.Text}\"";
			}

			//Modify the clipboard to be the clipboard string
			Clipboard.SetText(clipboardText);

		}
	}
}
