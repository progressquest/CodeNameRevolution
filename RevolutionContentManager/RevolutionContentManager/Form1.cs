using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RevolutionContentManager.CharacterService;
using RevolutionContentManagerDAL;

namespace RevolutionContentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string emptyString = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshCharacterList();
            showDeletedCharactersCheckBox.Checked = CharacterTool.GetShowDeletedCharacters();
            keepLastNameCheckBox.Checked = CharacterTool.GetDontClearLastName();
            keepGenderCheckBox.Checked = CharacterTool.GetDontClearGender();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        #region CharacterConstants

        private const string createCharacterText = "Create Character";
        private const string createNewCharactersText = "Create New Character(s)";
        private const string finishNewCharactersText = "Done Creating Character(s)";
        private const string addCharacterText = "Add Character";

        private const string editCharacterText = "Edit Character";
        private const string saveCharacterEditText = "Save Changes";

        private const string subItemNameId = "ID";
        private const string subItemNameFirstName = "First Name";
        private const string subItemNameLastName = "Last Name";
        private const string subItemNameGender = "Gender";
        private const string subItemNameDeleted = "Deleted";

        #endregion CharacterConstants

        #region CharacterTab

        private void refreshCharacterListButton_Click(object sender, EventArgs e)
        {
            this.refreshCharacterList();
        }

        private void refreshCharacterList()
        {
            this.characterListListView.Items.Clear();

            List<Character> characters = CharacterTool.GetAllCharacters();

            bool showDeleted = CharacterTool.GetShowDeletedCharacters();

            foreach (var character in characters)
            {
                if (showDeleted || character.Deleted == false)
                {
                    ListViewItem characterItem = new ListViewItem();
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                    subitem.Name = subItemNameId;
                    subitem.Text = character.ID.ToString();
                    characterItem.SubItems.Add(subitem);

                    subitem = new ListViewItem.ListViewSubItem();
                    subitem.Name = subItemNameFirstName;
                    subitem.Text = character.FirstName;
                    characterItem.SubItems.Add(subitem);

                    subitem = new ListViewItem.ListViewSubItem();
                    subitem.Name = subItemNameLastName;
                    subitem.Text = character.LastName;
                    characterItem.SubItems.Add(subitem);

                    subitem = new ListViewItem.ListViewSubItem();
                    subitem.Name = subItemNameGender;
                    subitem.Text = character.Gender ? "Male" : "Female";
                    characterItem.SubItems.Add(subitem);

                    subitem = new ListViewItem.ListViewSubItem();
                    subitem.Name = subItemNameDeleted;
                    subitem.Text = character.Deleted.ToString();
                    characterItem.SubItems.Add(subitem);

                    this.characterListListView.Items.Add(characterItem);
                }
            }
        }

        private void createCharacterButton_Click(object sender, EventArgs e)
        {
            switch (createCharacterButton.Text){

                case createNewCharactersText:
                    EnableCreateCharacter();
                    break;
                case finishNewCharactersText:
                    DisableCreateCharacter();
                    break;
            }
        }

        private void EnableCreateCharacter()
        {
            createCharacterButton.Text = finishNewCharactersText;

            refreshCharacterListButton.Enabled = false;
            editCharacterButton.Enabled = false;
            deleteCharacterButton.Enabled = false;
            undeleteCharacterButton.Enabled = false;
            selectAllCharactersButton.Enabled = false;
            unselectAllCharactersButton.Enabled = false;
            characterListListView.CheckBoxes = false;
            
            currentCharacterActionLabel.Text = createCharacterText;
            currentCharacterActionLabel.ForeColor = SystemColors.ControlText;
            currentCharacterActionButton.Text = addCharacterText;
            currentCharacterActionButton.Enabled = true;
            firstNameLabel.ForeColor = SystemColors.ControlText;
            firstNameTextBox.Enabled = true;
            lastNameLabel.ForeColor = SystemColors.ControlText;
            lastNameTextBox.Enabled = true;
            keepLastNameCheckBox.Enabled = true;
            maleRadioButton.Enabled = true;
            femaleRadioButton.Enabled = true;
            keepGenderCheckBox.Enabled = true;

            firstNameTextBox.Focus();
        }

        private void DisableCreateCharacter()
        {
            createCharacterButton.Text = createNewCharactersText;

            refreshCharacterListButton.Enabled = true;
            editCharacterButton.Enabled = true;
            deleteCharacterButton.Enabled = true;
            undeleteCharacterButton.Enabled = true;
            selectAllCharactersButton.Enabled = true;
            unselectAllCharactersButton.Enabled = true;
            characterListListView.CheckBoxes = true;

            currentCharacterActionLabel.ForeColor = SystemColors.ControlLight;
            currentCharacterActionButton.Enabled = false;
            firstNameLabel.ForeColor = SystemColors.ControlLight;
            firstNameTextBox.Enabled = false;
            firstNameTextBox.Text = emptyString;
            lastNameLabel.ForeColor = SystemColors.ControlLight;
            lastNameTextBox.Enabled = false;
            lastNameTextBox.Text = emptyString;
            keepLastNameCheckBox.Enabled = false;
            maleRadioButton.Enabled = false;
            maleRadioButton.Checked = false;
            femaleRadioButton.Enabled = false;
            femaleRadioButton.Checked = false;
            keepGenderCheckBox.Enabled = false;
        }

        private void currentCharacterActionButton_Click(object sender, EventArgs e)
        {
            switch (currentCharacterActionButton.Text)
            {
                case addCharacterText:
                    AddCharacter();
                    break;
                case saveCharacterEditText:
                    EditCharacter();
                    break;
            }
        }

        private void AddCharacter()
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || (!maleRadioButton.Checked && !femaleRadioButton.Checked))
            {
                MessageBox.Show("You must provide a First Name, Last Name, and choose a gender.");
            }
            else
            {
                Character ch = new Character
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Gender = maleRadioButton.Checked ? true : false,
                    Deleted = false
                };

                CharacterTool.SaveCharacter(ch);
                firstNameTextBox.Text = "";
                if(!CharacterTool.GetDontClearLastName())
                {
                    lastNameTextBox.Text = "";
                }
                if (!CharacterTool.GetDontClearGender())
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = false;
                }
                refreshCharacterList();
                characterListListView.EnsureVisible(characterListListView.Items.Count - 1);
            }
        }

        private void EditCharacter()
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || (!maleRadioButton.Checked && !femaleRadioButton.Checked))
            {
                MessageBox.Show("You must provide a First Name, Last Name, and choose a gender.");
            }
            else
            {
                Character ch = new Character
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Gender = maleRadioButton.Checked ? true : false,
                    Deleted = false,
                    ID = Convert.ToInt32(characterListListView.CheckedItems[0].SubItems[subItemNameId].Text)
                };

                CharacterTool.SaveCharacter(ch);
                firstNameTextBox.Text = "";
                if (!CharacterTool.GetDontClearLastName())
                {
                    lastNameTextBox.Text = "";
                }
                if (!CharacterTool.GetDontClearGender())
                {
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = false;
                }
                int viewIndex = characterListListView.CheckedItems[0].Index;
                refreshCharacterList();
                characterListListView.EnsureVisible(viewIndex);
                DisableEditCharacter();
            }
        }

        private void showDeletedCharactersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CharacterTool.SetShowDeletedCharacters(showDeletedCharactersCheckBox.Checked);
            refreshCharacterList();
        }

        private void keepLastNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CharacterTool.SetDontClearLastName(keepLastNameCheckBox.Checked);
        }

        private void keepGenderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CharacterTool.SetDontClearGender(keepGenderCheckBox.Checked);
        }
        
        private void firstNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AddCharacter();
                    firstNameTextBox.Focus();
                    break;
            }
        }

        private void lastNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AddCharacter();
                    firstNameTextBox.Focus();
                    break;
            }
        }

        private void maleRadioButton_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AddCharacter();
                    firstNameTextBox.Focus();
                    break;
            }
        }

        private void femaleRadioButton_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    AddCharacter();
                    firstNameTextBox.Focus();
                    break;
            }
        }

        private void characterListListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (characterListListView.CheckedItems.Count > 1)
            {
                editCharacterButton.Enabled = false;
            }
            else
            {
                editCharacterButton.Enabled = true;
            }
        }

        private void editCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterListListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("You must first select a character to edit.");
            }
            else
            {
                EnableEditCharacter();
            }
        }

        private void EnableEditCharacter()
        {
            characterListListView.FullRowSelect = true;
            
            refreshCharacterListButton.Enabled = false;
            createCharacterButton.Enabled = false;
            deleteCharacterButton.Enabled = false;
            undeleteCharacterButton.Enabled = false;
            selectAllCharactersButton.Enabled = false;
            unselectAllCharactersButton.Enabled = false;

            currentCharacterActionLabel.Text = editCharacterText;
            currentCharacterActionLabel.ForeColor = SystemColors.ControlText;
            currentCharacterActionButton.Text = saveCharacterEditText;
            currentCharacterActionButton.Enabled = true;
            firstNameLabel.ForeColor = SystemColors.ControlText;
            firstNameTextBox.Enabled = true;
            firstNameTextBox.Text = characterListListView.CheckedItems[0].SubItems[subItemNameFirstName].Text;
            lastNameLabel.ForeColor = SystemColors.ControlText;
            lastNameTextBox.Enabled = true;
            lastNameTextBox.Text = characterListListView.CheckedItems[0].SubItems[subItemNameLastName].Text;
            keepLastNameCheckBox.Enabled = true;
            maleRadioButton.Enabled = true;
            femaleRadioButton.Enabled = true;
            keepGenderCheckBox.Enabled = true;
            if (characterListListView.CheckedItems[0].SubItems[subItemNameGender].Text == "Male")
            {
                maleRadioButton.Checked = true;
            }
            else
            {
                femaleRadioButton.Checked = true;
            }

            firstNameTextBox.Focus();
        }

        private void DisableEditCharacter()
        {
            characterListListView.FullRowSelect = false;

            refreshCharacterListButton.Enabled = true;
            createCharacterButton.Enabled = true;
            deleteCharacterButton.Enabled = true;
            undeleteCharacterButton.Enabled = true;
            selectAllCharactersButton.Enabled = true;
            unselectAllCharactersButton.Enabled = true;

            currentCharacterActionLabel.ForeColor = SystemColors.ControlLight;
            currentCharacterActionButton.Enabled = false;
            firstNameLabel.ForeColor = SystemColors.ControlLight;
            firstNameTextBox.Enabled = false;
            firstNameTextBox.Text = emptyString;
            lastNameLabel.ForeColor = SystemColors.ControlLight;
            lastNameTextBox.Enabled = false;
            lastNameTextBox.Text = emptyString;
            keepLastNameCheckBox.Enabled = false;
            maleRadioButton.Enabled = false;
            maleRadioButton.Checked = false;
            femaleRadioButton.Enabled = false;
            femaleRadioButton.Checked = false;
            keepGenderCheckBox.Enabled = false;
        }

        private void deleteCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterListListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("You must select at least one character to delete.");
            }
            else
            {
                changeCharactersDeleteStatus(true);
            }
        }

        private void undeleteCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterListListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("You must select at least one character to undelete.");
            }
            else
            {
                changeCharactersDeleteStatus(false);
            }
        }

        private void changeCharactersDeleteStatus(bool deleted)
        {
            foreach (ListViewItem item in characterListListView.CheckedItems)
            {
                changeCharacterDeleteStatus(item, deleted);
            }
            if (!deleted || CharacterTool.GetShowDeletedCharacters())
            {
                int viewIndex = characterListListView.CheckedItems[0].Index;
                refreshCharacterList();
                characterListListView.EnsureVisible(viewIndex);
            }
            else
            {
                refreshCharacterList();
            }
        }

        private void changeCharacterDeleteStatus(ListViewItem item, bool deleted)
        {
            Character ch = new Character
            {
                FirstName = item.SubItems[subItemNameFirstName].Text,
                LastName = item.SubItems[subItemNameLastName].Text,
                Gender = item.SubItems[subItemNameGender].Text == "Male" ? true : false,
                Deleted = deleted,
                ID = Convert.ToInt32(item.SubItems[subItemNameId].Text)
            };

            CharacterTool.SaveCharacter(ch);
        }

        private void selectAllCharactersButton_Click(object sender, EventArgs e)
        {
            SetAllCheckedState(true);
        }

        private void unselectAllCharactersButton_Click(object sender, EventArgs e)
        {
            SetAllCheckedState(false);
        }

        private void SetAllCheckedState(bool checkAll)
        {
            foreach (ListViewItem item in characterListListView.Items)
            {
                item.Checked = checkAll;
            }
        }

        #endregion CharacterTab
    }
}
