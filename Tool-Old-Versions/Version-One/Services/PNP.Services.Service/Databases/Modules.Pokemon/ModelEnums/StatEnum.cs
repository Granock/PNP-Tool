using System;
using System.Collections.Generic;
using System.Text;

namespace PNP.Services.Service.Databases.Modules.Pokemon.ModelEnums
{
    public enum StatEnum
    {
        #region Base
        HPBase = 1,
        AttackBase = 2,
        DefenseBase = 3,
        SpecialAttackBase = 4,
        SpecialDefenseBase = 5,
        SpeedBase = 6,
        #endregion

        #region Current
        HPCurrent = 7,
        AttackCurrent = 8,
        DefenseCurrent = 9,
        SpecialAttackCurrent = 10,
        SpecialDefenseCurrent = 11,
        SpeedCurrent = 12
        #endregion
    }
}
