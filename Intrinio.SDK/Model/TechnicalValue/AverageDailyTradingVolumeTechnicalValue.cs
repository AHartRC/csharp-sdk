using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and adtv values of a Average Daily Trading Volume technical indicator calculation
	/// </summary>
	[DataContract]
	public class AverageDailyTradingVolumeTechnicalValue : IEquatable<AverageDailyTradingVolumeTechnicalValue>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="AverageDailyTradingVolumeTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Adtv">The Average Daily Trading Volume calculation value.</param>
		public AverageDailyTradingVolumeTechnicalValue(DateTime? DateTime = default, float? Adtv = default)
		{
			this.DateTime = DateTime;
			this.Adtv = Adtv;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Average Daily Trading Volume calculation value
		/// </summary>
		/// <value>The Average Daily Trading Volume calculation value</value>
		[DataMember(Name = "adtv", EmitDefaultValue = false)]
		public float? Adtv { get; set; }

		/// <summary>
		///     Returns true if AverageDailyTradingVolumeTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of AverageDailyTradingVolumeTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AverageDailyTradingVolumeTechnicalValue input)
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
					Adtv == input.Adtv ||
					Adtv != null &&
					Adtv.Equals(input.Adtv)
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
			sb.Append("class AverageDailyTradingVolumeTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Adtv: ").Append(Adtv).Append("\n");
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
			return Equals(input as AverageDailyTradingVolumeTechnicalValue);
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
				if (Adtv != null)
					hashCode = hashCode * 59 + Adtv.GetHashCode();
				return hashCode;
			}
		}
	}
}