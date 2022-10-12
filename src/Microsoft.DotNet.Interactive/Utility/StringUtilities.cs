﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.Utility;

public static class StringUtilities
{
    public static string NormalizeLineEndings(this string source)
    {
        return source.Replace("\r\n", "\n");
    }
}
