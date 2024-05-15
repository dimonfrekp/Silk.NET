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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class ErrorLogVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorLog> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorLog> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorLog> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorLog> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IErrorLog> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IErrorLog> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ExceptionInfo* pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropName, pExcepInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref ExceptionInfo pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropName, pExcepInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ExceptionInfo* pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref ExceptionInfo pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszPropNamePtr = &pszPropName)
        {
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ExceptionInfo* pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, byte*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfo);
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref ExceptionInfo pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, byte*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfoPtr);
        }
        SilkMarshal.Free((nint)pszPropNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IErrorLog> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorLog> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IErrorLog> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Span<ExceptionInfo> pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddError(pszPropName, ref pExcepInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, ExceptionInfo* pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddError(in pszPropName.GetPinnableReference(), pExcepInfo);
    }

    /// <summary>To be documented.</summary>
    public static int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pszPropName, Span<ExceptionInfo> pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddError(in pszPropName.GetPinnableReference(), ref pExcepInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddError(this ComPtr<IErrorLog> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Span<ExceptionInfo> pExcepInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddError(pszPropName, ref pExcepInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IErrorLog> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
