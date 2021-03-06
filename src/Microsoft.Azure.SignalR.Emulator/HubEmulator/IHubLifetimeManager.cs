﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.SignalR;

namespace Microsoft.Azure.SignalR.Emulator.HubEmulator
{
    internal interface IHubLifetimeManager
    {
        HubConnectionStore Connections { get; }
    }
}
