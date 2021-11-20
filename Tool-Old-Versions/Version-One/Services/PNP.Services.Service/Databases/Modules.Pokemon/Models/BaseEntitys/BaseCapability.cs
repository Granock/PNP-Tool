using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseCapability
    {
        #region Properties
        public Guid CapabilityGUID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Frequency { get; set; }
        #endregion
    }
}
