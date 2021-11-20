using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability {
    public class PokemonAbility : PokemonBaseAbility {

        #region Navigation

        [ForeignKey(nameof(Pokemon))]
        public Guid PokemonFK { get; set; }
        public TrainerPokemon Pokemon { get; set; }

        #endregion
    }
}
