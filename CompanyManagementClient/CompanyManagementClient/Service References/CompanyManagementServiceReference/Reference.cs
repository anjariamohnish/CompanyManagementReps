﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyManagementClient.CompanyManagementServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BOProject", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayerEntities")]
    [System.SerializableAttribute()]
    public partial class BOProject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DepartmentMasterIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProjectManagerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusMasterIdField;
        
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
        public int ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((this.ClientIdField.Equals(value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DepartmentMasterId {
            get {
                return this.DepartmentMasterIdField;
            }
            set {
                if ((this.DepartmentMasterIdField.Equals(value) != true)) {
                    this.DepartmentMasterIdField = value;
                    this.RaisePropertyChanged("DepartmentMasterId");
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
        public int ProjectManagerId {
            get {
                return this.ProjectManagerIdField;
            }
            set {
                if ((this.ProjectManagerIdField.Equals(value) != true)) {
                    this.ProjectManagerIdField = value;
                    this.RaisePropertyChanged("ProjectManagerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StatusMasterId {
            get {
                return this.StatusMasterIdField;
            }
            set {
                if ((this.StatusMasterIdField.Equals(value) != true)) {
                    this.StatusMasterIdField = value;
                    this.RaisePropertyChanged("StatusMasterId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BOTask", Namespace="http://schemas.datacontract.org/2004/07/BusinessLayerEntities")]
    [System.SerializableAttribute()]
    public partial class BOTask : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TechnologyMasterIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UpdateDateField;
        
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
        public int StatusId {
            get {
                return this.StatusIdField;
            }
            set {
                if ((this.StatusIdField.Equals(value) != true)) {
                    this.StatusIdField = value;
                    this.RaisePropertyChanged("StatusId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TechnologyMasterId {
            get {
                return this.TechnologyMasterIdField;
            }
            set {
                if ((this.TechnologyMasterIdField.Equals(value) != true)) {
                    this.TechnologyMasterIdField = value;
                    this.RaisePropertyChanged("TechnologyMasterId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdateDate {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyManagementServiceReference.ICompanyMangementService")]
    public interface ICompanyMangementService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyMangementService/DeleteTechnology", ReplyAction="http://tempuri.org/ICompanyMangementService/DeleteTechnologyResponse")]
        string DeleteTechnology(int technologyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyMangementService/AssignTechnologyToTask", ReplyAction="http://tempuri.org/ICompanyMangementService/AssignTechnologyToTaskResponse")]
        string AssignTechnologyToTask(int technologyId, int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyMangementService/AddProject", ReplyAction="http://tempuri.org/ICompanyMangementService/AddProjectResponse")]
        string AddProject(CompanyManagementClient.CompanyManagementServiceReference.BOProject project);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyMangementService/AssignEmployeeToProject", ReplyAction="http://tempuri.org/ICompanyMangementService/AssignEmployeeToProjectResponse")]
        string AssignEmployeeToProject(int employeeId, int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyMangementService/DeleteTask", ReplyAction="http://tempuri.org/ICompanyMangementService/DeleteTaskResponse")]
        string DeleteTask(int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyMangementService/DeleteProject", ReplyAction="http://tempuri.org/ICompanyMangementService/DeleteProjectResponse")]
        string DeleteProject(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyMangementService/CreateTaskInProject", ReplyAction="http://tempuri.org/ICompanyMangementService/CreateTaskInProjectResponse")]
        string CreateTaskInProject(CompanyManagementClient.CompanyManagementServiceReference.BOTask task, int projectId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyMangementServiceChannel : CompanyManagementClient.CompanyManagementServiceReference.ICompanyMangementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyMangementServiceClient : System.ServiceModel.ClientBase<CompanyManagementClient.CompanyManagementServiceReference.ICompanyMangementService>, CompanyManagementClient.CompanyManagementServiceReference.ICompanyMangementService {
        
        public CompanyMangementServiceClient() {
        }
        
        public CompanyMangementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyMangementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyMangementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyMangementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DeleteTechnology(int technologyId) {
            return base.Channel.DeleteTechnology(technologyId);
        }
        
        public string AssignTechnologyToTask(int technologyId, int taskId) {
            return base.Channel.AssignTechnologyToTask(technologyId, taskId);
        }
        
        public string AddProject(CompanyManagementClient.CompanyManagementServiceReference.BOProject project) {
            return base.Channel.AddProject(project);
        }
        
        public string AssignEmployeeToProject(int employeeId, int projectId) {
            return base.Channel.AssignEmployeeToProject(employeeId, projectId);
        }
        
        public string DeleteTask(int taskId) {
            return base.Channel.DeleteTask(taskId);
        }
        
        public string DeleteProject(int projectId) {
            return base.Channel.DeleteProject(projectId);
        }
        
        public string CreateTaskInProject(CompanyManagementClient.CompanyManagementServiceReference.BOTask task, int projectId) {
            return base.Channel.CreateTaskInProject(task, projectId);
        }
    }
}