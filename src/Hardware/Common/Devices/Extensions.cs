using System.Device.Gpio;
using System.Text;

namespace Common.Devices
{
    public static class Extensions
    {
        public static bool IsLow(this GpioPin pin)
        {
            return pin.Read().IsLow();
        }
        
        public static bool IsHigh(this GpioPin pin)
        {
            return pin.Read().IsHigh();
        }

        public static bool IsLow(this PinValue value)
        {
            return value == PinValue.Low;
        }
        
        public static bool IsHigh(this PinValue value)
        {
            return value == PinValue.High;
        }
    }
}
