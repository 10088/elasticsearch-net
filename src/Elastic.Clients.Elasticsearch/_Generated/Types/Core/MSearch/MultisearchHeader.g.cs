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
namespace Elastic.Clients.Elasticsearch.Core.MSearch;
public sealed partial class MultisearchHeader
{
	[JsonInclude]
	[JsonPropertyName("allow_no_indices")]
	public bool? AllowNoIndices { get; set; }

	[JsonInclude]
	[JsonPropertyName("allow_partial_search_results")]
	public bool? AllowPartialSearchResults { get; set; }

	[JsonInclude]
	[JsonPropertyName("ccs_minimize_roundtrips")]
	public bool? CcsMinimizeRoundtrips { get; set; }

	[JsonInclude]
	[JsonPropertyName("expand_wildcards")]
	[JsonConverter(typeof(ExpandWildcardsConverter))]
	public ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get; set; }

	[JsonInclude]
	[JsonPropertyName("ignore_throttled")]
	public bool? IgnoreThrottled { get; set; }

	[JsonInclude]
	[JsonPropertyName("ignore_unavailable")]
	public bool? IgnoreUnavailable { get; set; }

	[JsonInclude]
	[JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.Indices? Index { get; set; }

	[JsonInclude]
	[JsonPropertyName("preference")]
	public string? Preference { get; set; }

	[JsonInclude]
	[JsonPropertyName("request_cache")]
	public bool? RequestCache { get; set; }

	[JsonInclude]
	[JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

	[JsonInclude]
	[JsonPropertyName("search_type")]
	public Elastic.Clients.Elasticsearch.SearchType? SearchType { get; set; }
}

public sealed partial class MultisearchHeaderDescriptor : SerializableDescriptor<MultisearchHeaderDescriptor>
{
	internal MultisearchHeaderDescriptor(Action<MultisearchHeaderDescriptor> configure) => configure.Invoke(this);
	public MultisearchHeaderDescriptor() : base()
	{
	}

	private bool? AllowNoIndicesValue { get; set; }

	private bool? AllowPartialSearchResultsValue { get; set; }

	private bool? CcsMinimizeRoundtripsValue { get; set; }

	private ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcardsValue { get; set; }

	private bool? IgnoreThrottledValue { get; set; }

	private bool? IgnoreUnavailableValue { get; set; }

	private Elastic.Clients.Elasticsearch.Indices? IndexValue { get; set; }

	private string? PreferenceValue { get; set; }

	private bool? RequestCacheValue { get; set; }

	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }

	private Elastic.Clients.Elasticsearch.SearchType? SearchTypeValue { get; set; }

	public MultisearchHeaderDescriptor AllowNoIndices(bool? allowNoIndices = true)
	{
		AllowNoIndicesValue = allowNoIndices;
		return Self;
	}

	public MultisearchHeaderDescriptor AllowPartialSearchResults(bool? allowPartialSearchResults = true)
	{
		AllowPartialSearchResultsValue = allowPartialSearchResults;
		return Self;
	}

	public MultisearchHeaderDescriptor CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true)
	{
		CcsMinimizeRoundtripsValue = ccsMinimizeRoundtrips;
		return Self;
	}

	public MultisearchHeaderDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards)
	{
		ExpandWildcardsValue = expandWildcards;
		return Self;
	}

	public MultisearchHeaderDescriptor IgnoreThrottled(bool? ignoreThrottled = true)
	{
		IgnoreThrottledValue = ignoreThrottled;
		return Self;
	}

	public MultisearchHeaderDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true)
	{
		IgnoreUnavailableValue = ignoreUnavailable;
		return Self;
	}

	public MultisearchHeaderDescriptor Index(Elastic.Clients.Elasticsearch.Indices? index)
	{
		IndexValue = index;
		return Self;
	}

	public MultisearchHeaderDescriptor Preference(string? preference)
	{
		PreferenceValue = preference;
		return Self;
	}

	public MultisearchHeaderDescriptor RequestCache(bool? requestCache = true)
	{
		RequestCacheValue = requestCache;
		return Self;
	}

	public MultisearchHeaderDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	public MultisearchHeaderDescriptor SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType)
	{
		SearchTypeValue = searchType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllowNoIndicesValue.HasValue)
		{
			writer.WritePropertyName("allow_no_indices");
			writer.WriteBooleanValue(AllowNoIndicesValue.Value);
		}

		if (AllowPartialSearchResultsValue.HasValue)
		{
			writer.WritePropertyName("allow_partial_search_results");
			writer.WriteBooleanValue(AllowPartialSearchResultsValue.Value);
		}

		if (CcsMinimizeRoundtripsValue.HasValue)
		{
			writer.WritePropertyName("ccs_minimize_roundtrips");
			writer.WriteBooleanValue(CcsMinimizeRoundtripsValue.Value);
		}

		if (ExpandWildcardsValue is not null)
		{
			writer.WritePropertyName("expand_wildcards");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.ExpandWildcard>(ExpandWildcardsValue, writer, options);
		}

		if (IgnoreThrottledValue.HasValue)
		{
			writer.WritePropertyName("ignore_throttled");
			writer.WriteBooleanValue(IgnoreThrottledValue.Value);
		}

		if (IgnoreUnavailableValue.HasValue)
		{
			writer.WritePropertyName("ignore_unavailable");
			writer.WriteBooleanValue(IgnoreUnavailableValue.Value);
		}

		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (!string.IsNullOrEmpty(PreferenceValue))
		{
			writer.WritePropertyName("preference");
			writer.WriteStringValue(PreferenceValue);
		}

		if (RequestCacheValue.HasValue)
		{
			writer.WritePropertyName("request_cache");
			writer.WriteBooleanValue(RequestCacheValue.Value);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (SearchTypeValue is not null)
		{
			writer.WritePropertyName("search_type");
			JsonSerializer.Serialize(writer, SearchTypeValue, options);
		}

		writer.WriteEndObject();
	}
}