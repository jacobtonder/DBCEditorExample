using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            ListBox_Users.Items.Clear();
            foreach (Users t in DBCStores.Users.Records)
                ListBox_Users.Items.Add(t);

            ListBox_Users.SelectedIndex = 0;
        }
    }
}
