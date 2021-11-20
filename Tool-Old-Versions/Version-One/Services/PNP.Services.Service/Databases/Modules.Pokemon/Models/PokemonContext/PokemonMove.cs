using PNP.Services.Service.Databases.Modules.Pokemon.ModelEnums;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.PokemonContext
{
    public class PokemonMove : BaseMove
    {
        #region Properties
        public int LearnLevel { get; set; }
        public bool TypicalMove { get; set; }
        public MoveClassEnum MoveClass { get; set; }
        #endregion

        #region Constructors

        public PokemonMove() { }

        public PokemonMove(PresetMove dataMove)
        {
            MoveName = dataMove.MoveName;
            AC = dataMove.AC;
            CritsOn = dataMove.CritsOn;
            DamageBase = dataMove.DamageBase;
            DamageType = dataMove.DamageType;
            Range = dataMove.Range;
            Effect = dataMove.Effect;
            LearnLevel = dataMove.LearnLevel;
            TypicalMove = dataMove.TypicalMove;
            MoveClass = dataMove.MoveClass;
        }
        #endregion

        #region Navigation
        public Pokemon Pokemon { get; set; }
        #endregion
    }
}
