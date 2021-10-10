// <copyright file="EntityModifiers.cs" company="Chris Trout">
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
    /// Provides the metdata to alter Entity implementation.
    /// </summary>
    [Flags]
    public enum EntityModifiers
    {
        /// <summary>
        /// Indicates that an entity has no modifiers.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that this <see cref="Entity" /> can be decorated by another <see cref="Entity" />.
        /// </summary>
        Decoratee = 1,

        /// <summary>
        /// Indicates that this <see cref="Entity" /> decorates another <see cref="Entity" />.
        /// </summary>
        Decorator = 2,

        /// <summary>
        /// Indicates that this <see cref="Entity" /> can be extended by the user via partial classes.
        /// </summary>
        Extensible = 4,

        /// <summary>
        /// Indicates that this <see cref="Entity" /> must implement value semantics using the record keyword.
        /// </summary>
        Record = 8
    }
}