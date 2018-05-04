using JetBrains.Annotations;
using Lykke.Service.Nem.API.Settings.ServiceSettings;
using Lykke.Service.Nem.API.Settings.SlackNotifications;

namespace Lykke.Service.Nem.API.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings
    {
        public Nem.APISettings Nem.APIService { get; set; }

        public SlackNotificationsSettings SlackNotifications { get; set; }

        public MonitoringServiceClientSettings MonitoringServiceClient { get; set; }
    }
}
