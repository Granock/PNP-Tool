using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.PokemonContext
{
    public class PokemonAbility : BaseAbility
    {
        #region Constructors
        public PokemonAbility() { }
        public PokemonAbility(PresetAbility dataAbility)
        {
            Name = dataAbility.Name;
            Frequency = dataAbility.Frequency;
            Target = dataAbility.Target;
            Effect = dataAbility.Effect;
        }
        #endregion
        
        #region Navigation
        public Pokemon Pokemon { get; set; }
        #endregion
    }
}
