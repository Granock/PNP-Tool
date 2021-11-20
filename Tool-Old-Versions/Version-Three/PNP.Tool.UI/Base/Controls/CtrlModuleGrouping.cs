using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PNP.Tool.Core.BaseObj;
using PNP.Tool.Core.Enums.Modules;

namespace PNP_UI.Base.Controls {
    public partial class CtrlModuleGrouping : UserControl
    {
        #region Publics
        [Category("Ansicht")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool Collapsed {
            get => PnButtons.Visible;
            set => PnButtons.Visible = value; 
        }
        public EnumModuleGrouping ModuleGrouping { 
            get => _Grouping; 
            set {
                _Grouping = value;
                BtnGroupingHead.Text = value.ToReadableString();
            } 
        }
        public ICollection<ModuleInfo> Modules { 
            get => _Modules.ToList(); 
            set => UpdateModules(value); 
        }
        public Action<ModuleInfo> ModuleClicked { get; set; }
        #endregion

        #region Privates

        private EnumModuleGrouping _Grouping;
        private readonly ICollection<ModuleInfo> _Modules;
        private readonly IDictionary<EnumModule,string> _ModuleControlConnection;
        
        #endregion

        public CtrlModuleGrouping()
        {
            InitializeComponent();
            _Modules = new List<ModuleInfo>();
            _ModuleControlConnection = new Dictionary<EnumModule, string>();
            PnButtons.Visible = false;
            PnButtons.Controls.Clear();
        }

        public CtrlModuleGrouping(EnumModuleGrouping grouping, ICollection<ModuleInfo> modules, Image image = null) : this() {
            ModuleGrouping = grouping;
            Modules = modules;
            PnButtons.Visible = false;
            if(image != null) {
                BtnGroupingHead.Image = image;
            }
        }

        private void UpdateModules(ICollection<ModuleInfo> list) {
            List<ModuleInfo> ToAdd = list.Where(x => !_Modules.Any(t => t.Module == x.Module)).ToList();
            List<ModuleInfo> ToRemove = _Modules.Where(x => !list.Any(t => t.Module == x.Module)).ToList();
            
            //Remove old Modules
            foreach (ModuleInfo DTO in ToRemove) {
                if (_ModuleControlConnection.ContainsKey(DTO.Module)) {
                    string ControlName = _ModuleControlConnection[DTO.Module];
                    var Controls = PnButtons.Controls.Find(ControlName, false);
                    Controls.ToList().ForEach(x => PnButtons.Controls.Remove(x));
                    Controls.ToList().ForEach(x => x.Dispose());
                    _ModuleControlConnection.Remove(DTO.Module);
                    _Modules.Remove(DTO);
                }
            }

            //Add new Modules
            foreach(ModuleInfo DTO in ToAdd) {
                Button newButton = new() {
                    Name = DTO.Module.ToString(),
                    Text = DTO.Name
                };
                newButton.Click += BtnClicked;
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
                newButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
                newButton.TextAlign = ContentAlignment.MiddleLeft;
                newButton.ImageAlign = ContentAlignment.MiddleLeft;
                newButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                if(DTO.Image != null) {
                    newButton.Image = DTO.Image;
                }
                newButton.Padding = new(10, 0, 0, 0);
                newButton.Size= new (newButton.Size.Width,30);
                newButton.Font = new(newButton.Font.FontFamily, 10f, newButton.Font.Style, newButton.Font.Unit, newButton.Font.GdiCharSet, newButton.Font.GdiVerticalFont);
                PnButtons.Controls.Add(newButton);
                newButton.Dock = DockStyle.Top;
                ToolTip.SetToolTip(newButton, DTO.Description);
                _ModuleControlConnection.Add(DTO.Module, newButton.Name);
                _Modules.Add(DTO);
            }

            Invalidate();
        }

        private void BtnClicked(object sender, EventArgs e) {
            if(sender.GetType() == typeof(Button)) {
                var Btn = sender as Button;
                if(_ModuleControlConnection.Any(x => x.Value == Btn.Name)) {
                    EnumModule Module = _ModuleControlConnection.First(x => x.Value == Btn.Name).Key;
                    if(_Modules.Any(x => x.Module == Module)) {
                        ModuleClicked?.Invoke(_Modules.First(x => x.Module == Module));
                    }
                }
            }
        }

        private void BtnGroupingHead_Click(object sender, EventArgs e) {
            PnButtons.Visible = !PnButtons.Visible;
        }
    }
}
