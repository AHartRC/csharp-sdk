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
	///     ApiResponseEconomicIndexHistoricalData
	/// </summary>
	[DataContract]
	public class ApiResponseEconomicIndexHistoricalData : IEquatable<ApiResponseEconomicIndexHistoricalData>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseEconomicIndexHistoricalData" /> class.
		/// </summary>
		/// <param name="HistoricalData">HistoricalData.</param>
		/// <param name="Index">Index.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseEconomicIndexHistoricalData(List<HistoricalData> HistoricalData = default,
			EconomicIndexSummary Index = default, string NextPage = default)
		{
			this.HistoricalData = HistoricalData;
			this.Index = Index;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets HistoricalData
		/// </summary>
		[DataMember(Name = "historical_data", EmitDefaultValue = false)]
		public List<HistoricalData> HistoricalData { get; set; }

		/// <summary>
		///     Gets or Sets Index
		/// </summary>
		[DataMember(Name = "index", EmitDefaultValue = false)]
		public EconomicIndexSummary Index { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseEconomicIndexHistoricalData instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseEconomicIndexHistoricalData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseEconomicIndexHistoricalData input)
		{
			if (input == null)
				return false;

			return
				(
					HistoricalData == input.HistoricalData ||
					HistoricalData != null &&
					HistoricalData.SequenceEqual(input.HistoricalData)
				) &&
				(
					Index == input.Index ||
					Index != null &&
					Index.Equals(input.Index)
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
			sb.Append("class ApiResponseEconomicIndexHistoricalData {\n");
			sb.Append("  HistoricalData: ").Append(HistoricalData).Append("\n");
			sb.Append("  Index: ").Append(Index).Append("\n");
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
			return Equals(input as ApiResponseEconomicIndexHistoricalData);
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
				if (HistoricalData != null)
					hashCode = hashCode * 59 + HistoricalData.GetHashCode();
				if (Index != null)
					hashCode = hashCode * 59 + Index.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}