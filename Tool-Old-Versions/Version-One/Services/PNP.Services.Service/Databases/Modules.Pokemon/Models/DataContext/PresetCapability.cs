using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PresetCapability : BaseCapability
    {
        #region Constructor
        public PresetCapability() { }
        public PresetCapability(DataCapability dataCapability)
        {
            Name = dataCapability.Name;
            Text = dataCapability.Text;
            Frequency = dataCapability.Frequency;
        }
        #endregion

        #region Navigation
        public PokemonPreset DataPokemon { get; set; }
        #endregion
    }
}
