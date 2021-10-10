// <copyright file="CoreTypeTests.cs" company="Chris Trout">
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
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public class CoreTypeTests
    {
        [TestMethod]
        public void Returns_Culture_Specific_Messages_When_Culture_Is_Specified()
        {
            // arrange
            var english = Resources.CORETYPE_SELF_REFERENCE(new CultureInfo("en"));
            var french = Resources.CORETYPE_SELF_REFERENCE(new CultureInfo("fr"));
            var german = Resources.CORETYPE_SELF_REFERENCE(new CultureInfo("de"));
            var italian = Resources.CORETYPE_SELF_REFERENCE(new CultureInfo("it"));
            var spanish = Resources.CORETYPE_SELF_REFERENCE(new CultureInfo("es"));

            // act
            var englishUS = Resources.CORETYPE_SELF_REFERENCE(new CultureInfo("en-US"));

            // assert
            Assert.AreEqual(englishUS, english);
            Assert.AreNotEqual(englishUS, french);
            Assert.AreNotEqual(englishUS, german);
            Assert.AreNotEqual(englishUS, italian);
            Assert.AreNotEqual(englishUS, spanish);
        }

        [TestMethod]
        public void Returns_Named_Unknown_CoreType_From_Concept_Constructor()
        {
            // arrange
            string expectedName = "Unknown";

            var entity = null as Entity;
            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = Guid.Empty;
            var internalType = null as Type;
            bool isArray = false;
            bool isConcept = true;
            bool isEntity = false;
            bool isGeneric = false;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            string name = expectedName;
            var @namespace = string.Empty;

            // act
            var result = CoreType.Unknown;

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_Concept_Constructor()
        {
            // arrange
            string expectedName = "ConceptName";

            var entity = null as Entity;
            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = Guid.NewGuid();
            var internalType = null as Type;
            bool isArray = false;
            bool isConcept = true;
            bool isEntity = false;
            bool isGeneric = false;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            string name = expectedName;
            var @namespace = string.Empty;

            // act
            var result = new CoreType(id, expectedName);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_Entity_Constructor()
        {
            // arrange
            string expectedName = "EntityName";
            var entity = new Entity(
                                    Guid.NewGuid(),
                                    expectedName,
                                    "Description",
                                    EntityModifiers.None,
                                    101,
                                    103,
                                    null,
                                    new Field(
                                        Guid.NewGuid(),
                                        new CoreType(typeof(string)),
                                        "fieldName",
                                        "description",
                                        FieldModifiers.None,
                                        null));

            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = entity.EntityId;
            var internalType = null as Type;
            bool isArray = false;
            bool isConcept = false;
            bool isEntity = true;
            bool isGeneric = false;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            var name = expectedName;
            var @namespace = string.Empty;

            // act
            var result = new CoreType(entity);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_Entity_Constructor_With_IsArray_Equals_True()
        {
            // arrange
            string expectedName = "EntityName";
            var entity = new Entity(
                                    Guid.NewGuid(),
                                    expectedName,
                                    "Description",
                                    EntityModifiers.None,
                                    101,
                                    103,
                                    null,
                                    new Field(
                                        Guid.NewGuid(),
                                        new CoreType(typeof(string)),
                                        "fieldName",
                                        "description",
                                        FieldModifiers.None,
                                        null));

            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = entity.EntityId;
            var internalType = null as Type;
            bool isArray = true;
            bool isConcept = false;
            bool isEntity = true;
            bool isGeneric = false;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            var name = expectedName + "[]";
            var @namespace = string.Empty;

            // act
            var result = new CoreType(id, entity);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_GenericType_Constructor()
        {
            // arrange
            var entity = null as Entity;
            var genericType = new CoreType(typeof(List<>));
            var genericTypeParameters = new CoreType[1] { new CoreType(typeof(string)) };
            var id = Guid.NewGuid();
            var internalType = null as Type;
            bool isArray = false;
            bool isConcept = false;
            bool isEntity = false;
            bool isGeneric = true;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            var name = "List<String>";
            var @namespace = typeof(List<>).Namespace;

            // act
            var result = new CoreType(id, genericType, genericTypeParameters);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_GenericType_Constructor_With_Multiple_Generic_Parameters()
        {
            // arrange
            var entity = null as Entity;
            var genericType = new CoreType(typeof(Dictionary<,>));
            var genericTypeParameters = new CoreType[2] { new CoreType(typeof(string)), new CoreType(typeof(string)) };
            var id = Guid.NewGuid();
            var internalType = null as Type;
            bool isArray = false;
            bool isConcept = false;
            bool isEntity = false;
            bool isGeneric = true;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            var name = "Dictionary<String,String>";
            var @namespace = typeof(Dictionary<,>).Namespace;

            // act
            var result = new CoreType(id, genericType, genericTypeParameters);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_InternalType_Constructor()
        {
            // arrange
            var internalType = typeof(Application);

            var entity = null as Entity;
            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = internalType.GUID;
            bool isArray = false;
            bool isConcept = false;
            bool isEntity = false;
            bool isGeneric = false;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            var name = nameof(Application);
            var @namespace = typeof(Application).Namespace;

            // act
            var result = new CoreType(internalType);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_InternalType_Constructor_With_Primitive_Type()
        {
            // arrange
            var internalType = typeof(int);

            var entity = null as Entity;
            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = internalType.GUID;
            bool isArray = false;
            bool isConcept = false;
            bool isEntity = false;
            bool isGeneric = false;
            bool isLookup = false;
            bool isPrimitive = true;
            bool isValueType = true;
            var lookup = null as Lookup;
            var name = typeof(int).Name;
            var @namespace = typeof(int).Namespace;

            // act
            var result = new CoreType(internalType);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_InternalType_Constructor_With_IsArray_Equals_True()
        {
            // arrange
            var internalType = typeof(Application);

            var entity = null as Entity;
            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = Guid.NewGuid();
            bool isArray = true;
            bool isConcept = false;
            bool isEntity = false;
            bool isGeneric = false;
            bool isLookup = false;
            bool isPrimitive = false;
            bool isValueType = false;
            var lookup = null as Lookup;
            var name = nameof(Application) + "[]";
            var @namespace = typeof(Application).Namespace;

            // act
            var result = new CoreType(id, internalType);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Returns_Valid_CoreType_From_Lookup_Constructor()
        {
            // arrange
            var lookup = new Lookup(
                                    Guid.NewGuid(),
                                    "Lookup Testing:",
                                    "LookupDescription",
                                    LookupModifiers.Flags,
                                    new LookupItem(1, "Item Name 1", "Description 1"));

            var entity = null as Entity;
            var genericType = null as CoreType;
            var genericTypeParameters = null as CoreType[];
            var id = lookup.LookupId;
            var internalType = null as Type;
            bool isArray = false;
            bool isConcept = false;
            bool isEntity = false;
            bool isGeneric = false;
            bool isLookup = true;
            bool isPrimitive = false;
            bool isValueType = false;
            var name = lookup.Name;
            var @namespace = string.Empty;

            // act
            var result = new CoreType(lookup);

            // assert
            Assert.AreEqual(entity, result.Entity);
            Assert.AreEqual(genericType, result.GenericType);
            Assert.AreEqual(genericTypeParameters, result.GenericTypeParameters);
            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(internalType, result.InternalType);
            Assert.AreEqual(isArray, result.IsArray);
            Assert.AreEqual(isConcept, result.IsConcept);
            Assert.AreEqual(isEntity, result.IsEntity);
            Assert.AreEqual(isGeneric, result.IsGeneric);
            Assert.AreEqual(isLookup, result.IsLookup);
            Assert.AreEqual(isPrimitive, result.IsPrimitive);
            Assert.AreEqual(isValueType, result.IsValueType);
            Assert.AreEqual(lookup, result.Lookup);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(@namespace, result.Namespace);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Concept_Constructor_When_ConceptName_Is_Null()
        {
            // arrange
            var id = Guid.NewGuid();
            var conceptName = null as string;
            var expectedParamName = nameof(conceptName);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(id, conceptName));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Entity_Constructor_When_Type_Is_Null()
        {
            // arrange
            var entity = null as Entity;
            var expectedParamName = nameof(entity);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(entity));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Entity_Array_Constructor_When_Type_Is_Null()
        {
            // arrange
            var arrayId = Guid.NewGuid();
            var entity = null as Entity;
            var expectedParamName = nameof(entity);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(arrayId, entity));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_GenericType_Constructor_When_GenericType_Is_Null()
        {
            // arrange
            var genericType = null as CoreType;
            var genericTypeParameters = new CoreType[1] { new CoreType(typeof(string)) };
            var id = Guid.NewGuid();
            var expectedParamName = nameof(genericType);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(id, genericType, genericTypeParameters));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_GenericType_Constructor_When_GenericTypeParameters_Is_Null()
        {
            // arrange
            var genericType = new CoreType(typeof(IEnumerable<>));
            var genericTypeParameters = null as CoreType[];
            var id = Guid.NewGuid();
            var expectedParamName = nameof(genericTypeParameters);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(id, genericType, genericTypeParameters));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_InternalType_Constructor_When_Type_Is_Null()
        {
            // arrange
            var internalType = null as Type;
            var expectedParamName = nameof(internalType);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(internalType));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_InternalType_Array_Constructor_When_Type_Is_Null()
        {
            // arrange
            var arrayId = Guid.NewGuid();
            var internalType = null as Type;
            var expectedParamName = nameof(internalType);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(arrayId, internalType));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Lookup_Constructor_When_Lookup_Is_Null()
        {
            // arrange
            var lookup = null as Lookup;
            var expectedParamName = nameof(lookup);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new CoreType(lookup));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_GenericType_Constructor_When_GenericTypeParameters_Count_Is_Zero()
        {
            // arrange
            var genericType = new CoreType(typeof(IEnumerable<>));
            var genericTypeParameters = Array.Empty<CoreType>();
            var id = Guid.NewGuid();
            var expectedParamName = nameof(genericTypeParameters);
            var expectedMessage = $"{Resources.GENERIC_ONE_ENTRY(CultureInfo.CurrentUICulture, nameof(genericTypeParameters))} (Parameter '{nameof(genericTypeParameters)}')\r\nActual value was MyTrout.BuildingBlocks.Core.Models.CoreType[].";

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CoreType(id, genericType, genericTypeParameters));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(genericTypeParameters, result.ActualValue);
            Assert.AreEqual(expectedMessage, result.Message);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_GenericType_Constructor_When_GenericTypeParameters_Contains_Null_Generic_Parameter()
        {
            // arrange
            var genericType = new CoreType(typeof(IDictionary<,>));
            var genericTypeParameters = new CoreType[2] { new CoreType(typeof(string)), null };
            var id = Guid.NewGuid();
            var expectedParamName = nameof(genericTypeParameters);
            var expectedMessage = $"{Resources.GENERIC_NOT_NULL(CultureInfo.CurrentUICulture, nameof(genericTypeParameters))} (Parameter '{nameof(genericTypeParameters)}')\r\nActual value was MyTrout.BuildingBlocks.Core.Models.CoreType[].";

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CoreType(id, genericType, genericTypeParameters));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(genericTypeParameters, result.ActualValue);
            Assert.AreEqual(expectedMessage, result.Message);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_GenericType_Constructor_When_GenericTypeParameters_Count_Is_Different_Than_GenericType_Parameters_Count()
        {
            // arrange
            var genericType = new CoreType(typeof(List<>));
            var genericTypeParameters = new CoreType[2] { new CoreType(typeof(string)), new CoreType(typeof(Uri)) };
            var id = Guid.NewGuid();
            var expectedParamName = nameof(genericTypeParameters);
            var expectedMessage = $"{Resources.GENERIC_PARAMETERS_COUNT_MATCH(CultureInfo.CurrentUICulture, nameof(genericTypeParameters), nameof(genericType))} (Parameter '{nameof(genericTypeParameters)}')\r\nActual value was MyTrout.BuildingBlocks.Core.Models.CoreType[].";

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CoreType(id, genericType, genericTypeParameters));

            // assert
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(genericTypeParameters, result.ActualValue);
            Assert.AreEqual(expectedMessage, result.Message);
        }
    }
}
