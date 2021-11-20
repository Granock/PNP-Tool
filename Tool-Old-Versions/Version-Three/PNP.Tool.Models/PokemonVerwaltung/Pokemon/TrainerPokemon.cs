using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Edge;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move;
using PNP.Tool.Models.PokemonVerwaltung.Trainer;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon {
    public class TrainerPokemon : PokedexPokemon {

        #region Properties

        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        #region Stats

        public string Nature { get; set; }
        public int AllocatedHP { get; set; }
        public int AllocatedAttack { get; set; }
        public int AllocatedDefense { get; set; }
        public int AllocatedSPAttack { get; set; }
        public int AllocatedSPDefense { get; set; }
        public int AllocatedSpeed { get; set; }

        #endregion

        #endregion

        #region Navigation

        public ICollection<PokemonAbility> PokemonAbilites { get; set; }
        public ICollection<PokemonMove> PokemonMoves { get; set; }
        public ICollection<PokemonEdge> PokemonEdges { get; set; }

        [ForeignKey(nameof(Trainer))]
        public Guid? TrainerFK { get; set; }
        public BaseTrainer Trainer { get; set; }

        #endregion
    }
}
