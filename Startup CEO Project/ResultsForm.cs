using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Startup_CEO_Project
{
	public partial class ResultsForm : Form
	{
		//The ResultsForm that is currently open
		static ResultsForm MainForm = null;

		bool formIsOpen = true; //Whether the form is open or not
		bool recalculate = true; //Whether the form wants the results to be recalculated or not

		List<Label> Labels = new List<Label>(); //The list of all the labels in the results form
		List<TextBox> Textboxes = new List<TextBox>(); //The list of all the textboxes int he results form


		public ResultsForm()
		{
			InitializeComponent();
		}

		//Shows the results in a ResultsForm. If no results have been specified, then this function does nothing and returns null
		public static ResultsForm ShowResults(string title, List<ResultsPair> results)
		{
			if (results == null || results.Count == 0)
			{
				//Break out and return a null form
				return null;
			}
			//Convert the list to an array and show the results
			return ShowResults(title, results.ToArray());
		}

		//Shows the results in a ResultsForm. If no results have been specified, then this function does nothing and returns null
		public static ResultsForm ShowResults(string title, params ResultsPair[] results)
		{
			//If there are no results to be shown
			if (results == null || results.GetLength(0) == 0)
			{
				//Break out and return a null form
				return null;
			}
			//If there is an active form already open
			if (MainForm != null)
			{
				//Close it
				MainForm.Close();
			}

			//Create a new form
			MainForm = new ResultsForm();

			//If more than 1 results have been specified
			if (results.GetLength(0) >= 1)
			{
				//Set the first label in the form to the first specified results label
				MainForm.ResultsLabel.Text = results[0].label;
				//Set the first textbox in the form to be the first specified results text
				MainForm.ResultsBox.Text = results[0].result;

				//Add the first label to the list of labels
				MainForm.Labels.Add(MainForm.ResultsLabel);
				//Add the first textbox to the list of textboxes
				MainForm.Textboxes.Add(MainForm.ResultsBox);

				//Stores the location of the last label added
				var labelLocation = MainForm.ResultsLabel.Location;
				//Stores the location of the last textbox added
				var textBoxLocation = MainForm.ResultsBox.Location;

				//Loop over all the remaining results to be shown
				for (int i = 1; i < results.GetLength(0); i++)
				{

					//Add an offset to the label and textbox locations
					labelLocation.Y += 31;
					textBoxLocation.Y += 31;

					//Increase the MainForms Miniminum Size and Size
					MainForm.MinimumSize = new Size(MainForm.MinimumSize.Width, MainForm.MinimumSize.Height + 31);
					MainForm.Size = MainForm.MinimumSize;

					//Create a new label
					var newLabel = new Label();

					//Add the label to the results group
					MainForm.ResultsGroup.Controls.Add(newLabel);

					//Configure the label's parameters
					newLabel.AutoSize = MainForm.ResultsLabel.AutoSize;
					newLabel.Location = labelLocation;
					newLabel.Name = "ResultsLabel" + i;
					newLabel.Size = MainForm.ResultsLabel.Size;
					newLabel.TabIndex = MainForm.ResultsLabel.TabIndex + (i * 2);
					//Set the text of the label to the results label we are displaying
					newLabel.Text = results[i].label;

					//Create a new textbox
					var newBox = new TextBox();

					//Add the textbox to the results group
					MainForm.ResultsGroup.Controls.Add(newBox);

					//Configure the textbox's parameters
					newBox.Anchor = MainForm.ResultsBox.Anchor;
					newBox.Location = textBoxLocation;
					newBox.Name = "ResultsBox" + i;
					newBox.ReadOnly = true;
					newBox.Size = MainForm.ResultsBox.Size;
					newBox.TabIndex = MainForm.ResultsBox.TabIndex + (i * 2);
					//Set the textbox text to the results text we are displaying
					newBox.Text = results[i].result;

					//Add the newly added label to the list of labels
					MainForm.Labels.Add(newLabel);
					
					//Add the newly added textbox to the list of textboxes
					MainForm.Textboxes.Add(newBox);
				}
			}

			//Show the results form
			MainForm.Show();

			//Return the newly made form
			return MainForm;
		}

		//Called when the "Copy" Button is pressed
		private void CopyButton_Click(object sender, EventArgs e)
		{
			//Get the text that represents all the results
			string clipboardText = ResultsToText();
			//Modify the clipboard to be the clipboard string
			Clipboard.SetText(clipboardText);

		}

		private string ResultsToText()
		{
			//The text that stores all the results
			string text = "";
			//Loop over all the textboxes that are in the results form
			for (int i = 0; i < Textboxes.Count; i++)
			{
				//Add each of the labels and textboxes text to the final text
				text += $"\"{Labels[i].Text}\": \"{Textboxes[i].Text}\"\n";
			}
			//Return the final text
			return text;
		}

		private void saveToFileButton_Click(object sender, EventArgs e)
		{
			//Create the save file dialog that will allow us to save the results to a specified file
			//Reference: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog?view=netframework-4.8
			var saveDialog = new SaveFileDialog();

			//Set the dialog's filter to only accept either text files, or any custom format
			saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			//Set the default filter to be text files
			saveDialog.FilterIndex = 2;
			//Set the title of the save dialog box
			saveDialog.Title = "Specify where you want to save the results";
			//Set the default filename
			saveDialog.FileName = "Results";
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
						//Write all the results to the text file
						writer.WriteLine(ResultsToText());
						//Close the file
						writer.Close();
					}
				}
			}
		}

		//Returns whether the form wants to recalculate the results or not
		public bool WantsToRecalculate() => recalculate;

		//Returns whether the form is open or not
		public bool IsOpen() => formIsOpen;

		//Called when the form is closed
		private void ResultsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			//Specify that the form is no longer open
			formIsOpen = false;
		}

		//Called when the user wants to recalculate the results
		private void recalculateButton_Click(object sender, EventArgs e)
		{
			//Set the recalculate flag to false
			recalculate = false;
			//Close the form
			Close();
		}
	}
}
