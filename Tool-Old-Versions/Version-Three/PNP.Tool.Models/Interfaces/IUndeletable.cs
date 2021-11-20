namespace PNP.Tool.Models.Interfaces {
    /// <summary>
    /// If Model inherits this interface,
    /// instead of deleting it, it will be marked
    /// as deleted, but keept in the Database
    /// </summary>
    public interface IUndeletable : ModelInterface {
        public bool Deleted { get; set; }
    }
}
