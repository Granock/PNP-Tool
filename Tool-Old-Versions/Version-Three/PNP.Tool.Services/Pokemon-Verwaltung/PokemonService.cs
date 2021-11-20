using PNP.Tool.Databases.Base;
using PNP.Tool.Services.Base;

namespace PNP.Tool.Services.Pokemon_Verwaltung {
    public abstract class PokemonService : BaseService {
        protected override DbEnum GetDBEnum()
            => DbEnum.PokemonVerwaltung;
    }
}
