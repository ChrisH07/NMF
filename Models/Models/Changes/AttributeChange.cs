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
    /// The default implementation of the AttributeChange class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/changes")]
    [XmlNamespacePrefixAttribute("changes")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/changes#//AttributeChange")]
    public partial class AttributeChange : PropertyChange, IAttributeChange, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the OldValue property
        /// </summary>
        private string _oldValue;
        
        /// <summary>
        /// The backing field for the NewValue property
        /// </summary>
        private string _newValue;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The oldValue property
        /// </summary>
        [XmlElementNameAttribute("oldValue")]
        [XmlAttributeAttribute(true)]
        public virtual string OldValue
        {
            get
            {
                return this._oldValue;
            }
            set
            {
                if ((this._oldValue != value))
                {
                    string old = this._oldValue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOldValueChanging(e);
                    this.OnPropertyChanging("OldValue", e);
                    this._oldValue = value;
                    this.OnOldValueChanged(e);
                    this.OnPropertyChanged("OldValue", e);
                }
            }
        }
        
        /// <summary>
        /// The newValue property
        /// </summary>
        [XmlElementNameAttribute("newValue")]
        [XmlAttributeAttribute(true)]
        public virtual string NewValue
        {
            get
            {
                return this._newValue;
            }
            set
            {
                if ((this._newValue != value))
                {
                    string old = this._newValue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNewValueChanging(e);
                    this.OnPropertyChanging("NewValue", e);
                    this._newValue = value;
                    this.OnNewValueChanged(e);
                    this.OnPropertyChanged("NewValue", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AttributeChange")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OldValue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OldValueChanging;
        
        /// <summary>
        /// Gets fired when the OldValue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OldValueChanged;
        
        /// <summary>
        /// Gets fired before the NewValue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NewValueChanging;
        
        /// <summary>
        /// Gets fired when the NewValue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NewValueChanged;
        
        /// <summary>
        /// Raises the OldValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOldValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OldValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OldValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOldValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OldValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NewValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNewValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NewValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NewValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNewValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NewValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "OLDVALUE"))
            {
                return this.OldValue;
            }
            if ((attribute == "NEWVALUE"))
            {
                return this.NewValue;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "OLDVALUE"))
            {
                this.OldValue = ((string)(value));
                return;
            }
            if ((feature == "NEWVALUE"))
            {
                this.NewValue = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AttributeChange")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the oldValue property
        /// </summary>
        private sealed class OldValueProxy : ModelPropertyChange<IAttributeChange, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OldValueProxy(IAttributeChange modelElement) : 
                    base(modelElement, "oldValue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.OldValue;
                }
                set
                {
                    this.ModelElement.OldValue = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the newValue property
        /// </summary>
        private sealed class NewValueProxy : ModelPropertyChange<IAttributeChange, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NewValueProxy(IAttributeChange modelElement) : 
                    base(modelElement, "newValue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.NewValue;
                }
                set
                {
                    this.ModelElement.NewValue = value;
                }
            }
        }
    }
}

