// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureTarget : uint
{
    Texture1D = 0x0DE0,
    Texture2D = 0x0DE1,
    ProxyTexture1D = 0x8063,
    ProxyTexture2D = 0x8064,
    Texture3D = 0x806F,
    ProxyTexture3D = 0x8070,
    TextureCubeMap = 0x8513,
    TextureCubeMapPositiveX = 0x8515,
    TextureCubeMapNegativeX = 0x8516,
    TextureCubeMapPositiveY = 0x8517,
    TextureCubeMapNegativeY = 0x8518,
    TextureCubeMapPositiveZ = 0x8519,
    TextureCubeMapNegativeZ = 0x851A,
    ProxyTextureCubeMap = 0x851B,
    Texture1DArray = 0x8C18,
    ProxyTexture1DArray = 0x8C19,
    Texture2DArray = 0x8C1A,
    ProxyTexture2DArray = 0x8C1B,
    Renderbuffer = 0x8D41,
    TextureBuffer = 0x8C2A,
    TextureRectAngle = 0x84F5,
    ProxyTextureRectAngle = 0x84F7,
    Texture2DMultisample = 0x9100,
    ProxyTexture2DMultisample = 0x9101,
    Texture2DMultisampleArray = 0x9102,
    ProxyTexture2DMultisampleArray = 0x9103,
    TextureCubeMapArray = 0x9009,
    ProxyTextureCubeMapArray = 0x900B,
    TextureCubeMapArrayARB = 0x9009,
    ProxyTextureCubeMapArrayARB = 0x900B,
    TextureCubeMapARB = 0x8513,
    TextureCubeMapPositiveXARB = 0x8515,
    TextureCubeMapNegativeXARB = 0x8516,
    TextureCubeMapPositiveYARB = 0x8517,
    TextureCubeMapNegativeYARB = 0x8518,
    TextureCubeMapPositiveZARB = 0x8519,
    TextureCubeMapNegativeZARB = 0x851A,
    ProxyTextureCubeMapARB = 0x851B,
    TextureRectangleARB = 0x84F5,
    ProxyTextureRectangleARB = 0x84F7,
    ProxyTexture1DEXT = 0x8063,
    ProxyTexture2DEXT = 0x8064,
    Texture3DEXT = 0x806F,
    ProxyTexture3DEXT = 0x8070,
    ProxyTexture1DArrayEXT = 0x8C19,
    ProxyTexture2DArrayEXT = 0x8C1B,
    TextureCubeMapEXT = 0x8513,
    TextureCubeMapPositiveXEXT = 0x8515,
    TextureCubeMapNegativeXEXT = 0x8516,
    TextureCubeMapPositiveYEXT = 0x8517,
    TextureCubeMapNegativeYEXT = 0x8518,
    TextureCubeMapPositiveZEXT = 0x8519,
    TextureCubeMapNegativeZEXT = 0x851A,
    ProxyTextureCubeMapEXT = 0x851B,
    TextureRectangleNV = 0x84F5,
    ProxyTextureRectangleNV = 0x84F7,
    DetailTexture2DSGIS = 0x8095,
    Texture4DSGIS = 0x8134,
    ProxyTexture4DSGIS = 0x8135,
    TextureCubeMapOES = 0x8513,
    TextureCubeMapPositiveXOES = 0x8515,
    TextureCubeMapNegativeXOES = 0x8516,
    TextureCubeMapPositiveYOES = 0x8517,
    TextureCubeMapNegativeYOES = 0x8518,
    TextureCubeMapPositiveZOES = 0x8519,
    TextureCubeMapNegativeZOES = 0x851A,
    Texture3DOES = 0x806F,
    TextureCubeMapArrayOES = 0x9009,
    TextureCubeMapArrayEXT = 0x9009
}
