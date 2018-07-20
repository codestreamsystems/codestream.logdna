# codestream.logdna


[![NuGet](https://img.shields.io/nuget/dt/codestream.logdna.svg?style=plastic)](codestream.logdna) 
[![NuGet](https://img.shields.io/nuget/v/codestream.logdna.svg?style=plastic)](codestream.logdna)



Helpful classes on top of RedBear.LogDNA

## Configure LogDNA and ILogDNALogger in SimpleInjector (for example)

```
        private void RegisterLogDNA(Container container)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            container.RegisterSingleton(() =>
            {
                var config = new ConfigurationManager(AppSettings.LogDNAInjestionKey)
                {
                    HostName = AppSettings.LogDNAHostname,
                    FlushInterval = 500,
                    Tags = new []{AppSettings.Environment, Assembly.GetExecutingAssembly().GetName().Version.ToString() }
                };
                var client = config.Initialise();

                client.Connect();

                return client;
            });
            container.RegisterSingleton(() => (ILogDNALogger)new LogDNALogger(container.GetInstance<IApiClient>(), AppSettings.LogDNAApp));
        }

```

Then inject `ILogDNALogger` and away you go.