using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using System.Collections.Generic;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokCompletePreset : BasePokemon
    {
        #region Navigation
        public ICollection<PokPresetStat> PresetStats { get; set; }
        public ICollection<PokPresetSkill> PresetSkills { get; set; }
        public ICollection<PokPresetEdge> PresetEdges { get; set; }
        public ICollection<PokPresetCapability> PresetCapabilities { get; set; }
        public ICollection<PokPresetAbility> PresetAbilities { get; set; }
        public ICollection<PokPresetMove> PresetMoveList { get; set; }
        public PokPresetAdditionalInfo AdditionalInfo { get; set; }
        #endregion
    }
}
