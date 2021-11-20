using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon.Edge {
    public class PokemonEdge : PokemonBaseEdge {

        #region Navigation

        [ForeignKey(nameof(Pokemon))]
        public Guid PokemonFK { get; set; }
        public PokedexPokemon Pokemon { get; set; }

        #endregion
    }
}
