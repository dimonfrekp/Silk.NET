// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ShaderType : uint
{
    FragmentShader = 0x8B30,
    VertexShader = 0x8B31,
    GeometryShader = 0x8DD9,
    TessEvaluationShader = 0x8E87,
    TessControlShader = 0x8E88,
    ComputeShader = 0x91B9,
    FragmentShaderARB = 0x8B30,
    VertexShaderARB = 0x8B31
}
