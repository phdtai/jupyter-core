// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Jupyter.Core
{
    public struct ExecutionResult
    {
        public ExecuteStatus Status;
        public object Output;

        public static ExecutionResult Failed => new ExecutionResult
        {
            Status = ExecuteStatus.Error,
            Output = null
        };

        public static ExecutionResult Aborted => new ExecutionResult
        {
            Status = ExecuteStatus.Abort,
            Output = null
        };
    }

}
