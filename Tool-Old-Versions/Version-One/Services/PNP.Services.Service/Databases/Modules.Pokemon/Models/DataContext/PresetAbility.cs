using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PresetAbility : BaseAbility
    {
        #region Constructor
        public PresetAbility() { }
        public PresetAbility(DataAbility dataAbility)
        {
            Name = dataAbility.Name;
            Frequency = dataAbility.Frequency;
            Target = dataAbility.Target;
            Effect = dataAbility.Target;
        }
        #endregion

        #region Navigation
        public PokemonPreset DataPokemon { get; set; }
        #endregion
    }
}
