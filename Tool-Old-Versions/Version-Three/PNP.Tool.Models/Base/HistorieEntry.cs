using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNP.Tool.Models.Base {
    public class HistorieEntry : BaseEntity {

        #region Properties
        
        public string ChangeDescription { get; set; }
        public string ObjectBeforChange { get; set; }
        public string ObjectAfterChange { get; set; }
        
        #endregion

        #region Navigation

        [ForeignKey(nameof(TrackedObject))]
        public Guid TrackedObjectFK { get; set; }
        public BaseEntity TrackedObject { get; set; }

        #endregion
    }
}
