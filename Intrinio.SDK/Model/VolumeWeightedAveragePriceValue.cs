using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The date_time and vwap values of a Volume Weighted Average Price technical indicator calculation
	/// </summary>
	[DataContract]
	public class VolumeWeightedAveragePriceValue : IEquatable<VolumeWeightedAveragePriceValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="VolumeWeightedAveragePriceValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date and time of the observation.</param>
		/// <param name="Vwap">The Volume Weighted Average Price calculation value.</param>
		public VolumeWeightedAveragePriceValue(DateTime? DateTime = default, float? Vwap = default)
		{
			this.DateTime = DateTime;
			this.Vwap = Vwap;
		}

		/// <summary>
		///     The date and time of the observation
		/// </summary>
		/// <value>The date and time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Volume Weighted Average Price calculation value
		/// </summary>
		/// <value>The Volume Weighted Average Price calculation value</value>
		[DataMember(Name = "vwap", EmitDefaultValue = false)]
		public float? Vwap { get; set; }

		/// <summary>
		///     Returns true if VolumeWeightedAveragePriceValue instances are equal
		/// </summary>
		/// <param name="input">Instance of VolumeWeightedAveragePriceValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(VolumeWeightedAveragePriceValue input)
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
					Vwap == input.Vwap ||
					Vwap != null &&
					Vwap.Equals(input.Vwap)
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
			sb.Append("class VolumeWeightedAveragePriceValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Vwap: ").Append(Vwap).Append("\n");
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
			return Equals(input as VolumeWeightedAveragePriceValue);
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
				if (Vwap != null)
					hashCode = hashCode * 59 + Vwap.GetHashCode();
				return hashCode;
			}
		}
	}
}