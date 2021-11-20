namespace PNP_UI
{
    public abstract class AbstactPresenter<T> where T : IAbstractInterface 
    { 
        public  T _view;
        public abstract void StartPresenter();
    }
}
