﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NMF.Expressions
{
    internal sealed class ObservableNewArray1Expression<T> : NotifyExpression<T[]>
    {
        public INotifyExpression<int> Bounds1 { get; private set; }

        public ObservableNewArray1Expression(INotifyExpression<int> bounds1)
        {
            if (bounds1 == null) throw new ArgumentNullException("bounds1");

            Bounds1 = bounds1;

            bounds1.ValueChanged += ArgumentChanged;
        }

        public override ExpressionType NodeType
        {
            get
            {
                return ExpressionType.NewArrayBounds;
            }
        }

        protected override T[] GetValue()
        {
            return (T[])Activator.CreateInstance(typeof(T[]), Bounds1.Value);
        }

        protected override void DetachCore()
        {
            Bounds1.Detach();
        }

        protected override void AttachCore()
        {
            Bounds1.Attach();
        }

        private void ArgumentChanged(object sender, ValueChangedEventArgs e)
        {
            if (!IsAttached) return;
            Refresh();
        }

        public override bool IsParameterFree
        {
            get { return Bounds1.IsParameterFree; }
        }

        public override INotifyExpression<T[]> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableNewArray1Expression<T>(Bounds1.ApplyParameters(parameters));
        }
    }
    internal sealed class ObservableNewArray3Expression<T> : NotifyExpression<T[,,]>
    {
        public INotifyExpression<int> Bounds1 { get; private set; }
        public INotifyExpression<int> Bounds2 { get; private set; }
        public INotifyExpression<int> Bounds3 { get; private set; }

        public ObservableNewArray3Expression(INotifyExpression<int> bounds1, INotifyExpression<int> bounds2, INotifyExpression<int> bounds3)
        {
            if (bounds1 == null) throw new ArgumentNullException("bounds1");
            if (bounds2 == null) throw new ArgumentNullException("bounds2");
            if (bounds3 == null) throw new ArgumentNullException("bounds3");

            Bounds1 = bounds1;
            Bounds2 = bounds2;
            Bounds3 = bounds3;

            bounds1.ValueChanged += ArgumentChanged;
            bounds2.ValueChanged += ArgumentChanged;
            bounds3.ValueChanged += ArgumentChanged;
        }

        public override ExpressionType NodeType
        {
            get
            {
                return ExpressionType.NewArrayBounds;
            }
        }

        protected override T[,,] GetValue()
        {
            return (T[,,])Activator.CreateInstance(typeof(T[,,]), Bounds1.Value, Bounds2.Value, Bounds3.Value);
        }

        protected override void DetachCore()
        {
            Bounds1.Detach();
            Bounds2.Detach();
            Bounds3.Detach();
        }

        protected override void AttachCore()
        {
            Bounds1.Attach();
            Bounds2.Attach();
            Bounds3.Attach();
        }

        private void ArgumentChanged(object sender, ValueChangedEventArgs e)
        {
            if (!IsAttached) return;
            Refresh();
        }

        public override bool IsParameterFree
        {
            get { return Bounds1.IsParameterFree && Bounds2.IsParameterFree && Bounds3.IsParameterFree; }
        }

        public override INotifyExpression<T[,,]> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableNewArray3Expression<T>(Bounds1.ApplyParameters(parameters), Bounds2.ApplyParameters(parameters), Bounds3.ApplyParameters(parameters));
        }
    }
    internal sealed class ObservableNewArray2Expression<T> : NotifyExpression<T[,]>
    {
        public INotifyExpression<int> Bounds1 { get; private set; }
        public INotifyExpression<int> Bounds2 { get; private set; }

        public ObservableNewArray2Expression(INotifyExpression<int> bounds1, INotifyExpression<int> bounds2)
        {
            if (bounds1 == null) throw new ArgumentNullException("bounds1");
            if (bounds2 == null) throw new ArgumentNullException("bounds2");

            Bounds1 = bounds1;
            Bounds2 = bounds2;

            bounds1.ValueChanged += ArgumentChanged;
            bounds2.ValueChanged += ArgumentChanged;
        }

        public override ExpressionType NodeType
        {
            get
            {
                return ExpressionType.NewArrayBounds;
            }
        }

        protected override T[,] GetValue()
        {
            return (T[,])Activator.CreateInstance(typeof(T[,]), Bounds1.Value, Bounds2.Value);
        }

        protected override void DetachCore()
        {
            Bounds1.Detach();
            Bounds2.Detach();
        }

        protected override void AttachCore()
        {
            Bounds1.Attach();
            Bounds2.Attach();
        }

        private void ArgumentChanged(object sender, ValueChangedEventArgs e)
        {
            if (!IsAttached) return;
            Refresh();
        }

        public override bool IsParameterFree
        {
            get { return Bounds1.IsParameterFree && Bounds2.IsParameterFree; }
        }

        public override INotifyExpression<T[,]> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableNewArray2Expression<T>(Bounds1.ApplyParameters(parameters), Bounds2.ApplyParameters(parameters));
        }
    }
}
