﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CyberSniff.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CyberSniff.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred whilst getting your adapters, please refer to the error log..
        /// </summary>
        public static string ADAPTER_EXCEPTION {
            get {
                return ResourceManager.GetString("ADAPTER_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something is wrong with the CyberSniff client. Please report this to a developer and wait for an update.
        /// </summary>
        public static string API_CLIENT_AUTHENTICATE_EXCEPTION {
            get {
                return ResourceManager.GetString("API_CLIENT_AUTHENTICATE_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t verify the authenticity of the CyberSniff API response. Therefore we cannot authenticate you. This could be the result of having a HTTP web debugger open, like Fiddler that may tamper with the certificate. Close any web debuggers and try again..
        /// </summary>
        public static string API_FORGED_REQUEST {
            get {
                return ResourceManager.GetString("API_FORGED_REQUEST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We were unable to reach the CyberSniff servers for communication. Please check your internet connection or try again later..
        /// </summary>
        public static string API_OFFLINE {
            get {
                return ResourceManager.GetString("API_OFFLINE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CyberSniff-OSS/3.2.
        /// </summary>
        public static string API_USER_AGENT {
            get {
                return ResourceManager.GetString("API_USER_AGENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RELEASE OSS.
        /// </summary>
        public static string APP_STAGE {
            get {
                return ResourceManager.GetString("APP_STAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The authentication thread has exited unexpectedly. This could be due to antivirus software or due to software tampering tools being active. Please restart CyberSniff..
        /// </summary>
        public static string AUTH_THREAD_EXITED {
            get {
                return ResourceManager.GetString("AUTH_THREAD_EXITED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t load your background, it may have been moved, renamed or deleted..
        /// </summary>
        public static string BACKGROUND_LOAD_EXCEPTION {
            get {
                return ResourceManager.GetString("BACKGROUND_LOAD_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are currently capturing traffic, are you sure you want to exit CyberSniff?.
        /// </summary>
        public static string CAPTURE_ACTIVE_EXIT {
            get {
                return ResourceManager.GetString("CAPTURE_ACTIVE_EXIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry for the inconvenience, but CyberSniff has crashed (failed to start capture). Please contact support, or try again later. More error information can be found in the &apos;cybersniff.log&apos; file, in &apos;%appdata%\CyberSniff&apos;..
        /// </summary>
        public static string CAPTURE_EXCEPTION {
            get {
                return ResourceManager.GetString("CAPTURE_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to copy to clipboard, please make sure you select a item on the list to copy..
        /// </summary>
        public static string COPY_EXCEPTION {
            get {
                return ResourceManager.GetString("COPY_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to encrypt / decrypt data. This may be a sign of memory corruption. Restart CyberSniff and try again..
        /// </summary>
        public static string CRYPTO_EXCEPTION {
            get {
                return ResourceManager.GetString("CRYPTO_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong, it has been written to the log file..
        /// </summary>
        public static string EXCEPTION_BASIC {
            get {
                return ResourceManager.GetString("EXCEPTION_BASIC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry for the inconvenience, but CyberSniff has crashed. The error can be viewed below. It has been dumped to a log file which can be found in &apos;%appdata%\CSniffOSS\cybersniff.log&apos;. Use this file to report this problem to developers..
        /// </summary>
        public static string GENERIC_EXCEPTION {
            get {
                return ResourceManager.GetString("GENERIC_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You selected an invalid file. Please select a valid file instead..
        /// </summary>
        public static string INVALID_FILE_SELECTED {
            get {
                return ResourceManager.GetString("INVALID_FILE_SELECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to write log file changes to the disk, please make sure another program is not using the log file, that CyberSniff has permission to access the file or check your antivirus software..
        /// </summary>
        public static string LOG_WRITE_EXCEPTION {
            get {
                return ResourceManager.GetString("LOG_WRITE_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to logout of CyberSniff? All settings and account data will be removed from your PC..
        /// </summary>
        public static string LOGOUT_CONFIRM {
            get {
                return ResourceManager.GetString("LOGOUT_CONFIRM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We couldn&apos;t find Npcap or WinPcap installed on your device which is required to use CyberSniff. Please download and install it from https://nmap.org/npcap.
        /// </summary>
        public static string PCAP_DRIVER_EXCEPTION {
            get {
                return ResourceManager.GetString("PCAP_DRIVER_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read your settings, this may mean your settings is corrupted or unsupported. As a result, your settings have been reset. .
        /// </summary>
        public static string SETTINGS_READ_EXCEPTION {
            get {
                return ResourceManager.GetString("SETTINGS_READ_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to save your settings, the settings file may be in use by another process or CyberSniff might not have access to the settings file..
        /// </summary>
        public static string SETTINGS_WRITE_EXCEPTION {
            get {
                return ResourceManager.GetString("SETTINGS_WRITE_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You specified a invalid color, therefore CyberSniff cannot apply it..
        /// </summary>
        public static string THEME_APPLY_EXCEPTION {
            get {
                return ResourceManager.GetString("THEME_APPLY_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CyberSniff-OSS was developed by CyberVision Interactive, this build is OSS on GitHub! https://github.com/CyberSniffDeveloper/desktop-client. Credits:
        ///      
        ///If you paid for this software after 02/07/2022, you have been scammed and you should demand your money back!   
        ///    .
        /// </summary>
        public static string UI_ABOUT_BOX {
            get {
                return ResourceManager.GetString("UI_ABOUT_BOX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully cleared all results..
        /// </summary>
        public static string UI_CLEAR_SUCCESS {
            get {
                return ResourceManager.GetString("UI_CLEAR_SUCCESS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully copied to clipboard..
        /// </summary>
        public static string UI_COPY_SUCCESS {
            get {
                return ResourceManager.GetString("UI_COPY_SUCCESS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is a CyberSniff update available, please update to that version before continuing.
        /// </summary>
        public static string UPDATE_AVAILABLE {
            get {
                return ResourceManager.GetString("UPDATE_AVAILABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry for the inconvenience, but an exception has occurred whilst contacting the CyberSniff update server. This could be a issue with the server itself. Make sure you are connected to the internet, or try again later..
        /// </summary>
        public static string UPDATE_EXCEPTION {
            get {
                return ResourceManager.GetString("UPDATE_EXCEPTION", resourceCulture);
            }
        }
    }
}
