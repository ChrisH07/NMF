//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Units;
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

namespace NMFExamples.Probfunction
{
    
    
    /// <summary>
    /// The public interface for ContinuousSample
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ContinuousSample))]
    [XmlDefaultImplementationTypeAttribute(typeof(ContinuousSample))]
    public interface IContinuousSample : IModelElement
    {
        
        /// <summary>
        /// The value property
        /// </summary>
        Nullable<double> Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The probability property
        /// </summary>
        Nullable<double> Probability
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the Probability property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProbabilityChanging;
        
        /// <summary>
        /// Gets fired when the Probability property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProbabilityChanged;
    }
}
