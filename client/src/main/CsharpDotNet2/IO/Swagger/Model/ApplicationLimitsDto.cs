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
  public class ApplicationLimitsDto {
    /// <summary>
    /// Gets or Sets Replicas
    /// </summary>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replicas")]
    public int? Replicas { get; set; }

    /// <summary>
    /// Gets or Sets LimutCPU
    /// </summary>
    [DataMember(Name="limutCPU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limutCPU")]
    public float? LimutCPU { get; set; }

    /// <summary>
    /// Gets or Sets LimutRAM
    /// </summary>
    [DataMember(Name="limutRAM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limutRAM")]
    public float? LimutRAM { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationLimitsDto {\n");
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      sb.Append("  LimutCPU: ").Append(LimutCPU).Append("\n");
      sb.Append("  LimutRAM: ").Append(LimutRAM).Append("\n");
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
