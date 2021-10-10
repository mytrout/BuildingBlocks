// <copyright file="Concept.cs" company="Chris Trout">
// MIT License
//
// Copyright(c) 2021 Chris Trout
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
    using System;

    /// <summary>
    /// Represents a Concept within this system that is not currently defined as an <see cref="Entity"/>, <see cref="Lookup"/>, or represented by a .NET Type.
    /// </summary>
    public record Concept
    {
        /// <summary>
        /// Represents an Unknown CoreType.
        /// </summary>
        public static readonly Concept Unknown = new Concept(Guid.Empty, "Unknown");

        /// <summary>
        /// Initializes a new instance of the <see cref="Concept" /> class with the specified values.
        /// </summary>
        /// <param name="id">a unique identifier.</param>
        /// <param name="name">the name of the item.</param>
        public Concept(Guid id, string name)
        {
            this.ConceptId = id;

            if (name != null && string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentWhiteSpaceException(nameof(name), name as object);
            }

            this.Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Gets a unique identifier.
        /// </summary>
        /// <value>
        /// a unique identifier.
        /// </value>
        public Guid ConceptId { get; init; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        /// <value>
        /// the name of the item.
        /// </value>
        public string Name { get; init; }
    }
}
