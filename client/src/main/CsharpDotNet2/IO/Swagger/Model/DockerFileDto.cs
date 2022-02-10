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
  public class DockerFileDto {
    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets Workdir
    /// </summary>
    [DataMember(Name="workdir", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workdir")]
    public string Workdir { get; set; }

    /// <summary>
    /// Gets or Sets CommandsList
    /// </summary>
    [DataMember(Name="commandsList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commandsList")]
    public List<string> CommandsList { get; set; }

    /// <summary>
    /// Gets or Sets Cmd
    /// </summary>
    [DataMember(Name="cmd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cmd")]
    public string Cmd { get; set; }

    /// <summary>
    /// Gets or Sets ExtractArchiveTo
    /// </summary>
    [DataMember(Name="extractArchiveTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extractArchiveTo")]
    public string ExtractArchiveTo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DockerFileDto {\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Workdir: ").Append(Workdir).Append("\n");
      sb.Append("  CommandsList: ").Append(CommandsList).Append("\n");
      sb.Append("  Cmd: ").Append(Cmd).Append("\n");
      sb.Append("  ExtractArchiveTo: ").Append(ExtractArchiveTo).Append("\n");
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
