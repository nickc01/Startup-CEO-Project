namespace Startup_Company_Benefits
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
			this.SecondaryResultsBox = new System.Windows.Forms.TextBox();
			this.SecondaryResultsLabel = new System.Windows.Forms.Label();
			this.CopyButton = new System.Windows.Forms.Button();
			this.CopyButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
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
			this.ResultsBox.TabIndex = 3;
			// 
			// ResultsGroup
			// 
			this.ResultsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultsGroup.Controls.Add(this.SecondaryResultsBox);
			this.ResultsGroup.Controls.Add(this.SecondaryResultsLabel);
			this.ResultsGroup.Controls.Add(this.CopyButton);
			this.ResultsGroup.Controls.Add(this.ResultsBox);
			this.ResultsGroup.Controls.Add(this.ResultsLabel);
			this.ResultsGroup.Location = new System.Drawing.Point(12, 12);
			this.ResultsGroup.Name = "ResultsGroup";
			this.ResultsGroup.Size = new System.Drawing.Size(357, 107);
			this.ResultsGroup.TabIndex = 8;
			this.ResultsGroup.TabStop = false;
			this.ResultsGroup.Text = "Results";
			// 
			// SecondaryResultsBox
			// 
			this.SecondaryResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SecondaryResultsBox.Location = new System.Drawing.Point(164, 50);
			this.SecondaryResultsBox.Name = "SecondaryResultsBox";
			this.SecondaryResultsBox.ReadOnly = true;
			this.SecondaryResultsBox.Size = new System.Drawing.Size(187, 20);
			this.SecondaryResultsBox.TabIndex = 12;
			// 
			// SecondaryResultsLabel
			// 
			this.SecondaryResultsLabel.AutoSize = true;
			this.SecondaryResultsLabel.Location = new System.Drawing.Point(6, 53);
			this.SecondaryResultsLabel.Name = "SecondaryResultsLabel";
			this.SecondaryResultsLabel.Size = new System.Drawing.Size(120, 13);
			this.SecondaryResultsLabel.TabIndex = 11;
			this.SecondaryResultsLabel.Text = "Secondary Results Text";
			// 
			// CopyButton
			// 
			this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyButton.Location = new System.Drawing.Point(276, 78);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(75, 23);
			this.CopyButton.TabIndex = 10;
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
			this.ClientSize = new System.Drawing.Size(381, 131);
			this.Controls.Add(this.ResultsGroup);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(397, 170);
			this.Name = "ResultsForm";
			this.Text = "Results";
			this.ResultsGroup.ResumeLayout(false);
			this.ResultsGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label ResultsLabel;
		private System.Windows.Forms.TextBox ResultsBox;
		private System.Windows.Forms.GroupBox ResultsGroup;
		private System.Windows.Forms.Button CopyButton;
		private System.Windows.Forms.TextBox SecondaryResultsBox;
		private System.Windows.Forms.Label SecondaryResultsLabel;
		private System.Windows.Forms.ToolTip CopyButtonTooltip;
	}
}