using PNP.Services.Service.Enumerators;
using System.Collections.Generic;
using System.Drawing;

namespace PNP.Services.Service.Interfaces
{
    public interface IIconService
    {
        public Dictionary<string, Icon> GetIconsForForm(FormEnum formEnum);
        public Dictionary<string, Icon> GetIconForModule(ModuleEnum moduleEnum);
    }
}
