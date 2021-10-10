// <copyright file="ConceptTests.cs" company="Chris Trout">
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
    /// Tests to execute on <see cref="Concept" />.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public partial class ConceptTests
    {
        [TestMethod]
        public void Returns_Different_HashCode_From_Concept_GetHashCode_When_id_Property_Value_Is_Different()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";

            var source1 = new Concept(id, name);

            var changedid = new Guid("4df32a40-41a9-44f4-b233-a74c68d50f7f");
            var source2 = new Concept(changedid, name);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Concept_GetHashCode_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";

            var source1 = new Concept(id, name);

            var changedName = "Name2";
            var source2 = new Concept(id, changedName);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Concept_Equals_When_ObjectReference_Is_Same()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var source1 = new Concept(id, name);

            var expectedResult = true;

            // act
            var result = source1.Equals(source1);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Concept_Equals_When_id_Property_Value_Is_Different()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var source1 = new Concept(id, name);

            var changedid = new Guid("4df32a40-41a9-44f4-b233-a74c68d50f7f");

            var source2 = new Concept(changedid, name);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Concept_Equals_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var source1 = new Concept(id, name);

            var changedName = "Name2";

            var source2 = new Concept(id, changedName);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Same_Entity_From_Concept_Copy()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";

            var expectedResult = new Concept(id, name);

            // act
            var result = expectedResult with { };

            // assert
            Assert.IsFalse(object.ReferenceEquals(result, expectedResult));
            Assert.AreEqual(expectedResult.ConceptId, result.ConceptId);
            Assert.AreEqual(expectedResult.Name, result.Name);
        }

        [TestMethod]
        public void Returns_Same_HashCode_From_Concept_GetHashCode_When_Property_Value_Are_The_Same()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";

            var source1 = new Concept(id, name);

            var source2 = new Concept(id, name);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreEqual(source1, source2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Concept_Equals_When_All_Property_Values_Are_The_Same()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var source1 = new Concept(id, name);

            var source2 = new Concept(id, name);

            var expectedResult = true;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Unknown_Concept_From_Concept_Constructor()
        {
            // arrange
            var id = Guid.Empty;
            var name = "Unknown";

            // act
            var result = Concept.Unknown;

            // assert
            Assert.AreEqual(id, result.ConceptId);
            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        public void Returns_Valid_Concept_From_Concept_Constructor()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";

            // act
            var result = new Concept(id, name);

            // assert
            Assert.AreEqual(id, result.ConceptId);
            Assert.AreEqual(name, result.Name);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Concept_Constructor_When_Property_Name_Is_Empty()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = string.Empty;

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Concept(id, name));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Concept_Constructor_When_Property_Name_Is_Null()
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = null as string;

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Concept(id, name));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Concept_Constructor_When_Property_Name_Is_WhiteSpace(string name)
        {
            // arrange
            var id = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Concept(id, name));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(name, result.ActualValue);
        }
    }
}
