using PNP.Core.Core.Presenter.Settings;
using PNP.Services.Service.Enumerators;
using PNP.Services.Service.Enumerators.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PNP.Core.Core.Forms.Settings
{
    public partial class FrmSettings : Form, ISettings
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        public Action FrmClosed { get; set; }
        public List<Tuple<SettingEnum, object>> Settings {
            get => SaveSettings();
            set => LoadSettings(value); 
        }

        public void LoadSettings(List<Tuple<SettingEnum, object>> SettingsList)
        {
            #region LanguageSetting
            foreach (LanguageEnum e in Enum.GetValues(typeof(LanguageEnum)))
            { cbLanguage.Items.Add(e.ToString()); }

            LanguageEnum LE = (LanguageEnum)int.Parse(SettingsList.First(t => t.Item1 == SettingEnum.CurrentLanguageSelected).Item2.ToString());
            cbLanguage.SelectedIndex = cbLanguage.Items.IndexOf(LE.ToString());
            #endregion
        }

        public List<Tuple<SettingEnum, object>> SaveSettings()
        {
            List<Tuple<SettingEnum, object>> SettingsList = new List<Tuple<SettingEnum, object>>();

            #region LanguageSetting
            List<LanguageEnum> Languages = new List<LanguageEnum>();
            foreach (LanguageEnum e in Enum.GetValues(typeof(LanguageEnum))) { Languages.Add(e); }

            LanguageEnum LE = Languages.First(L => L.ToString() == cbLanguage.SelectedItem.ToString());
            SettingsList.Add(new Tuple<SettingEnum, object>(SettingEnum.CurrentLanguageSelected,(int)LE));
            #endregion

            return SettingsList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { DialogResult = DialogResult.No; }

        private void btnSuccess_Click(object sender, EventArgs e)
        { DialogResult = DialogResult.Yes; }

        private void FrmSettings_FormClosed(object sender, FormClosedEventArgs e)
        { FrmClosed?.Invoke(); }

        private void FrmSettings_Load(object sender, EventArgs e)
        { CenterToScreen(); }
    }
}
