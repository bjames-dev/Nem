using System;
using Common.Log;

namespace Lykke.Service.Nem.API.Client
{
    public class Nem.APIClient : INem.APIClient, IDisposable
    {
        private readonly ILog _log;

        public Nem.APIClient(string serviceUrl, ILog log)
        {
            _log = log;
        }

        public void Dispose()
        {
            //if (_service == null)
            //    return;
            //_service.Dispose();
            //_service = null;
        }
    }
}
