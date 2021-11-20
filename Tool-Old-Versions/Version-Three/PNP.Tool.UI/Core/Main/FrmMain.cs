using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PNP.Tool.Core.BaseObj;
using PNP.Tool.Core.Enums.Modules;
using PNP_UI.Base.Controls;

namespace PNP_UI.Core.Main {
    public partial class FrmMain : Form, IMainView
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Actions

        public Action<ModuleInfo> ModuleOpenClicked { get; set; }
        public Action<CoreMessage> SendMessage { get; set; }
        public Action WindowClosing { get; set; }
        public Action OpenSettings { get; set; }
        public Action OpenHelp { get; set; }
        public Action OpenInfo { get; set; }
        public Func<EnumModuleGrouping, Image> GetImageForGroup { get; set; }

        #endregion

        #region Module-List

        private IDictionary<EnumModuleGrouping, string> _GroupingControlMap;

        public bool AddModuleToList(ModuleInfo ToAdd)
        {
            try {
                if(_GroupingControlMap.ContainsKey(ToAdd.Grouping)) {
                    Control ctrl = PnModules.Controls.Find(_GroupingControlMap[ToAdd.Grouping], false).First();
                    if(ctrl.GetType() == typeof(CtrlModuleGrouping)) {
                        CtrlModuleGrouping GroupingCtrl = ctrl as CtrlModuleGrouping;
                        var x = GroupingCtrl.Modules;
                        x.Add(ToAdd);
                        GroupingCtrl.Modules = x;
                    }
                }

                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Ein Modul konnte nicht hinzugefügt werden.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        public bool ClearModuleList() {
            try {
                PnModules.Controls.Clear();
                _GroupingControlMap = new Dictionary<EnumModuleGrouping, string>();
                return true;
            } catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Die Module konnten nicht korrekt entfernt werden.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        public bool LoadModuleList(List<ModuleInfo> Modules) {
            try {
                ClearModuleList();

                //Create Controls For Groupings and Fill with the modules
                List<EnumModuleGrouping> AllGroups = Modules.Select(x => x.Grouping).Distinct().OrderByDescending(x => x.ToReadableString()).ToList();

                foreach (EnumModuleGrouping Value in AllGroups) {
                    CtrlModuleGrouping ctrl = new(Value, Modules.Where(x => x.Grouping == Value).OrderByDescending(x => x.Name).ToList(), GetImageForGroup?.Invoke(Value));
                    ctrl.Name = Value.ToString();
                    PnModules.Controls.Add(ctrl);
                    ctrl.Dock = DockStyle.Top;
                    ctrl.ModuleClicked += ModuleOpenClicked;
                    _GroupingControlMap.Add(Value, ctrl.Name);
                }

                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Die Module konnten nicht geladen werden.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        public bool RemoveModuleFromList(ModuleInfo ToRemove)
        {
            try {
                if (_GroupingControlMap.ContainsKey(ToRemove.Grouping)) {
                    Control ctrl = PnModules.Controls.Find(_GroupingControlMap[ToRemove.Grouping], false).First();
                    if (ctrl.GetType() == typeof(CtrlModuleGrouping)) {
                        CtrlModuleGrouping GroupingCtrl = ctrl as CtrlModuleGrouping;
                        var x = GroupingCtrl.Modules;
                        if (x.Any(t => t.Module == ToRemove.Module)) {
                            x.Where(t => t.Module == ToRemove.Module).ToList().ForEach(t => x.Remove(t));
                        }
                        GroupingCtrl.Modules = x;
                    }
                }

                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Ein Modul konnte nicht hinzugefügt werden.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        #endregion

        #region Window-Loading

        public bool ClearBottomWindow() {
            try {
                PnBottom.Controls.Clear();
                return true;
            } catch (Exception ex) {
                SendMessage?.Invoke(
                    new ("Error", 
                         "Die Menüleiste konnte nicht entfernt werden.", 
                         EnumMessageLevel.Error, 
                         new() { ex }));
                return false;
            }
        }

        public bool ClearMainWindow()
        {
            try {
                PnContent.Controls.Clear();
                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Das Modul konnte nicht entfernt werden.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        public bool LoadModuleIntoBottomWindow(Control BottomModuleControl)
        {
            try {
                PnBottom.Controls.Add(BottomModuleControl);
                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Die Menüleiste konnte nicht hinzugefügt werden.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        public bool LoadModuleIntoMainWindow(Control MainModuleControl)
        {
            try {
                PnContent.Controls.Add(MainModuleControl);
                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Das Modul konnte nicht geladen werden.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        #endregion

        #region Events

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        { WindowClosing?.Invoke(); }

        #endregion

        #region Status-Panel

        public bool LoadStatusControl(Control Status)
        {
            try {
                PnStatus.Controls.Add(Status);
                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Das füllen des StatusFensters war nicht erfolgreich.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        public bool ClearStatusPanel()
        {
            try {
                PnStatus.Controls.Clear();
                return true;
            }
            catch (Exception ex) {
                SendMessage?.Invoke(
                    new("Error",
                         "Das leeren des StatusFensters war nicht erfolgreich.",
                         EnumMessageLevel.Error,
                         new() { ex }));
                return false;
            }
        }

        #endregion
    }
}
