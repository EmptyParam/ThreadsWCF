﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CommStaClassLibrary.CommSta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService", Namespace="http://tempuri.org/")]
    public partial class CommStaService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VKontakte_StaOperationCompleted;
        
        private System.Threading.SendOrPostCallback VKontakte_Sta_ByDateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CommStaService() {
            this.Url = global::CommStaClassLibrary.Properties.Settings.Default.CommStaClassLibrary_CommStaService_CommStaService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event VKontakte_StaCompletedEventHandler VKontakte_StaCompleted;
        
        /// <remarks/>
        public event VKontakte_Sta_ByDateCompletedEventHandler VKontakte_Sta_ByDateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/VKontakte_Sta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VKontakte_Sta([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] wsRequest req) {
            this.Invoke("VKontakte_Sta", new object[] {
                        req});
        }
        
        /// <remarks/>
        public void VKontakte_StaAsync(wsRequest req) {
            this.VKontakte_StaAsync(req, null);
        }
        
        /// <remarks/>
        public void VKontakte_StaAsync(wsRequest req, object userState) {
            if ((this.VKontakte_StaOperationCompleted == null)) {
                this.VKontakte_StaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVKontakte_StaOperationCompleted);
            }
            this.InvokeAsync("VKontakte_Sta", new object[] {
                        req}, this.VKontakte_StaOperationCompleted, userState);
        }
        
        private void OnVKontakte_StaOperationCompleted(object arg) {
            if ((this.VKontakte_StaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VKontakte_StaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService/VKontakte_Sta_ByDate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void VKontakte_Sta_ByDate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] wsRequestByDate req) {
            this.Invoke("VKontakte_Sta_ByDate", new object[] {
                        req});
        }
        
        /// <remarks/>
        public void VKontakte_Sta_ByDateAsync(wsRequestByDate req) {
            this.VKontakte_Sta_ByDateAsync(req, null);
        }
        
        /// <remarks/>
        public void VKontakte_Sta_ByDateAsync(wsRequestByDate req, object userState) {
            if ((this.VKontakte_Sta_ByDateOperationCompleted == null)) {
                this.VKontakte_Sta_ByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVKontakte_Sta_ByDateOperationCompleted);
            }
            this.InvokeAsync("VKontakte_Sta_ByDate", new object[] {
                        req}, this.VKontakte_Sta_ByDateOperationCompleted, userState);
        }
        
        private void OnVKontakte_Sta_ByDateOperationCompleted(object arg) {
            if ((this.VKontakte_Sta_ByDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VKontakte_Sta_ByDateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(wsRequestByDate))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/CommSta")]
    public partial class wsRequest {
        
        private long groupIDField;
        
        private bool groupIDFieldSpecified;
        
        /// <remarks/>
        public long groupID {
            get {
                return this.groupIDField;
            }
            set {
                this.groupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool groupIDSpecified {
            get {
                return this.groupIDFieldSpecified;
            }
            set {
                this.groupIDFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/CommSta")]
    public partial class wsRequestByDate : wsRequest {
        
        private System.DateTime dateFromField;
        
        private bool dateFromFieldSpecified;
        
        private System.DateTime dateToField;
        
        private bool dateToFieldSpecified;
        
        /// <remarks/>
        public System.DateTime dateFrom {
            get {
                return this.dateFromField;
            }
            set {
                this.dateFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateFromSpecified {
            get {
                return this.dateFromFieldSpecified;
            }
            set {
                this.dateFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dateTo {
            get {
                return this.dateToField;
            }
            set {
                this.dateToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateToSpecified {
            get {
                return this.dateToFieldSpecified;
            }
            set {
                this.dateToFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void VKontakte_StaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void VKontakte_Sta_ByDateCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591