// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Test.Apex.VisualStudio;
using NuGet.PackageManagement.UI;
using NuGet.Tests.Apex.Apex;

namespace NuGet.Tests.Apex.Fixtures
{
    public class ShowPreviewWindowFixture : IDisposable
    {
        VisualStudioRegistryTestService _registryTestService;
        bool _initialValue;

        public ShowPreviewWindowFixture(VisualStudioHost host, bool showWindow)
        {
            _registryTestService = host.Get<VisualStudioRegistryTestService>();

            _initialValue = _registryTestService.GetBooleanRegistryValue(Constants.DoNotShowPreviewWindowRegistryName);

            _registryTestService.SetBooleanRegistryValue(Constants.DoNotShowPreviewWindowRegistryName, !showWindow);
        }

        public void Dispose()
        {
            _registryTestService.SetBooleanRegistryValue(Constants.DoNotShowPreviewWindowRegistryName, _initialValue);
        }
    }
}
