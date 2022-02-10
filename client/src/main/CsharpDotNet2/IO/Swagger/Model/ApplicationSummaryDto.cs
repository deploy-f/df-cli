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
  public class ApplicationSummaryDto {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets CreatedTS
    /// </summary>
    [DataMember(Name="createdTS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdTS")]
    public DateTime? CreatedTS { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public UserDto Owner { get; set; }

    /// <summary>
    /// Gets or Sets CurrentImage
    /// </summary>
    [DataMember(Name="currentImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentImage")]
    public ImageDto CurrentImage { get; set; }

    /// <summary>
    /// Gets or Sets IsRunned
    /// </summary>
    [DataMember(Name="isRunned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isRunned")]
    public bool? IsRunned { get; set; }

    /// <summary>
    /// Gets or Sets NeedRestart
    /// </summary>
    [DataMember(Name="needRestart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "needRestart")]
    public bool? NeedRestart { get; set; }

    /// <summary>
    /// Gets or Sets Command
    /// </summary>
    [DataMember(Name="command", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "command")]
    public string Command { get; set; }

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
    /// Gets or Sets Replicas
    /// </summary>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// Gets or Sets ClusterId
    /// </summary>
    [DataMember(Name="clusterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clusterId")]
    public int? ClusterId { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="nodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeId")]
    public int? NodeId { get; set; }

    /// <summary>
    /// Gets or Sets NodeModel
    /// </summary>
    [DataMember(Name="nodeModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeModel")]
    public NodeDto NodeModel { get; set; }

    /// <summary>
    /// Gets or Sets Alert
    /// </summary>
    [DataMember(Name="alert", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alert")]
    public bool? Alert { get; set; }

    /// <summary>
    /// Gets or Sets RestrictRestart
    /// </summary>
    [DataMember(Name="restrictRestart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restrictRestart")]
    public bool? RestrictRestart { get; set; }

    /// <summary>
    /// Gets or Sets ExpirationDate
    /// </summary>
    [DataMember(Name="expirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Gets or Sets MarketItem
    /// </summary>
    [DataMember(Name="marketItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketItem")]
    public MarketplaceItemDto MarketItem { get; set; }

    /// <summary>
    /// Gets or Sets DockerImageIsPresent
    /// </summary>
    [DataMember(Name="dockerImageIsPresent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dockerImageIsPresent")]
    public bool? DockerImageIsPresent { get; set; }

    /// <summary>
    /// Gets or Sets RegistryImage
    /// </summary>
    [DataMember(Name="registryImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryImage")]
    public string RegistryImage { get; set; }

    /// <summary>
    /// Gets or Sets RegistryUrl
    /// </summary>
    [DataMember(Name="registryUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryUrl")]
    public string RegistryUrl { get; set; }

    /// <summary>
    /// Gets or Sets RegistryUser
    /// </summary>
    [DataMember(Name="registryUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryUser")]
    public string RegistryUser { get; set; }

    /// <summary>
    /// Gets or Sets RegistryPassword
    /// </summary>
    [DataMember(Name="registryPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryPassword")]
    public string RegistryPassword { get; set; }

    /// <summary>
    /// Gets or Sets Properties
    /// </summary>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<PropertyDto> Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationSummaryDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CreatedTS: ").Append(CreatedTS).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  CurrentImage: ").Append(CurrentImage).Append("\n");
      sb.Append("  IsRunned: ").Append(IsRunned).Append("\n");
      sb.Append("  NeedRestart: ").Append(NeedRestart).Append("\n");
      sb.Append("  Command: ").Append(Command).Append("\n");
      sb.Append("  LimitCPU: ").Append(LimitCPU).Append("\n");
      sb.Append("  LimitRAM: ").Append(LimitRAM).Append("\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  NodeModel: ").Append(NodeModel).Append("\n");
      sb.Append("  Alert: ").Append(Alert).Append("\n");
      sb.Append("  RestrictRestart: ").Append(RestrictRestart).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  MarketItem: ").Append(MarketItem).Append("\n");
      sb.Append("  DockerImageIsPresent: ").Append(DockerImageIsPresent).Append("\n");
      sb.Append("  RegistryImage: ").Append(RegistryImage).Append("\n");
      sb.Append("  RegistryUrl: ").Append(RegistryUrl).Append("\n");
      sb.Append("  RegistryUser: ").Append(RegistryUser).Append("\n");
      sb.Append("  RegistryPassword: ").Append(RegistryPassword).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
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
