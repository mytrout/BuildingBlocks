// <copyright file="EntityTests.cs" company="Chris Trout">
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
    /// Tests to execute on <see cref="Entity" />.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public partial class EntityTests
    {
        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_BaseCoreType_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedBaseCoreType = null as CoreType;
            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, changedBaseCoreType, fields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_BaseCoreType_Property_Value_Is_Null()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var changedBaseCoreType = null as CoreType;

            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, changedBaseCoreType, fields);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_Description_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedDescription = "Description2";
            var source2 = new Entity(entityId, name, changedDescription, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_EntityId_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedEntityId = new Guid("e5ea48d6-9a3b-4da1-a4f6-22c622a4700e");
            var source2 = new Entity(changedEntityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_Fields_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedFields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name2", "Name2", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description2", FieldModifiers.None, null)
                                };
            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, changedFields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedModifiers = EntityModifiers.Decoratee;
            var source2 = new Entity(entityId, name, description, changedModifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedName = "Name2";
            var source2 = new Entity(entityId, changedName, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_PrimaryPrimeNumberForHash_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedPrimaryPrimeNumberForHash = 2950948;
            var source2 = new Entity(entityId, name, description, modifiers, changedPrimaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Entity_GetHashCode_When_SecondaryPrimeNumberForHash_Property_Value_Is_Different()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedSecondaryPrimeNumberForHash = 7478494;
            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, changedSecondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Entity_Equals_When_ObjectReference_Is_Same()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = true;

            // act
            var result = source1.Equals(source1);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_BaseCoreType_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedBaseCoreType = null as CoreType;

            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, changedBaseCoreType, fields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_Description_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedDescription = "Description2";

            var source2 = new Entity(entityId, name, changedDescription, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_EntityId_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedEntityId = new Guid("e5ea48d6-9a3b-4da1-a4f6-22c622a4700e");

            var source2 = new Entity(changedEntityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_Fields_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedFields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name2", "Name2", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description2", FieldModifiers.None, null)
                                };

            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, changedFields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedModifiers = EntityModifiers.Decoratee;

            var source2 = new Entity(entityId, name, description, changedModifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedName = "Name2";

            var source2 = new Entity(entityId, changedName, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_Other_Parameter_Is_DifferentType()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;

            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var source2 = new object();

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_Other_Parameter_Is_Null()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;

            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var source2 = null as Entity;

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_PrimaryPrimeNumberForHash_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedPrimaryPrimeNumberForHash = 2950948;

            var source2 = new Entity(entityId, name, description, modifiers, changedPrimaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Entity_Equals_When_SecondaryPrimeNumberForHash_Property_Value_Is_Different()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var changedSecondaryPrimeNumberForHash = 7478494;

            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, changedSecondaryPrimeNumberForHash, baseCoreType, fields);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Same_Entity_From_Entity_Copy()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedResult = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            // act
            var result = expectedResult with { };

            // assert
            Assert.IsFalse(object.ReferenceEquals(result, expectedResult));
            Assert.AreEqual(expectedResult.EntityId, result.EntityId);
            Assert.AreEqual(expectedResult.Name, result.Name);
            Assert.AreEqual(expectedResult.Description, result.Description);
            Assert.AreEqual(expectedResult.Modifiers, result.Modifiers);
            Assert.AreEqual(expectedResult.PrimaryPrimeNumberForHash, result.PrimaryPrimeNumberForHash);
            Assert.AreEqual(expectedResult.SecondaryPrimeNumberForHash, result.SecondaryPrimeNumberForHash);
            Assert.AreEqual(expectedResult.BaseCoreType, result.BaseCoreType);
            CollectionAssert.AreEqual(expectedResult.Fields.ToArray(), result.Fields.ToArray());
        }

        [TestMethod]
        public void Returns_Same_HashCode_From_Entity_GetHashCode_When_Property_Value_Are_The_Same()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreEqual(source1, source2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Entity_Equals_When_All_Property_Values_Are_The_Same()
        {
            // arrange
            var baseCoreType = new CoreType(typeof(Uri));
            var description = "Description1";
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };
            var modifiers = EntityModifiers.None;
            var name = "Name1";
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var source1 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var source2 = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            var expectedResult = true;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Valid_Entity_From_Entity_Constructor()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            // act
            var result = new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields);

            // assert
            Assert.AreEqual(entityId, result.EntityId);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(description, result.Description);
            Assert.AreEqual(modifiers, result.Modifiers);
            Assert.AreEqual(primaryPrimeNumberForHash, result.PrimaryPrimeNumberForHash);
            Assert.AreEqual(secondaryPrimeNumberForHash, result.SecondaryPrimeNumberForHash);
            Assert.AreEqual(baseCoreType, result.BaseCoreType);
            Assert.AreEqual(fields, result.Fields);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Entity_Constructor_When_Property_Description_Is_Empty()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = string.Empty;
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Entity_Constructor_When_Property_Name_Is_Empty()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = string.Empty;
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Entity_Constructor_When_Property_Description_Is_Null()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = null as string;
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Entity_Constructor_When_Property_Fields_Is_Null()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = null as Field[];

            var expectedParamName = nameof(fields);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Entity_Constructor_When_Property_Name_Is_Null()
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = null as string;
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_Entity_Constructor_When_Property_EntityId_Is_Empty_Guid()
        {
            // arrange
            var entityId = Guid.Empty;
            var name = "Name1";
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedParamName = nameof(entityId);

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Entity_Constructor_When_Property_Description_Is_WhiteSpace(string description)
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var name = "Name1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedParamName = nameof(description);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

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
        public void Throws_ArgumentWhiteSpaceException_From_Entity_Constructor_When_Property_Name_Is_WhiteSpace(string name)
        {
            // arrange
            var entityId = new Guid("0c2b50ce-9f95-4181-9020-128010ff4ddc");
            var description = "Description1";
            var modifiers = EntityModifiers.None;
            var primaryPrimeNumberForHash = 34094093;
            var secondaryPrimeNumberForHash = 9058594;
            var baseCoreType = new CoreType(typeof(Uri));
            var fields = new Field[2]
                                {
                                    new Field(new Guid("6afc2e86-a2bf-418f-be76-4081faa316c2"), new CoreType(typeof(string)), "Name1", "Name1", FieldModifiers.Optional, null),
                                    new Field(new Guid("efe47a20-590d-4af9-a2a4-9e6e0c8acda6"), new CoreType(typeof(string)), "Description1", "Description1", FieldModifiers.None, null)
                                };

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Entity(entityId, name, description, modifiers, primaryPrimeNumberForHash, secondaryPrimeNumberForHash, baseCoreType, fields));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(name, result.ActualValue);
        }
    }
}