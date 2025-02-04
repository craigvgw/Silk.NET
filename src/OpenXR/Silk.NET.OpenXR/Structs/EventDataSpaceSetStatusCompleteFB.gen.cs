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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEventDataSpaceSetStatusCompleteFB")]
    public unsafe partial struct EventDataSpaceSetStatusCompleteFB
    {
        public EventDataSpaceSetStatusCompleteFB
        (
            StructureType? type = StructureType.TypeEventDataSpaceSetStatusCompleteFB,
            void* next = null,
            ulong? requestId = null,
            Result? result = null,
            Space? space = null,
            UuidEXT? uuid = null,
            SpaceComponentTypeFB? componentType = null,
            uint? enabled = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (requestId is not null)
            {
                RequestId = requestId.Value;
            }

            if (result is not null)
            {
                Result = result.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }

            if (uuid is not null)
            {
                Uuid = uuid.Value;
            }

            if (componentType is not null)
            {
                ComponentType = componentType.Value;
            }

            if (enabled is not null)
            {
                Enabled = enabled.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrAsyncRequestIdFB")]
        [NativeName("Type.Name", "XrAsyncRequestIdFB")]
        [NativeName("Name", "requestId")]
        public ulong RequestId;
/// <summary></summary>
        [NativeName("Type", "XrResult")]
        [NativeName("Type.Name", "XrResult")]
        [NativeName("Name", "result")]
        public Result Result;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "uuid")]
        public UuidEXT Uuid;
/// <summary></summary>
        [NativeName("Type", "XrSpaceComponentTypeFB")]
        [NativeName("Type.Name", "XrSpaceComponentTypeFB")]
        [NativeName("Name", "componentType")]
        public SpaceComponentTypeFB ComponentType;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "enabled")]
        public uint Enabled;
    }
}
