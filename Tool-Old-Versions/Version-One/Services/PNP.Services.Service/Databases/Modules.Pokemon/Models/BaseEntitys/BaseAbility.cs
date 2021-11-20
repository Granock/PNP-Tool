using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseAbility
    {
        #region Properties
        public Guid AbilityGUID { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Target { get; set; }
        public string Effect { get; set; }
        #endregion
    }
}
