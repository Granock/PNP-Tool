using PNP.Core.Core.Presenter.Info;
using System;
using System.Windows.Forms;

namespace PNP.Core.Core.Forms.Infos
{
    public partial class FrmInfo : Form, IInfo
    {
        public FrmInfo()
        { InitializeComponent(); }

        public Action FrmClosed { get; set; }

        public void SetCreatorEmail(string Mail)
        { lblInfoMail.Text = Mail; }

        private void btnClose_Click(object sender, EventArgs e)
        { Close(); }

        private void FrmInfo_FormClosed(object sender, FormClosedEventArgs e)
        { FrmClosed?.Invoke(); }

        private void FrmInfo_Load(object sender, EventArgs e)
        { CenterToScreen(); }
    }
}
