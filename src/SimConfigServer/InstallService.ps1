﻿New-Service -Name SimConfigServer -BinaryPathName "C:\737Sim\SimConfigServer\SimConfigServer.exe --contentRoot {EXE FOLDER PATH}" -Credential "{DOMAIN OR COMPUTER NAME\USER}" -Description "Provides discoverable sim configuation to hardware." -DisplayName "Sim Config Server" -StartupType Automatic