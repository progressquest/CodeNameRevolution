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
            this.keepGenderCheckBox = new System.Windows.Forms.CheckBox();
            this.keepLastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.unselectAllCharactersButton = new System.Windows.Forms.Button();
            this.selectAllCharactersButton = new System.Windows.Forms.Button();
            this.currentCharacterActionButton = new System.Windows.Forms.Button();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.activateCharacterButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.currentCharacterActionLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.showDeletedCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteCharacterButton = new System.Windows.Forms.Button();
            this.editCharacterButton = new System.Windows.Forms.Button();
            this.createCharacterButton = new System.Windows.Forms.Button();
            this.refreshCharacterListButton = new System.Windows.Forms.Button();
            this.characterListPanel = new System.Windows.Forms.Panel();
            this.characterListListView = new System.Windows.Forms.ListView();
            this.characterSelectedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterFirstNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterLastNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterGenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.characterDeletedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.Size = new System.Drawing.Size(524, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.keepGenderCheckBox);
            this.tabPage1.Controls.Add(this.keepLastNameCheckBox);
            this.tabPage1.Controls.Add(this.unselectAllCharactersButton);
            this.tabPage1.Controls.Add(this.selectAllCharactersButton);
            this.tabPage1.Controls.Add(this.currentCharacterActionButton);
            this.tabPage1.Controls.Add(this.femaleRadioButton);
            this.tabPage1.Controls.Add(this.maleRadioButton);
            this.tabPage1.Controls.Add(this.activateCharacterButton);
            this.tabPage1.Controls.Add(this.lastNameTextBox);
            this.tabPage1.Controls.Add(this.lastNameLabel);
            this.tabPage1.Controls.Add(this.firstNameTextBox);
            this.tabPage1.Controls.Add(this.currentCharacterActionLabel);
            this.tabPage1.Controls.Add(this.firstNameLabel);
            this.tabPage1.Controls.Add(this.showDeletedCharactersCheckBox);
            this.tabPage1.Controls.Add(this.deleteCharacterButton);
            this.tabPage1.Controls.Add(this.editCharacterButton);
            this.tabPage1.Controls.Add(this.createCharacterButton);
            this.tabPage1.Controls.Add(this.refreshCharacterListButton);
            this.tabPage1.Controls.Add(this.characterListPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Characters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // keepGenderCheckBox
            // 
            this.keepGenderCheckBox.AutoSize = true;
            this.keepGenderCheckBox.Enabled = false;
            this.keepGenderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepGenderCheckBox.Location = new System.Drawing.Point(379, 268);
            this.keepGenderCheckBox.Name = "keepGenderCheckBox";
            this.keepGenderCheckBox.Size = new System.Drawing.Size(116, 17);
            this.keepGenderCheckBox.TabIndex = 18;
            this.keepGenderCheckBox.Text = "Don\'t Clear Gender";
            this.keepGenderCheckBox.UseVisualStyleBackColor = true;
            this.keepGenderCheckBox.CheckedChanged += new System.EventHandler(this.keepGenderCheckBox_CheckedChanged);
            // 
            // keepLastNameCheckBox
            // 
            this.keepLastNameCheckBox.AutoSize = true;
            this.keepLastNameCheckBox.Enabled = false;
            this.keepLastNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepLastNameCheckBox.Location = new System.Drawing.Point(245, 268);
            this.keepLastNameCheckBox.Name = "keepLastNameCheckBox";
            this.keepLastNameCheckBox.Size = new System.Drawing.Size(132, 17);
            this.keepLastNameCheckBox.TabIndex = 17;
            this.keepLastNameCheckBox.Text = "Don\'t Clear Last Name";
            this.keepLastNameCheckBox.UseVisualStyleBackColor = true;
            this.keepLastNameCheckBox.CheckedChanged += new System.EventHandler(this.keepLastNameCheckBox_CheckedChanged);
            // 
            // unselectAllCharactersButton
            // 
            this.unselectAllCharactersButton.Location = new System.Drawing.Point(183, 229);
            this.unselectAllCharactersButton.Name = "unselectAllCharactersButton";
            this.unselectAllCharactersButton.Size = new System.Drawing.Size(75, 23);
            this.unselectAllCharactersButton.TabIndex = 16;
            this.unselectAllCharactersButton.Text = "Unselect All";
            this.unselectAllCharactersButton.UseVisualStyleBackColor = true;
            // 
            // selectAllCharactersButton
            // 
            this.selectAllCharactersButton.Location = new System.Drawing.Point(101, 229);
            this.selectAllCharactersButton.Name = "selectAllCharactersButton";
            this.selectAllCharactersButton.Size = new System.Drawing.Size(75, 23);
            this.selectAllCharactersButton.TabIndex = 15;
            this.selectAllCharactersButton.Text = "Select All";
            this.selectAllCharactersButton.UseVisualStyleBackColor = true;
            // 
            // currentCharacterActionButton
            // 
            this.currentCharacterActionButton.Enabled = false;
            this.currentCharacterActionButton.Location = new System.Drawing.Point(200, 317);
            this.currentCharacterActionButton.Name = "currentCharacterActionButton";
            this.currentCharacterActionButton.Size = new System.Drawing.Size(111, 38);
            this.currentCharacterActionButton.TabIndex = 14;
            this.currentCharacterActionButton.Text = "Add Character";
            this.currentCharacterActionButton.UseVisualStyleBackColor = true;
            this.currentCharacterActionButton.Click += new System.EventHandler(this.currentCharacterActionButton_Click);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Enabled = false;
            this.femaleRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.femaleRadioButton.Location = new System.Drawing.Point(433, 292);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 13;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.femaleRadioButton_KeyDown);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Enabled = false;
            this.maleRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maleRadioButton.Location = new System.Drawing.Point(379, 292);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 12;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maleRadioButton_KeyDown);
            // 
            // activateCharacterButton
            // 
            this.activateCharacterButton.Location = new System.Drawing.Point(9, 179);
            this.activateCharacterButton.Name = "activateCharacterButton";
            this.activateCharacterButton.Size = new System.Drawing.Size(86, 36);
            this.activateCharacterButton.TabIndex = 11;
            this.activateCharacterButton.Text = "Activate Character(s)";
            this.activateCharacterButton.UseVisualStyleBackColor = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(245, 291);
            this.lastNameTextBox.MaxLength = 100;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.lastNameTextBox.TabIndex = 10;
            this.lastNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastNameTextBox_KeyDown);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastNameLabel.Location = new System.Drawing.Point(186, 294);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(65, 291);
            this.firstNameTextBox.MaxLength = 100;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.firstNameTextBox.TabIndex = 8;
            this.firstNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNameTextBox_KeyDown);
            // 
            // currentCharacterActionLabel
            // 
            this.currentCharacterActionLabel.AutoSize = true;
            this.currentCharacterActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCharacterActionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.currentCharacterActionLabel.Location = new System.Drawing.Point(8, 264);
            this.currentCharacterActionLabel.Name = "currentCharacterActionLabel";
            this.currentCharacterActionLabel.Size = new System.Drawing.Size(147, 20);
            this.currentCharacterActionLabel.TabIndex = 7;
            this.currentCharacterActionLabel.Text = "Create Character";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 294);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // showDeletedCharactersCheckBox
            // 
            this.showDeletedCharactersCheckBox.Location = new System.Drawing.Point(357, 229);
            this.showDeletedCharactersCheckBox.Name = "showDeletedCharactersCheckBox";
            this.showDeletedCharactersCheckBox.Size = new System.Drawing.Size(151, 23);
            this.showDeletedCharactersCheckBox.TabIndex = 5;
            this.showDeletedCharactersCheckBox.Text = "Show Deleted Characters";
            this.showDeletedCharactersCheckBox.UseVisualStyleBackColor = true;
            this.showDeletedCharactersCheckBox.CheckedChanged += new System.EventHandler(this.showDeletedCharactersCheckBox_CheckedChanged);
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
            this.createCharacterButton.Text = "Create New Character(s)";
            this.createCharacterButton.UseVisualStyleBackColor = true;
            this.createCharacterButton.Click += new System.EventHandler(this.createCharacterButton_Click);
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
            // characterSelectedHeader
            // 
            this.characterSelectedHeader.Text = "";
            this.characterSelectedHeader.Width = 22;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Revolution Content Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label currentCharacterActionLabel;
        private System.Windows.Forms.Button activateCharacterButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button currentCharacterActionButton;
        private System.Windows.Forms.Button unselectAllCharactersButton;
        private System.Windows.Forms.Button selectAllCharactersButton;
        private System.Windows.Forms.CheckBox keepGenderCheckBox;
        private System.Windows.Forms.CheckBox keepLastNameCheckBox;
    }
}

