using PNP.Tool.Core.Enums.Models.PokemonVerwaltung;

namespace PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move {
    public class PokemonBaseMove : BaseEntity {

        #region Properties

        public int AC { get; set; }
        public int CritsOn { get; set; }
        public int DamageBase { get; set; }
        public DamageTypeEnum DamageType { get; set; }
        public string Range { get; set; }
        public string Effect { get; set; }

        #endregion
    }
}
