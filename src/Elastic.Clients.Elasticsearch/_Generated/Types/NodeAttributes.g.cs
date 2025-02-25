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
namespace Elastic.Clients.Elasticsearch;
public sealed partial class NodeAttributes
{
	[JsonInclude]
	[JsonPropertyName("attributes")]
	public IReadOnlyDictionary<string, string> Attributes { get; init; }

	[JsonInclude]
	[JsonPropertyName("ephemeral_id")]
	public string EphemeralId { get; init; }

	[JsonInclude]
	[JsonPropertyName("external_id")]
	public string ExternalId { get; init; }

	[JsonInclude]
	[JsonPropertyName("id")]
	public string? Id { get; init; }

	[JsonInclude]
	[JsonPropertyName("name")]
	public string Name { get; init; }

	[JsonInclude]
	[JsonPropertyName("roles")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.NodeRole>? Roles { get; init; }

	[JsonInclude]
	[JsonPropertyName("transport_address")]
	public string TransportAddress { get; init; }
}