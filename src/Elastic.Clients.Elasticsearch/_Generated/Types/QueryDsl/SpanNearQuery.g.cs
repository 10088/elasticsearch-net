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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class SpanNearQuery : QueryDsl.QueryBase, IQueryContainerVariant, ISpanQueryVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "span_near";
		[JsonIgnore]
		string QueryDsl.ISpanQueryVariant.SpanQueryVariantName => "span_near";
		[JsonInclude]
		[JsonPropertyName("clauses")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery> Clauses { get; set; }

		[JsonInclude]
		[JsonPropertyName("in_order")]
		public bool? InOrder { get; set; }

		[JsonInclude]
		[JsonPropertyName("slop")]
		public int? Slop { get; set; }
	}

	public sealed partial class SpanNearQueryDescriptor : DescriptorBase<SpanNearQueryDescriptor>
	{
		internal SpanNearQueryDescriptor(Action<SpanNearQueryDescriptor> configure) => configure.Invoke(this);
		public SpanNearQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery> ClausesValue { get; set; }

		private bool? InOrderValue { get; set; }

		private int? SlopValue { get; set; }

		public SpanNearQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public SpanNearQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public SpanNearQueryDescriptor Clauses(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.SpanQuery> clauses)
		{
			ClausesValue = clauses;
			return Self;
		}

		public SpanNearQueryDescriptor InOrder(bool? inOrder = true)
		{
			InOrderValue = inOrder;
			return Self;
		}

		public SpanNearQueryDescriptor Slop(int? slop)
		{
			SlopValue = slop;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("clauses");
			JsonSerializer.Serialize(writer, ClausesValue, options);
			if (InOrderValue.HasValue)
			{
				writer.WritePropertyName("in_order");
				writer.WriteBooleanValue(InOrderValue.Value);
			}

			if (SlopValue.HasValue)
			{
				writer.WritePropertyName("slop");
				writer.WriteNumberValue(SlopValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}