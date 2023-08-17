using System;

namespace Common.Sim
{
    public static class ProSimB38M
    {
        public static class Electric
        {
            public static class Switch
            {
                public const int ApuGen1Center = 1;
                public const int ApuGen1Off = 2;
                public const int ApuGen1On = 3;
                public const int ApuGen2Center = 4;
                public const int ApuGen2Off = 5;
                public const int ApuGen2On = 6;
                public const int ApuSwitchOff = 7;
                public const int ApuSwitchOn = 8;
                public const int ApuSwitchStart = 9;
                public const int BatterySwitchOff = 10;
                public const int BatterySwitchOn = 11;
                public const int BusTransferSwitchOff = 12;
                public const int BusTransferSwitchAuto = 13;
                public const int Disconnect1Normal = 14;
                public const int Disconnect1Off = 15;
                public const int Disconnect2Normal = 16;
                public const int Disconnect2Off = 17;
                public const int ElecPnlAcStbyPwr = 18;
                public const int ElecPnlAcGrdPwr = 19;
                public const int ElecPnlAcGen1 = 20;
                public const int ElecPnlAcApuGen = 21;
                public const int ElecPnlAcGen2 = 22;
                public const int ElecPnlAcInv = 23;
                public const int ElecPnlAcTest = 24;
                public const int ElecPnlDcStbyPwr = 25;
                public const int ElecPnlDcBatBus = 26;
                public const int ElecPnlDcBat = 27;
                public const int ElecPnlDcAuxBat = 28;
                public const int ElecPnlDcTr1 = 29;
                public const int ElecPnlDcTr2 = 30;
                public const int ElecPnlDcTr3 = 31;
                public const int ElecPnlDcTest = 32;
                public const int ElecMaintOff = 33;
                public const int ElecMaintPushed = 34;
                public const int Gen1Center = 35;
                public const int Gen1Off = 36;
                public const int Gen1On = 37;
                public const int Gen2Center = 38;
                public const int Gen2Off = 39;
                public const int Gen2On = 40;
                public const int GalleyOff = 41;
                public const int GalleyOn = 42;
                public const int GroundPowerOff = 43;
                public const int GroundPowerCenter = 44;
                public const int GroundPowerOn = 45;
                public const int IgnitionSelectBoth = 46;
                public const int IgnitionSelectLeft = 47;
                public const int IgnitionSelectRight = 48;
                public const int StandbyPowerSwitchAuto = 49;
                public const int StandbyPowerSwitchOff = 50;
                public const int StandbyPowerSwitchBat = 51;
            }

            public static class Indicator
            {
                public const int ApuFault = 52;
                public const int ApuGenOffBus = 53;
                public const int ApuLowOilPressure = 54;
                public const int ApuOverspeed = 55;
                public const int BatDischarge = 56;
                public const int Door = 57;
                public const int Drive1 = 58;
                public const int Drive2 = 59;
                public const int Elec = 60;
                public const int GenBusOff1 = 61;
                public const int GenBusOff2 = 62;
                public const int GrdPwrAvailable = 63;
                public const int SourceOff1 = 64;
                public const int SourceOff2 = 65;
                public const int StandbyPwrOff = 66;
                public const int TrUnit = 67;
                public const int TransferBusOff1 = 68;
                public const int TransferBusOff2 = 69;
            }

            public static class Gate
            {
                public const int AcPower = 70;
                public const int ApuProtectiveShutdown = 71;
                public const int ApuRunning = 72;
                public const int ApuStarting = 73;
                public const int ApuStopping = 74;
                public const int BattBusGate = 75;
                public const int DcPower = 76;
                public const int GalleyBus1Powered = 77;
                public const int GalleyBus2Powered = 78;
                public const int StandByPower = 79;
            }

            public static class Numerical
            {
                public const int ApuNumerical = 80;
                public const int AmpereACStandbyBus = 81;
                public const int AmpereBattBus = 82;
                public const int AmpereDcbus1 = 83;
                public const int AmpereDcbus2 = 84;
                public const int AmpereDCStandbyBus = 85;
                public const int AmpereGalleyBusLeft = 86;
                public const int AmpereGalleyBusRight = 87;
                public const int AmpereGroundServicesBus = 88;
                public const int AmpereHotBattBus = 89;
                public const int AmpereInverter = 90;
                public const int AmpereMainBus1 = 91;
                public const int AmpereMainBus2 = 92;
                public const int AmpereSwitchedHotBattBus = 93;
                public const int AmpereTr1 = 94;
                public const int AmpereTr2 = 95;
                public const int AmpereTr3 = 96;
                public const int AmpereTransBus1 = 97;
                public const int AmpereTransBus2 = 98;
                public const int AmpereSwitchedground = 99;
                public const int ElectricPanelLowerCenter = 100;
                public const int ElectricPanelLowerLeft = 101;
                public const int ElectricPanelLowerRight = 102;
                public const int ElectricPanelUpperCenter = 103;
                public const int ElectricPanelUpperLeft = 104;
                public const int ElectricPanelUpperRight = 105;
                public const int VoltACStandbyBus = 106;
                public const int VoltBattBus = 107;
                public const int VoltDcbus1 = 108;
                public const int VoltDcbus2 = 109;
                public const int VoltDCStandbyBus = 110;
                public const int VoltGalleyBusLeft = 111;
                public const int VoltGalleyBusRight = 112;
                public const int VoltGroundServicesBus = 113;
                public const int VoltHotBattBus = 114;
                public const int VoltMainBus1 = 115;
                public const int VoltMainBus2 = 116;
                public const int VoltSwitchedHotBattBus = 117;
                public const int VoltTransBus1 = 118;
                public const int VoltTransBus2 = 119;
                public const int VoltSwitchedground = 120;
            }
        }

        public static class Engine
        {
            public static class Switch
            {
                public const int EecLeftOff = 121;
                public const int EecLeftPushed = 122;
                public const int EecLeftLatchOff = 123;
                public const int EecLeftLatchOn = 124;
                public const int EecRightOff = 125;
                public const int EecRightPushed = 126;
                public const int EecRightLatchOff = 127;
                public const int EecRightLatchOn = 128;
                public const int ReverserAirGrdPttNormal = 129;
                public const int ReverserAirGrdPttPushed = 130;
                public const int ReverserCommandPttNormal = 131;
                public const int ReverserCommandPttPushed = 132;
                public const int ReverserLimitedLeftPttNormal = 133;
                public const int ReverserLimitedLeftPttPushed = 134;
                public const int ReverserLimitedRightPttNormal = 135;
                public const int ReverserLimitedRightPttPushed = 136;
            }

            public static class Indicator
            {
                public const int EecAltnLeft = 137;
                public const int EecAltnRight = 138;
                public const int EecOnLeft = 139;
                public const int EecOnRight = 140;
                public const int EngineControlLeft = 141;
                public const int EngineControlRight = 142;
                public const int ReverserAirGrd = 143;
                public const int ReverserCommand = 144;
                public const int ReverserLimitedLeft = 145;
                public const int ReverserLimitedRight = 146;
            }

            public static class Gate
            {
                public const int ReverserSyncLockLeft = 147;
                public const int ReverserSyncLockRight = 148;
                public const int VibrationsEngine1 = 149;
                public const int VibrationsEngine2 = 150;
            }
        }

        public static class Pneumatic
        {
            public static class Switch
            {
                public const int AirTempSelectorContCab = 151;
                public const int AirTempSelectorDuctFwd = 152;
                public const int AirTempSelectorDuctAft = 153;
                public const int AirTempSelectorCabFwd = 154;
                public const int AirTempSelectorCabAft = 155;
                public const int AirTempSelectorR = 156;
                public const int AirTempSelectorL = 157;
                public const int AltHornCutoutOff = 158;
                public const int AltHornCutoutPushed = 159;
                public const int Bleed1Off = 160;
                public const int Bleed1On = 161;
                public const int Bleed2Off = 162;
                public const int Bleed2On = 163;
                public const int BleedApuOff = 164;
                public const int BleedApuOn = 165;
                public const int FlightAltInEncoderPulseDownOff = 166;
                public const int FlightAltInEncoderPulseDownOn = 167;
                public const int FlightAltInEncoderPulseUpOff = 168;
                public const int FlightAltInEncoderPulseUpOn = 169;
                public const int HighAltLdgOff = 170;
                public const int HighAltLdgPushed = 171;
                public const int HighAltLdgLatchOff = 172;
                public const int HighAltLdgLatchOn = 173;
                public const int LandAltInEncoderPulseDownOff = 174;
                public const int LandAltInEncoderPulseDownOn = 175;
                public const int LandAltInEncoderPulseUpOff = 176;
                public const int LandAltInEncoderPulseUpOn = 177;
                public const int OvhtTestOff = 178;
                public const int OvhtTestOn = 179;
                public const int OutflowValveOff = 180;
                public const int OutflowValveOpen = 181;
                public const int OutflowValveClose = 182;
                public const int Pack1Off = 183;
                public const int Pack1Auto = 184;
                public const int Pack1High = 185;
                public const int Pack2Off = 186;
                public const int Pack2Auto = 187;
                public const int Pack2High = 188;
                public const int PassOxygenNormal = 189;
                public const int PassOxygenOn = 190;
                public const int PneumaticIsolationSwitchAuto = 191;
                public const int PneumaticIsolationSwitchClose = 192;
                public const int PneumaticIsolationSwitchOpen = 193;
                public const int PressurizationAuto = 194;
                public const int PressurizationAltn = 195;
                public const int PressurizationMan = 196;
                public const int RecircFanLOff = 197;
                public const int RecircFanLAuto = 198;
                public const int RecircFanROff = 199;
                public const int RecircFanRAuto = 200;
                public const int Start1Off = 201;
                public const int Start1Grd = 202;
                public const int Start1Cont = 203;
                public const int Start1Flt = 204;
                public const int Start2Off = 205;
                public const int Start2Grd = 206;
                public const int Start2Cont = 207;
                public const int Start2Flt = 208;
                public const int TrimAirRelaySwitchOpen = 209;
                public const int TrimAirRelaySwitchClosed = 210;
                public const int TrimAirOff = 211;
                public const int TrimAirOn = 212;
                public const int TripResetOff = 213;
                public const int TripResetOn = 214;
            }

            public static class Indicator
            {
                public const int BleedTripOff1 = 215;
                public const int BleedTripOff2 = 216;
                public const int CowlAntiIceL = 217;
                public const int CowlAntiIceR = 218;
                public const int DualBleed = 219;
                public const int Eng1AntiIce = 220;
                public const int Eng2AntiIce = 221;
                public const int HighAltLdgInop = 222;
                public const int HighAltLdgOn = 223;
                public const int OffSchedDescent = 224;
                public const int OutflowValveGaugeOutput0 = 225;
                public const int OutflowValveGaugeOutput1 = 226;
                public const int OutflowValveGaugeOutput2 = 227;
                public const int OutflowValveGaugeOutput3 = 228;
                public const int OutflowValveGaugeOutput4 = 229;
                public const int OutflowValveGaugeOutput5 = 230;
                public const int OutflowValveGaugeOutput6 = 231;
                public const int PackL = 232;
                public const int PackR = 233;
                public const int PassOxyOn = 234;
                public const int PressureGaugeLeftOutput0 = 235;
                public const int PressureGaugeLeftOutput1 = 236;
                public const int PressureGaugeLeftOutput2 = 237;
                public const int PressureGaugeLeftOutput3 = 238;
                public const int PressureGaugeLeftOutput4 = 239;
                public const int PressureGaugeLeftOutput5 = 240;
                public const int PressureGaugeLeftOutput6 = 241;
                public const int PressureGaugeLeftOutput7 = 242;
                public const int PressureGaugeLeftOutput8 = 243;
                public const int PressureGaugeRightOutput0 = 244;
                public const int PressureGaugeRightOutput1 = 245;
                public const int PressureGaugeRightOutput2 = 246;
                public const int PressureGaugeRightOutput3 = 247;
                public const int PressureGaugeRightOutput4 = 248;
                public const int PressureGaugeRightOutput5 = 249;
                public const int PressureGaugeRightOutput6 = 250;
                public const int PressureGaugeRightOutput7 = 251;
                public const int PressureGaugeRightOutput8 = 252;
                public const int PressurizationAltn = 253;
                public const int PressurizationAutoFail = 254;
                public const int PressurizationManual = 255;
                public const int RamDoorFullOpenL = 256;
                public const int RamDoorFullOpenR = 257;
                public const int WingBodyOverheat1 = 258;
                public const int WingBodyOverheat2 = 259;
                public const int ZoneTempAftCab = 260;
                public const int ZoneTempContCab = 261;
                public const int ZoneTempFwdCab = 262;
            }

            public static class Gauge
            {
                public const int CabinVsi = 263;
                public const int CabinAltitude = 264;
                public const int CabinTemperature = 265;
                public const int OutflowValvePosition = 266;
                public const int OxygenPressure = 267;
                public const int PressureLeft = 268;
                public const int PressureRight = 269;
                public const int PressureDifferential = 270;
            }

            public static class Gate
            {
                public const int PackLOperating = 271;
                public const int PackLOperatingHigh = 272;
                public const int PackLOperatingNormal = 273;
                public const int PackROperating = 274;
                public const int PackROperatingHigh = 275;
                public const int PackROperatingNormal = 276;
                public const int PassOxyDeployed = 277;
                public const int PressureLossHigh = 278;
                public const int PressureLossLow = 279;
                public const int PressurisationDisplayDashedOut = 280;
                public const int PressurisationDisplayPower = 281;
                public const int RamDoorFullOpenLBright = 282;
                public const int RamDoorFullOpenRBright = 283;
                public const int RecircFanLRunning = 284;
                public const int RecircFanRRunning = 285;
                public const int Starter1PushbackSolenoid = 286;
                public const int Starter1Solenoid = 287;
                public const int Starter2PushbackSolenoid = 288;
                public const int Starter2Solenoid = 289;
            }

            public static class Numerical
            {
                public const int CabinVsiNumerical = 290;
                public const int CabinAltitudeNumerical = 291;
                public const int CabinTemperatureNumerical = 292;
                public const int CruiseAlt = 293;
                public const int LandAlt = 294;
                public const int OutflowValvePositionNumerical = 295;
                public const int OxygenPressureNumerical = 296;
                public const int PressureLeftNumerical = 297;
                public const int PressureRightNumerical = 298;
                public const int PressureDifferentialNumerical = 299;
            }

            public static class Analog
            {
                public const int AftCabSelector = 300;
                public const int ContCabSelector = 301;
                public const int FwdCabSelector = 302;
                public const int FlightAltIn = 303;
                public const int LandAltIn = 304;
            }

            public static class Encoder
            {
                public const int FlightAltInEncoder = 305;
                public const int LandAltInEncoder = 306;
            }
        }

        public static class Hydraulic
        {
            public static class Switch
            {
                public const int AlternateFlapsOff = 307;
                public const int AlternateFlapsArm = 308;
                public const int AlternateFlapsCtrlOff = 309;
                public const int AlternateFlapsCtrlUp = 310;
                public const int AlternateFlapsCtrlDown = 311;
                public const int FltCtrlAOff = 312;
                public const int FltCtrlAStbyRud = 313;
                public const int FltCtrlAAOn = 314;
                public const int FltCtrlBOff = 315;
                public const int FltCtrlBStbyRud = 316;
                public const int FltCtrlBBOn = 317;
                public const int HydElec1Off = 318;
                public const int HydElec1On = 319;
                public const int HydElec2Off = 320;
                public const int HydElec2On = 321;
                public const int HydEng1Off = 322;
                public const int HydEng1On = 323;
                public const int HydEng2Off = 324;
                public const int HydEng2On = 325;
                public const int SpoilerAOff = 326;
                public const int SpoilerAOn = 327;
                public const int SpoilerBOff = 328;
                public const int SpoilerBOn = 329;
            }

            public static class Indicator
            {
                public const int FltControlLowPressureA = 330;
                public const int FltControlLowPressureB = 331;
                public const int FeelDiffPress = 332;
                public const int HydElec1Lp = 333;
                public const int HydElec1Ovht = 334;
                public const int HydElec2Lp = 335;
                public const int HydElec2Ovht = 336;
                public const int HydEng1Lp = 337;
                public const int HydEng2Lp = 338;
                public const int HydStandbyLowPressure = 339;
                public const int HydStandbyLowQuantity = 340;
                public const int StdbyRudOn = 341;
            }

            public static class Gauge
            {
                public const int BrakePressure = 342;
            }

            public static class Gate
            {
                public const int FlapGate1 = 343;
                public const int FlapGate10 = 344;
                public const int FlapGate15 = 345;
                public const int FlapGate2 = 346;
                public const int FlapGate25 = 347;
                public const int FlapGate30 = 348;
                public const int FlapGate40 = 349;
                public const int FlapGate5 = 350;
                public const int FlapGateUp = 351;
                public const int HydraulicsAAvailable = 352;
                public const int HydraulicsBAvailable = 353;
                public const int HydraulicsAvailable = 354;
            }

            public static class Numerical
            {
                public const int BrakePressureNumerical = 355;
            }
        }

        public static class Fuel
        {
            public static class Switch
            {
                public const int CrossfeedOff = 356;
                public const int CrossfeedOn = 357;
                public const int FuelCenterLeftOff = 358;
                public const int FuelCenterLeftOn = 359;
                public const int FuelCenterRightOff = 360;
                public const int FuelCenterRightOn = 361;
                public const int FuelLeftAftOff = 362;
                public const int FuelLeftAftOn = 363;
                public const int FuelLeftFwdOff = 364;
                public const int FuelLeftFwdOn = 365;
                public const int FuelRightAftOff = 366;
                public const int FuelRightAftOn = 367;
                public const int FuelRightFwdOff = 368;
                public const int FuelRightFwdOn = 369;
            }

            public static class Indicator
            {
                public const int CrossfeedIndicator = 370;
                public const int EngValveClosedL = 371;
                public const int EngValveClosedR = 372;
                public const int FilterBypassL = 373;
                public const int FilterBypassR = 374;
                public const int FuelCenterLeftLp = 375;
                public const int FuelCenterRightLp = 376;
                public const int FuelLeftAftLp = 377;
                public const int FuelLeftFwdLp = 378;
                public const int FuelRightAftLp = 379;
                public const int FuelRightFwdLp = 380;
                public const int SparValveClosedL = 381;
                public const int SparValveClosedR = 382;
            }

            public static class Gauge
            {
                public const int FuelTemperature = 383;
                public const int LeftEngineFuel = 384;
                public const int RightEngineFuel = 385;
            }

            public static class Gate
            {
                public const int CrossfeedIndicatorBright = 386;
                public const int EngValveClosedLBright = 387;
                public const int EngValveClosedRBright = 388;
                public const int SparValveClosedLBright = 389;
                public const int SparValveClosedRBright = 390;
            }

            public static class Numerical
            {
                public const int FuelFlowLeft = 391;
                public const int FuelFlowRight = 392;
                public const int FuelTemperatureNumerical = 393;
                public const int LeftEngineFuelNumerical = 394;
                public const int RightEngineFuelNumerical = 395;
            }
        }

        public static class Lighting
        {
            public static class Switch
            {
                public const int DomeLightDim = 396;
                public const int DomeLightOff = 397;
                public const int DomeLightBright = 398;
                public const int EmerExitLightsOff = 399;
                public const int EmerExitLightsArmed = 400;
                public const int EmerExitLightsOn = 401;
                public const int LightMainFixedLOff = 402;
                public const int LightMainFixedLOn = 403;
                public const int LightMainFixedROff = 404;
                public const int LightMainFixedROn = 405;
                public const int LightTestBright = 406;
                public const int LightTestDim = 407;
                public const int LightTestTest = 408;
                public const int LightsAntiCollisionOff = 409;
                public const int LightsAntiCollisionOn = 410;
                public const int LightsLogoOff = 411;
                public const int LightsLogoOn = 412;
                public const int LightsPositionOff = 413;
                public const int LightsPositionOn = 414;
                public const int LightsRunwayTurnoffLOff = 415;
                public const int LightsRunwayTurnoffLOn = 416;
                public const int LightsRunwayTurnoffROff = 417;
                public const int LightsRunwayTurnoffROn = 418;
                public const int LightsStrobeOff = 419;
                public const int LightsStrobeOn = 420;
                public const int LightsStrobeSteadyStrobeSteady = 421;
                public const int LightsStrobeSteadyOff = 422;
                public const int LightsStrobeSteadySteady = 423;
                public const int LightsTaxiOff = 424;
                public const int LightsTaxiOn = 425;
                public const int LightsWheelWellOff = 426;
                public const int LightsWheelWellOn = 427;
                public const int LightsWingOff = 428;
                public const int LightsWingOn = 429;
            }

