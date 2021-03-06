// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tags.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2011 Ninject Project Contributors
//   Authors: Remo Gloor (remo.gloor@gmail.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ninject.Extensions.Xml.Processors
{
    /// <summary>
    /// The tags of the processors in this extension.
    /// </summary>
    public static class Tags
    {
        /// <summary>
        /// Defines that the processor is for bindings.
        /// </summary>
        public const string Binding = "Binding";

        /// <summary>
        /// Defines that the binding can have a scope
        /// </summary>
        public const string HasScope = "HasScope";

        /// <summary>
        /// Defines the the binding can have meta data.
        /// </summary>
        public const string HasMetadata = "Metadata";

        /// <summary>
        /// Defines that the binding can have conditions.
        /// </summary>
        public const string HasCondition = "HasCondition";

        /// <summary>
        /// Defines that the binding can have a name.
        /// </summary>
        public const string HasName = "HasName";
    }
}