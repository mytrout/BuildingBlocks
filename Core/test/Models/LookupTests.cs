// <copyright file="LookupTests.cs" company="Chris Trout">
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
    using System.Linq;

    /// <summary>
    /// Tests to execute on <see cref="Lookup" />.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public partial class LookupTests
    {
        [TestMethod]
        public void Returns_Different_HashCode_From_Lookup_GetHashCode_When_Description_Property_Value_Is_Different()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedDescription = "Description2";
            var source2 = new Lookup(lookupId, name, changedDescription, modifiers, items);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Lookup_GetHashCode_When_Items_Property_Value_Is_Different()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedItems = new LookupItem[1]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string)
                                };
            var source2 = new Lookup(lookupId, name, description, modifiers, changedItems);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Lookup_GetHashCode_When_LookupId_Property_Value_Is_Different()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedLookupId = new Guid("07771e3a-8773-431d-a4b6-c17160fe8e71");
            var source2 = new Lookup(changedLookupId, name, description, modifiers, items);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Lookup_GetHashCode_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedModifiers = LookupModifiers.None;
            var source2 = new Lookup(lookupId, name, description, changedModifiers, items);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Lookup_GetHashCode_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedName = "Name2";
            var source2 = new Lookup(lookupId, changedName, description, modifiers, items);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Lookup_Equals_When_ObjectReference_Is_Same()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var expectedResult = true;

            // act
            var result = source1.Equals(source1);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Lookup_Equals_When_Description_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedDescription = "Description2";

            var source2 = new Lookup(lookupId, name, changedDescription, modifiers, items);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Lookup_Equals_When_Items_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedItems = new LookupItem[1]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string)
                                };

            var source2 = new Lookup(lookupId, name, description, modifiers, changedItems);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Lookup_Equals_When_LookupId_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedLookupId = new Guid("07771e3a-8773-431d-a4b6-c17160fe8e71");

            var source2 = new Lookup(changedLookupId, name, description, modifiers, items);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Lookup_Equals_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedModifiers = LookupModifiers.None;

            var source2 = new Lookup(lookupId, name, description, changedModifiers, items);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Lookup_Equals_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var changedName = "Name2";

            var source2 = new Lookup(lookupId, changedName, description, modifiers, items);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Lookup_Equals_When_Other_Parameter_Is_DifferentType()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";

            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var source2 = new object();

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Lookup_Equals_When_Other_Parameter_Is_Null()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";

            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var source2 = null as Lookup;

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Same_Entity_From_Lookup_Copy()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedResult = new Lookup(lookupId, name, description, modifiers, items);

            // act
            var result = expectedResult with { };

            // assert
            Assert.IsFalse(object.ReferenceEquals(result, expectedResult));
            Assert.AreEqual(expectedResult.LookupId, result.LookupId);
            Assert.AreEqual(expectedResult.Name, result.Name);
            Assert.AreEqual(expectedResult.Description, result.Description);
            Assert.AreEqual(expectedResult.Modifiers, result.Modifiers);
            CollectionAssert.AreEqual(expectedResult.Items.ToArray(), result.Items.ToArray());
        }

        [TestMethod]
        public void Returns_Same_HashCode_From_Lookup_GetHashCode_When_Property_Value_Are_The_Same()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var source2 = new Lookup(lookupId, name, description, modifiers, items);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreEqual(source1, source2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Lookup_Equals_When_All_Property_Values_Are_The_Same()
        {
            // arrange
            var description = "Description1";
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var modifiers = LookupModifiers.Flags;
            var name = "Name1";
            var source1 = new Lookup(lookupId, name, description, modifiers, items);

            var source2 = new Lookup(lookupId, name, description, modifiers, items);

            var expectedResult = true;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Valid_Lookup_From_Lookup_Constructor()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            // act
            var result = new Lookup(lookupId, name, description, modifiers, items);

            // assert
            Assert.AreEqual(lookupId, result.LookupId);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(description, result.Description);
            Assert.AreEqual(modifiers, result.Modifiers);
            Assert.AreEqual(items, result.Items);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Lookup_Constructor_When_Property_Description_Is_Empty()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = string.Empty;
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Lookup(lookupId, name, description, modifiers, items));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Lookup_Constructor_When_Property_Name_Is_Empty()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = string.Empty;
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Lookup(lookupId, name, description, modifiers, items));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Lookup_Constructor_When_Property_Description_Is_Null()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = null as string;
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Lookup(lookupId, name, description, modifiers, items));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Lookup_Constructor_When_Property_Items_Is_Null()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = null as LookupItem[];

            var expectedParamName = nameof(items);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Lookup(lookupId, name, description, modifiers, items));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Lookup_Constructor_When_Property_Name_Is_Null()
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = null as string;
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Lookup(lookupId, name, description, modifiers, items));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_Lookup_Constructor_When_Property_LookupId_Is_Empty_Guid()
        {
            // arrange
            var lookupId = Guid.Empty;
            var name = "Name1";
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedParamName = nameof(lookupId);

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Lookup(lookupId, name, description, modifiers, items));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Lookup_Constructor_When_Property_Description_Is_WhiteSpace(string description)
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var name = "Name1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Lookup(lookupId, name, description, modifiers, items));

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
        public void Throws_ArgumentWhiteSpaceException_From_Lookup_Constructor_When_Property_Name_Is_WhiteSpace(string name)
        {
            // arrange
            var lookupId = new Guid("d3ad2f3c-d911-416d-8bd6-c5f920d8e1f9");
            var description = "Description1";
            var modifiers = LookupModifiers.Flags;
            var items = new LookupItem[2]
                                {
                                    new LookupItem(0, "None", "Indicates that a field has no modifiers.", null as string),
                                    new LookupItem(1, "Flags", "Indicates that Lookup items can be bitwise combined.", null as string)
                                };

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Lookup(lookupId, name, description, modifiers, items));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(name, result.ActualValue);
        }
    }
}