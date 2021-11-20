using System;
using System.Drawing;
using PNP.Tool.Core.BaseObj;
using PNP.Tool.Core.Enums.Modules;
using PNP.Tool.Services.Core.ImageProvider;
using PNP.Tool.Services.Core.Setting;
using PNP_UI.Base.Classes;

namespace PNP_UI.Core.Main {
    public class MainPresenter : BasePresenter<IMainView>
    {
        #region Services

        protected readonly IImageProviderService _imageProviderService;
        protected readonly ISettingsService _settingService;

        #endregion

        public MainPresenter(IMainView view,
                             IImageProviderService imageProviderService) : base(view) {
            _imageProviderService = imageProviderService;
        }

        public void InitView() {
            InitViewActions();
        }

        #region View-Actions

        private void InitViewActions() {
            _View.ModuleOpenClicked += OpenModule;
            _View.SendMessage += SendMessage;
            _View.WindowClosing += WindowClosing;
            _View.OpenSettings += OpenSettings;
            _View.OpenHelp += OpenHelp;
            _View.OpenInfo += OpenInfo;
            _View.GetImageForGroup += GetImageForGroup;
        }

        private void OpenModule(ModuleInfo infoDTO) {

        }

        private void SendMessage(CoreMessage message) {

        }

        private void WindowClosing() {

        }

        private void OpenSettings() {

        }

        private void OpenHelp() {

        }

        private void OpenInfo() {

        }

        private Image GetImageForGroup(EnumModuleGrouping group) {
            try {
                Guid imageGuid = _imageProviderService.GetIdentifierForModuleGrouping(group);
                return _imageProviderService.GetImage(imageGuid);
            } catch (Exception) {
                return null;
            }
        }

        #endregion

        #region Window-Handling



        #endregion
    }
}
