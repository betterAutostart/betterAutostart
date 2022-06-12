using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace betterAutostart
{
    public class LanguageObj
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }

        [JsonProperty("strings")]
        public Strings Strings { get; set; }
    }

    public class Strings
    {
        [JsonProperty("SIDEMENU_PROFILES")]
        public string SideMenuProfiles { get; set; }

        [JsonProperty("SIDEMENU_WEBSITE")]
        public string SideMenuWebsite { get; set; }

        [JsonProperty("SIDEMENU_WIKI")]
        public string SideMenuWiki { get; set; }

        [JsonProperty("SIDEMENU_SOURCECODE")]
        public string SideMenuSourceCode { get; set; }

        [JsonProperty("SIDEMENU_SETTINGS")]
        public string SideMenuSettings { get; set; }

        [JsonProperty("PROFILEP_STARTPROFILE")]
        public string ProfilePStartProfile { get; set; }

        [JsonProperty("PROFILEP_STOPPROFILE")]
        public string ProfilePStopProfile { get; set; }

        [JsonProperty("PROFILEP_EDITPROFILE")]
        public string ProfilePEditProfile { get; set; }

        [JsonProperty("PROFILEP_RUNNING")]
        public string ProfilePRunning { get; set; }

        [JsonProperty("PROFILE_DEFAULTNAME")]
        public string ProfileDefaultName { get; set; }

        [JsonProperty("EDITP_NAME")]
        public string EditPName { get; set; }

        [JsonProperty("EDITP_MAX16CHARACTERS")]
        public string EditPMax16Characters { get; set; }

        [JsonProperty("EDITP_EXECUTABLELIST")]
        public string EditPExecutableList { get; set; }

        [JsonProperty("EDITP_LSTBXCONTEXTMENU_EDIT")]
        public string EditPLstbxContextMenuEdit { get; set; }

        [JsonProperty("EDITP_LSTBXCONTEXTMENU_OPENINEXPLORER")]
        public string EditPLstbxContextMenuOpenInExplorer { get; set; }

        [JsonProperty("EDITP_LSTBXCONTEXTMENU_REMOVE")]
        public string EditPLstbxContextMenuRemove { get; set; }

        [JsonProperty("EDITP_ADDNEWEXECUTABLE")]
        public string EditPAddNewExecutable { get; set; }

        [JsonProperty("EDITP_ATTRIBUTES")]
        public string EditPAttributes { get; set; }

        [JsonProperty("EDITP_AUTOSTARTWITHSYSTEM")]
        public string EditPAutostartWithSystem { get; set; }

        [JsonProperty("EDITP_EXECUTEASADMIN")]
        public string EditPExecuteAsAdmin { get; set; }

        [JsonProperty("EDITP_HOTKEYSETTINGS")]
        public string EditPHotkeySettings { get; set; }

        [JsonProperty("EDITP_HOTKEYSTARTALL")]
        public string EditPHotkeyStartAll { get; set; }

        [JsonProperty("EDITP_HOTKEYSTOPALL")]
        public string EditPHotkeyStopAll { get; set; }

        [JsonProperty("EDITP_HOTKEYEDIT")]
        public string EditPHotkeyEdit { get; set; }

        [JsonProperty("EDITP_DELETEPROFILE")]
        public string EditPDeleteProfile { get; set; }

        [JsonProperty("EDITP_SAVEPROFILE")]
        public string EditPSaveProfile { get; set; }

        [JsonProperty("EDITP_ERROR_ONLYALPHABETICCHARS")]
        public string EditPErrorOnlyAlphabeticChars { get; set; }

        [JsonProperty("EDITP_BACK")]
        public string EditPBack { get; set; }

        [JsonProperty("EDITEXEC_NAME")]
        public string EditExecName { get; set; }

        [JsonProperty("EDITEXEC_MAX16CHARACTERS")]
        public string EditExecMax16Characters { get; set; }

        [JsonProperty("EDITEXEC_PATHHEADER")]
        public string EditExecPathHeader { get; set; }

        [JsonProperty("EDITEXEC_EDITPATH")]
        public string EditExecEditPath { get; set; }

        [JsonProperty("EDITEXEC_ATTRIBUTEHEADER")]
        public string EditExecAttributeHeader { get; set; }

        [JsonProperty("EDITEXEC_EXECASADMIN")]
        public string EditExecExecAsAdmin { get; set; }

        [JsonProperty("EDITEXEC_DELETEEXECAPP")]
        public string EditExecDeleteExecApp { get; set; }

        [JsonProperty("EDITEXEC_SAVEEXECAPP")]
        public string EditExecSaveExecApp { get; set; }

        [JsonProperty("EDITEXEC_AUTORESTART")]
        public string EditExecAutostart { get; set; }

        [JsonProperty("SETTINGS_LANGUAGE")]
        public string SettingsLanguage { get; set; }

        [JsonProperty("SETTINGS_LINKS")]
        public string SettingsLinks { get; set; }

        [JsonProperty("SETTINGS_WEBSITE")]
        public string SettingsWebsite { get; set; }

        [JsonProperty("SETTINGS_WIKI")]
        public string SettingsWiki { get; set; }

        [JsonProperty("SETTINGS_SOURCECODE")]
        public string SettingsSourcecode { get; set; }

        [JsonProperty("SETTINGS_DOCUMENTATION")]
        public string SettingsDocumentation { get; set; }

        [JsonProperty("SETTINGS_CREDITS")]
        public string SettingsCredit { get; set; }

        [JsonProperty("SETTINGS_VISITWEBSITE")]
        public string SettingsVisitWebsite { get; set; }

        [JsonProperty("SETTINGS_BUYMEACOFFEE")]
        public string SettingsBuyMeACoffee { get; set; }

        [JsonProperty("SETTINGS_SAVE")]
        public string SettingsSave { get; set; }

        [JsonProperty("PLACEHOLDER")]
        public string Placeholder { get; set; }

        [JsonProperty("NOTFOUND")]
        public string NotFound { get; set; }
    }

}
