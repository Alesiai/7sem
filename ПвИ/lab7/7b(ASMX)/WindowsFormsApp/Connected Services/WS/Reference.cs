﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp.WS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://alesia.com/")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://alesia.com/", ConfigurationName="WS.asmxWSSoap")]
    public interface asmxWSSoap {
        
        // CODEGEN: Generating message contract since element name GetDataResult from namespace http://alesia.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/GetData", ReplyAction="*")]
        WindowsFormsApp.WS.GetDataResponse GetData(WindowsFormsApp.WS.GetDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/GetData", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp.WS.GetDataResponse> GetDataAsync(WindowsFormsApp.WS.GetDataRequest request);
        
        // CODEGEN: Generating message contract since element name user from namespace http://alesia.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/AddData", ReplyAction="*")]
        WindowsFormsApp.WS.AddDataResponse AddData(WindowsFormsApp.WS.AddDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/AddData", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp.WS.AddDataResponse> AddDataAsync(WindowsFormsApp.WS.AddDataRequest request);
        
        // CODEGEN: Generating message contract since element name user from namespace http://alesia.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/UpdateData", ReplyAction="*")]
        WindowsFormsApp.WS.UpdateDataResponse UpdateData(WindowsFormsApp.WS.UpdateDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/UpdateData", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp.WS.UpdateDataResponse> UpdateDataAsync(WindowsFormsApp.WS.UpdateDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/DeleteData", ReplyAction="*")]
        void DeleteData(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://alesia.com/DeleteData", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteDataAsync(int id);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetData", Namespace="http://alesia.com/", Order=0)]
        public WindowsFormsApp.WS.GetDataRequestBody Body;
        
        public GetDataRequest() {
        }
        
        public GetDataRequest(WindowsFormsApp.WS.GetDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetDataRequestBody {
        
        public GetDataRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDataResponse", Namespace="http://alesia.com/", Order=0)]
        public WindowsFormsApp.WS.GetDataResponseBody Body;
        
        public GetDataResponse() {
        }
        
        public GetDataResponse(WindowsFormsApp.WS.GetDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://alesia.com/")]
    public partial class GetDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp.WS.User[] GetDataResult;
        
        public GetDataResponseBody() {
        }
        
        public GetDataResponseBody(WindowsFormsApp.WS.User[] GetDataResult) {
            this.GetDataResult = GetDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddData", Namespace="http://alesia.com/", Order=0)]
        public WindowsFormsApp.WS.AddDataRequestBody Body;
        
        public AddDataRequest() {
        }
        
        public AddDataRequest(WindowsFormsApp.WS.AddDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://alesia.com/")]
    public partial class AddDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp.WS.User user;
        
        public AddDataRequestBody() {
        }
        
        public AddDataRequestBody(WindowsFormsApp.WS.User user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDataResponse", Namespace="http://alesia.com/", Order=0)]
        public WindowsFormsApp.WS.AddDataResponseBody Body;
        
        public AddDataResponse() {
        }
        
        public AddDataResponse(WindowsFormsApp.WS.AddDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddDataResponseBody {
        
        public AddDataResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateData", Namespace="http://alesia.com/", Order=0)]
        public WindowsFormsApp.WS.UpdateDataRequestBody Body;
        
        public UpdateDataRequest() {
        }
        
        public UpdateDataRequest(WindowsFormsApp.WS.UpdateDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://alesia.com/")]
    public partial class UpdateDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp.WS.User user;
        
        public UpdateDataRequestBody() {
        }
        
        public UpdateDataRequestBody(WindowsFormsApp.WS.User user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateDataResponse", Namespace="http://alesia.com/", Order=0)]
        public WindowsFormsApp.WS.UpdateDataResponseBody Body;
        
        public UpdateDataResponse() {
        }
        
        public UpdateDataResponse(WindowsFormsApp.WS.UpdateDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateDataResponseBody {
        
        public UpdateDataResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface asmxWSSoapChannel : WindowsFormsApp.WS.asmxWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class asmxWSSoapClient : System.ServiceModel.ClientBase<WindowsFormsApp.WS.asmxWSSoap>, WindowsFormsApp.WS.asmxWSSoap {
        
        public asmxWSSoapClient() {
        }
        
        public asmxWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public asmxWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public asmxWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public asmxWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp.WS.GetDataResponse WindowsFormsApp.WS.asmxWSSoap.GetData(WindowsFormsApp.WS.GetDataRequest request) {
            return base.Channel.GetData(request);
        }
        
        public WindowsFormsApp.WS.User[] GetData() {
            WindowsFormsApp.WS.GetDataRequest inValue = new WindowsFormsApp.WS.GetDataRequest();
            inValue.Body = new WindowsFormsApp.WS.GetDataRequestBody();
            WindowsFormsApp.WS.GetDataResponse retVal = ((WindowsFormsApp.WS.asmxWSSoap)(this)).GetData(inValue);
            return retVal.Body.GetDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp.WS.GetDataResponse> WindowsFormsApp.WS.asmxWSSoap.GetDataAsync(WindowsFormsApp.WS.GetDataRequest request) {
            return base.Channel.GetDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp.WS.GetDataResponse> GetDataAsync() {
            WindowsFormsApp.WS.GetDataRequest inValue = new WindowsFormsApp.WS.GetDataRequest();
            inValue.Body = new WindowsFormsApp.WS.GetDataRequestBody();
            return ((WindowsFormsApp.WS.asmxWSSoap)(this)).GetDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp.WS.AddDataResponse WindowsFormsApp.WS.asmxWSSoap.AddData(WindowsFormsApp.WS.AddDataRequest request) {
            return base.Channel.AddData(request);
        }
        
        public void AddData(WindowsFormsApp.WS.User user) {
            WindowsFormsApp.WS.AddDataRequest inValue = new WindowsFormsApp.WS.AddDataRequest();
            inValue.Body = new WindowsFormsApp.WS.AddDataRequestBody();
            inValue.Body.user = user;
            WindowsFormsApp.WS.AddDataResponse retVal = ((WindowsFormsApp.WS.asmxWSSoap)(this)).AddData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp.WS.AddDataResponse> WindowsFormsApp.WS.asmxWSSoap.AddDataAsync(WindowsFormsApp.WS.AddDataRequest request) {
            return base.Channel.AddDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp.WS.AddDataResponse> AddDataAsync(WindowsFormsApp.WS.User user) {
            WindowsFormsApp.WS.AddDataRequest inValue = new WindowsFormsApp.WS.AddDataRequest();
            inValue.Body = new WindowsFormsApp.WS.AddDataRequestBody();
            inValue.Body.user = user;
            return ((WindowsFormsApp.WS.asmxWSSoap)(this)).AddDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp.WS.UpdateDataResponse WindowsFormsApp.WS.asmxWSSoap.UpdateData(WindowsFormsApp.WS.UpdateDataRequest request) {
            return base.Channel.UpdateData(request);
        }
        
        public void UpdateData(WindowsFormsApp.WS.User user) {
            WindowsFormsApp.WS.UpdateDataRequest inValue = new WindowsFormsApp.WS.UpdateDataRequest();
            inValue.Body = new WindowsFormsApp.WS.UpdateDataRequestBody();
            inValue.Body.user = user;
            WindowsFormsApp.WS.UpdateDataResponse retVal = ((WindowsFormsApp.WS.asmxWSSoap)(this)).UpdateData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp.WS.UpdateDataResponse> WindowsFormsApp.WS.asmxWSSoap.UpdateDataAsync(WindowsFormsApp.WS.UpdateDataRequest request) {
            return base.Channel.UpdateDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp.WS.UpdateDataResponse> UpdateDataAsync(WindowsFormsApp.WS.User user) {
            WindowsFormsApp.WS.UpdateDataRequest inValue = new WindowsFormsApp.WS.UpdateDataRequest();
            inValue.Body = new WindowsFormsApp.WS.UpdateDataRequestBody();
            inValue.Body.user = user;
            return ((WindowsFormsApp.WS.asmxWSSoap)(this)).UpdateDataAsync(inValue);
        }
        
        public void DeleteData(int id) {
            base.Channel.DeleteData(id);
        }
        
        public System.Threading.Tasks.Task DeleteDataAsync(int id) {
            return base.Channel.DeleteDataAsync(id);
        }
    }
}
