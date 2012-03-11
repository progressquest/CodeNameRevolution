﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace RevolutionContentManagerDAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ContentManagerEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ContentManagerEntities object using the connection string found in the 'ContentManagerEntities' section of the application configuration file.
        /// </summary>
        public ContentManagerEntities() : base("name=ContentManagerEntities", "ContentManagerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ContentManagerEntities object.
        /// </summary>
        public ContentManagerEntities(string connectionString) : base(connectionString, "ContentManagerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ContentManagerEntities object.
        /// </summary>
        public ContentManagerEntities(EntityConnection connection) : base(connection, "ContentManagerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ContentManagerSetting> ContentManagerSettings
        {
            get
            {
                if ((_ContentManagerSettings == null))
                {
                    _ContentManagerSettings = base.CreateObjectSet<ContentManagerSetting>("ContentManagerSettings");
                }
                return _ContentManagerSettings;
            }
        }
        private ObjectSet<ContentManagerSetting> _ContentManagerSettings;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ContentManagerSettings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContentManagerSettings(ContentManagerSetting contentManagerSetting)
        {
            base.AddObject("ContentManagerSettings", contentManagerSetting);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ContentManagerModel", Name="ContentManagerSetting")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ContentManagerSetting : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ContentManagerSetting object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="value">Initial value of the Value property.</param>
        public static ContentManagerSetting CreateContentManagerSetting(global::System.Int32 id, global::System.String name, global::System.String description, global::System.String value)
        {
            ContentManagerSetting contentManagerSetting = new ContentManagerSetting();
            contentManagerSetting.ID = id;
            contentManagerSetting.Name = name;
            contentManagerSetting.Description = description;
            contentManagerSetting.Value = value;
            return contentManagerSetting;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Value
        {
            get
            {
                return _Value;
            }
            set
            {
                OnValueChanging(value);
                ReportPropertyChanging("Value");
                _Value = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Value");
                OnValueChanged();
            }
        }
        private global::System.String _Value;
        partial void OnValueChanging(global::System.String value);
        partial void OnValueChanged();

        #endregion
    
    }

    #endregion
    
}
