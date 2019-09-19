using System;
using System.IO;
using System.Windows.Forms;
using DBCEditorExample.DataStores;
using DBCEditorExample.Structures;
using DBCLib.Exceptions;

namespace DBCEditorExample
{
    public partial class DBCEditor : Form
    {
        public DBCEditor()
        {
            InitializeComponent();
        }

        private void DBCEditor_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.InitFiles();
                DBCStores.LoadUsersEditorFiles();
            }
            catch (InvalidSignatureException exception)
            {
                MessageBox.Show("Invalid DBC Signature: " + "found '" + exception.Message + "' expected '" + DBCStores.Signature + "'.");
                Close();
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show("DBC file not found: " + exception.Message);
                Close();
            }

            ListBox_Users.Items.Clear();
            foreach (var user in DBCStores.Users.Records)
                ListBox_Users.Items.Add(user);

            ListBox_Users.SelectedIndex = 0;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (ListBox_Users.SelectedIndex == -1)
                return;

            var user = new Users()
            {
                Id = DBCStores.Users.MaxKey + 1,
                FirstName = "New",
                LastName = "User",
                BirthYear = 1970,
                Email = ""
            };

            try
            {
                ListBox_Users.Items.Add(user);
                DBCStores.Users.AddEntry(user.Id, user);

                // Select the new entry
                ListBox_Users.SelectedIndex = ListBox_Users.Items.Count - 1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (ListBox_Users.SelectedIndex == -1)
                return;

            try
            {
                var user = (Users)ListBox_Users.Items[ListBox_Users.SelectedIndex];

                --ListBox_Users.SelectedIndex;

                DBCStores.Users.RemoveEntry(user.Id);
                ListBox_Users.Items.Remove(user);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveUsersEditorFiles();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            MessageBox.Show("Success!", "Succesfully saved to the DBC File.");
        }

        private void ListBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_Users.SelectedIndex == -1)
                return;

            var user = (Users)ListBox_Users.Items[ListBox_Users.SelectedIndex];

            TextBox_Id.Text = user.Id.ToString();
            TextBox_BirthYear.Text = user.BirthYear.ToString();
            TextBox_FirstName.Text = user.FirstName;
            TextBox_LastName.Text = user.LastName;
            TextBox_Email.Text = user.Email;
        }

        private void TextBox_BirthYear_TextChanged(object sender, EventArgs e)
        {
            var user = (Users)ListBox_Users.Items[ListBox_Users.SelectedIndex];

            user.BirthYear = Convert.ToUInt32(TextBox_BirthYear.Text);

            DBCStores.Users.ReplaceEntry(user.Id, user);
            ListBox_Users.Items[ListBox_Users.SelectedIndex] = user;
        }

        private void TextBox_BirthYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Simple solution to prevent anything but numbers in the text box
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox_FirstName_TextChanged(object sender, EventArgs e)
        {
            var user = (Users)ListBox_Users.Items[ListBox_Users.SelectedIndex];

            user.FirstName = TextBox_FirstName.Text;

            DBCStores.Users.ReplaceEntry(user.Id, user);
            ListBox_Users.Items[ListBox_Users.SelectedIndex] = user;
        }

        private void TextBox_LastName_TextChanged(object sender, EventArgs e)
        {
            var user = (Users)ListBox_Users.Items[ListBox_Users.SelectedIndex];

            user.LastName = TextBox_LastName.Text;

            DBCStores.Users.ReplaceEntry(user.Id, user);
            ListBox_Users.Items[ListBox_Users.SelectedIndex] = user;
        }

        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            var user = (Users)ListBox_Users.Items[ListBox_Users.SelectedIndex];

            user.Email = TextBox_Email.Text;

            DBCStores.Users.ReplaceEntry(user.Id, user);
            ListBox_Users.Items[ListBox_Users.SelectedIndex] = user;
        }
    }
}
