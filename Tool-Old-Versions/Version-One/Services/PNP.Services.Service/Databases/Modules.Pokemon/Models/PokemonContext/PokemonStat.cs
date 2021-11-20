using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.PokemonContext
{
    public class PokemonStat : BaseStat
    {
        #region Constructor
        public PokemonStat() { }
        public PokemonStat(PresetStat dataStat)
        {
            StatType = dataStat.StatType;
            StatValue = dataStat.StatValue;
        }
        #endregion

        #region Navigation
        public Pokemon Pokemon { get; set; }
        #endregion
    }
}
