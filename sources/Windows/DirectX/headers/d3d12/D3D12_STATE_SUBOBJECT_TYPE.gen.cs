// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE"]/*'/>
public enum D3D12_STATE_SUBOBJECT_TYPE
{
    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG = 0,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE = 1,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE = 2,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK = 3,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY = 5,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION = 6,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION = 7,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION = 8,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG = 9,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG = 10,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP = 11,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1 = 12,

    /// <include file='D3D12_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_STATE_SUBOBJECT_TYPE.D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID"]/*'/>

    D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID =
        (D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1 + 1),
}
