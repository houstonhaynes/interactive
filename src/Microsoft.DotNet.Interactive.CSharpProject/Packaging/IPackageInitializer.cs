// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Interactive.CSharpProject.Packaging;

public interface IPackageInitializer
{
    Task InitializeAsync(DirectoryInfo directory);
}