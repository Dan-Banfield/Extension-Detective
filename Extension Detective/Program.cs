using System;
using System.Windows.Forms;
using Extension_Detective.Settings;

namespace Extension_Detective
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PerformStartupChecks();
        }

        private static void PerformStartupChecks()
        {
            if (SettingsManager.SettingsDataInstance.IsFirstRun)
            {
                MessageBox.Show("Welcome to Extension Detective!\n\nIt appears that this is your first time using the application. Extension Detective enables you to effortlessly correct file extensions, whether you're dealing with individual files or handling them in bulk.\n\nYou can find the source-code on GitHub\n\n (https://github.com/dan-banfield/)", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingsManager.UpdateSettings(new SettingsData()
                {
                    IsFirstRun = false
                });
            }
            LaunchApplication();
        }

        private static void LaunchApplication() => Application.Run(new MainForm());
    }
}