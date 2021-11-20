using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Enums;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset
{
    public class PokPresetMove : BaseMove
    {
        #region Properties
        public int LearnLevel { get; set; }
        public bool TypicalMove { get; set; }
        public MoveClassEnum MoveClass { get; set; }
        #endregion

        #region Constructor
        public PokPresetMove() { }
        public PokPresetMove(PokDataMove dataMove)
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
        public PokCompletePreset DataPokemon { get; set; }
        #endregion
    }
}
