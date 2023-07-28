#include <arduino.h>
#include <NativeEthernet.h>
#include "Network.h"

void teensyMAC(byte* mac)
{
	for (byte by = 0; by < 2; by++) mac[by] = (HW_OCOTP_MAC1 >> ((1 - by) * 8)) & 0xFF;
	for (byte by = 0; by < 4; by++) mac[by + 2] = (HW_OCOTP_MAC0 >> ((3 - by) * 8)) & 0xFF;

	Serial.printf("MAC: %02x:%02x:%02x:%02x:%02x:%02x\n", mac[0], mac[1], mac[2], mac[3], mac[4], mac[5]);
}

bool initEthernet()
{
	byte mac[6];
	teensyMAC(mac);

	if (EthernetClass::begin(mac) != 0)
	{
		IPAddress localIp = EthernetClass::localIP();
		Serial.printf("IP Address %u.%u.%u.%u\n", localIp[0], localIp[1], localIp[2], localIp[3]);

		return true;
	}
	
	Serial.println("\nFailed to configure Ethernet using DHCP");
	return false;
}