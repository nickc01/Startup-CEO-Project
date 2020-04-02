namespace Startup_CEO_Project
{
	partial class StartupCEOForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupCEOForm));
			this.EmployeeSalaryLabel = new System.Windows.Forms.Label();
			this.EmployeeSalaryTextBox = new System.Windows.Forms.TextBox();
			this.YearsWorkedLabel = new System.Windows.Forms.Label();
			this.YearsWorkedTextbox = new System.Windows.Forms.TextBox();
			this.AgeLabel = new System.Windows.Forms.Label();
			this.AgeBox = new System.Windows.Forms.TextBox();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ClearButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.CalculationMenuStrip = new System.Windows.Forms.MenuStrip();
			this.calculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateRaiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateVacationDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateBonusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ParametersGroup = new System.Windows.Forms.GroupBox();
			this.calculateEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CalculationMenuStrip.SuspendLayout();
			this.ParametersGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// EmployeeSalaryLabel
			// 
			this.EmployeeSalaryLabel.AutoSize = true;
			this.EmployeeSalaryLabel.Location = new System.Drawing.Point(6, 16);
			this.EmployeeSalaryLabel.Name = "EmployeeSalaryLabel";
			this.EmployeeSalaryLabel.Size = new System.Drawing.Size(85, 13);
			this.EmployeeSalaryLabel.TabIndex = 0;
			this.EmployeeSalaryLabel.Text = "Employee Salary";
			// 
			// EmployeeSalaryTextBox
			// 
			this.EmployeeSalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EmployeeSalaryTextBox.Location = new System.Drawing.Point(146, 13);
			this.EmployeeSalaryTextBox.Name = "EmployeeSalaryTextBox";
			this.EmployeeSalaryTextBox.Size = new System.Drawing.Size(156, 20);
			this.EmployeeSalaryTextBox.TabIndex = 1;
			// 
			// YearsWorkedLabel
			// 
			this.YearsWorkedLabel.AutoSize = true;
			this.YearsWorkedLabel.Location = new System.Drawing.Point(6, 42);
			this.YearsWorkedLabel.Name = "YearsWorkedLabel";
			this.YearsWorkedLabel.Size = new System.Drawing.Size(134, 13);
			this.YearsWorkedLabel.TabIndex = 2;
			this.YearsWorkedLabel.Text = "Years Worked at Company";
			// 
			// YearsWorkedTextbox
			// 
			this.YearsWorkedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.YearsWorkedTextbox.Location = new System.Drawing.Point(146, 39);
			this.YearsWorkedTextbox.Name = "YearsWorkedTextbox";
			this.YearsWorkedTextbox.Size = new System.Drawing.Size(156, 20);
			this.YearsWorkedTextbox.TabIndex = 3;
			// 
			// AgeLabel
			// 
			this.AgeLabel.AutoSize = true;
			this.AgeLabel.Location = new System.Drawing.Point(6, 68);
			this.AgeLabel.Name = "AgeLabel";
			this.AgeLabel.Size = new System.Drawing.Size(87, 13);
			this.AgeLabel.TabIndex = 4;
			this.AgeLabel.Text = "Age of Employee";
			// 
			// AgeBox
			// 
			this.AgeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AgeBox.Location = new System.Drawing.Point(146, 65);
			this.AgeBox.Name = "AgeBox";
			this.AgeBox.Size = new System.Drawing.Size(156, 20);
			this.AgeBox.TabIndex = 5;
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearButton.Location = new System.Drawing.Point(245, 127);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButtonTooltip.SetToolTip(this.ClearButton, "Clears all the parameters");
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// CalculationMenuStrip
			// 
			this.CalculationMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculationsToolStripMenuItem});
			this.CalculationMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.CalculationMenuStrip.Name = "CalculationMenuStrip";
			this.CalculationMenuStrip.Size = new System.Drawing.Size(332, 24);
			this.CalculationMenuStrip.TabIndex = 10;
			this.CalculationMenuStrip.Text = "menuStrip2";
			// 
			// calculationsToolStripMenuItem
			// 
			this.calculationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateRaiseToolStripMenuItem,
            this.calculateVacationDaysToolStripMenuItem,
            this.calculateBonusToolStripMenuItem,
            this.calculateEverythingToolStripMenuItem});
			this.calculationsToolStripMenuItem.Name = "calculationsToolStripMenuItem";
			this.calculationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.calculationsToolStripMenuItem.Text = "Calculations";
			// 
			// calculateRaiseToolStripMenuItem
			// 
			this.calculateRaiseToolStripMenuItem.Name = "calculateRaiseToolStripMenuItem";
			this.calculateRaiseToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.calculateRaiseToolStripMenuItem.Text = "Calculate Raise";
			this.calculateRaiseToolStripMenuItem.Click += new System.EventHandler(this.calculateRaiseToolStripMenuItem_Click);
			// 
			// calculateVacationDaysToolStripMenuItem
			// 
			this.calculateVacationDaysToolStripMenuItem.Name = "calculateVacationDaysToolStripMenuItem";
			this.calculateVacationDaysToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.calculateVacationDaysToolStripMenuItem.Text = "Calculate Vacation Days";
			this.calculateVacationDaysToolStripMenuItem.Click += new System.EventHandler(this.calculateVacationDaysToolStripMenuItem_Click);
			// 
			// calculateBonusToolStripMenuItem
			// 
			this.calculateBonusToolStripMenuItem.Name = "calculateBonusToolStripMenuItem";
			this.calculateBonusToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.calculateBonusToolStripMenuItem.Text = "Calculate Bonus";
			this.calculateBonusToolStripMenuItem.Click += new System.EventHandler(this.calculateBonusToolStripMenuItem_Click);
			// 
			// ParametersGroup
			// 
			this.ParametersGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ParametersGroup.Controls.Add(this.EmployeeSalaryLabel);
			this.ParametersGroup.Controls.Add(this.EmployeeSalaryTextBox);
			this.ParametersGroup.Controls.Add(this.YearsWorkedTextbox);
			this.ParametersGroup.Controls.Add(this.YearsWorkedLabel);
			this.ParametersGroup.Controls.Add(this.AgeBox);
			this.ParametersGroup.Controls.Add(this.AgeLabel);
			this.ParametersGroup.Location = new System.Drawing.Point(12, 27);
			this.ParametersGroup.Name = "ParametersGroup";
			this.ParametersGroup.Size = new System.Drawing.Size(308, 94);
			this.ParametersGroup.TabIndex = 11;
			this.ParametersGroup.TabStop = false;
			this.ParametersGroup.Text = "Parameters";
			// 
			// calculateEverythingToolStripMenuItem
			// 
			this.calculateEverythingToolStripMenuItem.Name = "calculateEverythingToolStripMenuItem";
			this.calculateEverythingToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.calculateEverythingToolStripMenuItem.Text = "Calculate Everything";
			this.calculateEverythingToolStripMenuItem.Click += new System.EventHandler(this.calculateEverythingToolStripMenuItem_Click);
			// 
			// StartupCEOForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 165);
			this.Controls.Add(this.ParametersGroup);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.CalculationMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(348, 204);
			this.Name = "StartupCEOForm";
			this.Text = "Employee Benefits Calculator";
			this.CalculationMenuStrip.ResumeLayout(false);
			this.CalculationMenuStrip.PerformLayout();
			this.ParametersGroup.ResumeLayout(false);
			this.ParametersGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label EmployeeSalaryLabel;
		private System.Windows.Forms.TextBox EmployeeSalaryTextBox;
		private System.Windows.Forms.Label YearsWorkedLabel;
		private System.Windows.Forms.TextBox YearsWorkedTextbox;
		private System.Windows.Forms.Label AgeLabel;
		private System.Windows.Forms.TextBox AgeBox;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.ToolTip ClearButtonTooltip;
		private System.Windows.Forms.MenuStrip CalculationMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateRaiseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateVacationDaysToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateBonusToolStripMenuItem;
		private System.Windows.Forms.GroupBox ParametersGroup;
		private System.Windows.Forms.ToolStripMenuItem calculateEverythingToolStripMenuItem;
	}
}

