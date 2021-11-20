using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon
{
    public abstract class BasePokemon
    {
        #region Properties
        [Key]
        public Guid PokemonGUID { get; set; }
        public int Pokedex { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        #endregion
    }
}
