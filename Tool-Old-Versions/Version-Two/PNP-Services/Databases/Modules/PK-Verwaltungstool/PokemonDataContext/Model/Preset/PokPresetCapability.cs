using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetCapability : BaseCapability
    {
        #region Constructor
        public PokPresetCapability() { }
        public PokPresetCapability(PokDataCapability dataCapability)
        {
            Name = dataCapability.Name;
            Text = dataCapability.Text;
            Frequency = dataCapability.Frequency;
        }
        #endregion

        #region Navigation
        public PokCompletePreset DataPokemon { get; set; }
        #endregion
    }
}
