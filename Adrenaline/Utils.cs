using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Adrenaline
{
    class Utils
    {
        public static string AppName = "Adrenaline",
            AppVersion = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion,
            CheckUpdateURL = "http://isc.mcarvalhor.com/Adrenaline/CheckUpdates?v=" + Utils.AppVersion, // Check update URL.
            Website = "http://isc.mcarvalhor.com/Adrenaline", // Official Website.
            DevWebsite = "http://mcarvalhor.com/"; // Developer official website.

        public static string[] HelpCommands = { "-h", "--h", "-help", "--help" };

        public const int MaxCheckUpdateBytes = 1024 * 1024 * 5, // 5 MiB to check updates.
            MaxUpdateBytes = 1024 * 1024 * 100; // 100 MiB to download updates.

        public const string AppSettingsPath = "options.json"; // Application user definitions file.

        private static System.Resources.ResourceManager stringsRes = null;

        [FlagsAttribute]
        private enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // ES_USER_PRESENT = 0x00000004 // Legacy flag, should not be used.
        }

        public static string GetString(string name)
        {
            string text, osLang;
            if (stringsRes == null)
            {
#if (DEBUG)
                Console.WriteLine("== GetString First Call ==");
#endif
                osLang = System.Globalization.CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
#if (DEBUG)
                Console.WriteLine("\tosLang = " + osLang);
#endif
                switch (osLang)
                {
                    case "pt":
                        stringsRes = Strings.pt.ResourceManager;
                        break;
                    case "es":
                        stringsRes = Strings.es.ResourceManager;
                        break;
                    case "en":
                    default:
                        stringsRes = Strings.en.ResourceManager;
                        break;
                }
#if (DEBUG)
                Console.WriteLine("stringsRes = " + stringsRes.BaseName);
#endif
            }
            text = stringsRes.GetString(name);
            if (text == null)
            {
                text = Strings.en.ResourceManager.GetString(name);
            }
            return text;
        }

        public static string GetPath()
        {
            string appsDir;

            appsDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            appsDir = Path.Combine(appsDir, Utils.AppName);

#if (DEBUG)
            Console.WriteLine("GetPath() = " + appsDir);
#endif

            return appsDir;
        }

        public static string GetTempFile()
        {
            string tempFile;

            tempFile = Path.GetTempFileName();

#if (DEBUG)
            Console.WriteLine("GetTempFile() = " + tempFile);
#endif

            return tempFile;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        public static void SendAwakeSignal(bool keepAwake)
        {
            if (keepAwake)
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
            }
            else
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            }
        }

        public static void MergeDirectory(DirectoryInfo source, DirectoryInfo dest)
        {
            /**
			 * This function merge all the content inside 'source' into 'dest'.
			 * Files that already exists will be overwritten.
			*/
            if (source.FullName.Equals(dest.FullName) || source.FullName.ToLower().Equals(dest.FullName.ToLower()))
            {
                return;
            }

            Directory.CreateDirectory(dest.FullName);

            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(dest.ToString(), fi.Name), true);
            }

            foreach (DirectoryInfo di in source.GetDirectories())
            {
                MergeDirectory(di, dest.CreateSubdirectory(di.Name));
            }
        }

    }
}
