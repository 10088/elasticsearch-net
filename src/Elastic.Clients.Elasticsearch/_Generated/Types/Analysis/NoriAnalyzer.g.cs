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
public sealed partial class NoriAnalyzer : IAnalyzer
{
	[JsonInclude]
	[JsonPropertyName("decompound_mode")]
	public Elastic.Clients.Elasticsearch.Analysis.NoriDecompoundMode? DecompoundMode { get; set; }

	[JsonInclude]
	[JsonPropertyName("stoptags")]
	public ICollection<string>? Stoptags { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "nori";
	[JsonInclude]
	[JsonPropertyName("user_dictionary")]
	public string? UserDictionary { get; set; }

	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class NoriAnalyzerDescriptor : SerializableDescriptor<NoriAnalyzerDescriptor>, IBuildableDescriptor<NoriAnalyzer>
{
	internal NoriAnalyzerDescriptor(Action<NoriAnalyzerDescriptor> configure) => configure.Invoke(this);
	public NoriAnalyzerDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Analysis.NoriDecompoundMode? DecompoundModeValue { get; set; }

	private ICollection<string>? StoptagsValue { get; set; }

	private string? UserDictionaryValue { get; set; }

	private string? VersionValue { get; set; }

	public NoriAnalyzerDescriptor DecompoundMode(Elastic.Clients.Elasticsearch.Analysis.NoriDecompoundMode? decompoundMode)
	{
		DecompoundModeValue = decompoundMode;
		return Self;
	}

	public NoriAnalyzerDescriptor Stoptags(ICollection<string>? stoptags)
	{
		StoptagsValue = stoptags;
		return Self;
	}

	public NoriAnalyzerDescriptor UserDictionary(string? userDictionary)
	{
		UserDictionaryValue = userDictionary;
		return Self;
	}

	public NoriAnalyzerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DecompoundModeValue is not null)
		{
			writer.WritePropertyName("decompound_mode");
			JsonSerializer.Serialize(writer, DecompoundModeValue, options);
		}

		if (StoptagsValue is not null)
		{
			writer.WritePropertyName("stoptags");
			JsonSerializer.Serialize(writer, StoptagsValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("nori");
		if (!string.IsNullOrEmpty(UserDictionaryValue))
		{
			writer.WritePropertyName("user_dictionary");
			writer.WriteStringValue(UserDictionaryValue);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	NoriAnalyzer IBuildableDescriptor<NoriAnalyzer>.Build() => new()
	{ DecompoundMode = DecompoundModeValue, Stoptags = StoptagsValue, UserDictionary = UserDictionaryValue, Version = VersionValue };
}