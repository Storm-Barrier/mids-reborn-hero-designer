﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hero_Designer.Forms.OptionsMenuItems {
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
    internal class frmCalcOpt {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal frmCalcOpt() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hero_Designer.Forms.OptionsMenuItems.frmCalcOpt", typeof(frmCalcOpt).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=102,Y=17}.
        /// </summary>
        internal static System.Drawing.Point cPicker_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("cPicker.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=192,Y=17}.
        /// </summary>
        internal static System.Drawing.Point fbdSave_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("fbdSave.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Swap = two powers are swapped. The powers in between are unaffected by the transition.
        ///Move = one power is moved to the position of another. The power being replaced, as well as all powers in between, are shifted in the direction of the power being moved.
        ///Shift = cascading swaps. Shifting down means powers are moved to a lower level, starting with the lowest. Shifting up means powers are moved to a higher level, starting with the highest..
        /// </summary>
        internal static string Label15_Text {
            get {
                return ResourceManager.GetString("Label15.Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When exemplared below level 32, the game scales your enhancements down. If you want to see the approximate values for your character when exemplared, enter a starting level and exemplar level (Remember that if your build&apos;s level is different to the starting level set here, the numbers will be wrong!).
        /// </summary>
        internal static string Label5_Text {
            get {
                return ResourceManager.GetString("Label5.Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some attacks have a chance to deal additional damage (such as fire). Because this damage isn&apos;t always going to happen, the attack&apos;s damage can be calculated either as an average, at maximum possible (as though the extra damage always happens), or at minimum (as though it never happens).
        ///Note that this also affects how Scrapper damage is displayed when Critical Hit is toggled on.
        ///Where an attack has a chance to do additional damage:.
        /// </summary>
        internal static string Label9_Text {
            get {
                return ResourceManager.GetString("Label9.Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Point similar to {X=17,Y=17}.
        /// </summary>
        internal static System.Drawing.Point myTip_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("myTip.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap optDO_Image {
            get {
                object obj = ResourceManager.GetObject("optDO.Image", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap optSO_Image {
            get {
                object obj = ResourceManager.GetObject("optSO.Image", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap optTO_Image {
            get {
                object obj = ResourceManager.GetObject("optTO.Image", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon reborn_wicon {
            get {
                object obj = ResourceManager.GetObject("reborn_wicon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set this to the level of your character. This setting will not reduce the number of slots/powers placed to match the level. Powers available after the level set ehre will still be calculated unless you disable them..
        /// </summary>
        internal static string udExHigh_ToolTip {
            get {
                return ResourceManager.GetString("udExHigh.ToolTip", resourceCulture);
            }
        }
    }
}