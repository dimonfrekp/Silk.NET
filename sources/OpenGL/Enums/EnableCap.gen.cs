// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum EnableCap : uint
{
    LineSmooth = unchecked((uint)0x0B20),
    PolygonSmooth = unchecked((uint)0x0B41),
    CullFace = unchecked((uint)0x0B44),
    DepthTest = unchecked((uint)0x0B71),
    StencilTest = unchecked((uint)0x0B90),
    Dither = unchecked((uint)0x0BD0),
    Blend = unchecked((uint)0x0BE2),
    ScissorTest = unchecked((uint)0x0C11),
    Texture1D = unchecked((uint)0x0DE0),
    Texture2D = unchecked((uint)0x0DE1),
    ColorLogicOp = unchecked((uint)0x0BF2),
    PolygonOffsetPoint = unchecked((uint)0x2A01),
    PolygonOffsetLine = unchecked((uint)0x2A02),
    PolygonOffsetFill = unchecked((uint)0x8037),
    VertexArray = unchecked((uint)0x8074),
    Multisample = unchecked((uint)0x809D),
    SampleAlphaToCoverage = unchecked((uint)0x809E),
    SampleAlphaToOne = unchecked((uint)0x809F),
    SampleCoverage = unchecked((uint)0x80A0),
    TextureCubeMap = unchecked((uint)0x8513),
    ClipDistance0 = unchecked((uint)0x3000),
    ClipDistance1 = unchecked((uint)0x3001),
    ClipDistance2 = unchecked((uint)0x3002),
    ClipDistance3 = unchecked((uint)0x3003),
    ClipDistance4 = unchecked((uint)0x3004),
    ClipDistance5 = unchecked((uint)0x3005),
    ClipDistance6 = unchecked((uint)0x3006),
    ClipDistance7 = unchecked((uint)0x3007),
    RasterizerDiscard = unchecked((uint)0x8C89),
    FramebufferSrgb = unchecked((uint)0x8DB9),
    TextureRectAngle = unchecked((uint)0x84F5),
    PrimitiveRestart = unchecked((uint)0x8F9D),
    ProgramPointSize = unchecked((uint)0x8642),
    DepthClamp = unchecked((uint)0x864F),
    TextureCubeMapSeamless = unchecked((uint)0x884F),
    SampleMask = unchecked((uint)0x8E51),
    SampleShading = unchecked((uint)0x8C36),
    PrimitiveRestartFixedIndex = unchecked((uint)0x8D69),
    DebugOutputSynchronous = unchecked((uint)0x8242),
    DebugOutput = unchecked((uint)0x92E0),
    ShadingRateImagePerPrimitiveNV = unchecked((uint)0x95B1),
    PointSmooth = unchecked((uint)0x0B10),
    LineStipple = unchecked((uint)0x0B24),
    PolygonStipple = unchecked((uint)0x0B42),
    Lighting = unchecked((uint)0x0B50),
    ColorMaterial = unchecked((uint)0x0B57),
    Fog = unchecked((uint)0x0B60),
    Normalize = unchecked((uint)0x0BA1),
    AlphaTest = unchecked((uint)0x0BC0),
    TextureGenS = unchecked((uint)0x0C60),
    TextureGenT = unchecked((uint)0x0C61),
    TextureGenR = unchecked((uint)0x0C62),
    TextureGenQ = unchecked((uint)0x0C63),
    AutoNormal = unchecked((uint)0x0D80),
    Map1Color4 = unchecked((uint)0x0D90),
    Map1Index = unchecked((uint)0x0D91),
    Map1Normal = unchecked((uint)0x0D92),
    Map1TextureCoord1 = unchecked((uint)0x0D93),
    Map1TextureCoord2 = unchecked((uint)0x0D94),
    Map1TextureCoord3 = unchecked((uint)0x0D95),
    Map1TextureCoord4 = unchecked((uint)0x0D96),
    Map1Vertex3 = unchecked((uint)0x0D97),
    Map1Vertex4 = unchecked((uint)0x0D98),
    Map2Color4 = unchecked((uint)0x0DB0),
    Map2Index = unchecked((uint)0x0DB1),
    Map2Normal = unchecked((uint)0x0DB2),
    Map2TextureCoord1 = unchecked((uint)0x0DB3),
    Map2TextureCoord2 = unchecked((uint)0x0DB4),
    Map2TextureCoord3 = unchecked((uint)0x0DB5),
    Map2TextureCoord4 = unchecked((uint)0x0DB6),
    Map2Vertex3 = unchecked((uint)0x0DB7),
    Map2Vertex4 = unchecked((uint)0x0DB8),
    ClipPlane0 = unchecked((uint)0x3000),
    ClipPlane1 = unchecked((uint)0x3001),
    ClipPlane2 = unchecked((uint)0x3002),
    ClipPlane3 = unchecked((uint)0x3003),
    ClipPlane4 = unchecked((uint)0x3004),
    ClipPlane5 = unchecked((uint)0x3005),
    Light0 = unchecked((uint)0x4000),
    Light1 = unchecked((uint)0x4001),
    Light2 = unchecked((uint)0x4002),
    Light3 = unchecked((uint)0x4003),
    Light4 = unchecked((uint)0x4004),
    Light5 = unchecked((uint)0x4005),
    Light6 = unchecked((uint)0x4006),
    Light7 = unchecked((uint)0x4007),
    IndexLogicOp = unchecked((uint)0x0BF1),
    NormalArray = unchecked((uint)0x8075),
    ColorArray = unchecked((uint)0x8076),
    IndexArray = unchecked((uint)0x8077),
    TextureCoordArray = unchecked((uint)0x8078),
    EdgeFlagArray = unchecked((uint)0x8079),
    ColorTable = unchecked((uint)0x80D0),
    PostConvolutionColorTable = unchecked((uint)0x80D1),
    PostColorMatrixColorTable = unchecked((uint)0x80D2),
    TextureCubeMapARB = unchecked((uint)0x8513),
    TextureRectangleARB = unchecked((uint)0x84F5),
    Convolution1DEXT = unchecked((uint)0x8010),
    Convolution2DEXT = unchecked((uint)0x8011),
    Separable2DEXT = unchecked((uint)0x8012),
    HistogramEXT = unchecked((uint)0x8024),
    MinmaxEXT = unchecked((uint)0x802E),
    RescaleNormalEXT = unchecked((uint)0x803A),
    SharedTexturePaletteEXT = unchecked((uint)0x81FB),
    Texture3DEXT = unchecked((uint)0x806F),
    TextureCubeMapEXT = unchecked((uint)0x8513),
    TextureRectangleNV = unchecked((uint)0x84F5),
    MultisampleSGIS = unchecked((uint)0x809D),
    SampleAlphaToMaskSGIS = unchecked((uint)0x809E),
    SampleAlphaToOneSGIS = unchecked((uint)0x809F),
    SampleMaskSGIS = unchecked((uint)0x80A0),
    PixelTextureSGIS = unchecked((uint)0x8353),
    Texture4DSGIS = unchecked((uint)0x8134),
    AsyncHistogramSGIX = unchecked((uint)0x832C),
    AsyncTexImageSGIX = unchecked((uint)0x835C),
    AsyncDrawPixelsSGIX = unchecked((uint)0x835D),
    AsyncReadPixelsSGIX = unchecked((uint)0x835E),
    CalligraphicFragmentSGIX = unchecked((uint)0x8183),
    FogOffsetSGIX = unchecked((uint)0x8198),
    FragmentLightingSGIX = unchecked((uint)0x8400),
    FragmentColorMaterialSGIX = unchecked((uint)0x8401),
    FragmentLight0SGIX = unchecked((uint)0x840C),
    FragmentLight1SGIX = unchecked((uint)0x840D),
    FragmentLight2SGIX = unchecked((uint)0x840E),
    FragmentLight3SGIX = unchecked((uint)0x840F),
    FragmentLight4SGIX = unchecked((uint)0x8410),
    FragmentLight5SGIX = unchecked((uint)0x8411),
    FragmentLight6SGIX = unchecked((uint)0x8412),
    FragmentLight7SGIX = unchecked((uint)0x8413),
    FramezoomSGIX = unchecked((uint)0x818B),
    InterlaceSGIX = unchecked((uint)0x8094),
    IrInstrument1SGIX = unchecked((uint)0x817F),
    PixelTexGenSGIX = unchecked((uint)0x8139),
    ReferencePlaneSGIX = unchecked((uint)0x817D),
    SpriteSGIX = unchecked((uint)0x8148),
    ColorTableSGI = unchecked((uint)0x80D0),
    PostConvolutionColorTableSGI = unchecked((uint)0x80D1),
    PostColorMatrixColorTableSGI = unchecked((uint)0x80D2),
    TextureColorTableSGI = unchecked((uint)0x80BC),
    TextureCubeMapOES = unchecked((uint)0x8513),
    TextureGenStrOES = unchecked((uint)0x8D60),
    FetchPerSampleARM = unchecked((uint)0x8F65),
    FramebufferFetchNoncoherentQCOM = unchecked((uint)0x96A2),
    ShadingRatePreserveAspectRatioQCOM = unchecked((uint)0x96A5)
}
