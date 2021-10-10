// <copyright file="Lookup.cs" company="Chris Trout">
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
    using System.Collections.Generic;

    /// <summary>
    /// Describes a list of hard-coded lookup items.
    /// </summary>
    public record Lookup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lookup" /> class with the specified values.
        /// </summary>
        /// <param name="lookupId">a unique indentifier.</param>
        /// <param name="name">the name of the item.</param>
        /// <param name="description">the description used by internal documentation.</param>
        /// <param name="modifiers">modifiers that can change Lookup behavior.</param>
        /// <param name="items">entries in the hard-coded Lookup.</param>
        public Lookup(Guid lookupId, string name, string description, LookupModifiers modifiers, params LookupItem[] items)
        {
            if (lookupId == Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(lookupId), lookupId, null);
            }

            this.LookupId = lookupId;

            if (name != null && string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentWhiteSpaceException(nameof(name), name as object);
            }

            this.Name = name ?? throw new ArgumentNullException(nameof(name));

            if (description != null && string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentWhiteSpaceException(nameof(description), description as object);
            }

            this.Description = description ?? throw new ArgumentNullException(nameof(description));
            this.Modifiers = modifiers;
            this.Items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Gets the description used by internal documentation.
        /// </summary>
        /// <value>
        /// the description used by internal documentation.
        /// </value>
        public string Description
        {
            get;
        }

        /// <summary>
        /// Gets entries in the hard-coded Lookup.
        /// </summary>
        /// <value>
        /// entries in the hard-coded Lookup.
        /// </value>
        public IEnumerable<LookupItem> Items
        {
            get;
        }

        /// <summary>
        /// Gets a unique indentifier.
        /// </summary>
        /// <value>
        /// a unique indentifier.
        /// </value>
        public Guid LookupId
        {
            get;
        }

        /// <summary>
        /// Gets modifiers that can change Lookup behavior.
        /// </summary>
        /// <value>
        /// modifiers that can change Lookup behavior.
        /// </value>
        public LookupModifiers Modifiers
        {
            get;
        }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        /// <value>
        /// the name of the item.
        /// </value>
        public string Name
        {
            get;
        }
    }
}