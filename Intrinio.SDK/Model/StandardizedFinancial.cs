using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Professional-grade historical financial data for a Company. This data is standardized, cleansed and verified to
	///     ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of
	///     standardized financials are to facilitate comparability across a single company’s fundamentals and across all
	///     companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain
	///     point in time, or within a single company across multiple time periods. This is not possible using the as-reported
	///     financial statements because of the inherent complexity of reporting standards.
	/// </summary>
	[DataContract]
	public class StandardizedFinancial : IEquatable<StandardizedFinancial>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="StandardizedFinancial" /> class.
		/// </summary>
		/// <param name="DataTag">DataTag.</param>
		/// <param name="Value">The value for the Data Tag within the scope of the Fundamental.</param>
		public StandardizedFinancial(DataTagSummary DataTag = default, decimal? Value = default)
		{
			this.DataTag = DataTag;
			this.Value = Value;
		}

		/// <summary>
		///     Gets or Sets DataTag
		/// </summary>
		[DataMember(Name = "data_tag", EmitDefaultValue = false)]
		public DataTagSummary DataTag { get; set; }

		/// <summary>
		///     The value for the Data Tag within the scope of the Fundamental
		/// </summary>
		/// <value>The value for the Data Tag within the scope of the Fundamental</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public decimal? Value { get; set; }

		/// <summary>
		///     Returns true if StandardizedFinancial instances are equal
		/// </summary>
		/// <param name="input">Instance of StandardizedFinancial to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(StandardizedFinancial input)
		{
			if (input == null)
				return false;

			return
				(
					DataTag == input.DataTag ||
					DataTag != null &&
					DataTag.Equals(input.DataTag)
				) &&
				(
					Value == input.Value ||
					Value != null &&
					Value.Equals(input.Value)
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
			sb.Append("class StandardizedFinancial {\n");
			sb.Append("  DataTag: ").Append(DataTag).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return Equals(input as StandardizedFinancial);
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
				if (DataTag != null)
					hashCode = hashCode * 59 + DataTag.GetHashCode();
				if (Value != null)
					hashCode = hashCode * 59 + Value.GetHashCode();
				return hashCode;
			}
		}
	}
}