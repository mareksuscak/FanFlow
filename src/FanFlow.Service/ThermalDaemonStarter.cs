using Microsoft.Win32;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanFlow.Service
{
    class ThermalDaemonStarter
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private const string ThermalDaemonExecutable = "thermald.exe";

        private string FindPath()
        {
            var programFiles = Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFilesX86);
            var exePath = Path.Combine(programFiles, "Gigabyte", "SIV", ThermalDaemonExecutable);

            if (!File.Exists(exePath))
            {
                throw new Exception(String.Format("Can't find thermald.exe at path: {0}", exePath));
            }

            return exePath;
        }

        private bool ProcessExists(string name)
        {
            bool result = false;
            Process[] processes = Process.GetProcesses();
            if (name.Length == 0)
                return result;
            foreach (Process process in processes)
            {
                if (string.Compare(process.ProcessName, name, true) == 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void RunProcess(string path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = path;
            startInfo.Verb = "runas";
            Process.Start(startInfo);
        }

        public void Start()
        {
            try
            {
                if (ProcessExists(Path.GetFileNameWithoutExtension(ThermalDaemonExecutable)))
                {
                    logger.Info("Thermal daemon is already running.");
                    return;
                }

                var path = FindPath();
                logger.Info(String.Format("File path for thermald.exe is: {0}", path));
                RunProcess(path);
                logger.Info("Thermal daemon started successfully");
            }
            catch (Exception ex)
            {
                logger.Error("Thermal daemon startup failed.", ex);
            }		
        }
    }
}
