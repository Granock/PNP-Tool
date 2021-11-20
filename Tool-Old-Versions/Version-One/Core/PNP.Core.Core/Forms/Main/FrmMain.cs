using PNP.Core.Core.Presenter.Main;
using PNP.Services.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PNP.Core.Core.Forms.Main
{
    public partial class FrmMain : Form,IMain
    {
        private Dictionary<string, ModuleInfo> ModuleList;
        public FrmMain()
        {
            InitializeComponent();
            tsbSettings.Click += tsiSettings_Clicked;
            tsbAdditional.Click += tsiAdditional_Clicked;
            tscMenus.SelectedIndexChanged += SelectedModuleChanged;
        }

        #region Actions and Funcs
        public Action FrmClosed { get; set; }
        public Action SettingsClicked { get; set; }
        public Action InfoClicked { get; set; }
        public Action<ModuleInfo> ModuleSelectedChanged { get; set; }
        #endregion

        #region EventHandlers
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        { FrmClosed?.Invoke(); }
        private void tsiSettings_Clicked(object sender, EventArgs e)
        { SettingsClicked?.Invoke(); }
        private void tsiAdditional_Clicked(object sender, EventArgs e)
        { InfoClicked?.Invoke(); }
        private void SelectedModuleChanged(object sender, EventArgs e)
        {
            if(tscMenus.SelectedIndex >= 0)
            { ModuleSelectedChanged?.Invoke(ModuleList[tscMenus.SelectedItem.ToString()]); }
        }
        #endregion

        #region GetControls
        public ref Panel GetModulePanel()
        { return ref panelMain; }
        public ref ToolStrip GetMainMenu()
        { return ref TopMenuStrip; }
        public ref StatusStrip GetStatusBar()
        { return ref BottomStatusStrip; }
        #endregion

        public void SetTranslation(Dictionary<string, string> translation)
        {
            Text = translation.ContainsKey("FrmMainText") ? translation["FrmMainText"] : "Programm";
            tsbSettings.Text = translation.ContainsKey("Settings") ? translation["Settings"] : "Einstellungen";
            tsbAdditional.Text = translation.ContainsKey("Additional") ? translation["Additional"] : "Weiteres";
        }
        public void SetModuleList(List<ModuleInfo> moduleInfos)
        {
            ModuleList = new Dictionary<string, ModuleInfo>();
            moduleInfos.ForEach(x => ModuleList.Add(x.ModuleName,x));
            tscMenus.Items.Clear();
            moduleInfos.ForEach(x => tscMenus.Items.Add(x.ModuleName));
        }
        public void SetIcons(Dictionary<string, Icon> IconList)
        {
            this.Icon = IconList.ContainsKey("FrmMain") ? IconList["FrmMain"] : this.Icon;
            tsbSettings.Image = IconList.ContainsKey("Settings") ? IconList["Settings"].ToBitmap() : tsbSettings.Image;
            tsbAdditional.Image = IconList.ContainsKey("Additional") ? IconList["Additional"].ToBitmap() : tsbAdditional.Image;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        { CenterToScreen(); }
    }
}
