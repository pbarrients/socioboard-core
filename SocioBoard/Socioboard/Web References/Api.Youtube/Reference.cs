﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
// 
#pragma warning disable 1591

namespace Socioboard.Api.Youtube {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="YoutubeSoap", Namespace="http://tempuri.org/")]
    public partial class Youtube : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddYoutubeAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetYoutubeChannelVideosOperationCompleted;
        
        private System.Threading.SendOrPostCallback GoogleLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback Get_Channel_List_serarchOperationCompleted;
        
        private System.Threading.SendOrPostCallback getYoutubeDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback SheduleYoutubeMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateYouTubeAccountByAdminOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddYoutubeAccountwithLoginOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Youtube() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_Youtube_Youtube;
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
        public event AddYoutubeAccountCompletedEventHandler AddYoutubeAccountCompleted;
        
        /// <remarks/>
        public event GetYoutubeChannelVideosCompletedEventHandler GetYoutubeChannelVideosCompleted;
        
        /// <remarks/>
        public event GoogleLoginCompletedEventHandler GoogleLoginCompleted;
        
        /// <remarks/>
        public event Get_Channel_List_serarchCompletedEventHandler Get_Channel_List_serarchCompleted;
        
        /// <remarks/>
        public event getYoutubeDataCompletedEventHandler getYoutubeDataCompleted;
        
        /// <remarks/>
        public event SheduleYoutubeMessageCompletedEventHandler SheduleYoutubeMessageCompleted;
        
        /// <remarks/>
        public event UpdateYouTubeAccountByAdminCompletedEventHandler UpdateYouTubeAccountByAdminCompleted;
        
        /// <remarks/>
        public event AddYoutubeAccountwithLoginCompletedEventHandler AddYoutubeAccountwithLoginCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddYoutubeAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddYoutubeAccount(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            object[] results = this.Invoke("AddYoutubeAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddYoutubeAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            this.AddYoutubeAccountAsync(client_id, client_secret, redirect_uri, UserId, GroupId, code, null);
        }
        
        /// <remarks/>
        public void AddYoutubeAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code, object userState) {
            if ((this.AddYoutubeAccountOperationCompleted == null)) {
                this.AddYoutubeAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddYoutubeAccountOperationCompleted);
            }
            this.InvokeAsync("AddYoutubeAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code}, this.AddYoutubeAccountOperationCompleted, userState);
        }
        
        private void OnAddYoutubeAccountOperationCompleted(object arg) {
            if ((this.AddYoutubeAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddYoutubeAccountCompleted(this, new AddYoutubeAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetYoutubeChannelVideos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetYoutubeChannelVideos(string userid, string profileid) {
            object[] results = this.Invoke("GetYoutubeChannelVideos", new object[] {
                        userid,
                        profileid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetYoutubeChannelVideosAsync(string userid, string profileid) {
            this.GetYoutubeChannelVideosAsync(userid, profileid, null);
        }
        
        /// <remarks/>
        public void GetYoutubeChannelVideosAsync(string userid, string profileid, object userState) {
            if ((this.GetYoutubeChannelVideosOperationCompleted == null)) {
                this.GetYoutubeChannelVideosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetYoutubeChannelVideosOperationCompleted);
            }
            this.InvokeAsync("GetYoutubeChannelVideos", new object[] {
                        userid,
                        profileid}, this.GetYoutubeChannelVideosOperationCompleted, userState);
        }
        
        private void OnGetYoutubeChannelVideosOperationCompleted(object arg) {
            if ((this.GetYoutubeChannelVideosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetYoutubeChannelVideosCompleted(this, new GetYoutubeChannelVideosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GoogleLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GoogleLogin(string code) {
            object[] results = this.Invoke("GoogleLogin", new object[] {
                        code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GoogleLoginAsync(string code) {
            this.GoogleLoginAsync(code, null);
        }
        
        /// <remarks/>
        public void GoogleLoginAsync(string code, object userState) {
            if ((this.GoogleLoginOperationCompleted == null)) {
                this.GoogleLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGoogleLoginOperationCompleted);
            }
            this.InvokeAsync("GoogleLogin", new object[] {
                        code}, this.GoogleLoginOperationCompleted, userState);
        }
        
        private void OnGoogleLoginOperationCompleted(object arg) {
            if ((this.GoogleLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GoogleLoginCompleted(this, new GoogleLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get_Channel_List_serarch", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Get_Channel_List_serarch(string token, string search) {
            this.Invoke("Get_Channel_List_serarch", new object[] {
                        token,
                        search});
        }
        
        /// <remarks/>
        public void Get_Channel_List_serarchAsync(string token, string search) {
            this.Get_Channel_List_serarchAsync(token, search, null);
        }
        
        /// <remarks/>
        public void Get_Channel_List_serarchAsync(string token, string search, object userState) {
            if ((this.Get_Channel_List_serarchOperationCompleted == null)) {
                this.Get_Channel_List_serarchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet_Channel_List_serarchOperationCompleted);
            }
            this.InvokeAsync("Get_Channel_List_serarch", new object[] {
                        token,
                        search}, this.Get_Channel_List_serarchOperationCompleted, userState);
        }
        
        private void OnGet_Channel_List_serarchOperationCompleted(object arg) {
            if ((this.Get_Channel_List_serarchCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get_Channel_List_serarchCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getYoutubeData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getYoutubeData(string UserId, string youtubeId) {
            object[] results = this.Invoke("getYoutubeData", new object[] {
                        UserId,
                        youtubeId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getYoutubeDataAsync(string UserId, string youtubeId) {
            this.getYoutubeDataAsync(UserId, youtubeId, null);
        }
        
        /// <remarks/>
        public void getYoutubeDataAsync(string UserId, string youtubeId, object userState) {
            if ((this.getYoutubeDataOperationCompleted == null)) {
                this.getYoutubeDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetYoutubeDataOperationCompleted);
            }
            this.InvokeAsync("getYoutubeData", new object[] {
                        UserId,
                        youtubeId}, this.getYoutubeDataOperationCompleted, userState);
        }
        
        private void OngetYoutubeDataOperationCompleted(object arg) {
            if ((this.getYoutubeDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getYoutubeDataCompleted(this, new getYoutubeDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SheduleYoutubeMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SheduleYoutubeMessage(string YoutubeId, string UserId, string sscheduledmsgguid) {
            object[] results = this.Invoke("SheduleYoutubeMessage", new object[] {
                        YoutubeId,
                        UserId,
                        sscheduledmsgguid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SheduleYoutubeMessageAsync(string YoutubeId, string UserId, string sscheduledmsgguid) {
            this.SheduleYoutubeMessageAsync(YoutubeId, UserId, sscheduledmsgguid, null);
        }
        
        /// <remarks/>
        public void SheduleYoutubeMessageAsync(string YoutubeId, string UserId, string sscheduledmsgguid, object userState) {
            if ((this.SheduleYoutubeMessageOperationCompleted == null)) {
                this.SheduleYoutubeMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSheduleYoutubeMessageOperationCompleted);
            }
            this.InvokeAsync("SheduleYoutubeMessage", new object[] {
                        YoutubeId,
                        UserId,
                        sscheduledmsgguid}, this.SheduleYoutubeMessageOperationCompleted, userState);
        }
        
        private void OnSheduleYoutubeMessageOperationCompleted(object arg) {
            if ((this.SheduleYoutubeMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SheduleYoutubeMessageCompleted(this, new SheduleYoutubeMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateYouTubeAccountByAdmin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateYouTubeAccountByAdmin(string ObjYouTube) {
            object[] results = this.Invoke("UpdateYouTubeAccountByAdmin", new object[] {
                        ObjYouTube});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateYouTubeAccountByAdminAsync(string ObjYouTube) {
            this.UpdateYouTubeAccountByAdminAsync(ObjYouTube, null);
        }
        
        /// <remarks/>
        public void UpdateYouTubeAccountByAdminAsync(string ObjYouTube, object userState) {
            if ((this.UpdateYouTubeAccountByAdminOperationCompleted == null)) {
                this.UpdateYouTubeAccountByAdminOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateYouTubeAccountByAdminOperationCompleted);
            }
            this.InvokeAsync("UpdateYouTubeAccountByAdmin", new object[] {
                        ObjYouTube}, this.UpdateYouTubeAccountByAdminOperationCompleted, userState);
        }
        
        private void OnUpdateYouTubeAccountByAdminOperationCompleted(object arg) {
            if ((this.UpdateYouTubeAccountByAdminCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateYouTubeAccountByAdminCompleted(this, new UpdateYouTubeAccountByAdminCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddYoutubeAccountwithLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddYoutubeAccountwithLogin(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string access_token) {
            object[] results = this.Invoke("AddYoutubeAccountwithLogin", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        access_token});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddYoutubeAccountwithLoginAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string access_token) {
            this.AddYoutubeAccountwithLoginAsync(client_id, client_secret, redirect_uri, UserId, GroupId, access_token, null);
        }
        
        /// <remarks/>
        public void AddYoutubeAccountwithLoginAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string access_token, object userState) {
            if ((this.AddYoutubeAccountwithLoginOperationCompleted == null)) {
                this.AddYoutubeAccountwithLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddYoutubeAccountwithLoginOperationCompleted);
            }
            this.InvokeAsync("AddYoutubeAccountwithLogin", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        access_token}, this.AddYoutubeAccountwithLoginOperationCompleted, userState);
        }
        
        private void OnAddYoutubeAccountwithLoginOperationCompleted(object arg) {
            if ((this.AddYoutubeAccountwithLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddYoutubeAccountwithLoginCompleted(this, new AddYoutubeAccountwithLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void AddYoutubeAccountCompletedEventHandler(object sender, AddYoutubeAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddYoutubeAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddYoutubeAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetYoutubeChannelVideosCompletedEventHandler(object sender, GetYoutubeChannelVideosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetYoutubeChannelVideosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetYoutubeChannelVideosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GoogleLoginCompletedEventHandler(object sender, GoogleLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GoogleLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GoogleLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void Get_Channel_List_serarchCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getYoutubeDataCompletedEventHandler(object sender, getYoutubeDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getYoutubeDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getYoutubeDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void SheduleYoutubeMessageCompletedEventHandler(object sender, SheduleYoutubeMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SheduleYoutubeMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SheduleYoutubeMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void UpdateYouTubeAccountByAdminCompletedEventHandler(object sender, UpdateYouTubeAccountByAdminCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateYouTubeAccountByAdminCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateYouTubeAccountByAdminCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void AddYoutubeAccountwithLoginCompletedEventHandler(object sender, AddYoutubeAccountwithLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddYoutubeAccountwithLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddYoutubeAccountwithLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591