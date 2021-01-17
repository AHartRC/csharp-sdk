using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time, adx, di_neg, and di_pos values of a Average Directional Index technical indicator calculation
	/// </summary>
	[DataContract]
	public class AverageDirectionalIndexTechnicalValue : IEquatable<AverageDirectionalIndexTechnicalValue>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="AverageDirectionalIndexTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Adx">The Average Directional Index value.</param>
		/// <param name="DiNeg">The Minus Directional Indicator value.</param>
		/// <param name="DiPos">The Plus Directional Indicator value.</param>
		public AverageDirectionalIndexTechnicalValue(DateTime? DateTime = default, float? Adx = default,
			float? DiNeg = default, float? DiPos = default)
		{
			this.DateTime = DateTime;
			this.Adx = Adx;
			this.DiNeg = DiNeg;
			this.DiPos = DiPos;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Average Directional Index value
		/// </summary>
		/// <value>The Average Directional Index value</value>
		[DataMember(Name = "adx", EmitDefaultValue = false)]
		public float? Adx { get; set; }

		/// <summary>
		///     The Minus Directional Indicator value
		/// </summary>
		/// <value>The Minus Directional Indicator value</value>
		[DataMember(Name = "di_neg", EmitDefaultValue = false)]
		public float? DiNeg { get; set; }

		/// <summary>
		///     The Plus Directional Indicator value
		/// </summary>
		/// <value>The Plus Directional Indicator value</value>
		[DataMember(Name = "di_pos", EmitDefaultValue = false)]
		public float? DiPos { get; set; }

		/// <summary>
		///     Returns true if AverageDirectionalIndexTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of AverageDirectionalIndexTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AverageDirectionalIndexTechnicalValue input)
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
					Adx == input.Adx ||
					Adx != null &&
					Adx.Equals(input.Adx)
				) &&
				(
					DiNeg == input.DiNeg ||
					DiNeg != null &&
					DiNeg.Equals(input.DiNeg)
				) &&
				(
					DiPos == input.DiPos ||
					DiPos != null &&
					DiPos.Equals(input.DiPos)
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
			sb.Append("class AverageDirectionalIndexTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Adx: ").Append(Adx).Append("\n");
			sb.Append("  DiNeg: ").Append(DiNeg).Append("\n");
			sb.Append("  DiPos: ").Append(DiPos).Append("\n");
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
			return Equals(input as AverageDirectionalIndexTechnicalValue);
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
				if (Adx != null)
					hashCode = hashCode * 59 + Adx.GetHashCode();
				if (DiNeg != null)
					hashCode = hashCode * 59 + DiNeg.GetHashCode();
				if (DiPos != null)
					hashCode = hashCode * 59 + DiPos.GetHashCode();
				return hashCode;
			}
		}
	}
}