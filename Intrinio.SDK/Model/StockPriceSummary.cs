using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The summary of a stock price for a security on a given date.
	/// </summary>
	[DataContract]
	public class StockPriceSummary : IEquatable<StockPriceSummary>, IValidatableObject
	{

		/// <summary>
		///     Initializes a new instance of the <see cref="StockPriceSummary" /> class.
		/// </summary>
		/// <param name="Date">
		///     The calendar date that the stock price represents. For non-daily stock prices, this represents the
		///     last day in the period (end of the week, month, quarter, year, etc).
		/// </param>
		/// <param name="Intraperiod">
		///     If true, the stock price represents an unfinished period (be it day, week, quarter, month, or
		///     year), meaning that the close price is the latest price available, not the official close price for the period.
		/// </param>
		/// <param name="Frequency">The type of period that the stock price represents.</param>
		/// <param name="Open">The price at the beginning of the period.</param>
		/// <param name="High">The highest price over the span of the period.</param>
		/// <param name="Low">The lowest price over the span of the period.</param>
		/// <param name="Close">The price at the end of the period.</param>
		/// <param name="Volume">The number of shares exchanged during the period.</param>
		/// <param name="AdjOpen">The price at the beginning of the period, adjusted for splits and dividends.</param>
		/// <param name="AdjHigh">The highest price over the span of the period, adjusted for splits and dividends.</param>
		/// <param name="AdjLow">The lowest price over the span of the period, adjusted for splits and dividends.</param>
		/// <param name="AdjClose">The price at the end of the period, adjusted for splits and dividends.</param>
		/// <param name="AdjVolume">The number of shares exchanged during the period, adjusted for splits and dividends.</param>
		public StockPriceSummary(DateTime? Date = default, bool? Intraperiod = default,
			StockPriceSummaryFrequencyEnum? Frequency = default, decimal? Open = default, decimal? High = default,
			decimal? Low = default, decimal? Close = default, decimal? Volume = default, decimal? AdjOpen = default,
			decimal? AdjHigh = default, decimal? AdjLow = default, decimal? AdjClose = default,
			decimal? AdjVolume = default)
		{
			this.Date = Date;
			this.Intraperiod = Intraperiod;
			this.Frequency = Frequency;
			this.Open = Open;
			this.High = High;
			this.Low = Low;
			this.Close = Close;
			this.Volume = Volume;
			this.AdjOpen = AdjOpen;
			this.AdjHigh = AdjHigh;
			this.AdjLow = AdjLow;
			this.AdjClose = AdjClose;
			this.AdjVolume = AdjVolume;
		}

		/// <summary>
		///     The type of period that the stock price represents
		/// </summary>
		/// <value>The type of period that the stock price represents</value>
		[DataMember(Name = "frequency", EmitDefaultValue = false)]
		public StockPriceSummaryFrequencyEnum? Frequency { get; set; }

		/// <summary>
		///     The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the
		///     period (end of the week, month, quarter, year, etc)
		/// </summary>
		/// <value>
		///     The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in
		///     the period (end of the week, month, quarter, year, etc)
		/// </value>
		[DataMember(Name = "date", EmitDefaultValue = false)]
		
		public DateTime? Date { get; set; }

		/// <summary>
		///     If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that
		///     the close price is the latest price available, not the official close price for the period
		/// </summary>
		/// <value>
		///     If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning
		///     that the close price is the latest price available, not the official close price for the period
		/// </value>
		[DataMember(Name = "intraperiod", EmitDefaultValue = false)]
		public bool? Intraperiod { get; set; }


		/// <summary>
		///     The price at the beginning of the period
		/// </summary>
		/// <value>The price at the beginning of the period</value>
		[DataMember(Name = "open", EmitDefaultValue = false)]
		public decimal? Open { get; set; }

		/// <summary>
		///     The highest price over the span of the period
		/// </summary>
		/// <value>The highest price over the span of the period</value>
		[DataMember(Name = "high", EmitDefaultValue = false)]
		public decimal? High { get; set; }

		/// <summary>
		///     The lowest price over the span of the period
		/// </summary>
		/// <value>The lowest price over the span of the period</value>
		[DataMember(Name = "low", EmitDefaultValue = false)]
		public decimal? Low { get; set; }

		/// <summary>
		///     The price at the end of the period
		/// </summary>
		/// <value>The price at the end of the period</value>
		[DataMember(Name = "close", EmitDefaultValue = false)]
		public decimal? Close { get; set; }

		/// <summary>
		///     The number of shares exchanged during the period
		/// </summary>
		/// <value>The number of shares exchanged during the period</value>
		[DataMember(Name = "volume", EmitDefaultValue = false)]
		public decimal? Volume { get; set; }

		/// <summary>
		///     The price at the beginning of the period, adjusted for splits and dividends
		/// </summary>
		/// <value>The price at the beginning of the period, adjusted for splits and dividends</value>
		[DataMember(Name = "adj_open", EmitDefaultValue = false)]
		public decimal? AdjOpen { get; set; }

		/// <summary>
		///     The highest price over the span of the period, adjusted for splits and dividends
		/// </summary>
		/// <value>The highest price over the span of the period, adjusted for splits and dividends</value>
		[DataMember(Name = "adj_high", EmitDefaultValue = false)]
		public decimal? AdjHigh { get; set; }

		/// <summary>
		///     The lowest price over the span of the period, adjusted for splits and dividends
		/// </summary>
		/// <value>The lowest price over the span of the period, adjusted for splits and dividends</value>
		[DataMember(Name = "adj_low", EmitDefaultValue = false)]
		public decimal? AdjLow { get; set; }

		/// <summary>
		///     The price at the end of the period, adjusted for splits and dividends
		/// </summary>
		/// <value>The price at the end of the period, adjusted for splits and dividends</value>
		[DataMember(Name = "adj_close", EmitDefaultValue = false)]
		public decimal? AdjClose { get; set; }

		/// <summary>
		///     The number of shares exchanged during the period, adjusted for splits and dividends
		/// </summary>
		/// <value>The number of shares exchanged during the period, adjusted for splits and dividends</value>
		[DataMember(Name = "adj_volume", EmitDefaultValue = false)]
		public decimal? AdjVolume { get; set; }

		/// <summary>
		///     Returns true if StockPriceSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of StockPriceSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(StockPriceSummary input)
		{
			if (input == null)
				return false;

			return
				(
					Date == input.Date ||
					Date != null &&
					Date.Equals(input.Date)
				) &&
				(
					Intraperiod == input.Intraperiod ||
					Intraperiod != null &&
					Intraperiod.Equals(input.Intraperiod)
				) &&
				(
					Frequency == input.Frequency ||
					Frequency != null &&
					Frequency.Equals(input.Frequency)
				) &&
				(
					Open == input.Open ||
					Open != null &&
					Open.Equals(input.Open)
				) &&
				(
					High == input.High ||
					High != null &&
					High.Equals(input.High)
				) &&
				(
					Low == input.Low ||
					Low != null &&
					Low.Equals(input.Low)
				) &&
				(
					Close == input.Close ||
					Close != null &&
					Close.Equals(input.Close)
				) &&
				(
					Volume == input.Volume ||
					Volume != null &&
					Volume.Equals(input.Volume)
				) &&
				(
					AdjOpen == input.AdjOpen ||
					AdjOpen != null &&
					AdjOpen.Equals(input.AdjOpen)
				) &&
				(
					AdjHigh == input.AdjHigh ||
					AdjHigh != null &&
					AdjHigh.Equals(input.AdjHigh)
				) &&
				(
					AdjLow == input.AdjLow ||
					AdjLow != null &&
					AdjLow.Equals(input.AdjLow)
				) &&
				(
					AdjClose == input.AdjClose ||
					AdjClose != null &&
					AdjClose.Equals(input.AdjClose)
				) &&
				(
					AdjVolume == input.AdjVolume ||
					AdjVolume != null &&
					AdjVolume.Equals(input.AdjVolume)
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
			sb.Append("class StockPriceSummary {\n");
			sb.Append("  Date: ").Append(Date).Append("\n");
			sb.Append("  Intraperiod: ").Append(Intraperiod).Append("\n");
			sb.Append("  Frequency: ").Append(Frequency).Append("\n");
			sb.Append("  Open: ").Append(Open).Append("\n");
			sb.Append("  High: ").Append(High).Append("\n");
			sb.Append("  Low: ").Append(Low).Append("\n");
			sb.Append("  Close: ").Append(Close).Append("\n");
			sb.Append("  Volume: ").Append(Volume).Append("\n");
			sb.Append("  AdjOpen: ").Append(AdjOpen).Append("\n");
			sb.Append("  AdjHigh: ").Append(AdjHigh).Append("\n");
			sb.Append("  AdjLow: ").Append(AdjLow).Append("\n");
			sb.Append("  AdjClose: ").Append(AdjClose).Append("\n");
			sb.Append("  AdjVolume: ").Append(AdjVolume).Append("\n");
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
			return Equals(input as StockPriceSummary);
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
				if (Date != null)
					hashCode = hashCode * 59 + Date.GetHashCode();
				if (Intraperiod != null)
					hashCode = hashCode * 59 + Intraperiod.GetHashCode();
				if (Frequency != null)
					hashCode = hashCode * 59 + Frequency.GetHashCode();
				if (Open != null)
					hashCode = hashCode * 59 + Open.GetHashCode();
				if (High != null)
					hashCode = hashCode * 59 + High.GetHashCode();
				if (Low != null)
					hashCode = hashCode * 59 + Low.GetHashCode();
				if (Close != null)
					hashCode = hashCode * 59 + Close.GetHashCode();
				if (Volume != null)
					hashCode = hashCode * 59 + Volume.GetHashCode();
				if (AdjOpen != null)
					hashCode = hashCode * 59 + AdjOpen.GetHashCode();
				if (AdjHigh != null)
					hashCode = hashCode * 59 + AdjHigh.GetHashCode();
				if (AdjLow != null)
					hashCode = hashCode * 59 + AdjLow.GetHashCode();
				if (AdjClose != null)
					hashCode = hashCode * 59 + AdjClose.GetHashCode();
				if (AdjVolume != null)
					hashCode = hashCode * 59 + AdjVolume.GetHashCode();
				return hashCode;
			}
		}
	}
}