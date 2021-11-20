using PNP.Core.Core.Forms.Infos;
using PNP.Services.Service.Services.GlobalSettings;

namespace PNP.Core.Core.Presenter.Info
{
    public class InfoPresenter : Presenter<IInfo>
    {
        public InfoPresenter()
        {
            SetView();
        }
        public override void StartPresenter()
        {
            _view.ShowDialog();
        }
        public void SetView()
        {
            _view = new FrmInfo();
            _view.SetCreatorEmail(GlobalProperties.GetSetting(Services.Service.Enumerators.Settings.SettingEnum.CreatorEmail).ToString());
        }
    }
}
