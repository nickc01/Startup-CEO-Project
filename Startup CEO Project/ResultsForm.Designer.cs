namespace Startup_CEO_Project
{
	partial class ResultsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
			this.CopyButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.CopyButton = new MetroFramework.Controls.MetroButton();
			this.SaveToFileTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.saveToFileButton = new MetroFramework.Controls.MetroButton();
			this.ExitTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.exitButton = new MetroFramework.Controls.MetroButton();
			this.ResultsGroup = new MetroFramework.Controls.MetroPanel();
			this.ResultsBox = new MetroFramework.Controls.MetroTextBox();
			this.ResultsLabel = new MetroFramework.Controls.MetroLabel();
			this.ResultsStyle = new MetroFramework.Components.MetroStyleManager(this.components);
			this.ResultsGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResultsStyle)).BeginInit();
			this.SuspendLayout();
			// 
			// CopyButton
			// 
			this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyButton.Location = new System.Drawing.Point(296, 103);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(75, 23);
			this.CopyButton.TabIndex = 4;
			this.CopyButton.Text = "Copy";
			this.CopyButtonTooltip.SetToolTip(this.CopyButton, "Copys the Results to your clipboard so you can paste the contents in whatever tex" +
        "t editor you like");
			this.CopyButton.UseSelectable = true;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// saveToFileButton
			// 
			this.saveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveToFileButton.Location = new System.Drawing.Point(215, 103);
			this.saveToFileButton.Name = "saveToFileButton";
			this.saveToFileButton.Size = new System.Drawing.Size(75, 23);
			this.saveToFileButton.TabIndex = 5;
			this.saveToFileButton.Text = "Save to File";
			this.SaveToFileTooltip.SetToolTip(this.saveToFileButton, "Saves the results to a file of your choice");
			this.saveToFileButton.UseSelectable = true;
			this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.Location = new System.Drawing.Point(134, 103);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.ExitTooltip.SetToolTip(this.exitButton, "Exits the results window");
			this.exitButton.UseSelectable = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// ResultsGroup
			// 
			this.ResultsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ResultsGroup.Controls.Add(this.ResultsBox);
			this.ResultsGroup.Controls.Add(this.ResultsLabel);
			this.ResultsGroup.HorizontalScrollbarBarColor = true;
			this.ResultsGroup.HorizontalScrollbarHighlightOnWheel = false;
			this.ResultsGroup.HorizontalScrollbarSize = 10;
			this.ResultsGroup.Location = new System.Drawing.Point(26, 63);
			this.ResultsGroup.Margin = new System.Windows.Forms.Padding(6);
			this.ResultsGroup.Name = "ResultsGroup";
			this.ResultsGroup.Size = new System.Drawing.Size(345, 31);
			this.ResultsGroup.TabIndex = 9;
			this.ResultsGroup.UseStyleColors = true;
			this.ResultsGroup.VerticalScrollbarBarColor = true;
			this.ResultsGroup.VerticalScrollbarHighlightOnWheel = false;
			this.ResultsGroup.VerticalScrollbarSize = 10;
			// 
			// ResultsBox
			// 
			this.ResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.ResultsBox.CustomButton.Image = null;
			this.ResultsBox.CustomButton.Location = new System.Drawing.Point(123, 1);
			this.ResultsBox.CustomButton.Name = "";
			this.ResultsBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.ResultsBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.ResultsBox.CustomButton.TabIndex = 1;
			this.ResultsBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.ResultsBox.CustomButton.UseSelectable = true;
			this.ResultsBox.CustomButton.Visible = false;
			this.ResultsBox.Lines = new string[0];
			this.ResultsBox.Location = new System.Drawing.Point(195, 3);
			this.ResultsBox.MaxLength = 32767;
			this.ResultsBox.Name = "ResultsBox";
			this.ResultsBox.PasswordChar = '\0';
			this.ResultsBox.ReadOnly = true;
			this.ResultsBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.ResultsBox.SelectedText = "";
			this.ResultsBox.SelectionLength = 0;
			this.ResultsBox.SelectionStart = 0;
			this.ResultsBox.ShortcutsEnabled = true;
			this.ResultsBox.Size = new System.Drawing.Size(145, 23);
			this.ResultsBox.TabIndex = 3;
			this.ResultsBox.UseSelectable = true;
			this.ResultsBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.ResultsBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// ResultsLabel
			// 
			this.ResultsLabel.AutoSize = true;
			this.ResultsLabel.Location = new System.Drawing.Point(8, 3);
			this.ResultsLabel.Name = "ResultsLabel";
			this.ResultsLabel.Size = new System.Drawing.Size(81, 19);
			this.ResultsLabel.TabIndex = 2;
			this.ResultsLabel.Text = "metroLabel1";
			// 
			// ResultsStyle
			// 
			this.ResultsStyle.Owner = null;
			// 
			// ResultsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 149);
			this.Controls.Add(this.ResultsGroup);
			this.Controls.Add(this.CopyButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.saveToFileButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(397, 149);
			this.Name = "ResultsForm";
			this.Style = MetroFramework.MetroColorStyle.Default;
			this.Text = "Results";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultsForm_FormClosed);
			this.Load += new System.EventHandler(this.ResultsForm_Load);
			this.ResultsGroup.ResumeLayout(false);
			this.ResultsGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResultsStyle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolTip CopyButtonTooltip;
		private System.Windows.Forms.ToolTip ExitTooltip;
		private System.Windows.Forms.ToolTip SaveToFileTooltip;
		private MetroFramework.Controls.MetroPanel ResultsGroup;
		private MetroFramework.Controls.MetroLabel ResultsLabel;
		private MetroFramework.Controls.MetroTextBox ResultsBox;
		private MetroFramework.Controls.MetroButton CopyButton;
		private MetroFramework.Controls.MetroButton exitButton;
		private MetroFramework.Controls.MetroButton saveToFileButton;
		private MetroFramework.Components.MetroStyleManager ResultsStyle;
	}
}