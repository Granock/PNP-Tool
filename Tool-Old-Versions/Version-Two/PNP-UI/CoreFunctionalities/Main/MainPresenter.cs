using PNP_Services;
using PNP_Services.Services.Core.LanguageService;
using PNP_UI.CoreFunctionalities.Infos;
using PNP_UI.CoreFunctionalities.Settings;
using PNP_UI.Features;
using System;

namespace PNP_UI.CoreFunctionalities.Main
{
    public class MainPresenter : AbstactPresenter<IMain>
    {
        private readonly ILanguageService _languageService;
        public Action PresenterCloses { get; set; }

        #region Constructors
        public MainPresenter(IMain view,ILanguageService languageService)
        {
            _view = view;
            _languageService = languageService;
        }
        #endregion

        public override void StartPresenter()
        {
            _view.SettingsClicked += SettingsClicked;
            _view.InfoClicked += InfoClicked;
            _view.FeatureSelectedChanged += SelectedFeatureChanged;
            _view.FrmClosed += ViewClosed;
            _view.SetFeatureList(FeatureProvider.GetAllAvailableFeatures());
            _view.SetTranslation(_languageService.GetLanguageTranslation());

            _view.Show();
        }

        #region _view

        #region Actions
        private void SelectedFeatureChanged(FeatureInfoDTO featureInfo)
        {
            FeatureProvider.CurrentFeature?.CloseFeature();
            FeatureProvider.LoadFeature(featureInfo);
            FeatureProvider.CurrentFeature?.LoadFeatureIntoWindow(ref _view.GetFeaturePanel());
        }
        private static void SettingsClicked()
        { 
            GlobalServiceProvider.GetRequiredService<SettingsPresenter>()
                                 .StartPresenter(); 
        }
        private static void InfoClicked()
        {
            GlobalServiceProvider.GetRequiredService<InfoPresenter>()
                                 .StartPresenter();
        }
        private void ViewClosed()
        { PresenterCloses?.Invoke(); }
        #endregion

        #endregion
    }
}
