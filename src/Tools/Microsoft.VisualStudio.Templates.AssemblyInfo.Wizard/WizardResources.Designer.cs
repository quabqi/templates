﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Templates.AssemblyInfo.Wizard {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WizardResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WizardResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.Templates.AssemblyInfo.Wizard.WizardResources", typeof(WizardResources).Assembly);
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
        ///   Looks up a localized string similar to Setting ComVisible to false makes the types in this assembly not visible to COM components.  If you need to access a type in this assembly from COM, set the ComVisible attribute to true on that type..
        /// </summary>
        internal static string ComVisibleInfo {
            get {
                return ResourceManager.GetString("ComVisibleInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In SDK-style projects such as this one, several assembly attributes that were historically defined in this file are now automatically added during build and populated with values defined in project properties. For details of which attributes are included and how to customise this process see: https://aka.ms/assembly-info-properties.
        /// </summary>
        internal static string GenerationInfo {
            get {
                return ResourceManager.GetString("GenerationInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following GUID is for the ID of the typelib if this project is exposed to COM..
        /// </summary>
        internal static string GuidInfo {
            get {
                return ResourceManager.GetString("GuidInfo", resourceCulture);
            }
        }
    }
}
