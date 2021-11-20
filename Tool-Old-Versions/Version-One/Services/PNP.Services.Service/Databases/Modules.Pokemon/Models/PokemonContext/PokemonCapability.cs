using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.PokemonContext
{
    public class PokemonCapability : BaseCapability
    {
        #region Constructors
        public PokemonCapability() { }
        public PokemonCapability(PresetCapability dataCapability)
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
