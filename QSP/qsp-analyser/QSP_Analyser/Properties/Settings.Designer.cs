﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Analyser.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string filepath {
            get {
                return ((string)(this["filepath"]));
            }
            set {
                this["filepath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableVariableCalls {
            get {
                return ((bool)(this["EnableVariableCalls"]));
            }
            set {
                this["EnableVariableCalls"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$COUNTER\r\n$ONGLOAD\r\n$ONGSAVE\r\n$ONNEWLOC\r\n$ONACTSEL\r\n$ONOBJSEL\r\n$ONOBJADD\r\n$ONOBJD" +
            "EL\r\n$USERCOM")]
        public string VariableNames {
            get {
                return ((string)(this["VariableNames"]));
            }
            set {
                this["VariableNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableSortingLocations {
            get {
                return ((bool)(this["EnableSortingLocations"]));
            }
            set {
                this["EnableSortingLocations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableSortingVariables {
            get {
                return ((bool)(this["EnableSortingVariables"]));
            }
            set {
                this["EnableSortingVariables"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableSortingObjects {
            get {
                return ((bool)(this["EnableSortingObjects"]));
            }
            set {
                this["EnableSortingObjects"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FSIZE\r\nFCOLOR\r\nBCOLOR\r\nLCOLOR\r\nUSEHTML\r\n$FNAME\r\n$BACKIMAGE\r\nNOSAVE\r\nDISABLESCROLL" +
            "\r\nDISABLESUBEX\r\nDEBUG\r\n$COUNTER\r\n$ONGLOAD\r\n$ONGSAVE\r\n$ONNEWLOC\r\n$ONACTSEL\r\n$ONOB" +
            "JSEL\r\n$ONOBJADD\r\n$ONOBJDEL\r\n$USERCOM\r\nARGS\r\n$ARGS\r\nRESULT\r\n$RESULT")]
        public string SystemVariables {
            get {
                return ((string)(this["SystemVariables"]));
            }
            set {
                this["SystemVariables"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableAero {
            get {
                return ((bool)(this["EnableAero"]));
            }
            set {
                this["EnableAero"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"SCROLL_SPEED
$UP_ARROW_IMAGE
$DOWN_ARROW_IMAGE
HIDE_SCROLL_ARROWS
$STYLESHEET
DISABLESHADE
DISABLEAUTOREF
$NEWLOC_EFFECT
NEWLOC_EFFECT_TIME
NEWLOC_EFFECT_SEQ
$TOPIMAGE
INTEGRATED_ACTIONS
MAINDESC_X
MAINDESC_Y
MAINDESC_W
MAINDESC_H
$MAIN_FORMAT
$MAINDESC_BACKIMAGE
STATDESC_X
STATDESC_Y
STATDESC_W
STATDESC_H
$STAT_FORMAT
$STATDESC_BACKIMAGE
ACTIONS_X
ACTIONS_Y
ACTIONS_W
ACTIONS_H
$ACTION_FORMAT
$SEL_ACTION_FORMAT
$ACTIONS_BACKIMAGE
OBJECTS_X
OBJECTS_Y
OBJECTS_W
OBJECTS_H
$OBJECT_FORMAT
$SEL_OBJECT_FORMAT
$OBJECTS_BACKIMAGE
USERINPUT_X
USERINPUT_Y
USERINPUT_W
USERINPUT_H
VIEW_X
VIEW_Y
VIEW_W
VIEW_H
$VIEW_EFFECT
VIEW_EFFECT_TIME
ALWAYS_SHOW_VIEW
$INPUT_BACKIMAGE
INPUT_X
INPUT_Y
$INPUT_FORMAT
INPUT_TEXT_X
INPUT_TEXT_Y
INPUT_TEXT_W
INPUT_TEXT_H
INPUT_BAR_X
INPUT_BAR_Y
INPUT_BAR_W
INPUT_BAR_H
$INPUT_OK_IMAGE
INPUT_OK_X
INPUT_OK_Y
$INPUT_CANCEL_IMAGE
INPUT_CANCEL_X
INPUT_CANCEL_Y
$INPUT_EFFECT
INPUT_EFFECT_TIME
$MSG_BACKIMAGE
MSG_X
MSG_Y
$MSG_FORMAT
MSG_TEXT_X
MSG_TEXT_Y
MSG_TEXT_W
MSG_TEXT_H
$MSG_OK_IMAGE
MSG_OK_X
MSG_OK_Y
$MSG_EFFECT
MSG_EFFECT_TIME
FIXED_SIZE_MENU
MENU_PADDING
MENU_BORDER
MENU_BORDER_COLOR
$MENU_BACKIMAGE
MENU_X
MENU_Y
$MENU_FORMAT
$SEL_MENU_FORMAT
MENU_LIST_X
MENU_LIST_Y
MENU_LIST_W
MENU_LIST_H
$MENU_EFFECT
MENU_EFFECT_TIME")]
        public string AeroSystemVars {
            get {
                return ((string)(this["AeroSystemVars"]));
            }
            set {
                this["AeroSystemVars"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableSortingActions {
            get {
                return ((bool)(this["EnableSortingActions"]));
            }
            set {
                this["EnableSortingActions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("_tr")]
        public string CsvTranslationSuffix {
            get {
                return ((string)(this["CsvTranslationSuffix"]));
            }
            set {
                this["CsvTranslationSuffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IgnoreEmptyTranslationsCsv {
            get {
                return ((bool)(this["IgnoreEmptyTranslationsCsv"]));
            }
            set {
                this["IgnoreEmptyTranslationsCsv"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableCurlyParsing {
            get {
                return ((bool)(this["EnableCurlyParsing"]));
            }
            set {
                this["EnableCurlyParsing"] = value;
            }
        }
    }
}
