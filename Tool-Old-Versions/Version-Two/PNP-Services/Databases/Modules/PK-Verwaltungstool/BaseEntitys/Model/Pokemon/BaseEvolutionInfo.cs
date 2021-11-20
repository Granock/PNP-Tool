using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BaseEvolutionInfo
    {
        #region Properties
        [Key]
        public Guid EvolutionInfoGUID { get; set; }
        public int? EvolutionLevel1 { get; set; }
        public bool HasEvolution { get; set; }
        public int? EvolutionLevel2 { get; set; }
        public bool HasSecondEvolution { get; set; }
        #endregion
    }
}
