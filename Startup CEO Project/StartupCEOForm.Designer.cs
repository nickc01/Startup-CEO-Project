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
			this.ClearButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.ClearButton = new MetroFramework.Controls.MetroButton();
			this.EmployeeSalaryLabel = new MetroFramework.Controls.MetroLabel();
			this.YearsWorkedLabel = new MetroFramework.Controls.MetroLabel();
			this.AgeLabel = new MetroFramework.Controls.MetroLabel();
			this.EmployeeSalaryTextbox = new MetroFramework.Controls.MetroTextBox();
			this.YearsWorkedTextbox = new MetroFramework.Controls.MetroTextBox();
			this.AgeTextbox = new MetroFramework.Controls.MetroTextBox();
			this.MetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
			this.ParameterGroup = new MetroFramework.Controls.MetroPanel();
			this.parametersLabel = new MetroFramework.Controls.MetroLabel();
			this.CalculationMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.calculateRaiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateVacationDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateBonusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CalculationMenuButton = new MetroFramework.Controls.MetroLink();
			((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
			this.ParameterGroup.SuspendLayout();
			this.CalculationMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearButton.Location = new System.Drawing.Point(492, 444);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(78, 23);
			this.ClearButton.Style = MetroFramework.MetroColorStyle.Green;
			this.ClearButton.TabIndex = 12;
			this.ClearButton.Text = "Clear";
			this.ClearButton.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ClearButton.UseSelectable = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// EmployeeSalaryLabel
			// 
			this.EmployeeSalaryLabel.AutoSize = true;
			this.EmployeeSalaryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.EmployeeSalaryLabel.Location = new System.Drawing.Point(3, 13);
			this.EmployeeSalaryLabel.Name = "EmployeeSalaryLabel";
			this.EmployeeSalaryLabel.Size = new System.Drawing.Size(108, 19);
			this.EmployeeSalaryLabel.Style = MetroFramework.MetroColorStyle.Green;
			this.EmployeeSalaryLabel.TabIndex = 13;
			this.EmployeeSalaryLabel.Text = "Employee Salary";
			this.EmployeeSalaryLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// YearsWorkedLabel
			// 
			this.YearsWorkedLabel.AutoSize = true;
			this.YearsWorkedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.YearsWorkedLabel.Location = new System.Drawing.Point(3, 42);
			this.YearsWorkedLabel.Name = "YearsWorkedLabel";
			this.YearsWorkedLabel.Size = new System.Drawing.Size(92, 19);
			this.YearsWorkedLabel.Style = MetroFramework.MetroColorStyle.Green;
			this.YearsWorkedLabel.TabIndex = 14;
			this.YearsWorkedLabel.Text = "Years Worked";
			this.YearsWorkedLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// AgeLabel
			// 
			this.AgeLabel.AutoSize = true;
			this.AgeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.AgeLabel.Location = new System.Drawing.Point(3, 71);
			this.AgeLabel.Name = "AgeLabel";
			this.AgeLabel.Size = new System.Drawing.Size(33, 19);
			this.AgeLabel.Style = MetroFramework.MetroColorStyle.Green;
			this.AgeLabel.TabIndex = 15;
			this.AgeLabel.Text = "Age";
			this.AgeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// EmployeeSalaryTextbox
			// 
			this.EmployeeSalaryTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.EmployeeSalaryTextbox.CustomButton.Image = null;
			this.EmployeeSalaryTextbox.CustomButton.Location = new System.Drawing.Point(403, 1);
			this.EmployeeSalaryTextbox.CustomButton.Name = "";
			this.EmployeeSalaryTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.EmployeeSalaryTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.EmployeeSalaryTextbox.CustomButton.TabIndex = 1;
			this.EmployeeSalaryTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.EmployeeSalaryTextbox.CustomButton.UseSelectable = true;
			this.EmployeeSalaryTextbox.CustomButton.Visible = false;
			this.EmployeeSalaryTextbox.Lines = new string[0];
			this.EmployeeSalaryTextbox.Location = new System.Drawing.Point(117, 13);
			this.EmployeeSalaryTextbox.MaxLength = 32767;
			this.EmployeeSalaryTextbox.Name = "EmployeeSalaryTextbox";
			this.EmployeeSalaryTextbox.PasswordChar = '\0';
			this.EmployeeSalaryTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.EmployeeSalaryTextbox.SelectedText = "";
			this.EmployeeSalaryTextbox.SelectionLength = 0;
			this.EmployeeSalaryTextbox.SelectionStart = 0;
			this.EmployeeSalaryTextbox.ShortcutsEnabled = true;
			this.EmployeeSalaryTextbox.Size = new System.Drawing.Size(425, 23);
			this.EmployeeSalaryTextbox.Style = MetroFramework.MetroColorStyle.Green;
			this.EmployeeSalaryTextbox.TabIndex = 16;
			this.EmployeeSalaryTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.EmployeeSalaryTextbox.UseSelectable = true;
			this.EmployeeSalaryTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.EmployeeSalaryTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// YearsWorkedTextbox
			// 
			this.YearsWorkedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.YearsWorkedTextbox.CustomButton.Image = null;
			this.YearsWorkedTextbox.CustomButton.Location = new System.Drawing.Point(403, 1);
			this.YearsWorkedTextbox.CustomButton.Name = "";
			this.YearsWorkedTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.YearsWorkedTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.YearsWorkedTextbox.CustomButton.TabIndex = 1;
			this.YearsWorkedTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.YearsWorkedTextbox.CustomButton.UseSelectable = true;
			this.YearsWorkedTextbox.CustomButton.Visible = false;
			this.YearsWorkedTextbox.Lines = new string[0];
			this.YearsWorkedTextbox.Location = new System.Drawing.Point(117, 42);
			this.YearsWorkedTextbox.MaxLength = 32767;
			this.YearsWorkedTextbox.Name = "YearsWorkedTextbox";
			this.YearsWorkedTextbox.PasswordChar = '\0';
			this.YearsWorkedTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.YearsWorkedTextbox.SelectedText = "";
			this.YearsWorkedTextbox.SelectionLength = 0;
			this.YearsWorkedTextbox.SelectionStart = 0;
			this.YearsWorkedTextbox.ShortcutsEnabled = true;
			this.YearsWorkedTextbox.Size = new System.Drawing.Size(425, 23);
			this.YearsWorkedTextbox.Style = MetroFramework.MetroColorStyle.Green;
			this.YearsWorkedTextbox.TabIndex = 17;
			this.YearsWorkedTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.YearsWorkedTextbox.UseSelectable = true;
			this.YearsWorkedTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.YearsWorkedTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AgeTextbox
			// 
			this.AgeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.AgeTextbox.CustomButton.Image = null;
			this.AgeTextbox.CustomButton.Location = new System.Drawing.Point(403, 1);
			this.AgeTextbox.CustomButton.Name = "";
			this.AgeTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AgeTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AgeTextbox.CustomButton.TabIndex = 1;
			this.AgeTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AgeTextbox.CustomButton.UseSelectable = true;
			this.AgeTextbox.CustomButton.Visible = false;
			this.AgeTextbox.Lines = new string[0];
			this.AgeTextbox.Location = new System.Drawing.Point(117, 71);
			this.AgeTextbox.MaxLength = 32767;
			this.AgeTextbox.Name = "AgeTextbox";
			this.AgeTextbox.PasswordChar = '\0';
			this.AgeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AgeTextbox.SelectedText = "";
			this.AgeTextbox.SelectionLength = 0;
			this.AgeTextbox.SelectionStart = 0;
			this.AgeTextbox.ShortcutsEnabled = true;
			this.AgeTextbox.Size = new System.Drawing.Size(425, 23);
			this.AgeTextbox.Style = MetroFramework.MetroColorStyle.Green;
			this.AgeTextbox.TabIndex = 18;
			this.AgeTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.AgeTextbox.UseSelectable = true;
			this.AgeTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AgeTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// MetroStyleManager
			// 
			this.MetroStyleManager.Owner = this;
			this.MetroStyleManager.Style = MetroFramework.MetroColorStyle.Green;
			this.MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// ParameterGroup
			// 
			this.ParameterGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ParameterGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ParameterGroup.Controls.Add(this.AgeLabel);
			this.ParameterGroup.Controls.Add(this.AgeTextbox);
			this.ParameterGroup.Controls.Add(this.YearsWorkedLabel);
			this.ParameterGroup.Controls.Add(this.EmployeeSalaryTextbox);
			this.ParameterGroup.Controls.Add(this.YearsWorkedTextbox);
			this.ParameterGroup.Controls.Add(this.EmployeeSalaryLabel);
			this.ParameterGroup.HorizontalScrollbarBarColor = true;
			this.ParameterGroup.HorizontalScrollbarHighlightOnWheel = false;
			this.ParameterGroup.HorizontalScrollbarSize = 10;
			this.ParameterGroup.Location = new System.Drawing.Point(23, 129);
			this.ParameterGroup.Name = "ParameterGroup";
			this.ParameterGroup.Size = new System.Drawing.Size(547, 300);
			this.ParameterGroup.Style = MetroFramework.MetroColorStyle.Green;
			this.ParameterGroup.TabIndex = 14;
			this.ParameterGroup.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ParameterGroup.VerticalScrollbarBarColor = true;
			this.ParameterGroup.VerticalScrollbarHighlightOnWheel = false;
			this.ParameterGroup.VerticalScrollbarSize = 10;
			// 
			// parametersLabel
			// 
			this.parametersLabel.AutoSize = true;
			this.parametersLabel.Location = new System.Drawing.Point(23, 107);
			this.parametersLabel.Name = "parametersLabel";
			this.parametersLabel.Size = new System.Drawing.Size(75, 19);
			this.parametersLabel.Style = MetroFramework.MetroColorStyle.Green;
			this.parametersLabel.TabIndex = 19;
			this.parametersLabel.Text = "Parameters";
			this.parametersLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// CalculationMenu
			// 
			this.CalculationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateRaiseToolStripMenuItem,
            this.calculateVacationDaysToolStripMenuItem,
            this.calculateBonusStripMenuItem,
            this.calculateEverythingToolStripMenuItem});
			this.CalculationMenu.Name = "CalculationMenu";
			this.CalculationMenu.Size = new System.Drawing.Size(200, 92);
			this.CalculationMenu.Text = "Calculations";
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
			// calculateBonusStripMenuItem
			// 
			this.calculateBonusStripMenuItem.Name = "calculateBonusStripMenuItem";
			this.calculateBonusStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.calculateBonusStripMenuItem.Text = "Calculate Bonus";
			this.calculateBonusStripMenuItem.Click += new System.EventHandler(this.calculateBonusToolStripMenuItem_Click);
			// 
			// calculateEverythingToolStripMenuItem
			// 
			this.calculateEverythingToolStripMenuItem.Name = "calculateEverythingToolStripMenuItem";
			this.calculateEverythingToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.calculateEverythingToolStripMenuItem.Text = "Calculate Everything";
			this.calculateEverythingToolStripMenuItem.Click += new System.EventHandler(this.calculateEverythingToolStripMenuItem_Click);
			// 
			// CalculationMenuButton
			// 
			this.CalculationMenuButton.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.CalculationMenuButton.Location = new System.Drawing.Point(23, 63);
			this.CalculationMenuButton.Name = "CalculationMenuButton";
			this.CalculationMenuButton.Size = new System.Drawing.Size(93, 23);
			this.CalculationMenuButton.Style = MetroFramework.MetroColorStyle.Green;
			this.CalculationMenuButton.TabIndex = 21;
			this.CalculationMenuButton.Text = "Calculations";
			this.CalculationMenuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.CalculationMenuButton.UseSelectable = true;
			this.CalculationMenuButton.Click += new System.EventHandler(this.CalculationMenuButton_Click);
			// 
			// StartupCEOForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(593, 490);
			this.Controls.Add(this.CalculationMenuButton);
			this.Controls.Add(this.parametersLabel);
			this.Controls.Add(this.ParameterGroup);
			this.Controls.Add(this.ClearButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(348, 300);
			this.Name = "StartupCEOForm";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Green;
			this.Text = "Employee Benefits Calculator";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
			this.ParameterGroup.ResumeLayout(false);
			this.ParameterGroup.PerformLayout();
			this.CalculationMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolTip ClearButtonTooltip;
		private MetroFramework.Controls.MetroButton ClearButton;
		private MetroFramework.Controls.MetroLabel EmployeeSalaryLabel;
		private MetroFramework.Controls.MetroLabel YearsWorkedLabel;
		private MetroFramework.Controls.MetroLabel AgeLabel;
		private MetroFramework.Controls.MetroTextBox AgeTextbox;
		private MetroFramework.Controls.MetroTextBox YearsWorkedTextbox;
		private MetroFramework.Controls.MetroTextBox EmployeeSalaryTextbox;
		private MetroFramework.Components.MetroStyleManager MetroStyleManager;
		private MetroFramework.Controls.MetroLabel parametersLabel;
		private MetroFramework.Controls.MetroPanel ParameterGroup;
		private MetroFramework.Controls.MetroContextMenu CalculationMenu;
		private System.Windows.Forms.ToolStripMenuItem calculateRaiseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateVacationDaysToolStripMenuItem;
		private MetroFramework.Controls.MetroLink CalculationMenuButton;
		private System.Windows.Forms.ToolStripMenuItem calculateBonusStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateEverythingToolStripMenuItem;
	}
}

