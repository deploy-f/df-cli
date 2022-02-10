using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class NodeDto {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets OwnerId
    /// </summary>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public string Host { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [DataMember(Name="port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "port")]
    public int? Port { get; set; }

    /// <summary>
    /// Gets or Sets DnsHost
    /// </summary>
    [DataMember(Name="dnsHost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dnsHost")]
    public string DnsHost { get; set; }

    /// <summary>
    /// Gets or Sets LimitCPU
    /// </summary>
    [DataMember(Name="limitCPU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limitCPU")]
    public float? LimitCPU { get; set; }

    /// <summary>
    /// Gets or Sets LimitRAM
    /// </summary>
    [DataMember(Name="limitRAM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limitRAM")]
    public float? LimitRAM { get; set; }

    /// <summary>
    /// Gets or Sets CreationTime
    /// </summary>
    [DataMember(Name="creationTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public NodeState State { get; set; }

    /// <summary>
    /// Gets or Sets IsShared
    /// </summary>
    [DataMember(Name="isShared", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isShared")]
    public bool? IsShared { get; set; }

    /// <summary>
    /// Gets or Sets Usage
    /// </summary>
    [DataMember(Name="usage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usage")]
    public NodeUsageData Usage { get; set; }

    /// <summary>
    /// Gets or Sets Services
    /// </summary>
    [DataMember(Name="services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "services")]
    public List<NodeServiceDto> Services { get; set; }

    /// <summary>
    /// Gets or Sets AverageCPUUsage
    /// </summary>
    [DataMember(Name="averageCPUUsage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageCPUUsage")]
    public int? AverageCPUUsage { get; set; }

    /// <summary>
    /// Gets or Sets AverageDiskUsage
    /// </summary>
    [DataMember(Name="averageDiskUsage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageDiskUsage")]
    public int? AverageDiskUsage { get; set; }

    /// <summary>
    /// Gets or Sets AverageRAMUsage
    /// </summary>
    [DataMember(Name="averageRAMUsage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageRAMUsage")]
    public int? AverageRAMUsage { get; set; }

    /// <summary>
    /// Gets or Sets TotalLoad
    /// </summary>
    [DataMember(Name="totalLoad", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalLoad")]
    public int? TotalLoad { get; set; }

    /// <summary>
    /// Gets or Sets IsApplicableForApps
    /// </summary>
    [DataMember(Name="isApplicableForApps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isApplicableForApps")]
    public bool? IsApplicableForApps { get; set; }

    /// <summary>
    /// Gets or Sets IsApplicableForMssql
    /// </summary>
    [DataMember(Name="isApplicableForMssql", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isApplicableForMssql")]
    public bool? IsApplicableForMssql { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  DnsHost: ").Append(DnsHost).Append("\n");
      sb.Append("  LimitCPU: ").Append(LimitCPU).Append("\n");
      sb.Append("  LimitRAM: ").Append(LimitRAM).Append("\n");
      sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  IsShared: ").Append(IsShared).Append("\n");
      sb.Append("  Usage: ").Append(Usage).Append("\n");
      sb.Append("  Services: ").Append(Services).Append("\n");
      sb.Append("  AverageCPUUsage: ").Append(AverageCPUUsage).Append("\n");
      sb.Append("  AverageDiskUsage: ").Append(AverageDiskUsage).Append("\n");
      sb.Append("  AverageRAMUsage: ").Append(AverageRAMUsage).Append("\n");
      sb.Append("  TotalLoad: ").Append(TotalLoad).Append("\n");
      sb.Append("  IsApplicableForApps: ").Append(IsApplicableForApps).Append("\n");
      sb.Append("  IsApplicableForMssql: ").Append(IsApplicableForMssql).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
