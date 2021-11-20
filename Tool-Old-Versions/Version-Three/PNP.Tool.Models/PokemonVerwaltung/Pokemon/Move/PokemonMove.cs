using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move {
    public class PokemonMove : PokemonLearnMove {

        #region Navigation

        [ForeignKey(nameof(TrainerPokemon))]
        public Guid TrainerPokemonFK { get; set; }
        public TrainerPokemon TrainerPokemon { get; set; }

        #endregion
    }
}
