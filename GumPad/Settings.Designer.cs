﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GumPad {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TransliterateAsEntityCode {
            get {
                return ((bool)(this["TransliterateAsEntityCode"]));
            }
            set {
                this["TransliterateAsEntityCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Devanagari")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConvertAsYouType {
            get {
                return ((bool)(this["ConvertAsYouType"]));
            }
            set {
                this["ConvertAsYouType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WordWrap {
            get {
                return ((bool)(this["WordWrap"]));
            }
            set {
                this["WordWrap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DefaultFileFilterIndex {
            get {
                return ((int)(this["DefaultFileFilterIndex"]));
            }
            set {
                this["DefaultFileFilterIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public string ConversionSchemeName {
            get {
                return ((string)(this["ConversionSchemeName"]));
            }
            set {
                this["ConversionSchemeName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GumPad built-in conversion map")]
        public string ConversionSchemeDescription {
            get {
                return ((string)(this["ConversionSchemeDescription"]));
            }
            set {
                this["ConversionSchemeDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Off")]
        public global::System.Diagnostics.TraceLevel TraceLevel {
            get {
                return ((global::System.Diagnostics.TraceLevel)(this["TraceLevel"]));
            }
            set {
                this["TraceLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.Diagnostics.TraceOptions TraceOutput {
            get {
                return ((global::System.Diagnostics.TraceOptions)(this["TraceOutput"]));
            }
            set {
                this["TraceOutput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("gumpad_trace.out")]
        public string TraceFileName {
            get {
                return ((string)(this["TraceFileName"]));
            }
            set {
                this["TraceFileName"] = value;
            }
        }
    }
}
