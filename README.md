## 737 Sim

### Stack

- [MS Flight Simulator 2020](https://www.flightsimulator.com)
- [ProSim737](https://prosim-ar.com/prosim737/)
- [OpenCockpits SIOC](https://www.opencockpits.com/index.php/en/download/category/sioc)
- [ESP32-S3-DEVKITC-1](https://docs.espressif.com/projects/esp-idf/en/latest/esp32s3/hw-reference/esp32s3/user-guide-devkitc-1.html) + [nanoFramework](https://www.nanoframework.net/)

[This video](https://www.youtube.com/watch?v=c2S8oXmdJpk) provides excellent coverage of ProSim, OpenCockpits SIOC and microcontroller integration. Although he integrates with an Arduino device, the same principles apply to other microcontrollers.

### ProSim Setup

Getting started guide can be found [here](https://wiki.prosim-ar.com/index.php/Getting_Started) and manual [here](https://wiki.prosim-ar.com/index.php/ProSim737_Manual).

### OpenCockpits SIOC Setup

OpenCockpits SIOC can be downloaded [here](https://www.opencockpits.com/index.php/en/download/category/sioc).

### ESP32-S3-DevKit Setup

#### Overview

*NOTE: As of 8/2023, the 32MB version of the dev board is not supported by nanoFramework. Follow the GitHub issue [here](https://github.com/nanoframework/Home/issues/1343).*

The ESP32-S3-WROOM is a general-purpose Wi-Fi + Bluetooth LE MCU module that integrates complete Wi-Fi and Bluetooth LE functions. The following versions are available:

- [ESP32-S3-WROOM-1](https://www.espressif.com/sites/default/files/documentation/esp32-s3-wroom-1_wroom-1u_datasheet_en.pdf): Quad flash, 3.3V SPI voltage, integrated antenna.
- [ESP32-S3-WROOM-1U](https://www.espressif.com/sites/default/files/documentation/esp32-s3-wroom-1_wroom-1u_datasheet_en.pdf): Quad flash, 3.3V SPI voltage, extenal antenna.
- [ESP32-S3-WROOM-2](https://www.espressif.com/sites/default/files/documentation/esp32-s3-wroom-2_datasheet_en.pdf): Octal flash 1.8V SPI voltage.

The ESP32-S3-DevKit is a development board that incorporates the ESP32-S3-WROOM MCU. The following versions are available:

- [ESP32-S3-DevKitM-1](https://docs.espressif.com/projects/esp-idf/en/latest/esp32s3/hw-reference/esp32s3/user-guide-devkitm-1.html) 
- [ESP32-S3-DevKitC-1 v1.0](https://docs.espressif.com/projects/esp-idf/en/latest/esp32s3/hw-reference/esp32s3/user-guide-devkitc-1-v1.0.html) 
- [ESP32-S3-DevKitC-1 v1.1](https://docs.espressif.com/projects/esp-idf/en/latest/esp32s3/hw-reference/esp32s3/user-guide-devkitc-1.html) 

The following development boards are available:

| Development Board         | MCU      | Flash    | PSRAM   | SPI Voltage | Antenna  | Buy |
| ------------------------- | -------- | -------- | ------- | ----------- | -------- | --- |
| ESP32-S3-DevKitM-1-N8     | WROOM-1  |  8 MB QD |         | 3.3 V       | PCB      | [adafruit](https://www.adafruit.com/product/5311) |
| ESP32-S3-DevKitM-1U-N8    | WROOM-1  |  8 MB QD |         | 3.3 V       | External | |
| ESP32-S3-DevKitC-1-N8     | WROOM-1  |  8 MB QD |         | 3.3 V       | PCB      | [DigiKey](https://www.digikey.com/en/products/detail/espressif-systems/ESP32-S3-DEVKITC-1-N8/15199021), [adafruit](https://www.adafruit.com/product/5312) |
| ESP32-S3-DevKitC-1-N8R2   | WROOM-1  |  8 MB QD | 2 MB QD | 3.3 V       | PCB      | [DigiKey](https://www.digikey.com/en/products/detail/espressif-systems/ESP32-S3-DEVKITC-1-N8R2/15199627), [adafruit](https://www.adafruit.com/product/5310) |
| ESP32-S3-DevKitC-1-N8R8   | WROOM-1  |  8 MB QD | 8 MB OT | 3.3 V       | PCB      | [DigiKey](https://www.digikey.com/en/products/detail/espressif-systems/ESP32-S3-DEVKITC-1-N8R8/15295894), [adafruit](https://www.adafruit.com/product/5336) |
| ESP32-S3-DevKitC-1U-N8    | WROOM-1U |  8 MB QD |         | 3.3 V       | External | [DigiKey](https://www.digikey.com/en/products/detail/espressif-systems/ESP32-S3-DEVKITC-1U-N8/16162645) |
| ESP32-S3-DevKitC-1U-N8R2  | WROOM-1U |  8 MB QD | 2 MB QD | 3.3 V       | External | [DigiKey](https://www.digikey.com/en/products/detail/espressif-systems/ESP32-S3-DEVKITC-1U-N8R2/16162648) |
| ESP32-S3-DevKitC-1U-N8R8  | WROOM-1U |  8 MB QD | 8 MB OT | 3.3 V       | External | [DigiKey](https://www.digikey.com/en/products/detail/espressif-systems/ESP32-S3-DEVKITC-1U-N8R8/16162636) |
| ESP32-S3-DevKitC-1-N16R8V | WROOM-2  | 16 MB OT | 8 MB OT | 1.8 V       | PCB      | |
| ESP32-S3-DevKitC-1-N32R8V | WROOM-2  | 32 MB OT | 8 MB OT | 1.8 V       | PCB      | [DigiKey](https://www.digikey.com/en/products/detail/espressif-systems/ESP32-S3-DEVKITC-1-N32R8V/15970965), [adafruit](https://www.adafruit.com/product/5364) |

- QD: Quad SPI
- OT: Octal SPI
- U: External antenna
- N: Flash size
- R: PSRAM size
- V: WROOM-2

#### Board Firmware

The nanoFramework will need to be flashed on the board as described [here](https://github.com/nanoframework/nanoFirmwareFlasher).

1. Install [the nanoFirmwareFlasher](https://github.com/nanoframework/nanoFirmwareFlasher):

```
dotnet tool install -g nanoff
```

2. Connect the device to the USB port (not USB-to-UART, they are both micro USB connectors).

3. Put the device in download mode:
    - Press and hold the [BOOT] button down
    - Press and Release the [RESET] button
    - Release the [BOOT] button

4. Check which port the device is connected too:

```
nanoff --listports
```

Should give the following output (port will vary):

```
.NET nanoFramework Firmware Flasher v2.5.34+c89f1d1d65
Copyright (C) 2019 .NET Foundation and nanoFramework project contributors


Available COM ports:
  COM6
```

5. Check connectivity as follows (optional, replace the COM port with the one in the previous step):

```
nanoff --platform esp32 --serialport COM5 --devicedetails
```

6. Update the firmware (replace the COM port with the one in the previous step):

```
nanoff --update --target ESP32_S3 --serialport COM6 -v d
```

Should give the following output:

```
.NET nanoFramework Firmware Flasher v2.5.34+c89f1d1d65
Copyright (C) 2019 .NET Foundation and nanoFramework project contributors


Using COM6 @ 1500000 baud to connect to ESP32.
Reading details from chip...
OK

Connected to:
ESP32-S3 (ESP32-S3 (revision v0.1))
Features WiFi, BLE
Flash size 8MB GD25Q64 from GIGADEVICE (manufacturer 0x200 device 0x16407)
PSRAM: undetermined
Crystal 40MHz
MAC 34:85:18:6C:F8:3C

Trying to find ESP32_S3 in stable repository...OK
Downloading firmware package...OK
Extracting ESP32_S3-1.8.1.388.zip...OK

Updating to 1.8.1.388

Erasing flash...OK
Flashing firmware...OK
```

7. Unplug and replug the device and list the ports:

```
nanoff --listports
```

Should give the following output with a different port than the boot loader:

```
.NET nanoFramework Firmware Flasher v2.5.34+c89f1d1d65
Copyright (C) 2019 .NET Foundation and nanoFramework project contributors


Available COM ports:
  COM4
```

The device should be ready to use.


#### Dev Environment

1. Install [Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/vs/community/).
2. Install [the nanoFramework Visual Studio extension](https://marketplace.visualstudio.com/items?itemName=nanoframework.nanoframework-vs2022-extension). 
3. Open the device explorer under `View > Other Windows > Device Explorer`.
4. Add a new "Blank Application (.NET nanoFramework)".
5. Install the following nuget packages:

```
Install-Package nanoFramework.CoreLibrary
Install-Package nanoFramework.Runtime.Events
Install-Package nanoFramework.System.Device.Gpio
Install-Package nanoFramework.System.IO.FileSystem
Install-Package nanoFramework.Hardware.Esp32
Install-Package nanoFramework.Iot.Device.Ws28xx.Esp32
Install-Package nanoFramework.Json
```

6. Run the blinky program:

```
using System;
using System.Drawing;
using System.Threading;
using Iot.Device.Ws28xx.Esp32;

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
```

