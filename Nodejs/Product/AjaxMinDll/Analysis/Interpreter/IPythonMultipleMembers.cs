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

using System.Collections.Generic;

namespace Microsoft.NodejsTools.Interpreter {
#if FALSE
    /// <summary>
    /// Represents a collection of multiple members which can appear under a single name.
    /// </summary>
    public interface IPythonMultipleMembers : IMember {
        IList<IMember> Members {
            get;
        }
    }
#endif
}
