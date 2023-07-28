using System;
using System.Drawing;
using System.Threading;
using Iot.Device.Ws28xx.Esp32;

namespace AftOverhead
{
    public class Program
    {
        public static void Main()
        {
            // Built in LED positions on ESP32-S3-DevKitC-1
            // v1.0: pin 48
            // v1.1: pin 38

            var led = new Sk6812(48, 1);
            var toggle = false;

            while (true)
            {
                led.Image.SetPixel(0, 0, toggle ? Color.Lime : Color.Black);
                led.Update();
                toggle = !toggle;
                Thread.Sleep(500);
            }
        }
    }
}
