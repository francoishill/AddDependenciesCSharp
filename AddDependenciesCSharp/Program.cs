using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AddDependenciesCSharp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm mainform = new MainForm();

			SharedClasses.AutoUpdating.CheckForUpdates(
			//SharedClasses.AutoUpdatingForm.CheckForUpdates(
				//delegate { Application.Exit(); },
				ActionIfUptoDate_Versionstring: (uptodateversion) => ThreadingInterop.UpdateGuiFromThread(mainform, () => mainform.Text += " (up to date version " + uptodateversion + ")"));//,
				//ActionIfUnableToCheckForUpdates: (errmsg) => ThreadingInterop.UpdateGuiFromThread(mainform, () => mainform.Text += " (" + errmsg + ")"));

			Application.Run(mainform);
		}
	}
}
