using System.Windows.Forms;

namespace PNP_UI.Base.Interfaces
{
    /// <summary>
    /// An interface which all <see cref="Form"/> have to implement
    /// </summary>
    public interface IForm
    {
        /// <summary>
        /// Shows the Form, without stopping the calling functions
        /// </summary>
        public void Show();

        /// <summary>
        /// Closes the Form
        /// </summary>
        public void Close();

        /// <summary>
        /// Shows the Form and waits for the Result, before further executing the calling function 
        /// </summary>
        /// <returns>a <see cref="System.Windows.Forms.DialogResult"/> which desribes the Result</returns>
        public DialogResult ShowDialog();

        /// <summary>
        /// A <see cref="System.Windows.Forms.DialogResult"/> Which describes the Result of the Window.
        /// Setting this Properties automatically closes the Form, as if <see cref="Close"/> was called
        /// </summary>
        public DialogResult DialogResult { get; set; }
    }
}
