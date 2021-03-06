//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
using NMFExamples.ComponentBasedSystems.SystemIndependent;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Collections.Specialized;

namespace NMFExamples.ComponentBasedSystems.Assembly
{
    
    
    /// <summary>
    /// The default implementation of the CompositeComponent class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/Assembly/")]
    [XmlNamespacePrefixAttribute("assembly")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//Assembly/CompositeComponent")]
    [DebuggerDisplayAttribute("CompositeComponent {Name}")]
    public partial class CompositeComponent : Component_MM06, ICompositeComponent, IModelElement
    {
        
        private static Lazy<ITypedElement> _encapsulatedContextsReference = new Lazy<ITypedElement>(RetrieveEncapsulatedContextsReference);
        
        /// <summary>
        /// The backing field for the EncapsulatedContexts property
        /// </summary>
        private ObservableCompositionOrderedSet<IAssemblyContext> _encapsulatedContexts;
        
        private static Lazy<ITypedElement> _delegateConnectorsReference = new Lazy<ITypedElement>(RetrieveDelegateConnectorsReference);
        
        /// <summary>
        /// The backing field for the DelegateConnectors property
        /// </summary>
        private ObservableCompositionOrderedSet<IDelegateConnector> _delegateConnectors;
        
        private static Lazy<ITypedElement> _connectorsReference = new Lazy<ITypedElement>(RetrieveConnectorsReference);
        
        /// <summary>
        /// The backing field for the Connectors property
        /// </summary>
        private ObservableCompositionOrderedSet<IAssemblyConnector> _connectors;
        
        private static IClass _classInstance;
        
        public CompositeComponent()
        {
            this._encapsulatedContexts = new ObservableCompositionOrderedSet<IAssemblyContext>(this);
            this._encapsulatedContexts.CollectionChanging += this.EncapsulatedContextsCollectionChanging;
            this._encapsulatedContexts.CollectionChanged += this.EncapsulatedContextsCollectionChanged;
            this._delegateConnectors = new ObservableCompositionOrderedSet<IDelegateConnector>(this);
            this._delegateConnectors.CollectionChanging += this.DelegateConnectorsCollectionChanging;
            this._delegateConnectors.CollectionChanged += this.DelegateConnectorsCollectionChanged;
            this._connectors = new ObservableCompositionOrderedSet<IAssemblyConnector>(this);
            this._connectors.CollectionChanging += this.ConnectorsCollectionChanging;
            this._connectors.CollectionChanged += this.ConnectorsCollectionChanged;
        }
        
        /// <summary>
        /// The EncapsulatedContexts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAssemblyContext> EncapsulatedContexts
        {
            get
            {
                return this._encapsulatedContexts;
            }
        }
        
        /// <summary>
        /// The DelegateConnectors property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IDelegateConnector> DelegateConnectors
        {
            get
            {
                return this._delegateConnectors;
            }
        }
        
        /// <summary>
        /// The Connectors property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IAssemblyConnector> Connectors
        {
            get
            {
                return this._connectors;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CompositeComponentChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CompositeComponentReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//Assembly/CompositeComponent")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveEncapsulatedContextsReference()
        {
            return ((ITypedElement)(((ModelElement)(CompositeComponent.ClassInstance)).Resolve("EncapsulatedContexts")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EncapsulatedContexts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EncapsulatedContextsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("EncapsulatedContexts", e, _encapsulatedContextsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EncapsulatedContexts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EncapsulatedContextsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EncapsulatedContexts", e, _encapsulatedContextsReference);
        }
        
        private static ITypedElement RetrieveDelegateConnectorsReference()
        {
            return ((ITypedElement)(((ModelElement)(CompositeComponent.ClassInstance)).Resolve("DelegateConnectors")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the DelegateConnectors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DelegateConnectorsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("DelegateConnectors", e, _delegateConnectorsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the DelegateConnectors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void DelegateConnectorsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("DelegateConnectors", e, _delegateConnectorsReference);
        }
        
        private static ITypedElement RetrieveConnectorsReference()
        {
            return ((ITypedElement)(((ModelElement)(CompositeComponent.ClassInstance)).Resolve("Connectors")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Connectors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectorsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Connectors", e, _connectorsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Connectors property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectorsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Connectors", e, _connectorsReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int encapsulatedContextsIndex = ModelHelper.IndexOfReference(this.EncapsulatedContexts, element);
            if ((encapsulatedContextsIndex != -1))
            {
                return ModelHelper.CreatePath("EncapsulatedContexts", encapsulatedContextsIndex);
            }
            int delegateConnectorsIndex = ModelHelper.IndexOfReference(this.DelegateConnectors, element);
            if ((delegateConnectorsIndex != -1))
            {
                return ModelHelper.CreatePath("DelegateConnectors", delegateConnectorsIndex);
            }
            int connectorsIndex = ModelHelper.IndexOfReference(this.Connectors, element);
            if ((connectorsIndex != -1))
            {
                return ModelHelper.CreatePath("Connectors", connectorsIndex);
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
            if ((reference == "ENCAPSULATEDCONTEXTS"))
            {
                if ((index < this.EncapsulatedContexts.Count))
                {
                    return this.EncapsulatedContexts[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "DELEGATECONNECTORS"))
            {
                if ((index < this.DelegateConnectors.Count))
                {
                    return this.DelegateConnectors[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "CONNECTORS"))
            {
                if ((index < this.Connectors.Count))
                {
                    return this.Connectors[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ENCAPSULATEDCONTEXTS"))
            {
                return this._encapsulatedContexts;
            }
            if ((feature == "DELEGATECONNECTORS"))
            {
                return this._delegateConnectors;
            }
            if ((feature == "CONNECTORS"))
            {
                return this._connectors;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._encapsulatedContexts))
            {
                return "EncapsulatedContexts";
            }
            if ((container == this._delegateConnectors))
            {
                return "DelegateConnectors";
            }
            if ((container == this._connectors))
            {
                return "Connectors";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//Assembly/CompositeComponent")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CompositeComponent class
        /// </summary>
        public class CompositeComponentChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CompositeComponent _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CompositeComponentChildrenCollection(CompositeComponent parent)
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
                    count = (count + this._parent.EncapsulatedContexts.Count);
                    count = (count + this._parent.DelegateConnectors.Count);
                    count = (count + this._parent.Connectors.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EncapsulatedContexts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.DelegateConnectors.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Connectors.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EncapsulatedContexts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.DelegateConnectors.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Connectors.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAssemblyContext encapsulatedContextsCasted = item.As<IAssemblyContext>();
                if ((encapsulatedContextsCasted != null))
                {
                    this._parent.EncapsulatedContexts.Add(encapsulatedContextsCasted);
                }
                IDelegateConnector delegateConnectorsCasted = item.As<IDelegateConnector>();
                if ((delegateConnectorsCasted != null))
                {
                    this._parent.DelegateConnectors.Add(delegateConnectorsCasted);
                }
                IAssemblyConnector connectorsCasted = item.As<IAssemblyConnector>();
                if ((connectorsCasted != null))
                {
                    this._parent.Connectors.Add(connectorsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EncapsulatedContexts.Clear();
                this._parent.DelegateConnectors.Clear();
                this._parent.Connectors.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EncapsulatedContexts.Contains(item))
                {
                    return true;
                }
                if (this._parent.DelegateConnectors.Contains(item))
                {
                    return true;
                }
                if (this._parent.Connectors.Contains(item))
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
                IEnumerator<IModelElement> encapsulatedContextsEnumerator = this._parent.EncapsulatedContexts.GetEnumerator();
                try
                {
                    for (
                    ; encapsulatedContextsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = encapsulatedContextsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    encapsulatedContextsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> delegateConnectorsEnumerator = this._parent.DelegateConnectors.GetEnumerator();
                try
                {
                    for (
                    ; delegateConnectorsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = delegateConnectorsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    delegateConnectorsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> connectorsEnumerator = this._parent.Connectors.GetEnumerator();
                try
                {
                    for (
                    ; connectorsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = connectorsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    connectorsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAssemblyContext assemblyContextItem = item.As<IAssemblyContext>();
                if (((assemblyContextItem != null) 
                            && this._parent.EncapsulatedContexts.Remove(assemblyContextItem)))
                {
                    return true;
                }
                IDelegateConnector delegateConnectorItem = item.As<IDelegateConnector>();
                if (((delegateConnectorItem != null) 
                            && this._parent.DelegateConnectors.Remove(delegateConnectorItem)))
                {
                    return true;
                }
                IAssemblyConnector assemblyConnectorItem = item.As<IAssemblyConnector>();
                if (((assemblyConnectorItem != null) 
                            && this._parent.Connectors.Remove(assemblyConnectorItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EncapsulatedContexts).Concat(this._parent.DelegateConnectors).Concat(this._parent.Connectors).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CompositeComponent class
        /// </summary>
        public class CompositeComponentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CompositeComponent _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CompositeComponentReferencedElementsCollection(CompositeComponent parent)
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
                    count = (count + this._parent.EncapsulatedContexts.Count);
                    count = (count + this._parent.DelegateConnectors.Count);
                    count = (count + this._parent.Connectors.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EncapsulatedContexts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.DelegateConnectors.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Connectors.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EncapsulatedContexts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.DelegateConnectors.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Connectors.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAssemblyContext encapsulatedContextsCasted = item.As<IAssemblyContext>();
                if ((encapsulatedContextsCasted != null))
                {
                    this._parent.EncapsulatedContexts.Add(encapsulatedContextsCasted);
                }
                IDelegateConnector delegateConnectorsCasted = item.As<IDelegateConnector>();
                if ((delegateConnectorsCasted != null))
                {
                    this._parent.DelegateConnectors.Add(delegateConnectorsCasted);
                }
                IAssemblyConnector connectorsCasted = item.As<IAssemblyConnector>();
                if ((connectorsCasted != null))
                {
                    this._parent.Connectors.Add(connectorsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EncapsulatedContexts.Clear();
                this._parent.DelegateConnectors.Clear();
                this._parent.Connectors.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EncapsulatedContexts.Contains(item))
                {
                    return true;
                }
                if (this._parent.DelegateConnectors.Contains(item))
                {
                    return true;
                }
                if (this._parent.Connectors.Contains(item))
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
                IEnumerator<IModelElement> encapsulatedContextsEnumerator = this._parent.EncapsulatedContexts.GetEnumerator();
                try
                {
                    for (
                    ; encapsulatedContextsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = encapsulatedContextsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    encapsulatedContextsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> delegateConnectorsEnumerator = this._parent.DelegateConnectors.GetEnumerator();
                try
                {
                    for (
                    ; delegateConnectorsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = delegateConnectorsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    delegateConnectorsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> connectorsEnumerator = this._parent.Connectors.GetEnumerator();
                try
                {
                    for (
                    ; connectorsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = connectorsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    connectorsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAssemblyContext assemblyContextItem = item.As<IAssemblyContext>();
                if (((assemblyContextItem != null) 
                            && this._parent.EncapsulatedContexts.Remove(assemblyContextItem)))
                {
                    return true;
                }
                IDelegateConnector delegateConnectorItem = item.As<IDelegateConnector>();
                if (((delegateConnectorItem != null) 
                            && this._parent.DelegateConnectors.Remove(delegateConnectorItem)))
                {
                    return true;
                }
                IAssemblyConnector assemblyConnectorItem = item.As<IAssemblyConnector>();
                if (((assemblyConnectorItem != null) 
                            && this._parent.Connectors.Remove(assemblyConnectorItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EncapsulatedContexts).Concat(this._parent.DelegateConnectors).Concat(this._parent.Connectors).GetEnumerator();
            }
        }
    }
}

