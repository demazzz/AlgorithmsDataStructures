// <copyright file="LinkedListTest.cs">Copyright ©  2019</copyright>
using System;
using AlgorithmsDataStructures;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsDataStructures.Tests
{
    /// <summary>This class contains parameterized unit tests for LinkedList</summary>
    [PexClass(typeof(LinkedList))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class LinkedListTest
    {
        /// <summary>Test stub for RemoveAll(Int32)</summary>
        [PexMethod]
        public void RemoveAllTest([PexAssumeUnderTest]LinkedList target, int _value)
        {
            target.RemoveAll(_value);
            // TODO: add assertions to method LinkedListTest.RemoveAllTest(LinkedList, Int32)
        }
    }
}
