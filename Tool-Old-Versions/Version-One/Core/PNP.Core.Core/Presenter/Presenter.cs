
namespace PNP.Core.Core.Presenter
{
    public abstract class Presenter<T> where T : IInterface 
    { 
        public  T _view;
        public abstract void StartPresenter();
    }
}
