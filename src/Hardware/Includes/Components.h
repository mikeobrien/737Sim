#ifndef COMPONENTS_H
#define COMPONENTS_H

#include <chrono>
#include <ctime> 

class LedController
{
private:
	uint8_t pin_;

public:
	void flash(int times);
	void setState(uint8_t state);
	LedController(uint8_t pin);
};

class SwitchMonitor
{
private:
	uint8_t pin_;
	uint8_t state_;
	int debounceWindow_;
	std::chrono::time_point<std::chrono::system_clock> lastChecked_;

	void init(uint8_t pin, int debounceWindow);
	bool inDebounceWindow();

public:
	SwitchMonitor(uint8_t pin);
	SwitchMonitor(uint8_t pin, int debounceWindow);
	uint8_t getState();
	bool stateChanged();
};

#endif // COMPONENTS_H
