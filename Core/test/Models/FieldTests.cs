// <copyright file="FieldTests.cs" company="Chris Trout">
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
    using MyTrout.BuildingBlocks.Core.Models;
    using System;

    /// <summary>
    /// Tests to execute on <see cref="Field" />.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public partial class FieldTests
    {
        [TestMethod]
        public void Returns_Different_HashCode_From_Field_GetHashCode_When_FieldId_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedFieldId = new Guid("0933b7b1-e209-4689-ac55-6c1d4630e951");
            var source2 = new Field(changedFieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Field_GetHashCode_When_FieldType_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedFieldType = new CoreType(typeof(int));
            var source2 = new Field(fieldId, changedFieldType, name, shortDescription, modifiers, optionalValue);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Field_GetHashCode_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedModifiers = FieldModifiers.Params;
            var source2 = new Field(fieldId, fieldType, name, shortDescription, changedModifiers, optionalValue);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Field_GetHashCode_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedName = "Name2";
            var source2 = new Field(fieldId, fieldType, changedName, shortDescription, modifiers, optionalValue);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Field_GetHashCode_When_OptionalValue_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedOptionalValue = "Name2";
            var source2 = new Field(fieldId, fieldType, name, shortDescription, modifiers, changedOptionalValue);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Field_GetHashCode_When_OptionalValue_Property_Value_Is_Null()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";
            var changedOptionalValue = null as object;

            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var source2 = new Field(fieldId, fieldType, name, shortDescription, modifiers, changedOptionalValue);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Field_GetHashCode_When_ShortDescription_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedShortDescription = "ShortDescription2";
            var source2 = new Field(fieldId, fieldType, name, changedShortDescription, modifiers, optionalValue);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Field_Equals_When_ObjectReference_Is_Same()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var expectedResult = true;

            // act
            var result = source1.Equals(source1);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_FieldId_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedFieldId = new Guid("0933b7b1-e209-4689-ac55-6c1d4630e951");

            var source2 = new Field(changedFieldId, fieldType, name, shortDescription, modifiers, optionalValue);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_FieldType_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedFieldType = new CoreType(typeof(int));

            var source2 = new Field(fieldId, changedFieldType, name, shortDescription, modifiers, optionalValue);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedModifiers = FieldModifiers.Params;

            var source2 = new Field(fieldId, fieldType, name, shortDescription, changedModifiers, optionalValue);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedName = "Name2";

            var source2 = new Field(fieldId, fieldType, changedName, shortDescription, modifiers, optionalValue);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_OptionalValue_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedOptionalValue = "Name2";

            var source2 = new Field(fieldId, fieldType, name, shortDescription, modifiers, changedOptionalValue);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_Other_Parameter_Is_DifferentType()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";

            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var source2 = new object();

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_Other_Parameter_Is_Null()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";

            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var source2 = null as Field;

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Field_Equals_When_ShortDescription_Property_Value_Is_Different()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var changedShortDescription = "ShortDescription2";

            var source2 = new Field(fieldId, fieldType, name, changedShortDescription, modifiers, optionalValue);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Same_Entity_From_Field_Copy()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedResult = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            // act
            var result = expectedResult with { };

            // assert
            Assert.IsFalse(object.ReferenceEquals(result, expectedResult));
            Assert.AreEqual(expectedResult.FieldId, result.FieldId);
            Assert.AreEqual(expectedResult.FieldType, result.FieldType);
            Assert.AreEqual(expectedResult.Name, result.Name);
            Assert.AreEqual(expectedResult.ShortDescription, result.ShortDescription);
            Assert.AreEqual(expectedResult.Modifiers, result.Modifiers);
            Assert.AreEqual(expectedResult.OptionalValue, result.OptionalValue);
        }

        [TestMethod]
        public void Returns_Same_HashCode_From_Field_GetHashCode_When_Property_Value_Are_The_Same()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var source2 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreEqual(source1, source2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Field_Equals_When_All_Property_Values_Are_The_Same()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var modifiers = FieldModifiers.Optional;
            var name = "Name1";
            var optionalValue = "Name";
            var shortDescription = "ShortDescription1";
            var source1 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var source2 = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            var expectedResult = true;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Valid_Field_From_Field_Constructor()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            // act
            var result = new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue);

            // assert
            Assert.AreEqual(fieldId, result.FieldId);
            Assert.AreEqual(fieldType, result.FieldType);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(shortDescription, result.ShortDescription);
            Assert.AreEqual(modifiers, result.Modifiers);
            Assert.AreEqual(optionalValue, result.OptionalValue);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Field_Constructor_When_Property_Name_Is_Empty()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = string.Empty;
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Field_Constructor_When_Property_ShortDescription_Is_Empty()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = string.Empty;
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(shortDescription);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Field_Constructor_When_Property_FieldType_Is_Null()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = null as CoreType;
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(fieldType);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Field_Constructor_When_Property_Name_Is_Null()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = null as string;
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Field_Constructor_When_Property_ShortDescription_Is_Null()
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = null as string;
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(shortDescription);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_Field_Constructor_When_Property_FieldId_Is_Empty_Guid()
        {
            // arrange
            var fieldId = Guid.Empty;
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(fieldId);

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Field_Constructor_When_Property_Name_Is_WhiteSpace(string name)
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var shortDescription = "ShortDescription1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(name, result.ActualValue);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Field_Constructor_When_Property_ShortDescription_Is_WhiteSpace(string shortDescription)
        {
            // arrange
            var fieldId = new Guid("1aa44f0e-21a8-4eb4-997f-9aaff4c8ba9f");
            var fieldType = new CoreType(typeof(string));
            var name = "Name1";
            var modifiers = FieldModifiers.Optional;
            var optionalValue = "Name";

            var expectedParamName = nameof(shortDescription);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Field(fieldId, fieldType, name, shortDescription, modifiers, optionalValue));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(shortDescription, result.ActualValue);
        }
    }
}