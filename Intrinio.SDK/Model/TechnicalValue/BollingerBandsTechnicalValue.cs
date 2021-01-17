using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time, lower_band, middle_band, and upper_band values of a Bollinger Bands technical indicator calculation
	/// </summary>
	[DataContract]
	public class BollingerBandsTechnicalValue : IEquatable<BollingerBandsTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="BollingerBandsTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="LowerBand">The lower band value of the Bollinger Bands technical indicator calculation.</param>
		/// <param name="MiddleBand">The middle band value of the Bollinger Bands technical indicator calculation.</param>
		/// <param name="UpperBand">The upper band value of the Bollinger Bands technical indicator calculation.</param>
		public BollingerBandsTechnicalValue(DateTime? DateTime = default, float? LowerBand = default,
			float? MiddleBand = default, float? UpperBand = default)
		{
			this.DateTime = DateTime;
			this.LowerBand = LowerBand;
			this.MiddleBand = MiddleBand;
			this.UpperBand = UpperBand;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The lower band value of the Bollinger Bands technical indicator calculation
		/// </summary>
		/// <value>The lower band value of the Bollinger Bands technical indicator calculation</value>
		[DataMember(Name = "lower_band", EmitDefaultValue = false)]
		public float? LowerBand { get; set; }

		/// <summary>
		///     The middle band value of the Bollinger Bands technical indicator calculation
		/// </summary>
		/// <value>The middle band value of the Bollinger Bands technical indicator calculation</value>
		[DataMember(Name = "middle_band", EmitDefaultValue = false)]
		public float? MiddleBand { get; set; }

		/// <summary>
		///     The upper band value of the Bollinger Bands technical indicator calculation
		/// </summary>
		/// <value>The upper band value of the Bollinger Bands technical indicator calculation</value>
		[DataMember(Name = "upper_band", EmitDefaultValue = false)]
		public float? UpperBand { get; set; }

		/// <summary>
		///     Returns true if BollingerBandsTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of BollingerBandsTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BollingerBandsTechnicalValue input)
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
					LowerBand == input.LowerBand ||
					LowerBand != null &&
					LowerBand.Equals(input.LowerBand)
				) &&
				(
					MiddleBand == input.MiddleBand ||
					MiddleBand != null &&
					MiddleBand.Equals(input.MiddleBand)
				) &&
				(
					UpperBand == input.UpperBand ||
					UpperBand != null &&
					UpperBand.Equals(input.UpperBand)
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
			sb.Append("class BollingerBandsTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  LowerBand: ").Append(LowerBand).Append("\n");
			sb.Append("  MiddleBand: ").Append(MiddleBand).Append("\n");
			sb.Append("  UpperBand: ").Append(UpperBand).Append("\n");
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
			return Equals(input as BollingerBandsTechnicalValue);
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
				if (LowerBand != null)
					hashCode = hashCode * 59 + LowerBand.GetHashCode();
				if (MiddleBand != null)
					hashCode = hashCode * 59 + MiddleBand.GetHashCode();
				if (UpperBand != null)
					hashCode = hashCode * 59 + UpperBand.GetHashCode();
				return hashCode;
			}
		}
	}
}