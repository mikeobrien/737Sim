using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;
using nanoFramework.Networking;

namespace Common.Net
{
    public class Wireless80211
    { 
        public static bool IsEnabled()
        {
            return !GetConfiguration().Ssid.IsNullOrEmpty();
        }
        
        public static void Disable(bool clear = false)
        {
            var configuration = GetConfiguration();
            configuration.Options = Wireless80211Configuration.ConfigurationOptions.None;
            if (clear)
            {
                configuration.Ssid = "";
                configuration.Password = "";
            }
            configuration.SaveConfiguration();
        }
        
        public static bool Configure(string ssid, string password)
        {
            var success = WifiNetworkHelper.ConnectDhcp(ssid, password, 
                token: new CancellationTokenSource(10000).Token);
            Debug.WriteLine($"WiFi connection status: {success}");
            var configuration = GetConfiguration();
            configuration.Options = Wireless80211Configuration.ConfigurationOptions.AutoConnect | 
                                    Wireless80211Configuration.ConfigurationOptions.Enable;
            configuration.SaveConfiguration();
            return true;
        }
        
        public static Wireless80211Configuration GetConfiguration()
        {
            foreach (var @interface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (@interface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    return Wireless80211Configuration.GetAllWireless80211Configurations()
                        [@interface.SpecificConfigId];
                }
            }
            return null;
        }
    }
}
