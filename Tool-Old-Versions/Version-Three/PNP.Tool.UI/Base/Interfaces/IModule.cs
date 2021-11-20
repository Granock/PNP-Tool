using System;
using PNP.Tool.Core.BaseObj;
using PNP.Tool.Core.Enums.Modules;

namespace PNP_UI.Base.Interfaces {
    /// <summary>
    /// An interface which all Presenters of Modules have to implement
    /// </summary>
    public interface IModule
    {
        #region Properties

        /// <summary>
        /// A enum Module instance, which describes, into which Group this Module should be sorted on displaying
        /// </summary>
        public EnumModuleGrouping ModuleGrouping { get; }

        /// <summary>
        /// A unique <see cref="EnumModule"/> to identify the Module
        /// </summary>
        public EnumModule ModuleEnum { get; }

        /// <summary>
        /// The Name of the Module
        /// </summary>
        public string ModuleName { get; }

        /// <summary>
        /// A Description of the Module
        /// </summary>
        public string ModuleDescription { get; }

        #endregion

        #region Actions

        /// <summary>
        /// Displays a Message to the User
        /// </summary>
        public Action<CoreMessage> SendMessage { get; set; }

        #endregion

        #region Functions

        /// <summary>
        /// Tells the Module it can start doing Work
        /// </summary>
        public void StartModule();

        /// <summary>
        /// Tells Module to Close.
        /// If there are Unsaved Changes Module will return <see cref="EnumModuleStopResult.HasUnsavedChanges"/> and won't close
        /// </summary>
        /// <param name="IgnoreUnsavedChanges">Forces the Module to Ignore Unsaved Changes</param>
        /// <param name="ForceClose">Forces the Module to ignore everything and close</param>
        /// <returns>an instance of <see cref="EnumModuleStopResult"/> which discribes if the Module Closes, and if not, why not</returns>
        public EnumModuleStopResult StopModule(bool IgnoreUnsavedChanges = false, bool ForceClose = false);

        /// <summary>
        /// Instructs the Module to save all Unsaved Changed
        /// </summary>
        /// <returns>If the Saving was Successfull</returns>
        public bool SaveUnsavedChanges();

        /// <summary>
        /// Packs all needen Information for a Module into the correct DTO
        /// </summary>
        /// <returns>an instance of <see cref="ModuleInfoDTO"/> which is filled</returns>
        public ModuleInfo GetModuleInfo() {
            return new (ModuleGrouping, ModuleEnum, ModuleName, ModuleDescription);
        }

        #endregion
    }
}
