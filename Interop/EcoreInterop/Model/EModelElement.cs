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
    [ModelRepresentationClassAttribute("http://www.eclipse.org/emf/2002/Ecore#//EModelElement/")]
    public abstract class EModelElement : ModelElement, IEModelElement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EAnnotations property
        /// </summary>
        private EModelElementEAnnotationsCollection _eAnnotations;
        
        public EModelElement()
        {
            this._eAnnotations = new EModelElementEAnnotationsCollection(this);
        }
        
        /// <summary>
        /// The eAnnotations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eAnnotations")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public virtual IListExpression<IEAnnotation> EAnnotations
        {
            get
            {
                return this._eAnnotations;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EModelElementChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EModelElementReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int eAnnotationsIndex = ModelHelper.IndexOfReference(this.EAnnotations, element);
            if ((eAnnotationsIndex != -1))
            {
                return ModelHelper.CreatePath("eAnnotations", eAnnotationsIndex);
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
            if ((reference == "EANNOTATIONS"))
            {
                if ((index < this.EAnnotations.Count))
                {
                    return this.EAnnotations[index];
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
            return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://www.eclipse.org/emf/2002/Ecore#//EModelElement/");
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EModelElement class
        /// </summary>
        public class EModelElementChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EModelElement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EModelElementChildrenCollection(EModelElement parent)
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
                    count = (count + this._parent.EAnnotations.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EAnnotations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EAnnotations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEAnnotation eAnnotationsCasted = item.As<IEAnnotation>();
                if ((eAnnotationsCasted != null))
                {
                    this._parent.EAnnotations.Add(eAnnotationsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EAnnotations.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EAnnotations.Contains(item))
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
                IEnumerator<IModelElement> eAnnotationsEnumerator = this._parent.EAnnotations.GetEnumerator();
                try
                {
                    for (
                    ; eAnnotationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eAnnotationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eAnnotationsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEAnnotation eAnnotationItem = item.As<IEAnnotation>();
                if (((eAnnotationItem != null) 
                            && this._parent.EAnnotations.Remove(eAnnotationItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EAnnotations).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EModelElement class
        /// </summary>
        public class EModelElementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EModelElement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EModelElementReferencedElementsCollection(EModelElement parent)
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
                    count = (count + this._parent.EAnnotations.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EAnnotations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EAnnotations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEAnnotation eAnnotationsCasted = item.As<IEAnnotation>();
                if ((eAnnotationsCasted != null))
                {
                    this._parent.EAnnotations.Add(eAnnotationsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EAnnotations.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EAnnotations.Contains(item))
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
                IEnumerator<IModelElement> eAnnotationsEnumerator = this._parent.EAnnotations.GetEnumerator();
                try
                {
                    for (
                    ; eAnnotationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eAnnotationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eAnnotationsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEAnnotation eAnnotationItem = item.As<IEAnnotation>();
                if (((eAnnotationItem != null) 
                            && this._parent.EAnnotations.Remove(eAnnotationItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EAnnotations).GetEnumerator();
            }
        }
    }
}

