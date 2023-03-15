﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Combat_Tracker
{
    public static partial class ActGlobals
    {
        public static class ActLocalization
        {
            public class LocalizationStringsHelper
            {
                public string this[string key]
                {
                    get
                    {
                        try
                        {
                            if (Strings.ContainsKey(key))
                            {
                                return Strings[key];
                            }

                            return key;
                        }
                        catch (Exception)
                        {
                            return key;
                        }
                    }
                    set
                    {
                        try
                        {
                            if (Strings.ContainsKey(key))
                            {
                                Strings[key] = value;
                            }
                            else
                            {
                                Strings.Add(key, new LocalizationObject(value, string.Empty));
                            }
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                }
            }

            private static readonly Dictionary<string, LocalizationObject> Strings =
                new Dictionary<string, LocalizationObject>();

            public static Dictionary<string, LocalizationObject> LocalizationStrings
            {
                get
                {
                    try
                    {
                        return Strings;
                    }
                    catch (Exception)
                    {
                        return null!;
                    }
                }
            }

            internal static void AddPrebuild()
            {
                Strings.Add("trayTitle-lowDotNet", new LocalizationObject("Insufficient .NET Framework", ""));
                Strings.Add("trayText-lowDotNet",
                            new LocalizationObject(
                                "Your detected .NET Framework version is {0}.\n\nYou will need to install v4.6 of the .NET Framework or greater in order for most Internet downloads/updates to work.",
                                ""));
                Strings.Add("trayButton-ok", new LocalizationObject("OK", ""));
                Strings.Add("trayButton-ignore", new LocalizationObject("Ignore For Now", ""));
                Strings.Add("trayTitle-unhandledException", new LocalizationObject("Unhandled Exception in ACT", ""));
                Strings.Add("messageBoxTitle-fatalUnhandledException",
                            new LocalizationObject("Fatal Error - Unhandled Exception", ""));
                Strings.Add("messageBoxText-fatalUnhandledException",
                            new LocalizationObject(
                                "An unhandled exception has occurred.  ACT may close.\nPress Ctrl-C to copy this MessageBox.\n\n{0}",
                                ""));
                Strings.Add("ui-textExportDefault", new LocalizationObject("[Current Default]", ""));
                Strings.Add("ui-customTriggerGeneralCategory",
                            new LocalizationObject(
                                " General",
                                "There is a space before the term for sorting purposes.  Also for Spell Timer categories."));
                Strings.Add("ui-soundTypeTts", new LocalizationObject("TTS", ""));
                Strings.Add("ui-soundTypeSound", new LocalizationObject("Sound", ""));
                Strings.Add("ui-soundTypeBeep", new LocalizationObject("Beep", ""));
                Strings.Add("ui-soundTypeNone", new LocalizationObject("None", ""));
                Strings.Add("data-timerStringNone", new LocalizationObject("<None>", ""));
                Strings.Add("ui-spellTimerTooltip",
                            new LocalizationObject("{0} - {1}s.", "Abbreviated 's.' stands for seconds."));
                Strings.Add("data-dnumNoDamage", new LocalizationObject("No Damage", ""));
                Strings.Add("data-dnumMiss", new LocalizationObject("Miss", ""));
                Strings.Add("data-dnumResist", new LocalizationObject("Resist", ""));
                Strings.Add("data-dnumParry", new LocalizationObject("Parry", ""));
                Strings.Add("data-dnumRiposte", new LocalizationObject("Riposte", ""));
                Strings.Add("data-dnumBlock", new LocalizationObject("Block", ""));
                Strings.Add("data-dnumDeath", new LocalizationObject("Death", ""));
                Strings.Add("specialAttackTerm-warded", new LocalizationObject("warded", ""));
                Strings.Add("specialAttackTerm-melee", new LocalizationObject("melee", ""));
                Strings.Add("specialAttackTerm-nonMelee", new LocalizationObject("non-melee", ""));
                Strings.Add("specialAttackTerm-unknown", new LocalizationObject("unknown", ""));
                Strings.Add("specialAttackTerm-killing", new LocalizationObject("Killing", ""));
                Strings.Add("specialAttackTerm-wardAbsorb", new LocalizationObject("Absorption", ""));
                Strings.Add("specialAttackTerm-increase",
                            new LocalizationObject("Increase", "One possible use is threat increase"));
                Strings.Add("encounterData-defaultEncounterName", new LocalizationObject("Encounter", ""));
                Strings.Add("zoneDataTerm-import", new LocalizationObject("Import", ""));
                Strings.Add("zoneDataTerm-importMerge", new LocalizationObject("Import/Merge - [{0}]", ""));
                Strings.Add("ui-tableColumnError",
                            new LocalizationObject(
                                "ERROR",
                                "Message shown in the main table when a cell's data provider throws an exception"));
                Strings.Add("uiOpMisc-logPosition1",
                            new LocalizationObject("Reading {0}\nAt position: {1:0,0}.",
                                                   "Shown in the Misc options panel"));
                Strings.Add("uiOpMisc-logPosition2a", new LocalizationObject(" ({0} lines behind.)", ""));
                Strings.Add("uiOpMisc-logPosition3", new LocalizationObject(" ({0} CustomTrigger lines behind.)", ""));
                Strings.Add("uiOpMisc-logPosition4", new LocalizationObject("\nSyncing companion files: ", ""));
                Strings.Add("uiOpMisc-logPaused", new LocalizationObject("Parsing Paused...", ""));
                Strings.Add("uiFormActMain-Title1", new LocalizationObject("*Combat* ", "Shown on the titlebar"));
                Strings.Add("uiFormMiniParse-titleCombat", new LocalizationObject("Mini Parse - *Combat*", ""));
                Strings.Add("uiFormMiniParse-title", new LocalizationObject("Mini Parse", ""));
                Strings.Add("uiFormActMain-Title2a", new LocalizationObject("Log Active", ""));
                Strings.Add("uiFormActMain-Title3", new LocalizationObject("[Exporting]", ""));
                Strings.Add("uiFormActMain-Title4", new LocalizationObject("[Importing]", ""));
                Strings.Add("uiFormActMain-Title5", new LocalizationObject("[ODBC]", ""));
                Strings.Add("uiFormActMain-Title0",
                            new LocalizationObject("{0}{1}Advanced Combat Tracker{2} - {3} - Log Time: {4} (Est. {5})",
                                                   ""));
                Strings.Add("trayText-eventExceptions1",
                            new LocalizationObject(
                                "In the last minute, these plugins caused exceptions in event handlers:\n", ""));
                Strings.Add("trayText-eventExceptions2", new LocalizationObject("{0} [{1} time(s)]", ""));
                Strings.Add("trayButton-openLogs", new LocalizationObject("Open Logs Folder", ""));
                Strings.Add("trayTitle-eventUnhandledException",
                            new LocalizationObject("Event Handler Unhandled Exceptions", ""));
                Strings.Add("trayButton-benchShow", new LocalizationObject("Show Benchmarks", ""));
                Strings.Add("ui-customTriggerSearch",
                            new LocalizationObject("Custom Trigger threads",
                                                   "Search terms for the Options tab to show Custom Trigger thread count"));
                Strings.Add("trayButton-notNow", new LocalizationObject("Not now", ""));
                Strings.Add("trayButton-never", new LocalizationObject("Never ask again", ""));
                Strings.Add("trayText-ctBench2",
                            new LocalizationObject(
                                "Custom Trigger log parsing has been behind for 10 seconds.  You may need to add more Custom Trigger threads in the Options page or optimize your current Custom Triggers to be more effiecient.\n\nWould you like to open the Custom Trigger Benchmark to identify problematic Custom Triggers?",
                                ""));
                Strings.Add("trayTitle-ctBench", new LocalizationObject("Custom Triggers lagging behind", ""));
                Strings.Add("trayText-parsingBusy",
                            new LocalizationObject(
                                "Log line parsing has been behind for 10 seconds.  A plugin subscribed to BeforeLogLine/OnLogLine may be processing synchronously and taking too long.",
                                ""));
                Strings.Add("trayTitle-parsingBusy", new LocalizationObject("Log Parsing lagging behind", ""));
                Strings.Add("uiFormActMain-Title2b", new LocalizationObject("Log Idle", ""));
                Strings.Add("uiOpWebServer-sessionStats",
                            new LocalizationObject(
                                "Session stats | During the last 10s\n{0:#,0} bytes in | {3:0.00} KB/s in\n{1:#,0} bytes out | {4:0.00} KB/s out\n{2} unique clients | {5} unique clients",
                                ""));
                Strings.Add("trayText-encClearGcCollect",
                            new LocalizationObject("{0:0,0} bytes allocated difference", ""));
                Strings.Add("uiLoading-init10",
                            new LocalizationObject("InitACT 10...  (Setting up log file, scanning for zone/name info)",
                                                   ""));
                Strings.Add("uiLoading-init11", new LocalizationObject("InitACT 11...  (Setting up data objects)", ""));
                Strings.Add("uiLoading-init12",
                            new LocalizationObject("InitACT 12...  (Scanning for blocked Internet files)", ""));
                Strings.Add("uiLoading-init13",
                            new LocalizationObject("InitACT 13...  (Setting processor affinity)", ""));
                Strings.Add("uiLoading-init14",
                            new LocalizationObject("InitACT 14...  (Initializing main table style)", ""));
                Strings.Add("uiLoading-init15",
                            new LocalizationObject("InitACT 15...  (Validating columns and export variables)", ""));
                Strings.Add("uiLoading-init16", new LocalizationObject("InitACT 16...  (Starting log watcher)", ""));
                Strings.Add("uiLoading-init17", new LocalizationObject("InitACT 17...  (Resetting tab views)", ""));
                Strings.Add("uiLoading-init18",
                            new LocalizationObject("InitACT 18...  (Resetting combobox styles, checking parser events)",
                                                   ""));
                Strings.Add("uiLoading-init19",
                            new LocalizationObject("InitACT 19...  (Checking for updates, setting initial viewstate)",
                                                   ""));
                Strings.Add("uiLoading-init20", new LocalizationObject("InitACT 20...  (Checking plugins)", ""));
                Strings.Add("messageBoxTitle-duplicatePlugin", new LocalizationObject("Duplicate Plugin", ""));
                Strings.Add("messageBox-duplicatePlugin",
                            new LocalizationObject("The plugin {0} appears to be loaded multiple times.", ""));
                Strings.Add("uiLoading-init21",
                            new LocalizationObject("InitACT 21...  (Setting up history database)", ""));
                Strings.Add("uiLoading-init22",
                            new LocalizationObject("InitACT 22...  (Checking ACT's folder, XML subs)", ""));
                Strings.Add("uiLoading-init23", new LocalizationObject("InitACT 23...  (Checking config backups)", ""));
                Strings.Add("uiLoading-initExit", new LocalizationObject("Exiting InitACT...", ""));
                Strings.Add("notifTitle-unknownAssembly",
                            new LocalizationObject("Unknown assemblies in ACT's folder.  (Click Show to open folder)",
                                                   ""));
                Strings.Add("notifText-unknownAssembly",
                            new LocalizationObject(
                                "The following assemblies were not recognized.  If they are plugins or from plugins, they should be deleted or moved to another folder to avoid \"wrong version\" load issues.\r\n\r\n{0}",
                                ""));
                Strings.Add("messageBoxText-unblock1b",
                            new LocalizationObject("{0} more files...",
                                                   "A count of additional blocked files not listed."));
                Strings.Add("messageBoxText-unblock1a",
                            new LocalizationObject(
                                "The following {0} file(s) were downloaded from the Internet and are still blocked:\n\n{1}\n\nUnblock?  Press [Cancel] to stop asking.",
                                ""));
                Strings.Add("messageBoxTitle-unblock", new LocalizationObject("Unblock files?", ""));
                Strings.Add("messageBoxText-unblockFail",
                            new LocalizationObject(
                                "Not all files could be unblocked.  Try running ACT as admin.\n\n{0}", ""));
                Strings.Add("messageBoxTitle-unblockFail", new LocalizationObject("Unblock Failure", ""));
                Strings.Add("trayButton-restartAct", new LocalizationObject("Restart", ""));
                Strings.Add("trayButton-ignoreRestart", new LocalizationObject("Ignore", ""));
                Strings.Add("trayTitle-restartAct", new LocalizationObject("ACT Restart Requested", ""));
                Strings.Add("trayText-restartACT",
                            new LocalizationObject("Restarting ACT is required to complete changes. \n\n{0}", ""));
                Strings.Add("uiTitle-act", new LocalizationObject("Advanced Combat Tracker", ""));
                Strings.Add("uiText-exitAct", new LocalizationObject("Exiting ACT...", ""));
                Strings.Add("fileDialogFilter-saveGraph",
                            new LocalizationObject("Portable Network Graphics (*.png)|*.png", ""));
                Strings.Add("fileDialogTitle-saveGraph", new LocalizationObject("Save graph as...", ""));
                Strings.Add("notifTitle-imageSaveException", new LocalizationObject("Could not save image.", ""));
                Strings.Add("messageBox-feedbackNoComments",
                            new LocalizationObject("You did not enter any comments.", ""));
                Strings.Add("messageBoxTitle-feedbackFail", new LocalizationObject("Feedback not submitted", ""));
                Strings.Add("messageBox-feedbackNoEmail",
                            new LocalizationObject(
                                "You did not enter your email address.  If you need technical support or help there will be no way to contact you. \nIf you are reporting a rare bug, without more information from you it may be impossible to fix.\n\nAre you sure you wish to leave your email blank?",
                                ""));
                Strings.Add("messageBoxTitle-feedbackWarning", new LocalizationObject("Feedback Warning", ""));
                Strings.Add("messageBox-feedbackShort",
                            new LocalizationObject(
                                "Your feedback seems to be very short.  If you are reporting a problem, the more you describe it the better.  If you do not sufficiently describe the problem, I must resort to guessing what your problem is... which may get no response at all.\n\nDo you wish to continue with sending the feedback?",
                                ""));
                Strings.Add("btnFeedbackSubmit-Text2", new LocalizationObject("Please restart to submit more.", ""));
                Strings.Add("encounterTerm-merged", new LocalizationObject("Merged({0})", ""));
                Strings.Add("fileDialogFilter-triggerSound",
                            new LocalizationObject("Waveform Files (*.wav)|*.wav", ""));
                Strings.Add("messageBox-invalidRegex",
                            new LocalizationObject(
                                "There was a problem with the regular expression syntax:\n{0}\n\nPlease click the Regular Expression link or visit the forums for more help on creating Regex matches.",
                                ""));
                Strings.Add("messageBoxTitle-invalidRegex", new LocalizationObject("Invalid Regular Expression", ""));
                Strings.Add("messageBoxText-customTriggerDeleteMultiple",
                            new LocalizationObject("Really delete {0} custom triggers under '{1}'?", ""));
                Strings.Add("messageBoxTitle-customTriggerDeleteMultiple",
                            new LocalizationObject("Delete multiple triggers?", ""));
                Strings.Add("contextMenu-gridCopy", new LocalizationObject("Copy \"{0}\"", ""));
                Strings.Add("contextMenu-gridAppend", new LocalizationObject("Append \", {0}\"", ""));
                Strings.Add("contextMenu-gridAppendLine", new LocalizationObject("Append \"<newline>\n{0}\"", ""));
                Strings.Add("fileDialogFilter-plugins",
                            new LocalizationObject(
                                "All Plugin Types|*.exe;*.dll;*.cs;*.vb;|Dynamic Link Library (*.dll)|*.dll|CSharp(C#) Source File (*.cs)|*.cs|Visual Basic.NET Source File (*.vb)|*.vb",
                                ""));
                Strings.Add("uiPlugins-fileDetails",
                            new LocalizationObject("{3}\n{0,0} bytes, Last Modified: {1} - {2}", ""));
                Strings.Add("messageBox-cullHistory", new LocalizationObject("{0} of {1} total records deleted.", ""));
                Strings.Add("messageBoxTitle-cullHistory", new LocalizationObject("Cull History", ""));
                Strings.Add("helpPanel-defaultText",
                            new LocalizationObject("Mouse-over an item to view a more detailed explanation.", ""));
                Strings.Add("uiOptions-searchDefault",
                            new LocalizationObject("Search Options...", "What is shown in the searchbox when empty"));
                Strings.Add("fileDialogFilter-saveTableImage",
                            new LocalizationObject("Portable Network Graphics (*.png)|*.png", ""));
                Strings.Add("fileDialogTitle-saveTableImage", new LocalizationObject("Save graph as...", ""));
                Strings.Add("notifText-clipboardReadFail",
                            new LocalizationObject("Could not get text from the clipboard...", ""));
                Strings.Add("notifTitle-clipboardReadFail", new LocalizationObject("Clipboard Error", ""));
                Strings.Add("notifText-xmlSnippetNotHandled",
                            new LocalizationObject(
                                "The XML Snippet was not marked as handled.  Does this share type require a plugin?",
                                ""));
                Strings.Add("notifTitle-xmlSnippetNotHandled", new LocalizationObject("XML Share not handled", ""));
                Strings.Add("notifText-xmlSnippetIncomplete",
                            new LocalizationObject(
                                "The shared XML seems to be missing required attributes to be imported", ""));
                Strings.Add("notifTitle-xmlSnippetIncomplete", new LocalizationObject("XML Share incomplete", ""));
                Strings.Add("notifText-xmlSnippetError",
                            new LocalizationObject("There was an unexpected error importing this XML snippet.\n\n{0}",
                                                   ""));
                Strings.Add("notifTitle-xmlSnippetError", new LocalizationObject("XML Share error", ""));
                Strings.Add("tooltip-regexWildcardWarn",
                            new LocalizationObject("Be careful about using wildcards like .* without need.", ""));
                Strings.Add("uiText-assemblyReport1", new LocalizationObject("\nACT assemblies:", ""));
                Strings.Add("uiText-assemblyReport2", new LocalizationObject("\nPlugin assemblies:", ""));
                Strings.Add("uiText-assemblyReport3", new LocalizationObject("\nAdditional assemblies:", ""));
                Strings.Add("graphAdv-toolTip", new LocalizationObject("+{0} ({1} sec average)", "sec = second"));
                Strings.Add("graphAdv-termDps", new LocalizationObject("DPS", ""));
                Strings.Add("graphCombatant-toolTip",
                            new LocalizationObject("+{0} ({1:#,0} sec average)", "sec = second"));
                Strings.Add("ui-processPriority+", new LocalizationObject("Above Normal", ""));
                Strings.Add("ui-processPriority", new LocalizationObject("Normal", ""));
                Strings.Add("ui-processPriority-", new LocalizationObject("Below Normal", ""));
                Strings.Add("ui-processPriority--", new LocalizationObject("Lowest", ""));
                Strings.Add("graphAttackTypes-noDataError",
                            new LocalizationObject("This sorting method has no available data.", ""));
                Strings.Add("graphEncText-noDataError",
                            new LocalizationObject("The table currently has no data to graph...", ""));
                Strings.Add("graphEncText-noDataSortingError",
                            new LocalizationObject(
                                "No rows with compatible data to graph...\nTry sorting the table by another column.",
                                ""));
                Strings.Add("lcdModeName-miniWindow", new LocalizationObject("Mini Window", ""));
                Strings.Add("lcdModeName-personalStats", new LocalizationObject("Personal Stats", ""));
                Strings.Add("lcdModeName-spellTimers", new LocalizationObject("Spell Timers", ""));
                Strings.Add("lcdModeName-sortBars", new LocalizationObject("Sort Bars", ""));
                Strings.Add("lcdError-noDevice", new LocalizationObject("No device is connected.", ""));
                Strings.Add("zoneTerm-unknown", new LocalizationObject("Unknown Zone", ""));
                Strings.Add("zoneTerm-import", new LocalizationObject("Import Zone", ""));
                Strings.Add("messageBoxTitle-selectEq2Path", new LocalizationObject("EQ2 Detection Failed", ""));
                Strings.Add("messageBox-selectEq2Path",
                            new LocalizationObject(
                                "Your current EQ2 installation was not detectable.  Please select the folder where EQ2 resides.",
                                "ACT unable to find the EQ2 installation"));
                Strings.Add("fileDialogTitle-eq2InstallFolder",
                            new LocalizationObject("Select your EQ2 installation folder", ""));
                Strings.Add("uiText-eq2Folder", new LocalizationObject("EQ2 Folder is: {0}", ""));
                Strings.Add("uiText-eq2Ini", new LocalizationObject("eq2.ini found.", "eq2.ini is a file name"));
                Strings.Add("uiText-eq2UiFolder", new LocalizationObject("UI Folder: {0}\\{1}", ""));
                Strings.Add("uiText-eq2BrowserExtracted",
                            new LocalizationObject("Extracted eq2ui_mainhud_browser.xml", ""));
                Strings.Add("uiText-eq2UiFolder2", new LocalizationObject("UI Folder: UI\\ACT", ""));
                Strings.Add("uiText-eq2UiComplete",
                            new LocalizationObject(
                                "\nOperation Complete. Type \"/browser\" in-game to show the web browser.", ""));
                Strings.Add("messageBoxTitle-complete", new LocalizationObject("The operation has completed", ""));
                Strings.Add("messageBoxText-eq2CreateFileError",
                            new LocalizationObject("Could not create {0}.\n{1}", ""));
                Strings.Add("messageBoxTitle-eq2CreateFileError", new LocalizationObject("Unable to continue", ""));
                Strings.Add("messageBox-importHistoryNoLogMatch",
                            new LocalizationObject(
                                "Could not find a log file for your character that likely had the date range.  Please find this file.",
                                ""));
                Strings.Add("fileDialogTitle-importHistoryNoLogMatch",
                            new LocalizationObject("Open log file containing {0} {1} to {2} {3}", "Date range (to)"));
                Strings.Add("fileDialogFilter-gameLogs",
                            new LocalizationObject(
                                "Game Log Files|{0}|Text Files (*.txt)|*.txt|Log Files (*.log)|*.log|Any File (*.*)|*.*",
                                ""));
                Strings.Add("messageBox-pluginImageError",
                            new LocalizationObject(
                                "ACT cannot use Win32/COM assemblies as native plugins or mix 32/64 bit assemblies.",
                                ""));
                Strings.Add("messageBoxTitle-pluginImageError", new LocalizationObject("Bad image format", ""));
                Strings.Add("messageBoxTitle-fileError", new LocalizationObject("File Unavailable", ""));
                Strings.Add("messageBox-pluginCompileError",
                            new LocalizationObject(
                                "There were errors compiling the plugin source file.\n\nPlease refer to the Plugin Info panel for more information.",
                                ""));
                Strings.Add("messageBoxTitle-pluginCompileError", new LocalizationObject("Compile Error", ""));
                Strings.Add("messageBoxTitle-loadError", new LocalizationObject("Load Error", ""));
                Strings.Add("messageBox-pluginInvalid",
                            new LocalizationObject(
                                "This assembly does not have a class that implements ACT's plugin interface, or scanning the assembly threw an error.",
                                ""));
                Strings.Add("messageBoxTitle-pluginInvalid", new LocalizationObject("Invalid Plugin", ""));
                Strings.Add("messageBoxText-pluginInternetBlocked",
                            new LocalizationObject(
                                "{0}\n\n---\n\nSuggestion: The plugin ({1}) may be blocked from loading because it is marked as from the Internet.  Please right-click the file, select Properties and Unblock the file.\n\nIf this plugin came with any other files, unblock them as well.",
                                ""));
                Strings.Add("messageBoxTitle-pluginInitFail",
                            new LocalizationObject("Plugin Initialization Failed", ""));
                Strings.Add("uiText-pluginInfoTitle1", new LocalizationObject("Assembly Info:\n", ""));
                Strings.Add("uiText-pluginInfoTitle2", new LocalizationObject("Source File Info:\n", ""));
                Strings.Add("uiText-pluginInfoParts1", new LocalizationObject("FileName: ", ""));
                Strings.Add("uiText-pluginInfoParts2", new LocalizationObject("OriginalFilename: ", ""));
                Strings.Add("uiText-pluginInfoParts3", new LocalizationObject("FileVersion: ", ""));
                Strings.Add("uiText-pluginInfoParts4", new LocalizationObject("ProductVersion: ", ""));
                Strings.Add("uiText-pluginInfoParts5", new LocalizationObject("FileDescription: ", ""));
                Strings.Add("uiText-pluginInfoParts6", new LocalizationObject("ProductName: ", ""));
                Strings.Add("uiText-pluginInfoParts7", new LocalizationObject("CompanyName: ", ""));
                Strings.Add("uiText-pluginInfoParts8", new LocalizationObject("LegalCopyright: ", ""));
                Strings.Add("uiText-pluginInfoParts9", new LocalizationObject("LegalTrademarks: ", ""));
                Strings.Add("uiText-pluginInfoParts10", new LocalizationObject("Comments: ", ""));
                Strings.Add("messageBox-removePlugin",
                            new LocalizationObject("Are you sure you wish to remove plugin {0}?", ""));
                Strings.Add("messageBoxTitle-removePlugin", new LocalizationObject("Remove Plugin?", ""));
                Strings.Add("sliderText-badPluginLocation",
                            new LocalizationObject(
                                "{0} should not be loaded from ACT's installation folder.  It may cause file locking issues or other hard to diagnose problems.  Please move it to a sub-folder or other location such as %APPDATA%\\Advanced Combat Tracker\\Plugins\\.",
                                ""));
                Strings.Add("sliderTitle-badPluginLocation", new LocalizationObject("Bad Plugin Location", ""));
                Strings.Add("uiText-pluginEnabled", new LocalizationObject("Enabled", ""));
                Strings.Add("uiText-pluginDefaultLabel", new LocalizationObject("No Status", ""));
                Strings.Add("sliderText-pluginRestart",
                            new LocalizationObject("You should restart ACT to apply the new plugin load order.", ""));
                Strings.Add("uiText-odbcGen1", new LocalizationObject("{0}, {1}.\nGenerating SQL...", ""));
                Strings.Add("uiText-odbcGen2", new LocalizationObject("{0}, {1}.\nGenerating SQL... {2}%", ""));
                Strings.Add("uiText-odbcGen3", new LocalizationObject("{0}, {1}.\nGenerating SQL... {2}% | {3}%", ""));
                Strings.Add("uiText-odbcGen4",
                            new LocalizationObject("{0}, {1}.\nGenerating SQL... {2}% | {3}% | {4}%", ""));
                Strings.Add("uiText-odbcCalc", new LocalizationObject("Data calculated for {0} in {1} secs.", ""));
                Strings.Add("uiText-odbcSending",
                            new LocalizationObject("{0}, {1}.\nSending SQL to datasource... {2}%", ""));
                Strings.Add("uiText-odbcSent",
                            new LocalizationObject("{0:0,0} SQL commands sent for {1} in {2} secs.", ""));
                Strings.Add("uiText-odbcSent2",
                            new LocalizationObject("{0:0,0} rows sent in {1} commands for {2} in {3} secs.", ""));
                Strings.Add("messageBox-exportNoOptions",
                            new LocalizationObject("Please select something to display in the export.", ""));
                Strings.Add("fileDialogFilter-exportHtml", new LocalizationObject("HTML File (*.html)|*.html", ""));
                Strings.Add("fileDialogTitle-exportHtml", new LocalizationObject("Export Encounter to HTML", ""));
                Strings.Add("uiText-htmlGen", new LocalizationObject("Generating HTML...\n", ""));
                Strings.Add("uiText-htmlWrite", new LocalizationObject("Writing HTML to file...", ""));
                Strings.Add("uiText-htmlComplete",
                            new LocalizationObject("Export to {0} has completed.\n{1} seconds elapsed.", ""));
                Strings.Add("uiText-customTriggerColTimeStamp", new LocalizationObject("Time Stamp", ""));
                Strings.Add("uiText-customTriggerColLogLine", new LocalizationObject("Log line", ""));
                Strings.Add("uiText-customTriggerClear", new LocalizationObject("Clear Items", ""));
                Strings.Add("uiText-customTriggerSearch", new LocalizationObject("Search triggered log lines...", ""));
                Strings.Add("uiText-customTriggerSearchText", new LocalizationObject("Search as Text", ""));
                Strings.Add("uiText-customTriggerSearchRegex", new LocalizationObject("Search as Regex", ""));
                Strings.Add("uiText-customTriggerFindNext", new LocalizationObject("Find Next", ""));
                Strings.Add("uiText-customTriggerFindPrev", new LocalizationObject("Find Prev", ""));
                Strings.Add("uiText-customTriggerCopy1", new LocalizationObject("Copy Search Results", ""));
                Strings.Add("uiText-customTriggerCopy2", new LocalizationObject("Copy Selection", ""));
                Strings.Add("uiText-customTriggerCopy3", new LocalizationObject("Copy All", ""));
                Strings.Add("uiText-clipConnectError1", new LocalizationObject("The IP/Port syntax is invalid.", ""));
                Strings.Add("uiText-clipConnectStart1", new LocalizationObject("Attempting connection...", ""));
                Strings.Add("uiText-clipConnectStart2", new LocalizationObject("Connected to {0}:{1}.", ""));
                Strings.Add("uiText-clipConnectFail", new LocalizationObject("Connection Failed.", ""));
                Strings.Add("messageBox-clipConnectError",
                            new LocalizationObject(
                                "\n\nIs the specified computer running the ACT Clipboard Sharer application?\n\nDO NOT USE THIS FEATURE IF THE GAME AND ACT ARE RUNNING ON THE SAME SYSTEM",
                                ""));
                Strings.Add("messageBoxTitle-clipConnectError",
                            new LocalizationObject("Clipboard Connection Failed", ""));
                Strings.Add("uiText-clipConnectDisc", new LocalizationObject("Not Connected.", ""));
                Strings.Add("messageBoxTitle-feedbackNoConnect",
                            new LocalizationObject("Connection to feedback server failed", ""));
                Strings.Add("messageBoxTitle-feedbackNoSend",
                            new LocalizationObject("Sending feedback data failed", ""));
                Strings.Add("messageBox-feedbackSuccess", new LocalizationObject("Feedback complete.", ""));
                Strings.Add("fileDialogFilter-actExport", new LocalizationObject("ACT Binary File (*.act)|*.act", ""));
                Strings.Add("fileDialogTitle-actExport", new LocalizationObject("Export Encounter to Data File", ""));
                Strings.Add("fileDialogDefault-actExport", new LocalizationObject("MultipleEncounters.act", ""));
                Strings.Add("uiText-actExport1", new LocalizationObject("Exporting...", ""));
                Strings.Add("uiText-actExport2", new LocalizationObject("{0} exported.", ""));
                Strings.Add("uiText-actExportError1", new LocalizationObject("File Error: {0}", ""));
                Strings.Add("uiText-actExportError2", new LocalizationObject("Unexpected error: {0}", ""));
                Strings.Add("uiText-actExportError3",
                            new LocalizationObject("Error while parsing ACT/XML file: Line #", ""));
                Strings.Add("uiText-actExportError4",
                            new LocalizationObject("The ACT file was corrupt, and may be an incompatible version.\n",
                                                   ""));
                Strings.Add("opMisc", new LocalizationObject("Miscellaneous", "Options tab treeview"));
                Strings.Add("opSound", new LocalizationObject("Sound Settings", ""));
                Strings.Add("opSoundTts", new LocalizationObject("Text to Speech", ""));
                Strings.Add("opImportExport", new LocalizationObject("Configuration Import/Export", ""));
                Strings.Add("opXmlShare", new LocalizationObject("XML Share Snippets", ""));
                Strings.Add("opXmlSubs", new LocalizationObject("XML Config Subscriptions", ""));
                Strings.Add("opLcdGeneral", new LocalizationObject("LCD Display Options", ""));
                Strings.Add("opLcdMono", new LocalizationObject("Monochrome LCD Options", ""));
                Strings.Add("opLcdColor", new LocalizationObject("Color LCD Options", ""));
                Strings.Add("opMainTable", new LocalizationObject("Main Table/Encounters", ""));
                Strings.Add("opMainTableGen", new LocalizationObject("General", ""));
                Strings.Add("opEncCulling", new LocalizationObject("Encounter Culling", ""));
                Strings.Add("opTableZone", new LocalizationObject("Zone View Options", ""));
                Strings.Add("opTableEncounter", new LocalizationObject("Encounter View Options", ""));
                Strings.Add("opTableCombatant", new LocalizationObject("Combatant View Options", ""));
                Strings.Add("opTableDamageType", new LocalizationObject("DamageType View Options", ""));
                Strings.Add("opTableAttackType", new LocalizationObject("AttackType View Options", ""));
                Strings.Add("opOutputDisplay", new LocalizationObject("Output Display", ""));
                Strings.Add("opGraphing", new LocalizationObject("Graphing", ""));
                Strings.Add("opMiniParse", new LocalizationObject("Mini Parse Window", ""));
                Strings.Add("opTextExports", new LocalizationObject("Text Export Settings", ""));
                Strings.Add("opOdbc", new LocalizationObject("ODBC (SQL)", ""));
                Strings.Add("opWebServer", new LocalizationObject("ACT Web Server", ""));
                Strings.Add("opFileHTML", new LocalizationObject("HTML File Generation", ""));
                Strings.Add("opColorFont", new LocalizationObject("Color and Font Settings", ""));
                Strings.Add("opColorUserInterface", new LocalizationObject("Main User Interface", ""));
                Strings.Add("opColorGraphing", new LocalizationObject("Graphing", ""));
                Strings.Add("opColorMisc", new LocalizationObject("Miscellaneous", ""));
                Strings.Add("opSelectiveParsing", new LocalizationObject("Selective Parsing", ""));
                Strings.Add("opDataCorrection", new LocalizationObject("Data Correction", ""));
                Strings.Add("opDataCorrectionMisc", new LocalizationObject("Miscellaneous", ""));
                Strings.Add("opDataCorrectionRename", new LocalizationObject("Combatant Rename", ""));
                Strings.Add("opDataCorrectionRedirect", new LocalizationObject("Ability Redirect", ""));
                Strings.Add("ioImport", new LocalizationObject("Import Encounters", "Import/Export tab treeview"));
                Strings.Add("ioImportLog", new LocalizationObject("Import a Log File", ""));
                Strings.Add("ioImportClip", new LocalizationObject("Import the Clipboard", ""));
                Strings.Add("ioImportAct", new LocalizationObject("Import an *.act File", ""));
                Strings.Add("ioExport", new LocalizationObject("Export Encounters", ""));
                Strings.Add("ioExportAct", new LocalizationObject("Export to an *.act File", ""));
                Strings.Add("ioExportHtml", new LocalizationObject("Export to an HTML Page", ""));
                Strings.Add("ioOdbc", new LocalizationObject("Export to SQL/ODBC", ""));
                Strings.Add("ioXmlFile", new LocalizationObject("Export to an XML File", ""));
                Strings.Add("htmlText-return", new LocalizationObject("Return to Index", ""));
                Strings.Add("htmlText-currentEncounter", new LocalizationObject("Current Encounter", ""));
                Strings.Add("htmlText-timers", new LocalizationObject("Timers Window", ""));
                Strings.Add("sliderText-oldLog",
                            new LocalizationObject(
                                "The currently open log file has not been modified for over a week.  Please ensure /log is on in-game and you have selected the correct log file.",
                                ""));
                Strings.Add("sliderTitle-oldLog", new LocalizationObject("Old Log File", ""));
                Strings.Add("sliderText-logFileTimeError",
                            new LocalizationObject(
                                "This log file is not valid for the current parsing plugin. (It cannot read the timestamps)\n\nPlease verify that you have the correct parsing plugin enabled and *only* one parsing plugin enabled.",
                                ""));
                Strings.Add("messageBoxTitle-startupLogError",
                            new LocalizationObject("Error loading last log file", ""));
                Strings.Add("messageBox-htmlNoFileAccess",
                            new LocalizationObject("Could not write to required files.\n\n{0}", ""));
                Strings.Add("messageBoxTitle-htmlNoFileAccess", new LocalizationObject("File Access Denied", ""));
                Strings.Add("htmlText-lastEnc", new LocalizationObject("Last Encounter", ""));
                Strings.Add("htmlText-lastUpdated", new LocalizationObject("Last Updated: ", ""));
                Strings.Add("uiOpMisc-logResumed", new LocalizationObject("Parsing Resumed...", ""));
                Strings.Add("uiText-odbcComplete",
                            new LocalizationObject("ODBC export has completed.\n{0} seconds elapsed.\n{1} errors.",
                                                   ""));
                Strings.Add("uiText-odbcComplete2",
                            new LocalizationObject(
                                "\t Please see the General Options tab ODBC section for error descriptions.", ""));
                Strings.Add("ui-ReadLogException",
                            new LocalizationObject("System Message: {0}",
                                                   "ReadLog throws an exception, this is displayed in the Options tab"));
                Strings.Add("ui-ReadLogClosed", new LocalizationObject("Logfile closed.", ""));
                Strings.Add("messageBox-clipboardNoText",
                            new LocalizationObject("The clipboard cannot be converted to plain text data.", ""));
                Strings.Add("messageBoxTitle-clipboardNoText", new LocalizationObject("Clipboard import failed", ""));
                Strings.Add("ui-ReadLogPaused", new LocalizationObject("Parsing Paused...", ""));
                Strings.Add("ui-ReadLogResumed", new LocalizationObject("Parsing Resumed...", ""));
                Strings.Add("messageBox-importDateTimeFail",
                            new LocalizationObject("Could not find the specified date range within the file.", ""));
                Strings.Add("messageBoxTitle-importFail", new LocalizationObject("Parse failed", ""));
                Strings.Add("trayButton-continue", new LocalizationObject("Continue", ""));
                Strings.Add("trayButton-skip", new LocalizationObject("Skip", ""));
                Strings.Add("trayText-findZoneBusy",
                            new LocalizationObject(
                                "Finding the zone name in the log file appears to be taking a long time.  Do you wish to skip scanning?\n\n{0} {1:0,0} bytes",
                                ""));
                Strings.Add("trayTitle-findZoneBusy", new LocalizationObject("Scanning Log File", ""));
                Strings.Add("messageBox-xmlPrefLoadError",
                            new LocalizationObject(
                                "The XML settings file may be corrupt or unusable.  Consider loading a backup from 'Configuration Import/Export' options.",
                                ""));
                Strings.Add("trayButton-openActLog", new LocalizationObject("Open error log", ""));
                Strings.Add("trayText-xmlPrefErrorCount",
                            new LocalizationObject(
                                "There were {0} errors encountered while loading settings.\nIf you just changed ACT versions, these errors may be a one-time result of ACT settings changing names/locations.",
                                ""));
                Strings.Add("trayTitle-xmlPrefErrorCount", new LocalizationObject("Config Load Errors", ""));
                Strings.Add("ui-loadingPlugin",
                            new LocalizationObject("Loading plugin {0}...", "Shown during InitACT"));
                Strings.Add("messageBoxTitle-serverStartError",
                            new LocalizationObject("Could not start the server", ""));
                Strings.Add("notifTitle-webserverException", new LocalizationObject("Webserver closed", ""));
                Strings.Add("ui-webserverStatus", new LocalizationObject("Server Status", ""));
                Strings.Add("webTitle-current", new LocalizationObject("Current Encounter Table", ""));
                Strings.Add("webDesc-current",
                            new LocalizationObject(
                                "Any encounter currently active can be found here. Page will refresh every 5 seconds.",
                                ""));
                Strings.Add("webTitle-mini", new LocalizationObject("Current Mini Window Text", ""));
                Strings.Add("webDesc-mini",
                            new LocalizationObject(
                                "The Mini Window text-only display of the current encounter. Page will refresh every 5 seconds.",
                                ""));
                Strings.Add("webTitle-browse", new LocalizationObject("Browse ACT's Encounter Data", ""));
                Strings.Add("webDesc-browse",
                            new LocalizationObject("Browse through all of the tables that ACT currently has in memory.",
                                                   ""));
                Strings.Add("webTitle-timers", new LocalizationObject("Timers Window Table", ""));
                Strings.Add("webDesc-timers",
                            new LocalizationObject(
                                "View a table of spell timers ACT is currently tracking.  Page will refresh every 2 seconds.",
                                ""));
                Strings.Add("notifTitle-webserverError", new LocalizationObject("Webserver error", ""));
                Strings.Add("webText-currentNoEncounter", new LocalizationObject("No Encounter", ""));
                Strings.Add("webText-timersNoTimers", new LocalizationObject("No Spell Timers to display.", ""));
                Strings.Add("webText-miniNoEncounter", new LocalizationObject("No Encounter", ""));
                Strings.Add("webText-miniNoFormat", new LocalizationObject("No Text Format Selected", ""));
                Strings.Add("webText-reload", new LocalizationObject("Reload", ""));
                Strings.Add("webText-currentEncounter", new LocalizationObject("Current Encounter", ""));
                Strings.Add("webText-loading", new LocalizationObject("Loading...", ""));
                Strings.Add("webText-copyAll", new LocalizationObject("Copy All to Clipboard", ""));
                Strings.Add("webText-browse", new LocalizationObject("Browse", ""));
                Strings.Add("webText-actUi", new LocalizationObject("ACT Web Interface", ""));
                Strings.Add("webText-timers", new LocalizationObject("Spell Timers", ""));
                Strings.Add("webText-timersSimple", new LocalizationObject("Simple View", ""));
                Strings.Add("webText-timersNormal", new LocalizationObject("Normal View", ""));
                Strings.Add("uiFormAvoidanceReport-specialTitle",
                            new LocalizationObject("{0}'s Special Attack Report", ""));
                Strings.Add("uiFormAvoidanceReport-avoidLabel",
                            new LocalizationObject("[{4}] {0}'s {1} vs {2} = {3:0} Avg", "vs = verses, Avg = average"));
                Strings.Add("uiFormAvoidanceReport-avoidTitle",
                            new LocalizationObject("Avoid-Other Report for {0}  (Click a row for details)", ""));
                Strings.Add("uiFormAvoidanceReport-avoidType", new LocalizationObject("Type", ""));
                Strings.Add("uiFormAvoidanceReport-avoidCount", new LocalizationObject("Count", ""));
                Strings.Add("uiFormAvoidanceReport-avoidDamage",
                            new LocalizationObject("Damage Avoided By Average", ""));
                Strings.Add("uiFormAvoidanceReport-avoidHps", new LocalizationObject("EncHPS", ""));
                Strings.Add("attackTypeTerm-melee", new LocalizationObject("Melee", "auto-attack type, non-skill"));
                Strings.Add("uiFormAvoidanceReport-total", new LocalizationObject("TOTAL", ""));
                Strings.Add("uiFormAvoidanceReport-avoidTitle2",
                            new LocalizationObject("{0}'s Avoidance Report  (Click a row for details)", ""));
                Strings.Add("uiFormAvoidanceReport-avoidCount2", new LocalizationObject("Avoids", ""));
                Strings.Add("uiFormAvoidanceReport-percAvoids", new LocalizationObject("% of Avoids", ""));
                Strings.Add("uiFormAvoidanceReport-swings", new LocalizationObject("Swings", ""));
                Strings.Add("uiFormAvoidanceReport-percSwings", new LocalizationObject("% of Swings", ""));
                Strings.Add("uiFormAvoidanceReport-noDamage", new LocalizationObject("No Damage (Stoneskin)", ""));
                Strings.Add("messageBox-avoidanceCopyDetail",
                            new LocalizationObject("\n\nDo you wish to copy this to the windows clipboard?", ""));
                Strings.Add("messageBoxTitle-avoidanceCopyDetail",
                            new LocalizationObject("Per hit average damage avoided: {0}", ""));
                Strings.Add("uiFormByCombatantLookup-title", new LocalizationObject("{0} Breakdown by Combatant", ""));
                Strings.Add("uiFormCustomTriggerBenchmark-lineCount",
                            new LocalizationObject("{0:#,0} log lines in this encounter.", ""));
                Strings.Add("uiText-y", new LocalizationObject("Y", "Yes"));
                Strings.Add("uiText-n", new LocalizationObject("N", "No"));
                Strings.Add("messageBoxText-viewLogsDisabled",
                            new LocalizationObject(
                                "ACT currently is not allowed to store log lines with encounter objects.\n\nLook for an option called 'Record all log lines while parsing.' in the Misc options page.",
                                ""));
                Strings.Add("messageBoxTitle-viewLogsDisabled", new LocalizationObject("Log recording disabled", ""));
                Strings.Add("messageBoxText-ctBenchNoSelection",
                            new LocalizationObject("Please select an encounter in the left-side TreeView.", ""));
                Strings.Add("messageBoxTitle-ctBenchInvalid", new LocalizationObject("Invalid Selection", ""));
                Strings.Add("messageBoxText-ctBenchSmallSelection",
                            new LocalizationObject("Please select an encounter with more than 1000 log line entries.",
                                                   ""));
                Strings.Add("uiFormCustomTriggerBenchmark-bench1", new LocalizationObject("<Benchmark>", ""));
                Strings.Add("uiFormCustomTriggerBenchmark-benchBaseline",
                            new LocalizationObject("<Baseline benchmark...>", ""));
                Strings.Add("uiFormCustomTriggerBenchmark-benchRunning", new LocalizationObject("text", "<Running>"));
                Strings.Add("messageBoxText-ctBenchComplete1",
                            new LocalizationObject(
                                "The baseline benchmark did not consume enough time to be useful.  Please select another encounter that has more log lines available.",
                                ""));
                Strings.Add("messageBoxTitle-ctBenchComplete", new LocalizationObject("Complete", ""));
                Strings.Add("messageBoxText-ctBenchComplete2",
                            new LocalizationObject(
                                "Benchmarking complete.\n\nIdentify the Custom Triggers that are many times more expensive than the baseline for optimizations.  Alternatively, restrict them to a specific zone if not already done.",
                                ""));
                Strings.Add("uiFormEncounterVcr-currentHealth",
                            new LocalizationObject("Current Health: {0:0.00%} of {1:#,0}", ""));
                Strings.Add("uiFormEncounterVcr-damageTaken",
                            new LocalizationObject("Damage taken: {0:0.00%} of {1:#,0}", ""));
                Strings.Add("uiFormEncounterVcr-healingTaken",
                            new LocalizationObject("Healing taken: {0:0.00%} of {1:#,0}", ""));
                Strings.Add("uiFormEncounterVcr-paused", new LocalizationObject("Paused @ T+{0}", ""));
                Strings.Add("uiFormEncounterVcr-rewind", new LocalizationObject("Rewind @ T+{0}", ""));
                Strings.Add("uiFormEncounterVcr-linked", new LocalizationObject("Linked @ T+{0}", ""));
                Strings.Add("uiFormEncounterVcr-play", new LocalizationObject("Play @ T+{0}", ""));
                Strings.Add("uiFormEncounterVcr-play4", new LocalizationObject("4x Play @ T+{0}", ""));
                Strings.Add("uiFormExportFormat-noSelection", new LocalizationObject("No Element Selected", ""));
                Strings.Add("uiFormExportFormat-save", new LocalizationObject("Save", ""));
                Strings.Add("uiFormExportFormat-edit", new LocalizationObject("Edit Directly", ""));
                Strings.Add("messageBoxTitle-getPluginsError1",
                            new LocalizationObject("Error retrieving plugin list", ""));
                Strings.Add("uiFormGetPlugins-headerLabel",
                            new LocalizationObject("Plugin Description (Added: {1} - Modified: {2} {3})", ""));
                Strings.Add("messageBoxText-getPluginsApplied",
                            new LocalizationObject("The plugin has been added and started.", ""));
                Strings.Add("messageBoxTitle-getPluginsApplied", new LocalizationObject("Plugin Applied", ""));
                Strings.Add("messageBoxText-getPluginsApplyFail",
                            new LocalizationObject("The downloaded file did not contain a plugin that could be loaded.",
                                                   ""));
                Strings.Add("messageBoxTitle-getPluginsApplyFail", new LocalizationObject("Plugin Load Failure", ""));
                Strings.Add("messageBoxText-getPluginsAppliedZip",
                            new LocalizationObject("From the ZIP, {0} plugin(s) have been added and started.", ""));
                Strings.Add("messageBoxText-getPluginsUnknownFile",
                            new LocalizationObject("The downloaded file was not of the expected type for a plugin.",
                                                   ""));
                Strings.Add("messageBoxTitle-getPluginsUnknownFile", new LocalizationObject("Unknown file type", ""));
                Strings.Add("messageBoxTitle-getPluginsApplyFail2",
                            new LocalizationObject("Error applying plugin", ""));
                Strings.Add("messageBoxText-getPlugins429",
                            new LocalizationObject(
                                "The remote server returned a 429 status error.\n\nThis may mean you have tried to access this resource too many times recently.  Please try again later.",
                                ""));
                Strings.Add("messageBoxText-getPlugins503",
                            new LocalizationObject(
                                "The remote server returned a 503 status error.\n\nThis may mean you have tried to access this resource too many times recently.  Please try again later.",
                                ""));
                Strings.Add("uiFormImportProgress-batchStep", new LocalizationObject("Batch {0} of {1}", ""));
                Strings.Add("uiFormImportProgress-progressPerc", new LocalizationObject("Progress: {0}%", ""));
                Strings.Add("uiFormImportProgress-importStats",
                            new LocalizationObject("{0:#,0}s\n{1:#,0}\n{2:#,0} per sec\n{3:#,0} k\n{4:#,0} k/s", ""));
                Strings.Add("uiFormImportProgress-timeElapsed",
                            new LocalizationObject("Operation Time Elapsed: {0:#,0}s\n", ""));
                Strings.Add("uiFormImportProgress-complete", new LocalizationObject("Operation Complete", ""));
                Strings.Add("messageBoxText-importAbort",
                            new LocalizationObject("Do you wish to abort the import process?", ""));
                Strings.Add("messageBoxTitle-importAbort", new LocalizationObject("Abort?", ""));
                Strings.Add("uiFormMiniParse-switchTooltip",
                            new LocalizationObject("Switch between text and graph modes", ""));
                Strings.Add("uiFormMiniParse-valueTooltip", new LocalizationObject("Val: {0:0} Y: {1}", ""));
                Strings.Add("uiFormPerformanceWizard-simple", new LocalizationObject("Simple", ""));
                Strings.Add("uiFormPerformanceWizard-advanced", new LocalizationObject("Advanced", ""));
                Strings.Add("uiFormResistsDeathReport-deathLegend",
                            new LocalizationObject("Time: Dmg (Dmg - Heal) [Dmg Total]\n", ""));
                Strings.Add("uiFormResistsDeathReport-deathTitle", new LocalizationObject("Death Report", ""));
                Strings.Add("uiFormResistsDeathReport-reportCopyLeft",
                            new LocalizationObject("Click to copy to the left...\n", ""));
                Strings.Add("uiFormCustomEncRange-custom", new LocalizationObject("CustomEnc", ""));
                Strings.Add("uiFormSpellRecastCalc-title",
                            new LocalizationObject("Spell Recast Calculation - {0} -> {1}", ""));
                Strings.Add("uiFormSpellRecastCalc-delaysLabel", new LocalizationObject("Checked Delays: ", ""));
                Strings.Add("messageBoxText-addCalcTimer",
                            new LocalizationObject(
                                "The lowest calculated recast has been sent to the spell timer options.  Do you wish to add/replace this timer now?",
                                ""));
                Strings.Add("messageBoxTitle-addCalcTimer", new LocalizationObject("Add Timer Now?", ""));
                Strings.Add("tts-spellStarted",
                            new LocalizationObject("{0} started", "Text to Speech: SpellName started"));
                Strings.Add("tts-spellWarning",
                            new LocalizationObject("{0} warning", "Text to Speech: SpellName warning"));
                Strings.Add("tts-spellExpired",
                            new LocalizationObject("{0} expired", "Text to Speech: SpellName expired"));
                Strings.Add("uiFormSpellTimers-displayTooltip",
                            new LocalizationObject("{0}s - {1}", "12s - SpellName"));
                Strings.Add("uiFormSpellTimers-displayRemaining",
                            new LocalizationObject("{0:00}m {1:00}s{2}", "01m 30s"));
                Strings.Add("messageBox-playerRemoveError",
                            new LocalizationObject("Please select a name in the list to remove.", ""));
                Strings.Add("messageBoxTitle-playerRemoveError", new LocalizationObject("No Selection", ""));
                Strings.Add("uiFormSpellTimers-searchPH",
                            new LocalizationObject("Search name or tooltip",
                                                   "Placeholder to show when textbox is empty"));
                Strings.Add("uiFormSpellTimersPanel-optionsTooltip",
                            new LocalizationObject("Right-click for options", ""));
                Strings.Add("uiFormSqlQuery-connectionInfo",
                            new LocalizationObject("ServerVersion: {0}, Database: {1}, DataSource: {2}", ""));
                Strings.Add("messageBoxTitle-odbcQueryError",
                            new LocalizationObject("ODBC Connection Query Failed", ""));
                Strings.Add("uiFormSqlQuery-rowsAffected", new LocalizationObject("\n{0} - Rows affected: {1}", ""));
                Strings.Add("uiFormSqlQuery-tableCommitError",
                            new LocalizationObject("\n{0} - {1} has the following error: {2} -- and has been ignored.",
                                                   "0 = timestamp, 1 = table row text, 2 = error text"));
                Strings.Add("messageBoxText-startupWizParserWarn",
                            new LocalizationObject(
                                "Simple detection suggests that you may already have a parsing plugin enabled.  Check the Plugins tab before adding another.",
                                ""));
                Strings.Add("messageBoxTitle-startupWizParserWarn", new LocalizationObject("Plugin event in-use", ""));
                Strings.Add("messageBoxText-startupWizFF14",
                            new LocalizationObject("Will ACT be used for Final Fantasy XIV?", ""));
                Strings.Add("messageBoxTitle-startupWizFF14", new LocalizationObject("FFXIV?", ""));
                Strings.Add("uiFormStartupWizard-pluginLog", new LocalizationObject("Plugin selected log file.", ""));
                Strings.Add("uiText-startupWizLogFileInfo",
                            new LocalizationObject("{0}\\{1}\nFile size: {2:0,0}  Last Modified: {3}", ""));
                Strings.Add("uiFormStartupWizard-pluginLog2",
                            new LocalizationObject("Log file status unknown.  Plugin may regenerate later.", ""));
                Strings.Add("messageBoxText-startupWizEQ2",
                            new LocalizationObject("Will ACT be used for EverQuest II?", ""));
                Strings.Add("messageBoxTitle-startupWizEQ2", new LocalizationObject("EQ2?", ""));
                Strings.Add("messageBox-eq2FolderWizard",
                            new LocalizationObject("Detected EQ2 path is:\n{0}\n\nIs this correct?", ""));
                Strings.Add("messageBoxTitle-eq2FolderWizard", new LocalizationObject("Detected EQ2 Folder", ""));
                Strings.Add("uiFormStartupWizard-eq2FolderTitle",
                            new LocalizationObject("Select your EQ2 installation folder", ""));
                Strings.Add("uiFormStartupWizard-eq2FolderFound", new LocalizationObject("EQ2 Logs folder found.", ""));
                Strings.Add("messageBox-openLogWizardNoLogs",
                            new LocalizationObject(
                                "No logs seem to exist in this folder or subfolder.  You must have logging enabled within EQ2 to use ACT.  Type \"/log\" within EQ2 to determine the logging status.",
                                ""));
                Strings.Add("messageBoxTitle-openLogWizardNoLogs", new LocalizationObject("No logfiles found", ""));
                Strings.Add("messageBoxTitle-openLogWizard", new LocalizationObject("Detected log file", ""));
                Strings.Add("messageBox-openLogWizard",
                            new LocalizationObject("\nIs the displayed log file the one you wish to open with ACT?",
                                                   ""));
                Strings.Add("uiFormStartupWizard-eq2FolderFound2",
                            new LocalizationObject("EQ2 Logs folder not found.", ""));
                Strings.Add("messageBox-openLogWizardNoFolder",
                            new LocalizationObject(
                                "No logs folder exists within this folder.  You must have logging enabled within EQ2 to use ACT.  Type \"/log\" within EQ2 to determine the logging status.",
                                ""));
                Strings.Add("messageBoxTitle-openLogWizardNoFolder", new LocalizationObject("No logs folder", ""));
                Strings.Add("messageBoxText-startupWizManualSelect",
                            new LocalizationObject("Please manually select your game log file.", ""));
                Strings.Add("messageBoxTitle-startupWizManualSelect", new LocalizationObject("Select log file", ""));
                Strings.Add("uiFormStartupWizard-loading", new LocalizationObject("Please wait...", ""));
                Strings.Add("messageBoxTitle-pluginWizTitleError",
                            new LocalizationObject("Could not retrieve plugin titles", ""));
                Strings.Add("uiFormStartupWizard-pluginInfo",
                            new LocalizationObject("Added: {1} - Modified: {2} {3}", ""));
                Strings.Add("messageBoxText-pluginWizParserAdded",
                            new LocalizationObject("The parsing plugin has been added and started.", ""));
                Strings.Add("uiFormTimeLine-title1", new LocalizationObject("Timeline - {0} {1:0.00}%", ""));
                Strings.Add("damageTypeTerm-outDamage", new LocalizationObject("Outgoing Damage", ""));
                Strings.Add("damageTypeTerm-incDamage", new LocalizationObject("Incoming Damage", ""));
                Strings.Add("damageTypeTerm-outHealing", new LocalizationObject("Outgoing Healing", ""));
                Strings.Add("damageTypeTerm-incHealing", new LocalizationObject("Incoming Healing", ""));
                Strings.Add("uiFormTimeLine-classType1", new LocalizationObject("Tanks", ""));
                Strings.Add("uiFormTimeLine-classType2", new LocalizationObject("Healers", ""));
                Strings.Add("uiFormTimeLine-classType3", new LocalizationObject("Melee DPS", ""));
                Strings.Add("uiFormTimeLine-classType4", new LocalizationObject("Other DPS", ""));
                Strings.Add("uiFormTimeLine-alignType1", new LocalizationObject("Us", ""));
                Strings.Add("uiFormTimeLine-alignType2", new LocalizationObject("Them", ""));
                Strings.Add("uiFormTimeLine-title2", new LocalizationObject("Timeline", ""));
                Strings.Add("uiFormTimeLine-toolTipError",
                            new LocalizationObject(
                                "This tool tip is too large.  Please Middle-Click to view separately.", ""));
                Strings.Add("uiFormUpdater-checking", new LocalizationObject("Checking version from web...", ""));
                Strings.Add("messageBox-updateCheckFail",
                            new LocalizationObject("Unable to obtain version info from web.\n", ""));
                Strings.Add("messageBoxTitle-updateCheckFail", new LocalizationObject("ACT version check failed", ""));
                Strings.Add("uiFormUpdater-noUpdates", new LocalizationObject("No updates available.", ""));
                Strings.Add("uiFormUpdater-updateAvailable",
                            new LocalizationObject("Update to {0} available.\nPress Download to retrieve.", ""));
                Strings.Add("trayTitle-updateAvailable", new LocalizationObject("ACT Update Available", ""));
                Strings.Add("uiFormUpdater-download1",
                            new LocalizationObject("Downloading update...  connecting...", ""));
                Strings.Add("uiFormUpdater-download2",
                            new LocalizationObject("Downloading update: {0:#,0} of {1:#,0} KB.", ""));
                Strings.Add("uiFormUpdater-download3",
                            new LocalizationObject("Downloading update: {0:#,0} KB read...", ""));
                Strings.Add("uiFormUpdater-downloadError",
                            new LocalizationObject("There was an error updating:\n", ""));
                Strings.Add("uiFormUpdater-download4",
                            new LocalizationObject("Download is complete.  Click Update to continue.", ""));
                Strings.Add("messageBox-updateAct",
                            new LocalizationObject(
                                "This will close the program and start the update.\nDo you wish to continue?", ""));
                Strings.Add("messageBoxTitle-updateAct", new LocalizationObject("Update?", ""));
                Strings.Add("messageBoxTitle-updateError", new LocalizationObject("Error Updating", ""));
                Strings.Add("uiIoImportClip-noText",
                            new LocalizationObject("The clipboard did not contain text data.", ""));
                Strings.Add("uiIoImportClip-clipStatus",
                            new LocalizationObject("The Windows clipboard contains {0:#,0} characters.", ""));
                Strings.Add("fileDialogFilter-xml", new LocalizationObject("XML File (*.xml)|*.xml", ""));
                Strings.Add("fileDialogTitle-xmlEncounter", new LocalizationObject("Export Encounter to XML", ""));
                Strings.Add("uiIoXmlFile-exporting", new LocalizationObject("Exporting XML...\nPlease wait...", ""));
                Strings.Add("uiIoXmlFile-exportComplete",
                            new LocalizationObject("Export to {0} has completed.\n{1:0} seconds elapsed.", ""));
                Strings.Add("uiIoXmlFile-exportCanceled", new LocalizationObject("Export canceled...", ""));
                Strings.Add("messageBoxText-colorRestart",
                            new LocalizationObject("You must restart ACT to revert these color changes.", ""));
                Strings.Add("messageBoxTitle-colorRestart", new LocalizationObject("Restart required", ""));
                Strings.Add("messageBoxText-abilityRedirectError",
                            new LocalizationObject(
                                "Please fill in both the Ability and Into fields and select an ability type.", ""));
                Strings.Add("messageBoxTitle-abilityRedirectError", new LocalizationObject("Invalid Entry", ""));
                Strings.Add("messageBoxText-combatantRenameError",
                            new LocalizationObject("Please fill in both the Before and After fields.", ""));
                Strings.Add("messageBoxTitle-combatantRenameError", new LocalizationObject("Invalid Entry", ""));
                Strings.Add("messageBox-uiExport1",
                            new LocalizationObject(
                                "Do you wish to set the homepage of EQ2's embedded browser to ACT's encounter index?",
                                ""));
                Strings.Add("messageBox-uiExport2",
                            new LocalizationObject(
                                "Do you wish to replace EQ2's browser window with one that has a collapsable interface and URL bar?",
                                ""));
                Strings.Add("messageBox-ftpConnectionTest",
                            new LocalizationObject(
                                "ACT may become unresponsive during this test.  Please wait at least 30 seconds while the test is performing, and allow access through firewall notifications if they appear.",
                                ""));
                Strings.Add("messageBox-ftpTestSuccess",
                            new LocalizationObject(
                                "\n\n=============================\nThe test completed sucessfully.\n\n", ""));
                Strings.Add("messageBoxTitle-ftpTestSuccess", new LocalizationObject("Test complete", ""));
                Strings.Add("messageBoxTitle-ftpTestFail", new LocalizationObject("Test incomplete", ""));
                Strings.Add("fileDialogTitle-importSettingsXml",
                            new LocalizationObject("Import Settings from XML", ""));
                Strings.Add("uiOptionsImportExport-xmlConverted",
                            new LocalizationObject(
                                "XML Converted.  The above may be copied as an ACT Config Snippet to paste.", ""));
                Strings.Add("messageBoxText-restartAct",
                            new LocalizationObject("You must restart ACT to apply changes.", ""));
                Strings.Add("messageBoxTitle-restartAct", new LocalizationObject("Restart", ""));
                Strings.Add("uiOptionsOdbc-connectSuccess", new LocalizationObject("ODBC Connection Succeeded", ""));
                Strings.Add("uiOptionsOdbc-tableValidated",
                            new LocalizationObject("'{0}' validated successfully.", ""));
                Strings.Add("uiOptionsOdbc-tableCreated", new LocalizationObject("'{0}' created successfully.", ""));
                Strings.Add("messageBox-odbcDropTables",
                            new LocalizationObject(
                                "This procedure will delete all ACT related table data and remove the tables from the database.\nOnce completed, this cannot be undone and the tables will have to be recreated before ACT can store data on them once again.\n\nAre you sure you wish to continue?",
                                ""));
                Strings.Add("messageBoxTitle-odbcDropTables", new LocalizationObject("ACT ODBC database removal", ""));
                Strings.Add("uiOptionsOdbc-tableDropped", new LocalizationObject("'{0}' dropped successfully.", ""));
                Strings.Add("messageBoxTitle-odbcHackError", new LocalizationObject("Could not add OdbcHack", ""));
                Strings.Add("tts-spellStartedTest", new LocalizationObject("Spellname started", ""));
                Strings.Add("tts-spellWarningTest", new LocalizationObject("Spellname warning", ""));
                Strings.Add("tts-spellExpiredTest", new LocalizationObject("Spellname expired", ""));
                Strings.Add("uiOptionsSound-soundMethod", new LocalizationObject("Sound Method:", ""));
                Strings.Add("tts-commandTest", new LocalizationObject("Command name", ""));
                Strings.Add("uiOptionsSound-ttsMethod", new LocalizationObject("TTS Method:", ""));
                Strings.Add("helpPanel-soundTts-lblTtsMethod",
                            new LocalizationObject("The currently used TTS engine method", ""));
                Strings.Add("helpPanel-soundTts-TestTts",
                            new LocalizationObject("Enter a text string to speak with the current rules and engine",
                                                   ""));
                Strings.Add("helpPanel-soundTts-correction",
                            new LocalizationObject(
                                "Uses regular expressions to find parts of a TTS string and replaces them with a specified correction.  Mostly this is used to correct pronunciation.",
                                ""));
                Strings.Add("helpPanel-soundTts-rbTtsSapiDirect",
                            new LocalizationObject(
                                "Uses the Windows SAPI directly.  This will have a different volume curve when compared to the other setting and other WAV sound files.",
                                ""));
                Strings.Add("helpPanel-soundTts-rbTtsSapiWav",
                            new LocalizationObject(
                                "Uses temporary WAV files created by Windows SAPI.  This method was originally created for low resource machines that could not play TTS reliably while playing a demanding CPU bound game.",
                                ""));
                Strings.Add("helpPanel-soundTts-linkTtsCpl",
                            new LocalizationObject(
                                "Opens the classic Text To Speech Control Panel applet.  The Windows 10/11 Settings app only affects UWP apps, not ACT.",
                                ""));
                Strings.Add("messageBoxText-exFilePrefixBlank",
                            new LocalizationObject(
                                "Leaving this blank field is dangerous and will result in macro files that will not function unless the used Clipboard Format properly prefixes channel commands to every line.",
                                ""));
                Strings.Add("messageBoxTitle-exFilePrefixBlank",
                            new LocalizationObject("DoFileCommands Channel Prefix", ""));
                Strings.Add("ttOptionsXmlShare-noName", new LocalizationObject("A name must be entered", ""));
                Strings.Add("ttOptionsXmlShare-xmlMissingAttributes",
                            new LocalizationObject(
                                "The shared XML seems to be missing required attributes to be imported", ""));
                Strings.Add("messageBoxTitle-xmlShareError", new LocalizationObject("Error parsing XML Share", ""));
                Strings.Add("messageBoxText-xmlSnippetNotUsed",
                            new LocalizationObject(
                                "{0}: No XML Snippet Handler marked the snippet as used.  This share type may require a plugin.",
                                ""));
                Strings.Add("messageBoxTitle-xmlSnippetError", new LocalizationObject("Error adding XML Share", ""));
                Strings.Add("uiOptionsXmlShare-customEntry", new LocalizationObject("* Custom Entry *", ""));
                Strings.Add("ttOptionsXmlShare-invalidXml",
                            new LocalizationObject("Invalid XML: Use this field to paste XML share text", ""));
                Strings.Add("uiOptionsXmlShare-pasteHere", new LocalizationObject("(Paste XML Here)", ""));
                Strings.Add("notifTitle-xmlShareAdded", new LocalizationObject("ACT XML Share", ""));
                Strings.Add("notifText-xmlShareAdded",
                            new LocalizationObject("A ({0}) from ({1}) has been added to ACT.", ""));
                Strings.Add("notifText-xmlShareDetected",
                            new LocalizationObject(
                                "A ({0}) from ({1}) has been detected in the log file.\n\nWould you like to import this to ACT?\n\n\n\n\n[Also in Options -> Configuration Import/Export -> XML Share Snippets]",
                                ""));
                Strings.Add("messageboxText-xmlShareUnknown",
                            new LocalizationObject(
                                "{0}: No XML Snippet Handler marked the snippet as consumed.  Does this share type require a plugin?",
                                ""));
                Strings.Add("messageboxTitle-xmlShareError", new LocalizationObject("Error adding XML Share", ""));
                Strings.Add("messageBoxText-xmlShareInvalid",
                            new LocalizationObject(
                                "This feature is for importing XML Share snippets, only.  If you wish to import an XML configuration file, use the Import button in Options -> Configuration Import/Export.",
                                ""));
            }

            internal static void Init()
            {
                Strings.Clear();
                Strings.Add("helpPanel-btnResetOdbcHacks",
                            new LocalizationObject(
                                "This button will delete all ODBC hacks and replace them with a set of known hacks for various datasources, such as MSSQL, MS Access, Postgres...",
                                string.Empty));
                Strings.Add("helpPanel-gbOdbcHacks",
                            new LocalizationObject(
                                "This section contains rules to modify all commands sent to the datasource if the connection string matches the rule.  You may use the Reset button to pre-populate known rules for reference.",
                                string.Empty));
                Strings.Add("helpPanel-btnExportUIBrowser",
                            new LocalizationObject(
                                "Press this button to start a wizard allowing you to set the EQ2's web browser to ACT's encounter index and optionally extracting a browser UI replacement with a collapsable interface and controls for maximum screen space.",
                                string.Empty));
                Strings.Add("helpPanel-btnOdbcDropTables",
                            new LocalizationObject(
                                "This will perform the DROP command on each table ACT uses.  This will delete all table data and remove the tables from the datasource.",
                                string.Empty));
                Strings.Add("helpPanel-btnOdbcTestConnection",
                            new LocalizationObject(
                                "This will attempt to log into the ODBC datasource specified in the Connection String.",
                                string.Empty));
                Strings.Add("helpPanel-btnOdbcValidateTables",
                            new LocalizationObject(
                                "This will make sure the ODBC datasource has the required tables and the tables have the required columns.  If anything is missing, ACT will attempt to create or alter the tables.  Success is required to do SQL exporting.",
                                string.Empty));
                Strings.Add("helpPanel-cbBlockisHit",
                            new LocalizationObject(
                                "When checked, a hit that reports that it fails to inflict any damage will still be considered a Hit.  When unchecked, only an attack that does damage is considered successful.",
                                string.Empty));
                Strings.Add("helpPanel-cbCurrentOdbc",
                            new LocalizationObject(
                                "When in combat, ACT can export to a temporary table called current_table on your ODBC datasource every few seconds.  Every export, the table will be deleted and refilled to reflect the current encounter.  This option is only recommended if you have a very quick connection to your datasource.",
                                string.Empty));
                Strings.Add("helpPanel-cbDoubleBufferLV",
                            new LocalizationObject(
                                "When checked, ACT will attempt to enable minimal redrawing of the main table.  Windows versions before WindowsXP normally do not have this ability and may cause undesired results.",
                                string.Empty));
                Strings.Add("helpPanel-cbExGraph",
                            new LocalizationObject("When checked, HTML exports will include a main encounter graph.",
                                                   string.Empty));
                Strings.Add("helpPanel-cbExHTML",
                            new LocalizationObject(
                                "EQ2 comes with an integrated web browser based on FireFox.  This can be used to view data exported by ACT while in fullscreen.  The main encounter table will be exported as HTML to be viewed within the EQ2 HTML window.  To access the HTML window, type: \"/browser\"",
                                string.Empty));
                Strings.Add("helpPanel-cbExHTMLFTP",
                            new LocalizationObject(
                                "If checked, when ACT exports EQ2 compatible HTML files, it will attempt to upload them to an FTP server of your choice.  Make sure to test your settings before use.",
                                string.Empty));
                Strings.Add("helpPanel-cbExOdbc",
                            new LocalizationObject(
                                "This will enable SQL exporting via ODBC automatically when an encounter ends.\n\nTo use this feature, you need an ODBC driver to connect to your datasource and to fill out the Connection String with the remote host info. http://connectionstrings.com/ can help you make a connection string for your specific SQL datasource.",
                                string.Empty));
                Strings.Add("helpPanel-cbExportBeep",
                            new LocalizationObject(
                                "When checked, any exporting to the clipboard will cause a default system beep.  This is a good indication of when an encounter is ended and there is new data to paste into EQ2.",
                                string.Empty));
                Strings.Add("helpPanel-cbExportFilterSpace",
                            new LocalizationObject(
                                "When checked, the Mini Parse window and clipboard exporting will exclude any combatants with spaces in their names.  This will exclude most mobs such as 'a giant bat' or 'King Drayek', but not 'Anguis' or 'Frostbite'.",
                                string.Empty));
                Strings.Add("helpPanel-cbExText",
                            new LocalizationObject(
                                "Combatant summaries for the encounter will be exported to the clipboard after an encounter has ended.  These summaries can be pasted into EQ2 by pressing Ctrl-V, and customized under General Options -> Text Only Formatting -> Clipboard Export Formatting.",
                                string.Empty));
                Strings.Add("helpPanel-cbGermanMergeNames",
                            new LocalizationObject(
                                "If enabled, combatants with grammatical changes such as: ruhiger Wachposten, ruhigen Wachpostens s, ruhigen Wachposten, ruhige Wachposten, ruhigen Wachposten en; will all show up as the same combatant.  (Which ever showed up first in an encounter)",
                                string.Empty));
                Strings.Add("helpPanel-cbGExpEnd",
                            new LocalizationObject(
                                "If 'You gain bonus experience for defeating the encounter!' is seen, the encounter will be considered ended. \n('You convert experience into achievement experience!' twice in a single second will also trigger this.)",
                                string.Empty));
                Strings.Add("helpPanel-cbGraphSoloInc",
                            new LocalizationObject(
                                "When unchecked, solo combatant graphs will only show DPS lines for outgoing damage.  When checked, incoming damage and incoming heal DPS lines will also be generated.  (This will slightly increase the CPU time used to generate)",
                                string.Empty));
                Strings.Add("helpPanel-cbHtmlTimers",
                            new LocalizationObject(
                                "When checked, ACT will export an HTML page displaying the current view of the Timers Window.  The timer view will have the same dimensions as the original window, so resize it to your needs.",
                                string.Empty));
                Strings.Add("helpPanel-cbIdleEnd",
                            new LocalizationObject(
                                "If no combat actions such as attacking are observed for N number of seconds, the encounter will be considered ended.",
                                string.Empty));
                Strings.Add("helpPanel-cbIdleTimerEnd",
                            new LocalizationObject(
                                "A previously defaulted non-option, ACT can internally count seconds of inactivity instead of waiting on a log timestamp with a time sufficiently after the last combat action.  If disabled, ACT will only end encounters based off of timestamps, and if no new log lines are parsed, its possible to never end an encounter *until* a new log timestamp is seen from EQ2.  When enabled, the timer will not strictly end an encounter based off the timer, but two seconds after (in absense of log timestamps).",
                                string.Empty));
                Strings.Add("helpPanel-cbKillEnd",
                            new LocalizationObject(
                                "When an allied combatant kills another, the encounter will be considered ended.",
                                string.Empty));
                Strings.Add("helpPanel-cbLcdRoute",
                            new LocalizationObject(
                                "When the ACT Clipboard Sharer is connected, using this option will route all LCD traffic to the G15 LCD on the connected computer's keyboard.  This allows you to run ACT on a different computer than EQ2 and retain all LCD functionality.",
                                string.Empty));
                Strings.Add("helpPanel-cbLongEncDuration",
                            new LocalizationObject(
                                "Previously when only using timed encounter ending, heals being cast while the delay was counting down could affect the encounter's total duration, and therefore ExtDPS.  If unchecked, heals after the last combat action will still be recorded up until the encounter is terminated, but will not affect the duration of the encounter.",
                                string.Empty));
                Strings.Add("helpPanel-cbMiniClickThrough",
                            new LocalizationObject(
                                "When enabled, mouse actions will not affect the Mini Window.  When transparency is set, this allows you to both see through and click on things behind the window.  Of course you can no longer move or close the window by normal means until click-through is disabled.  NOTE: You may toggle this option by right-clicking the main window 'Show Mini' button.",
                                string.Empty));
                Strings.Add("helpPanel-cbMultiDamageIsOne",
                            new LocalizationObject(
                                "When enabled, an attack that has multiple damage types, such as \"300 crushing, 5 poison and 5 disease damage\" will show up as one total attack: 300/5/5 crushing/poison/disease, internally seen as 310.  If disabled, each damage type will show up as an individual swing, IE three attacks: 300 crushing; 5 poison; 5 disease.  Having a single attack show up as multiple will have consequences when calculating ToHit%.",
                                string.Empty));
                Strings.Add("helpPanel-cbOnlyGraphAllies",
                            new LocalizationObject(
                                "When checked, simple encounter bar graphs will only show your allies.", string.Empty));
                Strings.Add("helpPanel-cbPetIsMaster",
                            new LocalizationObject(
                                "When checked, a pet will not show as its own entry, but as a spell under their master.  When unchecked, the pet is considered a seperate combatant and has its own statistics unrelated to its master.\nThis setting is not retroactive, and will not combine or seperate a pet from its master if the encounter has already taken place.  Only future encounters will be affected by this setting.\n\n\nSince LU19 and <Purpose tags> showing under a pet's name and not in log files, parsers cannot automatically see who a pet belongs to.",
                                string.Empty));
                Strings.Add("helpPanel-cbRecalcWardedHits",
                            new LocalizationObject(
                                "If enabled, no-damage hits or reduced damage hits immediately following a ward absorbtion will be increased by the absorbtion amount.  Stoneskin's no-damage hits cannot be recalculated.",
                                string.Empty));
                Strings.Add("helpPanel-cbRecordLogs",
                            new LocalizationObject(
                                "When checked, ACT will record all log lines that appear during an encounter.  You may then right click an encounter, select View Logs and view/search through them.  Disabling this option will reduce memory usage by a bit less than 45% when compared to default settings.  Exported ACT files will retain these recorded logs.",
                                string.Empty));
                Strings.Add("helpPanel-cbRestrictToAll",
                            new LocalizationObject(
                                "When checked, under each combatant, the only Damage Types entries that will be fully populated will be the ones marked (Ref) for Reference.  Instead of 'Melee (Out)' showing All, crush, and slash it will only show All, which is a combination of crush/slash.  Crush and slash will still be found under 'All Outgoing (Ref)' due to the (Ref) tag; the listing will simply be more crowded.\nEnabling this options willl reduce CPU usage by a bit less than 10% and reduce memory usage by a bit more than 10% when compared to default settings.  Unchecked, this option will populate all entries in their logical listings.",
                                string.Empty));
                Strings.Add("helpPanel-cbSExpEnd",
                            new LocalizationObject(
                                "If 'You gain experience!' is seen, the encounter will be considered ended. \n('You convert experience into achievement experience!' will also trigger this.)",
                                string.Empty));
                Strings.Add("helpPanel-cbSqlSafeMode",
                            new LocalizationObject(
                                "In safe mode, SQL commands will be sent one at a time and server response checked.  Otherwise commands will be sent in 100 row batches, which while faster will be more problematic to debug.",
                                string.Empty));
                Strings.Add("helpPanel-cbSwarmIsMaster",
                            new LocalizationObject(
                                "When enabled, \"Дух огня (персонажа)\", \"Wässrige Horde des Character\" and other similarly named pets will have their attack damage added to their master instead of as their own named entry.  Incoming attacks will *not* be redirected to their master's data.",
                                string.Empty));
                Strings.Add("helpPanel-cbWebServerEnabled",
                            new LocalizationObject(
                                "The ACT Web Interface is somewhat similar to the EQ2 HTML exports in appearance.  Dissimilarly, the web interface is not made up of intermediary HTML files but generated HTML upon request.  By default, you can see auto-updating pages of the current encounter table, Mini-Window text(with support for multiple presets), spell timers and a page that can browse through all of ACT's encounter data in memory.  Context-menu reports based on that data are not currently available but plugins can be made to expand the web interface.",
                                string.Empty));
                Strings.Add("helpPanel-cbWebServerShowReq",
                            new LocalizationObject(
                                "If enabled, all HTTP requests will be shown.  Otherwise things like auto-updating portions of pages or .css/.js files will be hidden (unless very large).  One request to '/timers'(always shown) may initiate requests to '/ACT.js', '/ACT.css' and '/timers.body'(optionally shown) as well.",
                                string.Empty));
                Strings.Add("helpPanel-cbZoneAllListing",
                            new LocalizationObject(
                                "As the first encounter of each Zone branch, an \"All\" entry can exist which will combine all data from other encounters for that zone.  As encounters progress within that zone, the All entry will be updated in real time.  The All encounter entry will be identical to a merged encounter of all encounters within that zone.\n\nDisabling this option will reduce memory and CPU usage a bit more than 10% when compared to default options.",
                                string.Empty));
                Strings.Add("helpPanel-CurrentExports",
                            new LocalizationObject(
                                "Checking this will create a custom HTML page with an auto updating graph or table.  The page will auto-refresh at the user specified interval providing more or less a real-time view of the encounter.",
                                string.Empty));
                Strings.Add("helpPanel-ddlGraphPriority",
                            new LocalizationObject(
                                "This setting will change the priority of graph generation.  All programs have a priority, usually Normal by default, and this priority defines how much CPU time should be given to the current task.  If set to Lowest(Idle), graph generation will only take CPU time not used by other applications.  If EQ2 is running, this will be next to nothing.  Normal priority will give equal amounts of CPU time to ACT and any other task, such as EQ2. Above Normal(Not recommended) will give graph generation more priority than most other programs and may cause noticable stuttering in EQ2 momentary freezing.  ACT's UI may also become unresponsive during graph generation.",
                                string.Empty));
                Strings.Add("helpPanel-ddlLanguage",
                            new LocalizationObject(
                                "This will change the parsing engine to another language or Spell Timers only mode.",
                                string.Empty));
                Strings.Add("helpPanel-ExFTPPASV",
                            new LocalizationObject(
                                "If you are behind a router or have multiple NICs you may need to use Passive mode transfers.  If the target FTP server is under the same conditions(a PASV only state), you must use Active mode.  Two machines that require PASV mode cannot establish FTP transfers.",
                                string.Empty));
                Strings.Add("helpPanel-GraphSize",
                            new LocalizationObject(
                                "This will set the image dimentions of the graph in HTML exporting and EQ2 viewing.",
                                string.Empty));
                Strings.Add("helpPanel-GraphType",
                            new LocalizationObject("Select a graphing method for the main encounter display.",
                                                   string.Empty));
                Strings.Add("helpPanel-lblWebServerPort",
                            new LocalizationObject(
                                "The listening port to accept HTTP requests from.  If you use a non-standard port (80), clients must add that port to their URL notation like the following: http://127.0.0.1:80/",
                                string.Empty));
                Strings.Add("helpPanel-LogPriority",
                            new LocalizationObject(
                                "This setting will change the priority of normal log parsing.  All programs have a priority, usually Normal by default, and this priority defines how much CPU time should be given to the current task.  If set to Lowest(Idle), log parsing will only take CPU time not used by other applications.  If EQ2 is running, this will be next to nothing.  Normal priority will give equal amounts of CPU time to ACT and any other task, such as EQ2.\n\nIf ACT seems unable to keep up with log parsing tasks while EQ2 is running, you may wish to set this to Above Normal.\n\nFor this setting to take effect, you must restart ACT or Close and Reopen the current log.",
                                string.Empty));
                Strings.Add("helpPanel-SampleType",
                            new LocalizationObject(
                                "These settings affect how many DPS plots there are along the X-Axis.  If an encounter is one minute long, and Fixed number of DPS samples(6) is selected, there will be six X-Axis plots in 10 second intervals.  If DPS samples every 15 seconds is selected, there will be four DPS plots at 15 second intervals.  Fixed number is useful for keeping a graph readable no matter how long the encounter, and fixed sample durations is useful for comparisons to other time lines.",
                                string.Empty));
                Strings.Add("helpPanel-tbCharName",
                            new LocalizationObject(
                                "If a log file is open this setting is ignored; however if ACT is used as an offline parser only, this setting will be used to fill in your name instead of using 'YOU'.",
                                string.Empty));
                Strings.Add("helpPanel-TextFormatAddPreset",
                            new LocalizationObject("Save these format options to the drop down list.", string.Empty));
                Strings.Add("helpPanel-TextFormatAllies",
                            new LocalizationObject("Allies formatting string. (First Line Format)", string.Empty));
                Strings.Add("helpPanel-TextFormatAlliesOnly",
                            new LocalizationObject(
                                "When checked, only combatants who have proven themselves allies in the encounter will be included in the export.  This includes healing you or other proven allies, or attacking your foes.  If you do not make any allies during the encounter, all combatants will be exported.",
                                string.Empty));
                Strings.Add("helpPanel-TextFormatAlliesStats",
                            new LocalizationObject(
                                "When checked, the totals of your allies will be prefixed to the normal export.",
                                string.Empty));
                Strings.Add("helpPanel-TextFormatPlayers",
                            new LocalizationObject("Per-player formatting string. (Repeating Format)", string.Empty));
                Strings.Add("helpPanel-TextFormatPreset",
                            new LocalizationObject("Replace the current formatters with a saved preset.",
                                                   string.Empty));
                Strings.Add("helpPanel-TextFormatRemovePreset",
                            new LocalizationObject("Remove the currently selected format from the drop down list.",
                                                   string.Empty));
                Strings.Add("helpPanel-TextFormatSort",
                            new LocalizationObject("The sorting method this formatting option will use.",
                                                   string.Empty));
                Strings.Add("helpPanel-cbCullAll",
                            new LocalizationObject(
                                "When a new zone listing is created, ACT will keep the listed number of \"All\" zone-wide encounters and cull the older.",
                                string.Empty));
                Strings.Add("helpPanel-cbCullCount",
                            new LocalizationObject(
                                "When an encounter ends, normal encounters are culled to the listed number.  This applies to encounters in any current or previous zone but will not affect \"All\" zone-wide encounters.",
                                string.Empty));
                Strings.Add("helpPanel-cbCullCountIgnoreNoAlly",
                            new LocalizationObject(
                                "Encounters with no allies, marked \"Encounter\" will not add to the count when determining the number of old encounters to cull.",
                                string.Empty));
                Strings.Add("helpPanel-cbCullNoAlly",
                            new LocalizationObject(
                                "When an encounter ends, all encounters (except for the last) labeled \"Encounter\" will be removed.",
                                string.Empty));
                Strings.Add("helpPanel-cbCullOther",
                            new LocalizationObject(
                                "When a new zone listing is created, ACT will keep the normal encounters of this many previous zones.",
                                string.Empty));
                Strings.Add("helpPanel-cbCullTimer",
                            new LocalizationObject(
                                "When an encounter ends, all encounters (except for \"All\" zone-wide encounters) older than this time limit will be removed.",
                                string.Empty));
                Strings.Add("messageBox-xmlReadError",
                            new LocalizationObject(
                                "Error while parsing XML settings: Line #{0} ({1})\n{2}\n\n Attempting default setting",
                                "A non-syntax error when reading XML setting files"));
                Strings.Add("messageBox-xmlSyntaxError",
                            new LocalizationObject(
                                "The XML settings file may be corrupt or unusable.  Loading defaults where applicable.\n{0}",
                                "The XML file was not parsable"));
                Strings.Add("messageBox-importParseError",
                            new LocalizationObject(
                                "Encountered an unrecoverable error while parsing:\n{0}\nParse position: {1}\n\n{2}\n\nIgnore this error and continue?",
                                string.Empty));
                Strings.Add("messageBoxTitle-importParseError", new LocalizationObject("Parsing Failed", string.Empty));
                Strings.Add("messageBox-eq2NotFound",
                            new LocalizationObject(
                                "EverQuest2.exe was not found in this folder.  If you are using an international version, you may need to select an 'LP_REGION_??_??' folder.",
                                string.Empty));
                Strings.Add("messageBoxTitle-eq2NotFound",
                            new LocalizationObject("Could not confirm folder selection", string.Empty));
                Strings.Add("messageBox-exportNoEncounters",
                            new LocalizationObject("Please select an encounter in the treeview.", string.Empty));
                Strings.Add("messageBoxTitle-exportNoEncounters",
                            new LocalizationObject("Nothing to export", string.Empty));
                Strings.Add("messageBox-sortingColumnError",
                            new LocalizationObject("Select a column entry to sort by.", string.Empty));
                Strings.Add("messageBoxTitle-sortingColumnError",
                            new LocalizationObject("Nothing Selected", string.Empty));
                Strings.Add("messageBox-localSecurityPolicy",
                            new LocalizationObject(
                                "The application was disallowed to perform the operation due to security settings of the local machine.\nIf you are running this application from a networked computer, please copy and run it locally.\n\n",
                                string.Empty));
                Strings.Add("messageBoxTitle-localSecurityPolicy",
                            new LocalizationObject("Security Exception", string.Empty));
                Strings.Add("messageBox-noFileFound",
                            new LocalizationObject("The specified path does not exist.", string.Empty));
                Strings.Add("messageBoxTitle-noFileFound", new LocalizationObject("File Not Found", string.Empty));
                Strings.Add("messageBox-searchResults",
                            new LocalizationObject("Search returned {0} results.", string.Empty));
                Strings.Add("messageBoxTitle-searchResults", new LocalizationObject("Search Complete", string.Empty));
                Strings.Add("messageBoxTitle-xmlPrefError",
                            new LocalizationObject("XML Preferences Error", string.Empty));
                Strings.Add("messageBoxTitle-error", new LocalizationObject("Error", string.Empty));
                Strings.Add("helpPanel-cbExFile",
                            new LocalizationObject(
                                "At the end of combat, this option will export to a macro file something similar to what a clipboard export would look like.  This file export is not restricted to 256 characters like the clipboard export, however it can only output 16 lines.  Once the export is created, you can display the results by using the command:\n\n/do_file_commands act-export.txt\n\nYou can create an EQ2 macro to trigger this command.  The macro file export will attempt to tabulate the data to make viewing it easier.\n\nYou must set the below option with what channel you wish to display the export to beforehand.  Leaving the channel prefix blank will cause the macro file not to function unless the Text Only Formatting options prefix a channel to *every* line.",
                                string.Empty));
                Strings.Add("exportFormattingLabel-custom", new LocalizationObject("Custom Text", string.Empty));
                Strings.Add("exportFormattingDesc-custom",
                            new LocalizationObject("Enter your custom text into the above text box before appending.",
                                                   string.Empty));
                Strings.Add("exportFormattingLabel-newline",
                            new LocalizationObject("New Line", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-newline",
                            new LocalizationObject("Formatting after this element will appear on a new line.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-title",
                            new LocalizationObject("Encounter Title", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-title",
                            new LocalizationObject(
                                "The title of the completed encounter.  This may only be used in Allies formatting.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-name",
                            new LocalizationObject("Name", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-name",
                            new LocalizationObject("The combatant's name.", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME",
                            new LocalizationObject("Short Name", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME",
                            new LocalizationObject(
                                "The combatant's name shortened to a number of characters after a colon, like: \"NAME:5\"",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-duration",
                            new LocalizationObject("Duration", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-duration",
                            new LocalizationObject(
                                "The duration of the combatant or the duration of the encounter, displayed as mm:ss",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-DURATION",
                            new LocalizationObject("Short Duration", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-DURATION",
                            new LocalizationObject(
                                "The duration of the combatant or encounter displayed in whole seconds.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-damage",
                            new LocalizationObject("Damage", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-damage",
                            new LocalizationObject(
                                "The amount of damage from auto-attack, spells, CAs, etc done to other combatants.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-damage%",
                            new LocalizationObject("Damage %", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-damage%",
                            new LocalizationObject(
                                "This value represents the percent share of all damage done by allies in this encounter.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-dps",
                            new LocalizationObject("DPS", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-dps",
                            new LocalizationObject(
                                "The damage total of the combatant divided by their personal duration, formatted as 12.34",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-DPS",
                            new LocalizationObject("Short DPS", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-DPS",
                            new LocalizationObject(
                                "The damage total of the combatatant divided by their personal duration, formatted as 12",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-extdps",
                            new LocalizationObject("Encounter DPS", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-extdps",
                            new LocalizationObject(
                                "The damage total of the combatant divided by the duration of the encounter, formatted as 12.34 -- This is more commonly used than DPS",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-EXTDPS",
                            new LocalizationObject("Short Encounter DPS", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-EXTDPS",
                            new LocalizationObject(
                                "The damage total of the combatant divided by the duration of the encounter, formatted as 12 -- This is more commonly used than DPS",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-hits",
                            new LocalizationObject("Hits", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-hits",
                            new LocalizationObject(
                                "The number of attack attempts that produced damage.  IE a spell successfully doing damage.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-crithits",
                            new LocalizationObject("Critical Hit Count", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-crithits",
                            new LocalizationObject("The number of damaging attacks that were critical.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-misses",
                            new LocalizationObject("Misses", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-misses",
                            new LocalizationObject("The number of auto-attacks or CAs that produced a miss message.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-hitfailed",
                            new LocalizationObject("Other Avoid", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-hitfailed",
                            new LocalizationObject(
                                "Any type of failed attack that was not a miss.  This includes resists, reflects, blocks, dodging, etc.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-swings",
                            new LocalizationObject("Swings (Attacks)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-swings",
                            new LocalizationObject(
                                "The number of attack attempts.  This includes any auto-attacks or abilities, also including resisted abilities that do no damage.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-tohit",
                            new LocalizationObject("To Hit %", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-tohit",
                            new LocalizationObject("The percentage of hits to swings as 12.34",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-TOHIT",
                            new LocalizationObject("Short To Hit %", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-TOHIT",
                            new LocalizationObject("The percentage of hits to swings as 12",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-maxhit",
                            new LocalizationObject("Highest Hit", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-maxhit",
                            new LocalizationObject(
                                "The highest single damaging hit formatted as [Combatant-]SkillName-Damage#",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-MAXHIT",
                            new LocalizationObject("Short Highest Hit", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-MAXHIT",
                            new LocalizationObject("The highest single damaging hit formatted as [Combatant-]Damage#",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-healed",
                            new LocalizationObject("Healed", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-healed",
                            new LocalizationObject(
                                "The numerical total of all heals, wards or similar sourced from this combatant.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-healed%",
                            new LocalizationObject("Healed %", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-healed%",
                            new LocalizationObject(
                                "This value represents the percent share of all healing done by allies in this encounter.",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-exthps",
                            new LocalizationObject("Encounter HPS", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-exthps",
                            new LocalizationObject(
                                "The healing total of the combatant divided by the duration of the encounter, formatted as 12.34",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-EXTHPS",
                            new LocalizationObject("Short Encounter HPS", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-EXTHPS",
                            new LocalizationObject(
                                "The healing total of the combatant divided by the duration of the encounter, formatted as 12",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-critheals",
                            new LocalizationObject("Critical Heal Count", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-critheals",
                            new LocalizationObject("The number of heals that were critical.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-heals",
                            new LocalizationObject("Heal Count", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-heals",
                            new LocalizationObject("The total number of heals from this combatant.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-maxheal",
                            new LocalizationObject("Highest Heal", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-maxheal",
                            new LocalizationObject(
                                "The highest single healing amount formatted as [Combatant-]SkillName-Healing#",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-MAXHEAL",
                            new LocalizationObject("Short Highest Heal", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-MAXHEAL",
                            new LocalizationObject(
                                "The highest single healing amount formatted as [Combatant-]Healing#",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-maxhealward",
                            new LocalizationObject("Highest Heal/Ward", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-maxhealward",
                            new LocalizationObject(
                                "The highest single healing/warding amount formatted as [Combatant-]SkillName-Healing#",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-MAXHEALWARD",
                            new LocalizationObject("Short Highest Heal/Ward",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-MAXHEALWARD",
                            new LocalizationObject(
                                "The highest single healing/warding amount formatted as [Combatant-]Healing#",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-damagetaken",
                            new LocalizationObject("Damage Received", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-damagetaken",
                            new LocalizationObject("The total amount of damage this combatant received.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-healstaken",
                            new LocalizationObject("Healing Received", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-healstaken",
                            new LocalizationObject("The total amount of healing this combatant received.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-powerdrain",
                            new LocalizationObject("Power Drain", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-powerdrain",
                            new LocalizationObject("The amount of power this combatant drained from others.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-kills",
                            new LocalizationObject("Killing Blows", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-kills",
                            new LocalizationObject("The total number of times this character landed a killing blow.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-deaths",
                            new LocalizationObject("Deaths", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-deaths",
                            new LocalizationObject("The total number of times this character was killed by another.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME3",
                            new LocalizationObject("Name (3 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME3",
                            new LocalizationObject("The combatant's name, up to 3 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME4",
                            new LocalizationObject("Name (4 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME4",
                            new LocalizationObject("The combatant's name, up to 4 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME5",
                            new LocalizationObject("Name (5 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME5",
                            new LocalizationObject("The combatant's name, up to 5 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME6",
                            new LocalizationObject("Name (6 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME6",
                            new LocalizationObject("The combatant's name, up to 6 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME7",
                            new LocalizationObject("Name (7 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME7",
                            new LocalizationObject("The combatant's name, up to 7 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME8",
                            new LocalizationObject("Name (8 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME8",
                            new LocalizationObject("The combatant's name, up to 8 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME9",
                            new LocalizationObject("Name (9 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME9",
                            new LocalizationObject("The combatant's name, up to 9 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME10",
                            new LocalizationObject("Name (10 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME10",
                            new LocalizationObject("The combatant's name, up to 10 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME11",
                            new LocalizationObject("Name (11 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME11",
                            new LocalizationObject("The combatant's name, up to 11 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME12",
                            new LocalizationObject("Name (12 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME12",
                            new LocalizationObject("The combatant's name, up to 12 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME13",
                            new LocalizationObject("Name (13 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME13",
                            new LocalizationObject("The combatant's name, up to 13 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME14",
                            new LocalizationObject("Name (14 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME14",
                            new LocalizationObject("The combatant's name, up to 14 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-NAME15",
                            new LocalizationObject("Name (15 chars)", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-NAME15",
                            new LocalizationObject("The combatant's name, up to 15 characters will be displayed.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-powerheal",
                            new LocalizationObject("Power Replenish", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-powerheal",
                            new LocalizationObject("The amount of power this combatant replenished to others.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-crithit%",
                            new LocalizationObject("Critical Hit Percentage",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-crithit%",
                            new LocalizationObject("The percentage of damaging attacks that were critical.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-critheal%",
                            new LocalizationObject("Critical Heal Percentage",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-critheal%",
                            new LocalizationObject("The percentage of heals that were critical.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-threatstr",
                            new LocalizationObject("Threat Increase/Decrease",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-threatstr",
                            new LocalizationObject("The amount of direct threat output that was increased/decreased.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-threatdelta",
                            new LocalizationObject("Threat Delta", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-threatdelta",
                            new LocalizationObject("The amount of direct threat output relative to zero.",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-tab",
                            new LocalizationObject("Tab Character", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-tab",
                            new LocalizationObject(
                                "Formatting after this element will appear in a relative column arrangement.  (The formatting example cannot display this properly)",
                                "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingLabel-cures",
                            new LocalizationObject("Cure or Dispel Count", "DEPRECATED: Only old plugins use this."));
                Strings.Add("exportFormattingDesc-cures",
                            new LocalizationObject("The total number of times the combatant cured or dispelled",
                                                   "DEPRECATED: Only old plugins use this."));
                Strings.Add("helpPanel-cbMiniColumnAlign",
                            new LocalizationObject(
                                "When enabled, the text export will be aligned into a table where each cell is padded to the length of the longest entry in that column.  The alignment is dependant on the font selected.  It is recommended you use a text formatter such as {NAME10} instead of {name} or that column may have excessive padding.",
                                string.Empty));
                Strings.Add("helpPanel-cbExFileColumnAlign",
                            new LocalizationObject(
                                "When enabled, the text export will be aligned into a table where each cell is padded to the length of the longest entry in that column.  It is recommended you use a text formatter such as {NAME10} instead of {name} or that column may have excessive padding.",
                                string.Empty));
                Strings.Add("helpPanel-lblExFileLines",
                            new LocalizationObject(
                                "ACT will only create macro files with up to this many commands.  NOTE: EQ2 has server side filtering to prevent spam in public channels.  No matter what, you cannot exceed 16 chat commands in a public channel within a short amount of time.",
                                string.Empty));
                Strings.Add("attackTypeTerm-all",
                            new LocalizationObject(
                                "All",
                                "The localized term for an AttackType object that contains swings merged from other AttackTypes"));
                Strings.Add("mergedEncounterTerm-all",
                            new LocalizationObject(
                                "All",
                                "The localized term for the merged All encounter at the top of zone breakdowns"));
                Strings.Add("specialAttackTerm-none",
                            new LocalizationObject(
                                "None", "What appears in the Special column of an attack when the attack is normal"));
                Strings.Add("helpPanel-xmlShare",
                            new LocalizationObject(
                                "This section is designed for importing small snippets of settings such as Custom Triggers or Spell Timers.  Typically these snippets will be parsed from game chat but may also be copied from elsewhere and pasted.\n\nWhen an XML snippet is detected in chat, by default the character name and type of data will appear in the third(yellow) ListBox.  You may then click on the data to review it in the TextBox to the right and either import or delete the entry.\n\nIf you wish to always import data from a particular character, you may enter their name into the TextBox above the yellow ListBox and click the above Add button.  Similarly there is a list of characters to always ignore data from.  You may temporarily disable an accept/reject entry by unchecking it or you may simply use the Remove button on either list.\n\nYou may possibly come across an XML snippet from another source made for this feature.  Instead of having someone send it to you in a tell, you may paste it directly into the larger TextBox above the Import/Delete buttons.  It will then appear as a custom entry allowing you to Import or Delete it.\n\nYou may create a snippet from your own data by going into either the Spell Timers options page or Custom Triggers tab, right-clicking the entry in the list and selecting Copy as Sharable XML.  If sending in EQ2 chat, the XML snippet must be by itself with no other chat or spaces.",
                                string.Empty));
                Strings.Add("helpPanel-xmlSubscription",
                            new LocalizationObject(
                                "This section is for keeping up to date with external ACT settings.  XML configuration files can be put on the web and upon startup or on demand, ACT can check these files for updates(based on the timestamp).  ACT can be set to automatically import or notify the user of these updates.\n\nThe top ListBox will contain the external URLs of the files already being watched.  To add an entry, enter the URL into the labeled TextBox, select an update option and click Add/Edit.  As update options, you can have ACT check but ignore updated files, notify you of updates using a message box or automatically import the external XML file upon detected updates.  The Query URL button will list the general contents of the URL, if valid, and list when it was marked changed.  The View in browser link will open the URL in your default web browser.\n\nThe Check Now button will on demand check all of the URLs for changes and check-mark the updated files.  If the URL has been updated but set to be ignored, it will be marked with a gray checkmark.  You may manually check or uncheck an entry by clicking on it.\n\nThe Update Checked button will import all entries with a normal checkmark regardless of if they were detected as changed.",
                                string.Empty));
                Strings.Add("helpPanel-ColorRestart",
                            new LocalizationObject("Changing these colors will require ACT to be restarted.",
                                                   string.Empty));
                Strings.Add("helpPanel-btnResetColors",
                            new LocalizationObject("Resetting color/font settings will require ACT to be restarted.",
                                                   string.Empty));
                Strings.Add("helpPanel-rbSParseFull",
                            new LocalizationObject(
                                "Full selective parsing should only be used in small groups where there are other groups near by.  When the encounter begins, the settings are locked to that encounter.  Using this feature may cause the ExtDPS calculations to differ from other copies of ACT or other parsers depending on the limiting options they use.  Once an encounter has taken place, you cannot add or remove combatants  to it without reparsing that battle.  Full selective parsing will create data gaps and should not be used while using ACT to analyze battles or statistics as it will not show a complete \"picture\" of the encounter.",
                                string.Empty));
                Strings.Add("helpPanel-btnImportFile",
                            new LocalizationObject(
                                "To import encounters from your logfile, select the start and ending date with the choosers and select the log file to parse.",
                                string.Empty));
                Strings.Add("helpPanel-cbGCollectOnClear",
                            new LocalizationObject(
                                "Enabling this will cause ACT to call GCCollect when clearing the encounters.  Doing this will cause the Clear Encounters button to take longer and has been known to completely freeze ACT until restart.  Only use this if you have problems with ACT never freeing memory over time.",
                                string.Empty));
                Strings.Add("helpPanel-cbAutoLoadLogs",
                            new LocalizationObject(
                                "ACT should check every few seconds for existing logs to have been updated and switch to those currently used logs.  (It will not check for new files automatically)",
                                string.Empty));
                Strings.Add("helpPanel-lblSplitFile",
                            new LocalizationObject(
                                "As long as another program has not locked the file, ACT will attempt to rename the file with a date when opening or closing a file. (When over this size)",
                                string.Empty));
                Strings.Add("helpPanel-lblExportSound",
                            new LocalizationObject(
                                "The sound for when ACT creates clipboard exports, macro exports, etc either manually or immediately after combat.",
                                string.Empty));
                Strings.Add("helpPanel-cbLcdEnabled",
                            new LocalizationObject(
                                "This will enable ACT's support for the G15 and G19 keyboards, or other devices that use those unified drivers.  For the default applets: button 1 of 4(G15) or Menu button(G19) will change ACT modes.  The next button(G15) or OK button(G19) will usually change sub-modes within that mode, such as switching export formats.",
                                string.Empty));
                Strings.Add("helpPanel-lblLcdMiniFormat",
                            new LocalizationObject(
                                "This LCD mode mimics the Mini Window in ACT.  This selector changes the export format displayed and may also be flipped through using the 2nd button of the G15 or OK button of the G19.",
                                string.Empty));
                Strings.Add("helpPanel-lblPersonalParseFormat",
                            new LocalizationObject(
                                "This LCD mode will create an export with only your personal data in it, unlike the repeating format of all other combatants.",
                                string.Empty));
                Strings.Add("helpPanel-Options_LcdMono",
                            new LocalizationObject(
                                "This section will define the look of the G15 specific applet.  Use the Font button to choose a base font to use for all screens.  To adjust the font size, use the Size Offset numeric selector for that mode.  Also adjust the vertical spacing of each line as you change the font size to meet your needs.",
                                string.Empty));
                Strings.Add("helpPanel-Options_LcdColor",
                            new LocalizationObject(
                                "This section will define the look of the G19 specific applet.  Use the Change Font buttons to change the font/size of the specific modes.  Also be aware that changing the font size may require you to change the vertical spacing to look correct.  You may also change the basic colors of those modes.  The Spell Timer and Graph modes mimic ACT's normal settings for colors.",
                                string.Empty));
                Strings.Add("helpPanel-Options_TableZone",
                            new LocalizationObject(
                                "These are the columns that will appear in the Main tab tables when clicking on TreeView nodes such as 'Import/Merge [1]' or 'ZoneName [3] 12:00:00 PM'.  This table lists all of the encounters of that node(Zone).",
                                string.Empty));
                Strings.Add("helpPanel-Options_TableEnc",
                            new LocalizationObject(
                                "These are the columns that will appear in the Main tab tables when clicking on TreeView nodes such as 'Mobname - [1:23] 12:01:02 PM'.  This table lists all of the combatants of the selected encounter.",
                                string.Empty));
                Strings.Add("helpPanel-Options_TableCombatant",
                            new LocalizationObject(
                                "These are the columns that will appear in the Main tab tables when clicking on TreeView nodes such as 'PlayerName' or 'MobName'.  This table lists all of the damage type categories of the combatant.",
                                string.Empty));
                Strings.Add("helpPanel-Options_TableDamageType",
                            new LocalizationObject(
                                "These are the columns that will appear in the Main tab tables when clicking on TreeView nodes such as 'Outgoing Damage' or 'Healed'.  This table lists all of the skill names of the selected damage type category.",
                                string.Empty));
                Strings.Add("helpPanel-Options_TableAttackType",
                            new LocalizationObject(
                                "These are the columns that will appear in the Main tab tables when clicking on TreeView nodes such as 'crush' or 'Smite'.  This table lists all of the individual combat actions of the selected skill name.",
                                string.Empty));
                Strings.Add("helpPanel-Options_MiniParse",
                            new LocalizationObject(
                                "The Mini Parse window is a small text only display of the current encounter.  It may also show a graph if you click the red button in the corner.  To change the included information, create a preset the new export format.",
                                string.Empty));
                Strings.Add("helpPanel-tbExFileName",
                            new LocalizationObject(
                                "This export file name is a relative file path to the game folder or may be an absolute path.",
                                string.Empty));
                Strings.Add("helpPanel-ccEncLabel1",
                            new LocalizationObject("The color for encounters where all enemies have been defeated.",
                                                   string.Empty));
                Strings.Add("helpPanel-ccEncLabel2",
                            new LocalizationObject("The color for encounters where the outcome was unknown.",
                                                   string.Empty));
                Strings.Add("helpPanel-ccEncLabel3",
                            new LocalizationObject("The color for encounters where all allies were defeated.",
                                                   string.Empty));
                Strings.Add("helpPanel-ccDGAllyText",
                            new LocalizationObject("The foreground color of combatant names that are marked as allies.",
                                                   string.Empty));
                Strings.Add("helpPanel-ccDGPersonalBackcolor",
                            new LocalizationObject(
                                "The background color of the main table row containing your combatant.", string.Empty));
                Strings.Add("helpPanel-Options_SelectiveParsing",
                            new LocalizationObject(
                                "The purpose of selective parsing is to restrict the data that appears.  The list at the left decides which combatants are used for data/exports.",
                                string.Empty));
                Strings.Add("helpPanel-IO_ImportClip",
                            new LocalizationObject(
                                "Press the Import Clipboard button to import the clipboard contents as though importing a log file.",
                                string.Empty));
                Strings.Add("helpPanel-IO_ExportAct",
                            new LocalizationObject(
                                "This feature will export a compressed binary file which can be later imported by ACT to recreate the encounter.  If you wish to export more than one encounter as a single file, use the Show Checkboxes feature on the Main tab.",
                                string.Empty));
                Strings.Add("helpPanel-IO_ExportHtml",
                            new LocalizationObject(
                                "This feature will export the selected encounters into a single static HTML file which is then controlled by JavaScript and CSS.",
                                string.Empty));
                Strings.Add("helpPanel-Options_Odbc",
                            new LocalizationObject(
                                "This section is for exporting ACT data into SQL datasources.  ACT uses ODBC connectivity in order to connect to these datasources and the local machine must have an ODBC driver installed to communicate to the desired type of datasource.",
                                string.Empty));
                Strings.Add("helpPanel-IO_XmlFile",
                            new LocalizationObject(
                                "This feature was added by user request.  I don't know of any practical use for it.",
                                string.Empty));
                Strings.Add("helpPanel-IO_ImportLog",
                            new LocalizationObject(
                                "Select the starting and end points before selecting the file to parse.",
                                string.Empty));
                Strings.Add("helpPanel-IO_ImportAct",
                            new LocalizationObject(
                                "This feature is specifically for importing *.act files exported by ACT.",
                                string.Empty));
                Strings.Add("helpPanel-Options_Sound",
                            new LocalizationObject(
                                "This panel will configure the different sounds ACT will generally make for different events.  Command sounds are when you interact with ACT by typing in a game, like '/act end' or '/e end'.  Misc sounds are when ACT tries to randomly get your attention for a miscellaneous purpose.  This could be an update or even an error playing a non-existent sound.\n\nThe bottom radio buttons change through what API ACT tries to make sounds through.  Windows API is very basic for compatibility purposes.  WMP is sufficient in most cases.",
                                string.Empty));
                Strings.Add("helpPanel-cbEncSilenceCut",
                            new LocalizationObject(
                                "When enabled, an encounter's duration will be reduced when there are no hostile actions recorded for this many seconds.  This setting should be lower than the above end encounter idle timer.  This setting will not increase the duration of an enounter past its last hostile action.",
                                string.Empty));
                Strings.Add("helpPanel-tbConvertXml",
                            new LocalizationObject(
                                "You may paste a portion of ACT's configuration file in this textbox and convert it into a snippet.  Someone copying this snippet and clicking the [Import XML] button in the corner will import the contained config settings.",
                                string.Empty));
            }
        }
    }
}
