using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PNP.Tool.Core.Enums.Models.PokemonVerwaltung;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Capability;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon {
    public class PokedexPokemon : BaseEntity {

        #region Properties

        public int Pokedex { get; set; }

        #region Skills

        public string Athletics { get; set; }
        public string Acrobatics { get; set; }
        public string Combat { get; set; }
        public string Stealth { get; set; }
        public string Perception { get; set; }
        public string Focus { get; set; }

        #endregion

        #region Stats

        public int BaseHP { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSPAttack { get; set; }
        public int BaseSPDefense { get; set; }
        public int BaseSpeed { get; set; }

        #endregion

        #region Additional

        public string Height { get; set; }
        public string Weight { get; set; }
        public int Weightclass { get; set; }
        public TypeEnum Type1 { get; set; }
        public TypeEnum? Type2 { get; set; }
        public string GenderRatio { get; set; }
        public string EggGroup { get; set; }
        public string HatchRate { get; set; }
        public string Diet { get; set; }
        public string Habitat { get; set; }

        #endregion

        #region Evolutions
        public int? EvolutionLevel1 { get; set; }
        public Guid? EvolutionPokemon1 { get; set; }

        public int? EvolutionLevel2 { get; set; }
        public Guid? EvolutionPokemon2 { get; set; }

        #endregion

        #endregion

        #region Navigation

        public bool WildcardAbilityIsBasic { get; set; }
        
        [ForeignKey(nameof(BasicAbility))]
        public Guid BasicAbilityFK { get; set; }
        public PokemonBaseAbility BasicAbility { get; set; }

        [ForeignKey(nameof(WildcardAbility))]
        public Guid WildcardAbilityFK { get; set; }
        public PokemonBaseAbility WildcardAbility { get; set; }

        [ForeignKey(nameof(AdvancedAbility))]
        public Guid AdvancedAbilityFK { get; set; }
        public PokemonBaseAbility AdvancedAbility { get; set; }

        [ForeignKey(nameof(AdvancedAbility2))]
        public Guid AdvancedAbility2FK { get; set; }
        public PokemonBaseAbility AdvancedAbility2 { get; set; }

        [ForeignKey(nameof(HighAbility))]
        public Guid HighAbilityFK { get; set; }
        public PokemonBaseAbility HighAbility { get; set; }

        public ICollection<PokemonCapability> PokemonCapabilities { get; set; }
        public ICollection<PokemonLearnMove> PokemonLearnMoves { get; set; }

        #endregion
    }
}
