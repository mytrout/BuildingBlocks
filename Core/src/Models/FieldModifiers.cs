// <copyright file="FieldModifiers.cs" company="Chris Trout">
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
    /// Provides the metadata to alter Field implementation.
    /// </summary>
    [Flags]
    public enum FieldModifiers
    {
        /// <summary>
        /// Indicates that a field has no modifiers.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that a field is optional.
        /// </summary><remarks><para>Fields are required by default, thus the Optional flag is the exceptional case.
        /// </para><para>If one <see cref="Field" /> is marked with this modifier, no other fields for the Class can be marked with <see cref="FieldModifiers.Params" />.
        /// </para></remarks>
        Optional = 1,

        /// <summary>
        /// Indicates that a field should use the params keyword in the constructor.
        /// </summary><remarks><para>This modifier applies to <see cref="Array" />-typed fields.
        /// </para><para>If one <see cref="Field" /> is marked with this modifier, no other fields for the Class can be marked with <see cref="FieldModifiers.Optional" />.
        /// </para></remarks>
        Params = 2,

        /// <summary>
        /// Indicates that a field is allowed to be <see langword="null" />.
        /// </summary><remarks><para>This modifier applies to <see cref="string" /> typed fields.
        /// </para></remarks>
        AllowNull = 4,

        /// <summary>
        /// Indicates that a field is allowed to be <see cref="Guid.Empty" /> or <see cref="string.Empty" />.
        /// </summary><remarks><para>This modifier applies to <see cref="string" /> and <see cref="System.Guid" /> typed fields.
        /// </para></remarks>
        AllowEmpty = 8,

        /// <summary>
        /// Indicates that a string field is allowed to contain only whitespace.
        /// </summary><remarks><para>This modifier applies to <see cref="string" />-typed fields.
        /// </para></remarks>
        AllowWhiteSpace = 16,

        /// <summary>
        /// Indicates that a field can be overridden.
        /// </summary>
        AllowFieldOverride = 32,

        /// <summary>
        /// Indicates that this <see cref="Field" /> is the decorated see cref="Field" />.
        /// </summary>
        Decorated = 64,

        /// <summary>
        /// Indicates that this <see cref="Field" /> is a part of an identifying key for its parent.
        /// </summary>
        Key = 128
    }
}