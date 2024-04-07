// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ImageTransformPNameHP : uint
{
    ScaleX = 0x8155,
    ScaleY = 0x8156,
    TranslateX = 0x8157,
    TranslateY = 0x8158,
    RotateAngle = 0x8159,
    RotateOriginX = 0x815A,
    RotateOriginY = 0x815B,
    MagFilter = 0x815C,
    MinFilter = 0x815D,
    CubicWeight = 0x815E
}
