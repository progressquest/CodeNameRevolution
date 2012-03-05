namespace RevolutionContentManager
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.showDeletedCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteCharacterButton = new System.Windows.Forms.Button();
            this.editCharacterButton = new System.Windows.Forms.Button();
            this.createCharacterButton = new System.Windows.Forms.Button();
            this.refreshCharacterListButton = new System.Windows.Forms.Button();
            this.characterListPanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.characterListListView = new System.Windows.Forms.ListView();
            this.characterIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterFirstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterLastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterGenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterDeletedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterSelectedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.characterListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.showDeletedCharactersCheckBox);
            this.tabPage1.Controls.Add(this.deleteCharacterButton);
            this.tabPage1.Controls.Add(this.editCharacterButton);
            this.tabPage1.Controls.Add(this.createCharacterButton);
            this.tabPage1.Controls.Add(this.refreshCharacterListButton);
            this.tabPage1.Controls.Add(this.characterListPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Characters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // showDeletedCharactersCheckBox
            // 
            this.showDeletedCharactersCheckBox.Location = new System.Drawing.Point(6, 175);
            this.showDeletedCharactersCheckBox.Name = "showDeletedCharactersCheckBox";
            this.showDeletedCharactersCheckBox.Size = new System.Drawing.Size(94, 50);
            this.showDeletedCharactersCheckBox.TabIndex = 5;
            this.showDeletedCharactersCheckBox.Text = "Show Deleted Characters";
            this.showDeletedCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteCharacterButton
            // 
            this.deleteCharacterButton.Location = new System.Drawing.Point(9, 136);
            this.deleteCharacterButton.Name = "deleteCharacterButton";
            this.deleteCharacterButton.Size = new System.Drawing.Size(86, 36);
            this.deleteCharacterButton.TabIndex = 4;
            this.deleteCharacterButton.Text = "Delete Character(s)";
            this.deleteCharacterButton.UseVisualStyleBackColor = true;
            // 
            // editCharacterButton
            // 
            this.editCharacterButton.Location = new System.Drawing.Point(9, 93);
            this.editCharacterButton.Name = "editCharacterButton";
            this.editCharacterButton.Size = new System.Drawing.Size(86, 36);
            this.editCharacterButton.TabIndex = 3;
            this.editCharacterButton.Text = "Edit Character";
            this.editCharacterButton.UseVisualStyleBackColor = true;
            // 
            // createCharacterButton
            // 
            this.createCharacterButton.Location = new System.Drawing.Point(9, 50);
            this.createCharacterButton.Name = "createCharacterButton";
            this.createCharacterButton.Size = new System.Drawing.Size(86, 36);
            this.createCharacterButton.TabIndex = 2;
            this.createCharacterButton.Text = "Create New Character";
            this.createCharacterButton.UseVisualStyleBackColor = true;
            // 
            // refreshCharacterListButton
            // 
            this.refreshCharacterListButton.Location = new System.Drawing.Point(9, 7);
            this.refreshCharacterListButton.Name = "refreshCharacterListButton";
            this.refreshCharacterListButton.Size = new System.Drawing.Size(86, 36);
            this.refreshCharacterListButton.TabIndex = 1;
            this.refreshCharacterListButton.Text = "Refresh List";
            this.refreshCharacterListButton.UseVisualStyleBackColor = true;
            this.refreshCharacterListButton.Click += new System.EventHandler(this.refreshCharacterListButton_Click);
            // 
            // characterListPanel
            // 
            this.characterListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.characterListPanel.Controls.Add(this.characterListListView);
            this.characterListPanel.Location = new System.Drawing.Point(101, 7);
            this.characterListPanel.Name = "characterListPanel";
            this.characterListPanel.Size = new System.Drawing.Size(407, 218);
            this.characterListPanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // characterListListView
            // 
            this.characterListListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.characterListListView.CheckBoxes = true;
            this.characterListListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.characterSelectedHeader,
            this.characterIDHeader,
            this.characterFirstNameHeader,
            this.characterLastNameHeader,
            this.characterGenderHeader,
            this.characterDeletedHeader});
            this.characterListListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterListListView.GridLines = true;
            this.characterListListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.characterListListView.HideSelection = false;
            this.characterListListView.Location = new System.Drawing.Point(0, 0);
            this.characterListListView.Name = "characterListListView";
            this.characterListListView.Size = new System.Drawing.Size(403, 214);
            this.characterListListView.TabIndex = 0;
            this.characterListListView.UseCompatibleStateImageBehavior = false;
            this.characterListListView.View = System.Windows.Forms.View.Details;
            // 
            // characterIDHeader
            // 
            this.characterIDHeader.Text = "ID";
            this.characterIDHeader.Width = 40;
            // 
            // characterFirstNameHeader
            // 
            this.characterFirstNameHeader.Text = "First Name";
            this.characterFirstNameHeader.Width = 100;
            // 
            // characterLastNameHeader
            // 
            this.characterLastNameHeader.Text = "Last Name";
            this.characterLastNameHeader.Width = 100;
            // 
            // characterGenderHeader
            // 
            this.characterGenderHeader.Text = "Gender";
            // 
            // characterDeletedHeader
            // 
            this.characterDeletedHeader.Text = "Deleted";
            // 
            // characterSelectedHeader
            // 
            this.characterSelectedHeader.Text = "";
            this.characterSelectedHeader.Width = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 265);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Revolution Content Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.characterListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel characterListPanel;
        private System.Windows.Forms.Button refreshCharacterListButton;
        private System.Windows.Forms.Button deleteCharacterButton;
        private System.Windows.Forms.Button editCharacterButton;
        private System.Windows.Forms.Button createCharacterButton;
        private System.Windows.Forms.CheckBox showDeletedCharactersCheckBox;
        private System.Windows.Forms.ListView characterListListView;
        private System.Windows.Forms.ColumnHeader characterIDHeader;
        private System.Windows.Forms.ColumnHeader characterFirstNameHeader;
        private System.Windows.Forms.ColumnHeader characterLastNameHeader;
        private System.Windows.Forms.ColumnHeader characterGenderHeader;
        private System.Windows.Forms.ColumnHeader characterDeletedHeader;
        private System.Windows.Forms.ColumnHeader characterSelectedHeader;
    }
}

