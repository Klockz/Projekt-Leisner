﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeisnerWPF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWCF.Model")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeisnerWPF.ServiceReference1.Patient[] PatientsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneNoField;
        
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
        public int CustomerNo {
            get {
                return this.CustomerNoField;
            }
            set {
                if ((this.CustomerNoField.Equals(value) != true)) {
                    this.CustomerNoField = value;
                    this.RaisePropertyChanged("CustomerNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public LeisnerWPF.ServiceReference1.Patient[] Patients {
            get {
                return this.PatientsField;
            }
            set {
                if ((object.ReferenceEquals(this.PatientsField, value) != true)) {
                    this.PatientsField = value;
                    this.RaisePropertyChanged("Patients");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((this.PhoneNoField.Equals(value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWCF.Model")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeisnerWPF.ServiceReference1.Questionnaire[] QuestionnairesField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
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
        public LeisnerWPF.ServiceReference1.Questionnaire[] Questionnaires {
            get {
                return this.QuestionnairesField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionnairesField, value) != true)) {
                    this.QuestionnairesField = value;
                    this.RaisePropertyChanged("Questionnaires");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Questionnaire", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWCF.Model")]
    [System.SerializableAttribute()]
    public partial class Questionnaire : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MotivationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PleaseContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeisnerWPF.ServiceReference1.ToiletVisit[] ToiletVisitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeisnerWPF.ServiceReference1.WetBed[] WetBedsField;
        
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
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
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
        public int Motivation {
            get {
                return this.MotivationField;
            }
            set {
                if ((this.MotivationField.Equals(value) != true)) {
                    this.MotivationField = value;
                    this.RaisePropertyChanged("Motivation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PleaseContact {
            get {
                return this.PleaseContactField;
            }
            set {
                if ((this.PleaseContactField.Equals(value) != true)) {
                    this.PleaseContactField = value;
                    this.RaisePropertyChanged("PleaseContact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LeisnerWPF.ServiceReference1.ToiletVisit[] ToiletVisits {
            get {
                return this.ToiletVisitsField;
            }
            set {
                if ((object.ReferenceEquals(this.ToiletVisitsField, value) != true)) {
                    this.ToiletVisitsField = value;
                    this.RaisePropertyChanged("ToiletVisits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LeisnerWPF.ServiceReference1.WetBed[] WetBeds {
            get {
                return this.WetBedsField;
            }
            set {
                if ((object.ReferenceEquals(this.WetBedsField, value) != true)) {
                    this.WetBedsField = value;
                    this.RaisePropertyChanged("WetBeds");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ToiletVisit", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWCF.Model")]
    [System.SerializableAttribute()]
    public partial class ToiletVisit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
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
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WetBed", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWCF.Model")]
    [System.SerializableAttribute()]
    public partial class WetBed : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeisnerWPF.ServiceReference1.SpotSize SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
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
        public LeisnerWPF.ServiceReference1.SpotSize Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SpotSize", Namespace="http://schemas.datacontract.org/2004/07/LeisnerWCF.Enums")]
    public enum SpotSize : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        XS = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        S = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        M = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        L = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        XL = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBedwetterService")]
    public interface IBedwetterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBedwetterService/GetCustomer", ReplyAction="http://tempuri.org/IBedwetterService/GetCustomerResponse")]
        LeisnerWPF.ServiceReference1.Customer GetCustomer(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBedwetterService/GetCustomer", ReplyAction="http://tempuri.org/IBedwetterService/GetCustomerResponse")]
        System.Threading.Tasks.Task<LeisnerWPF.ServiceReference1.Customer> GetCustomerAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBedwetterService/SubmitQuestionnaire", ReplyAction="http://tempuri.org/IBedwetterService/SubmitQuestionnaireResponse")]
        bool SubmitQuestionnaire(LeisnerWPF.ServiceReference1.Questionnaire questionnaire, LeisnerWPF.ServiceReference1.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBedwetterService/SubmitQuestionnaire", ReplyAction="http://tempuri.org/IBedwetterService/SubmitQuestionnaireResponse")]
        System.Threading.Tasks.Task<bool> SubmitQuestionnaireAsync(LeisnerWPF.ServiceReference1.Questionnaire questionnaire, LeisnerWPF.ServiceReference1.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBedwetterService/GetAllCustomers", ReplyAction="http://tempuri.org/IBedwetterService/GetAllCustomersResponse")]
        LeisnerWPF.ServiceReference1.Customer[] GetAllCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBedwetterService/GetAllCustomers", ReplyAction="http://tempuri.org/IBedwetterService/GetAllCustomersResponse")]
        System.Threading.Tasks.Task<LeisnerWPF.ServiceReference1.Customer[]> GetAllCustomersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBedwetterServiceChannel : LeisnerWPF.ServiceReference1.IBedwetterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BedwetterServiceClient : System.ServiceModel.ClientBase<LeisnerWPF.ServiceReference1.IBedwetterService>, LeisnerWPF.ServiceReference1.IBedwetterService {
        
        public BedwetterServiceClient() {
        }
        
        public BedwetterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BedwetterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BedwetterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BedwetterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LeisnerWPF.ServiceReference1.Customer GetCustomer(string email) {
            return base.Channel.GetCustomer(email);
        }
        
        public System.Threading.Tasks.Task<LeisnerWPF.ServiceReference1.Customer> GetCustomerAsync(string email) {
            return base.Channel.GetCustomerAsync(email);
        }
        
        public bool SubmitQuestionnaire(LeisnerWPF.ServiceReference1.Questionnaire questionnaire, LeisnerWPF.ServiceReference1.Patient patient) {
            return base.Channel.SubmitQuestionnaire(questionnaire, patient);
        }
        
        public System.Threading.Tasks.Task<bool> SubmitQuestionnaireAsync(LeisnerWPF.ServiceReference1.Questionnaire questionnaire, LeisnerWPF.ServiceReference1.Patient patient) {
            return base.Channel.SubmitQuestionnaireAsync(questionnaire, patient);
        }
        
        public LeisnerWPF.ServiceReference1.Customer[] GetAllCustomers() {
            return base.Channel.GetAllCustomers();
        }
        
        public System.Threading.Tasks.Task<LeisnerWPF.ServiceReference1.Customer[]> GetAllCustomersAsync() {
            return base.Channel.GetAllCustomersAsync();
        }
    }
}