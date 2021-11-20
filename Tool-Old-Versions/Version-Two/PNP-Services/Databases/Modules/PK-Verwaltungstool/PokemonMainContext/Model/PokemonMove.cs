using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Enums;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
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

        public PokemonMove(PokPresetMove dataMove)
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
