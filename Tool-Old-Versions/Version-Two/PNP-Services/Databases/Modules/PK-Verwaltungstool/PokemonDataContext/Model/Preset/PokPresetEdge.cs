using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetEdge : BaseEdge
    {
        #region Constructor
        public PokPresetEdge() { }
        public PokPresetEdge(PokDataEdge dataEdge)
        {
            Name = dataEdge.Name;
            Text = dataEdge.Text;
        }
        #endregion

        #region Navigation
        public PokCompletePreset DataPokemon { get; set; }
        #endregion
    }
}
