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
  public class ApplicationConfigFileDto {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets FileId
    /// </summary>
    [DataMember(Name="fileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileId")]
    public int? FileId { get; set; }

    /// <summary>
    /// Gets or Sets IsBinary
    /// </summary>
    [DataMember(Name="isBinary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isBinary")]
    public bool? IsBinary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationConfigFileDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  FileId: ").Append(FileId).Append("\n");
      sb.Append("  IsBinary: ").Append(IsBinary).Append("\n");
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
