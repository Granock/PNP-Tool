using System.Collections.Generic;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability {
    public class PokemonBaseAbility : BaseEntity {

        #region Properties

        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Target { get; set; }
        public string Effect { get; set; }

        #endregion
    }
}
