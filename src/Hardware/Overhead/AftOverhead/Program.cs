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
using Common.Sim;
using nanoFramework.Networking;

namespace AftOverhead
{
    public class Program
    {
        private const int StallWarning1Pin = 2;
        private const int StallWarning2Pin = 3;

        private static readonly RgbLed BuiltInLed = RgbLed.BuiltInEsp32S3DevKit10;
        private static readonly GpioController GpioController = new GpioController();

        public static void Main()
        {
            var config = Bootstrap.Init(GpioController, BuiltInLed, "737 Sim Aft Overhead Panel");
            
            var stallWarning1Button = GpioController.OpenButton(StallWarning1Pin);
            var stallWarning2Button = GpioController.OpenButton(StallWarning2Pin);

            while (true)
            {
                if (stallWarning1Button.HasChanged())
                {
                    BuiltInLed.On(stallWarning1Button.Pressed 
                        ? Color.DeepPink 
                        : Color.Black);
                }
                
                if (stallWarning2Button.HasChanged())
                {
                    BuiltInLed.On(stallWarning2Button.Pressed
                        ? Color.Yellow 
                        : Color.Black);
                }
            }
        }
    }
}
