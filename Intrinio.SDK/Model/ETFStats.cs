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
	///     Daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and volatility
	/// </summary>
	[DataContract]
	public class ETFStats : IEquatable<ETFStats>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ETFStats" /> class.
		/// </summary>
		/// <param name="Date">Date.</param>
		/// <param name="NetAssetValue">The net asset value (NAV &#x3D; Total Assets - Total Liabilities).</param>
		/// <param name="BetaVsSpy">Volatility this ETF is versus the SPY ETF.</param>
		/// <param name="TrailingOneMonthReturnSplitAndDividend">Trailing one month return including dividends.</param>
		/// <param name="TrailingOneMonthReturnSplitOnly">Trailing one month return excluding dividends.</param>
		/// <param name="TrailingOneYearReturnSplitAndDividend">Trailing one year return including dividends.</param>
		/// <param name="TrailingOneYearReturnSplitOnly">Trailing one year return excluding dividends.</param>
		/// <param name="TrailingOneYearVolatilityAnnualized">
		///     Annualized standard deviation of daily price returns over trailing
		///     252 trading days.
		/// </param>
		/// <param name="TrailingThreeYearAnnualizedReturnSplitAndDividend">Trailing three year return including dividends.</param>
		/// <param name="TrailingThreeYearAnnualizedReturnSplitOnly">Trailing three year return excluding dividends.</param>
		/// <param name="TrailingThreeYearVolatilityAnnualized">
		///     Annualized standard deviation of daily price returns over trailing
		///     756 trading days.
		/// </param>
		/// <param name="TrailingFiveYearAnnualizedReturnSplitAndDividend">Trailing five year return including dividends.</param>
		/// <param name="TrailingFiveYearAnnualizedReturnSplitOnly">Trailing five year return excluding dividends.</param>
		/// <param name="TrailingFiveYearVolatilityAnnualized">
		///     Annualized standard  deviation  of  daily  price  returns  over
		///     trailing 1260 trading days.
		/// </param>
		/// <param name="TrailingTenYearAnnualizedReturnSplitAndDividend">Trailing ten year return including dividends.</param>
		/// <param name="TrailingTenYearAnnualizedReturnSplitOnly">Trailing ten year return excluding dividends.</param>
		/// <param name="InceptionAnnualizedReturnSplitAndDividend">Annualized return including dividends since inception.</param>
		/// <param name="InceptionAnnualizedReturnSplitOnly">Annualized return excluding dividends since inception.</param>
		/// <param name="CalendarYear5ReturnSplitAndDividend">Five years ago calendar year return including dividends.</param>
		/// <param name="CalendarYear5ReturnSplitOnly">Five years ago calendar year return excluding dividends.</param>
		/// <param name="CalendarYear4ReturnSplitAndDividend">Four years ago calendar year return including dividends.</param>
		/// <param name="CalendarYear4ReturnSplitOnly">Four years ago calendar year return excluding dividends.</param>
		/// <param name="CalendarYear3ReturnSplitAndDividend">Three years ago calendar year return including dividends.</param>
		/// <param name="CalendarYear3ReturnSplitOnly">Three years ago calendar year return excluding dividends.</param>
		/// <param name="CalendarYear2ReturnSplitAndDividend">Two years ago calendar year return including dividends.</param>
		/// <param name="CalendarYear2ReturnSplitOnly">Two years ago calendar year return excluding dividends.</param>
		/// <param name="CalendarYear1ReturnSplitAndDividend">One year ago calendar year return including dividends.</param>
		/// <param name="CalendarYear1ReturnSplitOnly">One year ago calendar year return excluding dividends.</param>
		/// <param name="CalendarYearToDateReturnSplitAndDividend">Calendar year to date (YTD) return including dividends.</param>
		/// <param name="CalendarYearToDateReturnSplitOnly">Calendar year to date (YTD) return excluding dividends.</param>
		/// <param name="Etf">Etf.</param>
		public ETFStats(DateTime? Date = default, decimal? NetAssetValue = default, decimal? BetaVsSpy = default,
			decimal? TrailingOneMonthReturnSplitAndDividend = default,
			decimal? TrailingOneMonthReturnSplitOnly = default,
			decimal? TrailingOneYearReturnSplitAndDividend = default, decimal? TrailingOneYearReturnSplitOnly = default,
			decimal? TrailingOneYearVolatilityAnnualized = default,
			decimal? TrailingThreeYearAnnualizedReturnSplitAndDividend = default,
			decimal? TrailingThreeYearAnnualizedReturnSplitOnly = default,
			decimal? TrailingThreeYearVolatilityAnnualized = default,
			decimal? TrailingFiveYearAnnualizedReturnSplitAndDividend = default,
			decimal? TrailingFiveYearAnnualizedReturnSplitOnly = default,
			decimal? TrailingFiveYearVolatilityAnnualized = default,
			decimal? TrailingTenYearAnnualizedReturnSplitAndDividend = default,
			decimal? TrailingTenYearAnnualizedReturnSplitOnly = default,
			decimal? InceptionAnnualizedReturnSplitAndDividend = default,
			decimal? InceptionAnnualizedReturnSplitOnly = default,
			decimal? CalendarYear5ReturnSplitAndDividend = default, decimal? CalendarYear5ReturnSplitOnly = default,
			decimal? CalendarYear4ReturnSplitAndDividend = default, decimal? CalendarYear4ReturnSplitOnly = default,
			decimal? CalendarYear3ReturnSplitAndDividend = default, decimal? CalendarYear3ReturnSplitOnly = default,
			decimal? CalendarYear2ReturnSplitAndDividend = default, decimal? CalendarYear2ReturnSplitOnly = default,
			decimal? CalendarYear1ReturnSplitAndDividend = default, decimal? CalendarYear1ReturnSplitOnly = default,
			decimal? CalendarYearToDateReturnSplitAndDividend = default,
			decimal? CalendarYearToDateReturnSplitOnly = default, ETFSummary Etf = default)
		{
			this.Date = Date;
			this.NetAssetValue = NetAssetValue;
			this.BetaVsSpy = BetaVsSpy;
			this.TrailingOneMonthReturnSplitAndDividend = TrailingOneMonthReturnSplitAndDividend;
			this.TrailingOneMonthReturnSplitOnly = TrailingOneMonthReturnSplitOnly;
			this.TrailingOneYearReturnSplitAndDividend = TrailingOneYearReturnSplitAndDividend;
			this.TrailingOneYearReturnSplitOnly = TrailingOneYearReturnSplitOnly;
			this.TrailingOneYearVolatilityAnnualized = TrailingOneYearVolatilityAnnualized;
			this.TrailingThreeYearAnnualizedReturnSplitAndDividend = TrailingThreeYearAnnualizedReturnSplitAndDividend;
			this.TrailingThreeYearAnnualizedReturnSplitOnly = TrailingThreeYearAnnualizedReturnSplitOnly;
			this.TrailingThreeYearVolatilityAnnualized = TrailingThreeYearVolatilityAnnualized;
			this.TrailingFiveYearAnnualizedReturnSplitAndDividend = TrailingFiveYearAnnualizedReturnSplitAndDividend;
			this.TrailingFiveYearAnnualizedReturnSplitOnly = TrailingFiveYearAnnualizedReturnSplitOnly;
			this.TrailingFiveYearVolatilityAnnualized = TrailingFiveYearVolatilityAnnualized;
			this.TrailingTenYearAnnualizedReturnSplitAndDividend = TrailingTenYearAnnualizedReturnSplitAndDividend;
			this.TrailingTenYearAnnualizedReturnSplitOnly = TrailingTenYearAnnualizedReturnSplitOnly;
			this.InceptionAnnualizedReturnSplitAndDividend = InceptionAnnualizedReturnSplitAndDividend;
			this.InceptionAnnualizedReturnSplitOnly = InceptionAnnualizedReturnSplitOnly;
			this.CalendarYear5ReturnSplitAndDividend = CalendarYear5ReturnSplitAndDividend;
			this.CalendarYear5ReturnSplitOnly = CalendarYear5ReturnSplitOnly;
			this.CalendarYear4ReturnSplitAndDividend = CalendarYear4ReturnSplitAndDividend;
			this.CalendarYear4ReturnSplitOnly = CalendarYear4ReturnSplitOnly;
			this.CalendarYear3ReturnSplitAndDividend = CalendarYear3ReturnSplitAndDividend;
			this.CalendarYear3ReturnSplitOnly = CalendarYear3ReturnSplitOnly;
			this.CalendarYear2ReturnSplitAndDividend = CalendarYear2ReturnSplitAndDividend;
			this.CalendarYear2ReturnSplitOnly = CalendarYear2ReturnSplitOnly;
			this.CalendarYear1ReturnSplitAndDividend = CalendarYear1ReturnSplitAndDividend;
			this.CalendarYear1ReturnSplitOnly = CalendarYear1ReturnSplitOnly;
			this.CalendarYearToDateReturnSplitAndDividend = CalendarYearToDateReturnSplitAndDividend;
			this.CalendarYearToDateReturnSplitOnly = CalendarYearToDateReturnSplitOnly;
			this.Etf = Etf;
		}

		/// <summary>
		///     Gets or Sets Date
		/// </summary>
		[DataMember(Name = "date", EmitDefaultValue = false)]
		
		public DateTime? Date { get; set; }

		/// <summary>
		///     The net asset value (NAV &#x3D; Total Assets - Total Liabilities)
		/// </summary>
		/// <value>The net asset value (NAV &#x3D; Total Assets - Total Liabilities)</value>
		[DataMember(Name = "net_asset_value", EmitDefaultValue = false)]
		public decimal? NetAssetValue { get; set; }

		/// <summary>
		///     Volatility this ETF is versus the SPY ETF
		/// </summary>
		/// <value>Volatility this ETF is versus the SPY ETF</value>
		[DataMember(Name = "beta_vs_spy", EmitDefaultValue = false)]
		public decimal? BetaVsSpy { get; set; }

		/// <summary>
		///     Trailing one month return including dividends
		/// </summary>
		/// <value>Trailing one month return including dividends</value>
		[DataMember(Name = "trailing_one_month_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? TrailingOneMonthReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Trailing one month return excluding dividends
		/// </summary>
		/// <value>Trailing one month return excluding dividends</value>
		[DataMember(Name = "trailing_one_month_return_split_only", EmitDefaultValue = false)]
		public decimal? TrailingOneMonthReturnSplitOnly { get; set; }

		/// <summary>
		///     Trailing one year return including dividends
		/// </summary>
		/// <value>Trailing one year return including dividends</value>
		[DataMember(Name = "trailing_one_year_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? TrailingOneYearReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Trailing one year return excluding dividends
		/// </summary>
		/// <value>Trailing one year return excluding dividends</value>
		[DataMember(Name = "trailing_one_year_return_split_only", EmitDefaultValue = false)]
		public decimal? TrailingOneYearReturnSplitOnly { get; set; }

		/// <summary>
		///     Annualized standard deviation of daily price returns over trailing 252 trading days
		/// </summary>
		/// <value>Annualized standard deviation of daily price returns over trailing 252 trading days</value>
		[DataMember(Name = "trailing_one_year_volatility_annualized", EmitDefaultValue = false)]
		public decimal? TrailingOneYearVolatilityAnnualized { get; set; }

		/// <summary>
		///     Trailing three year return including dividends
		/// </summary>
		/// <value>Trailing three year return including dividends</value>
		[DataMember(Name = "trailing_three_year_annualized_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? TrailingThreeYearAnnualizedReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Trailing three year return excluding dividends
		/// </summary>
		/// <value>Trailing three year return excluding dividends</value>
		[DataMember(Name = "trailing_three_year_annualized_return_split_only", EmitDefaultValue = false)]
		public decimal? TrailingThreeYearAnnualizedReturnSplitOnly { get; set; }

		/// <summary>
		///     Annualized standard deviation of daily price returns over trailing 756 trading days
		/// </summary>
		/// <value>Annualized standard deviation of daily price returns over trailing 756 trading days</value>
		[DataMember(Name = "trailing_three_year_volatility_annualized", EmitDefaultValue = false)]
		public decimal? TrailingThreeYearVolatilityAnnualized { get; set; }

		/// <summary>
		///     Trailing five year return including dividends
		/// </summary>
		/// <value>Trailing five year return including dividends</value>
		[DataMember(Name = "trailing_five_year_annualized_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? TrailingFiveYearAnnualizedReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Trailing five year return excluding dividends
		/// </summary>
		/// <value>Trailing five year return excluding dividends</value>
		[DataMember(Name = "trailing_five_year_annualized_return_split_only", EmitDefaultValue = false)]
		public decimal? TrailingFiveYearAnnualizedReturnSplitOnly { get; set; }

		/// <summary>
		///     Annualized standard  deviation  of  daily  price  returns  over  trailing 1260 trading days
		/// </summary>
		/// <value>Annualized standard  deviation  of  daily  price  returns  over  trailing 1260 trading days</value>
		[DataMember(Name = "trailing_five_year_volatility_annualized", EmitDefaultValue = false)]
		public decimal? TrailingFiveYearVolatilityAnnualized { get; set; }

		/// <summary>
		///     Trailing ten year return including dividends
		/// </summary>
		/// <value>Trailing ten year return including dividends</value>
		[DataMember(Name = "trailing_ten_year_annualized_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? TrailingTenYearAnnualizedReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Trailing ten year return excluding dividends
		/// </summary>
		/// <value>Trailing ten year return excluding dividends</value>
		[DataMember(Name = "trailing_ten_year_annualized_return_split_only", EmitDefaultValue = false)]
		public decimal? TrailingTenYearAnnualizedReturnSplitOnly { get; set; }

		/// <summary>
		///     Annualized return including dividends since inception
		/// </summary>
		/// <value>Annualized return including dividends since inception</value>
		[DataMember(Name = "inception_annualized_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? InceptionAnnualizedReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Annualized return excluding dividends since inception
		/// </summary>
		/// <value>Annualized return excluding dividends since inception</value>
		[DataMember(Name = "inception_annualized_return_split_only", EmitDefaultValue = false)]
		public decimal? InceptionAnnualizedReturnSplitOnly { get; set; }

		/// <summary>
		///     Five years ago calendar year return including dividends
		/// </summary>
		/// <value>Five years ago calendar year return including dividends</value>
		[DataMember(Name = "calendar_year_5_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? CalendarYear5ReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Five years ago calendar year return excluding dividends
		/// </summary>
		/// <value>Five years ago calendar year return excluding dividends</value>
		[DataMember(Name = "calendar_year_5_return_split_only", EmitDefaultValue = false)]
		public decimal? CalendarYear5ReturnSplitOnly { get; set; }

		/// <summary>
		///     Four years ago calendar year return including dividends
		/// </summary>
		/// <value>Four years ago calendar year return including dividends</value>
		[DataMember(Name = "calendar_year_4_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? CalendarYear4ReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Four years ago calendar year return excluding dividends
		/// </summary>
		/// <value>Four years ago calendar year return excluding dividends</value>
		[DataMember(Name = "calendar_year_4_return_split_only", EmitDefaultValue = false)]
		public decimal? CalendarYear4ReturnSplitOnly { get; set; }

		/// <summary>
		///     Three years ago calendar year return including dividends
		/// </summary>
		/// <value>Three years ago calendar year return including dividends</value>
		[DataMember(Name = "calendar_year_3_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? CalendarYear3ReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Three years ago calendar year return excluding dividends
		/// </summary>
		/// <value>Three years ago calendar year return excluding dividends</value>
		[DataMember(Name = "calendar_year_3_return_split_only", EmitDefaultValue = false)]
		public decimal? CalendarYear3ReturnSplitOnly { get; set; }

		/// <summary>
		///     Two years ago calendar year return including dividends
		/// </summary>
		/// <value>Two years ago calendar year return including dividends</value>
		[DataMember(Name = "calendar_year_2_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? CalendarYear2ReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Two years ago calendar year return excluding dividends
		/// </summary>
		/// <value>Two years ago calendar year return excluding dividends</value>
		[DataMember(Name = "calendar_year_2_return_split_only", EmitDefaultValue = false)]
		public decimal? CalendarYear2ReturnSplitOnly { get; set; }

		/// <summary>
		///     One year ago calendar year return including dividends
		/// </summary>
		/// <value>One year ago calendar year return including dividends</value>
		[DataMember(Name = "calendar_year_1_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? CalendarYear1ReturnSplitAndDividend { get; set; }

		/// <summary>
		///     One year ago calendar year return excluding dividends
		/// </summary>
		/// <value>One year ago calendar year return excluding dividends</value>
		[DataMember(Name = "calendar_year_1_return_split_only", EmitDefaultValue = false)]
		public decimal? CalendarYear1ReturnSplitOnly { get; set; }

		/// <summary>
		///     Calendar year to date (YTD) return including dividends
		/// </summary>
		/// <value>Calendar year to date (YTD) return including dividends</value>
		[DataMember(Name = "calendar_year_to_date_return_split_and_dividend", EmitDefaultValue = false)]
		public decimal? CalendarYearToDateReturnSplitAndDividend { get; set; }

		/// <summary>
		///     Calendar year to date (YTD) return excluding dividends
		/// </summary>
		/// <value>Calendar year to date (YTD) return excluding dividends</value>
		[DataMember(Name = "calendar_year_to_date_return_split_only", EmitDefaultValue = false)]
		public decimal? CalendarYearToDateReturnSplitOnly { get; set; }

		/// <summary>
		///     Gets or Sets Etf
		/// </summary>
		[DataMember(Name = "etf", EmitDefaultValue = false)]
		public ETFSummary Etf { get; set; }

		/// <summary>
		///     Returns true if ETFStats instances are equal
		/// </summary>
		/// <param name="input">Instance of ETFStats to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ETFStats input)
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
					NetAssetValue == input.NetAssetValue ||
					NetAssetValue != null &&
					NetAssetValue.Equals(input.NetAssetValue)
				) &&
				(
					BetaVsSpy == input.BetaVsSpy ||
					BetaVsSpy != null &&
					BetaVsSpy.Equals(input.BetaVsSpy)
				) &&
				(
					TrailingOneMonthReturnSplitAndDividend == input.TrailingOneMonthReturnSplitAndDividend ||
					TrailingOneMonthReturnSplitAndDividend != null &&
					TrailingOneMonthReturnSplitAndDividend.Equals(input.TrailingOneMonthReturnSplitAndDividend)
				) &&
				(
					TrailingOneMonthReturnSplitOnly == input.TrailingOneMonthReturnSplitOnly ||
					TrailingOneMonthReturnSplitOnly != null &&
					TrailingOneMonthReturnSplitOnly.Equals(input.TrailingOneMonthReturnSplitOnly)
				) &&
				(
					TrailingOneYearReturnSplitAndDividend == input.TrailingOneYearReturnSplitAndDividend ||
					TrailingOneYearReturnSplitAndDividend != null &&
					TrailingOneYearReturnSplitAndDividend.Equals(input.TrailingOneYearReturnSplitAndDividend)
				) &&
				(
					TrailingOneYearReturnSplitOnly == input.TrailingOneYearReturnSplitOnly ||
					TrailingOneYearReturnSplitOnly != null &&
					TrailingOneYearReturnSplitOnly.Equals(input.TrailingOneYearReturnSplitOnly)
				) &&
				(
					TrailingOneYearVolatilityAnnualized == input.TrailingOneYearVolatilityAnnualized ||
					TrailingOneYearVolatilityAnnualized != null &&
					TrailingOneYearVolatilityAnnualized.Equals(input.TrailingOneYearVolatilityAnnualized)
				) &&
				(
					TrailingThreeYearAnnualizedReturnSplitAndDividend ==
					input.TrailingThreeYearAnnualizedReturnSplitAndDividend ||
					TrailingThreeYearAnnualizedReturnSplitAndDividend != null &&
					TrailingThreeYearAnnualizedReturnSplitAndDividend.Equals(input
						.TrailingThreeYearAnnualizedReturnSplitAndDividend)
				) &&
				(
					TrailingThreeYearAnnualizedReturnSplitOnly == input.TrailingThreeYearAnnualizedReturnSplitOnly ||
					TrailingThreeYearAnnualizedReturnSplitOnly != null &&
					TrailingThreeYearAnnualizedReturnSplitOnly.Equals(input.TrailingThreeYearAnnualizedReturnSplitOnly)
				) &&
				(
					TrailingThreeYearVolatilityAnnualized == input.TrailingThreeYearVolatilityAnnualized ||
					TrailingThreeYearVolatilityAnnualized != null &&
					TrailingThreeYearVolatilityAnnualized.Equals(input.TrailingThreeYearVolatilityAnnualized)
				) &&
				(
					TrailingFiveYearAnnualizedReturnSplitAndDividend ==
					input.TrailingFiveYearAnnualizedReturnSplitAndDividend ||
					TrailingFiveYearAnnualizedReturnSplitAndDividend != null &&
					TrailingFiveYearAnnualizedReturnSplitAndDividend.Equals(input
						.TrailingFiveYearAnnualizedReturnSplitAndDividend)
				) &&
				(
					TrailingFiveYearAnnualizedReturnSplitOnly == input.TrailingFiveYearAnnualizedReturnSplitOnly ||
					TrailingFiveYearAnnualizedReturnSplitOnly != null &&
					TrailingFiveYearAnnualizedReturnSplitOnly.Equals(input.TrailingFiveYearAnnualizedReturnSplitOnly)
				) &&
				(
					TrailingFiveYearVolatilityAnnualized == input.TrailingFiveYearVolatilityAnnualized ||
					TrailingFiveYearVolatilityAnnualized != null &&
					TrailingFiveYearVolatilityAnnualized.Equals(input.TrailingFiveYearVolatilityAnnualized)
				) &&
				(
					TrailingTenYearAnnualizedReturnSplitAndDividend ==
					input.TrailingTenYearAnnualizedReturnSplitAndDividend ||
					TrailingTenYearAnnualizedReturnSplitAndDividend != null &&
					TrailingTenYearAnnualizedReturnSplitAndDividend.Equals(input
						.TrailingTenYearAnnualizedReturnSplitAndDividend)
				) &&
				(
					TrailingTenYearAnnualizedReturnSplitOnly == input.TrailingTenYearAnnualizedReturnSplitOnly ||
					TrailingTenYearAnnualizedReturnSplitOnly != null &&
					TrailingTenYearAnnualizedReturnSplitOnly.Equals(input.TrailingTenYearAnnualizedReturnSplitOnly)
				) &&
				(
					InceptionAnnualizedReturnSplitAndDividend == input.InceptionAnnualizedReturnSplitAndDividend ||
					InceptionAnnualizedReturnSplitAndDividend != null &&
					InceptionAnnualizedReturnSplitAndDividend.Equals(input.InceptionAnnualizedReturnSplitAndDividend)
				) &&
				(
					InceptionAnnualizedReturnSplitOnly == input.InceptionAnnualizedReturnSplitOnly ||
					InceptionAnnualizedReturnSplitOnly != null &&
					InceptionAnnualizedReturnSplitOnly.Equals(input.InceptionAnnualizedReturnSplitOnly)
				) &&
				(
					CalendarYear5ReturnSplitAndDividend == input.CalendarYear5ReturnSplitAndDividend ||
					CalendarYear5ReturnSplitAndDividend != null &&
					CalendarYear5ReturnSplitAndDividend.Equals(input.CalendarYear5ReturnSplitAndDividend)
				) &&
				(
					CalendarYear5ReturnSplitOnly == input.CalendarYear5ReturnSplitOnly ||
					CalendarYear5ReturnSplitOnly != null &&
					CalendarYear5ReturnSplitOnly.Equals(input.CalendarYear5ReturnSplitOnly)
				) &&
				(
					CalendarYear4ReturnSplitAndDividend == input.CalendarYear4ReturnSplitAndDividend ||
					CalendarYear4ReturnSplitAndDividend != null &&
					CalendarYear4ReturnSplitAndDividend.Equals(input.CalendarYear4ReturnSplitAndDividend)
				) &&
				(
					CalendarYear4ReturnSplitOnly == input.CalendarYear4ReturnSplitOnly ||
					CalendarYear4ReturnSplitOnly != null &&
					CalendarYear4ReturnSplitOnly.Equals(input.CalendarYear4ReturnSplitOnly)
				) &&
				(
					CalendarYear3ReturnSplitAndDividend == input.CalendarYear3ReturnSplitAndDividend ||
					CalendarYear3ReturnSplitAndDividend != null &&
					CalendarYear3ReturnSplitAndDividend.Equals(input.CalendarYear3ReturnSplitAndDividend)
				) &&
				(
					CalendarYear3ReturnSplitOnly == input.CalendarYear3ReturnSplitOnly ||
					CalendarYear3ReturnSplitOnly != null &&
					CalendarYear3ReturnSplitOnly.Equals(input.CalendarYear3ReturnSplitOnly)
				) &&
				(
					CalendarYear2ReturnSplitAndDividend == input.CalendarYear2ReturnSplitAndDividend ||
					CalendarYear2ReturnSplitAndDividend != null &&
					CalendarYear2ReturnSplitAndDividend.Equals(input.CalendarYear2ReturnSplitAndDividend)
				) &&
				(
					CalendarYear2ReturnSplitOnly == input.CalendarYear2ReturnSplitOnly ||
					CalendarYear2ReturnSplitOnly != null &&
					CalendarYear2ReturnSplitOnly.Equals(input.CalendarYear2ReturnSplitOnly)
				) &&
				(
					CalendarYear1ReturnSplitAndDividend == input.CalendarYear1ReturnSplitAndDividend ||
					CalendarYear1ReturnSplitAndDividend != null &&
					CalendarYear1ReturnSplitAndDividend.Equals(input.CalendarYear1ReturnSplitAndDividend)
				) &&
				(
					CalendarYear1ReturnSplitOnly == input.CalendarYear1ReturnSplitOnly ||
					CalendarYear1ReturnSplitOnly != null &&
					CalendarYear1ReturnSplitOnly.Equals(input.CalendarYear1ReturnSplitOnly)
				) &&
				(
					CalendarYearToDateReturnSplitAndDividend == input.CalendarYearToDateReturnSplitAndDividend ||
					CalendarYearToDateReturnSplitAndDividend != null &&
					CalendarYearToDateReturnSplitAndDividend.Equals(input.CalendarYearToDateReturnSplitAndDividend)
				) &&
				(
					CalendarYearToDateReturnSplitOnly == input.CalendarYearToDateReturnSplitOnly ||
					CalendarYearToDateReturnSplitOnly != null &&
					CalendarYearToDateReturnSplitOnly.Equals(input.CalendarYearToDateReturnSplitOnly)
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
			sb.Append("class ETFStats {\n");
			sb.Append("  Date: ").Append(Date).Append("\n");
			sb.Append("  NetAssetValue: ").Append(NetAssetValue).Append("\n");
			sb.Append("  BetaVsSpy: ").Append(BetaVsSpy).Append("\n");
			sb.Append("  TrailingOneMonthReturnSplitAndDividend: ").Append(TrailingOneMonthReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  TrailingOneMonthReturnSplitOnly: ").Append(TrailingOneMonthReturnSplitOnly).Append("\n");
			sb.Append("  TrailingOneYearReturnSplitAndDividend: ").Append(TrailingOneYearReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  TrailingOneYearReturnSplitOnly: ").Append(TrailingOneYearReturnSplitOnly).Append("\n");
			sb.Append("  TrailingOneYearVolatilityAnnualized: ").Append(TrailingOneYearVolatilityAnnualized)
				.Append("\n");
			sb.Append("  TrailingThreeYearAnnualizedReturnSplitAndDividend: ")
				.Append(TrailingThreeYearAnnualizedReturnSplitAndDividend).Append("\n");
			sb.Append("  TrailingThreeYearAnnualizedReturnSplitOnly: ")
				.Append(TrailingThreeYearAnnualizedReturnSplitOnly).Append("\n");
			sb.Append("  TrailingThreeYearVolatilityAnnualized: ").Append(TrailingThreeYearVolatilityAnnualized)
				.Append("\n");
			sb.Append("  TrailingFiveYearAnnualizedReturnSplitAndDividend: ")
				.Append(TrailingFiveYearAnnualizedReturnSplitAndDividend).Append("\n");
			sb.Append("  TrailingFiveYearAnnualizedReturnSplitOnly: ").Append(TrailingFiveYearAnnualizedReturnSplitOnly)
				.Append("\n");
			sb.Append("  TrailingFiveYearVolatilityAnnualized: ").Append(TrailingFiveYearVolatilityAnnualized)
				.Append("\n");
			sb.Append("  TrailingTenYearAnnualizedReturnSplitAndDividend: ")
				.Append(TrailingTenYearAnnualizedReturnSplitAndDividend).Append("\n");
			sb.Append("  TrailingTenYearAnnualizedReturnSplitOnly: ").Append(TrailingTenYearAnnualizedReturnSplitOnly)
				.Append("\n");
			sb.Append("  InceptionAnnualizedReturnSplitAndDividend: ").Append(InceptionAnnualizedReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  InceptionAnnualizedReturnSplitOnly: ").Append(InceptionAnnualizedReturnSplitOnly).Append("\n");
			sb.Append("  CalendarYear5ReturnSplitAndDividend: ").Append(CalendarYear5ReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  CalendarYear5ReturnSplitOnly: ").Append(CalendarYear5ReturnSplitOnly).Append("\n");
			sb.Append("  CalendarYear4ReturnSplitAndDividend: ").Append(CalendarYear4ReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  CalendarYear4ReturnSplitOnly: ").Append(CalendarYear4ReturnSplitOnly).Append("\n");
			sb.Append("  CalendarYear3ReturnSplitAndDividend: ").Append(CalendarYear3ReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  CalendarYear3ReturnSplitOnly: ").Append(CalendarYear3ReturnSplitOnly).Append("\n");
			sb.Append("  CalendarYear2ReturnSplitAndDividend: ").Append(CalendarYear2ReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  CalendarYear2ReturnSplitOnly: ").Append(CalendarYear2ReturnSplitOnly).Append("\n");
			sb.Append("  CalendarYear1ReturnSplitAndDividend: ").Append(CalendarYear1ReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  CalendarYear1ReturnSplitOnly: ").Append(CalendarYear1ReturnSplitOnly).Append("\n");
			sb.Append("  CalendarYearToDateReturnSplitAndDividend: ").Append(CalendarYearToDateReturnSplitAndDividend)
				.Append("\n");
			sb.Append("  CalendarYearToDateReturnSplitOnly: ").Append(CalendarYearToDateReturnSplitOnly).Append("\n");
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
			return Equals(input as ETFStats);
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
				if (NetAssetValue != null)
					hashCode = hashCode * 59 + NetAssetValue.GetHashCode();
				if (BetaVsSpy != null)
					hashCode = hashCode * 59 + BetaVsSpy.GetHashCode();
				if (TrailingOneMonthReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + TrailingOneMonthReturnSplitAndDividend.GetHashCode();
				if (TrailingOneMonthReturnSplitOnly != null)
					hashCode = hashCode * 59 + TrailingOneMonthReturnSplitOnly.GetHashCode();
				if (TrailingOneYearReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + TrailingOneYearReturnSplitAndDividend.GetHashCode();
				if (TrailingOneYearReturnSplitOnly != null)
					hashCode = hashCode * 59 + TrailingOneYearReturnSplitOnly.GetHashCode();
				if (TrailingOneYearVolatilityAnnualized != null)
					hashCode = hashCode * 59 + TrailingOneYearVolatilityAnnualized.GetHashCode();
				if (TrailingThreeYearAnnualizedReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + TrailingThreeYearAnnualizedReturnSplitAndDividend.GetHashCode();
				if (TrailingThreeYearAnnualizedReturnSplitOnly != null)
					hashCode = hashCode * 59 + TrailingThreeYearAnnualizedReturnSplitOnly.GetHashCode();
				if (TrailingThreeYearVolatilityAnnualized != null)
					hashCode = hashCode * 59 + TrailingThreeYearVolatilityAnnualized.GetHashCode();
				if (TrailingFiveYearAnnualizedReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + TrailingFiveYearAnnualizedReturnSplitAndDividend.GetHashCode();
				if (TrailingFiveYearAnnualizedReturnSplitOnly != null)
					hashCode = hashCode * 59 + TrailingFiveYearAnnualizedReturnSplitOnly.GetHashCode();
				if (TrailingFiveYearVolatilityAnnualized != null)
					hashCode = hashCode * 59 + TrailingFiveYearVolatilityAnnualized.GetHashCode();
				if (TrailingTenYearAnnualizedReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + TrailingTenYearAnnualizedReturnSplitAndDividend.GetHashCode();
				if (TrailingTenYearAnnualizedReturnSplitOnly != null)
					hashCode = hashCode * 59 + TrailingTenYearAnnualizedReturnSplitOnly.GetHashCode();
				if (InceptionAnnualizedReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + InceptionAnnualizedReturnSplitAndDividend.GetHashCode();
				if (InceptionAnnualizedReturnSplitOnly != null)
					hashCode = hashCode * 59 + InceptionAnnualizedReturnSplitOnly.GetHashCode();
				if (CalendarYear5ReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + CalendarYear5ReturnSplitAndDividend.GetHashCode();
				if (CalendarYear5ReturnSplitOnly != null)
					hashCode = hashCode * 59 + CalendarYear5ReturnSplitOnly.GetHashCode();
				if (CalendarYear4ReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + CalendarYear4ReturnSplitAndDividend.GetHashCode();
				if (CalendarYear4ReturnSplitOnly != null)
					hashCode = hashCode * 59 + CalendarYear4ReturnSplitOnly.GetHashCode();
				if (CalendarYear3ReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + CalendarYear3ReturnSplitAndDividend.GetHashCode();
				if (CalendarYear3ReturnSplitOnly != null)
					hashCode = hashCode * 59 + CalendarYear3ReturnSplitOnly.GetHashCode();
				if (CalendarYear2ReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + CalendarYear2ReturnSplitAndDividend.GetHashCode();
				if (CalendarYear2ReturnSplitOnly != null)
					hashCode = hashCode * 59 + CalendarYear2ReturnSplitOnly.GetHashCode();
				if (CalendarYear1ReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + CalendarYear1ReturnSplitAndDividend.GetHashCode();
				if (CalendarYear1ReturnSplitOnly != null)
					hashCode = hashCode * 59 + CalendarYear1ReturnSplitOnly.GetHashCode();
				if (CalendarYearToDateReturnSplitAndDividend != null)
					hashCode = hashCode * 59 + CalendarYearToDateReturnSplitAndDividend.GetHashCode();
				if (CalendarYearToDateReturnSplitOnly != null)
					hashCode = hashCode * 59 + CalendarYearToDateReturnSplitOnly.GetHashCode();
				if (Etf != null)
					hashCode = hashCode * 59 + Etf.GetHashCode();
				return hashCode;
			}
		}
	}
}