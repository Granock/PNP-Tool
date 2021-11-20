using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;
using System.Collections.Generic;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PokemonPreset : BasePokemon
    {
        #region Navigation
        public ICollection<PresetStat> PresetStats { get; set; }
        public ICollection<PresetSkill> PresetSkills { get; set; }
        public ICollection<PresetEdge> PresetEdges { get; set; }
        public ICollection<PresetCapability> PresetCapabilities { get; set; }
        public ICollection<PresetAbility> PresetAbilities { get; set; }
        public ICollection<PresetMove> PresetMoveList { get; set; }
        public PresetAdditionalInfo AdditionalInfo { get; set; }
        #endregion
    }
}
