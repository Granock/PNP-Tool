using PNP_UI.Features;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PNP_UI.CoreFunctionalities.Main
{
    public partial class FrmMain : Form,IMain
    {
        private Dictionary<string, FeatureInfoDTO> AllFeatures;
        public FrmMain()
        {
            InitializeComponent();
            tsbSettings.Click += TsiSettings_Clicked;
            tsbAdditional.Click += TsiAdditional_Clicked;
            tscMenus.SelectedIndexChanged += SelectedFeatureChanged;
        }

        #region EventHandlers
        private void TsiSettings_Clicked(object sender, EventArgs e)
        { SettingsClicked?.Invoke(); }
        private void TsiAdditional_Clicked(object sender, EventArgs e)
        { InfoClicked?.Invoke(); }
        private void SelectedFeatureChanged(object sender, EventArgs e)
        {
            if(tscMenus.SelectedIndex >= 0)
            { FeatureSelectedChanged?.Invoke(AllFeatures[tscMenus.SelectedItem.ToString()]); }
        }
        #endregion

        #region IMain

        public ref Panel GetFeaturePanel()
        { return ref panelMain; }

        public void SetFeatureList(List<FeatureInfoDTO> featureInfos)
        {
            AllFeatures = new Dictionary<string, FeatureInfoDTO>();
            featureInfos.ForEach(m => AllFeatures.Add(m.DisplayName, m));
        }

        #region Translation

        #region TRANSLATIONCONSTANTS
        const string MAINTITLE = "Hauptfenster-Infos-Überschrift";
        const string MAINSETTINGS = "Hauptfenster-Einstellungen-Button";
        const string MAININFOS = "Hauptfenster-Infos-Button";
        #endregion

        public void SetTranslation(Dictionary<string, string> translation)
        {
            //All Translations

            if(translation.ContainsKey(MAINTITLE))
            { this.Text = translation[MAINTITLE]; }

            if(translation.ContainsKey(MAINSETTINGS))
            { tsbSettings.Text = translation[MAINSETTINGS]; }

            if(translation.ContainsKey(MAININFOS))
            { tsbAdditional.Text = translation[MAININFOS]; }

        }

        public List<string> GetAllTranslationAreas()
        {
            //All TranslationAreas
            List<string> translations = new();

            translations.Add(MAINTITLE);
            translations.Add(MAINSETTINGS);
            translations.Add(MAININFOS);

            return translations;
        }

        #endregion

        #region Actions and Funcs
        public Action SettingsClicked { get; set; }
        public Action InfoClicked { get; set; }
        public Action<FeatureInfoDTO> FeatureSelectedChanged { get; set; }
        public Action FrmClosed { get; set; }
        #endregion

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        { CenterToScreen(); }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        { FrmClosed?.Invoke(); }
    }
}
