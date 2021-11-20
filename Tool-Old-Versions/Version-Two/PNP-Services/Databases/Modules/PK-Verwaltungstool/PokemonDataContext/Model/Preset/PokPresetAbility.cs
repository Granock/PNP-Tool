using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetAbility : BaseAbility
    {
        #region Constructor
        public PokPresetAbility() { }
        public PokPresetAbility(PokDataAbility dataAbility)
        {
            Name = dataAbility.Name;
            Frequency = dataAbility.Frequency;
            Target = dataAbility.Target;
            Effect = dataAbility.Target;
        }
        #endregion

        #region Navigation
        public PokCompletePreset DataPokemon { get; set; }
        #endregion
    }
}
