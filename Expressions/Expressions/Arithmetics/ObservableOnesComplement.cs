﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMF.Expressions.Arithmetics
{

    internal sealed class ObservableIntOnesComplement : ObservableUnaryExpressionBase<int, int>
    {
        public ObservableIntOnesComplement(INotifyExpression<int> inner)
            : base(inner) { }

        protected override int GetValue()
        {
            return ~Target.Value;
        }

        public override INotifyExpression<int> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableIntOnesComplement(Target.ApplyParameters(parameters));
        }
    }

    internal sealed class ObservableUIntOnesComplement : ObservableUnaryExpressionBase<uint, uint>
    {
        public ObservableUIntOnesComplement(INotifyExpression<uint> inner)
            : base(inner) { }

        protected override uint GetValue()
        {
            return ~Target.Value;
        }

        public override INotifyExpression<uint> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableUIntOnesComplement(Target.ApplyParameters(parameters));
        }
    }

    internal sealed class ObservableLongOnesComplement : ObservableUnaryExpressionBase<long, long>
    {
        public ObservableLongOnesComplement(INotifyExpression<long> inner)
            : base(inner) { }

        protected override long GetValue()
        {
            return ~Target.Value;
        }

        public override INotifyExpression<long> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableLongOnesComplement(Target.ApplyParameters(parameters));
        }
    }

    internal sealed class ObservableULongOnesComplement : ObservableUnaryExpressionBase<ulong, ulong>
    {
        public ObservableULongOnesComplement(INotifyExpression<ulong> inner)
            : base(inner) { }

        protected override ulong GetValue()
        {
            return ~Target.Value;
        }

        public override INotifyExpression<ulong> ApplyParameters(IDictionary<string, object> parameters)
        {
            return new ObservableULongOnesComplement(Target.ApplyParameters(parameters));
        }
    }
}
