using System.Threading.Tasks;

namespace Lykke.Service.Nem.API.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}
