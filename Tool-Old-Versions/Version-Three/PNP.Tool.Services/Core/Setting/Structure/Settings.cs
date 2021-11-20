using PNP.Tool.Services.Core.Setting.Schema;

namespace PNP.Tool.Services.Core.Setting.Structure {
    [SettingClass("Einstellungen", "Einstellungen der Software")]
    public abstract class Settings
    {
        public Core.CoreSettings CoreSettings { get; set; }
        public Features.PokemonVerwaltung PokemonVerwaltung { get; set; }
    }
}
