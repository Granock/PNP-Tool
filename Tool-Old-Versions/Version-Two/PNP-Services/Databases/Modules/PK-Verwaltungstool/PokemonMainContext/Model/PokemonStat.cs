using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
{
    public class PokemonStat : BaseStat
    {
        #region Constructor
        public PokemonStat() { }
        public PokemonStat(PokPresetStat dataStat)
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
