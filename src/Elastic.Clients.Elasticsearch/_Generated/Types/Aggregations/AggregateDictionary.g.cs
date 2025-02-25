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
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations;
[JsonConverter(typeof(AggregateDictionaryConverter))]
public partial class AggregateDictionary : IsAReadOnlyDictionary<string, IAggregate>
{
	public AggregateDictionary(IReadOnlyDictionary<string, IAggregate> backingDictionary) : base(backingDictionary)
	{
	}

	public Elastic.Clients.Elasticsearch.Aggregations.CardinalityAggregate? GetCardinality(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.CardinalityAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.TDigestPercentileRanksAggregate? GetTDigestPercentileRanks(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.TDigestPercentileRanksAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.PercentilesBucketAggregate? GetPercentilesBucket(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.PercentilesBucketAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.MedianAbsoluteDeviationAggregate? GetMedianAbsoluteDeviation(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MedianAbsoluteDeviationAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.MinAggregate? GetMin(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MinAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.MaxAggregate? GetMax(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MaxAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.SumAggregate? GetSum(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.SumAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.AvgAggregate? GetAvg(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.AvgAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.WeightedAvgAggregate? GetWeightedAvg(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.WeightedAvgAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.ValueCountAggregate? GetValueCount(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ValueCountAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.DerivativeAggregate? GetDerivative(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.DerivativeAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.StatsAggregate? GetStats(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.StatsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.StatsBucketAggregate? GetStatsBucket(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.StatsBucketAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsAggregate? GetExtendedStats(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsBucketAggregate? GetExtendedStatsBucket(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsBucketAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregate? GetHistogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregate? GetDateHistogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.AutoDateHistogramAggregate? GetAutoDateHistogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.AutoDateHistogramAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.VariableWidthHistogramAggregate? GetVariableWidthHistogram(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.VariableWidthHistogramAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.StringTermsAggregate? GetStringTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.StringTermsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.LongTermsAggregate? GetLongTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.LongTermsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.DoubleTermsAggregate? GetDoubleTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.DoubleTermsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.MultiTermsAggregate? GetMultiTerms(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MultiTermsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.MissingAggregate? GetMissing(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MissingAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.NestedAggregate? GetNested(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.NestedAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.ReverseNestedAggregate? GetReverseNested(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ReverseNestedAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.GlobalAggregate? GetGlobal(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.GlobalAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.FilterAggregate? GetFilter(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.FilterAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.ChildrenAggregate? GetChildren(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ChildrenAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.ParentAggregate? GetParent(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ParentAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregate? GetSampler(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.RangeAggregate? GetRange(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.RangeAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.DateRangeAggregate? GetDateRange(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.DateRangeAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.IpRangeAggregate? GetIpRange(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.IpRangeAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.FiltersAggregate? GetFilters(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.FiltersAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.AdjacencyMatrixAggregate? GetAdjacencyMatrix(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.AdjacencyMatrixAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregate? GetComposite(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.ScriptedMetricAggregate? GetScriptedMetric(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.ScriptedMetricAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.TopHitsAggregate? GetTopHits(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.TopHitsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.InferenceAggregate? GetInference(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.InferenceAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.StringStatsAggregate? GetStringStats(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.StringStatsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.BoxPlotAggregate? GetBoxPlot(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.BoxPlotAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.TopMetricsAggregate? GetTopMetrics(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.TTestAggregate? GetTTest(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.TTestAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.RateAggregate? GetRate(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.RateAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.CumulativeCardinalityAggregate? GetCumulativeCardinality(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.CumulativeCardinalityAggregate?>(key);
	public Elastic.Clients.Elasticsearch.Aggregations.MatrixStatsAggregate? GetMatrixStats(string key) => TryGet<Elastic.Clients.Elasticsearch.Aggregations.MatrixStatsAggregate?>(key);
	private TAggregate TryGet<TAggregate>(string key)
		where TAggregate : class, IAggregate => BackingDictionary.TryGetValue(key, out var agg) ? agg as TAggregate : null;
}