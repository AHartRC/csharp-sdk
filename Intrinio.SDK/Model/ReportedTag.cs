using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An XBRL tag as-reported by the company on the as-reported financial statement
	/// </summary>
	[DataContract]
	public class ReportedTag : IEquatable<ReportedTag>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ReportedTag" /> class.
		/// </summary>
		/// <param name="Tag">The tag code.</param>
		/// <param name="Name">The tag name.</param>
		/// <param name="Balance">Whether the tag represents a credit or debit.</param>
		/// <param name="Unit">The unit of the tag.</param>
		/// <param name="Abstract">If true, the tag is an abstract and does not represent a nominal value.</param>
		/// <param name="Sequence">The vertical sequence of the tag when displayed in the financial statement.</param>
		/// <param name="Depth">The horizontal depth of the tag when displayed in the financial statement.</param>
		public ReportedTag(string Tag = default, string Name = default, string Balance = default, string Unit = default,
			bool? Abstract = default, int? Sequence = default, int? Depth = default)
		{
			this.Tag = Tag;
			this.Name = Name;
			this.Balance = Balance;
			this.Unit = Unit;
			this.Abstract = Abstract;
			this.Sequence = Sequence;
			this.Depth = Depth;
		}

		/// <summary>
		///     The tag code
		/// </summary>
		/// <value>The tag code</value>
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		public string Tag { get; set; }

		/// <summary>
		///     The tag name
		/// </summary>
		/// <value>The tag name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     Whether the tag represents a credit or debit
		/// </summary>
		/// <value>Whether the tag represents a credit or debit</value>
		[DataMember(Name = "balance", EmitDefaultValue = false)]
		public string Balance { get; set; }

		/// <summary>
		///     The unit of the tag
		/// </summary>
		/// <value>The unit of the tag</value>
		[DataMember(Name = "unit", EmitDefaultValue = false)]
		public string Unit { get; set; }

		/// <summary>
		///     If true, the tag is an abstract and does not represent a nominal value
		/// </summary>
		/// <value>If true, the tag is an abstract and does not represent a nominal value</value>
		[DataMember(Name = "abstract", EmitDefaultValue = false)]
		public bool? Abstract { get; set; }

		/// <summary>
		///     The vertical sequence of the tag when displayed in the financial statement
		/// </summary>
		/// <value>The vertical sequence of the tag when displayed in the financial statement</value>
		[DataMember(Name = "sequence", EmitDefaultValue = false)]
		public int? Sequence { get; set; }

		/// <summary>
		///     The horizontal depth of the tag when displayed in the financial statement
		/// </summary>
		/// <value>The horizontal depth of the tag when displayed in the financial statement</value>
		[DataMember(Name = "depth", EmitDefaultValue = false)]
		public int? Depth { get; set; }

		/// <summary>
		///     Returns true if ReportedTag instances are equal
		/// </summary>
		/// <param name="input">Instance of ReportedTag to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ReportedTag input)
		{
			if (input == null)
				return false;

			return
				(
					Tag == input.Tag ||
					Tag != null &&
					Tag.Equals(input.Tag)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Balance == input.Balance ||
					Balance != null &&
					Balance.Equals(input.Balance)
				) &&
				(
					Unit == input.Unit ||
					Unit != null &&
					Unit.Equals(input.Unit)
				) &&
				(
					Abstract == input.Abstract ||
					Abstract != null &&
					Abstract.Equals(input.Abstract)
				) &&
				(
					Sequence == input.Sequence ||
					Sequence != null &&
					Sequence.Equals(input.Sequence)
				) &&
				(
					Depth == input.Depth ||
					Depth != null &&
					Depth.Equals(input.Depth)
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
			sb.Append("class ReportedTag {\n");
			sb.Append("  Tag: ").Append(Tag).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Balance: ").Append(Balance).Append("\n");
			sb.Append("  Unit: ").Append(Unit).Append("\n");
			sb.Append("  Abstract: ").Append(Abstract).Append("\n");
			sb.Append("  Sequence: ").Append(Sequence).Append("\n");
			sb.Append("  Depth: ").Append(Depth).Append("\n");
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
			return Equals(input as ReportedTag);
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
				if (Tag != null)
					hashCode = hashCode * 59 + Tag.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Balance != null)
					hashCode = hashCode * 59 + Balance.GetHashCode();
				if (Unit != null)
					hashCode = hashCode * 59 + Unit.GetHashCode();
				if (Abstract != null)
					hashCode = hashCode * 59 + Abstract.GetHashCode();
				if (Sequence != null)
					hashCode = hashCode * 59 + Sequence.GetHashCode();
				if (Depth != null)
					hashCode = hashCode * 59 + Depth.GetHashCode();
				return hashCode;
			}
		}
	}
}