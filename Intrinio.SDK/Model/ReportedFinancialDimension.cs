using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An axis-member combination related to a reported XBRL fact, which denotes a facet of an XBRL dimension.
	/// </summary>
	[DataContract]
	public class ReportedFinancialDimension : IEquatable<ReportedFinancialDimension>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ReportedFinancialDimension" /> class.
		/// </summary>
		/// <param name="Axis">The axis of the dimension.</param>
		/// <param name="Member">The member of the axis.</param>
		public ReportedFinancialDimension(string Axis = default, string Member = default)
		{
			this.Axis = Axis;
			this.Member = Member;
		}

		/// <summary>
		///     The axis of the dimension
		/// </summary>
		/// <value>The axis of the dimension</value>
		[DataMember(Name = "axis", EmitDefaultValue = false)]
		public string Axis { get; set; }

		/// <summary>
		///     The member of the axis
		/// </summary>
		/// <value>The member of the axis</value>
		[DataMember(Name = "member", EmitDefaultValue = false)]
		public string Member { get; set; }

		/// <summary>
		///     Returns true if ReportedFinancialDimension instances are equal
		/// </summary>
		/// <param name="input">Instance of ReportedFinancialDimension to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ReportedFinancialDimension input)
		{
			if (input == null)
				return false;

			return
				(
					Axis == input.Axis ||
					Axis != null &&
					Axis.Equals(input.Axis)
				) &&
				(
					Member == input.Member ||
					Member != null &&
					Member.Equals(input.Member)
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
			sb.Append("class ReportedFinancialDimension {\n");
			sb.Append("  Axis: ").Append(Axis).Append("\n");
			sb.Append("  Member: ").Append(Member).Append("\n");
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
			return Equals(input as ReportedFinancialDimension);
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
				if (Axis != null)
					hashCode = hashCode * 59 + Axis.GetHashCode();
				if (Member != null)
					hashCode = hashCode * 59 + Member.GetHashCode();
				return hashCode;
			}
		}
	}
}