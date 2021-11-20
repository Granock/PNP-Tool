using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BaseEdge
    {
        #region Properties
        [Key]
        public Guid EdgeGUID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        #endregion
    }
}
