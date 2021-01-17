using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and rsi values of a Relative Strength Index technical indicator calculation
	/// </summary>
	[DataContract]
	public class RelativeStrengthIndexTechnicalValue : IEquatable<RelativeStrengthIndexTechnicalValue>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="RelativeStrengthIndexTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Rsi">The Relative Strength Index calculation value.</param>
		public RelativeStrengthIndexTechnicalValue(DateTime? DateTime = default, float? Rsi = default)
		{
			this.DateTime = DateTime;
			this.Rsi = Rsi;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Relative Strength Index calculation value
		/// </summary>
		/// <value>The Relative Strength Index calculation value</value>
		[DataMember(Name = "rsi", EmitDefaultValue = false)]
		public float? Rsi { get; set; }

		/// <summary>
		///     Returns true if RelativeStrengthIndexTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of RelativeStrengthIndexTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RelativeStrengthIndexTechnicalValue input)
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
					Rsi == input.Rsi ||
					Rsi != null &&
					Rsi.Equals(input.Rsi)
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
			sb.Append("class RelativeStrengthIndexTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Rsi: ").Append(Rsi).Append("\n");
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
			return Equals(input as RelativeStrengthIndexTechnicalValue);
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
				if (Rsi != null)
					hashCode = hashCode * 59 + Rsi.GetHashCode();
				return hashCode;
			}
		}
	}
}