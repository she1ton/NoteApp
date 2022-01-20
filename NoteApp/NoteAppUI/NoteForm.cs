using System;
using NoteApp;
using System.Windows.Forms;
using System.Drawing;

namespace NoteAppUI
{
    public partial class NoteForm : Form
    {
        private Note _note = new Note();

        /// <summary>
        /// Временное хранилище данных
        /// </summary>
        public Note Note
        {
            get => _note;
            set
            {
                _note = value;
                TitleTextBox.Text = value.Name;
                NoteTextTextBox.Text = value.Text;
                CategoryComboBox.Text = value.Category.ToString();
                CreatedDateTimePicker.Value = value.CreatedTime;
                ModifiedDateTimePicker.Value = value.ModifiedTime;
            }
        }

        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        /// <summary>
        /// OK
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewNote();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cancel
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Создание новой заметки
        /// </summary>
        private void NewNote()
        {
                string text = TitleTextBox.Text;
                Note.Name = text;
                Note.Text = NoteTextTextBox.Text;
                Note.CreatedTime = CreatedDateTimePicker.Value;
                Note.ModifiedTime = ModifiedDateTimePicker.Value;
                Note.Category = (NoteCategory)CategoryComboBox.SelectedItem;
        }

        /// <summary>
        /// Окраска полей, если введено более 50 символов
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextBox.Text.Length > 50)
            {
                TitleTextBox.BackColor = Color.LightCoral;
            }
            else
            {
                TitleTextBox.BackColor = Color.White;
            }
        }
    }
}
