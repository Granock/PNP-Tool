using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetAdditionalInfo : BaseAdditionalInfo
    {
        #region Navigation
        public PokCompletePreset DataPokemon { get; set; }
        public PokPresetEvolutionInfo EvolutionInfo { get; set; }
        #endregion
    }
}
