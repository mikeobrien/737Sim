using Microsoft.AspNetCore.Mvc;

namespace SimConfigServer
{
    public class ConfigController
    {        
        [HttpGet, Route("/")]
        public string GetDefaultPage()
        {
            return "Sim Config Server";
        }
    }
}
