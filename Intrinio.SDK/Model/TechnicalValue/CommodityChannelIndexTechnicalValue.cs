using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and cci values of a Commodity Channel Index technical indicator calculation
	/// </summary>
	[DataContract]
	public class CommodityChannelIndexTechnicalValue : IEquatable<CommodityChannelIndexTechnicalValue>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="CommodityChannelIndexTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Cci">The Commodity Channel Index calculation value.</param>
		public CommodityChannelIndexTechnicalValue(DateTime? DateTime = default, float? Cci = default)
		{
			this.DateTime = DateTime;
			this.Cci = Cci;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Commodity Channel Index calculation value
		/// </summary>
		/// <value>The Commodity Channel Index calculation value</value>
		[DataMember(Name = "cci", EmitDefaultValue = false)]
		public float? Cci { get; set; }

		/// <summary>
		///     Returns true if CommodityChannelIndexTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of CommodityChannelIndexTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CommodityChannelIndexTechnicalValue input)
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
					Cci == input.Cci ||
					Cci != null &&
					Cci.Equals(input.Cci)
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
			sb.Append("class CommodityChannelIndexTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Cci: ").Append(Cci).Append("\n");
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
			return Equals(input as CommodityChannelIndexTechnicalValue);
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
				if (Cci != null)
					hashCode = hashCode * 59 + Cci.GetHashCode();
				return hashCode;
			}
		}
	}
}