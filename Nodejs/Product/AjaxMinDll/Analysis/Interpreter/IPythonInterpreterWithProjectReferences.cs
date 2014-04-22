﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.NodejsTools.Interpreter {
#if FALSE
    public interface IPythonInterpreterWithProjectReferences {
        /// <summary>
        /// Asynchronously loads the assocated project reference into the interpreter.
        /// 
        /// Returns a new task which can be waited upon for completion of the reference being added.
        /// </summary>
        /// <remarks>New in 2.0.</remarks>
        Task AddReferenceAsync(ProjectReference reference, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Removes the associated project reference from the interpreter.
        /// </summary>
        /// <remarks>New in 2.0.</remarks>
        void RemoveReference(ProjectReference reference);
    }
#endif
}
