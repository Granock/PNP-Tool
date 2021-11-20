using PNP.Services.Service.Databases.Modules.Pokemon.Models.BaseEntitys;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Models.PokemonContext
{
    public class PokemonSkill : BaseSkill
    {
        #region Constructors

        public PokemonSkill() { }
        public PokemonSkill(PresetSkill dataSkill)
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
