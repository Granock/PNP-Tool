using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
{
    public class PokemonEdge : BaseEdge
    {
        #region Constructors
        public PokemonEdge() {}
        public PokemonEdge(PokPresetEdge dataEdge)
        {
            Name = dataEdge.Name;
            Text = dataEdge.Text;
        }
        #endregion

        #region Navigation
        public Pokemon Pokemon { get; set; }
        #endregion
    }
}
