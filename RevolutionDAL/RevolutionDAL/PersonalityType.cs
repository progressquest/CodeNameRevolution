//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace RevolutionDAL
{
    [DataContract]
    public partial class PersonalityType
    {
        #region Primitive Properties
    
        public virtual int ID
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual int TypeID
        {
            get { return _typeID; }
            set
            {
                if (_typeID != value)
                {
                    if (PersonalityTypeType != null && PersonalityTypeType.ID != value)
                    {
                        PersonalityTypeType = null;
                    }
                    _typeID = value;
                }
            }
        }
        private int _typeID;

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<PersonalityPhrase> PersonalityPhrases
        {
            get
            {
                if (_personalityPhrases == null)
                {
                    var newCollection = new FixupCollection<PersonalityPhrase>();
                    newCollection.CollectionChanged += FixupPersonalityPhrases;
                    _personalityPhrases = newCollection;
                }
                return _personalityPhrases;
            }
            set
            {
                if (!ReferenceEquals(_personalityPhrases, value))
                {
                    var previousValue = _personalityPhrases as FixupCollection<PersonalityPhrase>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPersonalityPhrases;
                    }
                    _personalityPhrases = value;
                    var newValue = value as FixupCollection<PersonalityPhrase>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPersonalityPhrases;
                    }
                }
            }
        }
        private ICollection<PersonalityPhrase> _personalityPhrases;
    
        public virtual PersonalityTypeType PersonalityTypeType
        {
            get { return _personalityTypeType; }
            set
            {
                if (!ReferenceEquals(_personalityTypeType, value))
                {
                    var previousValue = _personalityTypeType;
                    _personalityTypeType = value;
                    FixupPersonalityTypeType(previousValue);
                }
            }
        }
        private PersonalityTypeType _personalityTypeType;

        #endregion
        #region Association Fixup
    
        private void FixupPersonalityTypeType(PersonalityTypeType previousValue)
        {
            if (previousValue != null && previousValue.PersonalityTypes.Contains(this))
            {
                previousValue.PersonalityTypes.Remove(this);
            }
    
            if (PersonalityTypeType != null)
            {
                if (!PersonalityTypeType.PersonalityTypes.Contains(this))
                {
                    PersonalityTypeType.PersonalityTypes.Add(this);
                }
                if (TypeID != PersonalityTypeType.ID)
                {
                    TypeID = PersonalityTypeType.ID;
                }
            }
        }
    
        private void FixupPersonalityPhrases(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PersonalityPhrase item in e.NewItems)
                {
                    item.PersonalityType = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PersonalityPhrase item in e.OldItems)
                {
                    if (ReferenceEquals(item.PersonalityType, this))
                    {
                        item.PersonalityType = null;
                    }
                }
            }
        }

        #endregion
    }
}