            public static class Indicator
            {
                public const int EmergExitLightsNotArmed = 430;
            }

            public static class Gate
            {
                public const int DomelightBright = 431;
                public const int DomelightDim = 432;
                public const int DomelightMaster = 433;
                public const int EmergExitLightsGate = 434;
                public const int EmergencyExitLights = 435;
                public const int LightTest = 436;
                public const int MasterDim = 437;
                public const int OverheadBacklightMaster = 438;
                public const int PanelLightsFO = 439;
                public const int PanelLightsCaptain = 440;
                public const int PanelLightsControlStand = 441;
                public const int PanelLightsFlood = 442;
            }

            public static class Numerical
            {
                public const int AfdsFloodLightOutput = 443;
                public const int ChartLightFOOutput = 444;
                public const int ChartLightCaoptainOutput = 445;
                public const int McpBackgroundLightOutput = 446;
                public const int MipFloodLightOutput = 447;
                public const int MipPanelCaptLightOutput = 448;
                public const int MipPanelFOLightOutput = 449;
                public const int MapLightFOOutput = 450;
                public const int MapLightCaptainOutput = 451;
                public const int OverheadCbLightOutput = 452;
                public const int OverheadPanelLightOutput = 453;
                public const int PanelLightsOutput = 454;
                public const int PedestalPanelLightOutput = 455;
            }

            public static class Analog
            {
                public const int AfdsFloodLight = 456;
                public const int ChartLightFO = 457;
                public const int ChartLightCaoptain = 458;
                public const int McpBackgroundLight = 459;
                public const int MipFloodLight = 460;
                public const int MipPanelCaptLight = 461;
                public const int MipPanelFOLight = 462;
                public const int MapLightFO = 463;
                public const int MapLightCaptain = 464;
                public const int OverheadCbLight = 465;
                public const int OverheadPanelLight = 466;
                public const int PanelLights = 467;
                public const int PedestalPanelLight = 468;
            }
        }

        public static class Heating
        {
            public static class Switch
            {
                public const int EngAntiIce1Off = 469;
                public const int EngAntiIce1On = 470;
                public const int EngAntiIce2Off = 471;
                public const int EngAntiIce2On = 472;
                public const int ProbeHeatAAuto = 473;
                public const int ProbeHeatAOn = 474;
                public const int ProbeHeatBAuto = 475;
                public const int ProbeHeatBOn = 476;
                public const int TatTestOff = 477;
                public const int TatTestPushed = 478;
                public const int WindowHeatFwdLOff = 479;
                public const int WindowHeatFwdLOn = 480;
                public const int WindowHeatFwdROff = 481;
                public const int WindowHeatFwdROn = 482;
                public const int WindowHeatSideLOff = 483;
                public const int WindowHeatSideLOn = 484;
                public const int WindowHeatSideROff = 485;
                public const int WindowHeatSideROn = 486;
                public const int WindowHeatTestCenter = 487;
                public const int WindowHeatTestOvht = 488;
                public const int WindowHeatTestPwrTest = 489;
                public const int WingAntiIceOff = 490;
                public const int WingAntiIceOn = 491;
            }

            public static class Indicator
            {
                public const int AlphaVaneHeatL = 492;
                public const int AlphaVaneHeatR = 493;
                public const int CaptPitotHeat = 494;
                public const int CopilotPitotHeat = 495;
                public const int CowlValveOpenL = 496;
                public const int CowlValveOpenR = 497;
                public const int ElevPitotHeatL = 498;
                public const int ElevPitotHeatR = 499;
                public const int WaiLValveOpen = 500;
                public const int WaiRValveOpen = 501;
                public const int WindowHeatFwdLOff = 502;
                public const int WindowHeatFwdLOn = 503;
                public const int WindowHeatFwdLOverheat = 504;
                public const int WindowHeatFwdROff = 505;
                public const int WindowHeatFwdROn = 506;
                public const int WindowHeatFwdROverheat = 507;
                public const int WindowHeatSideLOff = 508;
                public const int WindowHeatSideLOn = 509;
                public const int WindowHeatSideLOverheat = 510;
                public const int WindowHeatSideROff = 511;
                public const int WindowHeatSideROn = 512;
                public const int WindowHeatSideROverheat = 513;
                public const int AuxpitotHeat = 514;
                public const int TempprobeHeat = 515;
            }

            public static class Gate
            {
                public const int WingAntiIceHoldActuator = 516;
                public const int WingAntiIceOffActuator = 517;
            }
        }

        public static class Misc
        {
            public static class Switch
            {
                public const int AspFilterModeB = 518;
                public const int AspFilterModeV = 519;
                public const int AspFilterModeR = 520;
                public const int AspAlternateSelectedOff = 521;
                public const int AspAlternateSelectedOn = 522;
                public const int AspBoomSelectedOff = 523;
                public const int AspBoomSelectedOn = 524;
                public const int AspFOFilterModeB = 525;
                public const int AspFOFilterModeV = 526;
                public const int AspFOFilterModeR = 527;
                public const int AspFOAlternateSelectedOff = 528;
                public const int AspFOAlternateSelectedOn = 529;
                public const int AspFOBoomSelectedOff = 530;
                public const int AspFOBoomSelectedOn = 531;
                public const int AspFOIcSelectedOff = 532;
                public const int AspFOIcSelectedOn = 533;
                public const int AspFOMaskSelectedOff = 534;
                public const int AspFOMaskSelectedOn = 535;
                public const int AspFONormalSelectedOff = 536;
                public const int AspFONormalSelectedOn = 537;
                public const int AspFORtSelectedOff = 538;
                public const int AspFORtSelectedOn = 539;
                public const int AspIcSelectedOff = 540;
                public const int AspIcSelectedOn = 541;
                public const int AspMaskSelectedOff = 542;
                public const int AspMaskSelectedOn = 543;
                public const int AspNormalSelectedOff = 544;
                public const int AspNormalSelectedOn = 545;
                public const int AspObsFilterModeB = 546;
                public const int AspObsFilterModeV = 547;
                public const int AspObsFilterModeR = 548;
                public const int AspObsAlternateSelectedOff = 549;
                public const int AspObsAlternateSelectedOn = 550;
                public const int AspObsBoomSelectedOff = 551;
                public const int AspObsBoomSelectedOn = 552;
                public const int AspObsIcSelectedOff = 553;
                public const int AspObsIcSelectedOn = 554;
                public const int AspObsMaskSelectedOff = 555;
                public const int AspObsMaskSelectedOn = 556;
                public const int AspObsNormalSelectedOff = 557;
                public const int AspObsNormalSelectedOn = 558;
                public const int AspObsRtSelectedOff = 559;
                public const int AspObsRtSelectedOn = 560;
                public const int AspRtSelectedOff = 561;
                public const int AspRtSelectedOn = 562;
                public const int AttendOff = 563;
                public const int AttendPushed = 564;
                public const int AttendCallResetOff = 565;
                public const int AttendCallResetPushed = 566;
                public const int CabinEvacSwitchOff = 567;
                public const int CabinEvacSwitchOn = 568;
                public const int CabinHornCutoutOff = 569;
                public const int CabinHornCutoutPushed = 570;
                public const int CockpitHornCutoutOff = 571;
                public const int CockpitHornCutoutPushed = 572;
                public const int DisplayControlPanelNormal = 573;
                public const int DisplayControlPanelBothOn1 = 574;
                public const int DisplayControlPanelBothOn2 = 575;
                public const int DisplaySourceAuto = 576;
                public const int DisplaySourceAllOn1 = 577;
                public const int DisplaySourceAllOn2 = 578;
                public const int DoorAftCargoSwitchNormal = 579;
                public const int DoorAftCargoSwitchPushed = 580;
                public const int DoorAftEntrySwitchNormal = 581;
                public const int DoorAftEntrySwitchPushed = 582;
                public const int DoorAftServiceSwitchNormal = 583;
                public const int DoorAftServiceSwitchPushed = 584;
                public const int DoorAirStairsSwitchNormal = 585;
                public const int DoorAirStairsSwitchPushed = 586;
                public const int DoorFwdCargoSwitchNormal = 587;
                public const int DoorFwdCargoSwitchPushed = 588;
                public const int DoorFwdServiceSwitchNormal = 589;
                public const int DoorFwdServiceSwitchPushed = 590;
                public const int DoorFwdEntrySwitchNormal = 591;
                public const int DoorFwdEntrySwitchPushed = 592;
                public const int DoorAutoUnlockPttNormal = 593;
                public const int DoorAutoUnlockPttPushed = 594;
                public const int DoorLockFailPttNormal = 595;
                public const int DoorLockFailPttPushed = 596;
                public const int EltArmed = 597;
                public const int EltOn = 598;
                public const int EquipCoolingExhaustNormal = 599;
                public const int EquipCoolingExhaustAlternate = 600;
                public const int EquipCoolingSupplyNormal = 601;
                public const int EquipCoolingSupplyAlternate = 602;
                public const int EvacArmSwitchOff = 603;
                public const int EvacArmSwitchArm = 604;
                public const int EvacArmSwitchOn = 605;
                public const int FlightFreezeOff = 606;
                public const int FlightFreezeOn = 607;
                public const int FlightFreezeToggleNormal = 608;
                public const int FlightFreezeTogglePushed = 609;
                public const int FlightRecorderNormal = 610;
                public const int FlightRecorderTest = 611;
                public const int FltDeckDoorAuto = 612;
                public const int FltDeckDoorUnlkd = 613;
                public const int FltDeckDoorDeny = 614;
                public const int GroundCallOff = 615;
                public const int GroundCallPushed = 616;
                public const int LeDevicesTestOff = 617;
                public const int LeDevicesTestPushed = 618;
                public const int MachAirspeedWarningTestNo1Off = 619;
                public const int MachAirspeedWarningTestNo1Pushed = 620;
                public const int MachAirspeedWarningTestNo2Off = 621;
                public const int MachAirspeedWarningTestNo2Pushed = 622;
                public const int NoSmokingOff = 623;
                public const int NoSmokingAuto = 624;
                public const int NoSmokingOn = 625;
                public const int PauseOff = 626;
                public const int PauseOn = 627;
                public const int PauseToggleNormal = 628;
                public const int PauseTogglePushed = 629;
                public const int SeatbeltOff = 630;
                public const int SeatbeltAuto = 631;
                public const int SeatbeltOn = 632;
                public const int StabTrimOverrideNormal = 633;
                public const int StabTrimOverrideOverride = 634;
                public const int StallTest1Off = 635;
                public const int StallTest1Pushed = 636;
                public const int StallTest2Off = 637;
                public const int StallTest2Pushed = 638;
                public const int User1InOff = 639;
                public const int User1InOn = 640;
                public const int User10InOff = 641;
                public const int User10InOn = 642;
                public const int User11InOff = 643;
                public const int User11InOn = 644;
                public const int User12InOff = 645;
                public const int User12InOn = 646;
                public const int User13InOff = 647;
                public const int User13InOn = 648;
                public const int User14InOff = 649;
                public const int User14InOn = 650;
                public const int User15InOff = 651;
                public const int User15InOn = 652;
                public const int User16InOff = 653;
                public const int User16InOn = 654;
                public const int User17InOff = 655;
                public const int User17InOn = 656;
                public const int User18InOff = 657;
                public const int User18InOn = 658;
                public const int User19InOff = 659;
                public const int User19InOn = 660;
                public const int User2InOff = 661;
                public const int User2InOn = 662;
                public const int User20InOff = 663;
                public const int User20InOn = 664;
                public const int User3InOff = 665;
                public const int User3InOn = 666;
                public const int User4InOff = 667;
                public const int User4InOn = 668;
                public const int User5InOff = 669;
                public const int User5InOn = 670;
                public const int User6InOff = 671;
                public const int User6InOn = 672;
                public const int User7InOff = 673;
                public const int User7InOn = 674;
                public const int User8InOff = 675;
                public const int User8InOn = 676;
                public const int User9InOff = 677;
                public const int User9InOn = 678;
                public const int VoiceRecorderAuto = 679;
                public const int VoiceRecorderOn = 680;
                public const int VoiceRecorderEraseOff = 681;
                public const int VoiceRecorderErasePushed = 682;
                public const int VoiceRecorderTestOff = 683;
                public const int VoiceRecorderTestPushed = 684;
                public const int WeatherRadarDualModeLeftMap = 685;
                public const int WeatherRadarDualModeLeftAuto = 686;
                public const int WeatherRadarDualModeLeftManual = 687;
                public const int WeatherRadarDualModeRightMap = 688;
                public const int WeatherRadarDualModeRightAuto = 689;
                public const int WeatherRadarDualModeRightManual = 690;
                public const int WeatherRadarAutoOff = 691;
                public const int WeatherRadarAutoPushed = 692;
                public const int WeatherRadarAutoLatchOff = 693;
                public const int WeatherRadarAutoLatchOn = 694;
                public const int WeatherRadarAltitudeLeftPulseDownOff = 695;
                public const int WeatherRadarAltitudeLeftPulseDownOn = 696;
                public const int WeatherRadarAltitudeLeftPulseUpOff = 697;
                public const int WeatherRadarAltitudeLeftPulseUpOn = 698;
                public const int WeatherRadarAltitudeRightPulseDownOff = 699;
                public const int WeatherRadarAltitudeRightPulseDownOn = 700;
                public const int WeatherRadarAltitudeRightPulseUpOff = 701;
                public const int WeatherRadarAltitudeRightPulseUpOn = 702;
                public const int WeatherRadarGcLeftNormal = 703;
                public const int WeatherRadarGcLeftPushed = 704;
                public const int WeatherRadarGcRightNormal = 705;
                public const int WeatherRadarGcRightPushed = 706;
                public const int WeatherRadarLROff = 707;
                public const int WeatherRadarLRPushed = 708;
                public const int WeatherRadarLRLatchOff = 709;
                public const int WeatherRadarLRLatchOn = 710;
                public const int WeatherRadarMapLeftNormal = 711;
                public const int WeatherRadarMapLeftPushed = 712;
                public const int WeatherRadarMapRightNormal = 713;
                public const int WeatherRadarMapRightPushed = 714;
                public const int WeatherRadarModeWxT = 715;
                public const int WeatherRadarModeWx = 716;
                public const int WeatherRadarModeWxrVar = 717;
                public const int WeatherRadarModeMap = 718;
                public const int WeatherRadarModeTest = 719;
                public const int WeatherRadarTestNormal = 720;
                public const int WeatherRadarTestPushed = 721;
                public const int WeatherRadarTfrLeftOff = 722;
                public const int WeatherRadarTfrLeftPushed = 723;
                public const int WeatherRadarTfrLeftLatchOff = 724;
                public const int WeatherRadarTfrLeftLatchOn = 725;
                public const int WeatherRadarTfrRightOff = 726;
                public const int WeatherRadarTfrRightPushed = 727;
                public const int WeatherRadarTfrRightLatchOff = 728;
                public const int WeatherRadarTfrRightLatchOn = 729;
                public const int WeatherRadarWxLeftNormal = 730;
                public const int WeatherRadarWxLeftPushed = 731;
                public const int WeatherRadarWxRightNormal = 732;
                public const int WeatherRadarWxRightPushed = 733;
                public const int WeatherRadarWxTLeftNormal = 734;
                public const int WeatherRadarWxTLeftPushed = 735;
                public const int WeatherRadarWxTRightNormal = 736;
                public const int WeatherRadarWxTRightPushed = 737;
                public const int WiperLeftPark = 738;
                public const int WiperLeftInt = 739;
                public const int WiperLeftLow = 740;
                public const int WiperLeftHigh = 741;
                public const int WiperRightPark = 742;
                public const int WiperRightInt = 743;
                public const int WiperRightLow = 744;
                public const int WiperRightHigh = 745;
                public const int YawDamperOff = 746;
                public const int YawDamperOn = 747;
            }

            public static class Indicator
            {
                public const int AttendCall = 748;
                public const int DoorAftCargo = 749;
                public const int DoorAftEntry = 750;
                public const int DoorAftService = 751;
                public const int DoorAirStairs = 752;
                public const int DoorEquip = 753;
                public const int DoorFwdCargo = 754;
                public const int DoorFwdService = 755;
                public const int DoorFwdEntry = 756;
                public const int DoorLeftAftOverwing = 757;
                public const int DoorLeftFwdOverwing = 758;
                public const int DoorRightAftOverwing = 759;
                public const int DoorRightFwdOverwing = 760;
                public const int DoorAutoUnlock = 761;
                public const int DoorLockFail = 762;
                public const int Elt = 763;
                public const int EquipCoolingExhaustOff = 764;
                public const int EquipCoolingSupplyOff = 765;
                public const int Evacuation = 766;
                public const int FlapsExtended1 = 767;
                public const int FlapsExtended2 = 768;
                public const int FlapsExtended3 = 769;
                public const int FlapsExtended4 = 770;
                public const int FlapsTransit1 = 771;
                public const int FlapsTransit2 = 772;
                public const int FlapsTransit3 = 773;
                public const int FlapsTransit4 = 774;
                public const int FlightRecorderOff = 775;
                public const int Gls = 776;
                public const int Gps = 777;
                public const int Ils = 778;
                public const int MachTrimFail = 779;
                public const int PauseIndicator = 780;
                public const int SlatsExtended1 = 781;
                public const int SlatsExtended2 = 782;
                public const int SlatsExtended3 = 783;
                public const int SlatsExtended4 = 784;
                public const int SlatsExtended5 = 785;
                public const int SlatsExtended6 = 786;
                public const int SlatsExtended7 = 787;
                public const int SlatsExtended8 = 788;
                public const int SlatsFullextended1 = 789;
                public const int SlatsFullextended2 = 790;
                public const int SlatsFullextended3 = 791;
                public const int SlatsFullextended4 = 792;
                public const int SlatsFullextended5 = 793;
                public const int SlatsFullextended6 = 794;
                public const int SlatsFullextended7 = 795;
                public const int SlatsFullextended8 = 796;
                public const int SlatsTransit1 = 797;
                public const int SlatsTransit2 = 798;
                public const int SlatsTransit3 = 799;
                public const int SlatsTransit4 = 800;
                public const int SlatsTransit5 = 801;
                public const int SlatsTransit6 = 802;
                public const int SlatsTransit7 = 803;
                public const int SlatsTransit8 = 804;
                public const int VoiceRecorderStatus = 805;
                public const int WeatherRadarMapLeftIndicator = 806;
                public const int WeatherRadarMapRightIndicator = 807;
                public const int WeatherRadarWxLeftIndicator = 808;
                public const int WeatherRadarWxRightIndicator = 809;
                public const int WeatherRadarWxTLeftIndicator = 810;
                public const int WeatherRadarWxTRightIndicator = 811;
                public const int YawDamper = 812;
            }

            public static class Gauge
            {
                public const int AileronTrimGauge = 813;
            }

