// <copyright file="Field.cs" company="Chris Trout">
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
    /// Describes a core field within a class.
    /// </summary>
    public record Field
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class with the specified values.
        /// </summary>
        /// <param name="fieldId">a unique identifier.</param>
        /// <param name="fieldType">a .NET Type.</param>
        /// <param name="name">the name of the item.</param>
        /// <param name="shortDescription">the description used by internal documentation.</param>
        /// <param name="modifiers">modifiers that change field behavior.</param>
        /// <param name="optionalValue">a default value for an optional field.</param>
        public Field(Guid fieldId, CoreType fieldType, string name, string shortDescription, FieldModifiers modifiers = FieldModifiers.None, object optionalValue = null)
            : this()
        {
            if (fieldId == Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(fieldId), fieldId, null);
            }

            this.FieldId = fieldId;
            this.FieldType = fieldType ?? throw new ArgumentNullException(nameof(fieldType));

            if (name != null && string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentWhiteSpaceException(nameof(name), name as object);
            }

            this.Name = name ?? throw new ArgumentNullException(nameof(name));

            if (shortDescription != null && string.IsNullOrWhiteSpace(shortDescription))
            {
                throw new ArgumentWhiteSpaceException(nameof(shortDescription), shortDescription as object);
            }

            this.ShortDescription = shortDescription ?? throw new ArgumentNullException(nameof(shortDescription));
            this.Modifiers = modifiers;
            this.OptionalValue = optionalValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Field" /> class.
        /// </summary>
        protected Field()
        {
            // no op
        }

        /// <summary>
        /// Gets a unique identifier.
        /// </summary>
        /// <value>
        /// a unique identifier.
        /// </value>
        public virtual Guid FieldId
        {
            get;
        }

        /// <summary>
        /// Gets a .NET Type.
        /// </summary>
        /// <value>
        /// a .NET Type.
        /// </value>
        public virtual CoreType FieldType
        {
            get;
        }

        /// <summary>
        /// Gets modifiers that change field behavior.
        /// </summary>
        /// <value>
        /// modifiers that change field behavior.
        /// </value>
        public virtual FieldModifiers Modifiers
        {
            get;
        }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        /// <value>
        /// the name of the item.
        /// </value>
        public virtual string Name
        {
            get;
        }

        /// <summary>
        /// Gets a default value for an optional field.
        /// </summary>
        /// <value>
        /// a default value for an optional field.
        /// </value>
        public virtual object OptionalValue
        {
            get;
        }

        /// <summary>
        /// Gets the description used by internal documentation.
        /// </summary>
        /// <value>
        /// the description used by internal documentation.
        /// </value>
        public virtual string ShortDescription
        {
            get;
        }
    }
}