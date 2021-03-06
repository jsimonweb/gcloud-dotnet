﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using static Google.Datastore.V1Beta3.Key.Types;

namespace Google.Datastore.V1Beta3
{
    public partial class Key
    {
        /// <summary>
        /// Creates a new mutation representing a delete of this key.
        /// </summary>
        /// <returns></returns>
        public Mutation ToDelete() => new Mutation { Delete = this };

        /// <summary>
        /// Creates a clone of this key and appends the specified path element to the clone.
        /// </summary>
        /// <param name="pathElement">The path element to append. Must not be null.</param>
        /// <returns>A clone of this key, with the specified path element</returns>
        public Key WithElement(PathElement pathElement)
        {
            GaxPreconditions.CheckNotNull(pathElement, nameof(pathElement));
            var clone = Clone();
            clone.Path.Add(pathElement);
            return clone;
        }
    }
}
