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
  public class IdDockerimageBody {
    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }

    /// <summary>
    /// Gets or Sets Pass
    /// </summary>
    [DataMember(Name="pass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pass")]
    public string Pass { get; set; }

    /// <summary>
    /// Gets or Sets RegistryUrl
    /// </summary>
    [DataMember(Name="registryUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryUrl")]
    public string RegistryUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdDockerimageBody {\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Pass: ").Append(Pass).Append("\n");
      sb.Append("  RegistryUrl: ").Append(RegistryUrl).Append("\n");
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
