using Common.Device;
using Common.Net;
using System;
using System.Device.Gpio;
using System.Drawing;
using System.Text;
using System.Threading;

namespace Common.Configuration
{
    public static class ConfigurationLoader
    {
        public static Configuration Load(string deviceName, bool configMode, RgbLed statusLed)
        {
            var config = Configuration.Load();

            if (AccessPoint.IsEnabled() || !Wireless80211.IsEnabled() || configMode)
            {
                statusLed.Flash(Color.Blue, 1);
                AccessPoint.Start(deviceName.Replace(' ', '_'));
                new ConfigurationWebServer(deviceName, config).Start();
                statusLed.Flash(Color.Blue, 2);
                Thread.Sleep(Timeout.Infinite);
            }
            
            return config;
        }
    }
}
