using PNP_Services;
using PNP_Services.Services.Core.LoggerService;
using System;
using System.Collections.Generic;

namespace PNP_UI.Features
{
    public static class FeatureProvider
    {
        public static IFeature CurrentFeature { get; private set; }
        private static List<FeatureInfoDTO> AvailableFeatures;

        private static readonly ILogger _Logger;
        private static readonly Dictionary<Guid, IFeature> _FeatureDictionaire = new();

        static FeatureProvider()
        {
            _Logger = GlobalServiceProvider.GetRequiredService<ILogger>();
            _Logger.SetNormSender("ModuleProvider");
        }

        public static List<FeatureInfoDTO> GetAllAvailableFeatures()
        {
            if (AvailableFeatures != null)
            { return AvailableFeatures; }

            #region Registering all Modules
            AvailableFeatures = new();
            #endregion

            return AvailableFeatures;
        }

        public static bool LoadFeature(FeatureInfoDTO infoDTO)
        {
            try
            {
                if (CurrentFeature != null && _FeatureDictionaire.ContainsKey(infoDTO.FeatureIdentifier) 
                    && _FeatureDictionaire[infoDTO.FeatureIdentifier] != CurrentFeature)
                {
                    CurrentFeature?.CloseFeature();
                    CurrentFeature = _FeatureDictionaire[infoDTO.FeatureIdentifier];
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                _Logger.LogError(ex);
                return false;
            }
        }

        private static void RegisterFeature(IFeature feature)
        {
            try
            {
                Guid g = Guid.NewGuid();

                while (_FeatureDictionaire.ContainsKey(g))
                { g = Guid.NewGuid(); }

                _FeatureDictionaire.Add(g, feature);
                AvailableFeatures.Add(feature.GetFeatureInfo());
            }
            catch (Exception ex)
            { _Logger.LogError(ex); }
        }
    }
}
