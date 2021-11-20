using System;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys
{
    public abstract class BasePokemon
    {
        #region Properties
        public Guid PokemonGUID { get; set; }
        public int Pokedex { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        #endregion
    }
}
