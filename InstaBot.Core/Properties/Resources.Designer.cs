﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstaBot.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InstaBot.Core.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to /html/body/div[3]/div/button.
        /// </summary>
        internal static string ClosePostPageButtonXPath {
            get {
                return ResourceManager.GetString("ClosePostPageButtonXPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FPmhX.
        /// </summary>
        internal static string FollowersCssClass {
            get {
                return ResourceManager.GetString("FollowersCssClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /html/body/div[3]/div/div[2]/div/article/div[2]/section[1]/span[1]/button.
        /// </summary>
        internal static string LikeButtonXPath {
            get {
                return ResourceManager.GetString("LikeButtonXPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /html/body/div[3]/div/div[2]/div/article/div[2]/section[1]/span[1]/button/span.
        /// </summary>
        internal static string LikeButtonXPathSpan {
            get {
                return ResourceManager.GetString("LikeButtonXPathSpan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /html/body/div[3]/div/div[2]/div/article/div[2]/section[2]/div/button/span.
        /// </summary>
        internal static string PostLikesCountXPath {
            get {
                return ResourceManager.GetString("PostLikesCountXPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to eLAPa.
        /// </summary>
        internal static string PostsCssClass {
            get {
                return ResourceManager.GetString("PostsCssClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to window.scrollTo(0, document.body.scrollHeight);.
        /// </summary>
        internal static string ScrollWindowScript {
            get {
                return ResourceManager.GetString("ScrollWindowScript", resourceCulture);
            }
        }
    }
}