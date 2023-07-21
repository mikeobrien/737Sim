#include <NativeEthernet.h>
#include "Network.h"

class LedController
{
	private:
		uint8_t pin_;

	public:
		void flash(const int times) const
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

		void setState(const uint8_t state) const
		{
			digitalWrite(pin_, state);
		}

	explicit LedController(const uint8_t pin)
	{
		pin_ = pin;
		pinMode(pin, OUTPUT);
	}
};

byte mac[6];
IPAddress iocpServer(192, 168, 1, 122);
EthernetClient client;

uint8_t stall1Pin = 0;
int stall1LastState;

uint8_t stall2Pin = 1;
int stall2LastState;

LedController builtInLed(LED_BUILTIN);

void iocpConnect()
{
	if (client.connect(iocpServer, 8092))
	{
		Serial.println("Connected to IOCP server");
		client.println("Arn.Inicio:1:2");
	}
	else
	{
		Serial.println("Failed to connect to IOCP server");
	}
}

void setup() {

	builtInLed.flash(1);

	pinMode(stall1Pin, INPUT_PULLUP);
	pinMode(stall2Pin, INPUT_PULLUP);

	teensyMAC(mac);

	if (EthernetClass::begin(mac) != 0) 
	{
		IPAddress localIp = EthernetClass::localIP();
		Serial.printf("IP Address %u.%u.%u.%u\n", localIp[0], localIp[1], localIp[2], localIp[3]);

		iocpConnect();
	}
	else 
	{
		Serial.println("\nFailed to configure Ethernet using DHCP");
	}
	
	builtInLed.flash(3);
}

void loop()
{
	if (!client.connected())
	{
		client.stop();
		delay(1000);
		iocpConnect();
	}

	delay(5);

	const uint8_t stall1CurrentState = (digitalRead(stall1Pin) == LOW ? HIGH : LOW);

	if (stall1CurrentState != stall1LastState)
	{
		builtInLed.setState(stall1CurrentState);

		client.printf("Arn.Resp:1=%u\n", stall1CurrentState);
		stall1LastState = stall1CurrentState;
	}

	const uint8_t stall2CurrentState = (digitalRead(stall2Pin) == LOW ? HIGH : LOW);

	if (stall2CurrentState != stall2LastState)
	{
		builtInLed.setState(stall2CurrentState);

		client.printf("Arn.Resp:2=%u\n", stall2CurrentState);
		stall2LastState = stall2CurrentState;
	}
}