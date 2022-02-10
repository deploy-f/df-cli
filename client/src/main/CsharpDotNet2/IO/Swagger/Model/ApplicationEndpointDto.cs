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
  public class ApplicationEndpointDto {
    /// <summary>
    /// Gets or Sets AppId
    /// </summary>
    [DataMember(Name="appId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appId")]
    public int? AppId { get; set; }

    /// <summary>
    /// Gets or Sets IsFullyExposed
    /// </summary>
    [DataMember(Name="isFullyExposed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFullyExposed")]
    public bool? IsFullyExposed { get; set; }

    /// <summary>
    /// Gets or Sets Endpoints
    /// </summary>
    [DataMember(Name="endpoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoints")]
    public List<string> Endpoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationEndpointDto {\n");
      sb.Append("  AppId: ").Append(AppId).Append("\n");
      sb.Append("  IsFullyExposed: ").Append(IsFullyExposed).Append("\n");
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
