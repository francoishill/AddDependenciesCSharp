namespace AddDependenciesCSharp
{
	partial class MainForm
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
			this.textBoxProjectPath = new System.Windows.Forms.TextBox();
			this.buttonBrowseProject = new System.Windows.Forms.Button();
			this.treeViewItemsToAdd = new System.Windows.Forms.TreeView();
			this.comboBoxSharedClasses = new System.Windows.Forms.ComboBox();
			this.radioButtonWinforms = new System.Windows.Forms.RadioButton();
			this.radioButtonWPF = new System.Windows.Forms.RadioButton();
			this.radioButtonConsole = new System.Windows.Forms.RadioButton();
			this.buttonAccept = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxProjectPath
			// 
			this.textBoxProjectPath.AllowDrop = true;
			this.textBoxProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxProjectPath.Location = new System.Drawing.Point(12, 12);
			this.textBoxProjectPath.Name = "textBoxProjectPath";
			this.textBoxProjectPath.Size = new System.Drawing.Size(785, 20);
			this.textBoxProjectPath.TabIndex = 1;
			this.textBoxProjectPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxProjectPath_DragDrop);
			this.textBoxProjectPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxProjectPath_DragEnter);
			// 
			// buttonBrowseProject
			// 
			this.buttonBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseProject.Location = new System.Drawing.Point(808, 10);
			this.buttonBrowseProject.Name = "buttonBrowseProject";
			this.buttonBrowseProject.Size = new System.Drawing.Size(30, 23);
			this.buttonBrowseProject.TabIndex = 2;
			this.buttonBrowseProject.Text = "...";
			this.buttonBrowseProject.UseVisualStyleBackColor = true;
			// 
			// treeViewItemsToAdd
			// 
			this.treeViewItemsToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewItemsToAdd.HotTracking = true;
			this.treeViewItemsToAdd.Indent = 5;
			this.treeViewItemsToAdd.Location = new System.Drawing.Point(12, 109);
			this.treeViewItemsToAdd.Name = "treeViewItemsToAdd";
			this.treeViewItemsToAdd.ShowLines = false;
			this.treeViewItemsToAdd.ShowPlusMinus = false;
			this.treeViewItemsToAdd.ShowRootLines = false;
			this.treeViewItemsToAdd.Size = new System.Drawing.Size(406, 145);
			this.treeViewItemsToAdd.TabIndex = 3;
			// 
			// comboBoxSharedClasses
			// 
			this.comboBoxSharedClasses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxSharedClasses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxSharedClasses.FormattingEnabled = true;
			this.comboBoxSharedClasses.Location = new System.Drawing.Point(12, 82);
			this.comboBoxSharedClasses.Name = "comboBoxSharedClasses";
			this.comboBoxSharedClasses.Size = new System.Drawing.Size(321, 21);
			this.comboBoxSharedClasses.TabIndex = 4;
			this.comboBoxSharedClasses.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxSharedClasses_KeyUp);
			// 
			// radioButtonWinforms
			// 
			this.radioButtonWinforms.AutoSize = true;
			this.radioButtonWinforms.Location = new System.Drawing.Point(81, 38);
			this.radioButtonWinforms.Name = "radioButtonWinforms";
			this.radioButtonWinforms.Size = new System.Drawing.Size(100, 17);
			this.radioButtonWinforms.TabIndex = 5;
			this.radioButtonWinforms.TabStop = true;
			this.radioButtonWinforms.Text = "Windows Forms";
			this.radioButtonWinforms.UseVisualStyleBackColor = true;
			// 
			// radioButtonWPF
			// 
			this.radioButtonWPF.AutoSize = true;
			this.radioButtonWPF.Location = new System.Drawing.Point(187, 38);
			this.radioButtonWPF.Name = "radioButtonWPF";
			this.radioButtonWPF.Size = new System.Drawing.Size(49, 17);
			this.radioButtonWPF.TabIndex = 6;
			this.radioButtonWPF.TabStop = true;
			this.radioButtonWPF.Text = "WPF";
			this.radioButtonWPF.UseVisualStyleBackColor = true;
			// 
			// radioButtonConsole
			// 
			this.radioButtonConsole.AutoSize = true;
			this.radioButtonConsole.Location = new System.Drawing.Point(12, 38);
			this.radioButtonConsole.Name = "radioButtonConsole";
			this.radioButtonConsole.Size = new System.Drawing.Size(63, 17);
			this.radioButtonConsole.TabIndex = 7;
			this.radioButtonConsole.TabStop = true;
			this.radioButtonConsole.Text = "Console";
			this.radioButtonConsole.UseVisualStyleBackColor = true;
			// 
			// buttonAccept
			// 
			this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAccept.Location = new System.Drawing.Point(763, 231);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(75, 23);
			this.buttonAccept.TabIndex = 8;
			this.buttonAccept.Text = "A&ccept";
			this.buttonAccept.UseVisualStyleBackColor = true;
			this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 266);
			this.Controls.Add(this.buttonAccept);
			this.Controls.Add(this.radioButtonConsole);
			this.Controls.Add(this.radioButtonWPF);
			this.Controls.Add(this.radioButtonWinforms);
			this.Controls.Add(this.comboBoxSharedClasses);
			this.Controls.Add(this.treeViewItemsToAdd);
			this.Controls.Add(this.buttonBrowseProject);
			this.Controls.Add(this.textBoxProjectPath);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxProjectPath;
		private System.Windows.Forms.Button buttonBrowseProject;
		private System.Windows.Forms.TreeView treeViewItemsToAdd;
		private System.Windows.Forms.ComboBox comboBoxSharedClasses;
		private System.Windows.Forms.RadioButton radioButtonWinforms;
		private System.Windows.Forms.RadioButton radioButtonWPF;
		private System.Windows.Forms.RadioButton radioButtonConsole;
		private System.Windows.Forms.Button buttonAccept;
	}
}

