using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using log4net;

namespace Santander.CalcService
{
    public class CalcService
    {
        private Timer _timer = null;
        private readonly ILog _log = LogManager.GetLogger(typeof (CalcService));

        public CalcService()
        {
            double interval = 5000;
            _timer = new Timer(interval);
            _timer.Elapsed += new ElapsedEventHandler(OnTick); 
        }

        protected virtual void OnTick(object sender, ElapsedEventArgs e)
        {
            _log.Debug("Tick: " + DateTime.Now.ToLongTimeString());
        }

        public void Start()
        {
            _log.Info("CalcService is started");
            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Start();
        }

        public void Stop()
        {
            _log.Info("CalcService is stopped");
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }
    }
}
