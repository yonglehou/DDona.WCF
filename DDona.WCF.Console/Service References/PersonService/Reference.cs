﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDona.WCF.Console.PersonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/DDona.WCF.Model")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> UpdateDateField;
        
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
        public System.DateTime BirthDay {
            get {
                return this.BirthDayField;
            }
            set {
                if ((this.BirthDayField.Equals(value) != true)) {
                    this.BirthDayField = value;
                    this.RaisePropertyChanged("BirthDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        public string Quote {
            get {
                return this.QuoteField;
            }
            set {
                if ((object.ReferenceEquals(this.QuoteField, value) != true)) {
                    this.QuoteField = value;
                    this.RaisePropertyChanged("Quote");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> UpdateDate {
            get {
                return this.UpdateDateField;
            }
            set {
                if ((this.UpdateDateField.Equals(value) != true)) {
                    this.UpdateDateField = value;
                    this.RaisePropertyChanged("UpdateDate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="StubClass", Namespace="http://schemas.datacontract.org/2004/07/DDona.WCF.WService.Custom")]
    [System.SerializableAttribute()]
    public partial class StubClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CurrentDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RandomNumberField;
        
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
        public System.DateTime CurrentDateTime {
            get {
                return this.CurrentDateTimeField;
            }
            set {
                if ((this.CurrentDateTimeField.Equals(value) != true)) {
                    this.CurrentDateTimeField = value;
                    this.RaisePropertyChanged("CurrentDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RandomNumber {
            get {
                return this.RandomNumberField;
            }
            set {
                if ((this.RandomNumberField.Equals(value) != true)) {
                    this.RandomNumberField = value;
                    this.RaisePropertyChanged("RandomNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SavePerson", ReplyAction="http://tempuri.org/IPersonService/SavePersonResponse")]
        bool SavePerson(DDona.WCF.Console.PersonService.Person Person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SavePerson", ReplyAction="http://tempuri.org/IPersonService/SavePersonResponse")]
        System.Threading.Tasks.Task<bool> SavePersonAsync(DDona.WCF.Console.PersonService.Person Person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAll", ReplyAction="http://tempuri.org/IPersonService/GetAllResponse")]
        DDona.WCF.Console.PersonService.Person[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetAll", ReplyAction="http://tempuri.org/IPersonService/GetAllResponse")]
        System.Threading.Tasks.Task<DDona.WCF.Console.PersonService.Person[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetByName", ReplyAction="http://tempuri.org/IPersonService/GetByNameResponse")]
        DDona.WCF.Console.PersonService.Person[] GetByName(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetByName", ReplyAction="http://tempuri.org/IPersonService/GetByNameResponse")]
        System.Threading.Tasks.Task<DDona.WCF.Console.PersonService.Person[]> GetByNameAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/ExcludePerson", ReplyAction="http://tempuri.org/IPersonService/ExcludePersonResponse")]
        bool ExcludePerson(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/ExcludePerson", ReplyAction="http://tempuri.org/IPersonService/ExcludePersonResponse")]
        System.Threading.Tasks.Task<bool> ExcludePersonAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetStub", ReplyAction="http://tempuri.org/IPersonService/GetStubResponse")]
        DDona.WCF.Console.PersonService.StubClass GetStub();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetStub", ReplyAction="http://tempuri.org/IPersonService/GetStubResponse")]
        System.Threading.Tasks.Task<DDona.WCF.Console.PersonService.StubClass> GetStubAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : DDona.WCF.Console.PersonService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<DDona.WCF.Console.PersonService.IPersonService>, DDona.WCF.Console.PersonService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SavePerson(DDona.WCF.Console.PersonService.Person Person) {
            return base.Channel.SavePerson(Person);
        }
        
        public System.Threading.Tasks.Task<bool> SavePersonAsync(DDona.WCF.Console.PersonService.Person Person) {
            return base.Channel.SavePersonAsync(Person);
        }
        
        public DDona.WCF.Console.PersonService.Person[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<DDona.WCF.Console.PersonService.Person[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public DDona.WCF.Console.PersonService.Person[] GetByName(string Name) {
            return base.Channel.GetByName(Name);
        }
        
        public System.Threading.Tasks.Task<DDona.WCF.Console.PersonService.Person[]> GetByNameAsync(string Name) {
            return base.Channel.GetByNameAsync(Name);
        }
        
        public bool ExcludePerson(int Id) {
            return base.Channel.ExcludePerson(Id);
        }
        
        public System.Threading.Tasks.Task<bool> ExcludePersonAsync(int Id) {
            return base.Channel.ExcludePersonAsync(Id);
        }
        
        public DDona.WCF.Console.PersonService.StubClass GetStub() {
            return base.Channel.GetStub();
        }
        
        public System.Threading.Tasks.Task<DDona.WCF.Console.PersonService.StubClass> GetStubAsync() {
            return base.Channel.GetStubAsync();
        }
    }
}
