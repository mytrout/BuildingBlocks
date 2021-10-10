// <copyright file="Application.cs" company="Chris Trout">
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
// </copyright>

namespace MyTrout.BuildingBlocks.Core.Models
{
    using MyTrout.BuildingBlocks.Core;
    using System;

    /// <summary>
    /// Describes the application being created.
    /// </summary>
    public record Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class with the specified values.
        /// </summary>
        /// <param name="applicationId">a unique identifier.</param>
        /// <param name="name">a unique application name.</param>
        /// <param name="companyName">the name of the application owner.</param>
        /// <param name="companyShortName">the short name of the application owner.</param>
        /// <param name="authors">a comma-delimited list of the authors who wrote this application.</param>
        /// <param name="originalCopyrightYear">the initial year of the copyright.</param>
        /// <param name="applicationUri">the Uri through which this application is accessed.</param>
        /// <param name="licenseUri">the <see cref="Uri" /> to the software license.</param>
        /// <param name="termsOfServiceUri">the <see cref="Uri" /> to the Terms of Service.</param>
        /// <param name="privacyStatementUri">the <see cref="Uri" /> to the Privacy Statement.</param>
        public Application(Guid applicationId, string name, string companyName, string companyShortName, string authors, int originalCopyrightYear, Uri applicationUri, Uri licenseUri, Uri termsOfServiceUri, Uri privacyStatementUri)
        {
            if (applicationId == Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(applicationId), applicationId, null);
            }

            this.ApplicationId = applicationId;

            if (name != null && string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentWhiteSpaceException(nameof(name), name as object);
            }

            this.Name = name ?? throw new ArgumentNullException(nameof(name));

            if (companyName != null && string.IsNullOrWhiteSpace(companyName))
            {
                throw new ArgumentWhiteSpaceException(nameof(companyName), companyName as object);
            }

            this.CompanyName = companyName ?? throw new ArgumentNullException(nameof(companyName));

            if (companyShortName != null && string.IsNullOrWhiteSpace(companyShortName))
            {
                throw new ArgumentWhiteSpaceException(nameof(companyShortName), companyShortName as object);
            }

            this.CompanyShortName = companyShortName ?? throw new ArgumentNullException(nameof(companyShortName));

            if (authors != null && string.IsNullOrWhiteSpace(authors))
            {
                throw new ArgumentWhiteSpaceException(nameof(authors), authors as object);
            }

            this.Authors = authors ?? throw new ArgumentNullException(nameof(authors));
            this.OriginalCopyrightYear = originalCopyrightYear;
            this.ApplicationUri = applicationUri ?? throw new ArgumentNullException(nameof(applicationUri));
            this.LicenseUri = licenseUri ?? throw new ArgumentNullException(nameof(licenseUri));
            this.TermsOfServiceUri = termsOfServiceUri ?? throw new ArgumentNullException(nameof(termsOfServiceUri));
            this.PrivacyStatementUri = privacyStatementUri ?? throw new ArgumentNullException(nameof(privacyStatementUri));
        }

        /// <summary>
        /// Gets a unique identifier.
        /// </summary>
        /// <value>
        /// a unique identifier.
        /// </value>
        public Guid ApplicationId
        {
            get;
        }

        /// <summary>
        /// Gets the Uri through which this application is accessed.
        /// </summary>
        /// <value>
        /// the Uri through which this application is accessed.
        /// </value>
        public Uri ApplicationUri
        {
            get;
        }

        /// <summary>
        /// Gets a comma-delimited list of the authors who wrote this application.
        /// </summary>
        /// <value>
        /// a comma-delimited list of the authors who wrote this application.
        /// </value>
        public string Authors
        {
            get;
        }

        /// <summary>
        /// Gets the name of the application owner.
        /// </summary>
        /// <value>
        /// the name of the application owner.
        /// </value>
        public string CompanyName
        {
            get;
        }

        /// <summary>
        /// Gets the short name of the application owner.
        /// </summary>
        /// <value>
        /// the short name of the application owner.
        /// </value>
        public string CompanyShortName
        {
            get;
        }

        /// <summary>
        /// Gets the <see cref="Uri" /> to the software license.
        /// </summary>
        /// <value>
        /// the <see cref="Uri" /> to the software license.
        /// </value>
        public Uri LicenseUri
        {
            get;
        }

        /// <summary>
        /// Gets a unique application name.
        /// </summary>
        /// <value>
        /// a unique application name.
        /// </value>
        public string Name
        {
            get;
        }

        /// <summary>
        /// Gets the initial year of the copyright.
        /// </summary>
        /// <value>
        /// the initial year of the copyright.
        /// </value>
        public int OriginalCopyrightYear
        {
            get;
        }

        /// <summary>
        /// Gets the <see cref="Uri" /> to the Privacy Statement.
        /// </summary>
        /// <value>
        /// the <see cref="Uri" /> to the Privacy Statement.
        /// </value>
        public Uri PrivacyStatementUri
        {
            get;
        }

        /// <summary>
        /// Gets the <see cref="Uri" /> to the Terms of Service.
        /// </summary>
        /// <value>
        /// the <see cref="Uri" /> to the Terms of Service.
        /// </value>
        public Uri TermsOfServiceUri
        {
            get;
        }
    }
}