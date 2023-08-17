using nanoFramework.Runtime.Native;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using Iot.Device.DhcpServer;
using AuthenticationType = System.Net.NetworkInformation.AuthenticationType;

namespace Common.Net
{
    public static class AccessPoint
    {
        private static readonly WirelessAPConfiguration.ConfigurationOptions EnabledConfiguration =
            WirelessAPConfiguration.ConfigurationOptions.Enable |
            WirelessAPConfiguration.ConfigurationOptions.AutoStart;

        // This is the only subnet mask supported by the DHCP server.
        private const string SubnetMask = "255.255.255.0";

        private static DhcpServer _dhcpServer;

        public static bool IsEnabled()
        {
            return IsEnabled(GetInfo());
        }

        private static bool IsEnabled(AccessPointInfo accessPoint)
        {
            return (accessPoint.Configuration.Options & EnabledConfiguration) == EnabledConfiguration;
        }

        public static void Start(string ssid, string ipAddress = "192.168.1.1")
        {
            Debug.WriteLine("Starting access point...");

            Wireless80211.Disable();
            
            if (!Configure(ssid, ipAddress))
            {
                Debug.WriteLine("Rebooting in access point mode...");
                Power.RebootDevice();
            }

            StartDhcpServer(ipAddress);
            
            Debug.WriteLine($"Access point started at {ipAddress}.");
        }

        private static bool Configure(string ssid, string ipAddress)
        {
            var accessPoint = GetInfo();
            var wasEnabled = IsEnabled(accessPoint);

            accessPoint.Configuration.Options = EnabledConfiguration;
            accessPoint.Configuration.Ssid = ssid;
            accessPoint.Configuration.Password = "";
            accessPoint.Configuration.MaxConnections = 10;
            
            accessPoint.Configuration.SaveConfiguration();

            accessPoint.Interface.EnableStaticIPv4(ipAddress, SubnetMask, ipAddress);

            return wasEnabled;
        }

        private static void StartDhcpServer(string ipAddress)
        {
            Debug.WriteLine("Starting DHCP...");
            
            _dhcpServer = new DhcpServer
            {
                CaptivePortalUrl = $"http://{ipAddress}"
            };

            if (!_dhcpServer.Start(IPAddress.Parse(ipAddress), IPAddress.Parse(SubnetMask)))
            {
                Debug.WriteLine($"Error initializing DHCP server.");
            }
        }

        public static void Disable()
        {
            var configuration = GetInfo().Configuration;
            configuration.Options = WirelessAPConfiguration.ConfigurationOptions.None;
            configuration.SaveConfiguration();
        }
        
        private static AccessPointInfo GetInfo()
        {
            foreach (var @interface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (@interface.NetworkInterfaceType != NetworkInterfaceType.WirelessAP) continue;

                var configuration = WirelessAPConfiguration.GetAllWirelessAPConfigurations()
                    [@interface.SpecificConfigId];

                return new AccessPointInfo(@interface, configuration);
            }
            return null;
        }

        private class AccessPointInfo
        {
            public AccessPointInfo(NetworkInterface @interface, WirelessAPConfiguration configuration)
            {
                Interface = @interface;
                Configuration = configuration;
            }

            public NetworkInterface Interface { get; }
            public WirelessAPConfiguration Configuration { get; }
        }
    }
}
