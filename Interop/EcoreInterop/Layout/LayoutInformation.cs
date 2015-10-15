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

namespace NMF.Interop.Layout
{
    
    
    [XmlNamespaceAttribute("http://www.emftext.org/commons/layout")]
    [XmlNamespacePrefixAttribute("layout")]
    [ModelRepresentationClassAttribute("http://www.emftext.org/commons/layout#//LayoutInformation/")]
    public abstract class LayoutInformation : ModelElement, ILayoutInformation, IModelElement
    {
        
        /// <summary>
        /// The backing field for the StartOffset property
        /// </summary>
        private int _startOffset;
        
        /// <summary>
        /// The backing field for the HiddenTokenText property
        /// </summary>
        private string _hiddenTokenText;
        
        /// <summary>
        /// The backing field for the VisibleTokenText property
        /// </summary>
        private string _visibleTokenText;
        
        /// <summary>
        /// The backing field for the SyntaxElementID property
        /// </summary>
        private string _syntaxElementID;
        
        /// <summary>
        /// The startOffset property
        /// </summary>
        [XmlElementNameAttribute("startOffset")]
        [XmlAttributeAttribute(true)]
        public virtual int StartOffset
        {
            get
            {
                return this._startOffset;
            }
            set
            {
                if ((value != this._startOffset))
                {
                    this._startOffset = value;
                    this.OnStartOffsetChanged(EventArgs.Empty);
                    this.OnPropertyChanged("StartOffset");
                }
            }
        }
        
        /// <summary>
        /// The hiddenTokenText property
        /// </summary>
        [XmlElementNameAttribute("hiddenTokenText")]
        [XmlAttributeAttribute(true)]
        public virtual string HiddenTokenText
        {
            get
            {
                return this._hiddenTokenText;
            }
            set
            {
                if ((value != this._hiddenTokenText))
                {
                    this._hiddenTokenText = value;
                    this.OnHiddenTokenTextChanged(EventArgs.Empty);
                    this.OnPropertyChanged("HiddenTokenText");
                }
            }
        }
        
        /// <summary>
        /// The visibleTokenText property
        /// </summary>
        [XmlElementNameAttribute("visibleTokenText")]
        [XmlAttributeAttribute(true)]
        public virtual string VisibleTokenText
        {
            get
            {
                return this._visibleTokenText;
            }
            set
            {
                if ((value != this._visibleTokenText))
                {
                    this._visibleTokenText = value;
                    this.OnVisibleTokenTextChanged(EventArgs.Empty);
                    this.OnPropertyChanged("VisibleTokenText");
                }
            }
        }
        
        /// <summary>
        /// The syntaxElementID property
        /// </summary>
        [XmlElementNameAttribute("syntaxElementID")]
        [XmlAttributeAttribute(true)]
        public virtual string SyntaxElementID
        {
            get
            {
                return this._syntaxElementID;
            }
            set
            {
                if ((value != this._syntaxElementID))
                {
                    this._syntaxElementID = value;
                    this.OnSyntaxElementIDChanged(EventArgs.Empty);
                    this.OnPropertyChanged("SyntaxElementID");
                }
            }
        }
        
        /// <summary>
        /// Gets fired when the StartOffset property changed its value
        /// </summary>
        public event EventHandler StartOffsetChanged;
        
        /// <summary>
        /// Gets fired when the HiddenTokenText property changed its value
        /// </summary>
        public event EventHandler HiddenTokenTextChanged;
        
        /// <summary>
        /// Gets fired when the VisibleTokenText property changed its value
        /// </summary>
        public event EventHandler VisibleTokenTextChanged;
        
        /// <summary>
        /// Gets fired when the SyntaxElementID property changed its value
        /// </summary>
        public event EventHandler SyntaxElementIDChanged;
        
        /// <summary>
        /// Raises the StartOffsetChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnStartOffsetChanged(EventArgs eventArgs)
        {
            EventHandler handler = this.StartOffsetChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the HiddenTokenTextChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnHiddenTokenTextChanged(EventArgs eventArgs)
        {
            EventHandler handler = this.HiddenTokenTextChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the VisibleTokenTextChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnVisibleTokenTextChanged(EventArgs eventArgs)
        {
            EventHandler handler = this.VisibleTokenTextChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SyntaxElementIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSyntaxElementIDChanged(EventArgs eventArgs)
        {
            EventHandler handler = this.SyntaxElementIDChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of the current model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://www.emftext.org/commons/layout#//LayoutInformation/");
        }
    }
}

