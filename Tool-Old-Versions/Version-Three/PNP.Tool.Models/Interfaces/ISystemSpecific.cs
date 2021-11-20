using System;

namespace PNP.Tool.Models.Interfaces {

    /// <summary>
    /// A Model which inherits this interface can be filter
    /// by <see cref="SystemGuid"/>
    /// </summary>
    public interface ISystemSpecific : ModelInterface {

        public Guid SystemGuid { get; set; }
    }
}
