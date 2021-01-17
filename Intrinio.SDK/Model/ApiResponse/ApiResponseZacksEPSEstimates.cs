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
	///     ApiResponseZacksEPSEstimates
	/// </summary>
	[DataContract]
	public class ApiResponseZacksEPSEstimates : IEquatable<ApiResponseZacksEPSEstimates>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseZacksEPSEstimates" /> class.
		/// </summary>
		/// <param name="Estimates">Zacks EPS estimate data for a given date range.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseZacksEPSEstimates(List<ZacksEPSEstimate> Estimates = default, string NextPage = default)
		{
			this.Estimates = Estimates;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Zacks EPS estimate data for a given date range
		/// </summary>
		/// <value>Zacks EPS estimate data for a given date range</value>
		[DataMember(Name = "estimates", EmitDefaultValue = false)]
		public List<ZacksEPSEstimate> Estimates { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseZacksEPSEstimates instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseZacksEPSEstimates to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseZacksEPSEstimates input)
		{
			if (input == null)
				return false;

			return
				(
					Estimates == input.Estimates ||
					Estimates != null &&
					Estimates.SequenceEqual(input.Estimates)
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
			sb.Append("class ApiResponseZacksEPSEstimates {\n");
			sb.Append("  Estimates: ").Append(Estimates).Append("\n");
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
			return Equals(input as ApiResponseZacksEPSEstimates);
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
				if (Estimates != null)
					hashCode = hashCode * 59 + Estimates.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}