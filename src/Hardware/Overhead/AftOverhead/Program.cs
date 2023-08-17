using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Iot.Device.Ws28xx.Esp32;
using Common.Device;
using Common.Configuration;

namespace AftOverhead
{
    public class Program
    {
        private const int ConfigModePin = 1;

        private static readonly RgbLed BuiltInLed = RgbLed.BuiltInEsp32S3DevKit10;

        public static void Main()
        {
            var gpioController = new GpioController();
            var configModeButton = gpioController.OpenPin(ConfigModePin, PinMode.InputPullUp);
            var config = ConfigurationLoader.Load("737 Sim Aft Overhead Panel", 
                configModeButton.IsLow(), BuiltInLed);

            BuiltInLed.Flash(Color.Lime, 1);

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
