using PNP.Services.Service.Enumerators;
using PNP.Services.Service.Enumerators.Settings;
using PNP.Services.Service.Interfaces;
using PNP.Services.Service.Services.GlobalSettings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace PNP.Services.Service.Services.LanguageService
{
    public class LanguageService : ILanguageService
    {
        public Dictionary<string, string> GetLanguageTranslation(FormEnum form)
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            try
            {
                string LanguageFilePath = (string)GlobalProperties.GetSetting(SettingEnum.LanguageFilePath);
                string Language = ((LanguageEnum)GlobalProperties.GetSetting(SettingEnum.CurrentLanguageSelected)).ToString();
                string TranslationFilePath = LanguageFilePath+Language;
                if(!Directory.Exists(Path.GetDirectoryName(TranslationFilePath)))
                { Directory.CreateDirectory(Path.GetDirectoryName(TranslationFilePath)); }
                if (File.Exists(TranslationFilePath))
                {
                    List<Tuple<string, string>> LanguageElements =
                        XElement.Load(TranslationFilePath).Descendants(form.ToString())
                        .Descendants("Translation")
                        .Select(tr => new Tuple<string, string>(tr.Attribute("Key").Value, tr.Attribute("Value").Value))
                        .ToList();
                    foreach (Tuple<string, string> x in LanguageElements)
                    { Dict.Add(x.Item1, x.Item2); }
                }
            }
            catch(Exception)
            {

            }

            return Dict;
        }

        public bool WriteTranslation(List<Tuple<string, string>> tuples, FormEnum form,LanguageEnum language)
        {
            try
            {
                string LanguageFilePath = (string)GlobalProperties.GetSetting(SettingEnum.LanguageFilePath);
                XElement LanguageItem = new XElement(form.ToString(),
                tuples
                .Select(t => new Tuple<XAttribute, XAttribute>(new XAttribute("Key", t.Item1), new XAttribute("Value", t.Item2)))
                .Select(t => new XElement("Translation", t.Item1, t.Item2))
                .ToList());
                string TranslationFilePath = LanguageFilePath + language.ToString();
                if(!Directory.Exists(Path.GetDirectoryName(TranslationFilePath)))
                { Directory.CreateDirectory(Path.GetDirectoryName(TranslationFilePath)); }
                LanguageItem.Save(TranslationFilePath);
                return true;
            }
            catch(Exception)
            { return false; }
        }
    }
}
