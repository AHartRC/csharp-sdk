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
	///     Returns a list of companies with its shares and positions sourced from Zacks.
	/// </summary>
	[DataContract]
	public class ZacksInstitutionalHoldingCompanyDetail : IEquatable<ZacksInstitutionalHoldingCompanyDetail>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksInstitutionalHoldingCompanyDetail" /> class.
		/// </summary>
		/// <param name="Ticker">The Zacks common exchange ticker.</param>
		/// <param name="Name">The company name of the stock listed.</param>
		/// <param name="Exchange">Exhange where the stock is traded whose shares are held by the institution.</param>
		/// <param name="SharesOutstanding">The number of shares shares outstanding for the stock.</param>
		/// <param name="LastClosePrice">The last close price of the stock listed.</param>
		/// <param name="LastCloseDate">Last closing price of the stock listed.</param>
		/// <param name="InstitutionalSharesHeldPercent">Percentage of shares outstanding held by institutions in the stock listed.</param>
		/// <param name="InstitutionalSharesBuy">Number of shares bought by institutions in the stock listed.</param>
		/// <param name="InstitutionalSharesSell">Number of shares sold by institutions in the stock listed.</param>
		/// <param name="InstitutionalPositionsIncrease">
		///     Number of institutions who increased their shares held in the stock
		///     listed.
		/// </param>
		/// <param name="InstitutionalPositionsDecrease">Number of institutions who decrease their shares held in the stock listed.</param>
		/// <param name="InstitutionalPositionsUnchanged">
		///     Number of institutions who did not change their shares held in the stock
		///     listed.
		/// </param>
		/// <param name="InstitutionalPositionsTotal">Total number of institutions who hold shares in the stock listed.</param>
		public ZacksInstitutionalHoldingCompanyDetail(string Ticker = default, string Name = default,
			string Exchange = default, decimal? SharesOutstanding = default, decimal? LastClosePrice = default,
			DateTime? LastCloseDate = default, decimal? InstitutionalSharesHeldPercent = default,
			decimal? InstitutionalSharesBuy = default, decimal? InstitutionalSharesSell = default,
			decimal? InstitutionalPositionsIncrease = default, decimal? InstitutionalPositionsDecrease = default,
			decimal? InstitutionalPositionsUnchanged = default, decimal? InstitutionalPositionsTotal = default)
		{
			this.Ticker = Ticker;
			this.Name = Name;
			this.Exchange = Exchange;
			this.SharesOutstanding = SharesOutstanding;
			this.LastClosePrice = LastClosePrice;
			this.LastCloseDate = LastCloseDate;
			this.InstitutionalSharesHeldPercent = InstitutionalSharesHeldPercent;
			this.InstitutionalSharesBuy = InstitutionalSharesBuy;
			this.InstitutionalSharesSell = InstitutionalSharesSell;
			this.InstitutionalPositionsIncrease = InstitutionalPositionsIncrease;
			this.InstitutionalPositionsDecrease = InstitutionalPositionsDecrease;
			this.InstitutionalPositionsUnchanged = InstitutionalPositionsUnchanged;
			this.InstitutionalPositionsTotal = InstitutionalPositionsTotal;
		}

		/// <summary>
		///     The Zacks common exchange ticker
		/// </summary>
		/// <value>The Zacks common exchange ticker</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The company name of the stock listed
		/// </summary>
		/// <value>The company name of the stock listed</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     Exhange where the stock is traded whose shares are held by the institution
		/// </summary>
		/// <value>Exhange where the stock is traded whose shares are held by the institution</value>
		[DataMember(Name = "exchange", EmitDefaultValue = false)]
		public string Exchange { get; set; }

		/// <summary>
		///     The number of shares shares outstanding for the stock
		/// </summary>
		/// <value>The number of shares shares outstanding for the stock</value>
		[DataMember(Name = "shares_outstanding", EmitDefaultValue = false)]
		public decimal? SharesOutstanding { get; set; }

		/// <summary>
		///     The last close price of the stock listed
		/// </summary>
		/// <value>The last close price of the stock listed</value>
		[DataMember(Name = "last_close_price", EmitDefaultValue = false)]
		public decimal? LastClosePrice { get; set; }

		/// <summary>
		///     Last closing price of the stock listed
		/// </summary>
		/// <value>Last closing price of the stock listed</value>
		[DataMember(Name = "last_close_date", EmitDefaultValue = false)]
		
		public DateTime? LastCloseDate { get; set; }

		/// <summary>
		///     Percentage of shares outstanding held by institutions in the stock listed
		/// </summary>
		/// <value>Percentage of shares outstanding held by institutions in the stock listed</value>
		[DataMember(Name = "institutional_shares_held_percent", EmitDefaultValue = false)]
		public decimal? InstitutionalSharesHeldPercent { get; set; }

		/// <summary>
		///     Number of shares bought by institutions in the stock listed
		/// </summary>
		/// <value>Number of shares bought by institutions in the stock listed</value>
		[DataMember(Name = "institutional_shares_buy", EmitDefaultValue = false)]
		public decimal? InstitutionalSharesBuy { get; set; }

		/// <summary>
		///     Number of shares sold by institutions in the stock listed
		/// </summary>
		/// <value>Number of shares sold by institutions in the stock listed</value>
		[DataMember(Name = "institutional_shares_sell", EmitDefaultValue = false)]
		public decimal? InstitutionalSharesSell { get; set; }

		/// <summary>
		///     Number of institutions who increased their shares held in the stock listed
		/// </summary>
		/// <value>Number of institutions who increased their shares held in the stock listed</value>
		[DataMember(Name = "institutional_positions_increase", EmitDefaultValue = false)]
		public decimal? InstitutionalPositionsIncrease { get; set; }

		/// <summary>
		///     Number of institutions who decrease their shares held in the stock listed
		/// </summary>
		/// <value>Number of institutions who decrease their shares held in the stock listed</value>
		[DataMember(Name = "institutional_positions_decrease", EmitDefaultValue = false)]
		public decimal? InstitutionalPositionsDecrease { get; set; }

		/// <summary>
		///     Number of institutions who did not change their shares held in the stock listed
		/// </summary>
		/// <value>Number of institutions who did not change their shares held in the stock listed</value>
		[DataMember(Name = "institutional_positions_unchanged", EmitDefaultValue = false)]
		public decimal? InstitutionalPositionsUnchanged { get; set; }

		/// <summary>
		///     Total number of institutions who hold shares in the stock listed
		/// </summary>
		/// <value>Total number of institutions who hold shares in the stock listed</value>
		[DataMember(Name = "institutional_positions_total", EmitDefaultValue = false)]
		public decimal? InstitutionalPositionsTotal { get; set; }

		/// <summary>
		///     Returns true if ZacksInstitutionalHoldingCompanyDetail instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksInstitutionalHoldingCompanyDetail to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksInstitutionalHoldingCompanyDetail input)
		{
			if (input == null)
				return false;

			return
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Exchange == input.Exchange ||
					Exchange != null &&
					Exchange.Equals(input.Exchange)
				) &&
				(
					SharesOutstanding == input.SharesOutstanding ||
					SharesOutstanding != null &&
					SharesOutstanding.Equals(input.SharesOutstanding)
				) &&
				(
					LastClosePrice == input.LastClosePrice ||
					LastClosePrice != null &&
					LastClosePrice.Equals(input.LastClosePrice)
				) &&
				(
					LastCloseDate == input.LastCloseDate ||
					LastCloseDate != null &&
					LastCloseDate.Equals(input.LastCloseDate)
				) &&
				(
					InstitutionalSharesHeldPercent == input.InstitutionalSharesHeldPercent ||
					InstitutionalSharesHeldPercent != null &&
					InstitutionalSharesHeldPercent.Equals(input.InstitutionalSharesHeldPercent)
				) &&
				(
					InstitutionalSharesBuy == input.InstitutionalSharesBuy ||
					InstitutionalSharesBuy != null &&
					InstitutionalSharesBuy.Equals(input.InstitutionalSharesBuy)
				) &&
				(
					InstitutionalSharesSell == input.InstitutionalSharesSell ||
					InstitutionalSharesSell != null &&
					InstitutionalSharesSell.Equals(input.InstitutionalSharesSell)
				) &&
				(
					InstitutionalPositionsIncrease == input.InstitutionalPositionsIncrease ||
					InstitutionalPositionsIncrease != null &&
					InstitutionalPositionsIncrease.Equals(input.InstitutionalPositionsIncrease)
				) &&
				(
					InstitutionalPositionsDecrease == input.InstitutionalPositionsDecrease ||
					InstitutionalPositionsDecrease != null &&
					InstitutionalPositionsDecrease.Equals(input.InstitutionalPositionsDecrease)
				) &&
				(
					InstitutionalPositionsUnchanged == input.InstitutionalPositionsUnchanged ||
					InstitutionalPositionsUnchanged != null &&
					InstitutionalPositionsUnchanged.Equals(input.InstitutionalPositionsUnchanged)
				) &&
				(
					InstitutionalPositionsTotal == input.InstitutionalPositionsTotal ||
					InstitutionalPositionsTotal != null &&
					InstitutionalPositionsTotal.Equals(input.InstitutionalPositionsTotal)
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
			sb.Append("class ZacksInstitutionalHoldingCompanyDetail {\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Exchange: ").Append(Exchange).Append("\n");
			sb.Append("  SharesOutstanding: ").Append(SharesOutstanding).Append("\n");
			sb.Append("  LastClosePrice: ").Append(LastClosePrice).Append("\n");
			sb.Append("  LastCloseDate: ").Append(LastCloseDate).Append("\n");
			sb.Append("  InstitutionalSharesHeldPercent: ").Append(InstitutionalSharesHeldPercent).Append("\n");
			sb.Append("  InstitutionalSharesBuy: ").Append(InstitutionalSharesBuy).Append("\n");
			sb.Append("  InstitutionalSharesSell: ").Append(InstitutionalSharesSell).Append("\n");
			sb.Append("  InstitutionalPositionsIncrease: ").Append(InstitutionalPositionsIncrease).Append("\n");
			sb.Append("  InstitutionalPositionsDecrease: ").Append(InstitutionalPositionsDecrease).Append("\n");
			sb.Append("  InstitutionalPositionsUnchanged: ").Append(InstitutionalPositionsUnchanged).Append("\n");
			sb.Append("  InstitutionalPositionsTotal: ").Append(InstitutionalPositionsTotal).Append("\n");
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
			return Equals(input as ZacksInstitutionalHoldingCompanyDetail);
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
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Exchange != null)
					hashCode = hashCode * 59 + Exchange.GetHashCode();
				if (SharesOutstanding != null)
					hashCode = hashCode * 59 + SharesOutstanding.GetHashCode();
				if (LastClosePrice != null)
					hashCode = hashCode * 59 + LastClosePrice.GetHashCode();
				if (LastCloseDate != null)
					hashCode = hashCode * 59 + LastCloseDate.GetHashCode();
				if (InstitutionalSharesHeldPercent != null)
					hashCode = hashCode * 59 + InstitutionalSharesHeldPercent.GetHashCode();
				if (InstitutionalSharesBuy != null)
					hashCode = hashCode * 59 + InstitutionalSharesBuy.GetHashCode();
				if (InstitutionalSharesSell != null)
					hashCode = hashCode * 59 + InstitutionalSharesSell.GetHashCode();
				if (InstitutionalPositionsIncrease != null)
					hashCode = hashCode * 59 + InstitutionalPositionsIncrease.GetHashCode();
				if (InstitutionalPositionsDecrease != null)
					hashCode = hashCode * 59 + InstitutionalPositionsDecrease.GetHashCode();
				if (InstitutionalPositionsUnchanged != null)
					hashCode = hashCode * 59 + InstitutionalPositionsUnchanged.GetHashCode();
				if (InstitutionalPositionsTotal != null)
					hashCode = hashCode * 59 + InstitutionalPositionsTotal.GetHashCode();
				return hashCode;
			}
		}
	}
}