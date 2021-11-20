using System;
using System.ComponentModel.DataAnnotations;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.TrainerMainContext.Model
{
    public class Trainer
    {
        #region Properties
        [Key]
        public Guid TrainerGUID { get; set; }
        #endregion
    }
}
