using PNP.Services.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PNP.Core.Core.Presenter.Main
{
    public interface IMain : IInterface
    {
        #region Actions and Fncs
        Action SettingsClicked { get; set; }
        Action InfoClicked { get; set; }
        Action<ModuleInfo> ModuleSelectedChanged { get; set; }
        #endregion

        #region GetControls
        public ref Panel GetModulePanel();
        public ref ToolStrip GetMainMenu();
        public ref StatusStrip GetStatusBar();
        #endregion

        public void SetTranslation(Dictionary<string, string> translation);
        public void SetModuleList(List<ModuleInfo> moduleInfos);
        public void SetIcons(Dictionary<string, Icon> IconList);
    }
}
