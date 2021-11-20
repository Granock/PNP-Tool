using PNP_UI.Base.Interfaces;

namespace PNP_UI.Base.Classes
{
    /// <summary>
    /// A Base Class for all Presenters, which have a View of Type <see cref="IBaseView"/>
    /// </summary>
    /// <typeparam name="T">The instance of <see cref="IBaseView"/> which is the correct interface for this Presenter</typeparam>
    public abstract class BasePresenter<T> where T : IBaseView 
    { 
        /// <summary>
        /// The Constructor for <see cref="BasePresenter{T}"/>
        /// </summary>
        /// <param name="view">The instance for <see cref="_View"/>, should bew automatically resolved by Dependency Injection</param>
        public BasePresenter(T view) {
            _View = view;
        }

        /// <summary>
        /// The View for this Presenter
        /// </summary>
        protected readonly  T _View;
    }
}
