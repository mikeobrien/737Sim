using System;
using System.Device.Gpio;

namespace Common.Devices
{
    public class ButtonState
    {
        private readonly GpioPin _pin;
        private PinValue _lastState;
        private readonly int _debounceTimeout;
        private DateTime _debounceStart = DateTime.MinValue;

        public ButtonState(GpioPin pin, int debounceTimeout = 10)
        {
            _pin = pin;
            _debounceTimeout = debounceTimeout;
            _lastState = pin.Read();
        }

        public bool Pressed => _lastState == PinValue.Low;

        public bool HasChanged()
        {
            var state = _pin.Read();

            if ((DateTime.UtcNow - _debounceStart).TotalMilliseconds <= _debounceTimeout ||
                state == _lastState)
            {
                return false;
            }

            _debounceStart = DateTime.UtcNow;
            _lastState = state;

            return true;
        }
    }

    public static class ButtonExtensions
    {
        public static ButtonState OpenButton(this GpioController controller, 
            int pin, int debounceTimeout = 10)
        {
            return new ButtonState(controller.OpenPin(
                pin, PinMode.InputPullUp), debounceTimeout);
        }
    }
}