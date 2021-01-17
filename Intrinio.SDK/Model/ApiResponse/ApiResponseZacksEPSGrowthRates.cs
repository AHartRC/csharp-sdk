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
	///     ApiResponseZacksEPSGrowthRates
	/// </summary>
	[DataContract]
	public class ApiResponseZacksEPSGrowthRates : IEquatable<ApiResponseZacksEPSGrowthRates>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseZacksEPSGrowthRates" /> class.
		/// </summary>
		/// <param name="EpsGrowthRates">Zacks EPS growth rate for the latest date.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseZacksEPSGrowthRates(List<ZacksEPSGrowthRate> EpsGrowthRates = default,
			string NextPage = default)
		{
			this.EpsGrowthRates = EpsGrowthRates;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Zacks EPS growth rate for the latest date
		/// </summary>
		/// <value>Zacks EPS growth rate for the latest date</value>
		[DataMember(Name = "eps_growth_rates", EmitDefaultValue = false)]
		public List<ZacksEPSGrowthRate> EpsGrowthRates { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseZacksEPSGrowthRates instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseZacksEPSGrowthRates to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseZacksEPSGrowthRates input)
		{
			if (input == null)
				return false;

			return
				(
					EpsGrowthRates == input.EpsGrowthRates ||
					EpsGrowthRates != null &&
					EpsGrowthRates.SequenceEqual(input.EpsGrowthRates)
				) &&
				(
					NextPage == input.NextPage ||
					NextPage != null &&
					NextPage.Equals(input.NextPage)
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
			sb.Append("class ApiResponseZacksEPSGrowthRates {\n");
			sb.Append("  EpsGrowthRates: ").Append(EpsGrowthRates).Append("\n");
			sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
			return Equals(input as ApiResponseZacksEPSGrowthRates);
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
				if (EpsGrowthRates != null)
					hashCode = hashCode * 59 + EpsGrowthRates.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}