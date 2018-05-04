using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Nem.API.Settings
{
    public class MonitoringServiceClientSettings
    {
        [HttpCheck("api/isalive", false)]
        public string MonitoringServiceUrl { get; set; }
    }
}
