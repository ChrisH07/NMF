﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml;
using System.Reflection;
using System.Collections;

namespace NMF.Serialization
{

    public abstract class XmlPropertySerializationInfo : IPropertySerializationInfo
    {
        public TypeConverter Converter
        {
            get;
            set;
        }

        public bool ShallCreateInstance
        {
            get;
            set;
        }

        public string ElementName
        {
            get;
            set;
        }

        public string Namespace
        {
            get;
            set;
        }

        public string NamespacePrefix
        {
            get;
            set;
        }

        public abstract void SetDefaultValue(object obj);

        public abstract object GetValue(object obj, XmlSerializationContext context);

        public abstract void SetValue(object obj, object value, XmlSerializationContext context);

        public abstract bool ShouldSerializeValue(object obj, object value);

        public bool IsIdentifier
        {
            get;
            set;
        }

        public XmlIdentificationMode IdentificationMode
        {
            get;
            set;
        }

        public bool IsStringConvertible
        {
            get
            {
                if (Converter != null)
                {
                    return Converter.CanConvertFrom(typeof(string)) && Converter.CanConvertTo(typeof(string));
                }
                else
                {
                    return PropertyType.IsStringConvertible;
                }
            }
        }

        public object ConvertFromString(string text)
        {
            if (Converter != null)
            {
                return Converter.ConvertFromInvariantString(text);
            }
            else
            {
                return PropertyType.ConvertFromString(text);
            }
        }

        public string ConvertToString(object input)
        {
            if (Converter != null)
            {
                return Converter.ConvertToInvariantString(input);
            }
            else
            {
                return PropertyType.ConvertToString(input);
            }
        }

        public abstract bool IsReadOnly { get; }


        public ITypeSerializationInfo PropertyType
        {
            get;
            set;
        }
    }

    public class XmlPropertySerializationInfo<TComponent, TProperty> : XmlPropertySerializationInfo
    {
        private Func<TComponent, TProperty> getter;
        private Action<TComponent, TProperty> setter;
        private TProperty defaultValue = default(TProperty);

        public XmlPropertySerializationInfo(PropertyInfo property)
        {
            getter = (Func<TComponent, TProperty>)Delegate.CreateDelegate(typeof(Func<TComponent, TProperty>), property.GetGetMethod());
            var setMethod = property.GetSetMethod(false);
            if (setMethod != null)
            {
                setter = (Action<TComponent, TProperty>)Delegate.CreateDelegate(typeof(Action<TComponent, TProperty>), setMethod);
            }
        }

        public override object GetValue(object obj, XmlSerializationContext context)
        {
            return getter((TComponent)obj);
        }

        public override void SetValue(object obj, object value, XmlSerializationContext context)
        {
            try
            {
                setter((TComponent)obj, (TProperty)value);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(string.Format("The property {0} can not be written to.", ElementName), e);
            }
        }

        public override bool ShouldSerializeValue(object obj, object value)
        {
            if (!PropertyType.IsCollection)
            {
                return !EqualityComparer<TProperty>.Default.Equals((TProperty)value, defaultValue);
            }
            else
            {
                var collection = value as IEnumerable;
                if (collection == null) return false;
                var enumerator = collection.GetEnumerator();
                var result = enumerator != null && enumerator.MoveNext();
                enumerator.Reset();
                return result;
            }
        }

        public override bool IsReadOnly
        {
            get { return setter == null; }
        }

        public override void SetDefaultValue(object obj)
        {
            try
            {
                defaultValue = (TProperty)obj;
            }
            catch (Exception)
            {
            }
        }
    }

}
