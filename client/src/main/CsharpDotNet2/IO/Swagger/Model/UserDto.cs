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
  public class UserDto {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationTime
    /// </summary>
    [DataMember(Name="registrationTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationTime")]
    public DateTime? RegistrationTime { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public int? UserId { get; set; }

    /// <summary>
    /// Gets or Sets RestrictActivity
    /// </summary>
    [DataMember(Name="restrictActivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restrictActivity")]
    public bool? RestrictActivity { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public float? Balance { get; set; }

    /// <summary>
    /// Gets or Sets Plan
    /// </summary>
    [DataMember(Name="plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan")]
    public string Plan { get; set; }

    /// <summary>
    /// Gets or Sets Applications
    /// </summary>
    [DataMember(Name="applications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applications")]
    public int? Applications { get; set; }

    /// <summary>
    /// Gets or Sets RunApplications
    /// </summary>
    [DataMember(Name="runApplications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runApplications")]
    public int? RunApplications { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  RegistrationTime: ").Append(RegistrationTime).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  RestrictActivity: ").Append(RestrictActivity).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
      sb.Append("  Applications: ").Append(Applications).Append("\n");
      sb.Append("  RunApplications: ").Append(RunApplications).Append("\n");
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
