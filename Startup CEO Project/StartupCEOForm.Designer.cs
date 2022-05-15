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
			this.ClearButton = new MetroFramework.Controls.MetroButton();
			this.EmployeeSalaryLabel = new MetroFramework.Controls.MetroLabel();
			this.YearsWorkedLabel = new MetroFramework.Controls.MetroLabel();
			this.AgeLabel = new MetroFramework.Controls.MetroLabel();
			this.EmployeeSalaryTextbox = new MetroFramework.Controls.MetroTextBox();
			this.YearsWorkedTextbox = new MetroFramework.Controls.MetroTextBox();
			this.AgeTextbox = new MetroFramework.Controls.MetroTextBox();
			this.MetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
			this.ParameterGroup = new MetroFramework.Controls.MetroPanel();
			this.EducationLabel = new MetroFramework.Controls.MetroLabel();
			this.EducationTextBox = new MetroFramework.Controls.MetroTextBox();
			this.PositionLabel = new MetroFramework.Controls.MetroLabel();
			this.JobPositionTextBox = new MetroFramework.Controls.MetroTextBox();
			this.NameTextbox = new MetroFramework.Controls.MetroTextBox();
			this.nameLabel = new MetroFramework.Controls.MetroLabel();
			this.addEmployeeButton = new MetroFramework.Controls.MetroButton();
			this.CalculationMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.calculateRaiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateVacationDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateBonusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateBreakTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateAmountOfBreaksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculateEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeesGrid = new MetroFramework.Controls.MetroGrid();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YearsWorkedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JobPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EducationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeesLabel = new MetroFramework.Controls.MetroLabel();
			this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
			this.resetThemeButton = new MetroFramework.Controls.MetroButton();
			this.ColorComboBox = new MetroFramework.Controls.MetroComboBox();
			this.colorLabel = new MetroFramework.Controls.MetroLabel();
			this.themeLabel = new MetroFramework.Controls.MetroLabel();
			this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
			this.parametersLabel = new MetroFramework.Controls.MetroLabel();
			this.MainTabControl = new MetroFramework.Controls.MetroTabControl();
			this.employeesPage = new MetroFramework.Controls.MetroTabPage();
			this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
			this.calculationsButton = new MetroFramework.Controls.MetroButton();
			this.LoadEmployeesButton = new MetroFramework.Controls.MetroButton();
			this.RemoveEmployeeButton = new MetroFramework.Controls.MetroButton();
			this.SaveEmployeesButton = new MetroFramework.Controls.MetroButton();
			this.ClearEmployeesButton = new MetroFramework.Controls.MetroButton();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.settingsPage = new MetroFramework.Controls.MetroTabPage();
			this.AboutPage = new MetroFramework.Controls.MetroTabPage();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MainTooltip = new MetroFramework.Components.MetroToolTip();
			((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
			this.ParameterGroup.SuspendLayout();
			this.CalculationMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
			this.metroPanel2.SuspendLayout();
			this.MainTabControl.SuspendLayout();
			this.employeesPage.SuspendLayout();
			this.metroPanel3.SuspendLayout();
			this.metroPanel1.SuspendLayout();
			this.settingsPage.SuspendLayout();
			this.AboutPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ClearButton.Location = new System.Drawing.Point(129, 5);
			this.ClearButton.Margin = new System.Windows.Forms.Padding(9);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(132, 23);
			this.ClearButton.TabIndex = 5;
			this.ClearButton.Text = "Clear Parameters";
			this.MainTooltip.SetToolTip(this.ClearButton, "Clears all the parameters");
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
			this.MainTooltip.SetToolTip(this.EmployeeSalaryLabel, "The salary of the employee");
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
			this.MainTooltip.SetToolTip(this.YearsWorkedLabel, "  How many years the employee has worked at the company  ");
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
			this.MainTooltip.SetToolTip(this.AgeLabel, "How old the employee is");
			// 
			// EmployeeSalaryTextbox
			// 
			this.EmployeeSalaryTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.EmployeeSalaryTextbox.CustomButton.Image = null;
			this.EmployeeSalaryTextbox.CustomButton.Location = new System.Drawing.Point(140, 1);
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
			this.EmployeeSalaryTextbox.Size = new System.Drawing.Size(162, 23);
			this.EmployeeSalaryTextbox.TabIndex = 0;
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
			this.YearsWorkedTextbox.CustomButton.Location = new System.Drawing.Point(140, 1);
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
			this.YearsWorkedTextbox.Size = new System.Drawing.Size(162, 23);
			this.YearsWorkedTextbox.TabIndex = 1;
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
			this.AgeTextbox.CustomButton.Location = new System.Drawing.Point(140, 1);
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
			this.AgeTextbox.Size = new System.Drawing.Size(162, 23);
			this.AgeTextbox.TabIndex = 2;
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
			this.ParameterGroup.AutoScroll = true;
			this.ParameterGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ParameterGroup.Controls.Add(this.EducationLabel);
			this.ParameterGroup.Controls.Add(this.EducationTextBox);
			this.ParameterGroup.Controls.Add(this.PositionLabel);
			this.ParameterGroup.Controls.Add(this.JobPositionTextBox);
			this.ParameterGroup.Controls.Add(this.NameTextbox);
			this.ParameterGroup.Controls.Add(this.nameLabel);
			this.ParameterGroup.Controls.Add(this.AgeLabel);
			this.ParameterGroup.Controls.Add(this.AgeTextbox);
			this.ParameterGroup.Controls.Add(this.YearsWorkedLabel);
			this.ParameterGroup.Controls.Add(this.EmployeeSalaryTextbox);
			this.ParameterGroup.Controls.Add(this.YearsWorkedTextbox);
			this.ParameterGroup.Controls.Add(this.EmployeeSalaryLabel);
			this.ParameterGroup.HorizontalScrollbar = true;
			this.ParameterGroup.HorizontalScrollbarBarColor = true;
			this.ParameterGroup.HorizontalScrollbarHighlightOnWheel = false;
			this.ParameterGroup.HorizontalScrollbarSize = 10;
			this.ParameterGroup.Location = new System.Drawing.Point(0, 27);
			this.ParameterGroup.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
			this.ParameterGroup.Name = "ParameterGroup";
			this.ParameterGroup.Size = new System.Drawing.Size(372, 180);
			this.ParameterGroup.TabIndex = 14;
			this.ParameterGroup.VerticalScrollbar = true;
			this.ParameterGroup.VerticalScrollbarBarColor = true;
			this.ParameterGroup.VerticalScrollbarHighlightOnWheel = false;
			this.ParameterGroup.VerticalScrollbarSize = 10;
			// 
			// EducationLabel
			// 
			this.EducationLabel.AutoSize = true;
			this.EducationLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.EducationLabel.Location = new System.Drawing.Point(8, 158);
			this.EducationLabel.Name = "EducationLabel";
			this.EducationLabel.Size = new System.Drawing.Size(69, 19);
			this.EducationLabel.TabIndex = 29;
			this.EducationLabel.Text = "Education";
			this.MainTooltip.SetToolTip(this.EducationLabel, "The name of the employee");
			// 
			// EducationTextBox
			// 
			this.EducationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.EducationTextBox.CustomButton.Image = null;
			this.EducationTextBox.CustomButton.Location = new System.Drawing.Point(140, 1);
			this.EducationTextBox.CustomButton.Name = "";
			this.EducationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.EducationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.EducationTextBox.CustomButton.TabIndex = 1;
			this.EducationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.EducationTextBox.CustomButton.UseSelectable = true;
			this.EducationTextBox.CustomButton.Visible = false;
			this.EducationTextBox.Lines = new string[0];
			this.EducationTextBox.Location = new System.Drawing.Point(182, 158);
			this.EducationTextBox.MaxLength = 32767;
			this.EducationTextBox.Name = "EducationTextBox";
			this.EducationTextBox.PasswordChar = '\0';
			this.EducationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.EducationTextBox.SelectedText = "";
			this.EducationTextBox.SelectionLength = 0;
			this.EducationTextBox.SelectionStart = 0;
			this.EducationTextBox.ShortcutsEnabled = true;
			this.EducationTextBox.Size = new System.Drawing.Size(162, 23);
			this.EducationTextBox.TabIndex = 28;
			this.EducationTextBox.UseSelectable = true;
			this.EducationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.EducationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// PositionLabel
			// 
			this.PositionLabel.AutoSize = true;
			this.PositionLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.PositionLabel.Location = new System.Drawing.Point(8, 129);
			this.PositionLabel.Name = "PositionLabel";
			this.PositionLabel.Size = new System.Drawing.Size(82, 19);
			this.PositionLabel.TabIndex = 27;
			this.PositionLabel.Text = "Job Position";
			this.MainTooltip.SetToolTip(this.PositionLabel, "The name of the employee");
			// 
			// JobPositionTextBox
			// 
			this.JobPositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.JobPositionTextBox.CustomButton.Image = null;
			this.JobPositionTextBox.CustomButton.Location = new System.Drawing.Point(140, 1);
			this.JobPositionTextBox.CustomButton.Name = "";
			this.JobPositionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.JobPositionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.JobPositionTextBox.CustomButton.TabIndex = 1;
			this.JobPositionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.JobPositionTextBox.CustomButton.UseSelectable = true;
			this.JobPositionTextBox.CustomButton.Visible = false;
			this.JobPositionTextBox.Lines = new string[0];
			this.JobPositionTextBox.Location = new System.Drawing.Point(182, 129);
			this.JobPositionTextBox.MaxLength = 32767;
			this.JobPositionTextBox.Name = "JobPositionTextBox";
			this.JobPositionTextBox.PasswordChar = '\0';
			this.JobPositionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.JobPositionTextBox.SelectedText = "";
			this.JobPositionTextBox.SelectionLength = 0;
			this.JobPositionTextBox.SelectionStart = 0;
			this.JobPositionTextBox.ShortcutsEnabled = true;
			this.JobPositionTextBox.Size = new System.Drawing.Size(162, 23);
			this.JobPositionTextBox.TabIndex = 26;
			this.JobPositionTextBox.UseSelectable = true;
			this.JobPositionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.JobPositionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// NameTextbox
			// 
			this.NameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.NameTextbox.CustomButton.Image = null;
			this.NameTextbox.CustomButton.Location = new System.Drawing.Point(140, 1);
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
			this.NameTextbox.Size = new System.Drawing.Size(162, 23);
			this.NameTextbox.TabIndex = 3;
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
			this.MainTooltip.SetToolTip(this.nameLabel, "The name of the employee");
			// 
			// addEmployeeButton
			// 
			this.addEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addEmployeeButton.Location = new System.Drawing.Point(8, 5);
			this.addEmployeeButton.Name = "addEmployeeButton";
			this.addEmployeeButton.Size = new System.Drawing.Size(109, 23);
			this.addEmployeeButton.TabIndex = 4;
			this.addEmployeeButton.Text = "Add Employee";
			this.MainTooltip.SetToolTip(this.addEmployeeButton, " Adds an employee to the list with the specified parameters ");
			this.addEmployeeButton.UseSelectable = true;
			this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
			// 
			// CalculationMenu
			// 
			this.CalculationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateRaiseToolStripMenuItem,
            this.calculateVacationDaysToolStripMenuItem,
            this.calculateBonusStripMenuItem,
            this.calculateBreakTimesToolStripMenuItem,
            this.calculateAmountOfBreaksToolStripMenuItem,
            this.calculateEverythingToolStripMenuItem});
			this.CalculationMenu.Name = "CalculationMenu";
			this.CalculationMenu.Size = new System.Drawing.Size(222, 136);
			this.CalculationMenu.Text = "Calculations";
			// 
			// calculateRaiseToolStripMenuItem
			// 
			this.calculateRaiseToolStripMenuItem.Name = "calculateRaiseToolStripMenuItem";
			this.calculateRaiseToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.calculateRaiseToolStripMenuItem.Text = "Calculate Raise";
			this.calculateRaiseToolStripMenuItem.Click += new System.EventHandler(this.calculateRaiseToolStripMenuItem_Click);
			// 
			// calculateVacationDaysToolStripMenuItem
			// 
			this.calculateVacationDaysToolStripMenuItem.Name = "calculateVacationDaysToolStripMenuItem";
			this.calculateVacationDaysToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.calculateVacationDaysToolStripMenuItem.Text = "Calculate Vacation Days";
			this.calculateVacationDaysToolStripMenuItem.Click += new System.EventHandler(this.calculateVacationDaysToolStripMenuItem_Click);
			// 
			// calculateBonusStripMenuItem
			// 
			this.calculateBonusStripMenuItem.Name = "calculateBonusStripMenuItem";
			this.calculateBonusStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.calculateBonusStripMenuItem.Text = "Calculate Bonus";
			this.calculateBonusStripMenuItem.Click += new System.EventHandler(this.calculateBonusToolStripMenuItem_Click);
			// 
			// calculateBreakTimesToolStripMenuItem
			// 
			this.calculateBreakTimesToolStripMenuItem.Name = "calculateBreakTimesToolStripMenuItem";
			this.calculateBreakTimesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.calculateBreakTimesToolStripMenuItem.Text = "Calculate Break Times";
			this.calculateBreakTimesToolStripMenuItem.Click += new System.EventHandler(this.calculateBreakTimesToolStripMenuItem_Click);
			// 
			// calculateAmountOfBreaksToolStripMenuItem
			// 
			this.calculateAmountOfBreaksToolStripMenuItem.Name = "calculateAmountOfBreaksToolStripMenuItem";
			this.calculateAmountOfBreaksToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.calculateAmountOfBreaksToolStripMenuItem.Text = "Calculate Amount of Breaks";
			this.calculateAmountOfBreaksToolStripMenuItem.Click += new System.EventHandler(this.calculateAmountOfBreaksToolStripMenuItem_Click);
			// 
			// calculateEverythingToolStripMenuItem
			// 
			this.calculateEverythingToolStripMenuItem.Name = "calculateEverythingToolStripMenuItem";
			this.calculateEverythingToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.calculateEverythingToolStripMenuItem.Text = "Calculate Everything";
			this.calculateEverythingToolStripMenuItem.Click += new System.EventHandler(this.calculateEverythingToolStripMenuItem_Click);
			// 
			// employeesGrid
			// 
			this.employeesGrid.AllowUserToAddRows = false;
			this.employeesGrid.AllowUserToDeleteRows = false;
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
            this.SalaryColumn,
            this.JobPositionColumn,
            this.EducationColumn});
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
			this.employeesGrid.Location = new System.Drawing.Point(-1, -1);
			this.employeesGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
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
			this.employeesGrid.RowHeadersVisible = false;
			this.employeesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.employeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.employeesGrid.Size = new System.Drawing.Size(253, 154);
			this.employeesGrid.TabIndex = 11;
			this.employeesGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.employeesGrid_RowsAdded);
			this.employeesGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.employeesGrid_RowsRemoved);
			this.employeesGrid.SelectionChanged += new System.EventHandler(this.metroGrid1_SelectionChanged);
			// 
			// NameColumn
			// 
			this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameColumn.FillWeight = 150F;
			this.NameColumn.HeaderText = "Employee Name";
			this.NameColumn.MinimumWidth = 100;
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
			this.SalaryColumn.MinimumWidth = 80;
			this.SalaryColumn.Name = "SalaryColumn";
			this.SalaryColumn.ReadOnly = true;
			this.SalaryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// JobPositionColumn
			// 
			this.JobPositionColumn.HeaderText = "Job Position";
			this.JobPositionColumn.Name = "JobPositionColumn";
			this.JobPositionColumn.ReadOnly = true;
			// 
			// EducationColumn
			// 
			this.EducationColumn.HeaderText = "Education";
			this.EducationColumn.Name = "EducationColumn";
			this.EducationColumn.ReadOnly = true;
			// 
			// EmployeesLabel
			// 
			this.EmployeesLabel.AutoSize = true;
			this.EmployeesLabel.Location = new System.Drawing.Point(384, 5);
			this.EmployeesLabel.Name = "EmployeesLabel";
			this.EmployeesLabel.Size = new System.Drawing.Size(72, 19);
			this.EmployeesLabel.TabIndex = 23;
			this.EmployeesLabel.Text = "Employees";
			// 
			// metroPanel2
			// 
			this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
			this.metroPanel2.Location = new System.Drawing.Point(9, 9);
			this.metroPanel2.Margin = new System.Windows.Forms.Padding(9);
			this.metroPanel2.Name = "metroPanel2";
			this.metroPanel2.Padding = new System.Windows.Forms.Padding(3);
			this.metroPanel2.Size = new System.Drawing.Size(619, 225);
			this.metroPanel2.TabIndex = 24;
			this.metroPanel2.VerticalScrollbarBarColor = true;
			this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel2.VerticalScrollbarSize = 10;
			// 
			// resetThemeButton
			// 
			this.resetThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resetThemeButton.Location = new System.Drawing.Point(76, 76);
			this.resetThemeButton.Name = "resetThemeButton";
			this.resetThemeButton.Size = new System.Drawing.Size(535, 23);
			this.resetThemeButton.TabIndex = 6;
			this.resetThemeButton.Text = "Reset Theme";
			this.resetThemeButton.UseSelectable = true;
			this.resetThemeButton.Click += new System.EventHandler(this.resetThemeButton_Click);
			// 
			// ColorComboBox
			// 
			this.ColorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ColorComboBox.FormattingEnabled = true;
			this.ColorComboBox.ItemHeight = 23;
			this.ColorComboBox.Items.AddRange(new object[] {
            "Black",
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
			this.ColorComboBox.Size = new System.Drawing.Size(535, 29);
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
			this.ThemeComboBox.Size = new System.Drawing.Size(535, 29);
			this.ThemeComboBox.TabIndex = 2;
			this.ThemeComboBox.UseSelectable = true;
			this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
			// 
			// parametersLabel
			// 
			this.parametersLabel.AutoSize = true;
			this.parametersLabel.Location = new System.Drawing.Point(0, 5);
			this.parametersLabel.Name = "parametersLabel";
			this.parametersLabel.Size = new System.Drawing.Size(75, 19);
			this.parametersLabel.TabIndex = 27;
			this.parametersLabel.Text = "Parameters";
			// 
			// MainTabControl
			// 
			this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainTabControl.Controls.Add(this.employeesPage);
			this.MainTabControl.Controls.Add(this.settingsPage);
			this.MainTabControl.Controls.Add(this.AboutPage);
			this.MainTabControl.Location = new System.Drawing.Point(23, 63);
			this.MainTabControl.Multiline = true;
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(645, 285);
			this.MainTabControl.TabIndex = 28;
			this.MainTabControl.UseSelectable = true;
			// 
			// employeesPage
			// 
			this.employeesPage.Controls.Add(this.metroPanel3);
			this.employeesPage.Controls.Add(this.LoadEmployeesButton);
			this.employeesPage.Controls.Add(this.RemoveEmployeeButton);
			this.employeesPage.Controls.Add(this.SaveEmployeesButton);
			this.employeesPage.Controls.Add(this.ClearEmployeesButton);
			this.employeesPage.Controls.Add(this.metroPanel1);
			this.employeesPage.Controls.Add(this.parametersLabel);
			this.employeesPage.Controls.Add(this.ParameterGroup);
			this.employeesPage.Controls.Add(this.EmployeesLabel);
			this.employeesPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeesPage.HorizontalScrollbarBarColor = true;
			this.employeesPage.HorizontalScrollbarHighlightOnWheel = false;
			this.employeesPage.HorizontalScrollbarSize = 10;
			this.employeesPage.Location = new System.Drawing.Point(4, 38);
			this.employeesPage.Name = "employeesPage";
			this.employeesPage.Size = new System.Drawing.Size(637, 243);
			this.employeesPage.TabIndex = 0;
			this.employeesPage.Text = "Employees";
			this.employeesPage.VerticalScrollbarBarColor = true;
			this.employeesPage.VerticalScrollbarHighlightOnWheel = false;
			this.employeesPage.VerticalScrollbarSize = 10;
			// 
			// metroPanel3
			// 
			this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.metroPanel3.Controls.Add(this.addEmployeeButton);
			this.metroPanel3.Controls.Add(this.ClearButton);
			this.metroPanel3.Controls.Add(this.calculationsButton);
			this.metroPanel3.HorizontalScrollbarBarColor = true;
			this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel3.HorizontalScrollbarSize = 10;
			this.metroPanel3.Location = new System.Drawing.Point(0, 204);
			this.metroPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.metroPanel3.Name = "metroPanel3";
			this.metroPanel3.Size = new System.Drawing.Size(372, 36);
			this.metroPanel3.TabIndex = 29;
			this.metroPanel3.VerticalScrollbarBarColor = true;
			this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel3.VerticalScrollbarSize = 10;
			// 
			// calculationsButton
			// 
			this.calculationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.calculationsButton.Location = new System.Drawing.Point(273, 5);
			this.calculationsButton.Name = "calculationsButton";
			this.calculationsButton.Size = new System.Drawing.Size(88, 23);
			this.calculationsButton.TabIndex = 6;
			this.calculationsButton.Text = "Calculations";
			this.MainTooltip.SetToolTip(this.calculationsButton, "Runs a calculation with the specified parameters");
			this.calculationsButton.UseSelectable = true;
			this.calculationsButton.Click += new System.EventHandler(this.CalculationMenuButton_Click);
			// 
			// LoadEmployeesButton
			// 
			this.LoadEmployeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LoadEmployeesButton.Location = new System.Drawing.Point(501, 217);
			this.LoadEmployeesButton.Name = "LoadEmployeesButton";
			this.LoadEmployeesButton.Size = new System.Drawing.Size(136, 23);
			this.LoadEmployeesButton.TabIndex = 10;
			this.LoadEmployeesButton.Text = "Load Employees";
			this.MainTooltip.SetToolTip(this.LoadEmployeesButton, "Loads a list of employees from an Employee text file");
			this.LoadEmployeesButton.UseSelectable = true;
			this.LoadEmployeesButton.Click += new System.EventHandler(this.LoadEmployeesButton_Click);
			// 
			// RemoveEmployeeButton
			// 
			this.RemoveEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveEmployeeButton.Location = new System.Drawing.Point(384, 188);
			this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
			this.RemoveEmployeeButton.Size = new System.Drawing.Size(137, 23);
			this.RemoveEmployeeButton.TabIndex = 7;
			this.RemoveEmployeeButton.Text = "Remove Employee";
			this.MainTooltip.SetToolTip(this.RemoveEmployeeButton, "Removes an employee from the employee list");
			this.RemoveEmployeeButton.UseSelectable = true;
			this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
			// 
			// SaveEmployeesButton
			// 
			this.SaveEmployeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveEmployeesButton.Location = new System.Drawing.Point(384, 217);
			this.SaveEmployeesButton.Name = "SaveEmployeesButton";
			this.SaveEmployeesButton.Size = new System.Drawing.Size(111, 23);
			this.SaveEmployeesButton.TabIndex = 9;
			this.SaveEmployeesButton.Text = "Save Employees";
			this.MainTooltip.SetToolTip(this.SaveEmployeesButton, "Saves the list of employees to an employee text file");
			this.SaveEmployeesButton.UseSelectable = true;
			this.SaveEmployeesButton.Click += new System.EventHandler(this.SaveEmployeesButton_Click);
			// 
			// ClearEmployeesButton
			// 
			this.ClearEmployeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ClearEmployeesButton.Location = new System.Drawing.Point(527, 188);
			this.ClearEmployeesButton.Name = "ClearEmployeesButton";
			this.ClearEmployeesButton.Size = new System.Drawing.Size(110, 23);
			this.ClearEmployeesButton.TabIndex = 8;
			this.ClearEmployeesButton.Text = "Clear Employees";
			this.MainTooltip.SetToolTip(this.ClearEmployeesButton, "Clears the entire list of employees");
			this.ClearEmployeesButton.UseSelectable = true;
			this.ClearEmployeesButton.Click += new System.EventHandler(this.ClearEmployeesButton_Click);
			// 
			// metroPanel1
			// 
			this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.metroPanel1.Controls.Add(this.employeesGrid);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(384, 27);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(253, 155);
			this.metroPanel1.TabIndex = 32;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// settingsPage
			// 
			this.settingsPage.Controls.Add(this.metroPanel2);
			this.settingsPage.HorizontalScrollbarBarColor = true;
			this.settingsPage.HorizontalScrollbarHighlightOnWheel = false;
			this.settingsPage.HorizontalScrollbarSize = 10;
			this.settingsPage.Location = new System.Drawing.Point(4, 38);
			this.settingsPage.Name = "settingsPage";
			this.settingsPage.Size = new System.Drawing.Size(637, 243);
			this.settingsPage.TabIndex = 1;
			this.settingsPage.Text = "Settings";
			this.settingsPage.VerticalScrollbarBarColor = true;
			this.settingsPage.VerticalScrollbarHighlightOnWheel = false;
			this.settingsPage.VerticalScrollbarSize = 10;
			// 
			// AboutPage
			// 
			this.AboutPage.Controls.Add(this.metroLabel5);
			this.AboutPage.Controls.Add(this.metroLabel4);
			this.AboutPage.Controls.Add(this.metroLabel3);
			this.AboutPage.Controls.Add(this.metroLabel2);
			this.AboutPage.Controls.Add(this.metroLabel1);
			this.AboutPage.Controls.Add(this.pictureBox1);
			this.AboutPage.HorizontalScrollbarBarColor = true;
			this.AboutPage.HorizontalScrollbarHighlightOnWheel = false;
			this.AboutPage.HorizontalScrollbarSize = 10;
			this.AboutPage.Location = new System.Drawing.Point(4, 38);
			this.AboutPage.Name = "AboutPage";
			this.AboutPage.Size = new System.Drawing.Size(637, 243);
			this.AboutPage.TabIndex = 2;
			this.AboutPage.Text = "About";
			this.AboutPage.VerticalScrollbarBarColor = true;
			this.AboutPage.VerticalScrollbarHighlightOnWheel = false;
			this.AboutPage.VerticalScrollbarSize = 10;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(3, 78);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(111, 19);
			this.metroLabel5.TabIndex = 7;
			this.metroLabel5.Text = "a file for later use";
			this.metroLabel5.UseStyleColors = true;
			this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(3, 59);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(362, 19);
			this.metroLabel4.TabIndex = 6;
			this.metroLabel4.Text = "keep track of multiple employees in a list, and save the list to";
			this.metroLabel4.UseStyleColors = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(3, 40);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(367, 19);
			this.metroLabel3.TabIndex = 5;
			this.metroLabel3.Text = "An application that allows you to calculate employee benefits,";
			this.metroLabel3.UseStyleColors = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel2.Location = new System.Drawing.Point(3, 134);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(83, 19);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "By Nickc01";
			this.metroLabel2.UseStyleColors = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.Location = new System.Drawing.Point(3, 3);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(261, 25);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Employee Benefits Calculator";
			this.metroLabel1.UseStyleColors = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::Startup_CEO_Project.Properties.Resources.Nickc01_Logo_6_0_Obsidian_Small;
			this.pictureBox1.Location = new System.Drawing.Point(484, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// MainTooltip
			// 
			this.MainTooltip.Style = MetroFramework.MetroColorStyle.Default;
			this.MainTooltip.StyleManager = null;
			this.MainTooltip.Theme = MetroFramework.MetroThemeStyle.Default;
			// 
			// StartupCEOForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(691, 371);
			this.Controls.Add(this.MainTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(691, 371);
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
			((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
			this.metroPanel2.ResumeLayout(false);
			this.metroPanel2.PerformLayout();
			this.MainTabControl.ResumeLayout(false);
			this.employeesPage.ResumeLayout(false);
			this.employeesPage.PerformLayout();
			this.metroPanel3.ResumeLayout(false);
			this.metroPanel1.ResumeLayout(false);
			this.settingsPage.ResumeLayout(false);
			this.AboutPage.ResumeLayout(false);
			this.AboutPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroButton ClearButton;
		private MetroFramework.Controls.MetroLabel EmployeeSalaryLabel;
		private MetroFramework.Controls.MetroLabel YearsWorkedLabel;
		private MetroFramework.Controls.MetroLabel AgeLabel;
		private MetroFramework.Controls.MetroTextBox AgeTextbox;
		private MetroFramework.Controls.MetroTextBox YearsWorkedTextbox;
		private MetroFramework.Controls.MetroTextBox EmployeeSalaryTextbox;
		private MetroFramework.Controls.MetroPanel ParameterGroup;
		private MetroFramework.Controls.MetroContextMenu CalculationMenu;
		private System.Windows.Forms.ToolStripMenuItem calculateRaiseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateVacationDaysToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateBonusStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateEverythingToolStripMenuItem;
		private MetroFramework.Controls.MetroLabel EmployeesLabel;
		private MetroFramework.Controls.MetroTextBox NameTextbox;
		private MetroFramework.Controls.MetroLabel nameLabel;
		public MetroFramework.Controls.MetroGrid employeesGrid;
		private MetroFramework.Controls.MetroPanel metroPanel2;
		private MetroFramework.Controls.MetroLabel themeLabel;
		private MetroFramework.Controls.MetroComboBox ThemeComboBox;
		private MetroFramework.Controls.MetroComboBox ColorComboBox;
		private MetroFramework.Controls.MetroLabel colorLabel;
		public MetroFramework.Components.MetroStyleManager MetroStyleManager;
		private MetroFramework.Controls.MetroButton resetThemeButton;
		private MetroFramework.Controls.MetroTabControl MainTabControl;
		private MetroFramework.Controls.MetroLabel parametersLabel;
		private MetroFramework.Controls.MetroTabPage employeesPage;
		private MetroFramework.Controls.MetroTabPage settingsPage;
		private MetroFramework.Controls.MetroButton RemoveEmployeeButton;
		private MetroFramework.Controls.MetroButton LoadEmployeesButton;
		private MetroFramework.Controls.MetroButton SaveEmployeesButton;
		private MetroFramework.Controls.MetroButton ClearEmployeesButton;
		private MetroFramework.Controls.MetroButton calculationsButton;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Components.MetroToolTip MainTooltip;
		private MetroFramework.Controls.MetroPanel metroPanel3;
		private MetroFramework.Controls.MetroTabPage AboutPage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel EducationLabel;
		private MetroFramework.Controls.MetroLabel PositionLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn YearsWorkedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn JobPositionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EducationColumn;
		private System.Windows.Forms.ToolStripMenuItem calculateBreakTimesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculateAmountOfBreaksToolStripMenuItem;
		public MetroFramework.Controls.MetroTextBox EducationTextBox;
		public MetroFramework.Controls.MetroTextBox JobPositionTextBox;
		public MetroFramework.Controls.MetroButton addEmployeeButton;
	}
}

