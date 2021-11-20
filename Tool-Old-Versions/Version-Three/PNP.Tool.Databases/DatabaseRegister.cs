using PNP.Tool.Databases.Base;
using PNP.Tool.Databases.Core;
using PNP.Tool.Databases.PokemonVerwaltung;

namespace PNP.Tool.Databases {
    public class DatabaseRegister {
        public static void Register() {
            DatabaseProvider.RegisterDatabase<CoreContext>(DbEnum.Core);
            DatabaseProvider.RegisterDatabase<PokemonContext>(DbEnum.PokemonVerwaltung);
        }
    }
}
