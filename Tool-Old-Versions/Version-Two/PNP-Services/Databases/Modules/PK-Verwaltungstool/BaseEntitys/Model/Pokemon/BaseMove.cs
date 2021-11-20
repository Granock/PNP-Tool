using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BaseMove
    {
        #region Properties
        [Key]
        public Guid MoveGUID { get; set; }
        public string MoveName { get; set; }
        public int AC { get; set; }
        public int CritsOn { get; set; }
        public int DamageBase { get; set; }
        public DamageTypeEnum DamageType { get; set; }
        public string Range { get; set; }
        public string Effect { get; set; }
        #endregion
    }
}
