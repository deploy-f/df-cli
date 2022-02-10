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
  public class AnalysisVariableDto {
    /// <summary>
    /// Gets or Sets Hidden
    /// </summary>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Gets or Sets Modificable
    /// </summary>
    [DataMember(Name="modificable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modificable")]
    public bool? Modificable { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public List<AnalysisVariableOptionDto> Options { get; set; }

    /// <summary>
    /// Gets or Sets CustomValueEnable
    /// </summary>
    [DataMember(Name="customValueEnable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customValueEnable")]
    public bool? CustomValueEnable { get; set; }

    /// <summary>
    /// Gets or Sets ValidationRegexp
    /// </summary>
    [DataMember(Name="validationRegexp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationRegexp")]
    public string ValidationRegexp { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalysisVariableDto {\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Modificable: ").Append(Modificable).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  CustomValueEnable: ").Append(CustomValueEnable).Append("\n");
      sb.Append("  ValidationRegexp: ").Append(ValidationRegexp).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
