﻿using System;
using NMF.Expressions.Linq.Orleans.Model;
using Orleans.Collections;

namespace NMF.Expressions.Linq.Orleans.Message
{
    [Serializable]
    public class ModelPropertyChangedMessage : ModelStreamMessage
    {
        public IObjectRemoteValue Value { get; private set; }
        public string PropertyName { get; private set; }
        public IObjectRemoteValue OldValue { get; set; }

        public ModelPropertyChangedMessage(IObjectRemoteValue value, IObjectRemoteValue oldValue, IObjectRemoteValue elementAffected, string propertyName)
            : base(elementAffected)
        {
            Value = value;
            OldValue = oldValue;
            PropertyName = propertyName;
        }
    }
}