using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseEdge
    {
        #region Properties
        public Guid EdgeGUID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        #endregion
    }
}
