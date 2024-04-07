// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelMap : uint
{
    IToI = 0x0C70,
    SToS = 0x0C71,
    IToR = 0x0C72,
    IToG = 0x0C73,
    IToB = 0x0C74,
    IToA = 0x0C75,
    RToR = 0x0C76,
    GToG = 0x0C77,
    BToB = 0x0C78,
    AToA = 0x0C79
}
