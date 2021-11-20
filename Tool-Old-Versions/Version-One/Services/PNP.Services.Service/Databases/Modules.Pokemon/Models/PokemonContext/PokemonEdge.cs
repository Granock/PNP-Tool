using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext;
using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.PokemonContext
{
    public class PokemonEdge : BaseEdge
    {
        #region Constructors
        public PokemonEdge() {}
        public PokemonEdge(PresetEdge dataEdge)
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
