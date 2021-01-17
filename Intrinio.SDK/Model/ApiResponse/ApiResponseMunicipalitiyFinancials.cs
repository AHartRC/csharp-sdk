using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.ApiResponse
{
	/// <summary>
	///     ApiResponseMunicipalitiyFinancials
	/// </summary>
	[DataContract]
	public class ApiResponseMunicipalitiyFinancials : IEquatable<ApiResponseMunicipalitiyFinancials>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseMunicipalitiyFinancials" /> class.
		/// </summary>
		/// <param name="Financials">Financials.</param>
		/// <param name="Municipality">Municipality.</param>
		public ApiResponseMunicipalitiyFinancials(List<MunicipalityFinancial> Financials = default,
			Municipality Municipality = default)
		{
			this.Financials = Financials;
			this.Municipality = Municipality;
		}

		/// <summary>
		///     Gets or Sets Financials
		/// </summary>
		[DataMember(Name = "financials", EmitDefaultValue = false)]
		public List<MunicipalityFinancial> Financials { get; set; }

		/// <summary>
		///     Gets or Sets Municipality
		/// </summary>
		[DataMember(Name = "municipality", EmitDefaultValue = false)]
		public Municipality Municipality { get; set; }

		/// <summary>
		///     Returns true if ApiResponseMunicipalitiyFinancials instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseMunicipalitiyFinancials to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseMunicipalitiyFinancials input)
		{
			if (input == null)
				return false;

			return
				(
					Financials == input.Financials ||
					Financials != null &&
					Financials.SequenceEqual(input.Financials)
				) &&
				(
					Municipality == input.Municipality ||
					Municipality != null &&
					Municipality.Equals(input.Municipality)
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
			sb.Append("class ApiResponseMunicipalitiyFinancials {\n");
			sb.Append("  Financials: ").Append(Financials).Append("\n");
			sb.Append("  Municipality: ").Append(Municipality).Append("\n");
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
			return Equals(input as ApiResponseMunicipalitiyFinancials);
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
				if (Financials != null)
					hashCode = hashCode * 59 + Financials.GetHashCode();
				if (Municipality != null)
					hashCode = hashCode * 59 + Municipality.GetHashCode();
				return hashCode;
			}
		}
	}
}