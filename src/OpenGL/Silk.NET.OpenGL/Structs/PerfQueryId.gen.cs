// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "perf query id")]
    public unsafe partial struct PerfQueryId
    {
        public PerfQueryId
        (
            uint? handle = null
        ) : this()
        {
            if (handle is not null)
            {
                Handle = handle.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "")]
        public uint Handle;
    }
}
