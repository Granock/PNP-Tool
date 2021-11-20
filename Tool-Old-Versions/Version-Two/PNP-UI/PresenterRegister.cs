using Microsoft.Extensions.DependencyInjection;
using PNP_Services;
using PNP_UI.CoreFunctionalities.Infos;
using PNP_UI.CoreFunctionalities.Main;
using PNP_UI.CoreFunctionalities.Settings;

namespace PNP_UI
{
    public class PresenterRegister : IRegister
    {
        public void Register(IServiceCollection serviceCollection)
        {
            //Register Presenters
            serviceCollection.AddSingleton<IInfoView, FrmInfo>();
            serviceCollection.AddSingleton<InfoPresenter>();
            serviceCollection.AddSingleton<ISettingsView, FrmSetting>();
            serviceCollection.AddSingleton<SettingsPresenter>();
            serviceCollection.AddSingleton<IMain, FrmMain>();
            serviceCollection.AddSingleton<MainPresenter>();
        }
    }
}
