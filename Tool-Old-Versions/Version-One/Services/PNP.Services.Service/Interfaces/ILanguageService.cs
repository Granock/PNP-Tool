using PNP.Services.Service.Enumerators;
using System;
using System.Collections.Generic;

namespace PNP.Services.Service.Interfaces
{
    public interface ILanguageService
    {
        /// <summary>
        /// Gets a translation for a specific Form
        /// </summary>
        /// <param name="form">the form for which a translation is asked</param>
        /// <returns>A Dictonary of strings, where the key points to the field, and the value is the translation</returns>
        public Dictionary<string,string> GetLanguageTranslation(FormEnum form);

        /// <summary>
        /// Writes the needed transaltionfile for the LanguageService
        /// </summary>
        /// <param name="tuples">A List if tuples. Key 1 is the fieldkey, Key 2 the translation</param>
        /// <param name="form">For which Form the Translation is</param>
        /// <param name="language">For which language the translation is</param>
        /// <returns></returns>
        public bool WriteTranslation(List<Tuple<string, string>> tuples, FormEnum form, LanguageEnum language);
    }
}
