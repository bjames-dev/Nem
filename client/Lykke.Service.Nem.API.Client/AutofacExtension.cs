using System;
using Autofac;
using Common.Log;

namespace Lykke.Service.Nem.API.Client
{
    public static class AutofacExtension
    {
        public static void RegisterNem.APIClient(this ContainerBuilder builder, string serviceUrl, ILog log)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (serviceUrl == null) throw new ArgumentNullException(nameof(serviceUrl));
            if (log == null) throw new ArgumentNullException(nameof(log));
            if (string.IsNullOrWhiteSpace(serviceUrl))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(serviceUrl));

            builder.RegisterType<Nem.APIClient>()
                .WithParameter("serviceUrl", serviceUrl)
                .As<INem.APIClient>()
                .SingleInstance();
        }

        public static void RegisterNem.APIClient(this ContainerBuilder builder, Nem.APIServiceClientSettings settings, ILog log)
        {
            builder.RegisterNem.APIClient(settings?.ServiceUrl, log);
        }
    }
}
