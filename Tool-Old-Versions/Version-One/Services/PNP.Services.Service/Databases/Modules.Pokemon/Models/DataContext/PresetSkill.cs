using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PresetSkill : BaseSkill
    {
        #region Navigation
        public PokemonPreset DataPokemon { get; set; }
        #endregion
    }
}
