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
    
    
    /// <summary>
    /// The public interface for Parameter
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//Parameter/")]
    [XmlDefaultImplementationTypeAttribute(typeof(Parameter))]
    [DefaultImplementationTypeAttribute(typeof(Parameter))]
    public interface IParameter : IModelElement, ITypedElement
    {
        
        /// <summary>
        /// The Direction property
        /// </summary>
        Direction Direction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Operation property
        /// </summary>
        IOperation Operation
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Direction property changed its value
        /// </summary>
        event EventHandler DirectionChanged;
        
        /// <summary>
        /// Gets fired when the Operation property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OperationChanged;
    }
}

