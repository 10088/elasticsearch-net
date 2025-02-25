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
namespace Elastic.Clients.Elasticsearch.Aggregations;
internal sealed class ExtendedStatsAggregationConverter : JsonConverter<ExtendedStatsAggregation>
{
	public override ExtendedStatsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "extended_stats")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new ExtendedStatsAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("format"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<string?>(ref reader, options);
					if (value is not null)
					{
						agg.Format = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<FieldValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("sigma"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<double?>(ref reader, options);
					if (value is not null)
					{
						agg.Sigma = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, ExtendedStatsAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("extended_stats");
		writer.WriteStartObject();
		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (!string.IsNullOrEmpty(value.Format))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(value.Format);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (value.Script is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, value.Script, options);
		}

		if (value.Sigma.HasValue)
		{
			writer.WritePropertyName("sigma");
			writer.WriteNumberValue(value.Sigma.Value);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(ExtendedStatsAggregationConverter))]
public sealed partial class ExtendedStatsAggregation : SearchAggregation
{
	public ExtendedStatsAggregation(string name, Field field) : this(name) => Field = field;
	public ExtendedStatsAggregation(string name) => Name = name;
	internal ExtendedStatsAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	public string? Format { get; set; }

	public IDictionary<string, object>? Meta { get; set; }

	public FieldValue? Missing { get; set; }

	public override string? Name { get; internal set; }

	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	public double? Sigma { get; set; }
}

public sealed partial class ExtendedStatsAggregationDescriptor<TDocument> : SerializableDescriptor<ExtendedStatsAggregationDescriptor<TDocument>>
{
	internal ExtendedStatsAggregationDescriptor(Action<ExtendedStatsAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
	public ExtendedStatsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private string? FormatValue { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	private double? SigmaValue { get; set; }

	public ExtendedStatsAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public ExtendedStatsAggregationDescriptor<TDocument> Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor<TDocument> Sigma(double? sigma)
	{
		SigmaValue = sigma;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("extended_stats");
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SigmaValue.HasValue)
		{
			writer.WritePropertyName("sigma");
			writer.WriteNumberValue(SigmaValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class ExtendedStatsAggregationDescriptor : SerializableDescriptor<ExtendedStatsAggregationDescriptor>
{
	internal ExtendedStatsAggregationDescriptor(Action<ExtendedStatsAggregationDescriptor> configure) => configure.Invoke(this);
	public ExtendedStatsAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private string? FormatValue { get; set; }

	private IDictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	private double? SigmaValue { get; set; }

	public ExtendedStatsAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public ExtendedStatsAggregationDescriptor Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	public ExtendedStatsAggregationDescriptor Sigma(double? sigma)
	{
		SigmaValue = sigma;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("extended_stats");
		writer.WriteStartObject();
		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (SigmaValue.HasValue)
		{
			writer.WritePropertyName("sigma");
			writer.WriteNumberValue(SigmaValue.Value);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}