            public static class Gate
            {
                public const int Kts80 = 814;
                public const int AspAspAltOut = 815;
                public const int AspAspBoomOut = 816;
                public const int AspAspIcOut = 817;
                public const int AspAspMaskOut = 818;
                public const int AspAspNormOut = 819;
                public const int AspAspRtOut = 820;
                public const int AspFOAspAltOut = 821;
                public const int AspFOAspBoomOut = 822;
                public const int AspFOAspIcOut = 823;
                public const int AspFOAspMaskOut = 824;
                public const int AspFOAspNormOut = 825;
                public const int AspFOAspRtOut = 826;
                public const int AspObsAspAltOut = 827;
                public const int AspObsAspBoomOut = 828;
                public const int AspObsAspIcOut = 829;
                public const int AspObsAspMaskOut = 830;
                public const int AspObsAspNormOut = 831;
                public const int AspObsAspRtOut = 832;
                public const int AttendActive = 833;
                public const int Braking = 834;
                public const int FlightdeckDoorLock = 835;
                public const int GearHandleReleaseSolenoid = 836;
                public const int GearWind = 837;
                public const int GroundGate = 838;
                public const int NoSmokingSign = 839;
                public const int NosewheelRotating = 840;
                public const int SeatbeltSign = 841;
                public const int SpeedbrakeExtended = 842;
                public const int SpeedbrakeExtendedInAir = 843;
                public const int StickShaker = 844;
                public const int StickShakerFO = 845;
                public const int User1Out = 846;
                public const int User10Out = 847;
                public const int User11Out = 848;
                public const int User12Out = 849;
                public const int User13Out = 850;
                public const int User14Out = 851;
                public const int User15Out = 852;
                public const int User16Out = 853;
                public const int User17Out = 854;
                public const int User18Out = 855;
                public const int User19Out = 856;
                public const int User2Out = 857;
                public const int User20Out = 858;
                public const int User3Out = 859;
                public const int User4Out = 860;
                public const int User5Out = 861;
                public const int User6Out = 862;
                public const int User7Out = 863;
                public const int User8Out = 864;
                public const int User9Out = 865;
                public const int V1 = 866;
                public const int V2 = 867;
                public const int Vrotate = 868;
                public const int VoiceRecorderHold = 869;
                public const int VoiceRecorderRelease = 870;
                public const int WiperLeftHighgate = 871;
                public const int WiperLeftIntgate = 872;
                public const int WiperLeftLowgate = 873;
                public const int WiperRightHighgate = 874;
                public const int WiperRightIntgate = 875;
                public const int WiperRightLowgate = 876;
                public const int YawDamperHoldActuator = 877;
                public const int YawDamperOffActuator = 878;
            }

            public static class Numerical
            {
                public const int AileronTrimGaugeNumerical = 879;
                public const int RadioAltitude = 880;
            }

            public static class Analog
            {
                public const int EgtLeftModifier = 881;
                public const int EgtRightModifier = 882;
                public const int FuelFlowLeftModifier = 883;
                public const int FuelFlowRightModifier = 884;
                public const int N1LeftModifier = 885;
                public const int N1RightModifier = 886;
                public const int WeatherRadarGain = 887;
                public const int WeatherRadarGainRight = 888;
                public const int WeatherRadarTilt = 889;
                public const int WeatherRadarTiltRight = 890;
            }

            public static class Encoder
            {
                public const int WeatherRadarAltitudeLeft = 891;
                public const int WeatherRadarAltitudeRight = 892;
            }
        }

        public static class Navigation
        {
            public static class Switch
            {
                public const int Adf1ModeSwitchOff = 893;
                public const int Adf1ModeSwitchAntenna = 894;
                public const int Adf1ModeSwitchAdf = 895;
                public const int Adf1ToneOff = 896;
                public const int Adf1ToneOn = 897;
                public const int Adf2ModeSwitchOff = 898;
                public const int Adf2ModeSwitchAntenna = 899;
                public const int Adf2ModeSwitchAdf = 900;
                public const int Adf2ToneOff = 901;
                public const int Adf2ToneOn = 902;
                public const int Cdu1Key0Normal = 903;
                public const int Cdu1Key0Pushed = 904;
                public const int Cdu1Key1Normal = 905;
                public const int Cdu1Key1Pushed = 906;
                public const int Cdu1Key2Normal = 907;
                public const int Cdu1Key2Pushed = 908;
                public const int Cdu1Key3Normal = 909;
                public const int Cdu1Key3Pushed = 910;
                public const int Cdu1Key4Normal = 911;
                public const int Cdu1Key4Pushed = 912;
                public const int Cdu1Key5Normal = 913;
                public const int Cdu1Key5Pushed = 914;
                public const int Cdu1Key6Normal = 915;
                public const int Cdu1Key6Pushed = 916;
                public const int Cdu1Key7Normal = 917;
                public const int Cdu1Key7Pushed = 918;
                public const int Cdu1Key8Normal = 919;
                public const int Cdu1Key8Pushed = 920;
                public const int Cdu1Key9Normal = 921;
                public const int Cdu1Key9Pushed = 922;
                public const int Cdu1KeyANormal = 923;
                public const int Cdu1KeyAPushed = 924;
                public const int Cdu1KeyAtcNormal = 925;
                public const int Cdu1KeyAtcPushed = 926;
                public const int Cdu1KeyBNormal = 927;
                public const int Cdu1KeyBPushed = 928;
                public const int Cdu1KeyCNormal = 929;
                public const int Cdu1KeyCPushed = 930;
                public const int Cdu1KeyClbNormal = 931;
                public const int Cdu1KeyClbPushed = 932;
                public const int Cdu1KeyClearNormal = 933;
                public const int Cdu1KeyClearPushed = 934;
                public const int Cdu1KeyClearlineNormal = 935;
                public const int Cdu1KeyClearlinePushed = 936;
                public const int Cdu1KeyCrzNormal = 937;
                public const int Cdu1KeyCrzPushed = 938;
                public const int Cdu1KeyDNormal = 939;
                public const int Cdu1KeyDPushed = 940;
                public const int Cdu1KeyDelNormal = 941;
                public const int Cdu1KeyDelPushed = 942;
                public const int Cdu1KeyDepArrNormal = 943;
                public const int Cdu1KeyDepArrPushed = 944;
                public const int Cdu1KeyDesNormal = 945;
                public const int Cdu1KeyDesPushed = 946;
                public const int Cdu1KeyDotNormal = 947;
                public const int Cdu1KeyDotPushed = 948;
                public const int Cdu1KeyENormal = 949;
                public const int Cdu1KeyEPushed = 950;
                public const int Cdu1KeyExecNormal = 951;
                public const int Cdu1KeyExecPushed = 952;
                public const int Cdu1KeyFNormal = 953;
                public const int Cdu1KeyFPushed = 954;
                public const int Cdu1KeyFixNormal = 955;
                public const int Cdu1KeyFixPushed = 956;
                public const int Cdu1KeyFmcCommNormal = 957;
                public const int Cdu1KeyFmcCommPushed = 958;
                public const int Cdu1KeyGNormal = 959;
                public const int Cdu1KeyGPushed = 960;
                public const int Cdu1KeyHNormal = 961;
                public const int Cdu1KeyHPushed = 962;
                public const int Cdu1KeyHoldNormal = 963;
                public const int Cdu1KeyHoldPushed = 964;
                public const int Cdu1KeyINormal = 965;
                public const int Cdu1KeyIPushed = 966;
                public const int Cdu1KeyInitRefNormal = 967;
                public const int Cdu1KeyInitRefPushed = 968;
                public const int Cdu1KeyJNormal = 969;
                public const int Cdu1KeyJPushed = 970;
                public const int Cdu1KeyKNormal = 971;
                public const int Cdu1KeyKPushed = 972;
                public const int Cdu1KeyLNormal = 973;
                public const int Cdu1KeyLPushed = 974;
                public const int Cdu1KeyLegsNormal = 975;
                public const int Cdu1KeyLegsPushed = 976;
                public const int Cdu1KeyLsk1lNormal = 977;
                public const int Cdu1KeyLsk1lPushed = 978;
                public const int Cdu1KeyLsk1rNormal = 979;
                public const int Cdu1KeyLsk1rPushed = 980;
                public const int Cdu1KeyLsk2lNormal = 981;
                public const int Cdu1KeyLsk2lPushed = 982;
                public const int Cdu1KeyLsk2rNormal = 983;
                public const int Cdu1KeyLsk2rPushed = 984;
                public const int Cdu1KeyLsk3lNormal = 985;
                public const int Cdu1KeyLsk3lPushed = 986;
                public const int Cdu1KeyLsk3rNormal = 987;
                public const int Cdu1KeyLsk3rPushed = 988;
                public const int Cdu1KeyLsk4lNormal = 989;
                public const int Cdu1KeyLsk4lPushed = 990;
                public const int Cdu1KeyLsk4rNormal = 991;
                public const int Cdu1KeyLsk4rPushed = 992;
                public const int Cdu1KeyLsk5lNormal = 993;
                public const int Cdu1KeyLsk5lPushed = 994;
                public const int Cdu1KeyLsk5rNormal = 995;
                public const int Cdu1KeyLsk5rPushed = 996;
                public const int Cdu1KeyLsk6lNormal = 997;
                public const int Cdu1KeyLsk6lPushed = 998;
                public const int Cdu1KeyLsk6rNormal = 999;
                public const int Cdu1KeyLsk6rPushed = 1000;
                public const int Cdu1KeyMNormal = 1001;
                public const int Cdu1KeyMPushed = 1002;
                public const int Cdu1KeyMenuNormal = 1003;
                public const int Cdu1KeyMenuPushed = 1004;
                public const int Cdu1KeyMinusNormal = 1005;
                public const int Cdu1KeyMinusPushed = 1006;
                public const int Cdu1KeyNNormal = 1007;
                public const int Cdu1KeyNPushed = 1008;
                public const int Cdu1KeyN1LimitNormal = 1009;
                public const int Cdu1KeyN1LimitPushed = 1010;
                public const int Cdu1KeyNextPageNormal = 1011;
                public const int Cdu1KeyNextPagePushed = 1012;
                public const int Cdu1KeyONormal = 1013;
                public const int Cdu1KeyOPushed = 1014;
                public const int Cdu1KeyPNormal = 1015;
                public const int Cdu1KeyPPushed = 1016;
                public const int Cdu1KeyPrevPageNormal = 1017;
                public const int Cdu1KeyPrevPagePushed = 1018;
                public const int Cdu1KeyProgNormal = 1019;
                public const int Cdu1KeyProgPushed = 1020;
                public const int Cdu1KeyQNormal = 1021;
                public const int Cdu1KeyQPushed = 1022;
                public const int Cdu1KeyRNormal = 1023;
                public const int Cdu1KeyRPushed = 1024;
                public const int Cdu1KeyRteNormal = 1025;
                public const int Cdu1KeyRtePushed = 1026;
                public const int Cdu1KeySNormal = 1027;
                public const int Cdu1KeySPushed = 1028;
                public const int Cdu1KeySlashNormal = 1029;
                public const int Cdu1KeySlashPushed = 1030;
                public const int Cdu1KeySpaceNormal = 1031;
                public const int Cdu1KeySpacePushed = 1032;
                public const int Cdu1KeyTNormal = 1033;
                public const int Cdu1KeyTPushed = 1034;
                public const int Cdu1KeyUNormal = 1035;
                public const int Cdu1KeyUPushed = 1036;
                public const int Cdu1KeyVNormal = 1037;
                public const int Cdu1KeyVPushed = 1038;
                public const int Cdu1KeyVnavNormal = 1039;
                public const int Cdu1KeyVnavPushed = 1040;
                public const int Cdu1KeyWNormal = 1041;
                public const int Cdu1KeyWPushed = 1042;
                public const int Cdu1KeyXNormal = 1043;
                public const int Cdu1KeyXPushed = 1044;
                public const int Cdu1KeyYNormal = 1045;
                public const int Cdu1KeyYPushed = 1046;
                public const int Cdu1KeyZNormal = 1047;
                public const int Cdu1KeyZPushed = 1048;
                public const int Cdu1BrightnessDownNormal = 1049;
                public const int Cdu1BrightnessDownPushed = 1050;
                public const int Cdu1BrightnessUpNormal = 1051;
                public const int Cdu1BrightnessUpPushed = 1052;
                public const int Cdu2Key0Normal = 1053;
                public const int Cdu2Key0Pushed = 1054;
                public const int Cdu2Key1Normal = 1055;
                public const int Cdu2Key1Pushed = 1056;
                public const int Cdu2Key2Normal = 1057;
                public const int Cdu2Key2Pushed = 1058;
                public const int Cdu2Key3Normal = 1059;
                public const int Cdu2Key3Pushed = 1060;
                public const int Cdu2Key4Normal = 1061;
                public const int Cdu2Key4Pushed = 1062;
                public const int Cdu2Key5Normal = 1063;
                public const int Cdu2Key5Pushed = 1064;
                public const int Cdu2Key6Normal = 1065;
                public const int Cdu2Key6Pushed = 1066;
                public const int Cdu2Key7Normal = 1067;
                public const int Cdu2Key7Pushed = 1068;
                public const int Cdu2Key8Normal = 1069;
                public const int Cdu2Key8Pushed = 1070;
                public const int Cdu2Key9Normal = 1071;
                public const int Cdu2Key9Pushed = 1072;
                public const int Cdu2KeyANormal = 1073;
                public const int Cdu2KeyAPushed = 1074;
                public const int Cdu2KeyAtcNormal = 1075;
                public const int Cdu2KeyAtcPushed = 1076;
                public const int Cdu2KeyBNormal = 1077;
                public const int Cdu2KeyBPushed = 1078;
                public const int Cdu2KeyCNormal = 1079;
                public const int Cdu2KeyCPushed = 1080;
                public const int Cdu2KeyClbNormal = 1081;
                public const int Cdu2KeyClbPushed = 1082;
                public const int Cdu2KeyClearNormal = 1083;
                public const int Cdu2KeyClearPushed = 1084;
                public const int Cdu2KeyClearlineNormal = 1085;
                public const int Cdu2KeyClearlinePushed = 1086;
                public const int Cdu2KeyCrzNormal = 1087;
                public const int Cdu2KeyCrzPushed = 1088;
                public const int Cdu2KeyDNormal = 1089;
                public const int Cdu2KeyDPushed = 1090;
                public const int Cdu2KeyDelNormal = 1091;
                public const int Cdu2KeyDelPushed = 1092;
                public const int Cdu2KeyDepArrNormal = 1093;
                public const int Cdu2KeyDepArrPushed = 1094;
                public const int Cdu2KeyDesNormal = 1095;
                public const int Cdu2KeyDesPushed = 1096;
                public const int Cdu2KeyDotNormal = 1097;
                public const int Cdu2KeyDotPushed = 1098;
                public const int Cdu2KeyENormal = 1099;
                public const int Cdu2KeyEPushed = 1100;
                public const int Cdu2KeyExecNormal = 1101;
                public const int Cdu2KeyExecPushed = 1102;
                public const int Cdu2KeyFNormal = 1103;
                public const int Cdu2KeyFPushed = 1104;
                public const int Cdu2KeyFixNormal = 1105;
                public const int Cdu2KeyFixPushed = 1106;
                public const int Cdu2KeyFmcCommNormal = 1107;
                public const int Cdu2KeyFmcCommPushed = 1108;
                public const int Cdu2KeyGNormal = 1109;
                public const int Cdu2KeyGPushed = 1110;
                public const int Cdu2KeyHNormal = 1111;
                public const int Cdu2KeyHPushed = 1112;
                public const int Cdu2KeyHoldNormal = 1113;
                public const int Cdu2KeyHoldPushed = 1114;
                public const int Cdu2KeyINormal = 1115;
                public const int Cdu2KeyIPushed = 1116;
                public const int Cdu2KeyInitRefNormal = 1117;
                public const int Cdu2KeyInitRefPushed = 1118;
                public const int Cdu2KeyJNormal = 1119;
                public const int Cdu2KeyJPushed = 1120;
                public const int Cdu2KeyKNormal = 1121;
                public const int Cdu2KeyKPushed = 1122;
                public const int Cdu2KeyLNormal = 1123;
                public const int Cdu2KeyLPushed = 1124;
                public const int Cdu2KeyLegsNormal = 1125;
                public const int Cdu2KeyLegsPushed = 1126;
                public const int Cdu2KeyLsk1lNormal = 1127;
                public const int Cdu2KeyLsk1lPushed = 1128;
                public const int Cdu2KeyLsk1rNormal = 1129;
                public const int Cdu2KeyLsk1rPushed = 1130;
                public const int Cdu2KeyLsk2lNormal = 1131;
                public const int Cdu2KeyLsk2lPushed = 1132;
                public const int Cdu2KeyLsk2rNormal = 1133;
                public const int Cdu2KeyLsk2rPushed = 1134;
                public const int Cdu2KeyLsk3lNormal = 1135;
                public const int Cdu2KeyLsk3lPushed = 1136;
                public const int Cdu2KeyLsk3rNormal = 1137;
                public const int Cdu2KeyLsk3rPushed = 1138;
                public const int Cdu2KeyLsk4lNormal = 1139;
                public const int Cdu2KeyLsk4lPushed = 1140;
                public const int Cdu2KeyLsk4rNormal = 1141;
                public const int Cdu2KeyLsk4rPushed = 1142;
                public const int Cdu2KeyLsk5lNormal = 1143;
                public const int Cdu2KeyLsk5lPushed = 1144;
                public const int Cdu2KeyLsk5rNormal = 1145;
                public const int Cdu2KeyLsk5rPushed = 1146;
                public const int Cdu2KeyLsk6lNormal = 1147;
                public const int Cdu2KeyLsk6lPushed = 1148;
                public const int Cdu2KeyLsk6rNormal = 1149;
                public const int Cdu2KeyLsk6rPushed = 1150;
                public const int Cdu2KeyMNormal = 1151;
                public const int Cdu2KeyMPushed = 1152;
                public const int Cdu2KeyMenuNormal = 1153;
                public const int Cdu2KeyMenuPushed = 1154;
                public const int Cdu2KeyMinusNormal = 1155;
                public const int Cdu2KeyMinusPushed = 1156;
                public const int Cdu2KeyNNormal = 1157;
                public const int Cdu2KeyNPushed = 1158;
                public const int Cdu2KeyN1LimitNormal = 1159;
                public const int Cdu2KeyN1LimitPushed = 1160;
                public const int Cdu2KeyNextPageNormal = 1161;
                public const int Cdu2KeyNextPagePushed = 1162;
                public const int Cdu2KeyONormal = 1163;
                public const int Cdu2KeyOPushed = 1164;
                public const int Cdu2KeyPNormal = 1165;
                public const int Cdu2KeyPPushed = 1166;
                public const int Cdu2KeyPrevPageNormal = 1167;
                public const int Cdu2KeyPrevPagePushed = 1168;
                public const int Cdu2KeyProgNormal = 1169;
                public const int Cdu2KeyProgPushed = 1170;
                public const int Cdu2KeyQNormal = 1171;
                public const int Cdu2KeyQPushed = 1172;
                public const int Cdu2KeyRNormal = 1173;
                public const int Cdu2KeyRPushed = 1174;
                public const int Cdu2KeyRteNormal = 1175;
                public const int Cdu2KeyRtePushed = 1176;
                public const int Cdu2KeySNormal = 1177;
                public const int Cdu2KeySPushed = 1178;
                public const int Cdu2KeySlashNormal = 1179;
                public const int Cdu2KeySlashPushed = 1180;
                public const int Cdu2KeySpaceNormal = 1181;
                public const int Cdu2KeySpacePushed = 1182;
                public const int Cdu2KeyTNormal = 1183;
                public const int Cdu2KeyTPushed = 1184;
                public const int Cdu2KeyUNormal = 1185;
                public const int Cdu2KeyUPushed = 1186;
                public const int Cdu2KeyVNormal = 1187;
                public const int Cdu2KeyVPushed = 1188;
                public const int Cdu2KeyVnavNormal = 1189;
                public const int Cdu2KeyVnavPushed = 1190;
                public const int Cdu2KeyWNormal = 1191;
                public const int Cdu2KeyWPushed = 1192;
                public const int Cdu2KeyXNormal = 1193;
                public const int Cdu2KeyXPushed = 1194;
                public const int Cdu2KeyYNormal = 1195;
                public const int Cdu2KeyYPushed = 1196;
                public const int Cdu2KeyZNormal = 1197;
                public const int Cdu2KeyZPushed = 1198;
                public const int Cdu2BrightnessDownNormal = 1199;
                public const int Cdu2BrightnessDownPushed = 1200;
                public const int Cdu2BrightnessUpNormal = 1201;
                public const int Cdu2BrightnessUpPushed = 1202;
                public const int FmcNormal = 1203;
                public const int FmcBothOnL = 1204;
                public const int FmcBothOnR = 1205;
                public const int IrsNormal = 1206;
                public const int IrsBothOnL = 1207;
                public const int IrsBothOnR = 1208;
                public const int IrsDispSelTkGs = 1209;
                public const int IrsDispSelTest = 1210;
                public const int IrsDispSelPpos = 1211;
                public const int IrsDispSelWind = 1212;
                public const int IrsDispSelHdgSts = 1213;
                public const int IrsKeypad0Off = 1214;
                public const int IrsKeypad0Pushed = 1215;
                public const int IrsKeypad1Off = 1216;
                public const int IrsKeypad1Pushed = 1217;
                public const int IrsKeypad2Off = 1218;
                public const int IrsKeypad2Pushed = 1219;
                public const int IrsKeypad3Off = 1220;
                public const int IrsKeypad3Pushed = 1221;
                public const int IrsKeypad4Off = 1222;
                public const int IrsKeypad4Pushed = 1223;
                public const int IrsKeypad5Off = 1224;
                public const int IrsKeypad5Pushed = 1225;
                public const int IrsKeypad6Off = 1226;
                public const int IrsKeypad6Pushed = 1227;
                public const int IrsKeypad7Off = 1228;
                public const int IrsKeypad7Pushed = 1229;
                public const int IrsKeypad8Off = 1230;
                public const int IrsKeypad8Pushed = 1231;
                public const int IrsKeypad9Off = 1232;
                public const int IrsKeypad9Pushed = 1233;
                public const int IrsKeypadClrOff = 1234;
                public const int IrsKeypadClrPushed = 1235;
                public const int IrsKeypadEntOff = 1236;
                public const int IrsKeypadEntPushed = 1237;
                public const int IrsSysDsplLeft = 1238;
                public const int IrsSysDsplRight = 1239;
                public const int IrsLeftNav = 1240;
                public const int IrsLeftOff = 1241;
                public const int IrsLeftAlign = 1242;
                public const int IrsLeftAtt = 1243;
                public const int IrsRightNav = 1244;
                public const int IrsRightOff = 1245;
                public const int IrsRightAlign = 1246;
                public const int IrsRightAtt = 1247;
                public const int MultiNavCapt0Normal = 1248;
                public const int MultiNavCapt0Pushed = 1249;
                public const int MultiNavCapt1Normal = 1250;
                public const int MultiNavCapt1Pushed = 1251;
                public const int MultiNavCapt2Normal = 1252;
                public const int MultiNavCapt2Pushed = 1253;
                public const int MultiNavCapt3Normal = 1254;
                public const int MultiNavCapt3Pushed = 1255;
                public const int MultiNavCapt4Normal = 1256;
                public const int MultiNavCapt4Pushed = 1257;
                public const int MultiNavCapt5Normal = 1258;
                public const int MultiNavCapt5Pushed = 1259;
                public const int MultiNavCapt6Normal = 1260;
                public const int MultiNavCapt6Pushed = 1261;
                public const int MultiNavCapt7Normal = 1262;
                public const int MultiNavCapt7Pushed = 1263;
                public const int MultiNavCapt8Normal = 1264;
                public const int MultiNavCapt8Pushed = 1265;
                public const int MultiNavCapt9Normal = 1266;
                public const int MultiNavCapt9Pushed = 1267;
                public const int MultiNavCaptClrNormal = 1268;
                public const int MultiNavCaptClrPushed = 1269;
                public const int MultiNavCaptModeDownNormal = 1270;
                public const int MultiNavCaptModeDownPushed = 1271;
                public const int MultiNavCaptModeUpNormal = 1272;
                public const int MultiNavCaptModeUpPushed = 1273;
                public const int MultiNavCaptTestNormal = 1274;
                public const int MultiNavCaptTestPushed = 1275;
                public const int MultiNavCaptXfrNormal = 1276;
                public const int MultiNavCaptXfrPushed = 1277;
                public const int MultiNavFO0Normal = 1278;
                public const int MultiNavFO0Pushed = 1279;
                public const int MultiNavFO1Normal = 1280;
                public const int MultiNavFO1Pushed = 1281;
                public const int MultiNavFO2Normal = 1282;
                public const int MultiNavFO2Pushed = 1283;
                public const int MultiNavFO3Normal = 1284;
                public const int MultiNavFO3Pushed = 1285;
                public const int MultiNavFO4Normal = 1286;
                public const int MultiNavFO4Pushed = 1287;
                public const int MultiNavFO5Normal = 1288;
                public const int MultiNavFO5Pushed = 1289;
                public const int MultiNavFO6Normal = 1290;
                public const int MultiNavFO6Pushed = 1291;
                public const int MultiNavFO7Normal = 1292;
                public const int MultiNavFO7Pushed = 1293;
                public const int MultiNavFO8Normal = 1294;
                public const int MultiNavFO8Pushed = 1295;
                public const int MultiNavFO9Normal = 1296;
                public const int MultiNavFO9Pushed = 1297;
                public const int MultiNavFOClrNormal = 1298;
                public const int MultiNavFOClrPushed = 1299;
                public const int MultiNavFOModeDownNormal = 1300;
                public const int MultiNavFOModeDownPushed = 1301;
                public const int MultiNavFOModeUpNormal = 1302;
                public const int MultiNavFOModeUpPushed = 1303;
                public const int MultiNavFOTestNormal = 1304;
                public const int MultiNavFOTestPushed = 1305;
                public const int MultiNavFOXfrNormal = 1306;
                public const int MultiNavFOXfrPushed = 1307;
                public const int RadioAdf1HundredsActivePulseDownOff = 1308;
                public const int RadioAdf1HundredsActivePulseDownOn = 1309;
                public const int RadioAdf1HundredsActivePulseUpOff = 1310;
                public const int RadioAdf1HundredsActivePulseUpOn = 1311;
                public const int RadioAdf1InnerShaftActivePulseDownOff = 1312;
                public const int RadioAdf1InnerShaftActivePulseDownOn = 1313;
                public const int RadioAdf1InnerShaftActivePulseUpOff = 1314;
                public const int RadioAdf1InnerShaftActivePulseUpOn = 1315;
                public const int RadioAdf1InnerShaftPulseDownOff = 1316;
                public const int RadioAdf1InnerShaftPulseDownOn = 1317;
                public const int RadioAdf1InnerShaftPulseUpOff = 1318;
                public const int RadioAdf1InnerShaftPulseUpOn = 1319;
                public const int RadioAdf1OuterShaftActivePulseDownOff = 1320;
                public const int RadioAdf1OuterShaftActivePulseDownOn = 1321;
                public const int RadioAdf1OuterShaftActivePulseUpOff = 1322;
                public const int RadioAdf1OuterShaftActivePulseUpOn = 1323;
                public const int RadioAdf1OuterShaftPulseDownOff = 1324;
                public const int RadioAdf1OuterShaftPulseDownOn = 1325;
                public const int RadioAdf1OuterShaftPulseUpOff = 1326;
                public const int RadioAdf1OuterShaftPulseUpOn = 1327;
                public const int RadioAdf2HundredsActivePulseDownOff = 1328;
                public const int RadioAdf2HundredsActivePulseDownOn = 1329;
                public const int RadioAdf2HundredsActivePulseUpOff = 1330;
                public const int RadioAdf2HundredsActivePulseUpOn = 1331;
                public const int RadioAdf2InnerShaftActivePulseDownOff = 1332;
                public const int RadioAdf2InnerShaftActivePulseDownOn = 1333;
                public const int RadioAdf2InnerShaftActivePulseUpOff = 1334;
                public const int RadioAdf2InnerShaftActivePulseUpOn = 1335;
                public const int RadioAdf2InnerShaftPulseDownOff = 1336;
                public const int RadioAdf2InnerShaftPulseDownOn = 1337;
                public const int RadioAdf2InnerShaftPulseUpOff = 1338;
                public const int RadioAdf2InnerShaftPulseUpOn = 1339;
                public const int RadioAdf2OuterShaftActivePulseDownOff = 1340;
                public const int RadioAdf2OuterShaftActivePulseDownOn = 1341;
                public const int RadioAdf2OuterShaftActivePulseUpOff = 1342;
                public const int RadioAdf2OuterShaftActivePulseUpOn = 1343;
                public const int RadioAdf2OuterShaftPulseDownOff = 1344;
                public const int RadioAdf2OuterShaftPulseDownOn = 1345;
                public const int RadioAdf2OuterShaftPulseUpOff = 1346;
                public const int RadioAdf2OuterShaftPulseUpOn = 1347;
                public const int RadioCom1InnerShaftPulseDownOff = 1348;
                public const int RadioCom1InnerShaftPulseDownOn = 1349;
                public const int RadioCom1InnerShaftPulseUpOff = 1350;
                public const int RadioCom1InnerShaftPulseUpOn = 1351;
                public const int RadioCom1OuterShaftPulseDownOff = 1352;
                public const int RadioCom1OuterShaftPulseDownOn = 1353;
                public const int RadioCom1OuterShaftPulseUpOff = 1354;
                public const int RadioCom1OuterShaftPulseUpOn = 1355;
                public const int RadioCom2InnerShaftPulseDownOff = 1356;
                public const int RadioCom2InnerShaftPulseDownOn = 1357;
                public const int RadioCom2InnerShaftPulseUpOff = 1358;
                public const int RadioCom2InnerShaftPulseUpOn = 1359;
                public const int RadioCom2OuterShaftPulseDownOff = 1360;
                public const int RadioCom2OuterShaftPulseDownOn = 1361;
                public const int RadioCom2OuterShaftPulseUpOff = 1362;
                public const int RadioCom2OuterShaftPulseUpOn = 1363;
                public const int RadioCom3InnerShaftPulseDownOff = 1364;
                public const int RadioCom3InnerShaftPulseDownOn = 1365;
                public const int RadioCom3InnerShaftPulseUpOff = 1366;
                public const int RadioCom3InnerShaftPulseUpOn = 1367;
                public const int RadioCom3OuterShaftPulseDownOff = 1368;
                public const int RadioCom3OuterShaftPulseDownOn = 1369;
                public const int RadioCom3OuterShaftPulseUpOff = 1370;
                public const int RadioCom3OuterShaftPulseUpOn = 1371;
                public const int RadioNav1InnerShaftPulseDownOff = 1372;
                public const int RadioNav1InnerShaftPulseDownOn = 1373;
                public const int RadioNav1InnerShaftPulseUpOff = 1374;
                public const int RadioNav1InnerShaftPulseUpOn = 1375;
                public const int RadioNav1OuterShaftPulseDownOff = 1376;
                public const int RadioNav1OuterShaftPulseDownOn = 1377;
                public const int RadioNav1OuterShaftPulseUpOff = 1378;
                public const int RadioNav1OuterShaftPulseUpOn = 1379;
                public const int RadioNav2InnerShaftPulseDownOff = 1380;
                public const int RadioNav2InnerShaftPulseDownOn = 1381;
                public const int RadioNav2InnerShaftPulseUpOff = 1382;
                public const int RadioNav2InnerShaftPulseUpOn = 1383;
                public const int RadioNav2OuterShaftPulseDownOff = 1384;
                public const int RadioNav2OuterShaftPulseDownOn = 1385;
                public const int RadioNav2OuterShaftPulseUpOff = 1386;
                public const int RadioNav2OuterShaftPulseUpOn = 1387;
                public const int RadioTestAdf1Normal = 1388;
                public const int RadioTestAdf1Pushed = 1389;
                public const int RadioTestAdf2Normal = 1390;
                public const int RadioTestAdf2Pushed = 1391;
                public const int RadioTestCom1Normal = 1392;
                public const int RadioTestCom1Pushed = 1393;
                public const int RadioTestCom2Normal = 1394;
                public const int RadioTestCom2Pushed = 1395;
                public const int RadioTestCom3Normal = 1396;
                public const int RadioTestCom3Pushed = 1397;
                public const int RadioTestNav1Normal = 1398;
                public const int RadioTestNav1Pushed = 1399;
                public const int RadioTestNav2Normal = 1400;
                public const int RadioTestNav2Pushed = 1401;
                public const int RadioTfrAdf1Normal = 1402;
                public const int RadioTfrAdf1Pushed = 1403;
                public const int RadioTfrAdf2Normal = 1404;
                public const int RadioTfrAdf2Pushed = 1405;
                public const int RadioTfrCom1Normal = 1406;
                public const int RadioTfrCom1Pushed = 1407;
                public const int RadioTfrCom2Normal = 1408;
                public const int RadioTfrCom2Pushed = 1409;
                public const int RadioTfrCom3Normal = 1410;
                public const int RadioTfrCom3Pushed = 1411;
                public const int RadioTfrNav1Normal = 1412;
                public const int RadioTfrNav1Pushed = 1413;
                public const int RadioTfrNav2Normal = 1414;
                public const int RadioTfrNav2Pushed = 1415;
                public const int RadioXpdrInnerShaftLeftPulseDownOff = 1416;
                public const int RadioXpdrInnerShaftLeftPulseDownOn = 1417;
                public const int RadioXpdrInnerShaftLeftPulseUpOff = 1418;
                public const int RadioXpdrInnerShaftLeftPulseUpOn = 1419;
                public const int RadioXpdrInnerShaftRightPulseDownOff = 1420;
                public const int RadioXpdrInnerShaftRightPulseDownOn = 1421;
                public const int RadioXpdrInnerShaftRightPulseUpOff = 1422;
                public const int RadioXpdrInnerShaftRightPulseUpOn = 1423;
                public const int RadioXpdrOuterShaftLeftPulseDownOff = 1424;
                public const int RadioXpdrOuterShaftLeftPulseDownOn = 1425;
                public const int RadioXpdrOuterShaftLeftPulseUpOff = 1426;
                public const int RadioXpdrOuterShaftLeftPulseUpOn = 1427;
                public const int RadioXpdrOuterShaftRightPulseDownOff = 1428;
                public const int RadioXpdrOuterShaftRightPulseDownOn = 1429;
                public const int RadioXpdrOuterShaftRightPulseUpOff = 1430;
                public const int RadioXpdrOuterShaftRightPulseUpOn = 1431;
                public const int RadioXpdrSelector1Off = 1432;
                public const int RadioXpdrSelector10 = 1433;
                public const int RadioXpdrSelector11 = 1434;
                public const int RadioXpdrSelector12 = 1435;
                public const int RadioXpdrSelector13 = 1436;
                public const int RadioXpdrSelector14 = 1437;
                public const int RadioXpdrSelector15 = 1438;
                public const int RadioXpdrSelector16 = 1439;
                public const int RadioXpdrSelector17 = 1440;
                public const int RadioXpdrSelector2Off = 1441;
                public const int RadioXpdrSelector20 = 1442;
                public const int RadioXpdrSelector21 = 1443;
                public const int RadioXpdrSelector22 = 1444;
                public const int RadioXpdrSelector23 = 1445;
                public const int RadioXpdrSelector24 = 1446;
                public const int RadioXpdrSelector25 = 1447;
                public const int RadioXpdrSelector26 = 1448;
                public const int RadioXpdrSelector27 = 1449;
                public const int RadioXpdrSelector3Off = 1450;
                public const int RadioXpdrSelector30 = 1451;
                public const int RadioXpdrSelector31 = 1452;
                public const int RadioXpdrSelector32 = 1453;
                public const int RadioXpdrSelector33 = 1454;
                public const int RadioXpdrSelector34 = 1455;
                public const int RadioXpdrSelector35 = 1456;
                public const int RadioXpdrSelector36 = 1457;
                public const int RadioXpdrSelector37 = 1458;
                public const int RadioXpdrSelector4Off = 1459;
                public const int RadioXpdrSelector40 = 1460;
                public const int RadioXpdrSelector41 = 1461;
                public const int RadioXpdrSelector42 = 1462;
                public const int RadioXpdrSelector43 = 1463;
                public const int RadioXpdrSelector44 = 1464;
                public const int RadioXpdrSelector45 = 1465;
                public const int RadioXpdrSelector46 = 1466;
                public const int RadioXpdrSelector47 = 1467;
                public const int TcasStdby = 1468;
                public const int TcasAltRptgOff = 1469;
                public const int TcasXpdr = 1470;
                public const int TcasTa = 1471;
                public const int TcasTaRa = 1472;
                public const int TcasTest = 1473;
                public const int TcasTestNormal = 1474;
                public const int TcasTestPushed = 1475;
                public const int TcasHorizontalRangeMax = 1476;
                public const int TcasHorizontalRange5 = 1477;
                public const int TcasHorizontalRange10 = 1478;
                public const int TcasHorizontalRange20 = 1479;
                public const int TcasVerticalRangeNormal = 1480;
                public const int TcasVerticalRangeAbove = 1481;
                public const int TcasVerticalRangeBelow = 1482;
                public const int VhfNavNormal = 1483;
                public const int VhfNavBothOn1 = 1484;
                public const int VhfNavBothOn2 = 1485;
                public const int XpdrAltSource1 = 1486;
                public const int XpdrAltSource2 = 1487;
                public const int XpdrIdentNormal = 1488;
                public const int XpdrIdentPushed = 1489;
                public const int XpdrOperationAuto = 1490;
                public const int XpdrOperationStandby = 1491;
                public const int XpdrOperationOn = 1492;
                public const int XpdrSelector1 = 1493;
                public const int XpdrSelector2 = 1494;
            }

