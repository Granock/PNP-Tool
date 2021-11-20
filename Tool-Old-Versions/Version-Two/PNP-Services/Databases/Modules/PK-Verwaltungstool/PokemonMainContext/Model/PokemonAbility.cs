using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
{
    public class PokemonAbility : BaseAbility
    {
        #region Constructors
        public PokemonAbility() { }
        public PokemonAbility(PokPresetAbility dataAbility)
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
