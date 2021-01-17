using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.ApiResponse
{
	/// <summary>
	///     ApiResponseETFHoldings
	/// </summary>
	[DataContract]
	public class ApiResponseETFHoldings : IEquatable<ApiResponseETFHoldings>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseETFHoldings" /> class.
		/// </summary>
		/// <param name="Holdings">Holdings.</param>
		/// <param name="Etf">Etf.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseETFHoldings(object Holdings = default, ETFSummary Etf = default, string NextPage = default)
		{
			this.Holdings = Holdings;
			this.Etf = Etf;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets Holdings
		/// </summary>
		[DataMember(Name = "holdings", EmitDefaultValue = false)]
		public object Holdings { get; set; }

		/// <summary>
		///     Gets or Sets Etf
		/// </summary>
		[DataMember(Name = "etf", EmitDefaultValue = false)]
		public ETFSummary Etf { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseETFHoldings instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseETFHoldings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseETFHoldings input)
		{
			if (input == null)
				return false;

			return
				(
					Holdings == input.Holdings ||
					Holdings != null &&
					Holdings.Equals(input.Holdings)
				) &&
				(
					Etf == input.Etf ||
					Etf != null &&
					Etf.Equals(input.Etf)
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
			sb.Append("class ApiResponseETFHoldings {\n");
			sb.Append("  Holdings: ").Append(Holdings).Append("\n");
			sb.Append("  Etf: ").Append(Etf).Append("\n");
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
			return Equals(input as ApiResponseETFHoldings);
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
				if (Holdings != null)
					hashCode = hashCode * 59 + Holdings.GetHashCode();
				if (Etf != null)
					hashCode = hashCode * 59 + Etf.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}