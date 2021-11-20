using PNP_Services.Databases.Modules.PK_Verwaltungstool.BaseEntitys.Model.Pokemon;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;
using System;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model
{
    public class PokemonAdditionalInfo : BaseAdditionalInfo
    {
        #region Properties
        public Guid DataPresetGUID { get; set; }
        #endregion

        #region Constructors
        public PokemonAdditionalInfo() { }
        public PokemonAdditionalInfo(PokPresetAdditionalInfo dataAdditionalInfo)
        {
            Height = dataAdditionalInfo.Height;
            Weight = dataAdditionalInfo.Weight;
            Weightclass = dataAdditionalInfo.Weightclass;
            Type1 = dataAdditionalInfo.Type1;
            Type2 = dataAdditionalInfo.Type2;
            Gender = dataAdditionalInfo.Gender;
            GenderRatio = dataAdditionalInfo.GenderRatio;
            EggGroup = dataAdditionalInfo.EggGroup;
            HatchRate = dataAdditionalInfo.HatchRate;
            Diet = dataAdditionalInfo.Diet;
            Habitat = dataAdditionalInfo.Habitat;

            DataPresetGUID = dataAdditionalInfo.DataPokemon?.PokemonGUID ?? Guid.Empty;
        }
        #endregion

        #region Navigation
        public Pokemon Pokemon { get; set; }
        #endregion
    }
}
