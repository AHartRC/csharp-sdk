using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A financial statement fact as-reported, directly from the financial statements of the XBRL filings from the
	///     company.
	/// </summary>
	[DataContract]
	public class ReportedFinancial : IEquatable<ReportedFinancial>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ReportedFinancial" /> class.
		/// </summary>
		/// <param name="XbrlTag">XbrlTag.</param>
		/// <param name="Value">The value reported for the XBRL Tag within the scope of the Fundamental.</param>
		/// <param name="Dimensions">
		///     The combination of XBRL axis and members that defines the dimensionalization of this fact (if
		///     any).
		/// </param>
		public ReportedFinancial(ReportedTag XbrlTag = default, decimal? Value = default,
			List<ReportedFinancialDimension> Dimensions = default)
		{
			this.XbrlTag = XbrlTag;
			this.Value = Value;
			this.Dimensions = Dimensions;
		}

		/// <summary>
		///     Gets or Sets XbrlTag
		/// </summary>
		[DataMember(Name = "xbrl_tag", EmitDefaultValue = false)]
		public ReportedTag XbrlTag { get; set; }

		/// <summary>
		///     The value reported for the XBRL Tag within the scope of the Fundamental
		/// </summary>
		/// <value>The value reported for the XBRL Tag within the scope of the Fundamental</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public decimal? Value { get; set; }

		/// <summary>
		///     The combination of XBRL axis and members that defines the dimensionalization of this fact (if any)
		/// </summary>
		/// <value>The combination of XBRL axis and members that defines the dimensionalization of this fact (if any)</value>
		[DataMember(Name = "dimensions", EmitDefaultValue = false)]
		public List<ReportedFinancialDimension> Dimensions { get; set; }

		/// <summary>
		///     Returns true if ReportedFinancial instances are equal
		/// </summary>
		/// <param name="input">Instance of ReportedFinancial to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ReportedFinancial input)
		{
			if (input == null)
				return false;

			return
				(
					XbrlTag == input.XbrlTag ||
					XbrlTag != null &&
					XbrlTag.Equals(input.XbrlTag)
				) &&
				(
					Value == input.Value ||
					Value != null &&
					Value.Equals(input.Value)
				) &&
				(
					Dimensions == input.Dimensions ||
					Dimensions != null &&
					Dimensions.SequenceEqual(input.Dimensions)
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
			sb.Append("class ReportedFinancial {\n");
			sb.Append("  XbrlTag: ").Append(XbrlTag).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
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
			return Equals(input as ReportedFinancial);
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
				if (XbrlTag != null)
					hashCode = hashCode * 59 + XbrlTag.GetHashCode();
				if (Value != null)
					hashCode = hashCode * 59 + Value.GetHashCode();
				if (Dimensions != null)
					hashCode = hashCode * 59 + Dimensions.GetHashCode();
				return hashCode;
			}
		}
	}
}