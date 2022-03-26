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

namespace Elastic.Clients.Elasticsearch
{
	internal static class ApiUrlsLookups
	{
		internal static ApiUrls AsyncSearchStatus = new ApiUrls(new[] { "/_async_search/status/{id}" });
		internal static ApiUrls AsyncSearchSubmit = new ApiUrls(new[] { "/_async_search", "/{index}/_async_search" });
		internal static ApiUrls AsyncSearchDelete = new ApiUrls(new[] { "/_async_search/{id}" });
		internal static ApiUrls AsyncSearchGet = new ApiUrls(new[] { "/_async_search/{id}" });
		internal static ApiUrls NoNamespaceBulk = new ApiUrls(new[] { "/_bulk", "/{index}/_bulk" });
		internal static ApiUrls NoNamespaceClosePointInTime = new ApiUrls(new[] { "/_pit" });
		internal static ApiUrls ClusterAllocationExplain = new ApiUrls(new[] { "/_cluster/allocation/explain" });
		internal static ApiUrls ClusterHealth = new ApiUrls(new[] { "/_cluster/health", "/_cluster/health/{index}" });
		internal static ApiUrls ClusterPendingTasks = new ApiUrls(new[] { "/_cluster/pending_tasks" });
		internal static ApiUrls ClusterState = new ApiUrls(new[] { "/_cluster/state", "/_cluster/state/{metric}", "/_cluster/state/{metric}/{index}" });
		internal static ApiUrls NoNamespaceCount = new ApiUrls(new[] { "/_count", "/{index}/_count" });
		internal static ApiUrls NoNamespaceCreate = new ApiUrls(new[] { "/{index}/_create/{id}" });
		internal static ApiUrls NoNamespaceDelete = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls EnrichDeletePolicy = new ApiUrls(new[] { "/_enrich/policy/{name}" });
		internal static ApiUrls EnrichExecutePolicy = new ApiUrls(new[] { "/_enrich/policy/{name}/_execute" });
		internal static ApiUrls EnrichGetPolicy = new ApiUrls(new[] { "/_enrich/policy/{name}", "/_enrich/policy" });
		internal static ApiUrls EnrichPutPolicy = new ApiUrls(new[] { "/_enrich/policy/{name}" });
		internal static ApiUrls EnrichStats = new ApiUrls(new[] { "/_enrich/_stats" });
		internal static ApiUrls EqlDelete = new ApiUrls(new[] { "/_eql/search/{id}" });
		internal static ApiUrls EqlGetStatus = new ApiUrls(new[] { "/_eql/search/status/{id}" });
		internal static ApiUrls EqlSearch = new ApiUrls(new[] { "/{index}/_eql/search" });
		internal static ApiUrls EqlGet = new ApiUrls(new[] { "/_eql/search/{id}" });
		internal static ApiUrls NoNamespaceExists = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls NoNamespaceGet = new ApiUrls(new[] { "/{index}/_doc/{id}" });
		internal static ApiUrls GraphExplore = new ApiUrls(new[] { "/{index}/_graph/explore" });
		internal static ApiUrls IndexLifecycleManagementDeleteLifecycle = new ApiUrls(new[] { "/_ilm/policy/{policy}" });
		internal static ApiUrls IndexLifecycleManagementExplainLifecycle = new ApiUrls(new[] { "/{index}/_ilm/explain" });
		internal static ApiUrls IndexLifecycleManagementGetLifecycle = new ApiUrls(new[] { "/_ilm/policy/{policy}", "/_ilm/policy" });
		internal static ApiUrls IndexLifecycleManagementGetStatus = new ApiUrls(new[] { "/_ilm/status" });
		internal static ApiUrls IndexLifecycleManagementMigrateToDataTiers = new ApiUrls(new[] { "/_ilm/migrate_to_data_tiers" });
		internal static ApiUrls IndexLifecycleManagementMoveToStep = new ApiUrls(new[] { "/_ilm/move/{index}" });
		internal static ApiUrls IndexLifecycleManagementPutLifecycle = new ApiUrls(new[] { "/_ilm/policy/{policy}" });
		internal static ApiUrls IndexLifecycleManagementRemovePolicy = new ApiUrls(new[] { "/{index}/_ilm/remove" });
		internal static ApiUrls IndexLifecycleManagementRetry = new ApiUrls(new[] { "/{index}/_ilm/retry" });
		internal static ApiUrls IndexLifecycleManagementStart = new ApiUrls(new[] { "/_ilm/start" });
		internal static ApiUrls IndexLifecycleManagementStop = new ApiUrls(new[] { "/_ilm/stop" });
		internal static ApiUrls IndexManagementDelete = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementExists = new ApiUrls(new[] { "/{index}" });
		internal static ApiUrls IndexManagementRefresh = new ApiUrls(new[] { "/_refresh", "/{index}/_refresh" });
		internal static ApiUrls NoNamespaceIndex = new ApiUrls(new[] { "/{index}/_doc/{id}", "/{index}/_doc" });
		internal static ApiUrls IngestDeletePipeline = new ApiUrls(new[] { "/_ingest/pipeline/{id}" });
		internal static ApiUrls IngestGeoIpStats = new ApiUrls(new[] { "/_ingest/geoip/stats" });
		internal static ApiUrls IngestGetPipeline = new ApiUrls(new[] { "/_ingest/pipeline", "/_ingest/pipeline/{id}" });
		internal static ApiUrls IngestProcessorGrok = new ApiUrls(new[] { "/_ingest/processor/grok" });
		internal static ApiUrls IngestPutPipeline = new ApiUrls(new[] { "/_ingest/pipeline/{id}" });
		internal static ApiUrls IngestSimulate = new ApiUrls(new[] { "/_ingest/pipeline/_simulate", "/_ingest/pipeline/{id}/_simulate" });
		internal static ApiUrls NodesHotThreads = new ApiUrls(new[] { "/_nodes/hot_threads", "/_nodes/{node_id}/hot_threads" });
		internal static ApiUrls NodesInfo = new ApiUrls(new[] { "/_nodes", "/_nodes/{node_id}", "/_nodes/{metric}", "/_nodes/{node_id}/{metric}" });
		internal static ApiUrls NodesReloadSecureSettings = new ApiUrls(new[] { "/_nodes/reload_secure_settings", "/_nodes/{node_id}/reload_secure_settings" });
		internal static ApiUrls NodesStats = new ApiUrls(new[] { "/_nodes/stats", "/_nodes/{node_id}/stats", "/_nodes/stats/{metric}", "/_nodes/{node_id}/stats/{metric}", "/_nodes/stats/{metric}/{index_metric}", "/_nodes/{node_id}/stats/{metric}/{index_metric}" });
		internal static ApiUrls NodesUsage = new ApiUrls(new[] { "/_nodes/usage", "/_nodes/{node_id}/usage", "/_nodes/usage/{metric}", "/_nodes/{node_id}/usage/{metric}" });
		internal static ApiUrls NoNamespaceOpenPointInTime = new ApiUrls(new[] { "/{index}/_pit" });
		internal static ApiUrls NoNamespacePing = new ApiUrls(new[] { "/" });
		internal static ApiUrls SearchableSnapshotsCacheStats = new ApiUrls(new[] { "/_searchable_snapshots/cache/stats", "/_searchable_snapshots/{node_id}/cache/stats" });
		internal static ApiUrls SearchableSnapshotsClearCache = new ApiUrls(new[] { "/_searchable_snapshots/cache/clear", "/{index}/_searchable_snapshots/cache/clear" });
		internal static ApiUrls SearchableSnapshotsMount = new ApiUrls(new[] { "/_snapshot/{repository}/{snapshot}/_mount" });
		internal static ApiUrls SearchableSnapshotsStats = new ApiUrls(new[] { "/_searchable_snapshots/stats", "/{index}/_searchable_snapshots/stats" });
		internal static ApiUrls NoNamespaceSearch = new ApiUrls(new[] { "/_search", "/{index}/_search" });
		internal static ApiUrls SnapshotLifecycleManagementDeleteLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}" });
		internal static ApiUrls SnapshotLifecycleManagementExecuteLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}/_execute" });
		internal static ApiUrls SnapshotLifecycleManagementExecuteRetention = new ApiUrls(new[] { "/_slm/_execute_retention" });
		internal static ApiUrls SnapshotLifecycleManagementGetLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}", "/_slm/policy" });
		internal static ApiUrls SnapshotLifecycleManagementGetStats = new ApiUrls(new[] { "/_slm/stats" });
		internal static ApiUrls SnapshotLifecycleManagementGetStatus = new ApiUrls(new[] { "/_slm/status" });
		internal static ApiUrls SnapshotLifecycleManagementPutLifecycle = new ApiUrls(new[] { "/_slm/policy/{policy_id}" });
		internal static ApiUrls SnapshotLifecycleManagementStart = new ApiUrls(new[] { "/_slm/start" });
		internal static ApiUrls SnapshotLifecycleManagementStop = new ApiUrls(new[] { "/_slm/stop" });
		internal static ApiUrls NoNamespaceGetSource = new ApiUrls(new[] { "/{index}/_source/{id}" });
		internal static ApiUrls SqlClearCursor = new ApiUrls(new[] { "/_sql/close" });
		internal static ApiUrls SqlDeleteAsync = new ApiUrls(new[] { "/_sql/async/delete/{id}" });
		internal static ApiUrls SqlGetAsync = new ApiUrls(new[] { "/_sql/async/{id}" });
		internal static ApiUrls SqlGetAsyncStatus = new ApiUrls(new[] { "/_sql/async/status/{id}" });
		internal static ApiUrls SqlQuery = new ApiUrls(new[] { "/_sql" });
		internal static ApiUrls TasksGet = new ApiUrls(new[] { "/_tasks/{task_id}" });
		internal static ApiUrls TasksCancel = new ApiUrls(new[] { "/_tasks/_cancel", "/_tasks/{task_id}/_cancel" });
		internal static ApiUrls TasksList = new ApiUrls(new[] { "/_tasks" });
		internal static ApiUrls NoNamespaceUpdate = new ApiUrls(new[] { "/{index}/_update/{id}" });
	}
}