            public static class Indicator
            {
                public const int Adf1Adf = 1495;
                public const int Adf1Ant = 1496;
                public const int Adf2Adf = 1497;
                public const int Adf2Ant = 1498;
                public const int Cdu1Call = 1499;
                public const int Cdu1Exec = 1500;
                public const int Cdu1Fail = 1501;
                public const int Cdu1Msg = 1502;
                public const int Cdu1Offset = 1503;
                public const int Cdu2Call = 1504;
                public const int Cdu2Exec = 1505;
                public const int Cdu2Fail = 1506;
                public const int Cdu2Msg = 1507;
                public const int Cdu2Offset = 1508;
                public const int IrsKeypadClrCue = 1509;
                public const int IrsKeypadEntCue = 1510;
                public const int IrsPanelDot1 = 1511;
                public const int IrsPanelDot2 = 1512;
                public const int IrsPanelDot3 = 1513;
                public const int IrsPanelDot4 = 1514;
                public const int IrsPanelDot5 = 1515;
                public const int IrsPanelDot6 = 1516;
                public const int IrsLeftDcFail = 1517;
                public const int IrsLeftFault = 1518;
                public const int IrsLeftOnDc = 1519;
                public const int IrsLeftAlign = 1520;
                public const int IrsRightDcFail = 1521;
                public const int IrsRightFault = 1522;
                public const int IrsRightOnDc = 1523;
                public const int IrsRightAlign = 1524;
                public const int Transponder1Active = 1525;
                public const int Transponder2Active = 1526;
                public const int XpdrFail = 1527;
            }

            public static class Gate
            {
                public const int AtcLabel = 1528;
                public const int AboveTransitionAltitude = 1529;
                public const int Irs1Attitude = 1530;
                public const int Irs1Heading = 1531;
                public const int Irs1Position = 1532;
                public const int Irs2Attitude = 1533;
                public const int Irs2Heading = 1534;
                public const int Irs2Position = 1535;
            }

