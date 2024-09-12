// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.Composition;
using Microsoft.Test.Apex.VisualStudio;
using NuGet.PackageManagement.VisualStudio;

namespace NuGet.Tests.Apex.Apex
{
    [Export(typeof(VisualStudioRegistryTestService))]
    public class VisualStudioRegistryTestService : VisualStudioTestService
    {
        public VisualStudioRegistryTestService()
        {
        }

        public bool GetBooleanRegistryValue(string key)
        {
            return RegistrySettingUtility.GetBooleanSetting(key);
        }

        public void SetBooleanRegistryValue(string key, bool value)
        {
            RegistrySettingUtility.SetBooleanSetting(key, value);
        }
    }
}
