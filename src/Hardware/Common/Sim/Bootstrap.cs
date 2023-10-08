using System;
using System.Device.Gpio;
using System.Device.Wifi;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Iot.Device.Ws28xx.Esp32;
using Common.Devices;
using Common.Configuration;
using Common.Net;
using nanoFramework.Networking; 

namespace Common.Sim
{
    public static class Bootstrap
    {
        private const int ConfigModePin = 1;

        public static Configuration.Configuration Init(GpioController gpioController, 
            RgbLed statusLed, string deviceName)
        {
            var configModeButton = gpioController.OpenPin(ConfigModePin, PinMode.InputPullUp);
            
            if (AccessPoint.IsEnabled()) statusLed.Flash(Color.Blue, 1);

            var config = LoadConfiguration(deviceName, configModeButton.IsLow());

            var wifiConfig = Wireless80211.GetConfiguration();

            if (WifiNetworkHelper.ConnectDhcp(wifiConfig.Ssid,
                wifiConfig.Password, requiresDateTime: true,
                token: new CancellationTokenSource(60000).Token))
            {
                statusLed.Flash(Color.Lime, 1);
            }
            else
            {
                statusLed.Flash(Color.Red, 1);
            }

            return config;
        }
        
        private static Configuration.Configuration LoadConfiguration(string deviceName, bool configMode)
        {
            var config = Configuration.Configuration.Load();

            if (AccessPoint.IsEnabled() || !Wireless80211.IsEnabled() || configMode)
            {
                AccessPoint.Start(deviceName.Replace(' ', '_'));
                new ConfigurationWebServer(deviceName, config).Run();
                Thread.Sleep(Timeout.Infinite);
            }
            
            return config;
        }
    }
}
