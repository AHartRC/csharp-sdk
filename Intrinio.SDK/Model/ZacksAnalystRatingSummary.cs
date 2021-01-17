using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. A rating
	///     includes data about mean, strong buys, buys, holds, sells, strong sells, and total.
	/// </summary>
	[DataContract]
	public class ZacksAnalystRatingSummary : IEquatable<ZacksAnalystRatingSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksAnalystRatingSummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for the record.</param>
		/// <param name="Date">The date of the Zacks Analyst Rating..</param>
		/// <param name="Mean">The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell)..</param>
		/// <param name="StrongBuys">The number of analysts recommending Strong Buy..</param>
		/// <param name="Buys">The number of analysts recommending Buy..</param>
		/// <param name="Holds">The number of analysts recommending Hold..</param>
		/// <param name="Sells">The number of analysts recommending Sell..</param>
		/// <param name="StrongSells">The number of analysts recommending Strong Sell..</param>
		/// <param name="Total">The total number of analyst recommendations..</param>
		public ZacksAnalystRatingSummary(string Id = default, DateTime? Date = default, decimal? Mean = default,
			int? StrongBuys = default, int? Buys = default, int? Holds = default, int? Sells = default,
			int? StrongSells = default, int? Total = default)
		{
			this.Id = Id;
			this.Date = Date;
			this.Mean = Mean;
			this.StrongBuys = StrongBuys;
			this.Buys = Buys;
			this.Holds = Holds;
			this.Sells = Sells;
			this.StrongSells = StrongSells;
			this.Total = Total;
		}

		/// <summary>
		///     The Intrinio ID for the record
		/// </summary>
		/// <value>The Intrinio ID for the record</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The date of the Zacks Analyst Rating.
		/// </summary>
		/// <value>The date of the Zacks Analyst Rating.</value>
		[DataMember(Name = "date", EmitDefaultValue = false)]
		
		public DateTime? Date { get; set; }

		/// <summary>
		///     The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell).
		/// </summary>
		/// <value>The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell).</value>
		[DataMember(Name = "mean", EmitDefaultValue = false)]
		public decimal? Mean { get; set; }

		/// <summary>
		///     The number of analysts recommending Strong Buy.
		/// </summary>
		/// <value>The number of analysts recommending Strong Buy.</value>
		[DataMember(Name = "strong_buys", EmitDefaultValue = false)]
		public int? StrongBuys { get; set; }

		/// <summary>
		///     The number of analysts recommending Buy.
		/// </summary>
		/// <value>The number of analysts recommending Buy.</value>
		[DataMember(Name = "buys", EmitDefaultValue = false)]
		public int? Buys { get; set; }

		/// <summary>
		///     The number of analysts recommending Hold.
		/// </summary>
		/// <value>The number of analysts recommending Hold.</value>
		[DataMember(Name = "holds", EmitDefaultValue = false)]
		public int? Holds { get; set; }

		/// <summary>
		///     The number of analysts recommending Sell.
		/// </summary>
		/// <value>The number of analysts recommending Sell.</value>
		[DataMember(Name = "sells", EmitDefaultValue = false)]
		public int? Sells { get; set; }

		/// <summary>
		///     The number of analysts recommending Strong Sell.
		/// </summary>
		/// <value>The number of analysts recommending Strong Sell.</value>
		[DataMember(Name = "strong_sells", EmitDefaultValue = false)]
		public int? StrongSells { get; set; }

		/// <summary>
		///     The total number of analyst recommendations.
		/// </summary>
		/// <value>The total number of analyst recommendations.</value>
		[DataMember(Name = "total", EmitDefaultValue = false)]
		public int? Total { get; set; }

		/// <summary>
		///     Returns true if ZacksAnalystRatingSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksAnalystRatingSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksAnalystRatingSummary input)
		{
			if (input == null)
				return false;

			return
				(
					Id == input.Id ||
					Id != null &&
					Id.Equals(input.Id)
				) &&
				(
					Date == input.Date ||
					Date != null &&
					Date.Equals(input.Date)
				) &&
				(
					Mean == input.Mean ||
					Mean != null &&
					Mean.Equals(input.Mean)
				) &&
				(
					StrongBuys == input.StrongBuys ||
					StrongBuys != null &&
					StrongBuys.Equals(input.StrongBuys)
				) &&
				(
					Buys == input.Buys ||
					Buys != null &&
					Buys.Equals(input.Buys)
				) &&
				(
					Holds == input.Holds ||
					Holds != null &&
					Holds.Equals(input.Holds)
				) &&
				(
					Sells == input.Sells ||
					Sells != null &&
					Sells.Equals(input.Sells)
				) &&
				(
					StrongSells == input.StrongSells ||
					StrongSells != null &&
					StrongSells.Equals(input.StrongSells)
				) &&
				(
					Total == input.Total ||
					Total != null &&
					Total.Equals(input.Total)
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
			sb.Append("class ZacksAnalystRatingSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Date: ").Append(Date).Append("\n");
			sb.Append("  Mean: ").Append(Mean).Append("\n");
			sb.Append("  StrongBuys: ").Append(StrongBuys).Append("\n");
			sb.Append("  Buys: ").Append(Buys).Append("\n");
			sb.Append("  Holds: ").Append(Holds).Append("\n");
			sb.Append("  Sells: ").Append(Sells).Append("\n");
			sb.Append("  StrongSells: ").Append(StrongSells).Append("\n");
			sb.Append("  Total: ").Append(Total).Append("\n");
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
			return Equals(input as ZacksAnalystRatingSummary);
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
				if (Id != null)
					hashCode = hashCode * 59 + Id.GetHashCode();
				if (Date != null)
					hashCode = hashCode * 59 + Date.GetHashCode();
				if (Mean != null)
					hashCode = hashCode * 59 + Mean.GetHashCode();
				if (StrongBuys != null)
					hashCode = hashCode * 59 + StrongBuys.GetHashCode();
				if (Buys != null)
					hashCode = hashCode * 59 + Buys.GetHashCode();
				if (Holds != null)
					hashCode = hashCode * 59 + Holds.GetHashCode();
				if (Sells != null)
					hashCode = hashCode * 59 + Sells.GetHashCode();
				if (StrongSells != null)
					hashCode = hashCode * 59 + StrongSells.GetHashCode();
				if (Total != null)
					hashCode = hashCode * 59 + Total.GetHashCode();
				return hashCode;
			}
		}
	}
}