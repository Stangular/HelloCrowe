using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Configuration;


namespace MainApp
{
    public interface ISayHello
    {
        int SayHello(string to);
        string GetConfigurationPath();
        string PathSelector();
    }

    public class HelloConsole : ISayHello
    {
        public HelloConsole()
        {

        }
        public string PathSelector()
        {
            return "hellopath";
        }
        public string GetConfigurationPath()
        {
            return ConfigurationManager.AppSettings[PathSelector()];
        }
        public int SayHello(string to = "World!")
        {
            var proc = Process.Start(GetConfigurationPath(), to);
            proc.WaitForExit();
            return proc.ExitCode;
        }
    }
}


