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
  public class ApplicationPortBindingDto {
    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protocol")]
    public string Protocol { get; set; }

    /// <summary>
    /// Gets or Sets ContainerPort
    /// </summary>
    [DataMember(Name="containerPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>
    /// Gets or Sets ExternalPort
    /// </summary>
    [DataMember(Name="externalPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalPort")]
    public int? ExternalPort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationPortBindingDto {\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  ContainerPort: ").Append(ContainerPort).Append("\n");
      sb.Append("  ExternalPort: ").Append(ExternalPort).Append("\n");
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
