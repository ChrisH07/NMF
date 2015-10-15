//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    public class NamespaceTypesCollection : ObservableOppositeList<INamespace, IType>
    {
        
        public NamespaceTypesCollection(INamespace parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((IType)(sender)));
        }
        
        protected override void SetOpposite(IType item, INamespace parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.Namespace = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.Namespace == this.Parent))
                {
                    item.Namespace = parent;
                }
            }
        }
    }
}

