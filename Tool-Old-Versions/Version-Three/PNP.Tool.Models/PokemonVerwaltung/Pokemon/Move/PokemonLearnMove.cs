using System;
using System.ComponentModel.DataAnnotations.Schema;
using PNP.Tool.Core.Enums.Models.PokemonVerwaltung;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move {
    public class PokemonLearnMove : PokemonBaseMove {

        #region Properties

        public int LearnLevel { get; set; }
        public bool TypicalMove { get; set; }
        public MoveClassEnum MoveClass { get; set; }
        
        #endregion

        #region Navigation

        [ForeignKey(nameof(Pokemon))]
        public Guid PokemonFK { get; set; }
        public PokedexPokemon Pokemon { get; set; }

        #endregion
    }
}
