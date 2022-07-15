using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace overwolf.plugins.aou
{
    public class AmongUsDetectionPlugin
    {
        public AmongUsDetectionPlugin()
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Caught")]
        public string GetAULocationSteamRegistrySync()
        {
            try
            {
                //Computer\HKEY_CURRENT_USER\SOFTWARE\Classes\amongus\shell\open\command
                using var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\amongus\\shell\\open\\command");
                var amogusexe = (string)key.GetValue("");
                if (amogusexe != null)
                {
                    amogusexe = amogusexe.Substring(amogusexe.IndexOf('"') + 1);
                    amogusexe = amogusexe.Substring(0, amogusexe.IndexOf('"'));
                    var amogus = Directory.GetParent(Directory.GetParent(Directory.GetParent(amogusexe).FullName).FullName).FullName;
                    if (Directory.Exists(amogus))
                    {
                        return amogus;
                    }
                }
            }
            catch { }
            return ""; // Fail
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Caught")]
        public string GetAULocationRegistrySync()
        {
            try
            {
                //Computer\HKEY_CURRENT_USER\SOFTWARE\Classes\amongus\shell\open\command
                using var key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\amongus\\shell\\open\\command");
                var amogusexe = (string) key.GetValue("");
                if (amogusexe != null)
                {
                    amogusexe = amogusexe.Substring(amogusexe.IndexOf('"') + 1);
                    amogusexe = amogusexe.Substring(0, amogusexe.IndexOf('"'));
                    var amogus = Directory.GetParent(Directory.GetParent(Directory.GetParent(amogusexe).FullName).FullName).FullName;
                    if (Directory.Exists(amogus))
                    {
                        return amogus;
                    }
                }
            }
            catch { }
            return ""; // Fail
        }
    }
}

