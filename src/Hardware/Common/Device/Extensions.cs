using System;
using System.Device.Gpio;
using System.Text;

namespace Common.Device
{
    public static class Extensions
    {
        public static bool IsLow(this GpioPin pin)
        {
            return pin.Read() == PinValue.Low;
        }
        
        public static bool IsHigh(this GpioPin pin)
        {
            return pin.Read() == PinValue.High;
        }
    }
}