            public static class Numerical
            {
                public const int Adf1Mode = 1536;
                public const int Adf2Mode = 1537;
                public const int IrsDisplayLeftCharState = 1538;
                public const int IrsDisplayLeftMode = 1539;
                public const int IrsDisplayLeftNumber = 1540;
                public const int IrsDisplayRightCharState = 1541;
                public const int IrsDisplayRightMode = 1542;
                public const int IrsDisplayRightNumber = 1543;
                public const int MultiNavCaptActiveDisplayMode = 1544;
                public const int MultiNavCaptActiveNavMode = 1545;
                public const int MultiNavCaptActiveValue = 1546;
                public const int MultiNavCaptStandbyDisplayMode = 1547;
                public const int MultiNavCaptStandbyNavMode = 1548;
                public const int MultiNavCaptStandbyValue = 1549;
                public const int MultiNavFOActiveDisplayMode = 1550;
                public const int MultiNavFOActiveNavMode = 1551;
                public const int MultiNavFOActiveValue = 1552;
                public const int MultiNavFOStandbyDisplayMode = 1553;
                public const int MultiNavFOStandbyNavMode = 1554;
                public const int MultiNavFOStandbyValue = 1555;
                public const int PressureAltitude = 1556;
                public const int RadioActiveModeAdf1 = 1557;
                public const int RadioActiveModeAdf2 = 1558;
                public const int RadioActiveModeCom1 = 1559;
                public const int RadioActiveModeCom2 = 1560;
                public const int RadioActiveModeCom3 = 1561;
                public const int RadioActiveModeNav1 = 1562;
                public const int RadioActiveModeNav2 = 1563;
                public const int RadioActiveModeXpdr = 1564;
                public const int RadioActiveModeXpdr2 = 1565;
                public const int RadioStandbyModeAdf1 = 1566;
                public const int RadioStandbyModeAdf2 = 1567;
                public const int RadioStandbyModeCom1 = 1568;
                public const int RadioStandbyModeCom2 = 1569;
                public const int RadioStandbyModeCom3 = 1570;
                public const int RadioStandbyModeNav1 = 1571;
                public const int RadioStandbyModeNav2 = 1572;
                public const int RadioStandbyModeXpdr2 = 1573;
                public const int RadioFreqAdf1 = 1574;
                public const int RadioFreqAdf2 = 1575;
                public const int RadioFreqCom1 = 1576;
                public const int RadioFreqCom2 = 1577;
                public const int RadioFreqCom3 = 1578;
                public const int RadioFreqHf1 = 1579;
                public const int RadioFreqHf2 = 1580;
                public const int RadioFreqNav1 = 1581;
                public const int RadioFreqNav2 = 1582;
                public const int RadioFreqXpdr = 1583;
                public const int RadioFreqXpdr2 = 1584;
                public const int RadioStandbyFreqAdf1 = 1585;
                public const int RadioStandbyFreqAdf2 = 1586;
                public const int RadioStandbyFreqCom1 = 1587;
                public const int RadioStandbyFreqCom2 = 1588;
                public const int RadioStandbyFreqCom3 = 1589;
                public const int RadioStandbyFreqHf1 = 1590;
                public const int RadioStandbyFreqHf2 = 1591;
                public const int RadioStandbyFreqNav1 = 1592;
                public const int RadioStandbyFreqNav2 = 1593;
                public const int RadioStandbyFreqXpdr2 = 1594;
            }

            public static class Analog
            {
                public const int Cdu1Brightness = 1595;
                public const int Cdu2Brightness = 1596;
                public const int RadioFreqInputAdf1 = 1597;
                public const int RadioFreqInputAdf2 = 1598;
                public const int RadioFreqInputCom1 = 1599;
                public const int RadioFreqInputCom2 = 1600;
                public const int RadioFreqInputCom3 = 1601;
                public const int RadioFreqInputHf1 = 1602;
                public const int RadioFreqInputHf2 = 1603;
                public const int RadioFreqInputNav1 = 1604;
                public const int RadioFreqInputNav2 = 1605;
                public const int RadioFreqInputXpdr = 1606;
                public const int RadioFreqInputXpdr2 = 1607;
                public const int RadioStandbyFreqInputAdf1 = 1608;
                public const int RadioStandbyFreqInputAdf2 = 1609;
                public const int RadioStandbyFreqInputCom1 = 1610;
                public const int RadioStandbyFreqInputCom2 = 1611;
                public const int RadioStandbyFreqInputCom3 = 1612;
                public const int RadioStandbyFreqInputHf1 = 1613;
                public const int RadioStandbyFreqInputHf2 = 1614;
                public const int RadioStandbyFreqInputNav1 = 1615;
                public const int RadioStandbyFreqInputNav2 = 1616;
                public const int RadioStandbyFreqInputXpdr2 = 1617;
            }

            public static class Encoder
            {
                public const int RadioAdf1HundredsActive = 1618;
                public const int RadioAdf1InnerShaft = 1619;
                public const int RadioAdf1InnerShaftActive = 1620;
                public const int RadioAdf1OuterShaft = 1621;
                public const int RadioAdf1OuterShaftActive = 1622;
                public const int RadioAdf2HundredsActive = 1623;
                public const int RadioAdf2InnerShaft = 1624;
                public const int RadioAdf2InnerShaftActive = 1625;
                public const int RadioAdf2OuterShaft = 1626;
                public const int RadioAdf2OuterShaftActive = 1627;
                public const int RadioCom1InnerShaft = 1628;
                public const int RadioCom1OuterShaft = 1629;
                public const int RadioCom2InnerShaft = 1630;
                public const int RadioCom2OuterShaft = 1631;
                public const int RadioCom3InnerShaft = 1632;
                public const int RadioCom3OuterShaft = 1633;
                public const int RadioNav1InnerShaft = 1634;
                public const int RadioNav1OuterShaft = 1635;
                public const int RadioNav2InnerShaft = 1636;
                public const int RadioNav2OuterShaft = 1637;
                public const int RadioXpdrInnerShaftLeft = 1638;
                public const int RadioXpdrInnerShaftRight = 1639;
                public const int RadioXpdrOuterShaftLeft = 1640;
                public const int RadioXpdrOuterShaftRight = 1641;
            }
        }

        public static class Warning
        {
            public static class Switch
            {
                public const int FireWarning1Off = 1642;
                public const int FireWarning1Pushed = 1643;
                public const int FireWarning2Off = 1644;
                public const int FireWarning2Pushed = 1645;
                public const int MasterCaution1Off = 1646;
                public const int MasterCaution1Pushed = 1647;
                public const int MasterCaution2Off = 1648;
                public const int MasterCaution2Pushed = 1649;
                public const int Recall1Off = 1650;
                public const int Recall1Pushed = 1651;
                public const int Recall2Off = 1652;
                public const int Recall2Pushed = 1653;
            }

            public static class Indicator
            {
                public const int FireWarning1 = 1654;
                public const int FireWarning2 = 1655;
                public const int MasterCaution1 = 1656;
                public const int MasterCaution2 = 1657;
                public const int WarnAirCond = 1658;
                public const int WarnAntiIce = 1659;
                public const int WarnApu = 1660;
                public const int WarnDoors = 1661;
                public const int WarnElec = 1662;
                public const int WarnEng = 1663;
                public const int WarnFltCont = 1664;
                public const int WarnFuel = 1665;
                public const int WarnHyd = 1666;
                public const int WarnIrs = 1667;
                public const int WarnOverhead = 1668;
                public const int WarnOvhtDet = 1669;
            }
        }

        public static class Fire
        {
            public static class Switch
            {
                public const int ApuBottleDischargedPttNormal = 1670;
                public const int ApuBottleDischargedPttPushed = 1671;
                public const int ApuBottleIndicatorPttNormal = 1672;
                public const int ApuBottleIndicatorPttPushed = 1673;
                public const int BellCutoutOff = 1674;
                public const int BellCutoutPushed = 1675;
                public const int CargoFireAftSelectorNorm = 1676;
                public const int CargoFireAftSelectorA = 1677;
                public const int CargoFireAftSelectorB = 1678;
                public const int CargoFireArmAftOff = 1679;
                public const int CargoFireArmAftPushed = 1680;
                public const int CargoFireArmAftLatchOff = 1681;
                public const int CargoFireArmAftLatchOn = 1682;
                public const int CargoFireArmFwdOff = 1683;
                public const int CargoFireArmFwdPushed = 1684;
                public const int CargoFireArmFwdLatchOff = 1685;
                public const int CargoFireArmFwdLatchOn = 1686;
                public const int CargoFireDetectorFaultPttNormal = 1687;
                public const int CargoFireDetectorFaultPttPushed = 1688;
                public const int CargoFireDischOff = 1689;
                public const int CargoFireDischPushed = 1690;
                public const int CargoFireExtLightAftPttNormal = 1691;
                public const int CargoFireExtLightAftPttPushed = 1692;
                public const int CargoFireExtLightFwdPttNormal = 1693;
                public const int CargoFireExtLightFwdPttPushed = 1694;
                public const int CargoFireFwdSelectorNorm = 1695;
                public const int CargoFireFwdSelectorA = 1696;
                public const int CargoFireFwdSelectorB = 1697;
                public const int CargoFireTestOff = 1698;
                public const int CargoFireTestPushed = 1699;
                public const int Engine1OverheatPttNormal = 1700;
                public const int Engine1OverheatPttPushed = 1701;
                public const int Engine2OverheatPttNormal = 1702;
                public const int Engine2OverheatPttPushed = 1703;
                public const int FireApuDetInopPttNormal = 1704;
                public const int FireApuDetInopPttPushed = 1705;
                public const int FireExtTestOff = 1706;
                public const int FireExtTest1 = 1707;
                public const int FireExtTest2 = 1708;
                public const int FireFaultPttNormal = 1709;
                public const int FireFaultPttPushed = 1710;
                public const int FireWheelWellPttNormal = 1711;
                public const int FireWheelWellPttPushed = 1712;
                public const int FireHandleApuOff = 1713;
                public const int FireHandleApuLeft = 1714;
                public const int FireHandleApuRight = 1715;
                public const int FireHandleEngine1Off = 1716;
                public const int FireHandleEngine1Left = 1717;
                public const int FireHandleEngine1Right = 1718;
                public const int FireHandleEngine2Off = 1719;
                public const int FireHandleEngine2Left = 1720;
                public const int FireHandleEngine2Right = 1721;
                public const int FireHandlePullApuNormal = 1722;
                public const int FireHandlePullApuPull = 1723;
                public const int FireHandlePullEngine1Normal = 1724;
                public const int FireHandlePullEngine1Pull = 1725;
                public const int FireHandlePullEngine2Normal = 1726;
                public const int FireHandlePullEngine2Pull = 1727;
                public const int LBottleDischargedPttNormal = 1728;
                public const int LBottleDischargedPttPushed = 1729;
                public const int LBottleIndicatorPttNormal = 1730;
                public const int LBottleIndicatorPttPushed = 1731;
                public const int OvhtDetLeftNormal = 1732;
                public const int OvhtDetLeftA = 1733;
                public const int OvhtDetLeftB = 1734;
                public const int OvhtDetRightNormal = 1735;
                public const int OvhtDetRightA = 1736;
                public const int OvhtDetRightB = 1737;
                public const int OvhtTestOff = 1738;
                public const int OvhtTestFaultInop = 1739;
                public const int OvhtTestOvhtFire = 1740;
                public const int RBottleDischargedPttNormal = 1741;
                public const int RBottleDischargedPttPushed = 1742;
                public const int RBottleIndicatorPttNormal = 1743;
                public const int RBottleIndicatorPttPushed = 1744;
            }

            public static class Indicator
            {
                public const int ApuBottleDischarged = 1745;
                public const int ApuBottleIndicator = 1746;
                public const int ApuFireHandleLight = 1747;
                public const int CargoFireArmedAft = 1748;
                public const int CargoFireArmedFwd = 1749;
                public const int CargoFireDetectorFault = 1750;
                public const int CargoFireDischLight = 1751;
                public const int CargoFireExtLightAft = 1752;
                public const int CargoFireExtLightFwd = 1753;
                public const int CargoFireIndicatorAft = 1754;
                public const int CargoFireIndicatorFwd = 1755;
                public const int Engine1FireHandleLight = 1756;
                public const int Engine1Overheat = 1757;
                public const int Engine2FireHandleLight = 1758;
                public const int Engine2Overheat = 1759;
                public const int Equipment = 1760;
                public const int FireApuDetInop = 1761;
                public const int FireFault = 1762;
                public const int FireWheelWell = 1763;
                public const int LBottleDischarged = 1764;
                public const int LBottleIndicator = 1765;
                public const int LavatorySmoke = 1766;
                public const int RBottleDischarged = 1767;
                public const int RBottleIndicator = 1768;
            }

            public static class Gate
            {
                public const int FireBell = 1769;
                public const int FireHandleUnlockApu = 1770;
                public const int FireHandleUnlockEngine1 = 1771;
                public const int FireHandleUnlockEngine2 = 1772;
            }
        }

        public static class Audio
        {
            public static class Gate
            {
                public const int AirspeedLow = 1773;
                public const int AltitudeAlert = 1774;
                public const int ApproachingMinimums = 1775;
                public const int AutopilotDisconnect = 1776;
                public const int BankAngle = 1777;
                public const int CabinAltAudio = 1778;
                public const int DontSink = 1779;
                public const int EvacCabin = 1780;
                public const int EvacCockpit = 1781;
                public const int FireAudio = 1782;
                public const int Gpws10 = 1783;
                public const int Gpws100 = 1784;
                public const int Gpws1000 = 1785;
                public const int Gpws20 = 1786;
                public const int Gpws200 = 1787;
                public const int Gpws2500 = 1788;
                public const int Gpws30 = 1789;
                public const int Gpws300 = 1790;
                public const int Gpws40 = 1791;
                public const int Gpws400 = 1792;
                public const int Gpws50 = 1793;
                public const int Gpws500 = 1794;
                public const int GearWarning = 1795;
                public const int Glideslope = 1796;
                public const int GroundCall = 1797;
                public const int HighChime = 1798;
                public const int HighLowChime = 1799;
                public const int LowChime = 1800;
                public const int Minimums = 1801;
                public const int NoSmokingAudio = 1802;
                public const int Overspeed = 1803;
                public const int PwsCaution = 1804;
                public const int PwsWarningLanding = 1805;
                public const int PwsWarningTakeOff = 1806;
                public const int Plus100 = 1807;
                public const int Pullup = 1808;
                public const int SeatbeltAudio = 1809;
                public const int Sinkrate = 1810;
                public const int TcasClearOfConflict = 1811;
                public const int TcasClimb = 1812;
                public const int TcasCrossingClimb = 1813;
                public const int TcasCrossingDescend = 1814;
                public const int TcasDescend = 1815;
                public const int TcasTestOk = 1816;
                public const int TcasTraffic = 1817;
                public const int TakeoffConfig = 1818;
                public const int TerrainAhead = 1819;
                public const int TerrainAheadPullup = 1820;
                public const int TooLowFlap = 1821;
                public const int TooLowGear = 1822;
                public const int TooLowTerrain = 1823;
                public const int Windshear = 1824;
            }
        }

        public static class Mip
        {
            public static class Switch
            {
                public const int AsaAPResetCaptOff = 1825;
                public const int AsaAPResetCaptPushed = 1826;
                public const int AsaAPResetFOOff = 1827;
                public const int AsaAPResetFOPushed = 1828;
                public const int AsaATResetCaptOff = 1829;
                public const int AsaATResetCaptPushed = 1830;
                public const int AsaATResetFOOff = 1831;
                public const int AsaATResetFOPushed = 1832;
                public const int AsaFmcResetCaptOff = 1833;
                public const int AsaFmcResetCaptPushed = 1834;
                public const int AsaFmcResetFOOff = 1835;
                public const int AsaFmcResetFOPushed = 1836;
                public const int AsaTestCaptOff = 1837;
                public const int AsaTestCapt1 = 1838;
                public const int AsaTestCapt2 = 1839;
                public const int AsaTestFOOff = 1840;
                public const int AsaTestFO1 = 1841;
                public const int AsaTestFO2 = 1842;
                public const int AutolandFOPttNormal = 1843;
                public const int AutolandFOPttPushed = 1844;
                public const int AutolandPttNormal = 1845;
                public const int AutolandPttPushed = 1846;
                public const int CabinAltitudeIndicatorFOPttNormal = 1847;
                public const int CabinAltitudeIndicatorFOPttPushed = 1848;
                public const int CabinAltitudeIndicatorPttNormal = 1849;
                public const int CabinAltitudeIndicatorPttPushed = 1850;
                public const int CaptainInnerSelectorPulseDownOff = 1851;
                public const int CaptainInnerSelectorPulseDownOn = 1852;
                public const int CaptainInnerSelectorPulseUpOff = 1853;
                public const int CaptainInnerSelectorPulseUpOn = 1854;
                public const int CaptainOuterSelectorC = 1855;
                public const int CaptainOuterSelectorL = 1856;
                public const int CaptainSelectSwitchNormal = 1857;
                public const int CaptainSelectSwitchPushed = 1858;
                public const int ClockCaptainNormal = 1859;
                public const int ClockCaptainPushed = 1860;
                public const int ClockFONormal = 1861;
                public const int ClockFOPushed = 1862;
                public const int FOInnerSelectorPulseDownOff = 1863;
                public const int FOInnerSelectorPulseDownOn = 1864;
                public const int FOInnerSelectorPulseUpOff = 1865;
                public const int FOInnerSelectorPulseUpOn = 1866;
                public const int FOOuterSelectorC = 1867;
                public const int FOOuterSelectorR = 1868;
                public const int FOSelectSwitchNormal = 1869;
                public const int FOSelectSwitchPushed = 1870;
                public const int FlapInhibitNorm = 1871;
                public const int FlapInhibitInhibit = 1872;
                public const int FlapLoadReliefPttNormal = 1873;
                public const int FlapLoadReliefPttPushed = 1874;
                public const int FuelFlowRate = 1875;
                public const int FuelFlowUsed = 1876;
                public const int FuelFlowReset = 1877;
                public const int GpwsInopPttNormal = 1878;
                public const int GpwsInopPttPushed = 1879;
                public const int GpwsSysTestOff = 1880;
                public const int GpwsSysTestPushed = 1881;
                public const int GearHandleLockOverrideNormal = 1882;
                public const int GearHandleLockOverrideOverride = 1883;
                public const int GearInhibitNorm = 1884;
                public const int GearInhibitInhibit = 1885;
                public const int GlideslopePushToInhibitNormal = 1886;
                public const int GlideslopePushToInhibitPushed = 1887;
                public const int GlideslopePushToInhibitFONormal = 1888;
                public const int GlideslopePushToInhibitFOPushed = 1889;
                public const int IsfdPlusOff = 1890;
                public const int IsfdPlusPushed = 1891;
                public const int IsfdMinusOff = 1892;
                public const int IsfdMinusPushed = 1893;
                public const int IsfdAppOff = 1894;
                public const int IsfdAppPushed = 1895;
                public const int IsfdHpInOff = 1896;
                public const int IsfdHpInPushed = 1897;
                public const int IsfdRstOff = 1898;
                public const int IsfdRstPushed = 1899;
                public const int IsfdBaroStdOff = 1900;
                public const int IsfdBaroStdPushed = 1901;
                public const int IsfdBaroEncoderPulseDownOff = 1902;
                public const int IsfdBaroEncoderPulseDownOn = 1903;
                public const int IsfdBaroEncoderPulseUpOff = 1904;
                public const int IsfdBaroEncoderPulseUpOn = 1905;
                public const int LeFlapExtendPttNormal = 1906;
                public const int LeFlapExtendPttPushed = 1907;
                public const int LeFlapTransitPttNormal = 1908;
                public const int LeFlapTransitPttPushed = 1909;
                public const int MdsCaptNorm = 1910;
                public const int MdsCaptOutbd = 1911;
                public const int MdsCaptInbd = 1912;
                public const int MdsFONorm = 1913;
                public const int MdsFOOutbd = 1914;
                public const int MdsFOInbd = 1915;
                public const int MfdEngNormal = 1916;
                public const int MfdEngPushed = 1917;
                public const int MfdEngXfrNormal = 1918;
                public const int MfdEngXfrPushed = 1919;
                public const int MfdInfoNormal = 1920;
                public const int MfdInfoPushed = 1921;
                public const int MfdSysNormal = 1922;
                public const int MfdSysPushed = 1923;
                public const int RunwayInopPttNormal = 1924;
                public const int RunwayInopPttPushed = 1925;
                public const int RunwayInhibitNorm = 1926;
                public const int RunwayInhibitInhibit = 1927;
                public const int SpeedBrakeDoNotArmPttNormal = 1928;
                public const int SpeedBrakeDoNotArmPttPushed = 1929;
                public const int SpoilerArmedPttNormal = 1930;
                public const int SpoilerArmedPttPushed = 1931;
                public const int SpoilerExtendPttNormal = 1932;
                public const int SpoilerExtendPttPushed = 1933;
                public const int StabOutOfTrimPttNormal = 1934;
                public const int StabOutOfTrimPttPushed = 1935;
                public const int StandbyAttitudeModeApp = 1936;
                public const int StandbyAttitudeModeOff = 1937;
                public const int StandbyAttitudeModeBcrs = 1938;
                public const int StandbyRmiNav1ModeVor = 1939;
                public const int StandbyRmiNav1ModeAdf = 1940;
                public const int StandbyRmiNav1ModeFOVor = 1941;
                public const int StandbyRmiNav1ModeFOAdf = 1942;
                public const int StandbyRmiNav2ModeVor = 1943;
                public const int StandbyRmiNav2ModeAdf = 1944;
                public const int StandbyRmiNav2ModeFOVor = 1945;
                public const int StandbyRmiNav2ModeFOAdf = 1946;
                public const int StandbyAltimeterQnhMomentaryCenter = 1947;
                public const int StandbyAltimeterQnhMomentaryUp = 1948;
                public const int StandbyAltimeterQnhMomentaryDown = 1949;
                public const int StandbyAltimeterQnhMomentaryUpFast = 1950;
                public const int StandbyAltimeterQnhMomentaryDownFast = 1951;
                public const int StandbyAltimeterQnhPulseDownOff = 1952;
                public const int StandbyAltimeterQnhPulseDownOn = 1953;
                public const int StandbyAltimeterQnhPulseUpOff = 1954;
                public const int StandbyAltimeterQnhPulseUpOn = 1955;
                public const int TakeoffConfigFOPttNormal = 1956;
                public const int TakeoffConfigFOPttPushed = 1957;
                public const int TakeoffConfigPttNormal = 1958;
                public const int TakeoffConfigPttPushed = 1959;
                public const int TerrainInhibitNorm = 1960;
                public const int TerrainInhibitInhibit = 1961;
            }

