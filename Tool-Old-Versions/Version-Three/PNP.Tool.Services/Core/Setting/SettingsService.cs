using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using PNP.Tool.Models.Core;
using PNP.Tool.Services.Core.Setting.Schema;
using PNP.Tool.Services.Core.Setting.Structure;

namespace PNP.Tool.Services.Core.Setting {
    public class SettingsService : CoreService,ISettingsService
    {
        public SettingsService()
        {
            using var db = GetDatabase();
            Type type = typeof(Settings);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!db.Query<SettingEntry>().Any(s => s.SettingName == property.Name) && property.GetCustomAttribute<SettingEntryAttribute>() != null)
                {
                    SettingEntry s = new(property.Name, JsonSerializer.Serialize(property.GetCustomAttribute<SettingEntryAttribute>().DefaultValue));
                    db.Add(s);
                }
            }
            db.SaveChanges();
        }
        
        #region IInterface

        public T GetSetting<T>(Expression<Func<Settings, T>> expr)
        {
            using var db = GetDatabase();
            Tuple<string, object> SettingData = CheckExpression(expr);

            if (db.Query<SettingEntry>().Any(x => x.SettingName == SettingData.Item1))
            { return JsonSerializer.Deserialize<T>(db.Query<SettingEntry>().First(x => x.SettingName == SettingData.Item1).Value); }
            else
            {
                SetSetting(expr,(T)SettingData.Item2);
                return (T)SettingData.Item2;
            }
        }

        public void SetSetting<T>(Expression<Func<Settings,T>> expr, T value)
        {
            using var db = GetDatabase();
            Tuple<string, object> SettingData = CheckExpression(expr);

            if (db.Query<SettingEntry>().Any(s => s.SettingName == SettingData.Item1))
            {
                SettingEntry setting = db.Query<SettingEntry>().First(x => x.SettingName == SettingData.Item1);
                setting.Value = JsonSerializer.Serialize(value);
            }
            else
            {
                SettingEntry setting = new();
                setting.SettingName = SettingData.Item1;
                setting.Value = JsonSerializer.Serialize(value);
                db.Add(setting);
            }
            db.SaveChanges();
        }

        #endregion

        private static Tuple<string, object> CheckExpression<T>(Expression<Func<Settings, T>> expr)
        {
            if (expr.Body is not MemberExpression mexpr || mexpr.Member == null)
            { throw new ArgumentException(""); }
            string name = $"{mexpr.Member.DeclaringType.Name}-{mexpr.Member.Name}";
            return new Tuple<string, object>(name, mexpr.Member.GetCustomAttribute<SettingEntryAttribute>().DefaultValue);
        }
    }
}
