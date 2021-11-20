using PNP.Services.Service.Enumerators;
using PNP.Services.Service.Interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace PNP.Services.Service.Services.IconService
{
    public class IconService : IIconService
    {
        public Dictionary<string, Icon> GetIconForModule(ModuleEnum moduleEnum)
        {
            Dictionary<string, Icon> IconList = new Dictionary<string, Icon>();
            switch(moduleEnum)
            {
                case ModuleEnum.Pokemon:
                    {
                        break;
                    }
            }
            return IconList;
        }

        public Dictionary<string, Icon> GetIconsForForm(FormEnum formEnum)
        {
            Dictionary<string, Icon> IconList = new Dictionary<string, Icon>();
            switch(formEnum)
            {
                case FormEnum.FrmMain:
                    {
                        break;
                    }
                case FormEnum.FrmSettings:
                    {
                        break;
                    }
                case FormEnum.FrmInfos:
                    {
                        break;
                    }
            }
            return IconList;
        }
    }
}
