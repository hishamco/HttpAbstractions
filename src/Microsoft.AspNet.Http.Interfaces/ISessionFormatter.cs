// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNet.Http
{
    /// <summary>
    /// Provides functionality for formatting serialized objects.
    /// </summary>
    public interface ISessionFormatter<T>
    {
        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <returns>The serialized data</returns>
        byte[] Serialize(T value);

        /// <summary>
        /// Deserializes the data and reconstitutes the object.
        /// </summary>
        /// <returns>The object of the deserialized data.</returns>
        T Deserialize(byte[] data);
    }
}