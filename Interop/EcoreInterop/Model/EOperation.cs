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
    [ModelRepresentationClassAttribute("http://www.eclipse.org/emf/2002/Ecore#//EOperation/")]
    [DebuggerDisplayAttribute("EOperation {Name}")]
    public class EOperation : ETypedElement, IEOperation, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ETypeParameters property
        /// </summary>
        private ObservableCompositionList<IETypeParameter> _eTypeParameters;
        
        /// <summary>
        /// The backing field for the EParameters property
        /// </summary>
        private EOperationEParametersCollection _eParameters;
        
        /// <summary>
        /// The backing field for the EExceptions property
        /// </summary>
        private ObservableAssociationList<IEClassifier> _eExceptions;
        
        /// <summary>
        /// The backing field for the EGenericExceptions property
        /// </summary>
        private ObservableCompositionList<IEGenericType> _eGenericExceptions;
        
        public EOperation()
        {
            this._eTypeParameters = new ObservableCompositionList<IETypeParameter>(this);
            this._eParameters = new EOperationEParametersCollection(this);
            this._eExceptions = new ObservableAssociationList<IEClassifier>();
            this._eGenericExceptions = new ObservableCompositionList<IEGenericType>(this);
        }
        
        /// <summary>
        /// The eContainingClass property
        /// </summary>
        [XmlElementNameAttribute("eContainingClass")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        public virtual IEClass EContainingClass
        {
            get
            {
                return ModelHelper.CastAs<IEClass>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The eTypeParameters property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eTypeParameters")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public virtual IListExpression<IETypeParameter> ETypeParameters
        {
            get
            {
                return this._eTypeParameters;
            }
        }
        
        /// <summary>
        /// The eParameters property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eParameters")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public virtual IListExpression<IEParameter> EParameters
        {
            get
            {
                return this._eParameters;
            }
        }
        
        /// <summary>
        /// The eExceptions property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eExceptions")]
        [XmlAttributeAttribute(true)]
        public virtual IListExpression<IEClassifier> EExceptions
        {
            get
            {
                return this._eExceptions;
            }
        }
        
        /// <summary>
        /// The eGenericExceptions property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eGenericExceptions")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public virtual IListExpression<IEGenericType> EGenericExceptions
        {
            get
            {
                return this._eGenericExceptions;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EOperationChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EOperationReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets fired when the EContainingClass property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> EContainingClassChanged;
        
        /// <summary>
        /// Raises the EContainingClassChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEContainingClassChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.EContainingClassChanged;
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
            IEClass oldEContainingClass = ModelHelper.CastAs<IEClass>(oldParent);
            IEClass newEContainingClass = ModelHelper.CastAs<IEClass>(newParent);
            if ((oldEContainingClass != null))
            {
                oldEContainingClass.EOperations.Remove(this);
            }
            if ((newEContainingClass != null))
            {
                newEContainingClass.EOperations.Add(this);
            }
            this.OnPropertyChanged("EContainingClass");
            this.OnEContainingClassChanged(new ValueChangedEventArgs(oldEContainingClass, newEContainingClass));
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int eTypeParametersIndex = ModelHelper.IndexOfReference(this.ETypeParameters, element);
            if ((eTypeParametersIndex != -1))
            {
                return ModelHelper.CreatePath("eTypeParameters", eTypeParametersIndex);
            }
            int eParametersIndex = ModelHelper.IndexOfReference(this.EParameters, element);
            if ((eParametersIndex != -1))
            {
                return ModelHelper.CreatePath("eParameters", eParametersIndex);
            }
            int eGenericExceptionsIndex = ModelHelper.IndexOfReference(this.EGenericExceptions, element);
            if ((eGenericExceptionsIndex != -1))
            {
                return ModelHelper.CreatePath("eGenericExceptions", eGenericExceptionsIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "ETYPEPARAMETERS"))
            {
                if ((index < this.ETypeParameters.Count))
                {
                    return this.ETypeParameters[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "EPARAMETERS"))
            {
                if ((index < this.EParameters.Count))
                {
                    return this.EParameters[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "EGENERICEXCEPTIONS"))
            {
                if ((index < this.EGenericExceptions.Count))
                {
                    return this.EGenericExceptions[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of the current model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://www.eclipse.org/emf/2002/Ecore#//EOperation/");
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EOperation class
        /// </summary>
        public class EOperationChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EOperation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EOperationChildrenCollection(EOperation parent)
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
                    count = (count + this._parent.ETypeParameters.Count);
                    count = (count + this._parent.EParameters.Count);
                    count = (count + this._parent.EGenericExceptions.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ETypeParameters.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EParameters.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EGenericExceptions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ETypeParameters.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EParameters.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EGenericExceptions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IETypeParameter eTypeParametersCasted = item.As<IETypeParameter>();
                if ((eTypeParametersCasted != null))
                {
                    this._parent.ETypeParameters.Add(eTypeParametersCasted);
                }
                IEParameter eParametersCasted = item.As<IEParameter>();
                if ((eParametersCasted != null))
                {
                    this._parent.EParameters.Add(eParametersCasted);
                }
                IEGenericType eGenericExceptionsCasted = item.As<IEGenericType>();
                if ((eGenericExceptionsCasted != null))
                {
                    this._parent.EGenericExceptions.Add(eGenericExceptionsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ETypeParameters.Clear();
                this._parent.EParameters.Clear();
                this._parent.EGenericExceptions.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ETypeParameters.Contains(item))
                {
                    return true;
                }
                if (this._parent.EParameters.Contains(item))
                {
                    return true;
                }
                if (this._parent.EGenericExceptions.Contains(item))
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
                IEnumerator<IModelElement> eTypeParametersEnumerator = this._parent.ETypeParameters.GetEnumerator();
                try
                {
                    for (
                    ; eTypeParametersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eTypeParametersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eTypeParametersEnumerator.Dispose();
                }
                IEnumerator<IModelElement> eParametersEnumerator = this._parent.EParameters.GetEnumerator();
                try
                {
                    for (
                    ; eParametersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eParametersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eParametersEnumerator.Dispose();
                }
                IEnumerator<IModelElement> eGenericExceptionsEnumerator = this._parent.EGenericExceptions.GetEnumerator();
                try
                {
                    for (
                    ; eGenericExceptionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eGenericExceptionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eGenericExceptionsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IETypeParameter eTypeParameterItem = item.As<IETypeParameter>();
                if (((eTypeParameterItem != null) 
                            && this._parent.ETypeParameters.Remove(eTypeParameterItem)))
                {
                    return true;
                }
                IEParameter eParameterItem = item.As<IEParameter>();
                if (((eParameterItem != null) 
                            && this._parent.EParameters.Remove(eParameterItem)))
                {
                    return true;
                }
                IEGenericType eGenericTypeItem = item.As<IEGenericType>();
                if (((eGenericTypeItem != null) 
                            && this._parent.EGenericExceptions.Remove(eGenericTypeItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ETypeParameters).Concat(this._parent.EParameters).Concat(this._parent.EGenericExceptions).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EOperation class
        /// </summary>
        public class EOperationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EOperation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EOperationReferencedElementsCollection(EOperation parent)
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
                    if ((this._parent.EContainingClass != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.ETypeParameters.Count);
                    count = (count + this._parent.EParameters.Count);
                    count = (count + this._parent.EExceptions.Count);
                    count = (count + this._parent.EGenericExceptions.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EContainingClassChanged += this.PropagateValueChanges;
                this._parent.ETypeParameters.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EParameters.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EExceptions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EGenericExceptions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EContainingClassChanged -= this.PropagateValueChanges;
                this._parent.ETypeParameters.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EParameters.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EExceptions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EGenericExceptions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.EContainingClass == null))
                {
                    IEClass eContainingClassCasted = item.As<IEClass>();
                    if ((eContainingClassCasted != null))
                    {
                        this._parent.EContainingClass = eContainingClassCasted;
                        return;
                    }
                }
                IETypeParameter eTypeParametersCasted = item.As<IETypeParameter>();
                if ((eTypeParametersCasted != null))
                {
                    this._parent.ETypeParameters.Add(eTypeParametersCasted);
                }
                IEParameter eParametersCasted = item.As<IEParameter>();
                if ((eParametersCasted != null))
                {
                    this._parent.EParameters.Add(eParametersCasted);
                }
                IEClassifier eExceptionsCasted = item.As<IEClassifier>();
                if ((eExceptionsCasted != null))
                {
                    this._parent.EExceptions.Add(eExceptionsCasted);
                }
                IEGenericType eGenericExceptionsCasted = item.As<IEGenericType>();
                if ((eGenericExceptionsCasted != null))
                {
                    this._parent.EGenericExceptions.Add(eGenericExceptionsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EContainingClass = null;
                this._parent.ETypeParameters.Clear();
                this._parent.EParameters.Clear();
                this._parent.EExceptions.Clear();
                this._parent.EGenericExceptions.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.EContainingClass))
                {
                    return true;
                }
                if (this._parent.ETypeParameters.Contains(item))
                {
                    return true;
                }
                if (this._parent.EParameters.Contains(item))
                {
                    return true;
                }
                if (this._parent.EExceptions.Contains(item))
                {
                    return true;
                }
                if (this._parent.EGenericExceptions.Contains(item))
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
                if ((this._parent.EContainingClass != null))
                {
                    array[arrayIndex] = this._parent.EContainingClass;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> eTypeParametersEnumerator = this._parent.ETypeParameters.GetEnumerator();
                try
                {
                    for (
                    ; eTypeParametersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eTypeParametersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eTypeParametersEnumerator.Dispose();
                }
                IEnumerator<IModelElement> eParametersEnumerator = this._parent.EParameters.GetEnumerator();
                try
                {
                    for (
                    ; eParametersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eParametersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eParametersEnumerator.Dispose();
                }
                IEnumerator<IModelElement> eExceptionsEnumerator = this._parent.EExceptions.GetEnumerator();
                try
                {
                    for (
                    ; eExceptionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eExceptionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eExceptionsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> eGenericExceptionsEnumerator = this._parent.EGenericExceptions.GetEnumerator();
                try
                {
                    for (
                    ; eGenericExceptionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eGenericExceptionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eGenericExceptionsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.EContainingClass == item))
                {
                    this._parent.EContainingClass = null;
                    return true;
                }
                IETypeParameter eTypeParameterItem = item.As<IETypeParameter>();
                if (((eTypeParameterItem != null) 
                            && this._parent.ETypeParameters.Remove(eTypeParameterItem)))
                {
                    return true;
                }
                IEParameter eParameterItem = item.As<IEParameter>();
                if (((eParameterItem != null) 
                            && this._parent.EParameters.Remove(eParameterItem)))
                {
                    return true;
                }
                IEClassifier eClassifierItem = item.As<IEClassifier>();
                if (((eClassifierItem != null) 
                            && this._parent.EExceptions.Remove(eClassifierItem)))
                {
                    return true;
                }
                IEGenericType eGenericTypeItem = item.As<IEGenericType>();
                if (((eGenericTypeItem != null) 
                            && this._parent.EGenericExceptions.Remove(eGenericTypeItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EContainingClass).Concat(this._parent.ETypeParameters).Concat(this._parent.EParameters).Concat(this._parent.EExceptions).Concat(this._parent.EGenericExceptions).GetEnumerator();
            }
        }
    }
}

