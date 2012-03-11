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

        internal static Character SaveCharacter(Character character)
        {
            Character ch = null;

            Service<ICharacterService>.Use(client =>
            {
                ch = client.SaveCharacter(character);
            });

            return ch;
        }
        
        internal static bool GetShowDeletedCharacters()
        {
            return GetBoolSetting((int)CMSettingEnum.ShowDeletedCharacters);
        }

        internal static ContentManagerSetting SetShowDeletedCharacters(bool showDeleted)
        {
            return SetBoolSetting(showDeleted, (int)CMSettingEnum.ShowDeletedCharacters);
        }

        internal static bool GetDontClearLastName()
        {
            return GetBoolSetting((int)CMSettingEnum.DontClearLastName);
        }

        internal static ContentManagerSetting SetDontClearLastName(bool dontClearLastName)
        {
            return SetBoolSetting(dontClearLastName, (int)CMSettingEnum.DontClearLastName);
        }

        internal static bool GetDontClearGender()
        {
            return GetBoolSetting((int)CMSettingEnum.DontClearGender);
        }

        internal static ContentManagerSetting SetDontClearGender(bool dontClearGender)
        {
            return SetBoolSetting(dontClearGender, (int)CMSettingEnum.DontClearGender);
        }

        private static bool GetBoolSetting(int id)
        {
            ContentManagerClient client = new ContentManagerClient();
            ContentManagerSetting setting = client.GetSetting(id);

            bool settingBool;
            Boolean.TryParse(setting.Value, out settingBool);

            return settingBool;
        }

        private static ContentManagerSetting SetBoolSetting(bool settingBool, int id)
        {
            ContentManagerClient client = new ContentManagerClient();
            ContentManagerSetting setting = client.GetSetting(id);

            setting.Value = settingBool.ToString();

            return client.SaveSetting(setting);
        }
    }
}
