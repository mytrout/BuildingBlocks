// <copyright file="CoreType.cs" company="Chris Trout">
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
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents a type within this system that can be derived from many different source (e.g. <see cref="Entity"/>, <see cref="Lookup"/> or standard .NET Types).
    /// </summary>
    public record CoreType
    {
        /// <summary>
        /// Represents an Unknown CoreType.
        /// </summary>
        public static readonly CoreType Unknown = new CoreType(Guid.Empty, "Unknown");

        private readonly string conceptName = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreType"/> class that is a concept.
        /// </summary>
        /// <param name="id">unique identifier for this concept.</param>
        /// <param name="conceptName">The concept name.</param>
        /// <remarks>This constructor is used by internal process in the BuildingBlocks application.</remarks>
        public CoreType(Guid id, string conceptName)
        {
            this.Id = id;
            this.conceptName = conceptName ?? throw new ArgumentNullException(nameof(conceptName));
            this.IsConcept = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreType"/> class that is derived from an <see cref="Entity"/>.
        /// </summary>
        /// <param name="entity">The <see cref="Entity"/> from which this type is derived.</param>
        /// <remarks>This constructor is used by internal process in the BuildingBlocks application.</remarks>
        public CoreType(Entity entity)
        {
            this.Entity = entity ?? throw new ArgumentNullException(nameof(entity));
            this.Id = this.Entity.EntityId;
            this.IsEntity = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreType"/> class that is derived from an <see cref="Entity"/>.
        /// </summary>
        /// <param name="arrayId">The unique identifier for an array of <see cref="Entity"/>.</param>
        /// <param name="entity">The <see cref="Entity"/> from which this type is derived.</param>
        public CoreType(Guid arrayId, Entity entity)
        {
            this.Id = arrayId;
            this.Entity = entity ?? throw new ArgumentNullException(nameof(entity));
            this.IsEntity = true;
            this.IsArray = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreType"/> class that is derived from an <see cref="Lookup"/>.
        /// </summary>
        /// <param name="lookup">The <see cref="Lookup"/> from which this type is derived.</param>
        /// <remarks>This constructor is used by internal process in the BuildingBlocks application.</remarks>
        public CoreType(Lookup lookup)
        {
            this.Lookup = lookup ?? throw new ArgumentNullException(nameof(lookup));
            this.Id = this.Lookup.LookupId;
            this.IsLookup = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreType"/> class that is a Generic Type.
        /// </summary>
        /// <param name="genericTypeId">The unique identifier for this custom Generic Type..</param>
        /// <param name="genericType">The generic type.</param>
        /// <param name="genericTypeParameters">The parameters for the Generic Type.</param>
        public CoreType(Guid genericTypeId, CoreType genericType, params CoreType[] genericTypeParameters)
        {
            this.GenericType = genericType ?? throw new ArgumentNullException(nameof(genericType));

            if (genericTypeParameters != null && !genericTypeParameters.Any())
            {
                throw new ArgumentOutOfRangeException(nameof(genericTypeParameters), genericTypeParameters, Resources.GENERIC_ONE_ENTRY(CultureInfo.CurrentUICulture, nameof(genericTypeParameters)));
            }

            if (genericTypeParameters != null && genericTypeParameters.Any(x => x == null))
            {
                throw new ArgumentOutOfRangeException(nameof(genericTypeParameters), genericTypeParameters, Resources.GENERIC_NOT_NULL(CultureInfo.CurrentUICulture, nameof(genericTypeParameters)));
            }

            if (genericTypeParameters != null && genericType.InternalType.IsGenericType && genericType.InternalType.GetGenericArguments().Length != genericTypeParameters.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(genericTypeParameters), genericTypeParameters, Resources.GENERIC_PARAMETERS_COUNT_MATCH(CultureInfo.CurrentUICulture, nameof(genericTypeParameters), nameof(genericType)));
            }

            this.GenericTypeParameters = genericTypeParameters ?? throw new ArgumentNullException(nameof(genericTypeParameters));
            this.Id = genericTypeId;
            this.IsGeneric = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreType"/> class that is derived from a regular .NET <see cref="Type"/>.
        /// </summary>
        /// <param name="internalType">The <see cref="Type"/> from which this <see cref="CoreType"/> is derived.</param>
        public CoreType(Type internalType)
        {
            this.InternalType = internalType ?? throw new ArgumentNullException(nameof(internalType));
            this.IsPrimitive = internalType.IsPrimitive;
            this.IsValueType = this.InternalType.IsValueType;
            this.Id = internalType.GUID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreType"/> class that is derived from a regular .NET <see cref="Type"/>.
        /// </summary>
        /// <param name="internalType">The <see cref="Type"/> from which this <see cref="CoreType"/> is derived.</param>
        /// <param name="arrayGuid">The unique identifier for an array of <see cref="Entity"/>.</param>
        public CoreType(Guid arrayGuid, Type internalType)
        {
            this.InternalType = internalType ?? throw new ArgumentNullException(nameof(internalType));
            this.IsPrimitive = internalType.IsPrimitive;
            this.IsValueType = this.InternalType.IsValueType;
            this.IsArray = true;
            this.Id = arrayGuid;
        }

        /// <summary>
        /// Gets the <see cref="CoreType"/> representing an <see cref="Entity" />.
        /// </summary>
        /// <value>
        /// the <see cref="CoreType"/> representing an <see cref="Entity" />.
        /// </value>
        /// <remarks>
        /// This property is for internal BuildingBlocks application use only.
        /// </remarks>
        public Entity Entity { get; }

        /// <summary>
        /// Gets the <see cref="CoreType"/> representing the Generic Type.
        /// </summary>
        /// <value>
        /// the <see cref="CoreType"/> representing the Generic Type.
        /// </value>
        public CoreType GenericType { get; }

        /// <summary>
        /// Gets a list of <see cref="CoreType"/> instances representing the parameters for the Generic Type.
        /// </summary>
        /// <value>a list of <see cref="CoreType"/> instances representing the parameters for the Generic Type.</value>
        public IEnumerable<CoreType> GenericTypeParameters { get; }

        /// <summary>
        /// Gets a unique identifier assigned to this <see cref="CoreType"/>.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Gets the <see cref="Type"/> from which this <see cref="CoreType"/> is derived.
        /// </summary>
        /// <value>
        /// the <see cref="Type"/> from which this <see cref="CoreType"/> is derived.
        /// </value>
        public Type InternalType { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="CoreType"/> is an array.
        /// </summary>
        /// <value>
        /// a value indicating whether this <see cref="CoreType"/> is an array.
        /// </value>
        public bool IsArray { get; } = false;

        /// <summary>
        /// Gets a value indicating whether this <see cref="CoreType"/> is a Concept.
        /// </summary>
        /// <value>
        /// a value indicating whether this <see cref="CoreType"/> is a Concept.
        /// </value>
        public bool IsConcept { get; } = false;

        /// <summary>
        /// Gets a value indicating whether this <see cref="CoreType"/> is derived from an <see cref="Entity" />.
        /// </summary>
        /// <value>
        /// a value indicating whether this <see cref="CoreType"/> is derived from an <see cref="Entity" />.
        /// </value>
        public bool IsEntity { get; } = false;

        /// <summary>
        /// Gets a value indicating whether this <see cref="CoreType"/> is a generic type.
        /// </summary>
        /// <value>
        /// a value indicating whether this <see cref="CoreType"/> is a generic type.
        /// </value>
        public bool IsGeneric { get; } = false;

        /// <summary>
        /// Gets a value indicating whether this <see cref="CoreType" /> is a <see cref="Lookup"/>.
        /// </summary>
        /// <value>
        /// a value indicating whether this <see cref="CoreType" /> is a <see cref="Lookup"/>.
        /// </value>
        public bool IsLookup { get; } = false;

        /// <summary>
        /// Gets a value indicating whether this <see cref="CoreType"/> is a primitive type.
        /// </summary>
        /// <value>
        /// a value indicating whether this <see cref="CoreType"/> is a primitive type.
        /// </value>
        public bool IsPrimitive { get; } = false;

        /// <summary>
        /// Gets a value indicating whether this <see cref="CoreType"/> is a value type.
        /// </summary>
        /// <value>
        /// a value indicating whether this <see cref="CoreType"/> is a value type.
        /// </value>
        public bool IsValueType { get; } = false;

        /// <summary>
        /// Gets the <see cref="CoreType"/> representing a <see cref="Lookup" />.
        /// </summary>
        /// <value>
        /// the <see cref="CoreType"/> representing a <see cref="Lookup" />.
        /// </value>
        /// <remarks>
        /// This property is for internal BuildingBlocks application use only.
        /// </remarks>
        public Lookup Lookup { get; init; }

        /// <summary>
        /// Gets a <see cref="string" /> representation of the name of the <see cref="CoreType"/>.
        /// </summary>
        /// <value>
        /// a <see cref="string" /> representation of the name of the <see cref="CoreType"/>.
        /// </value>
        /// <exception cref="InvalidOperationException">Throw when the <see cref="CoreType"/> has not been converted from a self-reference <see cref="CoreType" /> to the actual representation.</exception>
        public string Name
        {
            get
            {
                string workingName = this.conceptName ?? this.Entity?.Name ?? this.InternalType?.Name ?? this.Lookup?.Name;

                if (this.IsGeneric)
                {
                    workingName = this.ConvertToGenericTypeName();
                }

                if (this.IsArray)
                {
                    return $"{workingName}[]";
                }
                else
                {
                    return workingName;
                }
            }
        }

        /// <summary>
        /// Gets the primary namespace of the <see cref="CoreType"/>.
        /// </summary>
        /// <value>
        /// the primary namespace of the <see cref="CoreType"/>.
        /// </value>
        /// <remarks>
        /// This property currently does not reflect the full namespace list of generic parameters to a Generic Type.
        /// </remarks>
        public string Namespace
        {
            get
            {
                return this.InternalType?.Namespace
                    ?? this.GenericType?.Namespace
                    ?? string.Empty;
            }
        }

        /// <summary>
        /// Converts a <see cref="CoreType"/> into a <see cref="string"/> representation of the Generic Type.
        /// </summary>
        /// <returns>a <see cref="string"/> representation of the Generic Type.</returns>
        private string ConvertToGenericTypeName()
        {
            var fullTypeName = new StringBuilder();
            fullTypeName.Append(this.GenericType.InternalType.Name.Substring(0, this.GenericType.InternalType.Name.IndexOf('`', StringComparison.OrdinalIgnoreCase)));
            fullTypeName.Append('<');

            // Using 1-based indexing because this value is changed AFTER the comparison
            // and the comparison is LESS THAN the Count() to determine whether to add the comma.
            int currentParameter = 1;
            int parameterCount = this.GenericTypeParameters.Count();

            foreach (CoreType genericParameter in this.GenericTypeParameters)
            {
                fullTypeName.Append(genericParameter.Name);

                // Attempting to simplify this check by comparing genericParameter to this.GenericParameters.Last()
                // will always fail when the parameters are the same type (such as Dictionary<string,string>)
                // because CoreType uses value semantics, which means using parameter indexing is required.
                if (currentParameter < parameterCount)
                {
                    fullTypeName.Append(',');
                }

                currentParameter++;
            }

            fullTypeName.Append('>');
            return fullTypeName.ToString();
        }
    }
}
