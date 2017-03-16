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
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Changes
{
    
    
    /// <summary>
    /// The public interface for ElementaryChange
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ElementaryChange))]
    [XmlDefaultImplementationTypeAttribute(typeof(ElementaryChange))]
    public interface IElementaryChange : NMF.Models.IModelElement, IModelChange
    {
        
        /// <summary>
        /// The affectedElement property
        /// </summary>
        NMF.Models.IModelElement AffectedElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the AffectedElement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AffectedElementChanging;
        
        /// <summary>
        /// Gets fired when the AffectedElement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AffectedElementChanged;
    }
}

