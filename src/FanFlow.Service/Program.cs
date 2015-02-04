using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FanFlow.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            // Set working directory to the app domains base directory
            // http://stackoverflow.com/questions/858597/why-wont-my-windows-service-write-to-my-log-file
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            if (Environment.UserInteractive)
            {
                ThermalDaemonStarter thermalDaemonStarter = new ThermalDaemonStarter();
                thermalDaemonStarter.Start();
            }
            else
            {
                ServiceBase[] ServicesToRun = new ServiceBase[] 
                { 
                    new Service() 
                };
                ServiceBase.Run(ServicesToRun);
            }
            
        }
    }
}
