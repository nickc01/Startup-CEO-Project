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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.NameTextbox = new MetroFramework.Controls.MetroTextBox();
			this.nameLabel = new MetroFramework.Controls.MetroLabel();
			this.addEmployeeButton = new MetroFramework.Controls.MetroButton();
			this.parametersLabel = new MetroFramework.Controls.MetroLabel();
			this.CalculationMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.calculateRaiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateVacationDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateBonusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CalculationMenuButton = new MetroFramework.Controls.MetroLink();
			this.employeePanel = new MetroFramework.Controls.MetroPanel();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.SaveEmployeesButton = new MetroFramework.Controls.MetroButton();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.LoadEmployeesButton = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.ClearEmployeesButton = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.RemoveEmployeeButton = new MetroFramework.Controls.MetroButton();
			this.employeesGrid = new MetroFramework.Controls.MetroGrid();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YearsWorkedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeesLabel = new MetroFramework.Controls.MetroLabel();
			this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
			this.ColorComboBox = new MetroFramework.Controls.MetroComboBox();
			this.colorLabel = new MetroFramework.Controls.MetroLabel();
			this.themeLabel = new MetroFramework.Controls.MetroLabel();
			this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
			this.settingsLabel = new MetroFramework.Controls.MetroLabel();
			this.resetThemeButton = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
			this.ParameterGroup.SuspendLayout();
			this.CalculationMenu.SuspendLayout();
			this.employeePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
			this.metroPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearButton.Location = new System.Drawing.Point(324, 135);
			this.ClearButton.Margin = new System.Windows.Forms.Padding(9);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(78, 23);
			this.ClearButton.TabIndex = 12;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseSelectable = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// EmployeeSalaryLabel
			// 
			this.EmployeeSalaryLabel.AutoSize = true;
			this.EmployeeSalaryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.EmployeeSalaryLabel.Location = new System.Drawing.Point(8, 13);
			this.EmployeeSalaryLabel.Name = "EmployeeSalaryLabel";
			this.EmployeeSalaryLabel.Size = new System.Drawing.Size(108, 19);
			this.EmployeeSalaryLabel.TabIndex = 13;
			this.EmployeeSalaryLabel.Text = "Employee Salary";
			// 
			// YearsWorkedLabel
			// 
			this.YearsWorkedLabel.AutoSize = true;
			this.YearsWorkedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.YearsWorkedLabel.Location = new System.Drawing.Point(8, 42);
			this.YearsWorkedLabel.Name = "YearsWorkedLabel";
			this.YearsWorkedLabel.Size = new System.Drawing.Size(92, 19);
			this.YearsWorkedLabel.TabIndex = 14;
			this.YearsWorkedLabel.Text = "Years Worked";
			// 
			// AgeLabel
			// 
			this.AgeLabel.AutoSize = true;
			this.AgeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.AgeLabel.Location = new System.Drawing.Point(8, 71);
			this.AgeLabel.Name = "AgeLabel";
			this.AgeLabel.Size = new System.Drawing.Size(33, 19);
			this.AgeLabel.TabIndex = 15;
			this.AgeLabel.Text = "Age";
			// 
			// EmployeeSalaryTextbox
			// 
			this.EmployeeSalaryTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.EmployeeSalaryTextbox.CustomButton.Image = null;
			this.EmployeeSalaryTextbox.CustomButton.Location = new System.Drawing.Point(198, 1);
			this.EmployeeSalaryTextbox.CustomButton.Name = "";
			this.EmployeeSalaryTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.EmployeeSalaryTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.EmployeeSalaryTextbox.CustomButton.TabIndex = 1;
			this.EmployeeSalaryTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.EmployeeSalaryTextbox.CustomButton.UseSelectable = true;
			this.EmployeeSalaryTextbox.CustomButton.Visible = false;
			this.EmployeeSalaryTextbox.Lines = new string[0];
			this.EmployeeSalaryTextbox.Location = new System.Drawing.Point(182, 13);
			this.EmployeeSalaryTextbox.MaxLength = 32767;
			this.EmployeeSalaryTextbox.Name = "EmployeeSalaryTextbox";
			this.EmployeeSalaryTextbox.PasswordChar = '\0';
			this.EmployeeSalaryTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.EmployeeSalaryTextbox.SelectedText = "";
			this.EmployeeSalaryTextbox.SelectionLength = 0;
			this.EmployeeSalaryTextbox.SelectionStart = 0;
			this.EmployeeSalaryTextbox.ShortcutsEnabled = true;
			this.EmployeeSalaryTextbox.Size = new System.Drawing.Size(220, 23);
			this.EmployeeSalaryTextbox.TabIndex = 16;
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
			this.YearsWorkedTextbox.CustomButton.Location = new System.Drawing.Point(198, 1);
			this.YearsWorkedTextbox.CustomButton.Name = "";
			this.YearsWorkedTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.YearsWorkedTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.YearsWorkedTextbox.CustomButton.TabIndex = 1;
			this.YearsWorkedTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.YearsWorkedTextbox.CustomButton.UseSelectable = true;
			this.YearsWorkedTextbox.CustomButton.Visible = false;
			this.YearsWorkedTextbox.Lines = new string[0];
			this.YearsWorkedTextbox.Location = new System.Drawing.Point(182, 42);
			this.YearsWorkedTextbox.MaxLength = 32767;
			this.YearsWorkedTextbox.Name = "YearsWorkedTextbox";
			this.YearsWorkedTextbox.PasswordChar = '\0';
			this.YearsWorkedTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.YearsWorkedTextbox.SelectedText = "";
			this.YearsWorkedTextbox.SelectionLength = 0;
			this.YearsWorkedTextbox.SelectionStart = 0;
			this.YearsWorkedTextbox.ShortcutsEnabled = true;
			this.YearsWorkedTextbox.Size = new System.Drawing.Size(220, 23);
			this.YearsWorkedTextbox.TabIndex = 17;
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
			this.AgeTextbox.CustomButton.Location = new System.Drawing.Point(198, 1);
			this.AgeTextbox.CustomButton.Name = "";
			this.AgeTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.AgeTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.AgeTextbox.CustomButton.TabIndex = 1;
			this.AgeTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.AgeTextbox.CustomButton.UseSelectable = true;
			this.AgeTextbox.CustomButton.Visible = false;
			this.AgeTextbox.Lines = new string[0];
			this.AgeTextbox.Location = new System.Drawing.Point(182, 71);
			this.AgeTextbox.MaxLength = 32767;
			this.AgeTextbox.Name = "AgeTextbox";
			this.AgeTextbox.PasswordChar = '\0';
			this.AgeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.AgeTextbox.SelectedText = "";
			this.AgeTextbox.SelectionLength = 0;
			this.AgeTextbox.SelectionStart = 0;
			this.AgeTextbox.ShortcutsEnabled = true;
			this.AgeTextbox.Size = new System.Drawing.Size(220, 23);
			this.AgeTextbox.TabIndex = 18;
			this.AgeTextbox.UseSelectable = true;
			this.AgeTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.AgeTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// MetroStyleManager
			// 
			this.MetroStyleManager.Owner = this;
			// 
			// ParameterGroup
			// 
			this.ParameterGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ParameterGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ParameterGroup.Controls.Add(this.NameTextbox);
			this.ParameterGroup.Controls.Add(this.nameLabel);
			this.ParameterGroup.Controls.Add(this.addEmployeeButton);
			this.ParameterGroup.Controls.Add(this.AgeLabel);
			this.ParameterGroup.Controls.Add(this.AgeTextbox);
			this.ParameterGroup.Controls.Add(this.YearsWorkedLabel);
			this.ParameterGroup.Controls.Add(this.EmployeeSalaryTextbox);
			this.ParameterGroup.Controls.Add(this.YearsWorkedTextbox);
			this.ParameterGroup.Controls.Add(this.ClearButton);
			this.ParameterGroup.Controls.Add(this.EmployeeSalaryLabel);
			this.ParameterGroup.HorizontalScrollbarBarColor = true;
			this.ParameterGroup.HorizontalScrollbarHighlightOnWheel = false;
			this.ParameterGroup.HorizontalScrollbarSize = 10;
			this.ParameterGroup.Location = new System.Drawing.Point(23, 129);
			this.ParameterGroup.Margin = new System.Windows.Forms.Padding(9);
			this.ParameterGroup.Name = "ParameterGroup";
			this.ParameterGroup.Size = new System.Drawing.Size(413, 169);
			this.ParameterGroup.TabIndex = 14;
			this.ParameterGroup.VerticalScrollbarBarColor = true;
			this.ParameterGroup.VerticalScrollbarHighlightOnWheel = false;
			this.ParameterGroup.VerticalScrollbarSize = 10;
			// 
			// NameTextbox
			// 
			this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.NameTextbox.CustomButton.Image = null;
			this.NameTextbox.CustomButton.Location = new System.Drawing.Point(198, 1);
			this.NameTextbox.CustomButton.Name = "";
			this.NameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.NameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.NameTextbox.CustomButton.TabIndex = 1;
			this.NameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.NameTextbox.CustomButton.UseSelectable = true;
			this.NameTextbox.CustomButton.Visible = false;
			this.NameTextbox.Lines = new string[0];
			this.NameTextbox.Location = new System.Drawing.Point(182, 100);
			this.NameTextbox.MaxLength = 32767;
			this.NameTextbox.Name = "NameTextbox";
			this.NameTextbox.PasswordChar = '\0';
			this.NameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.NameTextbox.SelectedText = "";
			this.NameTextbox.SelectionLength = 0;
			this.NameTextbox.SelectionStart = 0;
			this.NameTextbox.ShortcutsEnabled = true;
			this.NameTextbox.Size = new System.Drawing.Size(220, 23);
			this.NameTextbox.TabIndex = 26;
			this.NameTextbox.UseSelectable = true;
			this.NameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.NameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.nameLabel.Location = new System.Drawing.Point(8, 100);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(45, 19);
			this.nameLabel.TabIndex = 25;
			this.nameLabel.Text = "Name";
			// 
			// addEmployeeButton
			// 
			this.addEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addEmployeeButton.Location = new System.Drawing.Point(8, 135);
			this.addEmployeeButton.Name = "addEmployeeButton";
			this.addEmployeeButton.Size = new System.Drawing.Size(114, 23);
			this.addEmployeeButton.TabIndex = 24;
			this.addEmployeeButton.Text = "Add Employee";
			this.addEmployeeButton.UseSelectable = true;
			this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
			// 
			// parametersLabel
			// 
			this.parametersLabel.AutoSize = true;
			this.parametersLabel.Location = new System.Drawing.Point(23, 107);
			this.parametersLabel.Name = "parametersLabel";
			this.parametersLabel.Size = new System.Drawing.Size(75, 19);
			this.parametersLabel.TabIndex = 19;
			this.parametersLabel.Text = "Parameters";
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
			this.CalculationMenuButton.TabIndex = 21;
			this.CalculationMenuButton.Text = "Calculations";
			this.CalculationMenuButton.UseSelectable = true;
			this.CalculationMenuButton.Click += new System.EventHandler(this.CalculationMenuButton_Click);
			// 
			// employeePanel
			// 
			this.employeePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.employeePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.employeePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.employeePanel.Controls.Add(this.metroButton4);
			this.employeePanel.Controls.Add(this.SaveEmployeesButton);
			this.employeePanel.Controls.Add(this.metroButton3);
			this.employeePanel.Controls.Add(this.LoadEmployeesButton);
			this.employeePanel.Controls.Add(this.metroButton2);
			this.employeePanel.Controls.Add(this.ClearEmployeesButton);
			this.employeePanel.Controls.Add(this.metroButton1);
			this.employeePanel.Controls.Add(this.RemoveEmployeeButton);
			this.employeePanel.Controls.Add(this.employeesGrid);
			this.employeePanel.HorizontalScrollbarBarColor = true;
			this.employeePanel.HorizontalScrollbarHighlightOnWheel = false;
			this.employeePanel.HorizontalScrollbarSize = 10;
			this.employeePanel.Location = new System.Drawing.Point(448, 129);
			this.employeePanel.Name = "employeePanel";
			this.employeePanel.Size = new System.Drawing.Size(468, 169);
			this.employeePanel.TabIndex = 22;
			this.employeePanel.VerticalScrollbarBarColor = true;
			this.employeePanel.VerticalScrollbarHighlightOnWheel = false;
			this.employeePanel.VerticalScrollbarSize = 10;
			// 
			// metroButton4
			// 
			this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroButton4.Location = new System.Drawing.Point(253, 135);
			this.metroButton4.Margin = new System.Windows.Forms.Padding(9);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(92, 27);
			this.metroButton4.TabIndex = 30;
			this.metroButton4.Text = "Save";
			this.metroButton4.UseSelectable = true;
			this.metroButton4.Click += new System.EventHandler(this.SaveEmployeesButton_Click);
			// 
			// SaveEmployeesButton
			// 
			this.SaveEmployeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveEmployeesButton.Enabled = false;
			this.SaveEmployeesButton.Location = new System.Drawing.Point(253, 135);
			this.SaveEmployeesButton.Margin = new System.Windows.Forms.Padding(9);
			this.SaveEmployeesButton.Name = "SaveEmployeesButton";
			this.SaveEmployeesButton.Size = new System.Drawing.Size(92, 23);
			this.SaveEmployeesButton.Style = MetroFramework.MetroColorStyle.Green;
			this.SaveEmployeesButton.TabIndex = 30;
			this.SaveEmployeesButton.Text = "Save";
			this.SaveEmployeesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.SaveEmployeesButton.UseSelectable = true;
			this.SaveEmployeesButton.Click += new System.EventHandler(this.SaveEmployeesButton_Click);
			// 
			// metroButton3
			// 
			this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroButton3.Location = new System.Drawing.Point(363, 135);
			this.metroButton3.Margin = new System.Windows.Forms.Padding(9);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(94, 27);
			this.metroButton3.TabIndex = 31;
			this.metroButton3.Text = "Load";
			this.metroButton3.UseSelectable = true;
			this.metroButton3.Click += new System.EventHandler(this.LoadEmployeesButton_Click);
			// 
			// LoadEmployeesButton
			// 
			this.LoadEmployeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LoadEmployeesButton.Location = new System.Drawing.Point(363, 135);
			this.LoadEmployeesButton.Margin = new System.Windows.Forms.Padding(9);
			this.LoadEmployeesButton.Name = "LoadEmployeesButton";
			this.LoadEmployeesButton.Size = new System.Drawing.Size(94, 23);
			this.LoadEmployeesButton.Style = MetroFramework.MetroColorStyle.Green;
			this.LoadEmployeesButton.TabIndex = 31;
			this.LoadEmployeesButton.Text = "Load";
			this.LoadEmployeesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.LoadEmployeesButton.UseSelectable = true;
			this.LoadEmployeesButton.Click += new System.EventHandler(this.LoadEmployeesButton_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroButton2.Location = new System.Drawing.Point(140, 135);
			this.metroButton2.Margin = new System.Windows.Forms.Padding(9);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(95, 27);
			this.metroButton2.TabIndex = 27;
			this.metroButton2.Text = "Clear All";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.ClearEmployeesButton_Click);
			// 
			// ClearEmployeesButton
			// 
			this.ClearEmployeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ClearEmployeesButton.Enabled = false;
			this.ClearEmployeesButton.Location = new System.Drawing.Point(140, 135);
			this.ClearEmployeesButton.Margin = new System.Windows.Forms.Padding(9);
			this.ClearEmployeesButton.Name = "ClearEmployeesButton";
			this.ClearEmployeesButton.Size = new System.Drawing.Size(95, 23);
			this.ClearEmployeesButton.Style = MetroFramework.MetroColorStyle.Green;
			this.ClearEmployeesButton.TabIndex = 27;
			this.ClearEmployeesButton.Text = "Clear All";
			this.ClearEmployeesButton.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ClearEmployeesButton.UseSelectable = true;
			this.ClearEmployeesButton.Click += new System.EventHandler(this.ClearEmployeesButton_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroButton1.Location = new System.Drawing.Point(9, 135);
			this.metroButton1.Margin = new System.Windows.Forms.Padding(9);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(113, 27);
			this.metroButton1.TabIndex = 28;
			this.metroButton1.Text = "Remove Employee";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
			// 
			// RemoveEmployeeButton
			// 
			this.RemoveEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveEmployeeButton.Enabled = false;
			this.RemoveEmployeeButton.Location = new System.Drawing.Point(9, 135);
			this.RemoveEmployeeButton.Margin = new System.Windows.Forms.Padding(9);
			this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
			this.RemoveEmployeeButton.Size = new System.Drawing.Size(113, 23);
			this.RemoveEmployeeButton.TabIndex = 28;
			this.RemoveEmployeeButton.Text = "Remove Employee";
			this.RemoveEmployeeButton.UseSelectable = true;
			this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
			// 
			// employeesGrid
			// 
			this.employeesGrid.AllowUserToAddRows = false;
			this.employeesGrid.AllowUserToDeleteRows = false;
			this.employeesGrid.AllowUserToResizeColumns = false;
			this.employeesGrid.AllowUserToResizeRows = false;
			this.employeesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.employeesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.employeesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.employeesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.employeesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.employeesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.AgeColumn,
            this.YearsWorkedColumn,
            this.SalaryColumn});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.employeesGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.employeesGrid.EnableHeadersVisualStyles = false;
			this.employeesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.employeesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.employeesGrid.Location = new System.Drawing.Point(3, 3);
			this.employeesGrid.MultiSelect = false;
			this.employeesGrid.Name = "employeesGrid";
			this.employeesGrid.ReadOnly = true;
			this.employeesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.employeesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.employeesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.employeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.employeesGrid.Size = new System.Drawing.Size(460, 120);
			this.employeesGrid.TabIndex = 2;
			this.employeesGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.employeesGrid_RowsAdded);
			this.employeesGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.employeesGrid_RowsRemoved);
			this.employeesGrid.SelectionChanged += new System.EventHandler(this.metroGrid1_SelectionChanged);
			// 
			// NameColumn
			// 
			this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameColumn.FillWeight = 150F;
			this.NameColumn.HeaderText = "Employee Name";
			this.NameColumn.Name = "NameColumn";
			this.NameColumn.ReadOnly = true;
			this.NameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// AgeColumn
			// 
			this.AgeColumn.FillWeight = 50F;
			this.AgeColumn.HeaderText = "Age";
			this.AgeColumn.Name = "AgeColumn";
			this.AgeColumn.ReadOnly = true;
			this.AgeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.AgeColumn.Width = 50;
			// 
			// YearsWorkedColumn
			// 
			this.YearsWorkedColumn.FillWeight = 80F;
			this.YearsWorkedColumn.HeaderText = "Years Worked";
			this.YearsWorkedColumn.Name = "YearsWorkedColumn";
			this.YearsWorkedColumn.ReadOnly = true;
			this.YearsWorkedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.YearsWorkedColumn.Width = 80;
			// 
			// SalaryColumn
			// 
			this.SalaryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SalaryColumn.FillWeight = 120F;
			this.SalaryColumn.HeaderText = "Salary";
			this.SalaryColumn.Name = "SalaryColumn";
			this.SalaryColumn.ReadOnly = true;
			this.SalaryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// EmployeesLabel
			// 
			this.EmployeesLabel.AutoSize = true;
			this.EmployeesLabel.Location = new System.Drawing.Point(448, 107);
			this.EmployeesLabel.Name = "EmployeesLabel";
			this.EmployeesLabel.Size = new System.Drawing.Size(72, 19);
			this.EmployeesLabel.TabIndex = 23;
			this.EmployeesLabel.Text = "Employees";
			// 
			// metroPanel2
			// 
			this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.metroPanel2.Controls.Add(this.resetThemeButton);
			this.metroPanel2.Controls.Add(this.ColorComboBox);
			this.metroPanel2.Controls.Add(this.colorLabel);
			this.metroPanel2.Controls.Add(this.themeLabel);
			this.metroPanel2.Controls.Add(this.ThemeComboBox);
			this.metroPanel2.HorizontalScrollbarBarColor = true;
			this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel2.HorizontalScrollbarSize = 10;
			this.metroPanel2.Location = new System.Drawing.Point(928, 129);
			this.metroPanel2.Margin = new System.Windows.Forms.Padding(9);
			this.metroPanel2.Name = "metroPanel2";
			this.metroPanel2.Padding = new System.Windows.Forms.Padding(3);
			this.metroPanel2.Size = new System.Drawing.Size(202, 169);
			this.metroPanel2.TabIndex = 24;
			this.metroPanel2.VerticalScrollbarBarColor = true;
			this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel2.VerticalScrollbarSize = 10;
			// 
			// ColorComboBox
			// 
			this.ColorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ColorComboBox.FormattingEnabled = true;
			this.ColorComboBox.ItemHeight = 23;
			this.ColorComboBox.Items.AddRange(new object[] {
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
			this.ColorComboBox.Location = new System.Drawing.Point(76, 41);
			this.ColorComboBox.Name = "ColorComboBox";
			this.ColorComboBox.Size = new System.Drawing.Size(118, 29);
			this.ColorComboBox.TabIndex = 5;
			this.ColorComboBox.UseSelectable = true;
			this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
			// 
			// colorLabel
			// 
			this.colorLabel.AutoSize = true;
			this.colorLabel.Location = new System.Drawing.Point(6, 46);
			this.colorLabel.Name = "colorLabel";
			this.colorLabel.Size = new System.Drawing.Size(42, 19);
			this.colorLabel.TabIndex = 4;
			this.colorLabel.Text = "Color";
			// 
			// themeLabel
			// 
			this.themeLabel.AutoSize = true;
			this.themeLabel.Location = new System.Drawing.Point(6, 13);
			this.themeLabel.Name = "themeLabel";
			this.themeLabel.Size = new System.Drawing.Size(49, 19);
			this.themeLabel.TabIndex = 3;
			this.themeLabel.Text = "Theme";
			// 
			// ThemeComboBox
			// 
			this.ThemeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ThemeComboBox.FormattingEnabled = true;
			this.ThemeComboBox.ItemHeight = 23;
			this.ThemeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
			this.ThemeComboBox.Location = new System.Drawing.Point(76, 6);
			this.ThemeComboBox.Name = "ThemeComboBox";
			this.ThemeComboBox.Size = new System.Drawing.Size(118, 29);
			this.ThemeComboBox.TabIndex = 2;
			this.ThemeComboBox.UseSelectable = true;
			this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
			// 
			// settingsLabel
			// 
			this.settingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsLabel.AutoSize = true;
			this.settingsLabel.Location = new System.Drawing.Point(922, 107);
			this.settingsLabel.Name = "settingsLabel";
			this.settingsLabel.Size = new System.Drawing.Size(54, 19);
			this.settingsLabel.TabIndex = 25;
			this.settingsLabel.Text = "Settings";
			// 
			// resetThemeButton
			// 
			this.resetThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resetThemeButton.Location = new System.Drawing.Point(76, 76);
			this.resetThemeButton.Name = "resetThemeButton";
			this.resetThemeButton.Size = new System.Drawing.Size(118, 23);
			this.resetThemeButton.TabIndex = 6;
			this.resetThemeButton.Text = "Reset Theme";
			this.resetThemeButton.UseSelectable = true;
			this.resetThemeButton.Click += new System.EventHandler(this.resetThemeButton_Click);
			// 
			// StartupCEOForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(1153, 321);
			this.Controls.Add(this.settingsLabel);
			this.Controls.Add(this.metroPanel2);
			this.Controls.Add(this.EmployeesLabel);
			this.Controls.Add(this.employeePanel);
			this.Controls.Add(this.CalculationMenuButton);
			this.Controls.Add(this.parametersLabel);
			this.Controls.Add(this.ParameterGroup);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1153, 321);
			this.Name = "StartupCEOForm";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Style = MetroFramework.MetroColorStyle.Default;
			this.Text = "Employee Benefits Calculator";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartupCEOForm_FormClosed);
			this.Load += new System.EventHandler(this.StartupCEOForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
			this.ParameterGroup.ResumeLayout(false);
			this.ParameterGroup.PerformLayout();
			this.CalculationMenu.ResumeLayout(false);
			this.employeePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
			this.metroPanel2.ResumeLayout(false);
			this.metroPanel2.PerformLayout();
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
		private MetroFramework.Controls.MetroLabel parametersLabel;
		private MetroFramework.Controls.MetroPanel ParameterGroup;
		private MetroFramework.Controls.MetroContextMenu CalculationMenu;
		private System.Windows.Forms.ToolStripMenuItem calculateRaiseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateVacationDaysToolStripMenuItem;
		private MetroFramework.Controls.MetroLink CalculationMenuButton;
		private System.Windows.Forms.ToolStripMenuItem calculateBonusStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateEverythingToolStripMenuItem;
		private MetroFramework.Controls.MetroPanel employeePanel;
		private MetroFramework.Controls.MetroLabel EmployeesLabel;
		private MetroFramework.Controls.MetroButton addEmployeeButton;
		private MetroFramework.Controls.MetroTextBox NameTextbox;
		private MetroFramework.Controls.MetroLabel nameLabel;
		public MetroFramework.Controls.MetroGrid employeesGrid;
		private MetroFramework.Controls.MetroButton RemoveEmployeeButton;
		private MetroFramework.Controls.MetroButton ClearEmployeesButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn YearsWorkedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
		private MetroFramework.Controls.MetroButton LoadEmployeesButton;
		private MetroFramework.Controls.MetroButton SaveEmployeesButton;
		private MetroFramework.Controls.MetroPanel metroPanel2;
		private MetroFramework.Controls.MetroLabel settingsLabel;
		private MetroFramework.Controls.MetroLabel themeLabel;
		private MetroFramework.Controls.MetroComboBox ThemeComboBox;
		private MetroFramework.Controls.MetroComboBox ColorComboBox;
		private MetroFramework.Controls.MetroLabel colorLabel;
		public MetroFramework.Components.MetroStyleManager MetroStyleManager;
		private MetroFramework.Controls.MetroButton metroButton4;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton resetThemeButton;
	}
}

