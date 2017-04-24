using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISayHello hello = new HelloConsole();
            hello.SayHello(args.Length > 0 ? args[0] : "World");
        }
    }
}
