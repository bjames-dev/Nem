using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Nem.API.Settings.ServiceSettings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
