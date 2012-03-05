//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace RevolutionDAL
{
    public partial class RevolutionEntities1 : ObjectContext
    {
        public const string ConnectionString = "name=RevolutionEntities1";
        public const string ContainerName = "RevolutionEntities1";
    
        #region Constructors
    
        public RevolutionEntities1()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public RevolutionEntities1(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public RevolutionEntities1(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Character> Characters
        {
            get { return _characters  ?? (_characters = CreateObjectSet<Character>("Characters")); }
        }
        private ObjectSet<Character> _characters;
    
        public ObjectSet<CharacterPersonality> CharacterPersonalities
        {
            get { return _characterPersonalities  ?? (_characterPersonalities = CreateObjectSet<CharacterPersonality>("CharacterPersonalities")); }
        }
        private ObjectSet<CharacterPersonality> _characterPersonalities;
    
        public ObjectSet<PersonalityPhrase> PersonalityPhrases
        {
            get { return _personalityPhrases  ?? (_personalityPhrases = CreateObjectSet<PersonalityPhrase>("PersonalityPhrases")); }
        }
        private ObjectSet<PersonalityPhrase> _personalityPhrases;
    
        public ObjectSet<PersonalityType> PersonalityTypes
        {
            get { return _personalityTypes  ?? (_personalityTypes = CreateObjectSet<PersonalityType>("PersonalityTypes")); }
        }
        private ObjectSet<PersonalityType> _personalityTypes;
    
        public ObjectSet<PersonalityTypeType> PersonalityTypeTypes
        {
            get { return _personalityTypeTypes  ?? (_personalityTypeTypes = CreateObjectSet<PersonalityTypeType>("PersonalityTypeTypes")); }
        }
        private ObjectSet<PersonalityTypeType> _personalityTypeTypes;
    
        public ObjectSet<Phrase> Phrases
        {
            get { return _phrases  ?? (_phrases = CreateObjectSet<Phrase>("Phrases")); }
        }
        private ObjectSet<Phrase> _phrases;
    
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get { return _sysdiagrams  ?? (_sysdiagrams = CreateObjectSet<sysdiagram>("sysdiagrams")); }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;
    
        public ObjectSet<Topic> Topics
        {
            get { return _topics  ?? (_topics = CreateObjectSet<Topic>("Topics")); }
        }
        private ObjectSet<Topic> _topics;
    
        public ObjectSet<ContentManagerSetting> ContentManagerSettings
        {
            get { return _contentManagerSettings  ?? (_contentManagerSettings = CreateObjectSet<ContentManagerSetting>("ContentManagerSettings")); }
        }
        private ObjectSet<ContentManagerSetting> _contentManagerSettings;

        #endregion
    }
}
