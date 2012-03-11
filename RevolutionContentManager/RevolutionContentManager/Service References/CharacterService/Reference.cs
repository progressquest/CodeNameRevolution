﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RevolutionContentManager.CharacterService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Character", Namespace="http://schemas.datacontract.org/2004/07/RevolutionDAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Character : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RevolutionContentManager.CharacterService.CharacterPersonality> CharacterPersonalitiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RevolutionContentManager.CharacterService.CharacterPersonality> CharacterPersonalities {
            get {
                return this.CharacterPersonalitiesField;
            }
            set {
                if ((object.ReferenceEquals(this.CharacterPersonalitiesField, value) != true)) {
                    this.CharacterPersonalitiesField = value;
                    this.RaisePropertyChanged("CharacterPersonalities");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted {
            get {
                return this.DeletedField;
            }
            set {
                if ((this.DeletedField.Equals(value) != true)) {
                    this.DeletedField = value;
                    this.RaisePropertyChanged("Deleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CharacterPersonality", Namespace="http://schemas.datacontract.org/2004/07/RevolutionDAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class CharacterPersonality : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.Character CharacterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CharacterIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.PersonalityType PersonalityTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonalityTypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RatingField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.Character Character {
            get {
                return this.CharacterField;
            }
            set {
                if ((object.ReferenceEquals(this.CharacterField, value) != true)) {
                    this.CharacterField = value;
                    this.RaisePropertyChanged("Character");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CharacterID {
            get {
                return this.CharacterIDField;
            }
            set {
                if ((this.CharacterIDField.Equals(value) != true)) {
                    this.CharacterIDField = value;
                    this.RaisePropertyChanged("CharacterID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.PersonalityType PersonalityType {
            get {
                return this.PersonalityTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityTypeField, value) != true)) {
                    this.PersonalityTypeField = value;
                    this.RaisePropertyChanged("PersonalityType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonalityTypeID {
            get {
                return this.PersonalityTypeIDField;
            }
            set {
                if ((this.PersonalityTypeIDField.Equals(value) != true)) {
                    this.PersonalityTypeIDField = value;
                    this.RaisePropertyChanged("PersonalityTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonalityType", Namespace="http://schemas.datacontract.org/2004/07/RevolutionDAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class PersonalityType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RevolutionContentManager.CharacterService.CharacterPersonality> CharacterPersonalitiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RevolutionContentManager.CharacterService.PersonalityPhrase> PersonalityPhrasesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.PersonalityTypeType PersonalityTypeTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RevolutionContentManager.CharacterService.CharacterPersonality> CharacterPersonalities {
            get {
                return this.CharacterPersonalitiesField;
            }
            set {
                if ((object.ReferenceEquals(this.CharacterPersonalitiesField, value) != true)) {
                    this.CharacterPersonalitiesField = value;
                    this.RaisePropertyChanged("CharacterPersonalities");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RevolutionContentManager.CharacterService.PersonalityPhrase> PersonalityPhrases {
            get {
                return this.PersonalityPhrasesField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityPhrasesField, value) != true)) {
                    this.PersonalityPhrasesField = value;
                    this.RaisePropertyChanged("PersonalityPhrases");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.PersonalityTypeType PersonalityTypeType {
            get {
                return this.PersonalityTypeTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityTypeTypeField, value) != true)) {
                    this.PersonalityTypeTypeField = value;
                    this.RaisePropertyChanged("PersonalityTypeType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeID {
            get {
                return this.TypeIDField;
            }
            set {
                if ((this.TypeIDField.Equals(value) != true)) {
                    this.TypeIDField = value;
                    this.RaisePropertyChanged("TypeID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonalityTypeType", Namespace="http://schemas.datacontract.org/2004/07/RevolutionDAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class PersonalityTypeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.PersonalityTypeType PersonalityTypeType1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.PersonalityTypeType PersonalityTypeType2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RevolutionContentManager.CharacterService.PersonalityType> PersonalityTypesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.PersonalityTypeType PersonalityTypeType1 {
            get {
                return this.PersonalityTypeType1Field;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityTypeType1Field, value) != true)) {
                    this.PersonalityTypeType1Field = value;
                    this.RaisePropertyChanged("PersonalityTypeType1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.PersonalityTypeType PersonalityTypeType2 {
            get {
                return this.PersonalityTypeType2Field;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityTypeType2Field, value) != true)) {
                    this.PersonalityTypeType2Field = value;
                    this.RaisePropertyChanged("PersonalityTypeType2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RevolutionContentManager.CharacterService.PersonalityType> PersonalityTypes {
            get {
                return this.PersonalityTypesField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityTypesField, value) != true)) {
                    this.PersonalityTypesField = value;
                    this.RaisePropertyChanged("PersonalityTypes");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonalityPhrase", Namespace="http://schemas.datacontract.org/2004/07/RevolutionDAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class PersonalityPhrase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonalityRatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.PersonalityType PersonalityTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonalityTypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.Phrase PhraseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhraseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RatingIsGreaterField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonalityRating {
            get {
                return this.PersonalityRatingField;
            }
            set {
                if ((this.PersonalityRatingField.Equals(value) != true)) {
                    this.PersonalityRatingField = value;
                    this.RaisePropertyChanged("PersonalityRating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.PersonalityType PersonalityType {
            get {
                return this.PersonalityTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityTypeField, value) != true)) {
                    this.PersonalityTypeField = value;
                    this.RaisePropertyChanged("PersonalityType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonalityTypeID {
            get {
                return this.PersonalityTypeIDField;
            }
            set {
                if ((this.PersonalityTypeIDField.Equals(value) != true)) {
                    this.PersonalityTypeIDField = value;
                    this.RaisePropertyChanged("PersonalityTypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.Phrase Phrase {
            get {
                return this.PhraseField;
            }
            set {
                if ((object.ReferenceEquals(this.PhraseField, value) != true)) {
                    this.PhraseField = value;
                    this.RaisePropertyChanged("Phrase");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhraseID {
            get {
                return this.PhraseIDField;
            }
            set {
                if ((this.PhraseIDField.Equals(value) != true)) {
                    this.PhraseIDField = value;
                    this.RaisePropertyChanged("PhraseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RatingIsGreater {
            get {
                return this.RatingIsGreaterField;
            }
            set {
                if ((this.RatingIsGreaterField.Equals(value) != true)) {
                    this.RatingIsGreaterField = value;
                    this.RaisePropertyChanged("RatingIsGreater");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Phrase", Namespace="http://schemas.datacontract.org/2004/07/RevolutionDAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Phrase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ImmediacyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsQuestionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSpontaneousField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RevolutionContentManager.CharacterService.PersonalityPhrase> PersonalityPhrasesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RevolutionContentManager.CharacterService.Topic TopicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TopicIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Immediacy {
            get {
                return this.ImmediacyField;
            }
            set {
                if ((this.ImmediacyField.Equals(value) != true)) {
                    this.ImmediacyField = value;
                    this.RaisePropertyChanged("Immediacy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsQuestion {
            get {
                return this.IsQuestionField;
            }
            set {
                if ((this.IsQuestionField.Equals(value) != true)) {
                    this.IsQuestionField = value;
                    this.RaisePropertyChanged("IsQuestion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSpontaneous {
            get {
                return this.IsSpontaneousField;
            }
            set {
                if ((this.IsSpontaneousField.Equals(value) != true)) {
                    this.IsSpontaneousField = value;
                    this.RaisePropertyChanged("IsSpontaneous");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RevolutionContentManager.CharacterService.PersonalityPhrase> PersonalityPhrases {
            get {
                return this.PersonalityPhrasesField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalityPhrasesField, value) != true)) {
                    this.PersonalityPhrasesField = value;
                    this.RaisePropertyChanged("PersonalityPhrases");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RevolutionContentManager.CharacterService.Topic Topic {
            get {
                return this.TopicField;
            }
            set {
                if ((object.ReferenceEquals(this.TopicField, value) != true)) {
                    this.TopicField = value;
                    this.RaisePropertyChanged("Topic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TopicID {
            get {
                return this.TopicIDField;
            }
            set {
                if ((this.TopicIDField.Equals(value) != true)) {
                    this.TopicIDField = value;
                    this.RaisePropertyChanged("TopicID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Topic", Namespace="http://schemas.datacontract.org/2004/07/RevolutionDAL", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Topic : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<RevolutionContentManager.CharacterService.Phrase> PhrasesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<RevolutionContentManager.CharacterService.Phrase> Phrases {
            get {
                return this.PhrasesField;
            }
            set {
                if ((object.ReferenceEquals(this.PhrasesField, value) != true)) {
                    this.PhrasesField = value;
                    this.RaisePropertyChanged("Phrases");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CharacterService.ICharacterService")]
    public interface ICharacterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterService/GetCharacter", ReplyAction="http://tempuri.org/ICharacterService/GetCharacterResponse")]
        RevolutionContentManager.CharacterService.Character GetCharacter(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterService/SaveCharacter", ReplyAction="http://tempuri.org/ICharacterService/SaveCharacterResponse")]
        RevolutionContentManager.CharacterService.Character SaveCharacter(RevolutionContentManager.CharacterService.Character character);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterService/RemoveCharacter", ReplyAction="http://tempuri.org/ICharacterService/RemoveCharacterResponse")]
        void RemoveCharacter(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICharacterService/GetAllCharacters", ReplyAction="http://tempuri.org/ICharacterService/GetAllCharactersResponse")]
        System.Collections.Generic.List<RevolutionContentManager.CharacterService.Character> GetAllCharacters();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICharacterServiceChannel : RevolutionContentManager.CharacterService.ICharacterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CharacterServiceClient : System.ServiceModel.ClientBase<RevolutionContentManager.CharacterService.ICharacterService>, RevolutionContentManager.CharacterService.ICharacterService {
        
        public CharacterServiceClient() {
        }
        
        public CharacterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CharacterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CharacterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CharacterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RevolutionContentManager.CharacterService.Character GetCharacter(int id) {
            return base.Channel.GetCharacter(id);
        }
        
        public RevolutionContentManager.CharacterService.Character SaveCharacter(RevolutionContentManager.CharacterService.Character character) {
            return base.Channel.SaveCharacter(character);
        }
        
        public void RemoveCharacter(int id) {
            base.Channel.RemoveCharacter(id);
        }
        
        public System.Collections.Generic.List<RevolutionContentManager.CharacterService.Character> GetAllCharacters() {
            return base.Channel.GetAllCharacters();
        }
    }
}
