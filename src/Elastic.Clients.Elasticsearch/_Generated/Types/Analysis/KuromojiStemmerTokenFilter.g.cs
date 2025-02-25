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
public sealed partial class KuromojiStemmerTokenFilter : ITokenFilter
{
	[JsonInclude]
	[JsonPropertyName("minimum_length")]
	public int MinimumLength { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "kuromoji_stemmer";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class KuromojiStemmerTokenFilterDescriptor : SerializableDescriptor<KuromojiStemmerTokenFilterDescriptor>, IBuildableDescriptor<KuromojiStemmerTokenFilter>
{
	internal KuromojiStemmerTokenFilterDescriptor(Action<KuromojiStemmerTokenFilterDescriptor> configure) => configure.Invoke(this);
	public KuromojiStemmerTokenFilterDescriptor() : base()
	{
	}

	private int MinimumLengthValue { get; set; }

	private string? VersionValue { get; set; }

	public KuromojiStemmerTokenFilterDescriptor MinimumLength(int minimumLength)
	{
		MinimumLengthValue = minimumLength;
		return Self;
	}

	public KuromojiStemmerTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("minimum_length");
		writer.WriteNumberValue(MinimumLengthValue);
		writer.WritePropertyName("type");
		writer.WriteStringValue("kuromoji_stemmer");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	KuromojiStemmerTokenFilter IBuildableDescriptor<KuromojiStemmerTokenFilter>.Build() => new()
	{ MinimumLength = MinimumLengthValue, Version = VersionValue };
}