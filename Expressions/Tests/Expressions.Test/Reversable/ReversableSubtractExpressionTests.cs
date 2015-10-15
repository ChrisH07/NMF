﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NMF.Expressions.Test.Reversable
{
    [TestClass]
    public class ReversableSubtractExpressionTests : ReversableExpressionTests
    {
        [TestMethod]
        public void ReversableSubtract_Int_CorrectResult()
        {
            var dummy = new ObservableDummy<int>();
            SetValue(() => dummy.Item - 8, 34);
            Assert.AreEqual(42, dummy.Item);
        }

        [TestMethod]
        public void ReversableSubtract_UInt_CorrectResult()
        {
            var dummy = new ObservableDummy<uint>();
            SetValue(() => dummy.Item - 8, 34u);
            Assert.AreEqual(42u, dummy.Item);
        }

        [TestMethod]
        public void ReversableSubtract_Long_CorrectResult()
        {
            var dummy = new ObservableDummy<long>();
            SetValue(() => dummy.Item - 8, 34L);
            Assert.AreEqual(42, dummy.Item);
        }

        [TestMethod]
        public void ReversableSubtract_ULong_CorrectResult()
        {
            var dummy = new ObservableDummy<ulong>();
            SetValue(() => dummy.Item - 8, 34ul);
            Assert.AreEqual(42ul, dummy.Item);
        }

        [TestMethod]
        public void ReversableSubtract_Float_CorrectResult()
        {
            var dummy = new ObservableDummy<float>();
            SetValue(() => dummy.Item - 8, 34f);
            Assert.AreEqual(42, dummy.Item);
        }

        [TestMethod]
        public void ReversableSubtract_Double_CorrectResult()
        {
            var dummy = new ObservableDummy<double>();
            SetValue(() => dummy.Item - 8, 34.0);
            Assert.AreEqual(42, dummy.Item);
        }

        [TestMethod]
        public void ReversableSubtract_Decimal_CorrectResult()
        {
            var dummy = new ObservableDummy<decimal>();
            SetValue(() => dummy.Item - 8, 34m);
            Assert.AreEqual(42, dummy.Item);
        }

        protected override void SetValue<T>(Expression<Func<T>> expression, T value)
        {
            var reversable = Observable.Reversable(expression);
            reversable.Value = value;
        }
    }

    [TestClass]
    public class ReversableSubtractExpressionRewriterTests : ReversableSubtractExpressionTests
    {

        protected override void SetValue<T>(Expression<Func<T>> expression, T value)
        {
            var setExpression = SetExpressionRewriter.CreateSetter(expression);
            Assert.IsNotNull(setExpression);
            var setter = setExpression.Compile();
            setter(value);
        }
    }
}
