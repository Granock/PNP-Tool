using Microsoft.EntityFrameworkCore;
using PNP.Tool.Databases.Base;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Capability;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Edge;
using PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move;
using PNP.Tool.Models.PokemonVerwaltung.Trainer;

namespace PNP.Tool.Databases.PokemonVerwaltung {
    public class PokemonContext : BaseContext {

        public PokemonContext() : base() { }

        public PokemonContext(ConnectionInfo info) : base(info) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            
            //Objects of the Model
            modelBuilder.Entity<PokedexPokemon>().ToTable("Pokemon");
            modelBuilder.Entity<TrainerPokemon>();
            modelBuilder.Entity<PokemonBaseAbility>().ToTable("PokemonAbility");
            modelBuilder.Entity<PokemonAbility>();
            modelBuilder.Entity<PokemonCapability>();
            modelBuilder.Entity<PokemonBaseEdge>().ToTable("PokemonEdge");
            modelBuilder.Entity<PokemonEdge>();
            modelBuilder.Entity<PokemonBaseMove>().ToTable("PokemonMove");
            modelBuilder.Entity<PokemonLearnMove>();
            modelBuilder.Entity<PokemonMove>();
            modelBuilder.Entity<BaseTrainer>().ToTable("Trainer");

            //Fluent API implementation  
        }
    }
}
