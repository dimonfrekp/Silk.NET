// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FogCoordSrc")]
    public enum FogCoordSrc : int
    {
        [NativeName("Name", "GL_FOG_COORDINATE_EXT")]
        FogCoordinateExt = 0x8451,
        [NativeName("Name", "GL_FRAGMENT_DEPTH_EXT")]
        FragmentDepthExt = 0x8452,
    }
}
