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
			this.ResultsLabel = new System.Windows.Forms.Label();
			this.ResultsBox = new System.Windows.Forms.TextBox();
			this.ResultsGroup = new System.Windows.Forms.GroupBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.saveToFileButton = new System.Windows.Forms.Button();
			this.CopyButton = new System.Windows.Forms.Button();
			this.CopyButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.SaveToFileTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.ExitTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.ResultsGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// ResultsLabel
			// 
			this.ResultsLabel.AutoSize = true;
			this.ResultsLabel.Location = new System.Drawing.Point(6, 22);
			this.ResultsLabel.Name = "ResultsLabel";
			this.ResultsLabel.Size = new System.Drawing.Size(63, 13);
			this.ResultsLabel.TabIndex = 2;
			this.ResultsLabel.Text = "ResultsText";
			// 
			// ResultsBox
			// 
			this.ResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsBox.Location = new System.Drawing.Point(164, 19);
			this.ResultsBox.Name = "ResultsBox";
			this.ResultsBox.ReadOnly = true;
			this.ResultsBox.Size = new System.Drawing.Size(187, 20);
			this.ResultsBox.TabIndex = 200;
			// 
			// ResultsGroup
			// 
			this.ResultsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsGroup.Controls.Add(this.exitButton);
			this.ResultsGroup.Controls.Add(this.saveToFileButton);
			this.ResultsGroup.Controls.Add(this.CopyButton);
			this.ResultsGroup.Controls.Add(this.ResultsBox);
			this.ResultsGroup.Controls.Add(this.ResultsLabel);
			this.ResultsGroup.Location = new System.Drawing.Point(12, 12);
			this.ResultsGroup.Name = "ResultsGroup";
			this.ResultsGroup.Size = new System.Drawing.Size(357, 77);
			this.ResultsGroup.TabIndex = 8;
			this.ResultsGroup.TabStop = false;
			this.ResultsGroup.Text = "Results";
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.Location = new System.Drawing.Point(114, 48);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "Exit";
			this.ExitTooltip.SetToolTip(this.exitButton, "Exits the results window");
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// saveToFileButton
			// 
			this.saveToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveToFileButton.Location = new System.Drawing.Point(195, 48);
			this.saveToFileButton.Name = "saveToFileButton";
			this.saveToFileButton.Size = new System.Drawing.Size(75, 23);
			this.saveToFileButton.TabIndex = 2;
			this.saveToFileButton.Text = "Save to File";
			this.SaveToFileTooltip.SetToolTip(this.saveToFileButton, "Saves the results to a file of your choice");
			this.saveToFileButton.UseVisualStyleBackColor = true;
			this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
			// 
			// CopyButton
			// 
			this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyButton.Location = new System.Drawing.Point(276, 48);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(75, 23);
			this.CopyButton.TabIndex = 3;
			this.CopyButton.Text = "Copy";
			this.CopyButtonTooltip.SetToolTip(this.CopyButton, "Copys the Results to your clipboard so you can paste the contents in whatever tex" +
        "t editor you like");
			this.CopyButton.UseVisualStyleBackColor = true;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// ResultsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 101);
			this.Controls.Add(this.ResultsGroup);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(397, 140);
			this.Name = "ResultsForm";
			this.Text = "Results";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultsForm_FormClosed);
			this.ResultsGroup.ResumeLayout(false);
			this.ResultsGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label ResultsLabel;
		private System.Windows.Forms.TextBox ResultsBox;
		private System.Windows.Forms.GroupBox ResultsGroup;
		private System.Windows.Forms.Button CopyButton;
		private System.Windows.Forms.ToolTip CopyButtonTooltip;
		private System.Windows.Forms.Button saveToFileButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.ToolTip ExitTooltip;
		private System.Windows.Forms.ToolTip SaveToFileTooltip;
	}
}