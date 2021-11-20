using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PNP_UI.CoreFunctionalities.Infos
{
    public partial class FrmInfo : Form, IInfoView
    {
        public FrmInfo()
        { InitializeComponent(); }

        public Action FrmClosed { get; set; }

        public List<string> GetAllTranslationAreas()
        {
            //All TranslationAreas
            return new List<string>();
        }

        public void SetCreatorEmail(string Mail)
        { lblInfoMail.Text = Mail; }

        private void btnClose_Click(object sender, EventArgs e)
        { Close(); }

        private void FrmInfo_Load(object sender, EventArgs e)
        { CenterToScreen(); }
    }
}
