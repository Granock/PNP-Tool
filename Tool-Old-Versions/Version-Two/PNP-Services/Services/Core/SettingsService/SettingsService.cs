using PNP_Services.Databases.Core.SettingDB;
using PNP_Services.Databases.Core.SettingDB.Model;
using PNP_Services.Services.Core.SettingsService.Schema.Attributes;
using PNP_Services.Services.Core.SettingsService.Structure;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;

namespace PNP_Services.Services.Core.SettingsService
{
    public class SettingsService : ISettingsService
    {
        private readonly SettingContext _settingContext;

        public SettingsService(SettingContext settingContext)
        {
            _settingContext = settingContext;
            Type type = typeof(Settings);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!_settingContext.Settings.Any(s => s.SettingName == property.Name) && property.GetCustomAttribute<SettingRestriction>() != null)
                {
                    Setting s = new(property.Name, JsonSerializer.Serialize(property.GetCustomAttribute<SettingRestriction>().DefaultValue));
                    _settingContext.Add(s);
                }
            }
            _settingContext.SaveChanges();
        }
        
        #region IInterface

        public T GetSetting<T>(Expression<Func<Settings, T>> expr)
        {
            Tuple<string, object> SettingData = CheckExpression(expr);

            if (_settingContext.Settings.Any(x => x.SettingName == SettingData.Item1))
            { return JsonSerializer.Deserialize<T>(_settingContext.Settings.First(x => x.SettingName == SettingData.Item1).Value); }
            else
            {
                SetSetting(expr,(T)SettingData.Item2);
                return (T)SettingData.Item2;
            }
        }

        public void SetSetting<T>(Expression<Func<Settings,T>> expr, T value)
        {
            Tuple<string, object> SettingData = CheckExpression(expr);

            if (_settingContext.Settings.Any(s => s.SettingName == SettingData.Item1))
            {
                Setting setting = _settingContext.Settings.First(x => x.SettingName == SettingData.Item1);
                setting.Value = JsonSerializer.Serialize(value);
            }
            else
            {
                Setting setting = new();
                setting.SettingName = SettingData.Item1;
                setting.Value = JsonSerializer.Serialize(value);
                _settingContext.Add(setting);
            }
            _settingContext.SaveChanges();
        }

        public void SetSetting<T>(string Settingname, T value)
        {
            Setting setting = new();
            setting.SettingName = Settingname;
            setting.Value = JsonSerializer.Serialize(value);
            _settingContext.Add(setting);
            _settingContext.SaveChanges();
        }

        #endregion

        private static Tuple<string, object> CheckExpression<T>(Expression<Func<Settings, T>> expr)
        {
            if (expr.Body is not MemberExpression mexpr || mexpr.Member == null)
            { throw new ArgumentException(""); }
            return new Tuple<string, object>(mexpr.Member.Name, mexpr.Member.GetCustomAttribute<SettingRestriction>().DefaultValue);
        }
    }
}
