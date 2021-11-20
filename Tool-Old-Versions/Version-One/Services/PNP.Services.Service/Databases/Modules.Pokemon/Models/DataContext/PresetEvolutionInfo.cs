using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PresetEvolutionInfo : BaseEvolutionInfo
    {
        #region Navigation
        public PokemonPreset Evolution0 { get; set; }
        public PokemonPreset Evolution1 { get; set; }
        public PokemonPreset Evolution2 { get; set; }
        public PresetAdditionalInfo PresetAdditionalInfo { get; set; }
        #endregion
    }
}
