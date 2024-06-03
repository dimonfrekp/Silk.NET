﻿using System;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Loads <see cref="IMod"/>s based on strings contained within the configuration file.
/// </summary>
public class ModLoader
{
    /// <summary>
    /// Gets a mod from the given name/string.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>The loaded mod if the mod was found, null otherwise.</returns>
    public static Type? LoadModByName(string name) =>
        name switch
        {
            nameof(ChangeNamespace) => typeof(ChangeNamespace),
            nameof(AddIncludes) => typeof(AddIncludes),
            nameof(TransformFunctions) => typeof(TransformFunctions),
            nameof(PrettifyNames) => typeof(PrettifyNames),
            nameof(AddOpaqueStructs) => typeof(AddOpaqueStructs),
            nameof(AddVTables) => typeof(AddVTables),
            nameof(AddApiProfiles) => typeof(AddApiProfiles),
            nameof(MixKhronosData) => typeof(MixKhronosData),
            nameof(TransformHandles) => typeof(TransformHandles),
            nameof(ExtractNestedTyping) => typeof(ExtractNestedTyping),
            _ => null
        };
}
