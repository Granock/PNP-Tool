using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon.Capability {
    public class PokemonCapability : BaseEntity {

        #region Properties

        public string Name { get; set; }
        public string Text { get; set; }

        #endregion

        #region Navigation

        [ForeignKey(nameof(Pokemon))]
        public Guid PokemonFK { get; set; }
        public PokedexPokemon Pokemon { get; set; }

        #endregion
    }
}
