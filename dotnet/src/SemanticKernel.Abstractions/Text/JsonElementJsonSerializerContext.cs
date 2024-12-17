// Copyright (c) Microsoft. All rights reserved.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.SemanticKernel.Text;

[JsonSerializable(typeof(JsonElement))]
internal partial class JsonElementJsonSerializerContext : JsonSerializerContext
{
    public static readonly JsonElementJsonSerializerContext MaxDepth_128 = new(new() { MaxDepth = 128 });
}
