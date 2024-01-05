// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS"]/*'/>
[Flags]
public enum D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS
{
    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE = 0x1,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING = 0x2,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT = 0x4,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION = 0x8,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING = 0x10,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION = 0x20,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION = 0x40,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING = 0x80,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM"]/*'/>

    D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM = unchecked((int)(0x80000000)),
}
