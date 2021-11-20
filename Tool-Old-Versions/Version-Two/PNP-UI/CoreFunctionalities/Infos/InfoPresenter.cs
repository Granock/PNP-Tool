namespace PNP_UI.CoreFunctionalities.Infos
{
    public class InfoPresenter : AbstactPresenter<IInfoView>
    {
        public InfoPresenter(IInfoView view)
        { _view = view; }

        public override void StartPresenter()
        {
            _view.SetCreatorEmail("");
            _view.ShowDialog();
        }
    }
}
