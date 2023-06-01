using Adrenaline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrenaline
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            //string appTitle = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            string appTitle = Utils.AppName;
            if (args.Length > 1 || (args.Length == 1 && Utils.HelpCommands.Contains(args[0])))
            {
                Console.Error.WriteLine("Command line instructions:");
                Console.Error.WriteLine("\t{0} {1}", System.Diagnostics.Process.GetCurrentProcess().ProcessName, "[AppTitle]");
                Console.Error.WriteLine("Where:");
                Console.Error.WriteLine("\t{0} -> {1}", "[AppTitle]", "The title that application should use for it's main window (defaults to '" + appTitle + "').");
                Console.Error.WriteLine();
                return 1;
            }
            else if (args.Length == 1)
            {
                appTitle = args[0];
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(appTitle));
            return 0;
        }
    }
}
