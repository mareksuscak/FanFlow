using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FanFlow.Service
{
    public partial class Service : ServiceBase
    {
        private ThermalDaemonStarter thermalDaemonStarter;

        public Service()
        {
            InitializeComponent();
            this.thermalDaemonStarter = new ThermalDaemonStarter();
        }

        protected override void OnStart(string[] args)
        {
            thermalDaemonStarter.Start();
        }

        protected override void OnStop()
        {
            // Do nothing
        }
    }
}
