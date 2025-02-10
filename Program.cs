using System;
using System.Windows.Forms;

namespace CsharpRentalApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // Enable high DPI support for better UI scaling
                Application.SetHighDpiMode(HighDpiMode.SystemAware);

                // Enable modern visual styles
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Run the application
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                // Catch any unexpected startup errors
                MessageBox.Show("An error occurred while starting the application:\n" + ex.Message,
                                "Startup Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