            public static class Indicator
            {
                public const int AsaAPAmberCapt = 1962;
                public const int AsaAPAmberFO = 1963;
                public const int AsaAPRedCapt = 1964;
                public const int AsaAPRedFO = 1965;
                public const int AsaATAmberCapt = 1966;
                public const int AsaATAmberFO = 1967;
                public const int AsaATRedCapt = 1968;
                public const int AsaATRedFO = 1969;
                public const int AsaFmcCapt = 1970;
                public const int AsaFmcFO = 1971;
                public const int Autoland = 1972;
                public const int AutolandFO = 1973;
                public const int BelowGsCp = 1974;
                public const int BelowGsFO = 1975;
                public const int CabinAltitudeIndicator = 1976;
                public const int CabinAltitudeIndicatorFO = 1977;
                public const int FlapLoadRelief = 1978;
                public const int GpwsInop = 1979;
                public const int LeFlapExtend = 1980;
                public const int LeFlapTransit = 1981;
                public const int LowOilPressureLeft = 1982;
                public const int LowOilPressureRight = 1983;
                public const int RunwayInop = 1984;
                public const int SpeedBrakeDoNotArm = 1985;
                public const int SpoilerArmed = 1986;
                public const int SpoilerExtend = 1987;
                public const int StabOutOfTrim = 1988;
                public const int StartValveOpenLeft = 1989;
                public const int StartValveOpenRight = 1990;
                public const int TakeoffConfig = 1991;
                public const int TakeoffConfigFO = 1992;
            }

            public static class Gauge
            {
                public const int Flap = 1993;
                public const int FlapRight = 1994;
                public const int StandbyAttitudeBank = 1995;
                public const int StandbyAttitudePitch = 1996;
                public const int StandbyGlideslope = 1997;
                public const int StandbyLocaliser = 1998;
                public const int StandbyAltimeter = 1999;
                public const int StandbyBarberpole = 2000;
                public const int StandbySpeed = 2001;
                public const int WetCompass = 2002;
                public const int YawDamperGauge = 2003;
            }

            public static class Gate
            {
                public const int InnerMarker = 2004;
                public const int MiddleMarker = 2005;
                public const int OuterMarker = 2006;
            }

            public static class Numerical
            {
                public const int FlapNumerical = 2007;
                public const int FlapRightNumerical = 2008;
                public const int StandbyAttitudeBankNumerical = 2009;
                public const int StandbyAttitudePitchNumerical = 2010;
                public const int StandbyGlideslopeNumerical = 2011;
                public const int StandbyLocaliserNumerical = 2012;
                public const int StandbyAltimeterNumerical = 2013;
                public const int StandbyBarberpoleNumerical = 2014;
                public const int StandbySpeedNumerical = 2015;
                public const int WetCompassNumerical = 2016;
                public const int YawDamperGaugeNumerical = 2017;
            }

            public static class Analog
            {
                public const int CaptainInboardBrightness = 2018;
                public const int CaptainInboardWeatherRadarTerrainBrightness = 2019;
                public const int CaptainOutboardBrightness = 2020;
                public const int CaptainOutboardWeatherRadarTerrainBrightness = 2021;
                public const int FirstOfficerInboardBrightness = 2022;
                public const int FirstOfficerInboardWeatherRadarTerrainBrightness = 2023;
                public const int FirstOfficerOutboardBrightness = 2024;
                public const int FirstOfficerOutboardWeatherRadarTerrainBrightness = 2025;
            }

            public static class Encoder
            {
                public const int CaptainInnerSelector = 2026;
                public const int FOInnerSelector = 2027;
                public const int IsfdBaroEncoder = 2028;
                public const int StandbyAltimeterQnh = 2029;
            }
        }

        public static class ThrottleMcp
        {
            public static class Switch
            {
                public const int ApDisconnectYokeCaptNormal = 2030;
                public const int ApDisconnectYokeCaptPushed = 2031;
                public const int ApDisconnectYokeFONormal = 2032;
                public const int ApDisconnectYokeFOPushed = 2033;
                public const int AtDisengageOff = 2034;
                public const int AtDisengagePushed = 2035;
                public const int AtDisengage2ndSwitchOff = 2036;
                public const int AtDisengage2ndSwitchPushed = 2037;
                public const int Efis1ArptOff = 2038;
                public const int Efis1ArptPushed = 2039;
                public const int Efis1BaroStdOff = 2040;
                public const int Efis1BaroStdPushed = 2041;
                public const int Efis1BaroModeInch = 2042;
                public const int Efis1BaroModeHpa = 2043;
                public const int Efis1CtrOff = 2044;
                public const int Efis1CtrPushed = 2045;
                public const int Efis1DataOff = 2046;
                public const int Efis1DataPushed = 2047;
                public const int Efis1FpvOff = 2048;
                public const int Efis1FpvPushed = 2049;
                public const int Efis1MinsResetOff = 2050;
                public const int Efis1MinsResetPushed = 2051;
                public const int Efis1MtrsOff = 2052;
                public const int Efis1MtrsPushed = 2053;
                public const int Efis1MinimumsModeRadio = 2054;
                public const int Efis1MinimumsModeBaro = 2055;
                public const int Efis1ModeApp = 2056;
                public const int Efis1ModeVor = 2057;
                public const int Efis1ModeMap = 2058;
                public const int Efis1ModePln = 2059;
                public const int Efis1ModeEncoderPulseDownOff = 2060;
                public const int Efis1ModeEncoderPulseDownOn = 2061;
                public const int Efis1ModeEncoderPulseUpOff = 2062;
                public const int Efis1ModeEncoderPulseUpOn = 2063;
                public const int Efis1PosOff = 2064;
                public const int Efis1PosPushed = 2065;
                public const int Efis1RangePulseDownOff = 2066;
                public const int Efis1RangePulseDownOn = 2067;
                public const int Efis1RangePulseUpOff = 2068;
                public const int Efis1RangePulseUpOn = 2069;
                public const int Efis1StaOff = 2070;
                public const int Efis1StaPushed = 2071;
                public const int Efis1Selector1Off = 2072;
                public const int Efis1Selector1Vor1 = 2073;
                public const int Efis1Selector1Adf1 = 2074;
                public const int Efis1Selector2Off = 2075;
                public const int Efis1Selector2Vor2 = 2076;
                public const int Efis1Selector2Adf2 = 2077;
                public const int Efis1TerrOff = 2078;
                public const int Efis1TerrPushed = 2079;
                public const int Efis1TfcOff = 2080;
                public const int Efis1TfcPushed = 2081;
                public const int Efis1VsdOff = 2082;
                public const int Efis1VsdPushed = 2083;
                public const int Efis1WptOff = 2084;
                public const int Efis1WptPushed = 2085;
                public const int Efis1WxrOff = 2086;
                public const int Efis1WxrPushed = 2087;
                public const int Efis1BaroMomentaryCenter = 2088;
                public const int Efis1BaroMomentaryUp = 2089;
                public const int Efis1BaroMomentaryDown = 2090;
                public const int Efis1BaroMomentaryUpFast = 2091;
                public const int Efis1BaroMomentaryDownFast = 2092;
                public const int Efis1BaroPulseDownOff = 2093;
                public const int Efis1BaroPulseDownOn = 2094;
                public const int Efis1BaroPulseUpOff = 2095;
                public const int Efis1BaroPulseUpOn = 2096;
                public const int Efis1MinimumsMomentaryCenter = 2097;
                public const int Efis1MinimumsMomentaryUp = 2098;
                public const int Efis1MinimumsMomentaryDown = 2099;
                public const int Efis1MinimumsMomentaryUpFast = 2100;
                public const int Efis1MinimumsMomentaryDownFast = 2101;
                public const int Efis1MinimumsPulseDownOff = 2102;
                public const int Efis1MinimumsPulseDownOn = 2103;
                public const int Efis1MinimumsPulseUpOff = 2104;
                public const int Efis1MinimumsPulseUpOn = 2105;
                public const int Efis2ArptOff = 2106;
                public const int Efis2ArptPushed = 2107;
                public const int Efis2BaroStdOff = 2108;
                public const int Efis2BaroStdPushed = 2109;
                public const int Efis2BaroModeInch = 2110;
                public const int Efis2BaroModeHpa = 2111;
                public const int Efis2CtrOff = 2112;
                public const int Efis2CtrPushed = 2113;
                public const int Efis2DataOff = 2114;
                public const int Efis2DataPushed = 2115;
                public const int Efis2FpvOff = 2116;
                public const int Efis2FpvPushed = 2117;
                public const int Efis2MinsResetOff = 2118;
                public const int Efis2MinsResetPushed = 2119;
                public const int Efis2MtrsOff = 2120;
                public const int Efis2MtrsPushed = 2121;
                public const int Efis2MinimumsModeRadio = 2122;
                public const int Efis2MinimumsModeBaro = 2123;
                public const int Efis2ModeApp = 2124;
                public const int Efis2ModeVor = 2125;
                public const int Efis2ModeMap = 2126;
                public const int Efis2ModePln = 2127;
                public const int Efis2ModeEncoderPulseDownOff = 2128;
                public const int Efis2ModeEncoderPulseDownOn = 2129;
                public const int Efis2ModeEncoderPulseUpOff = 2130;
                public const int Efis2ModeEncoderPulseUpOn = 2131;
                public const int Efis2PosOff = 2132;
                public const int Efis2PosPushed = 2133;
                public const int Efis2RangePulseDownOff = 2134;
                public const int Efis2RangePulseDownOn = 2135;
                public const int Efis2RangePulseUpOff = 2136;
                public const int Efis2RangePulseUpOn = 2137;
                public const int Efis2StaOff = 2138;
                public const int Efis2StaPushed = 2139;
                public const int Efis2Selector1Off = 2140;
                public const int Efis2Selector1Vor1 = 2141;
                public const int Efis2Selector1Adf1 = 2142;
                public const int Efis2Selector2Off = 2143;
                public const int Efis2Selector2Vor2 = 2144;
                public const int Efis2Selector2Adf2 = 2145;
                public const int Efis2TerrOff = 2146;
                public const int Efis2TerrPushed = 2147;
                public const int Efis2TfcOff = 2148;
                public const int Efis2TfcPushed = 2149;
                public const int Efis2VsdOff = 2150;
                public const int Efis2VsdPushed = 2151;
                public const int Efis2WptOff = 2152;
                public const int Efis2WptPushed = 2153;
                public const int Efis2WxrOff = 2154;
                public const int Efis2WxrPushed = 2155;
                public const int Efis2BaroMomentaryCenter = 2156;
                public const int Efis2BaroMomentaryUp = 2157;
                public const int Efis2BaroMomentaryDown = 2158;
                public const int Efis2BaroMomentaryUpFast = 2159;
                public const int Efis2BaroMomentaryDownFast = 2160;
                public const int Efis2BaroPulseDownOff = 2161;
                public const int Efis2BaroPulseDownOn = 2162;
                public const int Efis2BaroPulseUpOff = 2163;
                public const int Efis2BaroPulseUpOn = 2164;
                public const int Efis2MinimumsMomentaryCenter = 2165;
                public const int Efis2MinimumsMomentaryUp = 2166;
                public const int Efis2MinimumsMomentaryDown = 2167;
                public const int Efis2MinimumsMomentaryUpFast = 2168;
                public const int Efis2MinimumsMomentaryDownFast = 2169;
                public const int Efis2MinimumsPulseDownOff = 2170;
                public const int Efis2MinimumsPulseDownOn = 2171;
                public const int Efis2MinimumsPulseUpOff = 2172;
                public const int Efis2MinimumsPulseUpOn = 2173;
                public const int FlapUp = 2174;
                public const int Flap1 = 2175;
                public const int Flap2 = 2176;
                public const int Flap5 = 2177;
                public const int Flap10 = 2178;
                public const int Flap15 = 2179;
                public const int Flap25 = 2180;
                public const int Flap30 = 2181;
                public const int Flap40 = 2182;
                public const int FlapPulseDownNormal = 2183;
                public const int FlapPulseDownPushed = 2184;
                public const int FlapPulseUpNormal = 2185;
                public const int FlapPulseUpPushed = 2186;
                public const int FuelCutoffLeftIdle = 2187;
                public const int FuelCutoffLeftCutoff = 2188;
                public const int FuelCutoffRightIdle = 2189;
                public const int FuelCutoffRightCutoff = 2190;
                public const int GearHornCutoutOff = 2191;
                public const int GearHornCutoutPushed = 2192;
                public const int McpAltValEncoderPulseDownOff = 2193;
                public const int McpAltValEncoderPulseDownOn = 2194;
                public const int McpAltValEncoderPulseUpOff = 2195;
                public const int McpAltValEncoderPulseUpOn = 2196;
                public const int McpApDisengageNormal = 2197;
                public const int McpApDisengageDisengage = 2198;
                public const int McpAppOff = 2199;
                public const int McpAppPushed = 2200;
                public const int McpAtArmOff = 2201;
                public const int McpAtArmArm = 2202;
                public const int McpAltIntOff = 2203;
                public const int McpAltIntPushed = 2204;
                public const int McpAltHoldOff = 2205;
                public const int McpAltHoldPushed = 2206;
                public const int McpBankLimit25 = 2207;
                public const int McpBankLimit30 = 2208;
                public const int McpBankLimit10 = 2209;
                public const int McpBankLimit15 = 2210;
                public const int McpBankLimit20 = 2211;
                public const int McpCOOff = 2212;
                public const int McpCOPushed = 2213;
                public const int McpCmdAOff = 2214;
                public const int McpCmdAPushed = 2215;
                public const int McpCmdBOff = 2216;
                public const int McpCmdBPushed = 2217;
                public const int McpCourse1ValEncoderPulseDownOff = 2218;
                public const int McpCourse1ValEncoderPulseDownOn = 2219;
                public const int McpCourse1ValEncoderPulseUpOff = 2220;
                public const int McpCourse1ValEncoderPulseUpOn = 2221;
                public const int McpCourse2ValEncoderPulseDownOff = 2222;
                public const int McpCourse2ValEncoderPulseDownOn = 2223;
                public const int McpCourse2ValEncoderPulseUpOff = 2224;
                public const int McpCourse2ValEncoderPulseUpOn = 2225;
                public const int McpCwsAOff = 2226;
                public const int McpCwsAPushed = 2227;
                public const int McpCwsBOff = 2228;
                public const int McpCwsBPushed = 2229;
                public const int McpCaptainFDOff = 2230;
                public const int McpCaptainFDOn = 2231;
                public const int McpFOFDOff = 2232;
                public const int McpFOFDOn = 2233;
                public const int McpHeadingValEncoderPulseDownOff = 2234;
                public const int McpHeadingValEncoderPulseDownOn = 2235;
                public const int McpHeadingValEncoderPulseUpOff = 2236;
                public const int McpHeadingValEncoderPulseUpOn = 2237;
                public const int McpHeadingBankSelOff = 2238;
                public const int McpHeadingBankSelPushed = 2239;
                public const int McpHeadingSelOff = 2240;
                public const int McpHeadingSelPushed = 2241;
                public const int McpLnavOff = 2242;
                public const int McpLnavPushed = 2243;
                public const int McpLevelChangeOff = 2244;
                public const int McpLevelChangePushed = 2245;
                public const int McpN1Off = 2246;
                public const int McpN1Pushed = 2247;
                public const int McpSpeedValEncoderPulseDownOff = 2248;
                public const int McpSpeedValEncoderPulseDownOn = 2249;
                public const int McpSpeedValEncoderPulseUpOff = 2250;
                public const int McpSpeedValEncoderPulseUpOn = 2251;
                public const int McpSpeedIntOff = 2252;
                public const int McpSpeedIntPushed = 2253;
                public const int McpSpeedHoldOff = 2254;
                public const int McpSpeedHoldPushed = 2255;
                public const int McpVSOff = 2256;
                public const int McpVSPushed = 2257;
                public const int McpVSValEncoderPulseDownOff = 2258;
                public const int McpVSValEncoderPulseDownOn = 2259;
                public const int McpVSValEncoderPulseUpOff = 2260;
                public const int McpVSValEncoderPulseUpOn = 2261;
                public const int McpVnavOff = 2262;
                public const int McpVnavPushed = 2263;
                public const int McpVorLocOff = 2264;
                public const int McpVorLocPushed = 2265;
                public const int ParkingBrakeOff = 2266;
                public const int ParkingBrakeOn = 2267;
                public const int StabTrimBackupNormal = 2268;
                public const int StabTrimBackupCutout = 2269;
                public const int StabTrimPrimaryNormal = 2270;
                public const int StabTrimPrimaryCutout = 2271;
                public const int TogaOff = 2272;
                public const int TogaPushed = 2273;
                public const int Toga2ndSwitchOff = 2274;
                public const int Toga2ndSwitchPushed = 2275;
                public const int ThrottleLeftReverserSwitchOff = 2276;
                public const int ThrottleLeftReverserSwitchReverse = 2277;
                public const int ThrottleRightReverserSwitchOff = 2278;
                public const int ThrottleRightReverserSwitchReverse = 2279;
                public const int TrimWheelPulseDownOff = 2280;
                public const int TrimWheelPulseDownOn = 2281;
                public const int TrimWheelPulseUpOff = 2282;
                public const int TrimWheelPulseUpOn = 2283;
            }

            public static class Indicator
            {
                public const int McpAT = 2284;
                public const int McpApp = 2285;
                public const int McpAltHold = 2286;
                public const int McpCmdA = 2287;
                public const int McpCmdB = 2288;
                public const int McpCwsA = 2289;
                public const int McpCwsB = 2290;
                public const int McpFccAMaster = 2291;
                public const int McpFccBMaster = 2292;
                public const int McpHdgSel = 2293;
                public const int McpLnav = 2294;
                public const int McpLevelChange = 2295;
                public const int McpN1 = 2296;
                public const int McpSpeed = 2297;
                public const int McpVS = 2298;
                public const int McpVnav = 2299;
                public const int McpVorLoc = 2300;
                public const int ParkingBrake = 2301;
            }

            public static class Gauge
            {
                public const int ElevatorTrimGauge = 2302;
                public const int ElevatorTrimGauge2 = 2303;
                public const int SpeedbrakeServo = 2304;
                public const int ThrottleServoLeft = 2305;
                public const int ThrottleServoRight = 2306;
            }

