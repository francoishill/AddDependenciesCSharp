using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SharedClasses;

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

			string[] args = Environment.GetCommandLineArgs();

			if (args.Length <= 2)//args[0] is this EXE path, args[1] might be a path to a .csproj file
			{
				if (args.Length == 2)
				{
					string possibleCsprojPath = args[1].Trim(' ', '"', '\'', '\\');
					if (possibleCsprojPath.EndsWith(".csproj", StringComparison.InvariantCultureIgnoreCase))
						MainForm.presetCsProjFile = args[1];
				}

				MainForm mainform = new MainForm();
				SharedClasses.AutoUpdating.CheckForUpdates_ExceptionHandler(
					delegate
					{
						ThreadingInterop.UpdateGuiFromThread(mainform, () => mainform.Text += " (up to date version " + SharedClasses.AutoUpdating.GetThisAppVersionString() + ")");
					});
				/*SharedClasses.AutoUpdating.CheckForUpdates(
				//SharedClasses.AutoUpdatingForm.CheckForUpdates(
					//delegate { Application.Exit(); },
					ActionIfUptoDate_Versionstring: (uptodateversion) => ThreadingInterop.UpdateGuiFromThread(mainform, () => mainform.Text += " (up to date version " + uptodateversion + ")"));//,
					//ActionIfUnableToCheckForUpdates: (errmsg) => ThreadingInterop.UpdateGuiFromThread(mainform, () => mainform.Text += " (" + errmsg + ")"));*/

				Application.Run(mainform);
			}
			else
			{
				UserMessages.ShowWarningMessage("Please specify correct commandline-arguments for AddDependenciesCSharp, either none or one argument being the .csproj file");
				return;
			}
		}
	}
}
