using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            catch (InvalidSignatureException)
            {
                MessageBox.Show("Invalid DBC Signature: " + DBCStores.Signature);
                Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("DBC file not found: " + ex.Message);
                Close();
            }

            ListBox_Users.Items.Clear();
            foreach (Users user in DBCStores.Users.Records)
                ListBox_Users.Items.Add(user);

            ListBox_Users.SelectedIndex = 0;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (ListBox_Users.SelectedIndex == -1)
                return;

            Users user = new Users()
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
                Users user = (Users)ListBox_Users.Items[ListBox_Users.SelectedIndex];

                --ListBox_Users.SelectedIndex;

                DBCStores.Users.RemoveEntry(user.Id);
                ListBox_Users.Items.Remove(user);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
