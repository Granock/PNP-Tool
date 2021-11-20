using System;
using System.Collections.Generic;

namespace PNP_Services.Services.Core.LanguageService
{
    public interface ILanguageService
    {
        /// <summary>
        /// Gets a translation for a specific Form
        /// </summary>
        /// <returns>A Dictonary of strings, where the key points to the field, and the value is the translation</returns>
        public Dictionary<string, string> GetLanguageTranslation();

        /// <summary>
        /// Writes the needed transaltionfile for the LanguageService
        /// </summary>
        /// <param name="tuples">A List if tuples. Key 1 is the fieldkey, Key 2 the translation</param>
        /// <param name="language">For which language the translation is</param>
        /// <returns></returns>
        public bool WriteTranslation(List<Tuple<string, string>> tuples, LanguageEnum language);
    }
}
