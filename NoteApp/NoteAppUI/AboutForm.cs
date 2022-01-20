using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Форма About.
    /// </summary>
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Копирование почты при нажатии.
        /// </summary>
        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText("gudkov101001@gmail.com");
        }

        /// <summary>
        /// Переход в GitHub при нажатии.
        /// </summary>
        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Fy0dal/NoteApp");
        }

        private void AboutForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
