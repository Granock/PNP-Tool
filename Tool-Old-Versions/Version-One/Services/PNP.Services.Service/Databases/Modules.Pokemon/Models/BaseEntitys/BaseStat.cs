using PNP.Services.Service.Databases.Modules.Pokemon.ModelEnums;
using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseStat
    {
        #region Properties
        public Guid StatGUID { get; set; }
        public StatEnum StatType { get; set; }
        public int StatValue { get; set; }
        #endregion
    }
}
