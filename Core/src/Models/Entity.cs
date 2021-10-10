// <copyright file="Entity.cs" company="Chris Trout">
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
    /// Describes a core class within the new application.
    /// </summary>
    public record Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class with the specified values.
        /// </summary>
        /// <param name="entityId">a unique identifier.</param>
        /// <param name="name">the name of the item.</param>
        /// <param name="description">the description used by internal documentation.</param>
        /// <param name="modifiers">modifiers that change <see cref="Entity" /> behavior.</param>
        /// <param name="primaryPrimeNumberForHash">the prime number to initialize GetHashCode().</param>
        /// <param name="secondaryPrimeNumberForHash">the prime number to use on each field in GetHashCode().</param>
        /// <param name="baseCoreType">the Base CoreType for this Entity or <see langword="null" />.</param>
        /// <param name="fields">fields of the item.</param>
        public Entity(Guid entityId, string name, string description, EntityModifiers modifiers, int primaryPrimeNumberForHash, int secondaryPrimeNumberForHash, CoreType baseCoreType = null, params Field[] fields)
        {
            if (entityId == Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(entityId), entityId, null);
            }

            this.EntityId = entityId;

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
            this.PrimaryPrimeNumberForHash = primaryPrimeNumberForHash;
            this.SecondaryPrimeNumberForHash = secondaryPrimeNumberForHash;
            this.BaseCoreType = baseCoreType;
            this.Fields = fields ?? throw new ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Gets the Base CoreType for this Entity or <see langword="null" />.
        /// </summary>
        /// <value>
        /// the Base CoreType for this Entity or <see langword="null" />.
        /// </value>
        public CoreType BaseCoreType
        {
            get;
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
        /// Gets a unique identifier.
        /// </summary>
        /// <value>
        /// a unique identifier.
        /// </value>
        public Guid EntityId
        {
            get;
        }

        /// <summary>
        /// Gets fields of the item.
        /// </summary>
        /// <value>
        /// fields of the item.
        /// </value>
        public IEnumerable<Field> Fields
        {
            get;
        }

        /// <summary>
        /// Gets modifiers that change <see cref="Entity" /> behavior.
        /// </summary>
        /// <value>
        /// modifiers that change <see cref="Entity" /> behavior.
        /// </value>
        public EntityModifiers Modifiers
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

        /// <summary>
        /// Gets the prime number to initialize GetHashCode().
        /// </summary>
        /// <value>
        /// the prime number to initialize GetHashCode().
        /// </value>
        public int PrimaryPrimeNumberForHash
        {
            get;
        }

        /// <summary>
        /// Gets the prime number to use on each field in GetHashCode().
        /// </summary>
        /// <value>
        /// the prime number to use on each field in GetHashCode().
        /// </value>
        public int SecondaryPrimeNumberForHash
        {
            get;
        }
    }
}