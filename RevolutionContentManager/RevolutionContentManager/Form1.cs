using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RevolutionContentManager.CharacterService;
using RevolutionContentManager.ContentManagerSettingService;

namespace RevolutionContentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshCharacterList();
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
    }
}
