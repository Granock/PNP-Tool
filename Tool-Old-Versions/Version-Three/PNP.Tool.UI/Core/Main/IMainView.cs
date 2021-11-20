using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PNP.Tool.Core.BaseObj;
using PNP.Tool.Core.Enums.Modules;
using PNP_UI.Base.Interfaces;

namespace PNP_UI.Core.Main {
    public interface IMainView : IBaseView
    {
        #region Actions

        /// <summary>
        /// Called, if a Module should be opened
        /// </summary>
        public Action<ModuleInfo> ModuleOpenClicked { get; set; }

        /// <summary>
        /// Called if a Message should be Displayed to the User
        /// </summary>
        public Action<CoreMessage> SendMessage { get; set; }

        /// <summary>
        /// Invoked, when the Window Closes, See: <see cref="Form.OnClosing(System.ComponentModel.CancelEventArgs)"/> 
        /// </summary>
        public Action WindowClosing { get; set; }

        /// <summary>
        /// Invoked when the User wants to open the Settings Window
        /// </summary>
        public Action OpenSettings { get; set; }

        /// <summary>
        /// Invoked when the User wants to open the Help Window
        /// </summary>
        public Action OpenHelp { get; set; }

        /// <summary>
        /// Invoked when the User wants to open the Info Window
        /// </summary>
        public Action OpenInfo { get; set; }

        /// <summary>
        /// Gets an Image for a Group if available
        /// </summary>
        public Func<EnumModuleGrouping, Image> GetImageForGroup { get; set; }
        
        #endregion

        #region Functions

        /// <summary>
        /// Loads the Buttons for the Modules
        /// </summary>
        /// <param name="Modules">The List of Modules</param>
        /// <returns>If it was a success</returns>
        public bool LoadModuleList(List<ModuleInfo> Modules);

        /// <summary>
        /// Clears the ModuleList and removes the associated Buttons
        /// </summary>
        /// <returns>If this operation was a success</returns>
        public bool ClearModuleList();

        /// <summary>
        /// Removes a Module From the List without generating a completely new List
        /// </summary>
        /// <param name="ToRemove">The Module which needs to be removed</param>
        /// <returns>If the Module was successfully removed</returns>
        public bool RemoveModuleFromList(ModuleInfo ToRemove);

        /// <summary>
        /// Adds a Module to the List
        /// </summary>
        /// <param name="ToAdd">The Module which needs to be added</param>
        /// <returns>If the Module could be added successfully</returns>
        public bool AddModuleToList(ModuleInfo ToAdd);

        /// <summary>
        /// Loads the <see cref="Control"/> for the Module into the Main Window
        /// </summary>
        /// <param name="MainModuleControl">The <see cref="Control"/> which has to be loaded</param>
        /// <returns>Weather it was a Success</returns>
        public bool LoadModuleIntoMainWindow(Control MainModuleControl);

        /// <summary>
        /// Removes all <see cref="Control"/> from the MainWindow
        /// </summary>
        /// <returns>If the clearing was a success</returns>
        public bool ClearMainWindow();

        /// <summary>
        /// Loads the <see cref="Control"/> for the Module into the Bottom Window
        /// </summary>
        /// <param name="BottomModuleControl">The <see cref="Control"/> which has to be loaded</param>
        /// <returns>Weather it was a Success</returns>
        public bool LoadModuleIntoBottomWindow(Control BottomModuleControl);

        /// <summary>
        /// Removes all <see cref="Control"/> from the Bottom Window
        /// </summary>
        /// <returns>If the clearing was a success</returns>
        public bool ClearBottomWindow();

        /// <summary>
        /// Loads a Control into the Status-Panel
        /// </summary>
        /// <param name="Status">The StatusColtrol</param>
        /// <returns>If the loading was a success</returns>
        public bool LoadStatusControl(Control Status);

        /// <summary>
        /// Clears the StatusPanel
        /// </summary>
        /// <returns>If the clearing was successful</returns>
        public bool ClearStatusPanel();
        #endregion
    }
}
