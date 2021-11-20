using PNP.Core.Core.Forms.Main;
using PNP.Core.Core.Presenter.Info;
using PNP.Core.Core.Presenter.Settings;
using PNP.Services.Core;
using PNP.Services.Service.DTOs;
using PNP.Services.Service.Enumerators;
using PNP.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PNP.Core.Core.Presenter.Main
{
    public class MainPresenter : Presenter<IMain>
    {
        private readonly IIconService _iconService;
        private ILanguageService _languageService;
        private BaseModule _currentModule;
        public Action PresenterCloses { get; set; }

        #region Constructors
        public MainPresenter()
        {
            _languageService = GlobalServiceProvider.GetRequiredService<ILanguageService>();
            _iconService = GlobalServiceProvider.GetRequiredService<IIconService>();
            SetView();
        }
        #endregion

        #region _view
        public void SetView()
        {
            _view = new FrmMain();
            _view.FrmClosed += StopMain;
            _view.SettingsClicked += SettingsClicked;
            _view.InfoClicked += InfoClicked;
            _view.ModuleSelectedChanged += ModuleChanged;
            _view.SetTranslation(_languageService.GetLanguageTranslation(FormEnum.FrmMain));
            _view.SetIcons(_iconService.GetIconsForForm(FormEnum.FrmMain));
            _view.SetModuleList(GlobalModuleProvider.GetAvailableModules());
        }
        public void FrmClosed()
        { PresenterCloses?.Invoke(); }
        public void SettingsClicked()
        { new SettingsPresenter().StartPresenter(); }
        public void InfoClicked()
        { new InfoPresenter().StartPresenter(); }
        public void ModuleChanged(ModuleInfo moduleInfo)
        {
            if(_currentModule?.GetModuleInfo() != moduleInfo)
            {
                _currentModule?.CloseModule();
                _view.GetModulePanel().Controls.Clear();
                _view.GetStatusBar().Items.Clear();
                int count = _view.GetMainMenu().Items.Count;
                List<ToolStripItem> ItemsToRemove = new List<ToolStripItem>();
                for (int i = 0; i < count; i++)
                {
                    string name = _view.GetMainMenu().Items[i].Name;
                    if (name != "tsbSettings" && name != "tsbAdditional" && name != "tscMenus")
                    { ItemsToRemove.Add(_view.GetMainMenu().Items[i]); }
                }
                ItemsToRemove.ForEach(x => _view.GetMainMenu().Items.Remove(x));
                _currentModule = GlobalModuleProvider.GetModule(moduleInfo.ModuleEnum);
                _currentModule.FillModuleControlsIn(ref _view.GetModulePanel(),ref _view.GetMainMenu(),ref _view.GetStatusBar());
            }
        }

        #endregion

        public override void StartPresenter()
        { _view.ShowDialog(); }
        public void StopMain()
        { PresenterCloses?.Invoke(); }
    }
}
