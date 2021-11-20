using System;

namespace PNP_UI.Features
{
    /// <summary>
    /// Short Object, to make ModuleSelection easier
    /// </summary>
    public class FeatureInfoDTO
    {
        public FeatureInfoDTO(Guid g, string displayName, string description)
        {
            FeatureIdentifier = g;
            DisplayName = displayName;
            Description = description;
        }
        /// <summary>
        /// Unique Identifier of a Module
        /// </summary>
        public Guid FeatureIdentifier { get; set; }
        /// <summary>
        /// Name to Display in SelectionBox
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Description of the Module, optional
        /// </summary>
        public string Description { get; set; }
    }

}
