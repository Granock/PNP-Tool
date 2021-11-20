using System;
using System.Windows.Forms;

namespace PNP.Core.Core.Presenter
{
    public interface IInterface
    {
        Action FrmClosed { get; set; }
        public DialogResult ShowDialog();
        public void Close();

        public DialogResult DialogResult { get; set; }
    }
}
