using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetEvolutionInfo : BaseEvolutionInfo
    {
        #region Navigation
        public PokCompletePreset Evolution0 { get; set; }
        public PokCompletePreset Evolution1 { get; set; }
        public PokCompletePreset Evolution2 { get; set; }
        public PokPresetAdditionalInfo PresetAdditionalInfo { get; set; }
        #endregion
    }
}
