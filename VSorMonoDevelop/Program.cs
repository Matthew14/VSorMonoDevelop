using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace VSorMonoDevelop
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: {0} pathToSLN.sln", Process.GetCurrentProcess().ProcessName);
                return;
            }

            string vsLocation, monoDevelopLocation;
            try
            {
                vsLocation = ConfigurationManager.AppSettings.Get("vs");
                monoDevelopLocation = ConfigurationManager.AppSettings.Get("monoDevelop");
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading values from config file, ensure app setting keys 'vs' and 'monoDevelop' are set");
                return;
            }

            var slnPath = String.Join(" ", args);
            
            try
            {

                string contents = File.ReadAllText(slnPath);
                Process.Start(contents.Contains("MonoDevelopProperties") ? monoDevelopLocation : vsLocation, "\"" + slnPath + "\"");
            }
            catch
            {
                Console.WriteLine("Couldn't open file {0}", slnPath);
            }
        }
    }
}
