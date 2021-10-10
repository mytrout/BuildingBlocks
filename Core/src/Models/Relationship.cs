// <copyright file="Relationship.cs" company="Chris Trout">
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
    using System;

    /// <summary>
    /// Represent a relationship between two <see cref="CoreType" /> instances and their respective <see cref="Cardinality" /> and <see cref="Modality" />.
    /// </summary>
    public record Relationship
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class with the specified values.
        /// </summary>
        /// <param name="relationshipId">a unique identifier.</param>
        /// <param name="primaryType">the <see cref="CoreType" /> on the primary side.</param>
        /// <param name="modality">a flag indicating optional or required.</param>
        /// <param name="cardinality">the maximum number of items on the secondary side.</param>
        /// <param name="secondaryCoreType">the <see cref="CoreType" /> on the secondary side.</param>
        /// <param name="modifiers">modifiers that change <see cref="Relationship" /> behavior.</param>
        public Relationship(Guid relationshipId, CoreType primaryType, RelationshipModality modality, RelationshipCardinality cardinality, CoreType secondaryCoreType, RelationshipModifiers modifiers = RelationshipModifiers.None)
        {
            if (relationshipId == Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(relationshipId), relationshipId, null);
            }

            this.RelationshipId = relationshipId;
            this.PrimaryType = primaryType ?? throw new ArgumentNullException(nameof(primaryType));
            this.Modality = modality;
            this.Cardinality = cardinality;
            this.SecondaryCoreType = secondaryCoreType ?? throw new ArgumentNullException(nameof(secondaryCoreType));
            this.Modifiers = modifiers;
        }

        /// <summary>
        /// Gets the maximum number of items on the secondary side.
        /// </summary>
        /// <value>
        /// the maximum number of items on the secondary side.
        /// </value>
        public RelationshipCardinality Cardinality
        {
            get;
        }

        /// <summary>
        /// Gets a flag indicating optional or required.
        /// </summary>
        /// <value>
        /// a flag indicating optional or required.
        /// </value>
        public RelationshipModality Modality
        {
            get;
        }

        /// <summary>
        /// Gets modifiers that change <see cref="Relationship" /> behavior.
        /// </summary>
        /// <value>
        /// modifiers that change <see cref="Relationship" /> behavior.
        /// </value>
        public RelationshipModifiers Modifiers
        {
            get;
        }

        /// <summary>
        /// Gets the <see cref="CoreType" /> on the primary side.
        /// </summary>
        /// <value>
        /// the <see cref="CoreType" /> on the primary side.
        /// </value>
        public CoreType PrimaryType
        {
            get;
        }

        /// <summary>
        /// Gets a unique identifier.
        /// </summary>
        /// <value>
        /// a unique identifier.
        /// </value>
        public Guid RelationshipId
        {
            get;
        }

        /// <summary>
        /// Gets the <see cref="CoreType" /> on the secondary side.
        /// </summary>
        /// <value>
        /// the <see cref="CoreType" /> on the secondary side.
        /// </value>
        public CoreType SecondaryCoreType
        {
            get;
        }
    }
}