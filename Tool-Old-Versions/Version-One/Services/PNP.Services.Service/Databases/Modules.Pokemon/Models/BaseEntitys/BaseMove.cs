using PNP.Services.Service.Databases.Modules.Pokemon.ModelEnums;
using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseMove
    {
        #region Properties
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
