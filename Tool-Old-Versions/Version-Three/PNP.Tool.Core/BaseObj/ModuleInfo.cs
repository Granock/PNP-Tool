using System;
using System.Drawing;
using PNP.Tool.Core.Enums.Modules;

namespace PNP.Tool.Core.BaseObj {
    /// <summary>
    /// A small DTO which holds all needed Infos for a Module
    /// </summary>
    public class ModuleInfo
    {
        /// <summary>
        /// Creates a new Instance of this Module
        /// </summary>
        /// <param name="ModuleEnum">The <see cref="EnumModule"/> of the Module</param>
        /// <param name="ModuleName">The Name</param>
        /// <param name="ModuleDescription">The Description</param>
        public ModuleInfo(EnumModuleGrouping ModuleGrouping, EnumModule ModuleEnum, string ModuleName, string ModuleDescription, Image image = null) {
            Grouping = ModuleGrouping;
            Module = ModuleEnum;
            Name = ModuleName;
            Description = ModuleDescription;
            Image = image;
        }

        #region Properties

        /// <summary>
        /// A enum Module instance, which describes, into which Group this Module should be sorted on displaying
        /// </summary>
        public EnumModuleGrouping Grouping { get; set; }

        /// <summary>
        /// A unique <see cref="EnumModule"/> to identify the Module
        /// </summary>
        public EnumModule Module { get; set; }

        /// <summary>
        /// The Name of the Module
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A Description of the Module
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Holds the <see cref="System.Drawing.Image"/>, if available
        /// </summary>
        public Image Image { get; set; }

        #endregion
    }
}
