using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PresetAdditionalInfo : BaseAdditionalInfo
    {
        #region Navigation
        public PokemonPreset DataPokemon { get; set; }
        public PresetEvolutionInfo EvolutionInfo { get; set; }
        #endregion
    }
}
