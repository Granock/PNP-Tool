using System;
using System.ComponentModel.DataAnnotations;

namespace PNP.Tool.Models {
    public abstract class BaseEntity {

        #region Properties

        [Key]
        public Guid GUID { get; set; }

        #endregion
    }
}
