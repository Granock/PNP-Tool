using PNP.Services.Service.Databases.Modules.Pokemon.ModelEnums;
using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseAdditionalInfo
    {
        #region Properties
        public Guid InfoGUID { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int Weightclass { get; set; }
        public TypeEnum Type1 { get; set; }
        public TypeEnum? Type2 { get; set; }
        public string Gender { get; set; }
        public string GenderRatio { get; set; }
        public string EggGroup { get; set; }
        public string HatchRate { get; set; }
        public string Diet { get; set; }
        public string Habitat { get; set; }
        #endregion
    }
}
