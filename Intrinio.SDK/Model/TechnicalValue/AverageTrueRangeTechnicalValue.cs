using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and atr values of an Average True range technical indicator calculation
	/// </summary>
	[DataContract]
	public class AverageTrueRangeTechnicalValue : IEquatable<AverageTrueRangeTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="AverageTrueRangeTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Atr">The Average True Range calculation value.</param>
		public AverageTrueRangeTechnicalValue(DateTime? DateTime = default, float? Atr = default)
		{
			this.DateTime = DateTime;
			this.Atr = Atr;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Average True Range calculation value
		/// </summary>
		/// <value>The Average True Range calculation value</value>
		[DataMember(Name = "atr", EmitDefaultValue = false)]
		public float? Atr { get; set; }

		/// <summary>
		///     Returns true if AverageTrueRangeTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of AverageTrueRangeTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AverageTrueRangeTechnicalValue input)
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
					Atr == input.Atr ||
					Atr != null &&
					Atr.Equals(input.Atr)
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
			sb.Append("class AverageTrueRangeTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Atr: ").Append(Atr).Append("\n");
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
			return Equals(input as AverageTrueRangeTechnicalValue);
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
				if (Atr != null)
					hashCode = hashCode * 59 + Atr.GetHashCode();
				return hashCode;
			}
		}
	}
}