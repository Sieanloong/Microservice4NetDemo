using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroService4Net;

namespace Microservice4NetAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var microService = new MicroService(10086);
            microService.Run(args);
        }
    }
}
