using System.Collections;
using System.IO;
using System.Threading;
using Common.Net;
using nanoFramework.Runtime.Native;

namespace Common.Configuration
{
    public class ConfigurationWebServer
    {
        private readonly string _title;
        private readonly Configuration _config;
        private readonly WebServer _webServer;

        public ConfigurationWebServer(string title, Configuration config)
        {
            _title = title;
            _config = config;

            _webServer = new WebServer();
            _webServer.MapGet("/", DefaultHandler);
            _webServer.MapPost("/clear", ClearHandler, RebootHandler);
            _webServer.MapPost("/save", SaveHandler, RebootHandler);
        }

        public void Run()
        {
            _webServer.Run();
        }

        private string DefaultHandler(Hashtable request, Stream body)
        {
            var wifiConfig = Wireless80211.GetConfiguration();

            if (_config.IocpPort == 0)
                _config.IocpPort = 8092;

            return PageHtml(_title, 
                "		<form method=\"post\" enctype=\"application/x-www-form-urlencoded\">" +
                "			<table>" +
                "				<tr>" +
                "					<td>SSID</td>" +
                $"					<td><input type=\"text\" name=\"SSID\" value=\"{wifiConfig.Ssid}\" /></td>" +
                "				</tr>" +
                "				<tr>" +
                "					<td>Password</td>" +
                $"					<td><input type=\"text\" name=\"Password\" value=\"{wifiConfig.Password}\" /></td>" +
                "				</tr>" +
                "				<tr>" +
                "					<td>IOCP Server</td>" +
                $"					<td><input type=\"text\" name=\"IOCPServer\" value=\"{_config.IocpServer}\" /></td>" +
                "				</tr>" +
                "				<tr>" +
                "					<td>IOCP Port</td>" +
                $"					<td><input type=\"text\" name=\"IOCPPort\" value=\"{_config.IocpPort}\" /></td>" +
                "				</tr>" +
                "				<tr>" +
                "					<td colspan=\"2\" align=\"right\">" +
                "						<input type=\"submit\" value=\"Clear\" formaction=\"clear\" />" +
                "						<input type=\"submit\" value=\"Save\" formaction=\"save\" />" +
                "					</td>" +
                "				</tr>" +
                "			</table>" +
                "		</form>");
        }

        private string ClearHandler(Hashtable request, Stream body)
        {
            Wireless80211.Disable(true);

            _config.Delete();

            return RebootResponse();
        }

        private string SaveHandler(Hashtable request, Stream body)
        {
            Wireless80211.Configure((string)request["SSID"], (string)request["Password"]);

            _config.IocpServer = (string)request["IOCPServer"];
            _config.IocpPort = int.Parse((string)request["IOCPPort"]);
            _config.Save();

            return RebootResponse();
        }

        private string RebootResponse()
        {
            return PageHtml(_title, "Settings saved, rebooting...");
        }
        
        private void RebootHandler(Hashtable request)
        {
            AccessPoint.Disable();
            Thread.Sleep(200);
            Power.RebootDevice();
        }

        private string PageHtml(string title, string body)
        {
            return "<html>" +
                   "	<head>" +
                   "		<style type=\"text/css\">" +
                   "			body {" +
                   "				background-color: #000;" +
                   "				color: #fff;" +
                   "				font-family: arial;" +
                   "			}" +
                   "			body, td, input {" +
                   "				font-size: 20pt;" +
                   "			}" +
                   "		</style>" +
                   "	</head>" +
                   "	<body style=\"font-family: arial;\">" +
                   $"		<h3>{title}</h3>" +
                            body +
                   "	</body>" +
                   "</html>";
        }
    }
}