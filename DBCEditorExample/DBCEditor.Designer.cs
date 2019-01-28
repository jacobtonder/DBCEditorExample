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
            this.SuspendLayout();
            // 
            // ListBox_Users
            // 
            this.ListBox_Users.FormattingEnabled = true;
            this.ListBox_Users.Location = new System.Drawing.Point(13, 13);
            this.ListBox_Users.Name = "ListBox_Users";
            this.ListBox_Users.Size = new System.Drawing.Size(226, 355);
            this.ListBox_Users.TabIndex = 0;
            // 
            // DBCEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 373);
            this.Controls.Add(this.ListBox_Users);
            this.Name = "DBCEditor";
            this.Text = "DBC Editor";
            this.Load += new System.EventHandler(this.DBCEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Users;
    }
}

