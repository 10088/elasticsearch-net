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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public partial class ClusterHealthResponse : ResponseBase
	{
		[JsonPropertyName("active_primary_shards")]
		public int ActivePrimaryShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("active_shards")]
		public int ActiveShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("active_shards_percent_as_number")]
		public Percentage ActiveShardsPercentAsNumber
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster_name")]
		public string ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("delayed_unassigned_shards")]
		public int DelayedUnassignedShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices")]
		public Dictionary<IndexName, IndexHealthStats>? Indices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("initializing_shards")]
		public int InitializingShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_data_nodes")]
		public int NumberOfDataNodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_in_flight_fetch")]
		public int NumberOfInFlightFetch
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_nodes")]
		public int NumberOfNodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_pending_tasks")]
		public int NumberOfPendingTasks
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("relocating_shards")]
		public int RelocatingShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public Health Status
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("task_max_waiting_in_queue_millis")]
		public EpochMillis TaskMaxWaitingInQueueMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("unassigned_shards")]
		public int UnassignedShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}