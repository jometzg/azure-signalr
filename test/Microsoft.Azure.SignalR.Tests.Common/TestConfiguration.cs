﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Azure.SignalR.Tests.Common
{
    public class TestConfiguration
    {
        public static readonly TestConfiguration Instance = new TestConfiguration();

        private readonly IConfiguration _configuration;

        public string ConnectionString { get; private set; }

        protected TestConfiguration()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddUserSecrets<TestConfiguration>(optional: true)
                .AddJsonFile("appsettings.Test.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            Init();
        }

        private void Init()
        {
            ConnectionString = _configuration["Azure:SignalR:ConnectionString"];
        }
    }
}
