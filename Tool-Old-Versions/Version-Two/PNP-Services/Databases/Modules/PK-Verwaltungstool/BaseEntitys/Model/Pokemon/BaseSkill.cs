using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BaseSkill
    {
        #region Properties
        [Key]
        public Guid SkillGUID { get; set; }
        public SkillEnum SkillType { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        #endregion
    }
}
