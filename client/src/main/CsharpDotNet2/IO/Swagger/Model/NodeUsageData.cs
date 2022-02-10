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
  public class NodeUsageData {
    /// <summary>
    /// Gets or Sets Cpu1M
    /// </summary>
    [DataMember(Name="cpu1M", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cpu1M")]
    public List<float?> Cpu1M { get; set; }

    /// <summary>
    /// Gets or Sets Mem1M
    /// </summary>
    [DataMember(Name="mem1M", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mem1M")]
    public List<float?> Mem1M { get; set; }

    /// <summary>
    /// Gets or Sets Disk1M
    /// </summary>
    [DataMember(Name="disk1M", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disk1M")]
    public List<float?> Disk1M { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeUsageData {\n");
      sb.Append("  Cpu1M: ").Append(Cpu1M).Append("\n");
      sb.Append("  Mem1M: ").Append(Mem1M).Append("\n");
      sb.Append("  Disk1M: ").Append(Disk1M).Append("\n");
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
