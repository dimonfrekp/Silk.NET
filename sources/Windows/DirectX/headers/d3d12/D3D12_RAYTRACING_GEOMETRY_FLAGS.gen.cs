// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_FLAGS"]/*'/>
[Flags]
public enum D3D12_RAYTRACING_GEOMETRY_FLAGS
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_FLAGS.D3D12_RAYTRACING_GEOMETRY_FLAG_NONE"]/*'/>

    D3D12_RAYTRACING_GEOMETRY_FLAG_NONE = 0,

    /// <include file='D3D12_RAYTRACING_GEOMETRY_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_FLAGS.D3D12_RAYTRACING_GEOMETRY_FLAG_OPAQUE"]/*'/>

    D3D12_RAYTRACING_GEOMETRY_FLAG_OPAQUE = 0x1,

    /// <include file='D3D12_RAYTRACING_GEOMETRY_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_FLAGS.D3D12_RAYTRACING_GEOMETRY_FLAG_NO_DUPLICATE_ANYHIT_INVOCATION"]/*'/>

    D3D12_RAYTRACING_GEOMETRY_FLAG_NO_DUPLICATE_ANYHIT_INVOCATION = 0x2,
}
