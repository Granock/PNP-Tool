using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PNP_UI.CoreFunctionalities.Settings
{
    public partial class FrmSetting : Form, ISettingsView
    {
        private bool _save = false;

        private Dictionary<string, object> Settings = new();
        private readonly List<string> ChangedSettings = new();

        public Action FrmClosed { get; set; }

        public FrmSetting()
        { InitializeComponent(); }

        public List<string> GetAllTranslationAreas()
        { return new List<string>(); }

        public Dictionary<string, object> GetChangedSettings()
        { return  Settings.Where(x => ChangedSettings.Contains(x.Key)).ToDictionary(x => x.Key,x => x.Value); }

        public void SetSettings(Dictionary<string, object> settings)
        {
            Settings = settings;
            lbSettings.SelectedIndexChanged -= UpdateEditor;
            lbSettings.Items.Clear();
            foreach(string s in Settings.Keys)
            { lbSettings.Items.Add(s); }
            lbSettings.SelectedIndexChanged += UpdateEditor;
            UpdateEditor();
        }

        private void UpdateEditor(object sender, EventArgs e)
        { UpdateEditor(); }

        private void UpdateEditor()
        {

        }

        private void FrmSetting_FormClosed(object sender, FormClosedEventArgs e)
        { DialogResult = _save ? DialogResult.Yes : DialogResult.No; }

        private void BtnSave_Click(object sender, EventArgs e)
        { _save = true; Close(); }

        private void BtnCancel_Click(object sender, EventArgs e)
        { _save = false; Close(); }
    }
}
