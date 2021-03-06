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

namespace CheckInAppV3.checkInRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ICheck_InService", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class Check_InService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SetValueOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetValueOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginAccessOperationCompleted;
        
        private System.Threading.SendOrPostCallback sendMassageOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCoordinatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddNewCoordinatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback SignUpUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Check_InService() {
            this.Url = "http://89.252.8.148:1488/Check_InService.svc";
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
        public event SetValueCompletedEventHandler SetValueCompleted;
        
        /// <remarks/>
        public event GetValueCompletedEventHandler GetValueCompleted;
        
        /// <remarks/>
        public event LoginAccessCompletedEventHandler LoginAccessCompleted;
        
        /// <remarks/>
        public event sendMassageCompletedEventHandler sendMassageCompleted;
        
        /// <remarks/>
        public event GetCoordinatesCompletedEventHandler GetCoordinatesCompleted;
        
        /// <remarks/>
        public event AddNewCoordinatesCompletedEventHandler AddNewCoordinatesCompleted;
        
        /// <remarks/>
        public event SignUpUserCompletedEventHandler SignUpUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICheck_InService/SetValue", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetValue(LoginInfo val) {
            this.Invoke("SetValue", new object[] {
                        val});
        }
        
        /// <remarks/>
        public void SetValueAsync(LoginInfo val) {
            this.SetValueAsync(val, null);
        }
        
        /// <remarks/>
        public void SetValueAsync(LoginInfo val, object userState) {
            if ((this.SetValueOperationCompleted == null)) {
                this.SetValueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetValueOperationCompleted);
            }
            this.InvokeAsync("SetValue", new object[] {
                        val}, this.SetValueOperationCompleted, userState);
        }
        
        private void OnSetValueOperationCompleted(object arg) {
            if ((this.SetValueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetValueCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICheck_InService/GetValue", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LoginInfo GetValue(int index) {
            object[] results = this.Invoke("GetValue", new object[] {
                        index});
            return ((LoginInfo)(results[0]));
        }
        
        /// <remarks/>
        public void GetValueAsync(int index) {
            this.GetValueAsync(index, null);
        }
        
        /// <remarks/>
        public void GetValueAsync(int index, object userState) {
            if ((this.GetValueOperationCompleted == null)) {
                this.GetValueOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetValueOperationCompleted);
            }
            this.InvokeAsync("GetValue", new object[] {
                        index}, this.GetValueOperationCompleted, userState);
        }
        
        private void OnGetValueOperationCompleted(object arg) {
            if ((this.GetValueCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetValueCompleted(this, new GetValueCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICheck_InService/LoginAccess", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LoginAccess(string email, string pass) {
            object[] results = this.Invoke("LoginAccess", new object[] {
                        email,
                        pass});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAccessAsync(string email, string pass) {
            this.LoginAccessAsync(email, pass, null);
        }
        
        /// <remarks/>
        public void LoginAccessAsync(string email, string pass, object userState) {
            if ((this.LoginAccessOperationCompleted == null)) {
                this.LoginAccessOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginAccessOperationCompleted);
            }
            this.InvokeAsync("LoginAccess", new object[] {
                        email,
                        pass}, this.LoginAccessOperationCompleted, userState);
        }
        
        private void OnLoginAccessOperationCompleted(object arg) {
            if ((this.LoginAccessCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginAccessCompleted(this, new LoginAccessCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICheck_InService/sendMassage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string sendMassage(string msg, string msg2) {
            object[] results = this.Invoke("sendMassage", new object[] {
                        msg,
                        msg2});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void sendMassageAsync(string msg, string msg2) {
            this.sendMassageAsync(msg, msg2, null);
        }
        
        /// <remarks/>
        public void sendMassageAsync(string msg, string msg2, object userState) {
            if ((this.sendMassageOperationCompleted == null)) {
                this.sendMassageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendMassageOperationCompleted);
            }
            this.InvokeAsync("sendMassage", new object[] {
                        msg,
                        msg2}, this.sendMassageOperationCompleted, userState);
        }
        
        private void OnsendMassageOperationCompleted(object arg) {
            if ((this.sendMassageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendMassageCompleted(this, new sendMassageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICheck_InService/GetCoordinates", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetCoordinates(string login) {
            object[] results = this.Invoke("GetCoordinates", new object[] {
                        login});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCoordinatesAsync(string login) {
            this.GetCoordinatesAsync(login, null);
        }
        
        /// <remarks/>
        public void GetCoordinatesAsync(string login, object userState) {
            if ((this.GetCoordinatesOperationCompleted == null)) {
                this.GetCoordinatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCoordinatesOperationCompleted);
            }
            this.InvokeAsync("GetCoordinates", new object[] {
                        login}, this.GetCoordinatesOperationCompleted, userState);
        }
        
        private void OnGetCoordinatesOperationCompleted(object arg) {
            if ((this.GetCoordinatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCoordinatesCompleted(this, new GetCoordinatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICheck_InService/AddNewCoordinates", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddNewCoordinates(double lat, double lon, string user) {
            this.Invoke("AddNewCoordinates", new object[] {
                        lat,
                        lon,
                        user});
        }
        
        /// <remarks/>
        public void AddNewCoordinatesAsync(double lat, double lon, string user) {
            this.AddNewCoordinatesAsync(lat, lon, user, null);
        }
        
        /// <remarks/>
        public void AddNewCoordinatesAsync(double lat, double lon, string user, object userState) {
            if ((this.AddNewCoordinatesOperationCompleted == null)) {
                this.AddNewCoordinatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddNewCoordinatesOperationCompleted);
            }
            this.InvokeAsync("AddNewCoordinates", new object[] {
                        lat,
                        lon,
                        user}, this.AddNewCoordinatesOperationCompleted, userState);
        }
        
        private void OnAddNewCoordinatesOperationCompleted(object arg) {
            if ((this.AddNewCoordinatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddNewCoordinatesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICheck_InService/SignUpUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SignUpUser(string log, string pas, string mail) {
            object[] results = this.Invoke("SignUpUser", new object[] {
                        log,
                        pas,
                        mail});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SignUpUserAsync(string log, string pas, string mail) {
            this.SignUpUserAsync(log, pas, mail, null);
        }
        
        /// <remarks/>
        public void SignUpUserAsync(string log, string pas, string mail, object userState) {
            if ((this.SignUpUserOperationCompleted == null)) {
                this.SignUpUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSignUpUserOperationCompleted);
            }
            this.InvokeAsync("SignUpUser", new object[] {
                        log,
                        pas,
                        mail}, this.SignUpUserOperationCompleted, userState);
        }
        
        private void OnSignUpUserOperationCompleted(object arg) {
            if ((this.SignUpUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SignUpUserCompleted(this, new SignUpUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginInfo {
        
        private string loginField;
        
        private string passwordField;
        
        private string emailField;
        
        /// <remarks/>
        public string Login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SetValueCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetValueCompletedEventHandler(object sender, GetValueCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetValueCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetValueCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LoginInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LoginInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LoginAccessCompletedEventHandler(object sender, LoginAccessCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginAccessCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginAccessCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void sendMassageCompletedEventHandler(object sender, sendMassageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendMassageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendMassageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetCoordinatesCompletedEventHandler(object sender, GetCoordinatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCoordinatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCoordinatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void AddNewCoordinatesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SignUpUserCompletedEventHandler(object sender, SignUpUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SignUpUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SignUpUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591