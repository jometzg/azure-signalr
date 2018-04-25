// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Microsoft.Azure.SignalR
{
    public class ServiceOptions
    {
        // Connection string can be passed by setting this environment variable (default key)
        public static readonly string ConnectionStringDefaultKey = "Azure:SignalR:ConnectionString";

        internal static readonly int DefaultConnectionCount = 5;

        // The order to find connection string:
        // 1. options
        // 2. environment variable
        // Throw exception if 1 and 2 fail to find it.
        public string ConnectionString { get; set; } = null;

        public int ConnectionCount { get; set; } = DefaultConnectionCount;

        public Func<HttpContext, IEnumerable<Claim>> ClaimsProvider { get; set; } = null;
    }
}