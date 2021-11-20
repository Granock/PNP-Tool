using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetStat : BaseStat
    {
        #region Navigation
        public PokCompletePreset DataPokemon { get; set; }
        #endregion
    }
}
