using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Provides analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and 52 week low
	/// </summary>
	[DataContract]
	public class ETFAnalytics : IEquatable<ETFAnalytics>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ETFAnalytics" /> class.
		/// </summary>
		/// <param name="FiftyTwoWeekHigh">Highest trading price for the security in the preceding 52 weeks.</param>
		/// <param name="FiftyTwoWeekLow">Lowest trading price for the security in the preceding 52 weeks.</param>
		/// <param name="VolumeTraded">The total quantity of shares traded on the latest trading day.</param>
		/// <param name="AverageDailyVolumeOneMonth">The average quantity of shares traded per day for the last month.</param>
		/// <param name="AverageDailyVolumeThreeMonth">The average quantity of shares traded per day for the last three months.</param>
		/// <param name="AverageDailyVolumeSixMonth">The average quantity of shares traded per day for the last six months.</param>
		/// <param name="MarketCap">The market capitalization for the Exchange Traded Fund (ETF).</param>
		/// <param name="SharesOutstanding">The number of shares outstanding for the Exchange Traded Fund (ETF).</param>
		/// <param name="Etf">Etf.</param>
		public ETFAnalytics(decimal? FiftyTwoWeekHigh = default, decimal? FiftyTwoWeekLow = default,
			decimal? VolumeTraded = default, decimal? AverageDailyVolumeOneMonth = default,
			decimal? AverageDailyVolumeThreeMonth = default, decimal? AverageDailyVolumeSixMonth = default,
			decimal? MarketCap = default, decimal? SharesOutstanding = default, ETFSummary Etf = default)
		{
			this.FiftyTwoWeekHigh = FiftyTwoWeekHigh;
			this.FiftyTwoWeekLow = FiftyTwoWeekLow;
			this.VolumeTraded = VolumeTraded;
			this.AverageDailyVolumeOneMonth = AverageDailyVolumeOneMonth;
			this.AverageDailyVolumeThreeMonth = AverageDailyVolumeThreeMonth;
			this.AverageDailyVolumeSixMonth = AverageDailyVolumeSixMonth;
			this.MarketCap = MarketCap;
			this.SharesOutstanding = SharesOutstanding;
			this.Etf = Etf;
		}

		/// <summary>
		///     Highest trading price for the security in the preceding 52 weeks
		/// </summary>
		/// <value>Highest trading price for the security in the preceding 52 weeks</value>
		[DataMember(Name = "fifty_two_week_high", EmitDefaultValue = false)]
		public decimal? FiftyTwoWeekHigh { get; set; }

		/// <summary>
		///     Lowest trading price for the security in the preceding 52 weeks
		/// </summary>
		/// <value>Lowest trading price for the security in the preceding 52 weeks</value>
		[DataMember(Name = "fifty_two_week_low", EmitDefaultValue = false)]
		public decimal? FiftyTwoWeekLow { get; set; }

		/// <summary>
		///     The total quantity of shares traded on the latest trading day
		/// </summary>
		/// <value>The total quantity of shares traded on the latest trading day</value>
		[DataMember(Name = "volume_traded", EmitDefaultValue = false)]
		public decimal? VolumeTraded { get; set; }

		/// <summary>
		///     The average quantity of shares traded per day for the last month
		/// </summary>
		/// <value>The average quantity of shares traded per day for the last month</value>
		[DataMember(Name = "average_daily_volume_one_month", EmitDefaultValue = false)]
		public decimal? AverageDailyVolumeOneMonth { get; set; }

		/// <summary>
		///     The average quantity of shares traded per day for the last three months
		/// </summary>
		/// <value>The average quantity of shares traded per day for the last three months</value>
		[DataMember(Name = "average_daily_volume_three_month", EmitDefaultValue = false)]
		public decimal? AverageDailyVolumeThreeMonth { get; set; }

		/// <summary>
		///     The average quantity of shares traded per day for the last six months
		/// </summary>
		/// <value>The average quantity of shares traded per day for the last six months</value>
		[DataMember(Name = "average_daily_volume_six_month", EmitDefaultValue = false)]
		public decimal? AverageDailyVolumeSixMonth { get; set; }

		/// <summary>
		///     The market capitalization for the Exchange Traded Fund (ETF)
		/// </summary>
		/// <value>The market capitalization for the Exchange Traded Fund (ETF)</value>
		[DataMember(Name = "market_cap", EmitDefaultValue = false)]
		public decimal? MarketCap { get; set; }

		/// <summary>
		///     The number of shares outstanding for the Exchange Traded Fund (ETF)
		/// </summary>
		/// <value>The number of shares outstanding for the Exchange Traded Fund (ETF)</value>
		[DataMember(Name = "shares_outstanding", EmitDefaultValue = false)]
		public decimal? SharesOutstanding { get; set; }

		/// <summary>
		///     Gets or Sets Etf
		/// </summary>
		[DataMember(Name = "etf", EmitDefaultValue = false)]
		public ETFSummary Etf { get; set; }

		/// <summary>
		///     Returns true if ETFAnalytics instances are equal
		/// </summary>
		/// <param name="input">Instance of ETFAnalytics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ETFAnalytics input)
		{
			if (input == null)
				return false;

			return
				(
					FiftyTwoWeekHigh == input.FiftyTwoWeekHigh ||
					FiftyTwoWeekHigh != null &&
					FiftyTwoWeekHigh.Equals(input.FiftyTwoWeekHigh)
				) &&
				(
					FiftyTwoWeekLow == input.FiftyTwoWeekLow ||
					FiftyTwoWeekLow != null &&
					FiftyTwoWeekLow.Equals(input.FiftyTwoWeekLow)
				) &&
				(
					VolumeTraded == input.VolumeTraded ||
					VolumeTraded != null &&
					VolumeTraded.Equals(input.VolumeTraded)
				) &&
				(
					AverageDailyVolumeOneMonth == input.AverageDailyVolumeOneMonth ||
					AverageDailyVolumeOneMonth != null &&
					AverageDailyVolumeOneMonth.Equals(input.AverageDailyVolumeOneMonth)
				) &&
				(
					AverageDailyVolumeThreeMonth == input.AverageDailyVolumeThreeMonth ||
					AverageDailyVolumeThreeMonth != null &&
					AverageDailyVolumeThreeMonth.Equals(input.AverageDailyVolumeThreeMonth)
				) &&
				(
					AverageDailyVolumeSixMonth == input.AverageDailyVolumeSixMonth ||
					AverageDailyVolumeSixMonth != null &&
					AverageDailyVolumeSixMonth.Equals(input.AverageDailyVolumeSixMonth)
				) &&
				(
					MarketCap == input.MarketCap ||
					MarketCap != null &&
					MarketCap.Equals(input.MarketCap)
				) &&
				(
					SharesOutstanding == input.SharesOutstanding ||
					SharesOutstanding != null &&
					SharesOutstanding.Equals(input.SharesOutstanding)
				) &&
				(
					Etf == input.Etf ||
					Etf != null &&
					Etf.Equals(input.Etf)
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
			sb.Append("class ETFAnalytics {\n");
			sb.Append("  FiftyTwoWeekHigh: ").Append(FiftyTwoWeekHigh).Append("\n");
			sb.Append("  FiftyTwoWeekLow: ").Append(FiftyTwoWeekLow).Append("\n");
			sb.Append("  VolumeTraded: ").Append(VolumeTraded).Append("\n");
			sb.Append("  AverageDailyVolumeOneMonth: ").Append(AverageDailyVolumeOneMonth).Append("\n");
			sb.Append("  AverageDailyVolumeThreeMonth: ").Append(AverageDailyVolumeThreeMonth).Append("\n");
			sb.Append("  AverageDailyVolumeSixMonth: ").Append(AverageDailyVolumeSixMonth).Append("\n");
			sb.Append("  MarketCap: ").Append(MarketCap).Append("\n");
			sb.Append("  SharesOutstanding: ").Append(SharesOutstanding).Append("\n");
			sb.Append("  Etf: ").Append(Etf).Append("\n");
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
			return Equals(input as ETFAnalytics);
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
				if (FiftyTwoWeekHigh != null)
					hashCode = hashCode * 59 + FiftyTwoWeekHigh.GetHashCode();
				if (FiftyTwoWeekLow != null)
					hashCode = hashCode * 59 + FiftyTwoWeekLow.GetHashCode();
				if (VolumeTraded != null)
					hashCode = hashCode * 59 + VolumeTraded.GetHashCode();
				if (AverageDailyVolumeOneMonth != null)
					hashCode = hashCode * 59 + AverageDailyVolumeOneMonth.GetHashCode();
				if (AverageDailyVolumeThreeMonth != null)
					hashCode = hashCode * 59 + AverageDailyVolumeThreeMonth.GetHashCode();
				if (AverageDailyVolumeSixMonth != null)
					hashCode = hashCode * 59 + AverageDailyVolumeSixMonth.GetHashCode();
				if (MarketCap != null)
					hashCode = hashCode * 59 + MarketCap.GetHashCode();
				if (SharesOutstanding != null)
					hashCode = hashCode * 59 + SharesOutstanding.GetHashCode();
				if (Etf != null)
					hashCode = hashCode * 59 + Etf.GetHashCode();
				return hashCode;
			}
		}
	}
}