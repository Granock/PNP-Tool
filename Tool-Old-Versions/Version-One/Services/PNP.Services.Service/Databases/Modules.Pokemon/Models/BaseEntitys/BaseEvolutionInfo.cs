using System;
using System.Collections.Generic;
using System.Text;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BaseEvolutionInfo
    {
        #region Properties
        public Guid EvolutionInfoGUID { get; set; }
        public int? EvolutionLevel1 { get; set; }
        public bool HasEvolution { get; set; }
        public int? EvolutionLevel2 { get; set; }
        public bool HasSecondEvolution { get; set; }
        #endregion
    }
}
