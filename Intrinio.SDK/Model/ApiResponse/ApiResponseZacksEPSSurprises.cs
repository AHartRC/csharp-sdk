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
	///     ApiResponseZacksEPSSurprises
	/// </summary>
	[DataContract]
	public class ApiResponseZacksEPSSurprises : IEquatable<ApiResponseZacksEPSSurprises>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseZacksEPSSurprises" /> class.
		/// </summary>
		/// <param name="EpsSurprises">Zacks EPS Surprise data for a Security in descending order by actual reported date.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseZacksEPSSurprises(List<ZacksEPSSurprise> EpsSurprises = default, string NextPage = default)
		{
			this.EpsSurprises = EpsSurprises;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Zacks EPS Surprise data for a Security in descending order by actual reported date
		/// </summary>
		/// <value>Zacks EPS Surprise data for a Security in descending order by actual reported date</value>
		[DataMember(Name = "eps_surprises", EmitDefaultValue = false)]
		public List<ZacksEPSSurprise> EpsSurprises { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseZacksEPSSurprises instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseZacksEPSSurprises to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseZacksEPSSurprises input)
		{
			if (input == null)
				return false;

			return
				(
					EpsSurprises == input.EpsSurprises ||
					EpsSurprises != null &&
					EpsSurprises.SequenceEqual(input.EpsSurprises)
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
			sb.Append("class ApiResponseZacksEPSSurprises {\n");
			sb.Append("  EpsSurprises: ").Append(EpsSurprises).Append("\n");
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
			return Equals(input as ApiResponseZacksEPSSurprises);
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
				if (EpsSurprises != null)
					hashCode = hashCode * 59 + EpsSurprises.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}