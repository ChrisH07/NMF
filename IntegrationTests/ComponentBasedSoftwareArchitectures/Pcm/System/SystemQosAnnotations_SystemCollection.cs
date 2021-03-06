//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Qosannotations;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Pcm.System
{
    
    
    public class SystemQosAnnotations_SystemCollection : ObservableOppositeList<ISystem0, IQoSAnnotations>
    {
        
        public SystemQosAnnotations_SystemCollection(ISystem0 parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((IQoSAnnotations)(sender)));
            }
        }
        
        protected override void SetOpposite(IQoSAnnotations item, ISystem0 parent)
        {
            if ((parent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.System_QoSAnnotations = parent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.System_QoSAnnotations == this.Parent))
                {
                    item.System_QoSAnnotations = parent;
                }
            }
        }
    }
}

