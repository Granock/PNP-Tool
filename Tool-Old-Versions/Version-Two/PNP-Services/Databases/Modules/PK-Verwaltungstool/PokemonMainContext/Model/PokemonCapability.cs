using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
{
    public class PokemonCapability : BaseCapability
    {
        #region Constructors
        public PokemonCapability() { }
        public PokemonCapability(PokPresetCapability dataCapability)
        {
            Name = dataCapability.Name;
            Text = dataCapability.Text;
            Frequency = dataCapability.Frequency;
        }
        #endregion

        #region Navigation
        public Pokemon Pokemon { get; set; }
        #endregion
    }
}
