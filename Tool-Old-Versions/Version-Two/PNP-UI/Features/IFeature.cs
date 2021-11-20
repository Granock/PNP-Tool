using System;
using System.Windows.Forms;

namespace PNP_UI.Features
{
    public interface IFeature
    {
        /// <summary>
        /// Action is Called, when the Feature by itself wants to close
        /// </summary>
        public Action FeatureCloses { get; set; }

        /// <summary>
        /// Signals the Feature, that it need to save and close
        /// </summary>
        public void CloseFeature();

        /// <summary>
        /// Signales the Feature, that it can start
        /// </summary>
        public void StartFeature();

        /// <summary>
        /// Gets Titel and Description
        /// </summary>
        /// <returns>retruns Tuple, Key 1 = Title, Key2 = Description</returns>
        public FeatureInfoDTO GetFeatureInfo();

        /// <summary>
        /// Gives the Feature a ref to the Main Panel to Load its Control into
        /// </summary>
        /// <param name="window">the Panel, into which it needs to load its Controls</param>
        public void LoadFeatureIntoWindow(ref Panel window);
    }
}
