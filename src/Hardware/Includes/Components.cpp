#include <arduino.h>
#include "Components.h"

// LedController Impl

void LedController::flash(int times)
{
	for (int i = 0; i < times; ++i)
	{
		digitalWrite(pin_, HIGH);
		delay(100);
		digitalWrite(pin_, LOW);
		if (i < times - 1)
			delay(100);
	}
}

void LedController::setState(uint8_t state)
{
	digitalWrite(pin_, state);
}

LedController::LedController(uint8_t pin)
{
	pin_ = pin;
	pinMode(pin, OUTPUT);
}

// SwitchMonitor Impl

SwitchMonitor::SwitchMonitor(uint8_t pin)
{
	init(pin, 2);
}

SwitchMonitor::SwitchMonitor(uint8_t pin, int debounceWindow)
{
	init(pin, debounceWindow);
}

void SwitchMonitor::init(uint8_t pin, int debounceWindow)
{
	lastChecked_ = std::chrono::system_clock::now();
	pin_ = pin;
	state_ = digitalRead(pin);
	pinMode(pin, INPUT_PULLUP);
	debounceWindow_ = debounceWindow;
}

uint8_t SwitchMonitor::getState()
{
	return state_;
}

bool SwitchMonitor::stateChanged()
{
	if (inDebounceWindow()) return false;

	uint8_t currentState = digitalRead(pin_);
	bool changed = currentState != state_;
	state_ = currentState;
	return changed;
}

bool SwitchMonitor::inDebounceWindow()
{
	auto currentTime = std::chrono::system_clock::now();
	int elapsed = std::chrono::duration_cast<std::chrono::milliseconds>(currentTime - lastChecked_).count();

	if (elapsed <= debounceWindow_) return true;

	lastChecked_ = currentTime;

	return false;
}