// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

// ReSharper disable once CheckNamespace

namespace System.Reflection
{
    [DebuggerStepThrough]
    internal static class PropertyInfoExtensions
    {
        public static bool IsStatic(this PropertyInfo property) 
            => (property.GetMethod ?? property.SetMethod).IsStatic;
    }
}
