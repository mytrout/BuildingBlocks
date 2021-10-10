// <copyright file="RelationshipTests.cs" company="Chris Trout">
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
    using MyTrout.BuildingBlocks.Core.Models;
    using System;

    /// <summary>
    /// Tests to execute on <see cref="Relationship" />.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public partial class RelationshipTests
    {
        [TestMethod]
        public void Returns_Different_HashCode_From_Relationship_GetHashCode_When_Cardinality_Property_Value_Is_Different()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedCardinality = RelationshipCardinality.ManyToMany;
            var source2 = new Relationship(relationshipId, primaryType, modality, changedCardinality, secondaryCoreType, modifiers);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Relationship_GetHashCode_When_Modality_Property_Value_Is_Different()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedModality = RelationshipModality.Required;
            var source2 = new Relationship(relationshipId, primaryType, changedModality, cardinality, secondaryCoreType, modifiers);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Relationship_GetHashCode_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedModifiers = RelationshipModifiers.EffectiveDateRequired;
            var source2 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, changedModifiers);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Relationship_GetHashCode_When_PrimaryType_Property_Value_Is_Different()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedPrimaryType = new CoreType(typeof(Uri));
            var source2 = new Relationship(relationshipId, changedPrimaryType, modality, cardinality, secondaryCoreType, modifiers);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Relationship_GetHashCode_When_RelationshipId_Property_Value_Is_Different()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedRelationshipId = new Guid("41118c0f-e63e-4273-9d78-48ff12d4ef7c");
            var source2 = new Relationship(changedRelationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Relationship_GetHashCode_When_SecondaryCoreType_Property_Value_Is_Different()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedSecondaryCoreType = new CoreType(typeof(string));
            var source2 = new Relationship(relationshipId, primaryType, modality, cardinality, changedSecondaryCoreType, modifiers);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Relationship_Equals_When_ObjectReference_Is_Same()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var expectedResult = true;

            // act
            var result = source1.Equals(source1);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_Cardinality_Property_Value_Is_Different()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedCardinality = RelationshipCardinality.ManyToMany;

            var source2 = new Relationship(relationshipId, primaryType, modality, changedCardinality, secondaryCoreType, modifiers);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_Modality_Property_Value_Is_Different()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedModality = RelationshipModality.Required;

            var source2 = new Relationship(relationshipId, primaryType, changedModality, cardinality, secondaryCoreType, modifiers);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_Modifiers_Property_Value_Is_Different()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedModifiers = RelationshipModifiers.EffectiveDateRequired;

            var source2 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, changedModifiers);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_Other_Parameter_Is_DifferentType()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));

            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var source2 = new object();

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_Other_Parameter_Is_Null()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));

            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var source2 = null as Relationship;

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_PrimaryType_Property_Value_Is_Different()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedPrimaryType = new CoreType(typeof(Uri));

            var source2 = new Relationship(relationshipId, changedPrimaryType, modality, cardinality, secondaryCoreType, modifiers);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_RelationshipId_Property_Value_Is_Different()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedRelationshipId = new Guid("41118c0f-e63e-4273-9d78-48ff12d4ef7c");

            var source2 = new Relationship(changedRelationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Relationship_Equals_When_SecondaryCoreType_Property_Value_Is_Different()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var changedSecondaryCoreType = new CoreType(typeof(string));

            var source2 = new Relationship(relationshipId, primaryType, modality, cardinality, changedSecondaryCoreType, modifiers);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Same_Entity_From_Relationship_Copy()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;

            var expectedResult = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            // act
            var result = expectedResult with { };

            // assert
            Assert.IsFalse(object.ReferenceEquals(result, expectedResult));
            Assert.AreEqual(expectedResult.RelationshipId, result.RelationshipId);
            Assert.AreEqual(expectedResult.PrimaryType, result.PrimaryType);
            Assert.AreEqual(expectedResult.Modality, result.Modality);
            Assert.AreEqual(expectedResult.Cardinality, result.Cardinality);
            Assert.AreEqual(expectedResult.SecondaryCoreType, result.SecondaryCoreType);
            Assert.AreEqual(expectedResult.Modifiers, result.Modifiers);
        }

        [TestMethod]
        public void Returns_Same_HashCode_From_Relationship_GetHashCode_When_Property_Value_Are_The_Same()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;

            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var source2 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreEqual(source1, source2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Relationship_Equals_When_All_Property_Values_Are_The_Same()
        {
            // arrange
            var cardinality = RelationshipCardinality.OneToMany;
            var modality = RelationshipModality.Optional;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;
            var primaryType = new CoreType(typeof(string));
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var secondaryCoreType = new CoreType(typeof(Uri));
            var source1 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var source2 = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            var expectedResult = true;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Valid_Relationship_From_Relationship_Constructor()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;

            // act
            var result = new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers);

            // assert
            Assert.AreEqual(relationshipId, result.RelationshipId);
            Assert.AreEqual(primaryType, result.PrimaryType);
            Assert.AreEqual(modality, result.Modality);
            Assert.AreEqual(cardinality, result.Cardinality);
            Assert.AreEqual(secondaryCoreType, result.SecondaryCoreType);
            Assert.AreEqual(modifiers, result.Modifiers);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Relationship_Constructor_When_Property_PrimaryType_Is_Null()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = null as CoreType;
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;

            var expectedParamName = nameof(primaryType);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Relationship_Constructor_When_Property_SecondaryCoreType_Is_Null()
        {
            // arrange
            var relationshipId = new Guid("14eeeaa1-8a9d-4905-8af1-6b86c492d79c");
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = null as CoreType;
            var modifiers = RelationshipModifiers.ExpirationDateRequired;

            var expectedParamName = nameof(secondaryCoreType);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_Relationship_Constructor_When_Property_RelationshipId_Is_Empty_Guid()
        {
            // arrange
            var relationshipId = Guid.Empty;
            var primaryType = new CoreType(typeof(string));
            var modality = RelationshipModality.Optional;
            var cardinality = RelationshipCardinality.OneToMany;
            var secondaryCoreType = new CoreType(typeof(Uri));
            var modifiers = RelationshipModifiers.ExpirationDateRequired;

            var expectedParamName = nameof(relationshipId);

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Relationship(relationshipId, primaryType, modality, cardinality, secondaryCoreType, modifiers));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }
    }
}