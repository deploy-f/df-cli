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
  public class CreateImageDto {
    /// <summary>
    /// Gets or Sets FileId
    /// </summary>
    [DataMember(Name="fileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileId")]
    public int? FileId { get; set; }

    /// <summary>
    /// Gets or Sets PrefferedNodeId
    /// </summary>
    [DataMember(Name="prefferedNodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefferedNodeId")]
    public int? PrefferedNodeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateImageDto {\n");
      sb.Append("  FileId: ").Append(FileId).Append("\n");
      sb.Append("  PrefferedNodeId: ").Append(PrefferedNodeId).Append("\n");
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
