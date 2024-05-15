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

public unsafe static class TypeLib2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLib2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLib2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLib2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLib2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ITypeLib2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeLib2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetTypeInfoCount(this ComPtr<ITypeLib2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfo(this ComPtr<ITypeLib2> thisVtbl, uint index, ITypeInfo** ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint, ITypeInfo**, int>)@this->LpVtbl[4])(@this, index, ppTInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfo(this ComPtr<ITypeLib2> thisVtbl, uint index, ref ITypeInfo* ppTInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint, ITypeInfo**, int>)@this->LpVtbl[4])(@this, index, ppTInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoType(this ComPtr<ITypeLib2> thisVtbl, uint index, TypeKind* pTKind)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint, TypeKind*, int>)@this->LpVtbl[5])(@this, index, pTKind);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfoType(this ComPtr<ITypeLib2> thisVtbl, uint index, ref TypeKind pTKind)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TypeKind* pTKindPtr = &pTKind)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint, TypeKind*, int>)@this->LpVtbl[5])(@this, index, pTKindPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoOfGuid(this ComPtr<ITypeLib2> thisVtbl, Guid* guid, ITypeInfo** ppTinfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, ITypeInfo**, int>)@this->LpVtbl[6])(@this, guid, ppTinfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoOfGuid(this ComPtr<ITypeLib2> thisVtbl, Guid* guid, ref ITypeInfo* ppTinfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTinfoPtr = &ppTinfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, ITypeInfo**, int>)@this->LpVtbl[6])(@this, guid, ppTinfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoOfGuid(this ComPtr<ITypeLib2> thisVtbl, ref Guid guid, ITypeInfo** ppTinfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, ITypeInfo**, int>)@this->LpVtbl[6])(@this, guidPtr, ppTinfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoOfGuid(this ComPtr<ITypeLib2> thisVtbl, ref Guid guid, ref ITypeInfo* ppTinfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (ITypeInfo** ppTinfoPtr = &ppTinfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, ITypeInfo**, int>)@this->LpVtbl[6])(@this, guidPtr, ppTinfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibAttr(this ComPtr<ITypeLib2> thisVtbl, TLibAttr** ppTLibAttr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, TLibAttr**, int>)@this->LpVtbl[7])(@this, ppTLibAttr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibAttr(this ComPtr<ITypeLib2> thisVtbl, ref TLibAttr* ppTLibAttr)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TLibAttr** ppTLibAttrPtr = &ppTLibAttr)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, TLibAttr**, int>)@this->LpVtbl[7])(@this, ppTLibAttrPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeComp(this ComPtr<ITypeLib2> thisVtbl, ITypeComp** ppTComp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, ITypeComp**, int>)@this->LpVtbl[8])(@this, ppTComp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeComp(this ComPtr<ITypeLib2> thisVtbl, ref ITypeComp* ppTComp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeComp** ppTCompPtr = &ppTComp)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, ITypeComp**, int>)@this->LpVtbl[8])(@this, ppTCompPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocString, pdwHelpContextPtr, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
        {
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocString, pdwHelpContextPtr, pBstrHelpFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrDocStringPtr = &pBstrDocString)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrName, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, char** pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocString, pdwHelpContext, pBstrHelpFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocString, pdwHelpContextPtr, pBstrHelpFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, char** pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocString, pdwHelpContextPtr, pBstrHelpFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContext, pBstrHelpFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFile);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pBstrNamePtr = &pBstrName)
        {
            fixed (char** pBstrDocStringPtr = &pBstrDocString)
            {
                fixed (uint* pdwHelpContextPtr = &pdwHelpContext)
                {
                    fixed (char** pBstrHelpFilePtr = &pBstrHelpFile)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, char**, char**, uint*, char**, int>)@this->LpVtbl[9])(@this, index, pBstrNamePtr, pBstrDocStringPtr, pdwHelpContextPtr, pBstrHelpFilePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, int* pfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, int*, int>)@this->LpVtbl[10])(@this, szNameBuf, lHashVal, pfName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref int pfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfNamePtr = &pfName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, int*, int>)@this->LpVtbl[10])(@this, szNameBuf, lHashVal, pfNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, int* pfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, int*, int>)@this->LpVtbl[10])(@this, szNameBufPtr, lHashVal, pfName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref int pfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (int* pfNamePtr = &pfName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, int*, int>)@this->LpVtbl[10])(@this, szNameBufPtr, lHashVal, pfNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, int* pfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, int*, int>)@this->LpVtbl[10])(@this, szNameBufPtr, lHashVal, pfName);
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref int pfName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (int* pfNamePtr = &pfName)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, int*, int>)@this->LpVtbl[10])(@this, szNameBufPtr, lHashVal, pfNamePtr);
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* pcFoundPtr = &pcFound)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfo, rgMemId, pcFoundPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, ref int rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* rgMemIdPtr = &rgMemId)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfo, rgMemIdPtr, pcFound);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, ref int rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* rgMemIdPtr = &rgMemId)
        {
            fixed (ushort* pcFoundPtr = &pcFound)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfo, rgMemIdPtr, pcFoundPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfoPtr, rgMemId, pcFound);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            fixed (ushort* pcFoundPtr = &pcFound)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfoPtr, rgMemId, pcFoundPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, ref int rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            fixed (int* rgMemIdPtr = &rgMemId)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfoPtr, rgMemIdPtr, pcFound);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, ref int rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            fixed (int* rgMemIdPtr = &rgMemId)
            {
                fixed (ushort* pcFoundPtr = &pcFound)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBuf, lHashVal, ppTInfoPtr, rgMemIdPtr, pcFoundPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemId, pcFound);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (ushort* pcFoundPtr = &pcFound)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemId, pcFoundPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, ref int rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (int* rgMemIdPtr = &rgMemId)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemIdPtr, pcFound);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, ref int rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (int* rgMemIdPtr = &rgMemId)
            {
                fixed (ushort* pcFoundPtr = &pcFound)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemIdPtr, pcFoundPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemId, pcFound);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (ushort* pcFoundPtr = &pcFound)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemId, pcFoundPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, ref int rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (int* rgMemIdPtr = &rgMemId)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemIdPtr, pcFound);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, ref int rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* szNameBufPtr = &szNameBuf)
        {
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                fixed (int* rgMemIdPtr = &rgMemId)
                {
                    fixed (ushort* pcFoundPtr = &pcFound)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, char*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemIdPtr, pcFoundPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemId, pcFound);
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (ushort* pcFoundPtr = &pcFound)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemId, pcFoundPtr);
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, ref int rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (int* rgMemIdPtr = &rgMemId)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemIdPtr, pcFound);
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, ref int rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (int* rgMemIdPtr = &rgMemId)
        {
            fixed (ushort* pcFoundPtr = &pcFound)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfo, rgMemIdPtr, pcFoundPtr);
            }
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemId, pcFound);
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            fixed (ushort* pcFoundPtr = &pcFound)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemId, pcFoundPtr);
            }
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, ref int rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            fixed (int* rgMemIdPtr = &rgMemId)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemIdPtr, pcFound);
            }
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, ref int rgMemId, ref ushort pcFound)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var szNameBufPtr = (byte*) SilkMarshal.StringToPtr(szNameBuf, NativeStringEncoding.UTF8);
        fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
        {
            fixed (int* rgMemIdPtr = &rgMemId)
            {
                fixed (ushort* pcFoundPtr = &pcFound)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, byte*, uint, ITypeInfo**, int*, ushort*, int>)@this->LpVtbl[11])(@this, szNameBufPtr, lHashVal, ppTInfoPtr, rgMemIdPtr, pcFoundPtr);
                }
            }
        }
        SilkMarshal.Free((nint)szNameBufPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseTLibAttr(this ComPtr<ITypeLib2> thisVtbl, TLibAttr* pTLibAttr)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<ITypeLib2*, TLibAttr*, void>)@this->LpVtbl[12])(@this, pTLibAttr);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseTLibAttr(this ComPtr<ITypeLib2> thisVtbl, ref TLibAttr pTLibAttr)
    {
        var @this = thisVtbl.Handle;
        fixed (TLibAttr* pTLibAttrPtr = &pTLibAttr)
        {
            ((delegate* unmanaged[Cdecl]<ITypeLib2*, TLibAttr*, void>)@this->LpVtbl[12])(@this, pTLibAttrPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeLib2> thisVtbl, Guid* guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, Variant*, int>)@this->LpVtbl[13])(@this, guid, pVarVal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeLib2> thisVtbl, Guid* guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pVarValPtr = &pVarVal)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, Variant*, int>)@this->LpVtbl[13])(@this, guid, pVarValPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeLib2> thisVtbl, ref Guid guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, Variant*, int>)@this->LpVtbl[13])(@this, guidPtr, pVarVal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCustData(this ComPtr<ITypeLib2> thisVtbl, ref Guid guid, ref Variant pVarVal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, Guid*, Variant*, int>)@this->LpVtbl[13])(@this, guidPtr, pVarValPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibStatistics(this ComPtr<ITypeLib2> thisVtbl, uint* pcUniqueNames, uint* pcchUniqueNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint*, uint*, int>)@this->LpVtbl[14])(@this, pcUniqueNames, pcchUniqueNames);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibStatistics(this ComPtr<ITypeLib2> thisVtbl, uint* pcUniqueNames, ref uint pcchUniqueNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchUniqueNamesPtr = &pcchUniqueNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint*, uint*, int>)@this->LpVtbl[14])(@this, pcUniqueNames, pcchUniqueNamesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibStatistics(this ComPtr<ITypeLib2> thisVtbl, ref uint pcUniqueNames, uint* pcchUniqueNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcUniqueNamesPtr = &pcUniqueNames)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint*, uint*, int>)@this->LpVtbl[14])(@this, pcUniqueNamesPtr, pcchUniqueNames);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLibStatistics(this ComPtr<ITypeLib2> thisVtbl, ref uint pcUniqueNames, ref uint pcchUniqueNames)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcUniqueNamesPtr = &pcUniqueNames)
        {
            fixed (uint* pcchUniqueNamesPtr = &pcchUniqueNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, uint*, uint*, int>)@this->LpVtbl[14])(@this, pcUniqueNamesPtr, pcchUniqueNamesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, char** pbstrHelpString, uint* pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, char** pbstrHelpString, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDllPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, char** pbstrHelpString, ref uint pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpString, pdwHelpStringContextPtr, pbstrHelpStringDll);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, char** pbstrHelpString, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
        {
            fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpString, pdwHelpStringContextPtr, pbstrHelpStringDllPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpStringPtr, pdwHelpStringContext, pbstrHelpStringDll);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
        {
            fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpStringPtr, pdwHelpStringContext, pbstrHelpStringDllPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
        {
            fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpStringPtr, pdwHelpStringContextPtr, pbstrHelpStringDll);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** pbstrHelpStringPtr = &pbstrHelpString)
        {
            fixed (uint* pdwHelpStringContextPtr = &pdwHelpStringContext)
            {
                fixed (char** pbstrHelpStringDllPtr = &pbstrHelpStringDll)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, int, uint, char**, uint*, char**, int>)@this->LpVtbl[15])(@this, index, lcid, pbstrHelpStringPtr, pdwHelpStringContextPtr, pbstrHelpStringDllPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAllCustData(this ComPtr<ITypeLib2> thisVtbl, CustomData* pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, CustomData*, int>)@this->LpVtbl[16])(@this, pCustData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAllCustData(this ComPtr<ITypeLib2> thisVtbl, ref CustomData pCustData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CustomData* pCustDataPtr = &pCustData)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeLib2*, CustomData*, int>)@this->LpVtbl[16])(@this, pCustDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ITypeLib2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLib2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeLib2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfo<TI0>(this ComPtr<ITypeLib2> thisVtbl, uint index, ref ComPtr<TI0> ppTInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypeInfo(index, (ITypeInfo**) ppTInfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfoType(this ComPtr<ITypeLib2> thisVtbl, uint index, Span<TypeKind> pTKind)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypeInfoType(index, ref pTKind.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfoOfGuid<TI0>(this ComPtr<ITypeLib2> thisVtbl, out ComPtr<TI0> ppTinfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppTinfo = default;
        return @this->GetTypeInfoOfGuid(SilkMarshal.GuidPtrOf<TI0>(), (ITypeInfo**) ppTinfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoOfGuid(this ComPtr<ITypeLib2> thisVtbl, Span<Guid> guid, ITypeInfo** ppTinfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypeInfoOfGuid(ref guid.GetPinnableReference(), ppTinfo);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeInfoOfGuid<TI0>(this ComPtr<ITypeLib2> thisVtbl, ref Guid guid, ref ComPtr<TI0> ppTinfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypeInfoOfGuid(ref guid, (ITypeInfo**) ppTinfo.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypeInfoOfGuid(this ComPtr<ITypeLib2> thisVtbl, Span<Guid> guid, ref ITypeInfo* ppTinfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypeInfoOfGuid(ref guid.GetPinnableReference(), ref ppTinfo);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypeComp<TI0>(this ComPtr<ITypeLib2> thisVtbl, ref ComPtr<TI0> ppTComp) where TI0 : unmanaged, IComVtbl<ITypeComp>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypeComp((ITypeComp**) ppTComp.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var ret = @this->GetDocumentation(index, pBstrName, pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, pBstrName, pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var ret = @this->GetDocumentation(index, pBstrName, pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, pBstrName, ref pBstrDocString, pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, ref char* pBstrDocString, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var ret = @this->GetDocumentation(index, pBstrName, ref pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, pBstrName, ref pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, string[] pBstrNameSa, ref char* pBstrDocString, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrName = (char**) SilkMarshal.StringArrayToPtr(pBstrNameSa);
        var ret = @this->GetDocumentation(index, pBstrName, ref pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrName, pBstrNameSa);
        SilkMarshal.Free((nint) pBstrName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, char** pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, ref pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, string[] pBstrDocStringSa, uint* pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var ret = @this->GetDocumentation(index, ref pBstrName, pBstrDocString, pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, ref pBstrName, pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, ref pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, string[] pBstrDocStringSa, ref uint pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrDocString = (char**) SilkMarshal.StringArrayToPtr(pBstrDocStringSa);
        var ret = @this->GetDocumentation(index, ref pBstrName, pBstrDocString, ref pdwHelpContext, ref pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrDocString, pBstrDocStringSa);
        SilkMarshal.Free((nint) pBstrDocString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, char** pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, ref pBstrName, pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, uint* pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, ref pBstrName, ref pBstrDocString, pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, ref uint pdwHelpContext, string[] pBstrHelpFileSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pBstrHelpFile = (char**) SilkMarshal.StringArrayToPtr(pBstrHelpFileSa);
        var ret = @this->GetDocumentation(index, ref pBstrName, ref pBstrDocString, ref pdwHelpContext, pBstrHelpFile);
        SilkMarshal.CopyPtrToStringArray((nint) pBstrHelpFile, pBstrHelpFileSa);
        SilkMarshal.Free((nint) pBstrHelpFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, char** pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, ref pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation(this ComPtr<ITypeLib2> thisVtbl, int index, ref char* pBstrName, ref char* pBstrDocString, Span<uint> pdwHelpContext, ref char* pBstrHelpFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation(index, ref pBstrName, ref pBstrDocString, ref pdwHelpContext.GetPinnableReference(), ref pBstrHelpFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, Span<int> pfName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsName(szNameBuf, lHashVal, ref pfName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, int* pfName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsName(ref szNameBuf.GetPinnableReference(), lHashVal, pfName);
    }

    /// <summary>To be documented.</summary>
    public static int IsName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, Span<int> pfName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsName(ref szNameBuf.GetPinnableReference(), lHashVal, ref pfName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, Span<int> pfName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsName(szNameBuf, lHashVal, ref pfName.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, int* rgMemId, ushort* pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ppTInfo, rgMemId, ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, int* rgMemId, ref ushort pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), rgMemId, ref pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, Span<int> rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ppTInfo, ref rgMemId.GetPinnableReference(), pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref int rgMemId, ushort* pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, Span<int> rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ppTInfo, ref rgMemId.GetPinnableReference(), ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref int rgMemId, ref ushort pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref rgMemId, ref pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ref ppTInfo, rgMemId, ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, Span<int> rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ref ppTInfo, ref rgMemId.GetPinnableReference(), pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, char* szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, Span<int> rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ref ppTInfo, ref rgMemId.GetPinnableReference(), ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ppTInfo, rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, int* rgMemId, ushort* pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(ref szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ppTInfo, rgMemId, ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, int* rgMemId, ref ushort pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(ref szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), rgMemId, ref pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, Span<int> rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ppTInfo, ref rgMemId.GetPinnableReference(), pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref int rgMemId, ushort* pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(ref szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, Span<int> rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ppTInfo, ref rgMemId.GetPinnableReference(), ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, ref char szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref int rgMemId, ref ushort pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(ref szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref rgMemId, ref pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ref ppTInfo, rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ref ppTInfo, rgMemId, ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, Span<int> rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ref ppTInfo, ref rgMemId.GetPinnableReference(), pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, Span<char> szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, Span<int> rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(ref szNameBuf.GetPinnableReference(), lHashVal, ref ppTInfo, ref rgMemId.GetPinnableReference(), ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, int* rgMemId, ushort* pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, int* rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ppTInfo, rgMemId, ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, int* rgMemId, ref ushort pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), rgMemId, ref pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, Span<int> rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ppTInfo, ref rgMemId.GetPinnableReference(), pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref int rgMemId, ushort* pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref rgMemId, pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ITypeInfo** ppTInfo, Span<int> rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ppTInfo, ref rgMemId.GetPinnableReference(), ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FindName<TI0>(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ComPtr<TI0> ppTInfo, ref int rgMemId, ref ushort pcFound) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindName(szNameBuf, lHashVal, (ITypeInfo**) ppTInfo.GetAddressOf(), ref rgMemId, ref pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, int* rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ref ppTInfo, rgMemId, ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, Span<int> rgMemId, ushort* pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ref ppTInfo, ref rgMemId.GetPinnableReference(), pcFound);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindName(this ComPtr<ITypeLib2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szNameBuf, uint lHashVal, ref ITypeInfo* ppTInfo, Span<int> rgMemId, Span<ushort> pcFound)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindName(szNameBuf, lHashVal, ref ppTInfo, ref rgMemId.GetPinnableReference(), ref pcFound.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseTLibAttr(this ComPtr<ITypeLib2> thisVtbl, Span<TLibAttr> pTLibAttr)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseTLibAttr(ref pTLibAttr.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeLib2> thisVtbl, Guid* guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCustData(guid, ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCustData(this ComPtr<ITypeLib2> thisVtbl, Span<Guid> guid, Variant* pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCustData(ref guid.GetPinnableReference(), pVarVal);
    }

    /// <summary>To be documented.</summary>
    public static int GetCustData(this ComPtr<ITypeLib2> thisVtbl, Span<Guid> guid, Span<Variant> pVarVal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCustData(ref guid.GetPinnableReference(), ref pVarVal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibStatistics(this ComPtr<ITypeLib2> thisVtbl, uint* pcUniqueNames, Span<uint> pcchUniqueNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLibStatistics(pcUniqueNames, ref pcchUniqueNames.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLibStatistics(this ComPtr<ITypeLib2> thisVtbl, Span<uint> pcUniqueNames, uint* pcchUniqueNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLibStatistics(ref pcUniqueNames.GetPinnableReference(), pcchUniqueNames);
    }

    /// <summary>To be documented.</summary>
    public static int GetLibStatistics(this ComPtr<ITypeLib2> thisVtbl, Span<uint> pcUniqueNames, Span<uint> pcchUniqueNames)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLibStatistics(ref pcUniqueNames.GetPinnableReference(), ref pcchUniqueNames.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, string[] pbstrHelpStringSa, uint* pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
        var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
        var ret = @this->GetDocumentation2(index, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
        SilkMarshal.Free((nint) pbstrHelpString);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
        SilkMarshal.Free((nint) pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, string[] pbstrHelpStringSa, uint* pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
        var ret = @this->GetDocumentation2(index, lcid, pbstrHelpString, pdwHelpStringContext, ref pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
        SilkMarshal.Free((nint) pbstrHelpString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, string[] pbstrHelpStringSa, ref uint pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
        var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
        var ret = @this->GetDocumentation2(index, lcid, pbstrHelpString, ref pdwHelpStringContext, pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
        SilkMarshal.Free((nint) pbstrHelpString);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
        SilkMarshal.Free((nint) pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, char** pbstrHelpString, Span<uint> pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(index, lcid, pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, string[] pbstrHelpStringSa, ref uint pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpString = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringSa);
        var ret = @this->GetDocumentation2(index, lcid, pbstrHelpString, ref pdwHelpStringContext, ref pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpString, pbstrHelpStringSa);
        SilkMarshal.Free((nint) pbstrHelpString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, char** pbstrHelpString, Span<uint> pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(index, lcid, pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), ref pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, uint* pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
        var ret = @this->GetDocumentation2(index, lcid, ref pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
        SilkMarshal.Free((nint) pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, ref uint pdwHelpStringContext, string[] pbstrHelpStringDllSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var pbstrHelpStringDll = (char**) SilkMarshal.StringArrayToPtr(pbstrHelpStringDllSa);
        var ret = @this->GetDocumentation2(index, lcid, ref pbstrHelpString, ref pdwHelpStringContext, pbstrHelpStringDll);
        SilkMarshal.CopyPtrToStringArray((nint) pbstrHelpStringDll, pbstrHelpStringDllSa);
        SilkMarshal.Free((nint) pbstrHelpStringDll);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, Span<uint> pdwHelpStringContext, char** pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(index, lcid, ref pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDocumentation2(this ComPtr<ITypeLib2> thisVtbl, int index, uint lcid, ref char* pbstrHelpString, Span<uint> pdwHelpStringContext, ref char* pbstrHelpStringDll)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDocumentation2(index, lcid, ref pbstrHelpString, ref pdwHelpStringContext.GetPinnableReference(), ref pbstrHelpStringDll);
    }

    /// <summary>To be documented.</summary>
    public static int GetAllCustData(this ComPtr<ITypeLib2> thisVtbl, Span<CustomData> pCustData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAllCustData(ref pCustData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ITypeLib2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetTypeInfoOfGuid<TI0>(this ComPtr<ITypeLib2> thisVtbl) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetTypeInfoOfGuid(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
