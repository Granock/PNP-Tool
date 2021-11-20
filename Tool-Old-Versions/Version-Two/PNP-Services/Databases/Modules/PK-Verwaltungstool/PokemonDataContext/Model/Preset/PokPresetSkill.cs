using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetSkill : BaseSkill
    {
        #region Navigation
        public PokCompletePreset DataPokemon { get; set; }
        #endregion
    }
}
