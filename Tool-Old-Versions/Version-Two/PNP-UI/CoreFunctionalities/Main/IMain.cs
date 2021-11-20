using PNP_UI.Features;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PNP_UI.CoreFunctionalities.Main
{
    public interface IMain : IAbstractInterface
    {
        #region Actions and Fncs
        Action SettingsClicked { get; set; }
        Action InfoClicked { get; set; }
        Action<FeatureInfoDTO> FeatureSelectedChanged { get; set; }
        #endregion

        #region GetControls
        public ref Panel GetFeaturePanel();
        #endregion

        public void SetTranslation(Dictionary<string, string> translation);
        public void SetFeatureList(List<FeatureInfoDTO> featureInfos);
    }
}
