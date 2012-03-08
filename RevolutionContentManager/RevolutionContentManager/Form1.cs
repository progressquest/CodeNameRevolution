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

        private const string createCharacterText = "Create Character";
        private const string createNewCharactersText = "Create New Character(s)";
        private const string finishNewCharactersText = "Done Creating Character(s)";
        private const string addCharacterText = "Add Character";
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
                    characterItem.SubItems.Add(character.ID.ToString());
                    characterItem.SubItems.Add(character.FirstName);
                    characterItem.SubItems.Add(character.LastName);
                    characterItem.SubItems.Add(character.Gender ? "Male" : "Female");
                    characterItem.SubItems.Add(character.Deleted.ToString());
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
            activateCharacterButton.Enabled = false;
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
            activateCharacterButton.Enabled = true;
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

        private void showDeletedCharactersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CharacterTool.SetShowDeletedCharacters(showDeletedCharactersCheckBox.Checked);
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

        

        
    }
}
