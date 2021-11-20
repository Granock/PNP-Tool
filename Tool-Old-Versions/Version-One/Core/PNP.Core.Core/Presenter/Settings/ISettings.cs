using PNP.Services.Service.Enumerators.Settings;
using System;
using System.Collections.Generic;

namespace PNP.Core.Core.Presenter.Settings
{
    public interface ISettings : IInterface
    {
        public List<Tuple<SettingEnum, object>> Settings { get; set; }
    }
}