            public static class Gate
            {
                public const int ATDisconnectSolenoid = 2307;
                public const int ATHoldSolenoid = 2308;
                public const int AutopilotPitchCmd = 2309;
                public const int AutopilotPitchCws = 2310;
                public const int AutopilotRollCmd = 2311;
                public const int AutopilotRollCws = 2312;
                public const int FmaPitchModeAltAcq = 2313;
                public const int FmaPitchModeAltHold = 2314;
                public const int FmaPitchModeFlare = 2315;
                public const int FmaPitchModeGP = 2316;
                public const int FmaPitchModeGS = 2317;
                public const int FmaPitchModeMcpSpd = 2318;
                public const int FmaPitchModeToga = 2319;
                public const int FmaPitchModeVS = 2320;
                public const int FmaPitchModeVnavAlt = 2321;
                public const int FmaPitchModeVnavPath = 2322;
                public const int FmaPitchModeVnavSpd = 2323;
                public const int FmaRollModeHdgBackcourse = 2324;
                public const int FmaRollModeHdgFac = 2325;
                public const int FmaRollModeHdgLnav = 2326;
                public const int FmaRollModeHdgSel = 2327;
                public const int FmaRollModeHdgVorLog = 2328;
                public const int FmaThrustModeArm = 2329;
                public const int FmaThrustModeFmcSpd = 2330;
                public const int FmaThrustModeGa = 2331;
                public const int FmaThrustModeMcpSpd = 2332;
                public const int FmaThrustModeN1 = 2333;
                public const int FmaThrustModeRetard = 2334;
                public const int FmaThrustModeThrHld = 2335;
                public const int McpSpeedFlashingA = 2336;
                public const int McpSpeedFlashingB = 2337;
                public const int McpSpeedClosed = 2338;
                public const int ParkingBrakeHold = 2339;
                public const int ParkingBrakeRelease = 2340;
                public const int ParkingBrakeSwitchFree = 2341;
                public const int SpeedbrakeAutodeploy = 2342;
                public const int SpeedbrakeAutorestow = 2343;
                public const int ThrottleServoPowerLeft = 2344;
                public const int ThrottleServoPowerRight = 2345;
                public const int TrimMotorApHighSpeed = 2346;
                public const int TrimMotorApSlowSpeed = 2347;
                public const int TrimMotorManualHighSpeed = 2348;
                public const int TrimMotorManualSlowSpeed = 2349;
                public const int TrimMotorDown = 2350;
                public const int TrimMotorUp = 2351;
                public const int VsSpeedClosed = 2352;
            }

            public static class Numerical
            {
                public const int ElevatorTrimGauge2Numerical = 2353;
                public const int ElevatorTrimGaugeNumerical = 2354;
                public const int McpAltValOutput = 2355;
                public const int McpCourse1ValOutput = 2356;
                public const int McpCourse2ValOutput = 2357;
                public const int McpHeadingValOutput = 2358;
                public const int McpSpeedValOutput = 2359;
                public const int McpVSValOutput = 2360;
                public const int RemoteThrustHandleLeft = 2361;
                public const int RemoteThrustHandleRight = 2362;
                public const int SpeedbrakeServoNumerical = 2363;
                public const int ThrottleServoLeftNumerical = 2364;
                public const int ThrottleServoRightNumerical = 2365;
                public const int TrimMotorSpeed = 2366;
                public const int TrimMotorValue = 2367;
            }

            public static class Analog
            {
                public const int CombinedThrottleReverserInputLeft = 2368;
                public const int CombinedThrottleReverserInputRight = 2369;
                public const int FlapInput = 2370;
                public const int McpAltVal = 2371;
                public const int McpCourse1Val = 2372;
                public const int McpCourse2Val = 2373;
                public const int McpHeadingVal = 2374;
                public const int McpSpeedVal = 2375;
                public const int McpVSVal = 2376;
                public const int SpeedbrakeInput = 2377;
                public const int ThrottleInputLeft = 2378;
                public const int ThrottleInputRight = 2379;
                public const int ThrottleReverserInputLeft = 2380;
                public const int ThrottleReverserInputRight = 2381;
            }

            public static class Encoder
            {
                public const int Efis1ModeEncoder = 2382;
                public const int Efis1Range = 2383;
                public const int Efis1Baro = 2384;
                public const int Efis1Minimums = 2385;
                public const int Efis2ModeEncoder = 2386;
                public const int Efis2Range = 2387;
                public const int Efis2Baro = 2388;
                public const int Efis2Minimums = 2389;
                public const int McpAltValEncoder = 2390;
                public const int McpCourse1ValEncoder = 2391;
                public const int McpCourse2ValEncoder = 2392;
                public const int McpHeadingValEncoder = 2393;
                public const int McpSpeedValEncoder = 2394;
                public const int McpVSValEncoder = 2395;
                public const int TrimWheel = 2396;
            }
        }

        public static class FlightControls
        {
            public static class Switch
            {
                public const int AileronTrimCenter = 2397;
                public const int AileronTrimLeft = 2398;
                public const int AileronTrimRight = 2399;
                public const int ElevatorTrimCpt1Center = 2400;
                public const int ElevatorTrimCpt1Up = 2401;
                public const int ElevatorTrimCpt1Down = 2402;
                public const int ElevatorTrimCpt2Center = 2403;
                public const int ElevatorTrimCpt2Up = 2404;
                public const int ElevatorTrimCpt2Down = 2405;
                public const int ElevatorTrimFO1Center = 2406;
                public const int ElevatorTrimFO1Up = 2407;
                public const int ElevatorTrimFO1Down = 2408;
                public const int ElevatorTrimFO2Center = 2409;
                public const int ElevatorTrimFO2Up = 2410;
                public const int ElevatorTrimFO2Down = 2411;
                public const int LandingAssistArmed = 2412;
                public const int LandingAssistOn = 2413;
                public const int LandingAssistPttNormal = 2414;
                public const int LandingAssistPttPushed = 2415;
                public const int RudderTrimCenter = 2416;
                public const int RudderTrimLeft = 2417;
                public const int RudderTrimRight = 2418;
                public const int RudderTrimEncoderPulseDownOff = 2419;
                public const int RudderTrimEncoderPulseDownOn = 2420;
                public const int RudderTrimEncoderPulseUpOff = 2421;
                public const int RudderTrimEncoderPulseUpOn = 2422;
                public const int ToebrakeLeftFOSwitchInputOff = 2423;
                public const int ToebrakeLeftFOSwitchInputOn = 2424;
                public const int ToebrakeLeftCaptainSwitchInputOff = 2425;
                public const int ToebrakeLeftCaptainSwitchInputOn = 2426;
                public const int ToebrakeRightFOSwitchInputOff = 2427;
                public const int ToebrakeRightFOSwitchInputOn = 2428;
                public const int ToebrakeRightCaptainSwitchInputOff = 2429;
                public const int ToebrakeRightCaptainSwitchInputOn = 2430;
            }

            public static class Indicator
            {
                public const int AutoSlatFail = 2431;
                public const int LandingAssist = 2432;
                public const int SpeedTrimFail = 2433;
                public const int SpoilersFailure = 2434;
            }

            public static class Gauge
            {
                public const int RudderTrimGauge = 2435;
            }

            public static class Gate
            {
                public const int RudderTrimIndicatorOffFlag = 2436;
            }

            public static class Numerical
            {
                public const int RudderTrimGaugeNumerical = 2437;
            }

            public static class Analog
            {
                public const int AileronFOInput = 2438;
                public const int AileronTrimAnalogInput = 2439;
                public const int AileronCaptainInput = 2440;
                public const int ElevatorFOInput = 2441;
                public const int ElevatorCaptainInput = 2442;
                public const int ElevatorTrimAnalogInput = 2443;
                public const int RudderFOInput = 2444;
                public const int RudderTrimAnalogInput = 2445;
                public const int RudderCaptainInput = 2446;
                public const int TillerFOInput = 2447;
                public const int TillerCaptainInput = 2448;
                public const int ToebrakeLeftFOInput = 2449;
                public const int ToebrakeLeftCaptainInput = 2450;
                public const int ToebrakeRightFOInput = 2451;
                public const int ToebrakeRightCaptainInput = 2452;
            }

            public static class Encoder
            {
                public const int RudderTrimEncoder = 2453;
            }
        }

        public static class Communication
        {
            public static class Switch
            {
                public const int AspAdf1VolOff = 2454;
                public const int AspAdf1VolPushed = 2455;
                public const int AspAdf1VolLatchOff = 2456;
                public const int AspAdf1VolLatchOn = 2457;
                public const int AspAdf2VolOff = 2458;
                public const int AspAdf2VolPushed = 2459;
                public const int AspAdf2VolLatchOff = 2460;
                public const int AspAdf2VolLatchOn = 2461;
                public const int AspFltVolOff = 2462;
                public const int AspFltVolPushed = 2463;
                public const int AspFltVolLatchOff = 2464;
                public const int AspFltVolLatchOn = 2465;
                public const int AspFltVolSendNormal = 2466;
                public const int AspFltVolSendPushed = 2467;
                public const int AspFOAdf1VolOff = 2468;
                public const int AspFOAdf1VolPushed = 2469;
                public const int AspFOAdf1VolLatchOff = 2470;
                public const int AspFOAdf1VolLatchOn = 2471;
                public const int AspFOAdf2VolOff = 2472;
                public const int AspFOAdf2VolPushed = 2473;
                public const int AspFOAdf2VolLatchOff = 2474;
                public const int AspFOAdf2VolLatchOn = 2475;
                public const int AspFOFltVolOff = 2476;
                public const int AspFOFltVolPushed = 2477;
                public const int AspFOFltVolLatchOff = 2478;
                public const int AspFOFltVolLatchOn = 2479;
                public const int AspFOFltVolSendNormal = 2480;
                public const int AspFOFltVolSendPushed = 2481;
                public const int AspFOHf1Off = 2482;
                public const int AspFOHf1Pushed = 2483;
                public const int AspFOHf1LatchOff = 2484;
                public const int AspFOHf1LatchOn = 2485;
                public const int AspFOHf1SendNormal = 2486;
                public const int AspFOHf1SendPushed = 2487;
                public const int AspFOHf2Off = 2488;
                public const int AspFOHf2Pushed = 2489;
                public const int AspFOHf2LatchOff = 2490;
                public const int AspFOHf2LatchOn = 2491;
                public const int AspFOHf2SendNormal = 2492;
                public const int AspFOHf2SendPushed = 2493;
                public const int AspFOMarkerVolOff = 2494;
                public const int AspFOMarkerVolPushed = 2495;
                public const int AspFOMarkerVolLatchOff = 2496;
                public const int AspFOMarkerVolLatchOn = 2497;
                public const int AspFONav1VolOff = 2498;
                public const int AspFONav1VolPushed = 2499;
                public const int AspFONav1VolLatchOff = 2500;
                public const int AspFONav1VolLatchOn = 2501;
                public const int AspFONav2VolOff = 2502;
                public const int AspFONav2VolPushed = 2503;
                public const int AspFONav2VolLatchOff = 2504;
                public const int AspFONav2VolLatchOn = 2505;
                public const int AspFOPaVolOff = 2506;
                public const int AspFOPaVolPushed = 2507;
                public const int AspFOPaVolLatchOff = 2508;
                public const int AspFOPaVolLatchOn = 2509;
                public const int AspFOPaVolSendNormal = 2510;
                public const int AspFOPaVolSendPushed = 2511;
                public const int AspFOSvcVolOff = 2512;
                public const int AspFOSvcVolPushed = 2513;
                public const int AspFOSvcVolLatchOff = 2514;
                public const int AspFOSvcVolLatchOn = 2515;
                public const int AspFOSvcVolSendNormal = 2516;
                public const int AspFOSvcVolSendPushed = 2517;
                public const int AspFOSpkrVolOff = 2518;
                public const int AspFOSpkrVolPushed = 2519;
                public const int AspFOSpkrVolLatchOff = 2520;
                public const int AspFOSpkrVolLatchOn = 2521;
                public const int AspFOVhf1VolOff = 2522;
                public const int AspFOVhf1VolPushed = 2523;
                public const int AspFOVhf1VolLatchOff = 2524;
                public const int AspFOVhf1VolLatchOn = 2525;
                public const int AspFOVhf1VolSendNormal = 2526;
                public const int AspFOVhf1VolSendPushed = 2527;
                public const int AspFOVhf2VolOff = 2528;
                public const int AspFOVhf2VolPushed = 2529;
                public const int AspFOVhf2VolLatchOff = 2530;
                public const int AspFOVhf2VolLatchOn = 2531;
                public const int AspFOVhf2VolSendNormal = 2532;
                public const int AspFOVhf2VolSendPushed = 2533;
                public const int AspFOVhf3VolOff = 2534;
                public const int AspFOVhf3VolPushed = 2535;
                public const int AspFOVhf3VolLatchOff = 2536;
                public const int AspFOVhf3VolLatchOn = 2537;
                public const int AspFOVhf3VolSendNormal = 2538;
                public const int AspFOVhf3VolSendPushed = 2539;
                public const int AspHf1Off = 2540;
                public const int AspHf1Pushed = 2541;
                public const int AspHf1LatchOff = 2542;
                public const int AspHf1LatchOn = 2543;
                public const int AspHf1SendNormal = 2544;
                public const int AspHf1SendPushed = 2545;
                public const int AspHf2Off = 2546;
                public const int AspHf2Pushed = 2547;
                public const int AspHf2LatchOff = 2548;
                public const int AspHf2LatchOn = 2549;
                public const int AspHf2SendNormal = 2550;
                public const int AspHf2SendPushed = 2551;
                public const int AspMarkerVolOff = 2552;
                public const int AspMarkerVolPushed = 2553;
                public const int AspMarkerVolLatchOff = 2554;
                public const int AspMarkerVolLatchOn = 2555;
                public const int AspNav1VolOff = 2556;
                public const int AspNav1VolPushed = 2557;
                public const int AspNav1VolLatchOff = 2558;
                public const int AspNav1VolLatchOn = 2559;
                public const int AspNav2VolOff = 2560;
                public const int AspNav2VolPushed = 2561;
                public const int AspNav2VolLatchOff = 2562;
                public const int AspNav2VolLatchOn = 2563;
                public const int AspObsAdf1VolOff = 2564;
                public const int AspObsAdf1VolPushed = 2565;
                public const int AspObsAdf1VolLatchOff = 2566;
                public const int AspObsAdf1VolLatchOn = 2567;
                public const int AspObsAdf2VolOff = 2568;
                public const int AspObsAdf2VolPushed = 2569;
                public const int AspObsAdf2VolLatchOff = 2570;
                public const int AspObsAdf2VolLatchOn = 2571;
                public const int AspObsFltVolOff = 2572;
                public const int AspObsFltVolPushed = 2573;
                public const int AspObsFltVolLatchOff = 2574;
                public const int AspObsFltVolLatchOn = 2575;
                public const int AspObsFltVolSendNormal = 2576;
                public const int AspObsFltVolSendPushed = 2577;
                public const int AspObsHf1Off = 2578;
                public const int AspObsHf1Pushed = 2579;
                public const int AspObsHf1LatchOff = 2580;
                public const int AspObsHf1LatchOn = 2581;
                public const int AspObsHf1SendNormal = 2582;
                public const int AspObsHf1SendPushed = 2583;
                public const int AspObsHf2Off = 2584;
                public const int AspObsHf2Pushed = 2585;
                public const int AspObsHf2LatchOff = 2586;
                public const int AspObsHf2LatchOn = 2587;
                public const int AspObsHf2SendNormal = 2588;
                public const int AspObsHf2SendPushed = 2589;
                public const int AspObsMarkerVolOff = 2590;
                public const int AspObsMarkerVolPushed = 2591;
                public const int AspObsMarkerVolLatchOff = 2592;
                public const int AspObsMarkerVolLatchOn = 2593;
                public const int AspObsNav1VolOff = 2594;
                public const int AspObsNav1VolPushed = 2595;
                public const int AspObsNav1VolLatchOff = 2596;
                public const int AspObsNav1VolLatchOn = 2597;
                public const int AspObsNav2VolOff = 2598;
                public const int AspObsNav2VolPushed = 2599;
                public const int AspObsNav2VolLatchOff = 2600;
                public const int AspObsNav2VolLatchOn = 2601;
                public const int AspObsPaVolOff = 2602;
                public const int AspObsPaVolPushed = 2603;
                public const int AspObsPaVolLatchOff = 2604;
                public const int AspObsPaVolLatchOn = 2605;
                public const int AspObsPaVolSendNormal = 2606;
                public const int AspObsPaVolSendPushed = 2607;
                public const int AspObsSvcVolOff = 2608;
                public const int AspObsSvcVolPushed = 2609;
                public const int AspObsSvcVolLatchOff = 2610;
                public const int AspObsSvcVolLatchOn = 2611;
                public const int AspObsSvcVolSendNormal = 2612;
                public const int AspObsSvcVolSendPushed = 2613;
                public const int AspObsSpkrVolOff = 2614;
                public const int AspObsSpkrVolPushed = 2615;
                public const int AspObsSpkrVolLatchOff = 2616;
                public const int AspObsSpkrVolLatchOn = 2617;
                public const int AspObsVhf1VolOff = 2618;
                public const int AspObsVhf1VolPushed = 2619;
                public const int AspObsVhf1VolLatchOff = 2620;
                public const int AspObsVhf1VolLatchOn = 2621;
                public const int AspObsVhf1VolSendNormal = 2622;
                public const int AspObsVhf1VolSendPushed = 2623;
                public const int AspObsVhf2VolOff = 2624;
                public const int AspObsVhf2VolPushed = 2625;
                public const int AspObsVhf2VolLatchOff = 2626;
                public const int AspObsVhf2VolLatchOn = 2627;
                public const int AspObsVhf2VolSendNormal = 2628;
                public const int AspObsVhf2VolSendPushed = 2629;
                public const int AspObsVhf3VolOff = 2630;
                public const int AspObsVhf3VolPushed = 2631;
                public const int AspObsVhf3VolLatchOff = 2632;
                public const int AspObsVhf3VolLatchOn = 2633;
                public const int AspObsVhf3VolSendNormal = 2634;
                public const int AspObsVhf3VolSendPushed = 2635;
                public const int AspPaVolOff = 2636;
                public const int AspPaVolPushed = 2637;
                public const int AspPaVolLatchOff = 2638;
                public const int AspPaVolLatchOn = 2639;
                public const int AspPaVolSendNormal = 2640;
                public const int AspPaVolSendPushed = 2641;
                public const int AspSvcVolOff = 2642;
                public const int AspSvcVolPushed = 2643;
                public const int AspSvcVolLatchOff = 2644;
                public const int AspSvcVolLatchOn = 2645;
                public const int AspSvcVolSendNormal = 2646;
                public const int AspSvcVolSendPushed = 2647;
                public const int AspSpkrVolOff = 2648;
                public const int AspSpkrVolPushed = 2649;
                public const int AspSpkrVolLatchOff = 2650;
                public const int AspSpkrVolLatchOn = 2651;
                public const int AspVhf1VolOff = 2652;
                public const int AspVhf1VolPushed = 2653;
                public const int AspVhf1VolLatchOff = 2654;
                public const int AspVhf1VolLatchOn = 2655;
                public const int AspVhf1VolSendNormal = 2656;
                public const int AspVhf1VolSendPushed = 2657;
                public const int AspVhf2VolOff = 2658;
                public const int AspVhf2VolPushed = 2659;
                public const int AspVhf2VolLatchOff = 2660;
                public const int AspVhf2VolLatchOn = 2661;
                public const int AspVhf2VolSendNormal = 2662;
                public const int AspVhf2VolSendPushed = 2663;
                public const int AspVhf3VolOff = 2664;
                public const int AspVhf3VolPushed = 2665;
                public const int AspVhf3VolLatchOff = 2666;
                public const int AspVhf3VolLatchOn = 2667;
                public const int AspVhf3VolSendNormal = 2668;
                public const int AspVhf3VolSendPushed = 2669;
                public const int Atc0Normal = 2670;
                public const int Atc0Pushed = 2671;
                public const int Atc1Normal = 2672;
                public const int Atc1Pushed = 2673;
                public const int Atc2Normal = 2674;
                public const int Atc2Pushed = 2675;
                public const int Atc3Normal = 2676;
                public const int Atc3Pushed = 2677;
                public const int Atc4Normal = 2678;
                public const int Atc4Pushed = 2679;
                public const int Atc5Normal = 2680;
                public const int Atc5Pushed = 2681;
                public const int Atc6Normal = 2682;
                public const int Atc6Pushed = 2683;
                public const int Atc7Normal = 2684;
                public const int Atc7Pushed = 2685;
                public const int AtcClrNormal = 2686;
                public const int AtcClrPushed = 2687;
                public const int ExternalPowerReceptaclePilotCallSwitchNormal = 2688;
                public const int ExternalPowerReceptaclePilotCallSwitchPushed = 2689;
                public const int FlightAttendantPanelPilotCallSwitchNormal = 2690;
                public const int FlightAttendantPanelPilotCallSwitchPushed = 2691;
                public const int HandMicPttFONormal = 2692;
                public const int HandMicPttFOPushed = 2693;
                public const int HandMicPttCaptainNormal = 2694;
                public const int HandMicPttCaptainPushed = 2695;
                public const int HandMicPttObserverNormal = 2696;
                public const int HandMicPttObserverPushed = 2697;
                public const int RmpCaptAdfNormal = 2698;
                public const int RmpCaptAdfPushed = 2699;
                public const int RmpCaptAmNormal = 2700;
                public const int RmpCaptAmPushed = 2701;
                public const int RmpCaptHf1Normal = 2702;
                public const int RmpCaptHf1Pushed = 2703;
                public const int RmpCaptHf2Normal = 2704;
                public const int RmpCaptHf2Pushed = 2705;
                public const int RmpCaptNav1Normal = 2706;
                public const int RmpCaptNav1Pushed = 2707;
                public const int RmpCaptNav2Normal = 2708;
                public const int RmpCaptNav2Pushed = 2709;
                public const int RmpCaptVhfTestNormal = 2710;
                public const int RmpCaptVhfTestPushed = 2711;
                public const int RmpCaptVhf1Normal = 2712;
                public const int RmpCaptVhf1Pushed = 2713;
                public const int RmpCaptVhf2Normal = 2714;
                public const int RmpCaptVhf2Pushed = 2715;
                public const int RmpCaptVhf3Normal = 2716;
                public const int RmpCaptVhf3Pushed = 2717;
                public const int RmpCaptInnerEncoderPulseDownOff = 2718;
                public const int RmpCaptInnerEncoderPulseDownOn = 2719;
                public const int RmpCaptInnerEncoderPulseUpOff = 2720;
                public const int RmpCaptInnerEncoderPulseUpOn = 2721;
                public const int RmpCaptOuterEncoderPulseDownOff = 2722;
                public const int RmpCaptOuterEncoderPulseDownOn = 2723;
                public const int RmpCaptOuterEncoderPulseUpOff = 2724;
                public const int RmpCaptOuterEncoderPulseUpOn = 2725;
                public const int RmpCaptPanelOffNormal = 2726;
                public const int RmpCaptPanelOffPushed = 2727;
                public const int RmpCaptSenseEncoderPulseDownOff = 2728;
                public const int RmpCaptSenseEncoderPulseDownOn = 2729;
                public const int RmpCaptSenseEncoderPulseUpOff = 2730;
                public const int RmpCaptSenseEncoderPulseUpOn = 2731;
                public const int RmpCaptTransferNormal = 2732;
                public const int RmpCaptTransferPushed = 2733;
                public const int RmpFOAdfNormal = 2734;
                public const int RmpFOAdfPushed = 2735;
                public const int RmpFOAmNormal = 2736;
                public const int RmpFOAmPushed = 2737;
                public const int RmpFOHf1Normal = 2738;
                public const int RmpFOHf1Pushed = 2739;
                public const int RmpFOHf2Normal = 2740;
                public const int RmpFOHf2Pushed = 2741;
                public const int RmpFONav1Normal = 2742;
                public const int RmpFONav1Pushed = 2743;
                public const int RmpFONav2Normal = 2744;
                public const int RmpFONav2Pushed = 2745;
                public const int RmpFOVhfTestNormal = 2746;
                public const int RmpFOVhfTestPushed = 2747;
                public const int RmpFOVhf1Normal = 2748;
                public const int RmpFOVhf1Pushed = 2749;
                public const int RmpFOVhf2Normal = 2750;
                public const int RmpFOVhf2Pushed = 2751;
                public const int RmpFOVhf3Normal = 2752;
                public const int RmpFOVhf3Pushed = 2753;
                public const int RmpFOInnerEncoderPulseDownOff = 2754;
                public const int RmpFOInnerEncoderPulseDownOn = 2755;
                public const int RmpFOInnerEncoderPulseUpOff = 2756;
                public const int RmpFOInnerEncoderPulseUpOn = 2757;
                public const int RmpFOOuterEncoderPulseDownOff = 2758;
                public const int RmpFOOuterEncoderPulseDownOn = 2759;
                public const int RmpFOOuterEncoderPulseUpOff = 2760;
                public const int RmpFOOuterEncoderPulseUpOn = 2761;
                public const int RmpFOPanelOffNormal = 2762;
                public const int RmpFOPanelOffPushed = 2763;
                public const int RmpFOSenseEncoderPulseDownOff = 2764;
                public const int RmpFOSenseEncoderPulseDownOn = 2765;
                public const int RmpFOSenseEncoderPulseUpOff = 2766;
                public const int RmpFOSenseEncoderPulseUpOn = 2767;
                public const int RmpFOTransferNormal = 2768;
                public const int RmpFOTransferPushed = 2769;
                public const int RmpObsAdfNormal = 2770;
                public const int RmpObsAdfPushed = 2771;
                public const int RmpObsAmNormal = 2772;
                public const int RmpObsAmPushed = 2773;
                public const int RmpObsHf1Normal = 2774;
                public const int RmpObsHf1Pushed = 2775;
                public const int RmpObsHf2Normal = 2776;
                public const int RmpObsHf2Pushed = 2777;
                public const int RmpObsNav1Normal = 2778;
                public const int RmpObsNav1Pushed = 2779;
                public const int RmpObsNav2Normal = 2780;
                public const int RmpObsNav2Pushed = 2781;
                public const int RmpObsVhfTestNormal = 2782;
                public const int RmpObsVhfTestPushed = 2783;
                public const int RmpObsVhf1Normal = 2784;
                public const int RmpObsVhf1Pushed = 2785;
                public const int RmpObsVhf2Normal = 2786;
                public const int RmpObsVhf2Pushed = 2787;
                public const int RmpObsVhf3Normal = 2788;
                public const int RmpObsVhf3Pushed = 2789;
                public const int RmpObsInnerEncoderPulseDownOff = 2790;
                public const int RmpObsInnerEncoderPulseDownOn = 2791;
                public const int RmpObsInnerEncoderPulseUpOff = 2792;
                public const int RmpObsInnerEncoderPulseUpOn = 2793;
                public const int RmpObsOuterEncoderPulseDownOff = 2794;
                public const int RmpObsOuterEncoderPulseDownOn = 2795;
                public const int RmpObsOuterEncoderPulseUpOff = 2796;
                public const int RmpObsOuterEncoderPulseUpOn = 2797;
                public const int RmpObsPanelOffNormal = 2798;
                public const int RmpObsPanelOffPushed = 2799;
                public const int RmpObsSenseEncoderPulseDownOff = 2800;
                public const int RmpObsSenseEncoderPulseDownOn = 2801;
                public const int RmpObsSenseEncoderPulseUpOff = 2802;
                public const int RmpObsSenseEncoderPulseUpOn = 2803;
                public const int RmpObsTransferNormal = 2804;
                public const int RmpObsTransferPushed = 2805;
                public const int SelcalHf1SwitchNormal = 2806;
                public const int SelcalHf1SwitchPushed = 2807;
                public const int SelcalHf2SwitchNormal = 2808;
                public const int SelcalHf2SwitchPushed = 2809;
                public const int SelcalVhf1SwitchNormal = 2810;
                public const int SelcalVhf1SwitchPushed = 2811;
                public const int SelcalVhf2SwitchNormal = 2812;
                public const int SelcalVhf2SwitchPushed = 2813;
                public const int SelcalVhf3SwitchNormal = 2814;
                public const int SelcalVhf3SwitchPushed = 2815;
                public const int YokePttIcFONormal = 2816;
                public const int YokePttIcFOPushed = 2817;
                public const int YokePttIcCaptainNormal = 2818;
                public const int YokePttIcCaptainPushed = 2819;
                public const int YokePttRtFONormal = 2820;
                public const int YokePttRtFOPushed = 2821;
                public const int YokePttRtCaptainNormal = 2822;
                public const int YokePttRtCaptainPushed = 2823;
            }

