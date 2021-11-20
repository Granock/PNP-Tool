using Microsoft.Extensions.DependencyInjection;
using PNP.Tool.Core.Global;
using PNP.Tool.Services.Core.ImageProvider;
using PNP.Tool.Services.Core.Logger;
using PNP.Tool.Services.Core.Setting;

namespace PNP.Tool.Services {
    public class ServiceRegister : IDPInjectionRegister {
        public void Register(IServiceCollection serviceCollection) {
            serviceCollection.AddScoped(x => LoggerFactory.GetLogger(x));
            serviceCollection.AddScoped<ISettingsService, SettingsService>();
            serviceCollection.AddScoped<IImageProviderService, ImageProviderService>();
        }
    }
}
