using Iot.Device.Ws28xx.Esp32;
using System.Drawing;
using System.Threading;

namespace Common.Devices
{
    public class RgbLed
    {
        private readonly Sk6812 _led;
        private Color _color;

        public RgbLed(int pin)
        {
            _led = new Sk6812(pin, 1);
        }

        public static RgbLed BuiltInEsp32S3DevKit10 => new(48);
        public static RgbLed BuiltInEsp32S3DevKit11 => new(38);

        public void Flash(Color color, int times = 1)
        {
            for (var i = 0; i < times * 2; i++)
            {
                if (i > 0) Thread.Sleep(250);
                Toggle(color);
            }
        }

        public void Toggle(Color color)
        {
            if (_color != color)
                Set(color);
            else
                Off();
        }

        public void On(Color color)
        {
            Set(color);
        }

        public void Off()
        {
            Set(Color.Black);
        }

        private void Set(Color color)
        {
            _color = color;
            _led.Image.SetPixel(0, 0, color);
            _led.Update();
        }
    }
}
