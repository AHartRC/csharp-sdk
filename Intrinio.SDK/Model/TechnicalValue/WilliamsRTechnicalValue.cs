using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and wr values of a Willliams %R technical indicator calculation
	/// </summary>
	[DataContract]
	public class WilliamsRTechnicalValue : IEquatable<WilliamsRTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="WilliamsRTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Wr">The Willaims %R calculation value.</param>
		public WilliamsRTechnicalValue(DateTime? DateTime = default, float? Wr = default)
		{
			this.DateTime = DateTime;
			this.Wr = Wr;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Willaims %R calculation value
		/// </summary>
		/// <value>The Willaims %R calculation value</value>
		[DataMember(Name = "wr", EmitDefaultValue = false)]
		public float? Wr { get; set; }

		/// <summary>
		///     Returns true if WilliamsRTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of WilliamsRTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WilliamsRTechnicalValue input)
		{
			if (input == null)
				return false;

			return
				(
					DateTime == input.DateTime ||
					DateTime != null &&
					DateTime.Equals(input.DateTime)
				) &&
				(
					Wr == input.Wr ||
					Wr != null &&
					Wr.Equals(input.Wr)
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
			sb.Append("class WilliamsRTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Wr: ").Append(Wr).Append("\n");
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
			return Equals(input as WilliamsRTechnicalValue);
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
				if (DateTime != null)
					hashCode = hashCode * 59 + DateTime.GetHashCode();
				if (Wr != null)
					hashCode = hashCode * 59 + Wr.GetHashCode();
				return hashCode;
			}
		}
	}
}