// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32990 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>BEArcus.Agent</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace BEArcus.Agent {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.arcus.com/configuration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.arcus.com/configuration", IsNullable=false)]
    public partial class Configuration {
        
        private List<SettingType> commonSettingsField;
        
        private DataStoresType dataStoresField;
        
        private LogType logSettingField;
        
        /// <summary>
        /// Configuration class constructor
        /// </summary>
        public Configuration() {
            this.logSettingField = new LogType();
            this.dataStoresField = new DataStoresType();
            this.commonSettingsField = new List<SettingType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Setting", IsNullable=false)]
        public List<SettingType> CommonSettings {
            get {
                return this.commonSettingsField;
            }
            set {
                this.commonSettingsField = value;
            }
        }
        
        public DataStoresType DataStores {
            get {
                return this.dataStoresField;
            }
            set {
                this.dataStoresField = value;
            }
        }
        
        public LogType LogSetting {
            get {
                return this.logSettingField;
            }
            set {
                this.logSettingField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.arcus.com/configuration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.arcus.com/configuration", IsNullable=true)]
    public partial class SettingType {
        
        private string nameField;
        
        private string valueField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.arcus.com/configuration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.arcus.com/configuration", IsNullable=true)]
    public partial class LogType {
        
        private string nameField;
        
        private string valueField;
        
        private bool enabledField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.arcus.com/configuration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.arcus.com/configuration", IsNullable=true)]
    public partial class DocumentDBType {
        
        private string nameField;
        
        private bool enabledField;
        
        private string endPointUrlField;
        
        private string authorizationKeyField;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EndPointUrl {
            get {
                return this.endPointUrlField;
            }
            set {
                this.endPointUrlField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AuthorizationKey {
            get {
                return this.authorizationKeyField;
            }
            set {
                this.authorizationKeyField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.arcus.com/configuration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.arcus.com/configuration", IsNullable=true)]
    public partial class FileSystemType {
        
        private string nameField;
        
        private bool enabledField;
        
        private string alertPathField;
        
        private string jobPathField;
        
        private string jobHistoryPathField;
        
        private string mediaServerPathField;
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AlertPath {
            get {
                return this.alertPathField;
            }
            set {
                this.alertPathField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string JobPath {
            get {
                return this.jobPathField;
            }
            set {
                this.jobPathField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string JobHistoryPath {
            get {
                return this.jobHistoryPathField;
            }
            set {
                this.jobHistoryPathField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MediaServerPath {
            get {
                return this.mediaServerPathField;
            }
            set {
                this.mediaServerPathField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.arcus.com/configuration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.arcus.com/configuration", IsNullable=true)]
    public partial class DataStoresType {
        
        private List<FileSystemType> fileSystemField;
        
        private List<DocumentDBType> documentDBField;
        
        /// <summary>
        /// DataStoresType class constructor
        /// </summary>
        public DataStoresType() {
            this.documentDBField = new List<DocumentDBType>();
            this.fileSystemField = new List<FileSystemType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FileSystem")]
        public List<FileSystemType> FileSystem {
            get {
                return this.fileSystemField;
            }
            set {
                this.fileSystemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("DocumentDB")]
        public List<DocumentDBType> DocumentDB {
            get {
                return this.documentDBField;
            }
            set {
                this.documentDBField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.arcus.com/configuration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.arcus.com/configuration", IsNullable=true)]
    public partial class CommonSettingsType {
        
        private List<SettingType> settingField;
        
        /// <summary>
        /// CommonSettingsType class constructor
        /// </summary>
        public CommonSettingsType() {
            this.settingField = new List<SettingType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Setting")]
        public List<SettingType> Setting {
            get {
                return this.settingField;
            }
            set {
                this.settingField = value;
            }
        }
    }
}