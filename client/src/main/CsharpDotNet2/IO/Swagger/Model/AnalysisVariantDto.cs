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
  public class AnalysisVariantDto {
    /// <summary>
    /// Gets or Sets AnalyserType
    /// </summary>
    [DataMember(Name="analyserType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analyserType")]
    public string AnalyserType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template")]
    public string Template { get; set; }

    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    [DataMember(Name="variables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variables")]
    public List<AnalysisVariableDto> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalysisVariantDto {\n");
      sb.Append("  AnalyserType: ").Append(AnalyserType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  Variables: ").Append(Variables).Append("\n");
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