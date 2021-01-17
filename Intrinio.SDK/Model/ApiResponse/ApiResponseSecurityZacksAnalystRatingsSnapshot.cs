using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.ApiResponse
{
	/// <summary>
	///     ApiResponseSecurityZacksAnalystRatingsSnapshot
	/// </summary>
	[DataContract]
	public class
		ApiResponseSecurityZacksAnalystRatingsSnapshot : IEquatable<ApiResponseSecurityZacksAnalystRatingsSnapshot>,
			IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseSecurityZacksAnalystRatingsSnapshot" /> class.
		/// </summary>
		/// <param name="Snapshots">Snapshots.</param>
		/// <param name="Security">The Security resolved from the given identifier.</param>
		public ApiResponseSecurityZacksAnalystRatingsSnapshot(List<ZacksAnalystRatingSnapshot> Snapshots = default,
			SecuritySummary Security = default)
		{
			this.Snapshots = Snapshots;
			this.Security = Security;
		}

		/// <summary>
		///     Gets or Sets Snapshots
		/// </summary>
		[DataMember(Name = "snapshots", EmitDefaultValue = false)]
		public List<ZacksAnalystRatingSnapshot> Snapshots { get; set; }

		/// <summary>
		///     The Security resolved from the given identifier
		/// </summary>
		/// <value>The Security resolved from the given identifier</value>
		[DataMember(Name = "security", EmitDefaultValue = false)]
		public SecuritySummary Security { get; set; }

		/// <summary>
		///     Returns true if ApiResponseSecurityZacksAnalystRatingsSnapshot instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseSecurityZacksAnalystRatingsSnapshot to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseSecurityZacksAnalystRatingsSnapshot input)
		{
			if (input == null)
				return false;

			return
				(
					Snapshots == input.Snapshots ||
					Snapshots != null &&
					Snapshots.SequenceEqual(input.Snapshots)
				) &&
				(
					Security == input.Security ||
					Security != null &&
					Security.Equals(input.Security)
				);
		}

		/// <summary>
		///     To validate all properties of the instance
		/// </summary>
		/// <param name="validationContext">Validation context</param>
		/// <returns>Validation Result</returns>
		IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
		{
			yield break;
		}

		/// <summary>
		///     Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ApiResponseSecurityZacksAnalystRatingsSnapshot {\n");
			sb.Append("  Snapshots: ").Append(Snapshots).Append("\n");
			sb.Append("  Security: ").Append(Security).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		///     Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonSerializer.Serialize(this, new JsonSerializerOptions {WriteIndented = true});
		}

		/// <summary>
		///     Returns true if objects are equal
		/// </summary>
		/// <param name="input">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object input)
		{
			return Equals(input as ApiResponseSecurityZacksAnalystRatingsSnapshot);
		}

		/// <summary>
		///     Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				var hashCode = 41;
				if (Snapshots != null)
					hashCode = hashCode * 59 + Snapshots.GetHashCode();
				if (Security != null)
					hashCode = hashCode * 59 + Security.GetHashCode();
				return hashCode;
			}
		}
	}
}