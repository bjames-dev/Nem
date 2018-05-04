using System.Collections.Generic;
using Lykke.Service.Nem.API.Core.Domain.Health;

namespace Lykke.Service.Nem.API.Core.Services
{
    // NOTE: See https://lykkex.atlassian.net/wiki/spaces/LKEWALLET/pages/35755585/Add+your+app+to+Monitoring
    public interface IHealthService
    {
        string GetHealthViolationMessage();
        IEnumerable<HealthIssue> GetHealthIssues();
    }
}