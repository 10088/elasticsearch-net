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
public sealed partial class StandardTokenizer : ITokenizer
{
	[JsonInclude]
	[JsonPropertyName("max_token_length")]
	public int? MaxTokenLength { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "standard";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class StandardTokenizerDescriptor : SerializableDescriptor<StandardTokenizerDescriptor>, IBuildableDescriptor<StandardTokenizer>
{
	internal StandardTokenizerDescriptor(Action<StandardTokenizerDescriptor> configure) => configure.Invoke(this);
	public StandardTokenizerDescriptor() : base()
	{
	}

	private int? MaxTokenLengthValue { get; set; }

	private string? VersionValue { get; set; }

	public StandardTokenizerDescriptor MaxTokenLength(int? maxTokenLength)
	{
		MaxTokenLengthValue = maxTokenLength;
		return Self;
	}

	public StandardTokenizerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxTokenLengthValue.HasValue)
		{
			writer.WritePropertyName("max_token_length");
			writer.WriteNumberValue(MaxTokenLengthValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("standard");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	StandardTokenizer IBuildableDescriptor<StandardTokenizer>.Build() => new()
	{ MaxTokenLength = MaxTokenLengthValue, Version = VersionValue };
}