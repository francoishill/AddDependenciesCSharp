using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SharedClasses;

namespace AddDependenciesCSharp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			foreach (FullPathAndDisplayName file in CSharpDependencies.GetSharedClasses())
				comboBoxSharedClasses.Items.Add(file);
		}

		private void textBoxProjectPath_DragEnter(object sender, DragEventArgs e)
		{
			// Check if the Dataformat of the data can be accepted
			// (we only accept file drops from Explorer, etc.)
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy; // Okay
			else
				e.Effect = DragDropEffects.None; // Unknown data, ignore it
		}

		private void textBoxProjectPath_DragDrop(object sender, DragEventArgs e)
		{
			// Extract the data from the DataObject-Container into a string list
			string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			// Do something with the data...

			// For example add all files into a simple label control:
			if (FileList.Length != 1)
				UserMessages.ShowWarningMessage("Cannot only use 1 project file");
			else if (!FileList[0].EndsWith(".csproj", StringComparison.InvariantCultureIgnoreCase))
				UserMessages.ShowWarningMessage("File must be of type .csproj");
			else
			{
				textBoxProjectPath.Text = FileList[0];
			}
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			StylingInterop.SetTreeviewVistaStyle(treeViewItemsToAdd);
			base.OnHandleCreated(e);
		}

		private void comboBoxSharedClasses_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (comboBoxSharedClasses.SelectedIndex != -1 || !string.IsNullOrWhiteSpace(comboBoxSharedClasses.Text))
					AddComboboxItemToList();
				else
					buttonAccept.PerformClick();
			}
		}

		private void AddComboboxItemToList()
		{
			FullPathAndDisplayName file = comboBoxSharedClasses.SelectedItem as FullPathAndDisplayName;
			if (file != null)
			{
				AddFileToTreeview(file);
			}
			else if (!string.IsNullOrWhiteSpace(comboBoxSharedClasses.Text))
				AddFileToTreeview(new FullPathAndDisplayName(comboBoxSharedClasses.Text));
			else
				UserMessages.ShowWarningMessage("Cannot add blank item");
		}

		private void AddFileToTreeview(FullPathAndDisplayName file)
		{
			treeViewItemsToAdd.Nodes.Add(file.FullPath, file.DisplayName).Tag = file;
			if (comboBoxSharedClasses.SelectedIndex != -1)
				comboBoxSharedClasses.Items.Remove(file);
			comboBoxSharedClasses.SelectedIndex = -1;
			comboBoxSharedClasses.Text = null;
		}

		private void buttonAccept_Click(object sender, EventArgs e)
		{
			if (comboBoxSharedClasses.Text.Length != 0 && UserMessages.Confirm("The current selected item is not added to the list, add it now?"))
				AddComboboxItemToList();

			if (string.IsNullOrWhiteSpace(textBoxProjectPath.Text))
				UserMessages.ShowWarningMessage("Please select a project first.");
			else if (!textBoxProjectPath.Text.EndsWith(".csproj", StringComparison.InvariantCultureIgnoreCase))
				UserMessages.ShowWarningMessage("Please select a valid .csproj file.");
			else if (comboBoxSharedClasses.Text.Length != 0)
				UserMessages.ShowWarningMessage("Please add the item to the list first.");
			else if (treeViewItemsToAdd.Nodes.Count == 0)
				UserMessages.ShowWarningMessage("Please add at least one item.");
			else
			{
				//All checks successful, may proceed
				List<FullPathAndDisplayName> tmplist = new List<FullPathAndDisplayName>();
				foreach (TreeNode node in treeViewItemsToAdd.Nodes)
					tmplist.Add(node.Tag as FullPathAndDisplayName);
				CSharpDependencies.EnsureCorrectFileDependancies(textBoxProjectPath.Text, tmplist.ToArray());
			}
		}
	}
}