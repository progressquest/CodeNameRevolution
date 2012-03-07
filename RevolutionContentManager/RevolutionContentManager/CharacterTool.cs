using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RevolutionContentManager.CharacterService;
using SafeService;
using RevolutionContentManagerDAL;
using System.Data.Entity;

namespace RevolutionContentManager
{
    internal class CharacterTool
    {
        internal static List<Character> GetAllCharacters()
        {
            List<Character> characterList = null;

            Service<ICharacterService>.Use(client =>
            {
                characterList = client.GetAllCharacters();
            });

            return characterList;
        }

        internal static bool GetShowDeletedCharacters()
        {
            ContentManagerClient client = new ContentManagerClient();
            ContentManagerSetting showDeletedSetting = client.GetSetting((int)CMSettingEnum.ShowDeletedCharacters);

            bool showDeleted;
            Boolean.TryParse(showDeletedSetting.Value, out showDeleted);

            return showDeleted;
        }

        internal static ContentManagerSetting SetShowDeletedCharacters(bool showDeleted)
        {
            ContentManagerClient client = new ContentManagerClient();
            ContentManagerSetting showDeletedSetting = client.GetSetting((int)CMSettingEnum.ShowDeletedCharacters);

            showDeletedSetting.Value = showDeleted.ToString();

            return client.SaveSetting(showDeletedSetting);
        }

        
    }
}
