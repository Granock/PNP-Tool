using PNP.Services.Service.Databases.Modules.Pokemon.ModelEnums;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext
{
    public class PresetMove : BaseMove
    {
        #region Properties
        public int LearnLevel { get; set; }
        public bool TypicalMove { get; set; }
        public MoveClassEnum MoveClass { get; set; }
        #endregion

        #region Constructor
        public PresetMove() { }
        public PresetMove(DataMove dataMove)
        {
            MoveName = dataMove.MoveName;
            AC = dataMove.AC;
            CritsOn = dataMove.CritsOn;
            DamageBase = dataMove.DamageBase;
            DamageType = dataMove.DamageType;
            Range = dataMove.Range;
            Effect = dataMove.Effect;
        }
        #endregion

        #region Navigation
        public PokemonPreset DataPokemon { get; set; }
        #endregion
    }
}
