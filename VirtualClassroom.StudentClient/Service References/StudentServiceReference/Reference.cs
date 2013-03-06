﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualClassroom.StudentClient.StudentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/VirtualClassroom.Services.Models")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClassIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EGNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private VirtualClassroom.StudentClient.StudentServiceReference.Homework[] HomeworksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public int ClassId {
            get {
                return this.ClassIdField;
            }
            set {
                if ((this.ClassIdField.Equals(value) != true)) {
                    this.ClassIdField = value;
                    this.RaisePropertyChanged("ClassId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EGN {
            get {
                return this.EGNField;
            }
            set {
                if ((object.ReferenceEquals(this.EGNField, value) != true)) {
                    this.EGNField = value;
                    this.RaisePropertyChanged("EGN");
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
        public VirtualClassroom.StudentClient.StudentServiceReference.Homework[] Homeworks {
            get {
                return this.HomeworksField;
            }
            set {
                if ((object.ReferenceEquals(this.HomeworksField, value) != true)) {
                    this.HomeworksField = value;
                    this.RaisePropertyChanged("Homeworks");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Homework", Namespace="http://schemas.datacontract.org/2004/07/VirtualClassroom.Services.Models")]
    [System.SerializableAttribute()]
    public partial class Homework : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LessonIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private VirtualClassroom.StudentClient.StudentServiceReference.Mark[] MarksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIdField;
        
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
        public byte[] Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
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
        public string Filename {
            get {
                return this.FilenameField;
            }
            set {
                if ((object.ReferenceEquals(this.FilenameField, value) != true)) {
                    this.FilenameField = value;
                    this.RaisePropertyChanged("Filename");
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
        public int LessonId {
            get {
                return this.LessonIdField;
            }
            set {
                if ((this.LessonIdField.Equals(value) != true)) {
                    this.LessonIdField = value;
                    this.RaisePropertyChanged("LessonId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public VirtualClassroom.StudentClient.StudentServiceReference.Mark[] Marks {
            get {
                return this.MarksField;
            }
            set {
                if ((object.ReferenceEquals(this.MarksField, value) != true)) {
                    this.MarksField = value;
                    this.RaisePropertyChanged("Marks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentId {
            get {
                return this.StudentIdField;
            }
            set {
                if ((this.StudentIdField.Equals(value) != true)) {
                    this.StudentIdField = value;
                    this.RaisePropertyChanged("StudentId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Mark", Namespace="http://schemas.datacontract.org/2004/07/VirtualClassroom.Services.Models")]
    [System.SerializableAttribute()]
    public partial class Mark : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HomeworkIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LessonNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ValueField;
        
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
        public int HomeworkId {
            get {
                return this.HomeworkIdField;
            }
            set {
                if ((this.HomeworkIdField.Equals(value) != true)) {
                    this.HomeworkIdField = value;
                    this.RaisePropertyChanged("HomeworkId");
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
        public string LessonName {
            get {
                return this.LessonNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LessonNameField, value) != true)) {
                    this.LessonNameField = value;
                    this.RaisePropertyChanged("LessonName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectName {
            get {
                return this.SubjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectNameField, value) != true)) {
                    this.SubjectNameField = value;
                    this.RaisePropertyChanged("SubjectName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LessonView", Namespace="http://schemas.datacontract.org/2004/07/VirtualClassroom.Services.Views")]
    [System.SerializableAttribute()]
    public partial class LessonView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasHomeworkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> HomeworkDeadlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SentHomeworkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
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
        public bool HasHomework {
            get {
                return this.HasHomeworkField;
            }
            set {
                if ((this.HasHomeworkField.Equals(value) != true)) {
                    this.HasHomeworkField = value;
                    this.RaisePropertyChanged("HasHomework");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> HomeworkDeadline {
            get {
                return this.HomeworkDeadlineField;
            }
            set {
                if ((this.HomeworkDeadlineField.Equals(value) != true)) {
                    this.HomeworkDeadlineField = value;
                    this.RaisePropertyChanged("HomeworkDeadline");
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
        public bool SentHomework {
            get {
                return this.SentHomeworkField;
            }
            set {
                if ((this.SentHomeworkField.Equals(value) != true)) {
                    this.SentHomeworkField = value;
                    this.RaisePropertyChanged("SentHomework");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/VirtualClassroom.Services.Models")]
    [System.SerializableAttribute()]
    public partial class File : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilenameField;
        
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
        public byte[] Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Filename {
            get {
                return this.FilenameField;
            }
            set {
                if ((object.ReferenceEquals(this.FilenameField, value) != true)) {
                    this.FilenameField = value;
                    this.RaisePropertyChanged("Filename");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentServiceReference.IStudentService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IStudentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/LoginStudent", ReplyAction="http://tempuri.org/IStudentService/LoginStudentResponse")]
        VirtualClassroom.StudentClient.StudentServiceReference.Student LoginStudent(string usernameCrypt, string passwordCrypt, string secret);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetLessonViewsByStudent", ReplyAction="http://tempuri.org/IStudentService/GetLessonViewsByStudentResponse")]
        VirtualClassroom.StudentClient.StudentServiceReference.LessonView[] GetLessonViewsByStudent(int studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/DownloadLessonContent", ReplyAction="http://tempuri.org/IStudentService/DownloadLessonContentResponse")]
        VirtualClassroom.StudentClient.StudentServiceReference.File DownloadLessonContent(int lessonId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/DownloadSentHomework", ReplyAction="http://tempuri.org/IStudentService/DownloadSentHomeworkResponse")]
        VirtualClassroom.StudentClient.StudentServiceReference.File DownloadSentHomework(int studentId, int lessonId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/DownloadLessonHomework", ReplyAction="http://tempuri.org/IStudentService/DownloadLessonHomeworkResponse")]
        VirtualClassroom.StudentClient.StudentServiceReference.File DownloadLessonHomework(int lessonId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/AddHomework", ReplyAction="http://tempuri.org/IStudentService/AddHomeworkResponse")]
        void AddHomework(VirtualClassroom.StudentClient.StudentServiceReference.Homework homework);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetHomeworksByStudent", ReplyAction="http://tempuri.org/IStudentService/GetHomeworksByStudentResponse")]
        VirtualClassroom.StudentClient.StudentServiceReference.Homework[] GetHomeworksByStudent(int studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetMarksByStudent", ReplyAction="http://tempuri.org/IStudentService/GetMarksByStudentResponse")]
        VirtualClassroom.StudentClient.StudentServiceReference.Mark[] GetMarksByStudent(int studentId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentServiceChannel : VirtualClassroom.StudentClient.StudentServiceReference.IStudentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<VirtualClassroom.StudentClient.StudentServiceReference.IStudentService>, VirtualClassroom.StudentClient.StudentServiceReference.IStudentService {
        
        public StudentServiceClient() {
        }
        
        public StudentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VirtualClassroom.StudentClient.StudentServiceReference.Student LoginStudent(string usernameCrypt, string passwordCrypt, string secret) {
            return base.Channel.LoginStudent(usernameCrypt, passwordCrypt, secret);
        }
        
        public VirtualClassroom.StudentClient.StudentServiceReference.LessonView[] GetLessonViewsByStudent(int studentId) {
            return base.Channel.GetLessonViewsByStudent(studentId);
        }
        
        public VirtualClassroom.StudentClient.StudentServiceReference.File DownloadLessonContent(int lessonId) {
            return base.Channel.DownloadLessonContent(lessonId);
        }
        
        public VirtualClassroom.StudentClient.StudentServiceReference.File DownloadSentHomework(int studentId, int lessonId) {
            return base.Channel.DownloadSentHomework(studentId, lessonId);
        }
        
        public VirtualClassroom.StudentClient.StudentServiceReference.File DownloadLessonHomework(int lessonId) {
            return base.Channel.DownloadLessonHomework(lessonId);
        }
        
        public void AddHomework(VirtualClassroom.StudentClient.StudentServiceReference.Homework homework) {
            base.Channel.AddHomework(homework);
        }
        
        public VirtualClassroom.StudentClient.StudentServiceReference.Homework[] GetHomeworksByStudent(int studentId) {
            return base.Channel.GetHomeworksByStudent(studentId);
        }
        
        public VirtualClassroom.StudentClient.StudentServiceReference.Mark[] GetMarksByStudent(int studentId) {
            return base.Channel.GetMarksByStudent(studentId);
        }
    }
}
