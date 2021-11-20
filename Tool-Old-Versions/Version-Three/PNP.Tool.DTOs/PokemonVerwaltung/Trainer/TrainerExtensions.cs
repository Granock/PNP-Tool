using PNP.Tool.DTOs.Base;
using PNP.Tool.Models.PokemonVerwaltung.Trainer;

namespace PNP.Tool.DTOs.PokemonVerwaltung.Trainer {
    public static class TrainerExtensions {
        
        public static BaseTrainerDTO ToDTO(this BaseTrainer trainer) {
            //Load Base-Stats
            BaseTrainerDTO dto = trainer.ToBaseDTO<BaseTrainer, BaseTrainerDTO>();
            //Other stats

            return dto;
        }
    }
}
