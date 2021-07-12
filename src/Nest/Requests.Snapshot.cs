// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elastic.Transport;
using Elasticsearch.Net;
using Nest.Utf8Json;
using Elasticsearch.Net.Specification.SnapshotApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface ICleanupRepositoryRequest : IRequest<CleanupRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}
	}

	///<summary>Request for CleanupRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html</para></summary>
	public partial class CleanupRepositoryRequest : PlainRequestBase<CleanupRepositoryRequestParameters>, ICleanupRepositoryRequest
	{
		protected ICleanupRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCleanupRepository;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/_cleanup</summary>
		///<param name = "repository">this parameter is required</param>
		public CleanupRepositoryRequest(Name repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CleanupRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ICleanupRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ICloneSnapshotRequest : IRequest<CloneSnapshotRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Name Snapshot
		{
			get;
		}

		[IgnoreDataMember]
		Name TargetSnapshot
		{
			get;
		}
	}

	///<summary>Request for Clone <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class CloneSnapshotRequest : PlainRequestBase<CloneSnapshotRequestParameters>, ICloneSnapshotRequest
	{
		protected ICloneSnapshotRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotClone;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		///<summary>/_snapshot/{repository}/{snapshot}/_clone/{target_snapshot}</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		///<param name = "targetSnapshot">this parameter is required</param>
		public CloneSnapshotRequest(Name repository, Name snapshot, Name targetSnapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot).Required("target_snapshot", targetSnapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CloneSnapshotRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ICloneSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Name ICloneSnapshotRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");
		[IgnoreDataMember]
		Name ICloneSnapshotRequest.TargetSnapshot => Self.RouteValues.Get<Name>("target_snapshot");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ISnapshotRequest : IRequest<SnapshotRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Name Snapshot
		{
			get;
		}
	}

	///<summary>Request for Snapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class SnapshotRequest : PlainRequestBase<SnapshotRequestParameters>, ISnapshotRequest
	{
		protected ISnapshotRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotSnapshot;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public SnapshotRequest(Name repository, Name snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SnapshotRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ISnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Name ISnapshotRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ICreateRepositoryRequest : IRequest<CreateRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}
	}

	///<summary>Request for CreateRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class CreateRepositoryRequest : PlainRequestBase<CreateRepositoryRequestParameters>, ICreateRepositoryRequest
	{
		protected ICreateRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreateRepository;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		///<summary>/_snapshot/{repository}</summary>
		///<param name = "repository">this parameter is required</param>
		public CreateRepositoryRequest(Name repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CreateRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ICreateRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Whether to verify the repository after creation</summary>
		public bool? Verify
		{
			get => Q<bool? >("verify");
			set => Q("verify", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IDeleteSnapshotRequest : IRequest<DeleteSnapshotRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Names Snapshot
		{
			get;
		}
	}

	///<summary>Request for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class DeleteSnapshotRequest : PlainRequestBase<DeleteSnapshotRequestParameters>, IDeleteSnapshotRequest
	{
		protected IDeleteSnapshotRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public DeleteSnapshotRequest(Name repository, Names snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteSnapshotRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IDeleteSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Names IDeleteSnapshotRequest.Snapshot => Self.RouteValues.Get<Names>("snapshot");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IDeleteRepositoryRequest : IRequest<DeleteRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Names RepositoryName
		{
			get;
		}
	}

	///<summary>Request for DeleteRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class DeleteRepositoryRequest : PlainRequestBase<DeleteRepositoryRequestParameters>, IDeleteRepositoryRequest
	{
		protected IDeleteRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDeleteRepository;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}</summary>
		///<param name = "repository">this parameter is required</param>
		public DeleteRepositoryRequest(Names repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IDeleteRepositoryRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetSnapshotRequest : IRequest<GetSnapshotRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Names Snapshot
		{
			get;
		}
	}

	///<summary>Request for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class GetSnapshotRequest : PlainRequestBase<GetSnapshotRequestParameters>, IGetSnapshotRequest
	{
		protected IGetSnapshotRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public GetSnapshotRequest(Name repository, Names snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetSnapshotRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IGetSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Names IGetSnapshotRequest.Snapshot => Self.RouteValues.Get<Names>("snapshot");
		// Request parameters
		///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Whether to include details of each index in the snapshot, if those details are available. Defaults to false.</summary>
		public bool? IndexDetails
		{
			get => Q<bool? >("index_details");
			set => Q("index_details", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Whether to show verbose snapshot info or only show the basic info found in the repository index blob</summary>
		public bool? Verbose
		{
			get => Q<bool? >("verbose");
			set => Q("verbose", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetRepositoryRequest : IRequest<GetRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Names RepositoryName
		{
			get;
		}
	}

	///<summary>Request for GetRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class GetRepositoryRequest : PlainRequestBase<GetRepositoryRequestParameters>, IGetRepositoryRequest
	{
		protected IGetRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGetRepository;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot</summary>
		public GetRepositoryRequest(): base()
		{
		}

		///<summary>/_snapshot/{repository}</summary>
		///<param name = "repository">Optional, accepts null</param>
		public GetRepositoryRequest(Names repository): base(r => r.Optional("repository", repository))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IGetRepositoryRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");
		// Request parameters
		///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IAnalyzeRepositoryRequest : IRequest<AnalyzeRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}
	}

	///<summary>Request for AnalyzeRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class AnalyzeRepositoryRequest : PlainRequestBase<AnalyzeRepositoryRequestParameters>, IAnalyzeRepositoryRequest
	{
		protected IAnalyzeRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotAnalyzeRepository;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/_analyze</summary>
		///<param name = "repository">this parameter is required</param>
		public AnalyzeRepositoryRequest(Name repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected AnalyzeRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IAnalyzeRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		// Request parameters
		///<summary>Number of blobs to create during the test. Defaults to 100.</summary>
		public long? BlobCount
		{
			get => Q<long? >("blob_count");
			set => Q("blob_count", value);
		}

		///<summary>Number of operations to run concurrently during the test. Defaults to 10.</summary>
		public long? Concurrency
		{
			get => Q<long? >("concurrency");
			set => Q("concurrency", value);
		}

		///<summary>Whether to return detailed results or a summary. Defaults to 'false' so that only the summary is returned.</summary>
		public bool? Detailed
		{
			get => Q<bool? >("detailed");
			set => Q("detailed", value);
		}

		///<summary>
		/// Number of nodes on which to perform an early read on a blob, i.e. before writing has completed. Early reads are rare actions so the
		/// 'rare_action_probability' parameter is also relevant. Defaults to 2.
		///</summary>
		public long? EarlyReadNodeCount
		{
			get => Q<long? >("early_read_node_count");
			set => Q("early_read_node_count", value);
		}

		///<summary>Maximum size of a blob to create during the test, e.g '1gb' or '100mb'. Defaults to '10mb'.</summary>
		public string MaxBlobSize
		{
			get => Q<string>("max_blob_size");
			set => Q("max_blob_size", value);
		}

		///<summary>Maximum total size of all blobs to create during the test, e.g '1tb' or '100gb'. Defaults to '1gb'.</summary>
		public string MaxTotalDataSize
		{
			get => Q<string>("max_total_data_size");
			set => Q("max_total_data_size", value);
		}

		///<summary>Probability of taking a rare action such as an early read or an overwrite. Defaults to 0.02.</summary>
		public long? RareActionProbability
		{
			get => Q<long? >("rare_action_probability");
			set => Q("rare_action_probability", value);
		}

		///<summary>Whether to rarely abort writes before they complete. Defaults to 'true'.</summary>
		public bool? RarelyAbortWrites
		{
			get => Q<bool? >("rarely_abort_writes");
			set => Q("rarely_abort_writes", value);
		}

		///<summary>Number of nodes on which to read a blob after writing. Defaults to 10.</summary>
		public long? ReadNodeCount
		{
			get => Q<long? >("read_node_count");
			set => Q("read_node_count", value);
		}

		///<summary>Seed for the random number generator used to create the test workload. Defaults to a random value.</summary>
		public long? Seed
		{
			get => Q<long? >("seed");
			set => Q("seed", value);
		}

		///<summary>Explicit operation timeout. Defaults to '30s'.</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IRestoreRequest : IRequest<RestoreRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Name Snapshot
		{
			get;
		}
	}

	///<summary>Request for Restore <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class RestoreRequest : PlainRequestBase<RestoreRequestParameters>, IRestoreRequest
	{
		protected IRestoreRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotRestore;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		///<summary>/_snapshot/{repository}/{snapshot}/_restore</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public RestoreRequest(Name repository, Name snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected RestoreRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IRestoreRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Name IRestoreRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ISnapshotStatusRequest : IRequest<SnapshotStatusRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Names Snapshot
		{
			get;
		}
	}

	///<summary>Request for Status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class SnapshotStatusRequest : PlainRequestBase<SnapshotStatusRequestParameters>, ISnapshotStatusRequest
	{
		protected ISnapshotStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/_status</summary>
		public SnapshotStatusRequest(): base()
		{
		}

		///<summary>/_snapshot/{repository}/_status</summary>
		///<param name = "repository">Optional, accepts null</param>
		public SnapshotStatusRequest(Name repository): base(r => r.Optional("repository", repository))
		{
		}

		///<summary>/_snapshot/{repository}/{snapshot}/_status</summary>
		///<param name = "repository">Optional, accepts null</param>
		///<param name = "snapshot">Optional, accepts null</param>
		public SnapshotStatusRequest(Name repository, Names snapshot): base(r => r.Optional("repository", repository).Optional("snapshot", snapshot))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ISnapshotStatusRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Names ISnapshotStatusRequest.Snapshot => Self.RouteValues.Get<Names>("snapshot");
		// Request parameters
		///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IVerifyRepositoryRequest : IRequest<VerifyRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}
	}

	///<summary>Request for VerifyRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public partial class VerifyRepositoryRequest : PlainRequestBase<VerifyRepositoryRequestParameters>, IVerifyRepositoryRequest
	{
		protected IVerifyRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotVerifyRepository;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/_verify</summary>
		///<param name = "repository">this parameter is required</param>
		public VerifyRepositoryRequest(Name repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected VerifyRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IVerifyRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}
}