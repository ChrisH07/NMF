//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34209
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

namespace NMF.Interop.Ecore
{
    
    
    [XmlNamespaceAttribute("http://www.eclipse.org/emf/2002/Ecore")]
    [XmlNamespacePrefixAttribute("ecore")]
    [ModelRepresentationClassAttribute("http://www.eclipse.org/emf/2002/Ecore#//EParameter/")]
    [DebuggerDisplayAttribute("EParameter {Name}")]
    public class EParameter : ETypedElement, IEParameter, IModelElement
    {
        
        /// <summary>
        /// The eOperation property
        /// </summary>
        [XmlElementNameAttribute("eOperation")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        public virtual IEOperation EOperation
        {
            get
            {
                return ModelHelper.CastAs<IEOperation>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EParameterReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets fired when the EOperation property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> EOperationChanged;
        
        /// <summary>
        /// Raises the EOperationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEOperationChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.EOperationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IEOperation oldEOperation = ModelHelper.CastAs<IEOperation>(oldParent);
            IEOperation newEOperation = ModelHelper.CastAs<IEOperation>(newParent);
            if ((oldEOperation != null))
            {
                oldEOperation.EParameters.Remove(this);
            }
            if ((newEOperation != null))
            {
                newEOperation.EParameters.Add(this);
            }
            this.OnPropertyChanged("EOperation");
            this.OnEOperationChanged(new ValueChangedEventArgs(oldEOperation, newEOperation));
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of the current model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://www.eclipse.org/emf/2002/Ecore#//EParameter/");
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EParameter class
        /// </summary>
        public class EParameterReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EParameter _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EParameterReferencedElementsCollection(EParameter parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.EOperation != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EOperationChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EOperationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.EOperation == null))
                {
                    IEOperation eOperationCasted = item.As<IEOperation>();
                    if ((eOperationCasted != null))
                    {
                        this._parent.EOperation = eOperationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EOperation = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.EOperation))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.EOperation != null))
                {
                    array[arrayIndex] = this._parent.EOperation;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.EOperation == item))
                {
                    this._parent.EOperation = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EOperation).GetEnumerator();
            }
        }
    }
}

