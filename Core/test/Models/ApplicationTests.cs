// <copyright file="ApplicationTests.cs" company="Chris Trout">
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
    using MyTrout.BuildingBlocks.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Tests to execute on <see cref="Application" />.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [TestClass]
    public partial class ApplicationTests
    {
        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_ApplicationId_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedApplicationId = new Guid("4df32a40-41a9-44f4-b233-a74c68d50f7f");
            var source2 = new Application(changedApplicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_ApplicationUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedApplicationUri = new Uri("https://test2.url/");
            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, changedApplicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_Authors_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedAuthors = "Authors2";
            var source2 = new Application(applicationId, name, companyName, companyShortName, changedAuthors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_CompanyName_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedCompanyName = "CompanyName2";
            var source2 = new Application(applicationId, name, changedCompanyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_CompanyShortName_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedCompanyShortName = "CompanyShortName2";
            var source2 = new Application(applicationId, name, companyName, changedCompanyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_LicenseUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedLicenseUri = new Uri("https://license2.url/");
            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, changedLicenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedName = "Name2";
            var source2 = new Application(applicationId, changedName, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_OriginalCopyrightYear_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedOriginalCopyrightYear = 2019;
            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, changedOriginalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_PrivacyStatementUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedPrivacyStatementUri = new Uri("https://privacy2.url/");
            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, changedPrivacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Different_HashCode_From_Application_GetHashCode_When_TermsOfServiceUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedTermsOfServiceUri = new Uri("https://tos2.url/");
            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, changedTermsOfServiceUri, privacyStatementUri);

            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Application_Equals_When_ObjectReference_Is_Same()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = true;

            // act
            var result = source1.Equals(source1);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_ApplicationId_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedApplicationId = new Guid("4df32a40-41a9-44f4-b233-a74c68d50f7f");

            var source2 = new Application(changedApplicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_ApplicationUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedApplicationUri = new Uri("https://test2.url/");

            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, changedApplicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_Authors_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedAuthors = "Authors2";

            var source2 = new Application(applicationId, name, companyName, companyShortName, changedAuthors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_CompanyName_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedCompanyName = "CompanyName2";

            var source2 = new Application(applicationId, name, changedCompanyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_CompanyShortName_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedCompanyShortName = "CompanyShortName2";

            var source2 = new Application(applicationId, name, companyName, changedCompanyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_LicenseUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedLicenseUri = new Uri("https://license2.url/");

            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, changedLicenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_Name_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedName = "Name2";

            var source2 = new Application(applicationId, changedName, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_OriginalCopyrightYear_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedOriginalCopyrightYear = 2019;

            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, changedOriginalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_Other_Parameter_Is_DifferentType()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");

            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var source2 = new object();

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_Other_Parameter_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");

            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var source2 = null as Application;

            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_PrivacyStatementUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedPrivacyStatementUri = new Uri("https://privacy2.url/");

            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, changedPrivacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_False_From_Application_Equals_When_TermsOfServiceUri_Property_Value_Is_Different()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var changedTermsOfServiceUri = new Uri("https://tos2.url/");

            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, changedTermsOfServiceUri, privacyStatementUri);
            var expectedResult = false;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Same_Entity_From_Application_Copy()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedResult = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            // act
            var result = expectedResult with { };

            // assert
            Assert.IsFalse(object.ReferenceEquals(result, expectedResult));
            Assert.AreEqual(expectedResult.ApplicationId, result.ApplicationId);
            Assert.AreEqual(expectedResult.Name, result.Name);
            Assert.AreEqual(expectedResult.CompanyName, result.CompanyName);
            Assert.AreEqual(expectedResult.CompanyShortName, result.CompanyShortName);
            Assert.AreEqual(expectedResult.Authors, result.Authors);
            Assert.AreEqual(expectedResult.OriginalCopyrightYear, result.OriginalCopyrightYear);
            Assert.AreEqual(expectedResult.ApplicationUri, result.ApplicationUri);
            Assert.AreEqual(expectedResult.LicenseUri, result.LicenseUri);
            Assert.AreEqual(expectedResult.TermsOfServiceUri, result.TermsOfServiceUri);
            Assert.AreEqual(expectedResult.PrivacyStatementUri, result.PrivacyStatementUri);
        }

        [TestMethod]
        public void Returns_Same_HashCode_From_Application_GetHashCode_When_Property_Value_Are_The_Same()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);
            var expectedResult = source1.GetHashCode();

            // act
            var result = source2.GetHashCode();

            // assert
            Assert.AreEqual(source1, source2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_True_From_Application_Equals_When_All_Property_Values_Are_The_Same()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var applicationUri = new Uri("https://test.url/");
            var authors = "Authors1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var licenseUri = new Uri("https://license.url/");
            var name = "Name1";
            var originalCopyrightYear = 1989;
            var privacyStatementUri = new Uri("https://privacy.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var source1 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var source2 = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            var expectedResult = true;

            // act
            var result = source1.Equals(source2);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns_Valid_Application_From_Application_Constructor()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            // act
            var result = new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri);

            // assert
            Assert.AreEqual(applicationId, result.ApplicationId);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(companyName, result.CompanyName);
            Assert.AreEqual(companyShortName, result.CompanyShortName);
            Assert.AreEqual(authors, result.Authors);
            Assert.AreEqual(originalCopyrightYear, result.OriginalCopyrightYear);
            Assert.AreEqual(applicationUri, result.ApplicationUri);
            Assert.AreEqual(licenseUri, result.LicenseUri);
            Assert.AreEqual(termsOfServiceUri, result.TermsOfServiceUri);
            Assert.AreEqual(privacyStatementUri, result.PrivacyStatementUri);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_Authors_Is_Empty()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = string.Empty;
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(authors);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_CompanyName_Is_Empty()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = string.Empty;
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(companyName);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_CompanyShortName_Is_Empty()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = string.Empty;
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(companyShortName);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_Name_Is_Empty()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = string.Empty;
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_ApplicationUri_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = null as Uri;
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(applicationUri);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_Authors_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = null as string;
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(authors);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_CompanyName_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = null as string;
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(companyName);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_CompanyShortName_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = null as string;
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(companyShortName);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_LicenseUri_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = null as Uri;
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(licenseUri);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_Name_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = null as string;
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_PrivacyStatementUri_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = null as Uri;

            var expectedParamName = nameof(privacyStatementUri);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentNullException_From_Application_Constructor_When_Property_TermsOfServiceUri_Is_Null()
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = null as Uri;
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(termsOfServiceUri);

            // act
            var result = Assert.ThrowsException<ArgumentNullException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        public void Throws_ArgumentOutOfRangeException_From_Application_Constructor_When_Property_ApplicationId_Is_Empty_Guid()
        {
            // arrange
            var applicationId = Guid.Empty;
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(applicationId);

            // act
            var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_Authors_Is_WhiteSpace(string authors)
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(authors);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(authors, result.ActualValue);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_CompanyName_Is_WhiteSpace(string companyName)
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(companyName);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(companyName, result.ActualValue);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_CompanyShortName_Is_WhiteSpace(string companyShortName)
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var name = "Name1";
            var companyName = "CompanyName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(companyShortName);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(companyShortName, result.ActualValue);
        }

        [TestMethod]
        [DataRow("  ")]
        [DataRow("\r\n")]
        [DataRow("")]
        [DataRow("\t   \r    \n")]
        public void Throws_ArgumentWhiteSpaceException_From_Application_Constructor_When_Property_Name_Is_WhiteSpace(string name)
        {
            // arrange
            var applicationId = new Guid("b04b25dd-a1f6-40d5-983c-76e1e81a4afe");
            var companyName = "CompanyName1";
            var companyShortName = "CompanyShortName1";
            var authors = "Authors1";
            var originalCopyrightYear = 1989;
            var applicationUri = new Uri("https://test.url/");
            var licenseUri = new Uri("https://license.url/");
            var termsOfServiceUri = new Uri("https://tos.url/");
            var privacyStatementUri = new Uri("https://privacy.url/");

            var expectedParamName = nameof(name);

            // act
            var result = Assert.ThrowsException<ArgumentWhiteSpaceException>(() => new Application(applicationId, name, companyName, companyShortName, authors, originalCopyrightYear, applicationUri, licenseUri, termsOfServiceUri, privacyStatementUri));

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedParamName, result.ParamName);
            Assert.AreEqual(name, result.ActualValue);
        }
    }
}