using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time, lower_bound, and uppoer_bound values of a Donchian Channel technical indicator calculation
	/// </summary>
	[DataContract]
	public class DonchianChannelTechnicalValue : IEquatable<DonchianChannelTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="DonchianChannelTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="LowerBound">The lower bound value of the Donchian Channel calculation.</param>
		/// <param name="UpperBound">The upper bound value of the Donchian Channel calculation.</param>
		public DonchianChannelTechnicalValue(DateTime? DateTime = default, float? LowerBound = default,
			float? UpperBound = default)
		{
			this.DateTime = DateTime;
			this.LowerBound = LowerBound;
			this.UpperBound = UpperBound;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The lower bound value of the Donchian Channel calculation
		/// </summary>
		/// <value>The lower bound value of the Donchian Channel calculation</value>
		[DataMember(Name = "lower_bound", EmitDefaultValue = false)]
		public float? LowerBound { get; set; }

		/// <summary>
		///     The upper bound value of the Donchian Channel calculation
		/// </summary>
		/// <value>The upper bound value of the Donchian Channel calculation</value>
		[DataMember(Name = "upper_bound", EmitDefaultValue = false)]
		public float? UpperBound { get; set; }

		/// <summary>
		///     Returns true if DonchianChannelTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of DonchianChannelTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DonchianChannelTechnicalValue input)
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
					LowerBound == input.LowerBound ||
					LowerBound != null &&
					LowerBound.Equals(input.LowerBound)
				) &&
				(
					UpperBound == input.UpperBound ||
					UpperBound != null &&
					UpperBound.Equals(input.UpperBound)
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
			sb.Append("class DonchianChannelTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  LowerBound: ").Append(LowerBound).Append("\n");
			sb.Append("  UpperBound: ").Append(UpperBound).Append("\n");
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
			return Equals(input as DonchianChannelTechnicalValue);
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
				if (LowerBound != null)
					hashCode = hashCode * 59 + LowerBound.GetHashCode();
				if (UpperBound != null)
					hashCode = hashCode * 59 + UpperBound.GetHashCode();
				return hashCode;
			}
		}
	}
}