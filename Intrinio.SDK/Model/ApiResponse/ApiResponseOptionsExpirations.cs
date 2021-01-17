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
	///     ApiResponseOptionsExpirations
	/// </summary>
	[DataContract]
	public class ApiResponseOptionsExpirations : IEquatable<ApiResponseOptionsExpirations>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseOptionsExpirations" /> class.
		/// </summary>
		/// <param name="Expirations">A list of option expiration dates in descending order.</param>
		public ApiResponseOptionsExpirations(List<string> Expirations = default)
		{
			this.Expirations = Expirations;
		}

		/// <summary>
		///     A list of option expiration dates in descending order
		/// </summary>
		/// <value>A list of option expiration dates in descending order</value>
		[DataMember(Name = "expirations", EmitDefaultValue = false)]
		public List<string> Expirations { get; set; }

		/// <summary>
		///     Returns true if ApiResponseOptionsExpirations instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseOptionsExpirations to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseOptionsExpirations input)
		{
			if (input == null)
				return false;

			return
				Expirations == input.Expirations ||
				Expirations != null &&
				Expirations.SequenceEqual(input.Expirations);
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
			sb.Append("class ApiResponseOptionsExpirations {\n");
			sb.Append("  Expirations: ").Append(Expirations).Append("\n");
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
			return Equals(input as ApiResponseOptionsExpirations);
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
				if (Expirations != null)
					hashCode = hashCode * 59 + Expirations.GetHashCode();
				return hashCode;
			}
		}
	}
}