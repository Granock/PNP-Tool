using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BaseCapability
    {
        #region Properties
        [Key]
        public Guid CapabilityGUID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Frequency { get; set; }
        #endregion
    }
}
