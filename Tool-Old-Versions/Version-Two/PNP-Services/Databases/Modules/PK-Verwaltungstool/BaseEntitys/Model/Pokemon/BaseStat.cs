using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BaseStat
    {
        #region Properties
        [Key]
        public Guid StatGUID { get; set; }
        public StatEnum StatType { get; set; }
        public int StatValue { get; set; }
        #endregion
    }
}
