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
  public class ApplicationCreateDto {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets PrefferNodeId
    /// </summary>
    [DataMember(Name="prefferNodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefferNodeId")]
    public int? PrefferNodeId { get; set; }

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
    /// Gets or Sets InitVolumes
    /// </summary>
    [DataMember(Name="initVolumes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initVolumes")]
    public bool? InitVolumes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationCreateDto {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  PrefferNodeId: ").Append(PrefferNodeId).Append("\n");
      sb.Append("  LimitCPU: ").Append(LimitCPU).Append("\n");
      sb.Append("  LimitRAM: ").Append(LimitRAM).Append("\n");
      sb.Append("  InitVolumes: ").Append(InitVolumes).Append("\n");
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
