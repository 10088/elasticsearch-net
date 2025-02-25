// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class UniqueTokenFilter : ITokenFilter
{
	[JsonInclude]
	[JsonPropertyName("only_on_same_position")]
	public bool? OnlyOnSamePosition { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "unique";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class UniqueTokenFilterDescriptor : SerializableDescriptor<UniqueTokenFilterDescriptor>, IBuildableDescriptor<UniqueTokenFilter>
{
	internal UniqueTokenFilterDescriptor(Action<UniqueTokenFilterDescriptor> configure) => configure.Invoke(this);
	public UniqueTokenFilterDescriptor() : base()
	{
	}

	private bool? OnlyOnSamePositionValue { get; set; }

	private string? VersionValue { get; set; }

	public UniqueTokenFilterDescriptor OnlyOnSamePosition(bool? onlyOnSamePosition = true)
	{
		OnlyOnSamePositionValue = onlyOnSamePosition;
		return Self;
	}

	public UniqueTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (OnlyOnSamePositionValue.HasValue)
		{
			writer.WritePropertyName("only_on_same_position");
			writer.WriteBooleanValue(OnlyOnSamePositionValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("unique");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	UniqueTokenFilter IBuildableDescriptor<UniqueTokenFilter>.Build() => new()
	{ OnlyOnSamePosition = OnlyOnSamePositionValue, Version = VersionValue };
}