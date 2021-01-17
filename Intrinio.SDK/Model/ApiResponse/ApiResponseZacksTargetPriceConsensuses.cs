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
	///     ApiResponseZacksTargetPriceConsensuses
	/// </summary>
	[DataContract]
	public class ApiResponseZacksTargetPriceConsensuses : IEquatable<ApiResponseZacksTargetPriceConsensuses>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseZacksTargetPriceConsensuses" /> class.
		/// </summary>
		/// <param name="TargetPriceConsensuses">Zacks target price consensuses for the latest date.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseZacksTargetPriceConsensuses(List<ZacksTargetPriceConsensus> TargetPriceConsensuses = default,
			string NextPage = default)
		{
			this.TargetPriceConsensuses = TargetPriceConsensuses;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Zacks target price consensuses for the latest date
		/// </summary>
		/// <value>Zacks target price consensuses for the latest date</value>
		[DataMember(Name = "target_price_consensuses", EmitDefaultValue = false)]
		public List<ZacksTargetPriceConsensus> TargetPriceConsensuses { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseZacksTargetPriceConsensuses instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseZacksTargetPriceConsensuses to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseZacksTargetPriceConsensuses input)
		{
			if (input == null)
				return false;

			return
				(
					TargetPriceConsensuses == input.TargetPriceConsensuses ||
					TargetPriceConsensuses != null &&
					TargetPriceConsensuses.SequenceEqual(input.TargetPriceConsensuses)
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
			sb.Append("class ApiResponseZacksTargetPriceConsensuses {\n");
			sb.Append("  TargetPriceConsensuses: ").Append(TargetPriceConsensuses).Append("\n");
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
			return Equals(input as ApiResponseZacksTargetPriceConsensuses);
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
				if (TargetPriceConsensuses != null)
					hashCode = hashCode * 59 + TargetPriceConsensuses.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}