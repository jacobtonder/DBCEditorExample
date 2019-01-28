namespace DBCEditorExample
{
    partial class DBCEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_Users = new System.Windows.Forms.ListBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.TextBox_FirstName = new System.Windows.Forms.TextBox();
            this.TextBox_LastName = new System.Windows.Forms.TextBox();
            this.Label_Id = new System.Windows.Forms.Label();
            this.Label_BirthYear = new System.Windows.Forms.Label();
            this.TextBox_Id = new System.Windows.Forms.TextBox();
            this.TextBox_BirthYear = new System.Windows.Forms.TextBox();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.Label_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox_Users
            // 
            this.ListBox_Users.FormattingEnabled = true;
            this.ListBox_Users.Location = new System.Drawing.Point(13, 13);
            this.ListBox_Users.Name = "ListBox_Users";
            this.ListBox_Users.Size = new System.Drawing.Size(156, 186);
            this.ListBox_Users.TabIndex = 0;
            this.ListBox_Users.SelectedIndexChanged += new System.EventHandler(this.ListBox_Users_SelectedIndexChanged);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(12, 205);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 1;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(93, 205);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 2;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(243, 205);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(75, 23);
            this.Button_Save.TabIndex = 3;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.AutoSize = true;
            this.Label_FirstName.Location = new System.Drawing.Point(200, 52);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(57, 13);
            this.Label_FirstName.TabIndex = 4;
            this.Label_FirstName.Text = "First Name";
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.Location = new System.Drawing.Point(301, 52);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(58, 13);
            this.Label_LastName.TabIndex = 5;
            this.Label_LastName.Text = "Last Name";
            // 
            // TextBox_FirstName
            // 
            this.TextBox_FirstName.Location = new System.Drawing.Point(175, 68);
            this.TextBox_FirstName.Name = "TextBox_FirstName";
            this.TextBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.TextBox_FirstName.TabIndex = 6;
            // 
            // TextBox_LastName
            // 
            this.TextBox_LastName.Location = new System.Drawing.Point(281, 68);
            this.TextBox_LastName.Name = "TextBox_LastName";
            this.TextBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.TextBox_LastName.TabIndex = 7;
            // 
            // Label_Id
            // 
            this.Label_Id.AutoSize = true;
            this.Label_Id.Location = new System.Drawing.Point(214, 9);
            this.Label_Id.Name = "Label_Id";
            this.Label_Id.Size = new System.Drawing.Size(16, 13);
            this.Label_Id.TabIndex = 8;
            this.Label_Id.Text = "Id";
            // 
            // Label_BirthYear
            // 
            this.Label_BirthYear.AutoSize = true;
            this.Label_BirthYear.Location = new System.Drawing.Point(304, 9);
            this.Label_BirthYear.Name = "Label_BirthYear";
            this.Label_BirthYear.Size = new System.Drawing.Size(53, 13);
            this.Label_BirthYear.TabIndex = 9;
            this.Label_BirthYear.Text = "Birth Year";
            // 
            // TextBox_Id
            // 
            this.TextBox_Id.Enabled = false;
            this.TextBox_Id.Location = new System.Drawing.Point(175, 25);
            this.TextBox_Id.Name = "TextBox_Id";
            this.TextBox_Id.ReadOnly = true;
            this.TextBox_Id.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Id.TabIndex = 10;
            // 
            // TextBox_BirthYear
            // 
            this.TextBox_BirthYear.Location = new System.Drawing.Point(281, 25);
            this.TextBox_BirthYear.Name = "TextBox_BirthYear";
            this.TextBox_BirthYear.Size = new System.Drawing.Size(100, 20);
            this.TextBox_BirthYear.TabIndex = 11;
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.Location = new System.Drawing.Point(175, 107);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(206, 20);
            this.TextBox_Email.TabIndex = 12;
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Location = new System.Drawing.Point(262, 91);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(32, 13);
            this.Label_Email.TabIndex = 13;
            this.Label_Email.Text = "Email";
            // 
            // DBCEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(392, 240);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.TextBox_BirthYear);
            this.Controls.Add(this.TextBox_Id);
            this.Controls.Add(this.Label_BirthYear);
            this.Controls.Add(this.Label_Id);
            this.Controls.Add(this.TextBox_LastName);
            this.Controls.Add(this.TextBox_FirstName);
            this.Controls.Add(this.Label_LastName);
            this.Controls.Add(this.Label_FirstName);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.ListBox_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DBCEditor";
            this.Text = "DBC Editor";
            this.Load += new System.EventHandler(this.DBCEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Users;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.TextBox TextBox_FirstName;
        private System.Windows.Forms.TextBox TextBox_LastName;
        private System.Windows.Forms.Label Label_Id;
        private System.Windows.Forms.Label Label_BirthYear;
        private System.Windows.Forms.TextBox TextBox_Id;
        private System.Windows.Forms.TextBox TextBox_BirthYear;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.Label Label_Email;
    }
}

