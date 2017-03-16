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
    /// The default implementation of the AttributeCollectionDeletion class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/changes")]
    [XmlNamespacePrefixAttribute("changes")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/changes#//AttributeCollectionDeletion")]
    public partial class AttributeCollectionDeletion : CollectionDeletion, IAttributeCollectionDeletion, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the DeletedValue property
        /// </summary>
        private string _deletedValue;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The deletedValue property
        /// </summary>
        [XmlElementNameAttribute("deletedValue")]
        [XmlAttributeAttribute(true)]
        public virtual string DeletedValue
        {
            get
            {
                return this._deletedValue;
            }
            set
            {
                if ((this._deletedValue != value))
                {
                    string old = this._deletedValue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnDeletedValueChanging(e);
                    this.OnPropertyChanging("DeletedValue", e);
                    this._deletedValue = value;
                    this.OnDeletedValueChanged(e);
                    this.OnPropertyChanged("DeletedValue", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AttributeCollectionDeletion")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the DeletedValue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeletedValueChanging;
        
        /// <summary>
        /// Gets fired when the DeletedValue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeletedValueChanged;
        
        /// <summary>
        /// Raises the DeletedValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeletedValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeletedValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the DeletedValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeletedValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeletedValueChanged;
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
            if ((attribute == "DELETEDVALUE"))
            {
                return this.DeletedValue;
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
            if ((feature == "DELETEDVALUE"))
            {
                this.DeletedValue = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AttributeCollectionDeletion")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the deletedValue property
        /// </summary>
        private sealed class DeletedValueProxy : ModelPropertyChange<IAttributeCollectionDeletion, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeletedValueProxy(IAttributeCollectionDeletion modelElement) : 
                    base(modelElement, "deletedValue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.DeletedValue;
                }
                set
                {
                    this.ModelElement.DeletedValue = value;
                }
            }
        }
    }
}

