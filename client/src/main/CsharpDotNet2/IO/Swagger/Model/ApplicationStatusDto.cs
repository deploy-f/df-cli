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
  public class ApplicationStatusDto {
    /// <summary>
    /// Gets or Sets AppId
    /// </summary>
    [DataMember(Name="appId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appId")]
    public int? AppId { get; set; }

    /// <summary>
    /// Gets or Sets IsStarted
    /// </summary>
    [DataMember(Name="isStarted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isStarted")]
    public bool? IsStarted { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public ApplicationStatus Status { get; set; }

    /// <summary>
    /// Gets or Sets Restarts
    /// </summary>
    [DataMember(Name="restarts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restarts")]
    public int? Restarts { get; set; }

    /// <summary>
    /// Gets or Sets Uptime
    /// </summary>
    [DataMember(Name="uptime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uptime")]
    public long? Uptime { get; set; }

    /// <summary>
    /// Gets or Sets Endpoints
    /// </summary>
    [DataMember(Name="endpoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoints")]
    public Dictionary<string, string> Endpoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationStatusDto {\n");
      sb.Append("  AppId: ").Append(AppId).Append("\n");
      sb.Append("  IsStarted: ").Append(IsStarted).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Restarts: ").Append(Restarts).Append("\n");
      sb.Append("  Uptime: ").Append(Uptime).Append("\n");
      sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
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
