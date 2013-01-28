﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerShell {
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
    internal class ManagedEntranceStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ManagedEntranceStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.ManagedEntranceStrings", typeof(ManagedEntranceStrings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows PowerShell 
        ///Copyright (C) 2012 Microsoft Corporation. All rights reserved..
        /// </summary>
        internal static string ShellBanner {
            get {
                return ResourceManager.GetString("ShellBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PowerShell[.exe] [-PSConsoleFile &lt;file&gt; | -Version &lt;version&gt;]
        ///    [-NoLogo] [-NoExit] [-Sta] [-Mta] [-NoProfile] [-NonInteractive]
        ///    [-InputFormat {Text | XML}] [-OutputFormat {Text | XML}] 
        ///    [-WindowStyle &lt;style&gt;] [-EncodedCommand &lt;Base64EncodedCommand&gt;] 
        ///    [-File &lt;filePath&gt; &lt;args&gt;] [-ExecutionPolicy &lt;ExecutionPolicy&gt;]
        ///    [-Command { - | &lt;script-block&gt; [-args &lt;arg-array&gt;]
        ///                  | &lt;string&gt; [&lt;CommandParameters&gt;] } ]
        ///
        ///PowerShell[.exe] -Help | -? | /?
        ///
        ///-PSConsoleFile
        ///    Loads th [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ShellHelp {
            get {
                return ResourceManager.GetString("ShellHelp", resourceCulture);
            }
        }
    }
}