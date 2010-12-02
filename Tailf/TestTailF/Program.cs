using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Config;
using log4net;
using System.Threading;

namespace TestTailF
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            int i=0;
            while (true)
            {
                var lg = LogManager.GetLogger(typeof(Program));
                lg.Info("Message " + i++);
                Thread.Sleep(10);
            }
        }
    }
}
