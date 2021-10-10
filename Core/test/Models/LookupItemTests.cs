// <copyright file="LookupItemTests.cs" company="Chris Trout">
// MIT License
//
// Copyright(c) 2019-2021 Chris Trout
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//
// </copyright>

namespace MyTrout.BuildingBlocks.Core.Models.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTrout.BuildingBlocks.Core;
    using System;

    /// <summary>
    /// Tests to execute on <see cref="LookupItem" />.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public partial class LookupItemTests
    {
        [TestMethod]
        public void Returns_Different_HashCode_From_LookupItem_GetHashCode_When_Description_Property_Value_Is_Different()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedDescription = "Description2";
            var source2 = new LookupItem(id, name, changedDescription, remarks);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_LookupItem_GetHashCode_When_Id_Property_Value_Is_Different()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedId = 2;
            var source2 = new LookupItem(changedId, name, description, remarks);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_LookupItem_GetHashCode_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedName = "Name2";
            var source2 = new LookupItem(id, changedName, description, remarks);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_LookupItem_GetHashCode_When_Remarks_Property_Value_Is_Different()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedRemarks = "Remarks2";
            var source2 = new LookupItem(id, name, description, changedRemarks);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_LookupItem_GetHashCode_When_Remarks_Property_Value_Is_Null()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";
            var changedRemarks = null as string;

            var source1 = new LookupItem(id, name, description, remarks);

            var source2 = new LookupItem(id, name, description, changedRemarks);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_LookupItem_Equals_When_ObjectReference_Is_Same()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var expectedResult = true;

            // act
            var result = source1.Equals(source1);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_LookupItem_Equals_When_Description_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedDescription = "Description2";

            var source2 = new LookupItem(id, name, changedDescription, remarks);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_LookupItem_Equals_When_Id_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedId = 2;

            var source2 = new LookupItem(changedId, name, description, remarks);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_LookupItem_Equals_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedName = "Name2";

            var source2 = new LookupItem(id, changedName, description, remarks);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_LookupItem_Equals_When_Other_Parameter_Is_DifferentType()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";

            var source1 = new LookupItem(id, name, description, remarks);

            var source2 = new object();

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_LookupItem_Equals_When_Other_Parameter_Is_Null()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";

            var source1 = new LookupItem(id, name, description, remarks);

            var source2 = null as LookupItem;

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_LookupItem_Equals_When_Remarks_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var changedRemarks = "Remarks2";

            var source2 = new LookupItem(id, name, description, changedRemarks);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Same_Entity_From_LookupItem_Copy()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";

            var expectedResult = new LookupItem(id, name, description, remarks);

            // act
            var result = expectedResult with { };

            // assert
            Assert.IsFalse(object.ReferenceEquals(result, expectedResult));
            Assert.AreEqual(expectedResult.Id, result.Id);
            Assert.AreEqual(expectedResult.Name, result.Name);
            Assert.AreEqual(expectedResult.Description, result.Description);
            Assert.AreEqual(expectedResult.Remarks, result.Remarks);
        }

        [TestMethod]
        public void Returns_Same_HashCode_From_LookupItem_GetHashCode_When_Property_Value_Are_The_Same()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";

            var source1 = new LookupItem(id, name, description, remarks);

            var source2 = new LookupItem(id, name, description, remarks);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreEqual(source1, source2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_LookupItem_Equals_When_All_Property_Values_Are_The_Same()
        {
            // arrange
            var description = "Description1";
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";
            var source1 = new LookupItem(id, name, description, remarks);

            var source2 = new LookupItem(id, name, description, remarks);

            var expectedResult = true;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Valid_LookupItem_From_LookupItem_Constructor()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = "Description1";
            var remarks = "Remarks1";

            // act
            var result = new LookupItem(id, name, description, remarks);

            // assert
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(description, result.Description);
            Assert.AreEqual(remarks, result.Remarks);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_LookupItem_Constructor_When_Property_Description_Is_Empty()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = string.Empty;
            var remarks = "Remarks1";

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new LookupItem(id, name, description, remarks));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_LookupItem_Constructor_When_Property_Name_Is_Empty()
        {
            // arrange
            var id = 1;
            var name = string.Empty;
            var description = "Description1";
            var remarks = "Remarks1";

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new LookupItem(id, name, description, remarks));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_LookupItem_Constructor_When_Property_Description_Is_Null()
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var description = null as string;
            var remarks = "Remarks1";

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new LookupItem(id, name, description, remarks));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_LookupItem_Constructor_When_Property_Name_Is_Null()
        {
            // arrange
            var id = 1;
            var name = null as string;
            var description = "Description1";
            var remarks = "Remarks1";

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new LookupItem(id, name, description, remarks));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_LookupItem_Constructor_When_Property_Description_Is_WhiteSpace(string description)
        {
            // arrange
            var id = 1;
            var name = "Name1";
            var remarks = "Remarks1";

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new LookupItem(id, name, description, remarks));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(description, result.ActualValue);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_LookupItem_Constructor_When_Property_Name_Is_WhiteSpace(string name)
        {
            // arrange
            var id = 1;
            var description = "Description1";
            var remarks = "Remarks1";

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new LookupItem(id, name, description, remarks));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(name, result.ActualValue);
        }
    }
}