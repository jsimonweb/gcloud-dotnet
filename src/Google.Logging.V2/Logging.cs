// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/logging/v2/logging.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Logging.V2 {

  /// <summary>Holder for reflection information generated from google/logging/v2/logging.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class LoggingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/logging/v2/logging.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoggingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9nb29nbGUvbG9nZ2luZy92Mi9sb2dnaW5nLnByb3RvEhFnb29nbGUubG9n",
            "Z2luZy52MhocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxojZ29vZ2xl",
            "L2FwaS9tb25pdG9yZWRfcmVzb3VyY2UucHJvdG8aIWdvb2dsZS9sb2dnaW5n",
            "L3YyL2xvZ19lbnRyeS5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnBy",
            "b3RvGhdnb29nbGUvcnBjL3N0YXR1cy5wcm90byIkChBEZWxldGVMb2dSZXF1",
            "ZXN0EhAKCGxvZ19uYW1lGAEgASgJIv8BChZXcml0ZUxvZ0VudHJpZXNSZXF1",
            "ZXN0EhAKCGxvZ19uYW1lGAEgASgJEi8KCHJlc291cmNlGAIgASgLMh0uZ29v",
            "Z2xlLmFwaS5Nb25pdG9yZWRSZXNvdXJjZRJFCgZsYWJlbHMYAyADKAsyNS5n",
            "b29nbGUubG9nZ2luZy52Mi5Xcml0ZUxvZ0VudHJpZXNSZXF1ZXN0LkxhYmVs",
            "c0VudHJ5EiwKB2VudHJpZXMYBCADKAsyGy5nb29nbGUubG9nZ2luZy52Mi5M",
            "b2dFbnRyeRotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY",
            "AiABKAk6AjgBIhkKF1dyaXRlTG9nRW50cmllc1Jlc3BvbnNlInUKFUxpc3RM",
            "b2dFbnRyaWVzUmVxdWVzdBITCgtwcm9qZWN0X2lkcxgBIAMoCRIOCgZmaWx0",
            "ZXIYAiABKAkSEAoIb3JkZXJfYnkYAyABKAkSEQoJcGFnZV9zaXplGAQgASgF",
            "EhIKCnBhZ2VfdG9rZW4YBSABKAkiXwoWTGlzdExvZ0VudHJpZXNSZXNwb25z",
            "ZRIsCgdlbnRyaWVzGAEgAygLMhsuZ29vZ2xlLmxvZ2dpbmcudjIuTG9nRW50",
            "cnkSFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJIlAKJ0xpc3RNb25pdG9yZWRS",
            "ZXNvdXJjZURlc2NyaXB0b3JzUmVxdWVzdBIRCglwYWdlX3NpemUYASABKAUS",
            "EgoKcGFnZV90b2tlbhgCIAEoCSKKAQooTGlzdE1vbml0b3JlZFJlc291cmNl",
            "RGVzY3JpcHRvcnNSZXNwb25zZRJFChRyZXNvdXJjZV9kZXNjcmlwdG9ycxgB",
            "IAMoCzInLmdvb2dsZS5hcGkuTW9uaXRvcmVkUmVzb3VyY2VEZXNjcmlwdG9y",
            "EhcKD25leHRfcGFnZV90b2tlbhgCIAEoCTLwBAoQTG9nZ2luZ1NlcnZpY2VW",
            "MhJ3CglEZWxldGVMb2cSIy5nb29nbGUubG9nZ2luZy52Mi5EZWxldGVMb2dS",
            "ZXF1ZXN0GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5Ii2C0+STAicqJS92MmJl",
            "dGExL3tsb2dfbmFtZT1wcm9qZWN0cy8qL2xvZ3MvKn0SiwEKD1dyaXRlTG9n",
            "RW50cmllcxIpLmdvb2dsZS5sb2dnaW5nLnYyLldyaXRlTG9nRW50cmllc1Jl",
            "cXVlc3QaKi5nb29nbGUubG9nZ2luZy52Mi5Xcml0ZUxvZ0VudHJpZXNSZXNw",
            "b25zZSIhgtPkkwIbIhYvdjJiZXRhMS9lbnRyaWVzOndyaXRlOgEqEocBCg5M",
            "aXN0TG9nRW50cmllcxIoLmdvb2dsZS5sb2dnaW5nLnYyLkxpc3RMb2dFbnRy",
            "aWVzUmVxdWVzdBopLmdvb2dsZS5sb2dnaW5nLnYyLkxpc3RMb2dFbnRyaWVz",
            "UmVzcG9uc2UiIILT5JMCGiIVL3YyYmV0YTEvZW50cmllczpsaXN0OgEqEsoB",
            "CiBMaXN0TW9uaXRvcmVkUmVzb3VyY2VEZXNjcmlwdG9ycxI6Lmdvb2dsZS5s",
            "b2dnaW5nLnYyLkxpc3RNb25pdG9yZWRSZXNvdXJjZURlc2NyaXB0b3JzUmVx",
            "dWVzdBo7Lmdvb2dsZS5sb2dnaW5nLnYyLkxpc3RNb25pdG9yZWRSZXNvdXJj",
            "ZURlc2NyaXB0b3JzUmVzcG9uc2UiLYLT5JMCJxIlL3YyYmV0YTEvbW9uaXRv",
            "cmVkUmVzb3VyY2VEZXNjcmlwdG9yc0IqChVjb20uZ29vZ2xlLmxvZ2dpbmcu",
            "djJCDExvZ2dpbmdQcm90b1AB+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.MonitoredResourceReflection.Descriptor, global::Google.Logging.V2.LogEntryReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.DeleteLogRequest), global::Google.Logging.V2.DeleteLogRequest.Parser, new[]{ "LogName" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.WriteLogEntriesRequest), global::Google.Logging.V2.WriteLogEntriesRequest.Parser, new[]{ "LogName", "Resource", "Labels", "Entries" }, null, null, new pbr::GeneratedCodeInfo[] { null, }),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.WriteLogEntriesResponse), global::Google.Logging.V2.WriteLogEntriesResponse.Parser, null, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.ListLogEntriesRequest), global::Google.Logging.V2.ListLogEntriesRequest.Parser, new[]{ "ProjectIds", "Filter", "OrderBy", "PageSize", "PageToken" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.ListLogEntriesResponse), global::Google.Logging.V2.ListLogEntriesResponse.Parser, new[]{ "Entries", "NextPageToken" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.ListMonitoredResourceDescriptorsRequest), global::Google.Logging.V2.ListMonitoredResourceDescriptorsRequest.Parser, new[]{ "PageSize", "PageToken" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Google.Logging.V2.ListMonitoredResourceDescriptorsResponse), global::Google.Logging.V2.ListMonitoredResourceDescriptorsResponse.Parser, new[]{ "ResourceDescriptors", "NextPageToken" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  The parameters to DeleteLog.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DeleteLogRequest : pb::IMessage<DeleteLogRequest> {
    private static readonly pb::MessageParser<DeleteLogRequest> _parser = new pb::MessageParser<DeleteLogRequest>(() => new DeleteLogRequest());
    public static pb::MessageParser<DeleteLogRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DeleteLogRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DeleteLogRequest(DeleteLogRequest other) : this() {
      logName_ = other.logName_;
    }

    public DeleteLogRequest Clone() {
      return new DeleteLogRequest(this);
    }

    /// <summary>Field number for the "log_name" field.</summary>
    public const int LogNameFieldNumber = 1;
    private string logName_ = "";
    /// <summary>
    ///  Required. The resource name of the log to delete.  Example:
    ///  `"projects/my-project/logs/syslog"`.
    /// </summary>
    public string LogName {
      get { return logName_; }
      set {
        logName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DeleteLogRequest);
    }

    public bool Equals(DeleteLogRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LogName != other.LogName) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (LogName.Length != 0) hash ^= LogName.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (LogName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LogName);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (LogName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogName);
      }
      return size;
    }

    public void MergeFrom(DeleteLogRequest other) {
      if (other == null) {
        return;
      }
      if (other.LogName.Length != 0) {
        LogName = other.LogName;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            LogName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to WriteLogEntries.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class WriteLogEntriesRequest : pb::IMessage<WriteLogEntriesRequest> {
    private static readonly pb::MessageParser<WriteLogEntriesRequest> _parser = new pb::MessageParser<WriteLogEntriesRequest>(() => new WriteLogEntriesRequest());
    public static pb::MessageParser<WriteLogEntriesRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public WriteLogEntriesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public WriteLogEntriesRequest(WriteLogEntriesRequest other) : this() {
      logName_ = other.logName_;
      Resource = other.resource_ != null ? other.Resource.Clone() : null;
      labels_ = other.labels_.Clone();
      entries_ = other.entries_.Clone();
    }

    public WriteLogEntriesRequest Clone() {
      return new WriteLogEntriesRequest(this);
    }

    /// <summary>Field number for the "log_name" field.</summary>
    public const int LogNameFieldNumber = 1;
    private string logName_ = "";
    /// <summary>
    ///  Optional. A default log resource name for those log entries in `entries`
    ///  that do not specify their own `logName`.  Example:
    ///  `"projects/my-project/logs/syslog"`.  See
    ///  [LogEntry][google.logging.v2.LogEntry].
    /// </summary>
    public string LogName {
      get { return logName_; }
      set {
        logName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 2;
    private global::Google.Api.MonitoredResource resource_;
    /// <summary>
    ///  Optional. A default monitored resource for those log entries in `entries`
    ///  that do not specify their own `resource`.
    /// </summary>
    public global::Google.Api.MonitoredResource Resource {
      get { return resource_; }
      set {
        resource_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 3;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 26);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    ///  Optional. User-defined `key:value` items that are added to
    ///  the `labels` field of each log entry in `entries`, except when a log
    ///  entry specifies its own `key:value` item with the same key.
    ///  Example: `{ "size": "large", "color":"red" }`
    /// </summary>
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Logging.V2.LogEntry> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Logging.V2.LogEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Logging.V2.LogEntry> entries_ = new pbc::RepeatedField<global::Google.Logging.V2.LogEntry>();
    /// <summary>
    ///  Required. The log entries to write. The log entries must have values for
    ///  all required fields.
    /// </summary>
    public pbc::RepeatedField<global::Google.Logging.V2.LogEntry> Entries {
      get { return entries_; }
    }

    public override bool Equals(object other) {
      return Equals(other as WriteLogEntriesRequest);
    }

    public bool Equals(WriteLogEntriesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LogName != other.LogName) return false;
      if (!object.Equals(Resource, other.Resource)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if(!entries_.Equals(other.entries_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (LogName.Length != 0) hash ^= LogName.GetHashCode();
      if (resource_ != null) hash ^= Resource.GetHashCode();
      hash ^= Labels.GetHashCode();
      hash ^= entries_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (LogName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LogName);
      }
      if (resource_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Resource);
      }
      labels_.WriteTo(output, _map_labels_codec);
      entries_.WriteTo(output, _repeated_entries_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (LogName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogName);
      }
      if (resource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Resource);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      size += entries_.CalculateSize(_repeated_entries_codec);
      return size;
    }

    public void MergeFrom(WriteLogEntriesRequest other) {
      if (other == null) {
        return;
      }
      if (other.LogName.Length != 0) {
        LogName = other.LogName;
      }
      if (other.resource_ != null) {
        if (resource_ == null) {
          resource_ = new global::Google.Api.MonitoredResource();
        }
        Resource.MergeFrom(other.Resource);
      }
      labels_.Add(other.labels_);
      entries_.Add(other.entries_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            LogName = input.ReadString();
            break;
          }
          case 18: {
            if (resource_ == null) {
              resource_ = new global::Google.Api.MonitoredResource();
            }
            input.ReadMessage(resource_);
            break;
          }
          case 26: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 34: {
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Result returned from WriteLogEntries.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class WriteLogEntriesResponse : pb::IMessage<WriteLogEntriesResponse> {
    private static readonly pb::MessageParser<WriteLogEntriesResponse> _parser = new pb::MessageParser<WriteLogEntriesResponse>(() => new WriteLogEntriesResponse());
    public static pb::MessageParser<WriteLogEntriesResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public WriteLogEntriesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public WriteLogEntriesResponse(WriteLogEntriesResponse other) : this() {
    }

    public WriteLogEntriesResponse Clone() {
      return new WriteLogEntriesResponse(this);
    }

    public override bool Equals(object other) {
      return Equals(other as WriteLogEntriesResponse);
    }

    public bool Equals(WriteLogEntriesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(WriteLogEntriesResponse other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to `ListLogEntries`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListLogEntriesRequest : pb::IMessage<ListLogEntriesRequest> {
    private static readonly pb::MessageParser<ListLogEntriesRequest> _parser = new pb::MessageParser<ListLogEntriesRequest>(() => new ListLogEntriesRequest());
    public static pb::MessageParser<ListLogEntriesRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListLogEntriesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListLogEntriesRequest(ListLogEntriesRequest other) : this() {
      projectIds_ = other.projectIds_.Clone();
      filter_ = other.filter_;
      orderBy_ = other.orderBy_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
    }

    public ListLogEntriesRequest Clone() {
      return new ListLogEntriesRequest(this);
    }

    /// <summary>Field number for the "project_ids" field.</summary>
    public const int ProjectIdsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_projectIds_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> projectIds_ = new pbc::RepeatedField<string>();
    /// <summary>
    ///  Required. One or more project IDs or project numbers from which to retrieve
    ///  log entries.  Examples of a project ID: `"my-project-1A"`, `"1234567890"`.
    /// </summary>
    public pbc::RepeatedField<string> ProjectIds {
      get { return projectIds_; }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 2;
    private string filter_ = "";
    /// <summary>
    ///  Optional. An [advanced logs filter](/logging/docs/view/advanced_filters).
    ///  The filter is compared against all log entries in the projects specified by
    ///  `projectIds`.  Only entries that match the filter are retrieved.  An empty
    ///  filter matches all log entries.
    /// </summary>
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "order_by" field.</summary>
    public const int OrderByFieldNumber = 3;
    private string orderBy_ = "";
    /// <summary>
    ///  Optional. How the results should be sorted.  Presently, the only permitted
    ///  values are `"timestamp"` (default) and `"timestamp desc"`.  The first
    ///  option returns entries in order of increasing values of
    ///  `LogEntry.timestamp` (oldest first), and the second option returns entries
    ///  in order of decreasing timestamps (newest first).  Entries with equal
    ///  timestamps are returned in order of `LogEntry.insertId`.
    /// </summary>
    public string OrderBy {
      get { return orderBy_; }
      set {
        orderBy_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 4;
    private int pageSize_;
    /// <summary>
    ///  Optional. The maximum number of results to return from this request.  Fewer
    ///  results might be returned. You must check for the `nextPageToken` result to
    ///  determine if additional results are available, which you can retrieve by
    ///  passing the `nextPageToken` value in the `pageToken` parameter to the next
    ///  request.
    /// </summary>
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 5;
    private string pageToken_ = "";
    /// <summary>
    ///  Optional. If the `pageToken` request parameter is supplied, then the next
    ///  page of results in the set are retrieved.  The `pageToken` parameter must
    ///  be set with the value of the `nextPageToken` result parameter from the
    ///  previous request.  The values of `projectIds`, `filter`, and `orderBy` must
    ///  be the same as in the previous request.
    /// </summary>
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListLogEntriesRequest);
    }

    public bool Equals(ListLogEntriesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!projectIds_.Equals(other.projectIds_)) return false;
      if (Filter != other.Filter) return false;
      if (OrderBy != other.OrderBy) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= projectIds_.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      projectIds_.WriteTo(output, _repeated_projectIds_codec);
      if (Filter.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OrderBy);
      }
      if (PageSize != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PageToken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += projectIds_.CalculateSize(_repeated_projectIds_codec);
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (OrderBy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrderBy);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      return size;
    }

    public void MergeFrom(ListLogEntriesRequest other) {
      if (other == null) {
        return;
      }
      projectIds_.Add(other.projectIds_);
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      if (other.OrderBy.Length != 0) {
        OrderBy = other.OrderBy;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            projectIds_.AddEntriesFrom(input, _repeated_projectIds_codec);
            break;
          }
          case 18: {
            Filter = input.ReadString();
            break;
          }
          case 26: {
            OrderBy = input.ReadString();
            break;
          }
          case 32: {
            PageSize = input.ReadInt32();
            break;
          }
          case 42: {
            PageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Result returned from `ListLogEntries`.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListLogEntriesResponse : pb::IMessage<ListLogEntriesResponse> {
    private static readonly pb::MessageParser<ListLogEntriesResponse> _parser = new pb::MessageParser<ListLogEntriesResponse>(() => new ListLogEntriesResponse());
    public static pb::MessageParser<ListLogEntriesResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListLogEntriesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListLogEntriesResponse(ListLogEntriesResponse other) : this() {
      entries_ = other.entries_.Clone();
      nextPageToken_ = other.nextPageToken_;
    }

    public ListLogEntriesResponse Clone() {
      return new ListLogEntriesResponse(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Logging.V2.LogEntry> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Logging.V2.LogEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Logging.V2.LogEntry> entries_ = new pbc::RepeatedField<global::Google.Logging.V2.LogEntry>();
    /// <summary>
    ///  A list of log entries.
    /// </summary>
    public pbc::RepeatedField<global::Google.Logging.V2.LogEntry> Entries {
      get { return entries_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    ///  If there are more results than were returned, then `nextPageToken` is
    ///  given a value in the response.  To get the next batch of results, call
    ///  this method again using the value of `nextPageToken` as `pageToken`.
    /// </summary>
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListLogEntriesResponse);
    }

    public bool Equals(ListLogEntriesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      entries_.WriteTo(output, _repeated_entries_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      return size;
    }

    public void MergeFrom(ListLogEntriesResponse other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The parameters to ListMonitoredResourceDescriptors
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListMonitoredResourceDescriptorsRequest : pb::IMessage<ListMonitoredResourceDescriptorsRequest> {
    private static readonly pb::MessageParser<ListMonitoredResourceDescriptorsRequest> _parser = new pb::MessageParser<ListMonitoredResourceDescriptorsRequest>(() => new ListMonitoredResourceDescriptorsRequest());
    public static pb::MessageParser<ListMonitoredResourceDescriptorsRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListMonitoredResourceDescriptorsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListMonitoredResourceDescriptorsRequest(ListMonitoredResourceDescriptorsRequest other) : this() {
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
    }

    public ListMonitoredResourceDescriptorsRequest Clone() {
      return new ListMonitoredResourceDescriptorsRequest(this);
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 1;
    private int pageSize_;
    /// <summary>
    ///  Optional. The maximum number of results to return from this request.  Fewer
    ///  results might be returned. You must check for the `nextPageToken` result to
    ///  determine if additional results are available, which you can retrieve by
    ///  passing the `nextPageToken` value in the `pageToken` parameter to the next
    ///  request.
    /// </summary>
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 2;
    private string pageToken_ = "";
    /// <summary>
    ///  Optional. If the `pageToken` request parameter is supplied, then the next
    ///  page of results in the set are retrieved.  The `pageToken` parameter must
    ///  be set with the value of the `nextPageToken` result parameter from the
    ///  previous request.
    /// </summary>
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListMonitoredResourceDescriptorsRequest);
    }

    public bool Equals(ListMonitoredResourceDescriptorsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PageSize != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      return size;
    }

    public void MergeFrom(ListMonitoredResourceDescriptorsRequest other) {
      if (other == null) {
        return;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PageSize = input.ReadInt32();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Result returned from ListMonitoredResourceDescriptors.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ListMonitoredResourceDescriptorsResponse : pb::IMessage<ListMonitoredResourceDescriptorsResponse> {
    private static readonly pb::MessageParser<ListMonitoredResourceDescriptorsResponse> _parser = new pb::MessageParser<ListMonitoredResourceDescriptorsResponse>(() => new ListMonitoredResourceDescriptorsResponse());
    public static pb::MessageParser<ListMonitoredResourceDescriptorsResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Logging.V2.LoggingReflection.Descriptor.MessageTypes[6]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ListMonitoredResourceDescriptorsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ListMonitoredResourceDescriptorsResponse(ListMonitoredResourceDescriptorsResponse other) : this() {
      resourceDescriptors_ = other.resourceDescriptors_.Clone();
      nextPageToken_ = other.nextPageToken_;
    }

    public ListMonitoredResourceDescriptorsResponse Clone() {
      return new ListMonitoredResourceDescriptorsResponse(this);
    }

    /// <summary>Field number for the "resource_descriptors" field.</summary>
    public const int ResourceDescriptorsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Api.MonitoredResourceDescriptor> _repeated_resourceDescriptors_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Api.MonitoredResourceDescriptor.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.MonitoredResourceDescriptor> resourceDescriptors_ = new pbc::RepeatedField<global::Google.Api.MonitoredResourceDescriptor>();
    /// <summary>
    ///  A list of resource descriptors.
    /// </summary>
    public pbc::RepeatedField<global::Google.Api.MonitoredResourceDescriptor> ResourceDescriptors {
      get { return resourceDescriptors_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    ///  If there are more results than were returned, then `nextPageToken` is
    ///  returned in the response.  To get the next batch of results, call this
    ///  method again using the value of `nextPageToken` as `pageToken`.
    /// </summary>
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ListMonitoredResourceDescriptorsResponse);
    }

    public bool Equals(ListMonitoredResourceDescriptorsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!resourceDescriptors_.Equals(other.resourceDescriptors_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= resourceDescriptors_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      resourceDescriptors_.WriteTo(output, _repeated_resourceDescriptors_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += resourceDescriptors_.CalculateSize(_repeated_resourceDescriptors_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      return size;
    }

    public void MergeFrom(ListMonitoredResourceDescriptorsResponse other) {
      if (other == null) {
        return;
      }
      resourceDescriptors_.Add(other.resourceDescriptors_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            resourceDescriptors_.AddEntriesFrom(input, _repeated_resourceDescriptors_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
