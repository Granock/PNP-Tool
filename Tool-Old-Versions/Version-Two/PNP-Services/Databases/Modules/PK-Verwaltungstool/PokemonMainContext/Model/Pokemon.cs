using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
{
    public class Pokemon : BasePokemon
    {
        #region Properties
        public Guid TrainerGUID { get; set; }
        #endregion

        #region Constructor
        public Pokemon() { }
        public Pokemon(PokCompletePreset dataPokemon)
        {
            Pokedex = dataPokemon.Pokedex;
            Name = dataPokemon.Name;
            Level = dataPokemon.Level;
            ExperiencePoints = dataPokemon.ExperiencePoints;

            PokemonStats = dataPokemon.PresetStats?.Select(x => new PokemonStat(x)).ToList() ?? new List<PokemonStat>();
            PokemonSkills = dataPokemon.PresetSkills?.Select(x => new PokemonSkill(x)).ToList() ?? new List<PokemonSkill>();
            PokemonEdges = dataPokemon.PresetEdges?.Select(x => new PokemonEdge(x)).ToList() ?? new List<PokemonEdge>();
            PokemonCapabilities = dataPokemon.PresetCapabilities?.Select(x => new PokemonCapability(x)).ToList() ?? new List<PokemonCapability>();
            PokemonAbilities = dataPokemon.PresetAbilities?.Select(x => new PokemonAbility(x)).ToList() ?? new List<PokemonAbility>();
            PokemonMoves = dataPokemon.PresetMoveList?.Select(x => new PokemonMove(x)).ToList() ?? new List<PokemonMove>();
            AdditionalInfo = dataPokemon.AdditionalInfo != null ? new PokemonAdditionalInfo(dataPokemon.AdditionalInfo) : new PokemonAdditionalInfo();
        }
        #endregion

        #region Navigation
        public ICollection<PokemonStat> PokemonStats { get; set; }
        public ICollection<PokemonSkill> PokemonSkills { get; set; }
        public ICollection<PokemonEdge> PokemonEdges { get; set; }
        public ICollection<PokemonCapability> PokemonCapabilities { get; set; }
        public ICollection<PokemonAbility> PokemonAbilities { get; set; }
        public ICollection<PokemonMove> PokemonMoves { get; set; }
        public PokemonAdditionalInfo AdditionalInfo { get; set; }
        #endregion
    }
}
