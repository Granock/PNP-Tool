using PNP.Services.Service.Databases.Modules.Pokemon.ModelEnums;
using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseSkill
    {
        #region Properties
        public Guid SkillGUID { get; set; }
        public SkillEnum SkillType { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        #endregion
    }
}
