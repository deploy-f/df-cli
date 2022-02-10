using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Информация о docker-image
  /// </summary>
  [DataContract]
  public class ImageDto {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets File
    /// </summary>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public FileDto File { get; set; }

    /// <summary>
    /// Gets or Sets CreatedTS
    /// </summary>
    [DataMember(Name="createdTS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdTS")]
    public DateTime? CreatedTS { get; set; }

    /// <summary>
    /// Gets or Sets UploadedUser
    /// </summary>
    [DataMember(Name="uploadedUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploadedUser")]
    public UserDto UploadedUser { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="nodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeId")]
    public int? NodeId { get; set; }

    /// <summary>
    /// Gets or Sets RegistryImage
    /// </summary>
    [DataMember(Name="registryImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryImage")]
    public string RegistryImage { get; set; }

    /// <summary>
    /// Gets or Sets RegistryUrl
    /// </summary>
    [DataMember(Name="registryUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryUrl")]
    public string RegistryUrl { get; set; }

    /// <summary>
    /// Gets or Sets RegistryUser
    /// </summary>
    [DataMember(Name="registryUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryUser")]
    public string RegistryUser { get; set; }

    /// <summary>
    /// Gets or Sets RegistryPassword
    /// </summary>
    [DataMember(Name="registryPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registryPassword")]
    public string RegistryPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImageDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  CreatedTS: ").Append(CreatedTS).Append("\n");
      sb.Append("  UploadedUser: ").Append(UploadedUser).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  RegistryImage: ").Append(RegistryImage).Append("\n");
      sb.Append("  RegistryUrl: ").Append(RegistryUrl).Append("\n");
      sb.Append("  RegistryUser: ").Append(RegistryUser).Append("\n");
      sb.Append("  RegistryPassword: ").Append(RegistryPassword).Append("\n");
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
