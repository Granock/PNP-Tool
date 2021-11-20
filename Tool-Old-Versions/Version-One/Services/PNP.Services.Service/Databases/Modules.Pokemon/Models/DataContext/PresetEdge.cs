using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PresetEdge : BaseEdge
    {
        #region Constructor
        public PresetEdge() { }
        public PresetEdge(DataEdge dataEdge)
        {
            Name = dataEdge.Name;
            Text = dataEdge.Text;
        }
        #endregion

        #region Navigation
        public PokemonPreset DataPokemon { get; set; }
        #endregion
    }
}
