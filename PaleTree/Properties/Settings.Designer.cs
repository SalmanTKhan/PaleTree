﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaleTree.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int X {
            get {
                return ((int)(this["X"]));
            }
            set {
                this["X"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int Y {
            get {
                return ((int)(this["Y"]));
            }
            set {
                this["Y"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Maximized {
            get {
                return ((bool)(this["Maximized"]));
            }
            set {
                this["Maximized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FilterRecvEnabled {
            get {
                return ((bool)(this["FilterRecvEnabled"]));
            }
            set {
                this["FilterRecvEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FilterSendEnabled {
            get {
                return ((bool)(this["FilterSendEnabled"]));
            }
            set {
                this["FilterSendEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1140")]
        public int Width {
            get {
                return ((int)(this["Width"]));
            }
            set {
                this["Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("700")]
        public int Height {
            get {
                return ((int)(this["Height"]));
            }
            set {
                this["Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FilterRecv {
            get {
                return ((string)(this["FilterRecv"]));
            }
            set {
                this["FilterRecv"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FilterSend {
            get {
                return ((string)(this["FilterSend"]));
            }
            set {
                this["FilterSend"] = value;
            }
        }
    }
}
