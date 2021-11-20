using System;
using System.Windows.Forms;

namespace PNP_Core.RuntimeHandling
{
    public static class CoreEntryPoint
    {

        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CoreRunContext());
        }
    }
}
