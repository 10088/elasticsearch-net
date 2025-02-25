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
namespace Elastic.Clients.Elasticsearch.Ml;
public sealed partial class QuestionAnsweringInferenceUpdateOptions
{
	[JsonInclude]
	[JsonPropertyName("max_answer_length")]
	public int? MaxAnswerLength { get; set; }

	[JsonInclude]
	[JsonPropertyName("num_top_classes")]
	public int? NumTopClasses { get; set; }

	[JsonInclude]
	[JsonPropertyName("question")]
	public string Question { get; set; }

	[JsonInclude]
	[JsonPropertyName("results_field")]
	public string? ResultsField { get; set; }

	[JsonInclude]
	[JsonPropertyName("tokenization")]
	public Elastic.Clients.Elasticsearch.Ml.NlpTokenizationUpdateOptions? Tokenization { get; set; }

	public static implicit operator InferenceConfigUpdate(QuestionAnsweringInferenceUpdateOptions questionAnsweringInferenceUpdateOptions) => Ml.InferenceConfigUpdate.QuestionAnswering(questionAnsweringInferenceUpdateOptions);
}

public sealed partial class QuestionAnsweringInferenceUpdateOptionsDescriptor : SerializableDescriptor<QuestionAnsweringInferenceUpdateOptionsDescriptor>
{
	internal QuestionAnsweringInferenceUpdateOptionsDescriptor(Action<QuestionAnsweringInferenceUpdateOptionsDescriptor> configure) => configure.Invoke(this);
	public QuestionAnsweringInferenceUpdateOptionsDescriptor() : base()
	{
	}

	private int? MaxAnswerLengthValue { get; set; }

	private int? NumTopClassesValue { get; set; }

	private string QuestionValue { get; set; }

	private string? ResultsFieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Ml.NlpTokenizationUpdateOptions? TokenizationValue { get; set; }

	private NlpTokenizationUpdateOptionsDescriptor TokenizationDescriptor { get; set; }

	private Action<NlpTokenizationUpdateOptionsDescriptor> TokenizationDescriptorAction { get; set; }

	public QuestionAnsweringInferenceUpdateOptionsDescriptor MaxAnswerLength(int? maxAnswerLength)
	{
		MaxAnswerLengthValue = maxAnswerLength;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor NumTopClasses(int? numTopClasses)
	{
		NumTopClassesValue = numTopClasses;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor Question(string question)
	{
		QuestionValue = question;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor ResultsField(string? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor Tokenization(Elastic.Clients.Elasticsearch.Ml.NlpTokenizationUpdateOptions? tokenization)
	{
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = null;
		TokenizationValue = tokenization;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor Tokenization(NlpTokenizationUpdateOptionsDescriptor descriptor)
	{
		TokenizationValue = null;
		TokenizationDescriptorAction = null;
		TokenizationDescriptor = descriptor;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor Tokenization(Action<NlpTokenizationUpdateOptionsDescriptor> configure)
	{
		TokenizationValue = null;
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxAnswerLengthValue.HasValue)
		{
			writer.WritePropertyName("max_answer_length");
			writer.WriteNumberValue(MaxAnswerLengthValue.Value);
		}

		if (NumTopClassesValue.HasValue)
		{
			writer.WritePropertyName("num_top_classes");
			writer.WriteNumberValue(NumTopClassesValue.Value);
		}

		writer.WritePropertyName("question");
		writer.WriteStringValue(QuestionValue);
		if (!string.IsNullOrEmpty(ResultsFieldValue))
		{
			writer.WritePropertyName("results_field");
			writer.WriteStringValue(ResultsFieldValue);
		}

		if (TokenizationDescriptor is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationDescriptor, options);
		}
		else if (TokenizationDescriptorAction is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, new NlpTokenizationUpdateOptionsDescriptor(TokenizationDescriptorAction), options);
		}
		else if (TokenizationValue is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationValue, options);
		}

		writer.WriteEndObject();
	}
}