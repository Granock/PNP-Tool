using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PNP_UI
{
    public interface IAbstractInterface
    {
        public void Show();
        public DialogResult ShowDialog();
        public void Close();
        public List<string> GetAllTranslationAreas();
        public DialogResult DialogResult { get; set; }
        public Action FrmClosed { get; set; }
    }
}
