using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
{
    public class PokemonSkill : BaseSkill
    {
        #region Constructors

        public PokemonSkill() { }
        public PokemonSkill(PokPresetSkill dataSkill)
        {
            SkillType = dataSkill.SkillType;
            Value1 = dataSkill.Value1;
            Value2 = dataSkill.Value2;
        }

        #endregion

        #region Navigation
        public Pokemon Pokemon { get; set; }
        #endregion
    }
}
