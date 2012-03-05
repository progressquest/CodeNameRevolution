using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RevolutionContentManager.CharacterService;
using RevolutionContentManager.ContentManagerSettingService;
using SafeService;

namespace RevolutionContentManager
{
    internal class CharacterTool
    {
        private static ContentManagerSetting CMSetting { get; set; }

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
            ContentManagerSetting showDeletedSetting = CMSettings.GetContentManagerSetting((int)CMSettingEnum.ShowDeletedCharacters);

            bool showDeleted;
            Boolean.TryParse(showDeletedSetting.Value, out showDeleted);

            return showDeleted;
        }

        internal static ContentManagerSetting SetShowDeletedCharacters(bool showDeleted)
        {
            ContentManagerSetting showDeletedSetting = CMSettings.GetContentManagerSetting((int)CMSettingEnum.ShowDeletedCharacters);

            showDeletedSetting.Value = showDeleted.ToString();

            return CMSettings.SaveContentManagerSetting(showDeletedSetting);
        }

        
    }
}