            public static class Indicator
            {
                public const int AspAdf1Vol = 2824;
                public const int AspAdf2Vol = 2825;
                public const int AspFltVol = 2826;
                public const int AspFltVolCall = 2827;
                public const int AspFltVolSendBar = 2828;
                public const int AspFOAdf1Vol = 2829;
                public const int AspFOAdf2Vol = 2830;
                public const int AspFOFltVol = 2831;
                public const int AspFOFltVolCall = 2832;
                public const int AspFOFltVolSendBar = 2833;
                public const int AspFOHf1 = 2834;
                public const int AspFOHf1Call = 2835;
                public const int AspFOHf1SendBar = 2836;
                public const int AspFOHf2 = 2837;
                public const int AspFOHf2Call = 2838;
                public const int AspFOHf2SendBar = 2839;
                public const int AspFOMarkerVol = 2840;
                public const int AspFONav1Vol = 2841;
                public const int AspFONav2Vol = 2842;
                public const int AspFOPaVol = 2843;
                public const int AspFOPaVolSendBar = 2844;
                public const int AspFOSvcVol = 2845;
                public const int AspFOSvcVolCall = 2846;
                public const int AspFOSvcVolSendBar = 2847;
                public const int AspFOSpkrVol = 2848;
                public const int AspFOVhf1Vol = 2849;
                public const int AspFOVhf1VolCall = 2850;
                public const int AspFOVhf1VolSendBar = 2851;
                public const int AspFOVhf2Vol = 2852;
                public const int AspFOVhf2VolCall = 2853;
                public const int AspFOVhf2VolSendBar = 2854;
                public const int AspFOVhf3Vol = 2855;
                public const int AspFOVhf3VolCall = 2856;
                public const int AspFOVhf3VolSendBar = 2857;
                public const int AspHf1 = 2858;
                public const int AspHf1Call = 2859;
                public const int AspHf1SendBar = 2860;
                public const int AspHf2 = 2861;
                public const int AspHf2Call = 2862;
                public const int AspHf2SendBar = 2863;
                public const int AspMarkerVol = 2864;
                public const int AspNav1Vol = 2865;
                public const int AspNav2Vol = 2866;
                public const int AspObsAdf1Vol = 2867;
                public const int AspObsAdf2Vol = 2868;
                public const int AspObsFltVol = 2869;
                public const int AspObsFltVolCall = 2870;
                public const int AspObsFltVolSendBar = 2871;
                public const int AspObsHf1 = 2872;
                public const int AspObsHf1Call = 2873;
                public const int AspObsHf1SendBar = 2874;
                public const int AspObsHf2 = 2875;
                public const int AspObsHf2Call = 2876;
                public const int AspObsHf2SendBar = 2877;
                public const int AspObsMarkerVol = 2878;
                public const int AspObsNav1Vol = 2879;
                public const int AspObsNav2Vol = 2880;
                public const int AspObsPaVol = 2881;
                public const int AspObsPaVolSendBar = 2882;
                public const int AspObsSvcVol = 2883;
                public const int AspObsSvcVolCall = 2884;
                public const int AspObsSvcVolSendBar = 2885;
                public const int AspObsSpkrVol = 2886;
                public const int AspObsVhf1Vol = 2887;
                public const int AspObsVhf1VolCall = 2888;
                public const int AspObsVhf1VolSendBar = 2889;
                public const int AspObsVhf2Vol = 2890;
                public const int AspObsVhf2VolCall = 2891;
                public const int AspObsVhf2VolSendBar = 2892;
                public const int AspObsVhf3Vol = 2893;
                public const int AspObsVhf3VolCall = 2894;
                public const int AspObsVhf3VolSendBar = 2895;
                public const int AspPaVol = 2896;
                public const int AspPaVolSendBar = 2897;
                public const int AspSvcVol = 2898;
                public const int AspSvcVolCall = 2899;
                public const int AspSvcVolSendBar = 2900;
                public const int AspSpkrVol = 2901;
                public const int AspVhf1Vol = 2902;
                public const int AspVhf1VolCall = 2903;
                public const int AspVhf1VolSendBar = 2904;
                public const int AspVhf2Vol = 2905;
                public const int AspVhf2VolCall = 2906;
                public const int AspVhf2VolSendBar = 2907;
                public const int AspVhf3Vol = 2908;
                public const int AspVhf3VolCall = 2909;
                public const int AspVhf3VolSendBar = 2910;
                public const int Call = 2911;
                public const int Hf1AmModulation = 2912;
                public const int Hf2AmModulation = 2913;
                public const int RmpCaptAdfIndicator = 2914;
                public const int RmpCaptAm = 2915;
                public const int RmpCaptHf1Indicator = 2916;
                public const int RmpCaptHf2Indicator = 2917;
                public const int RmpCaptNav1Indicator = 2918;
                public const int RmpCaptNav2Indicator = 2919;
                public const int RmpCaptVhf1Indicator = 2920;
                public const int RmpCaptVhf2Indicator = 2921;
                public const int RmpCaptVhf3Indicator = 2922;
                public const int RmpCaptOffsideTuning = 2923;
                public const int RmpFOAdfIndicator = 2924;
                public const int RmpFOAm = 2925;
                public const int RmpFOHf1Indicator = 2926;
                public const int RmpFOHf2Indicator = 2927;
                public const int RmpFONav1Indicator = 2928;
                public const int RmpFONav2Indicator = 2929;
                public const int RmpFOVhf1Indicator = 2930;
                public const int RmpFOVhf2Indicator = 2931;
                public const int RmpFOVhf3Indicator = 2932;
                public const int RmpFOOffsideTuning = 2933;
                public const int RmpObsAdfIndicator = 2934;
                public const int RmpObsAm = 2935;
                public const int RmpObsHf1Indicator = 2936;
                public const int RmpObsHf2Indicator = 2937;
                public const int RmpObsNav1Indicator = 2938;
                public const int RmpObsNav2Indicator = 2939;
                public const int RmpObsVhf1Indicator = 2940;
                public const int RmpObsVhf2Indicator = 2941;
                public const int RmpObsVhf3Indicator = 2942;
                public const int RmpObsOffsideTuning = 2943;
                public const int SelcalHf1Indicator = 2944;
                public const int SelcalHf2Indicator = 2945;
                public const int SelcalVhf1Indicator = 2946;
                public const int SelcalVhf2Indicator = 2947;
                public const int SelcalVhf3Indicator = 2948;
            }

            public static class Gate
            {
                public const int CrossMute = 2949;
            }

            public static class Numerical
            {
                public const int RmpCaptActiveMode = 2950;
                public const int RmpCaptActiveValue = 2951;
                public const int RmpCaptStandbyMode = 2952;
                public const int RmpCaptStandbyValue = 2953;
                public const int RmpFOActiveMode = 2954;
                public const int RmpFOActiveValue = 2955;
                public const int RmpFOStandbyMode = 2956;
                public const int RmpFOStandbyValue = 2957;
                public const int RmpObsActiveMode = 2958;
                public const int RmpObsActiveValue = 2959;
                public const int RmpObsStandbyMode = 2960;
                public const int RmpObsStandbyValue = 2961;
            }

            public static class Analog
            {
                public const int AspAdf1VolVolume = 2962;
                public const int AspAdf2VolVolume = 2963;
                public const int AspFltVolVolume = 2964;
                public const int AspFOAdf1VolVolume = 2965;
                public const int AspFOAdf2VolVolume = 2966;
                public const int AspFOFltVolVolume = 2967;
                public const int AspFOHf1Volume = 2968;
                public const int AspFOHf2Volume = 2969;
                public const int AspFOMarkerVolVolume = 2970;
                public const int AspFONav1VolVolume = 2971;
                public const int AspFONav2VolVolume = 2972;
                public const int AspFOPaVolVolume = 2973;
                public const int AspFOSvcVolVolume = 2974;
                public const int AspFOSpkrVolVolume = 2975;
                public const int AspFOVhf1VolVolume = 2976;
                public const int AspFOVhf2VolVolume = 2977;
                public const int AspFOVhf3VolVolume = 2978;
                public const int AspHf1Volume = 2979;
                public const int AspHf2Volume = 2980;
                public const int AspMarkerVolVolume = 2981;
                public const int AspNav1VolVolume = 2982;
                public const int AspNav2VolVolume = 2983;
                public const int AspObsAdf1VolVolume = 2984;
                public const int AspObsAdf2VolVolume = 2985;
                public const int AspObsFltVolVolume = 2986;
                public const int AspObsHf1Volume = 2987;
                public const int AspObsHf2Volume = 2988;
                public const int AspObsMarkerVolVolume = 2989;
                public const int AspObsNav1VolVolume = 2990;
                public const int AspObsNav2VolVolume = 2991;
                public const int AspObsPaVolVolume = 2992;
                public const int AspObsSvcVolVolume = 2993;
                public const int AspObsSpkrVolVolume = 2994;
                public const int AspObsVhf1VolVolume = 2995;
                public const int AspObsVhf2VolVolume = 2996;
                public const int AspObsVhf3VolVolume = 2997;
                public const int AspPaVolVolume = 2998;
                public const int AspSvcVolVolume = 2999;
                public const int AspSpkrVolVolume = 3000;
                public const int AspVhf1VolVolume = 3001;
                public const int AspVhf2VolVolume = 3002;
                public const int AspVhf3VolVolume = 3003;
                public const int RmpCaptSense = 3004;
                public const int RmpFOSense = 3005;
                public const int RmpObsSense = 3006;
            }

            public static class Encoder
            {
                public const int RmpCaptInnerEncoder = 3007;
                public const int RmpCaptOuterEncoder = 3008;
                public const int RmpCaptSenseEncoder = 3009;
                public const int RmpFOInnerEncoder = 3010;
                public const int RmpFOOuterEncoder = 3011;
                public const int RmpFOSenseEncoder = 3012;
                public const int RmpObsInnerEncoder = 3013;
                public const int RmpObsOuterEncoder = 3014;
                public const int RmpObsSenseEncoder = 3015;
            }
        }

        public static class LandingGear
        {
            public static class Switch
            {
                public const int AntiSkidInopPttNormal = 3016;
                public const int AntiSkidInopPttPushed = 3017;
                public const int AutobrakeOff = 3018;
                public const int AutobrakeRto = 3019;
                public const int Autobrake1 = 3020;
                public const int Autobrake2 = 3021;
                public const int Autobrake3 = 3022;
                public const int AutobrakeMax = 3023;
                public const int AutobrakeDisarmPttNormal = 3024;
                public const int AutobrakeDisarmPttPushed = 3025;
                public const int BrakeInputOff = 3026;
                public const int BrakeInputOn = 3027;
                public const int BrakeTempPttNormal = 3028;
                public const int BrakeTempPttPushed = 3029;
                public const int GearDown = 3030;
                public const int GearUp = 3031;
                public const int GearLeftPttNormal = 3032;
                public const int GearLeftPttPushed = 3033;
                public const int GearLeftTransitPttNormal = 3034;
                public const int GearLeftTransitPttPushed = 3035;
                public const int GearNosePttNormal = 3036;
                public const int GearNosePttPushed = 3037;
                public const int GearNoseTransitPttNormal = 3038;
                public const int GearNoseTransitPttPushed = 3039;
                public const int GearRightPttNormal = 3040;
                public const int GearRightPttPushed = 3041;
                public const int GearRightTransitPttNormal = 3042;
                public const int GearRightTransitPttPushed = 3043;
                public const int NoseWheelSteeringNormal = 3044;
                public const int NoseWheelSteeringAlternate = 3045;
                public const int TirePressurePttNormal = 3046;
                public const int TirePressurePttPushed = 3047;
            }

            public static class Indicator
            {
                public const int AntiSkidInop = 3048;
                public const int AutobrakeDisarm = 3049;
                public const int BrakeTemp = 3050;
                public const int GearLeft = 3051;
                public const int GearLeftAftOvh = 3052;
                public const int GearLeftTransit = 3053;
                public const int GearNose = 3054;
                public const int GearNoseAftOvh = 3055;
                public const int GearNoseTransit = 3056;
                public const int GearRight = 3057;
                public const int GearRightAftOvh = 3058;
                public const int GearRightTransit = 3059;
                public const int Maint = 3060;
                public const int TirePressure = 3061;
            }

            public static class Gate
            {
                public const int AutobrakeReset = 3062;
            }
        }
    }
}
