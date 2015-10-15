﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SL = System.Linq.Enumerable;
using NMF.Expressions.Linq;

namespace NMF.Expressions
{
    internal class DistinctExpression<T> : IEnumerableExpression<T>
    {
        public IEnumerableExpression<T> Source { get; private set; }
        public IEqualityComparer<T> Comparer { get; set; }

        public DistinctExpression(IEnumerableExpression<T> source, IEqualityComparer<T> comparer)
        {
            if (source == null) throw new ArgumentNullException("source");

            Source = source;
            Comparer = comparer ?? EqualityComparer<T>.Default;
        }

        public INotifyEnumerable<T> AsNotifiable()
        {
            return Source.AsNotifiable().Distinct(Comparer);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return SL.Distinct(Source, Comparer).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        INotifyEnumerable IEnumerableExpression.AsNotifiable()
        {
            return AsNotifiable();
        }
    }
}
