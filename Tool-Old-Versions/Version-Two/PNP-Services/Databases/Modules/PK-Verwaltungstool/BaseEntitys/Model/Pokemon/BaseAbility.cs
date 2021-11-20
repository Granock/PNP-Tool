using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BaseAbility
    {
        #region Properties
        [Key]
        public Guid AbilityGUID { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Target { get; set; }
        public string Effect { get; set; }
        #endregion
    }
}
