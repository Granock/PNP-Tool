using Microsoft.Extensions.DependencyInjection;
using PNP.Tool.Core.Global;
using PNP_UI.Core.Main;

namespace PNP.Tool.UI {
    public class PresenterRegister : IDPInjectionRegister {
        public void Register(IServiceCollection serviceCollection) {
            serviceCollection.AddSingleton<IMainView, FrmMain>();
        }
    }
}
