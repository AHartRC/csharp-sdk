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
	///     Exchange Traded Fund (ETF) including extensive metadata
	/// </summary>
	[DataContract]
	public class ETF : IEquatable<ETF>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ETF" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the ETF.</param>
		/// <param name="Name">The common name of the ETF.</param>
		/// <param name="Ticker">The common ticker symbol for the ETF.</param>
		/// <param name="FigiTicker">The OpenFIGI ticker for the ETF.</param>
		/// <param name="Ric">Reuters Instrument Code (RIC) for the ETF.</param>
		/// <param name="Isin">International Securities Identification Number (ISIN) for the ETF.</param>
		/// <param name="Sedol">Stock Exchange Daily Official List (SEDOL) for the ETF.</param>
		/// <param name="ExchangeMic">
		///     The exchange Market Identifier Code (MIC) from the International Standards Organization
		///     (ISO).
		/// </param>
		/// <param name="Sponsor">The fund manager (ETF) or issuing bank (ETN).</param>
		/// <param name="Type">High-level classification for the ETF based on its intended investment objective.</param>
		/// <param name="Description">The ETF description as published by the ETF sponsor.</param>
		/// <param name="InceptionDate">Inception Date for the ETF as published by the ETF sponsor.</param>
		/// <param name="DataChangeDate">The last date on which there was a change in a classifications data field for this ETF.</param>
		/// <param name="CloseDate">The date on which this ETF was de-listed if it is no longer listed.</param>
		/// <param name="IsLiveListed">If true, the ETF is still listed on an exchange; if false, the ETF is no longer listed.</param>
		/// <param name="LegalStructure">The legal structure as defined in the prospectus.</param>
		/// <param name="IntradayNavTicker">Intra-day NAV ticker for the Exchange Traded Fund (ETF).</param>
		/// <param name="PrimaryTicker">
		///     The primary ticker field is used for Exchange Traded Products (ETPs) that have multiple
		///     listings and share classes. If an ETP has multiple listings or share classes, the same primary ticker is assigned
		///     to all the listings and share classes.
		/// </param>
		/// <param name="PrimaryTickerCountryCode">2 letter ISO country code for the country of the primary listing.</param>
		/// <param name="PrimaryListingRegion">Geographic region in the country of the primary listing falls.</param>
		/// <param name="NetExpenseRatio">
		///     Gross expense net of Fee Waivers, as a percentage of net assets as published by the ETF
		///     Sponsor.
		/// </param>
		/// <param name="AssetClass">Captures the underlying nature of the securities in the Exchanged Traded Product (ETP).</param>
		/// <param name="OtherAssetTypes">
		///     If &#39;asset_class&#39; field is classified as &#39;Other Asset Types&#39; this field
		///     captures the specific category of the underlying assets.
		/// </param>
		/// <param name="MarketCapRange">
		///     Equity ETFs are classified as falling into categories based on the description of their
		///     investment strategy in the prospectus.  Examples (&#39;Mega Cap&#39;, &#39;Large Cap&#39;, &#39;Mid Cap&#39;,
		///     etc.).
		/// </param>
		/// <param name="HoldsOnlyNyseStocks">If true, the ETF is an equity ETF and holds only stocks listed on NYSE.</param>
		/// <param name="HoldsOnlyNasdaqStocks">If false, the ETF is an equity ETF and holds only stocks listed on Nasdaq.</param>
		/// <param name="GrowthValueTilt">
		///     Classifies equity ETFs as either &#39;Growth&#39; or Value&#39; based on the stated style
		///     tilt in the ETF prospectus. Equity ETFs that do not have a stated style tilt are classified as &#39;Core / Blend
		///     &#39;.
		/// </param>
		/// <param name="GrowthType">
		///     For ETFs that are classified as &#39;Growth&#39; in &#39;growth_value_tilt&#39;, this field
		///     further identifies those where the stocks in the ETF are both selected and weighted based on their growth (style
		///     factor) scores.
		/// </param>
		/// <param name="ValueType">
		///     For ETFs that are classified as &#39;Value&#39; in &#39;growth_value_tilt&#39;, this field
		///     further identifies those where the stocks in the ETF are both selected and weighted based on their value (style
		///     factor) scores.
		/// </param>
		/// <param name="Sector">
		///     For equity ETFs that aim to provide targeted exposure to a sector or industry, this field
		///     identifies the Sector that it provides the exposure to.
		/// </param>
		/// <param name="Industry">
		///     For equity ETFs that aim to provide targeted exposure to an industry, this field identifies the
		///     Industry that it provides the exposure to..
		/// </param>
		/// <param name="SubIndustry">
		///     For equity ETFs that aim to provide targeted exposure to a sub-industry, this field
		///     identifies the sub-industry that it provides the exposure to.
		/// </param>
		/// <param name="CrossSectorTheme">
		///     For equity ETFs that aim to provide targeted exposure to a specific investment theme
		///     that cuts across GICS sectors, this field identifies the specific cross-sector theme.  Examples (&#39;Agri-business
		///     &#39;, &#39;Natural Resources&#39;, &#39;Green Investing&#39;, etc.).
		/// </param>
		/// <param name="NaturalResourcesType">
		///     For ETFs that are classified as &#39;Natural Resources&#39; in the &#39;
		///     cross_sector_theme&#39; field, this field provides further detail on the type of Natural Resources exposure..
		/// </param>
		/// <param name="ExcludesFinancials">
		///     For equity ETFs, identifies those ETFs where the underlying fund holdings will not
		///     hold financials stocks, based on the funds intended objective.
		/// </param>
		/// <param name="ExcludesTechnology">
		///     For equity ETFs, identifies those ETFs where the underlying fund holdings will not
		///     hold technology stocks, based on the funds intended objective.
		/// </param>
		/// <param name="UsOrExcludesUs">
		///     Takes the value of &#39;Domestic&#39; for US exposure, &#39;International&#39; for non-US
		///     exposure and &#39;Global&#39; for exposure that includes all regions including the US.
		/// </param>
		/// <param name="DevelopedEmerging">
		///     This field identifies the stage of development of the markets that the ETF provides
		///     exposure to.
		/// </param>
		/// <param name="SpecializedRegion">
		///     This field is populated if the ETF provides targeted exposure to a specific type of
		///     geography-based grouping that does not fall into a specific country or continent grouping.  Examples (&#39;BRIC
		///     &#39;, &#39;Chindia&#39;, etc.).
		/// </param>
		/// <param name="Continent">
		///     This field is populated if the ETF provides targeted exposure to a specific continent or
		///     country within that Continent.
		/// </param>
		/// <param name="LatinAmericaSubGroup">
		///     For ETFs that are classified as &#39;Latin America&#39; in the &#39;continent&#39;
		///     field, this field provides further detail on the type of regional exposure.
		/// </param>
		/// <param name="EuropeSubGroup">
		///     For ETFs that are classified as &#39;Europe&#39; in the &#39;continent&#39; field, this
		///     field provides further detail on the type of regional exposure.
		/// </param>
		/// <param name="AsiaSubGroup">
		///     For ETFs that are classified as &#39;Asia&#39; in the &#39;continent&#39; field, this field
		///     provides further detail on the type of regional exposure.
		/// </param>
		/// <param name="SpecificCountry">This field is populated if the ETF provides targeted exposure to a specific country.</param>
		/// <param name="ChinaListingLocation">
		///     For ETFs that are classified as &#39;China&#39; in the &#39;country&#39; field, this
		///     field provides further detail on the type of exposure in the underlying securities.
		/// </param>
		/// <param name="UsState">
		///     Takes the value of a US state if the ETF provides targeted exposure to the municipal bonds or
		///     equities of companies operating in a specific state in the US.
		/// </param>
		/// <param name="RealEstate">
		///     For ETFs that provide targeted real estate exposure, this field is populated if the ETF
		///     provides targeted exposure to a specific segment of the real estate market.
		/// </param>
		/// <param name="IndexWeightingScheme">
		///     For ETFs that track an underlying index, this field provides detail on the index
		///     weighting type.
		/// </param>
		/// <param name="MarketCapWeightingType">
		///     For ETFs that take the value &#39;Market Cap Weighted&#39; in the &#39;
		///     index_weighting_scheme&#39; field, this field provides detail on the market cap weighting type.
		/// </param>
		/// <param name="FundamentalWeightingType">
		///     For ETFs that take the value ‘Fundamental Weighted’ in the &#39;
		///     index_weighting_scheme&#39; field, this field provides detail on the fundamental weighting methodology.
		/// </param>
		/// <param name="DividendWeightingType">
		///     For ETFs that take the value &#39;Dividend Weighted&#39; in the &#39;
		///     index_weighting_scheme&#39; field, this field provides detail on the dividend weighting methodology.
		/// </param>
		/// <param name="BondType">
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Bonds&#39;, this field provides detail on the
		///     type of bonds held in the ETF.
		/// </param>
		/// <param name="GovernmentBondTypes">
		///     For bond ETFs that take the value &#39;Treasury &amp; Government&#39; in &#39;
		///     bond_type&#39;, this field provides detail on the exposure.
		/// </param>
		/// <param name="MunicipalBondRegion">
		///     For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this
		///     field provides additional detail on the geographic exposure.
		/// </param>
		/// <param name="MunicipalVrdo">
		///     For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this field
		///     identifies those ETFs that specifically provide exposure to Variable Rate Demand Obligations.
		/// </param>
		/// <param name="MortgageBondTypes">
		///     For bond ETFs that take the value &#39;Mortgage&#39; in &#39;bond_type&#39;, this field
		///     provides additional detail on the type of underlying securities.
		/// </param>
		/// <param name="BondTaxStatus">
		///     For all US bond ETFs, this field provides additional detail on the tax treatment of the
		///     underlying securities.
		/// </param>
		/// <param name="CreditQuality">
		///     For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to
		///     securities of a specific credit quality range.
		/// </param>
		/// <param name="AverageMaturity">
		///     For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to
		///     securities of a specific maturity range.
		/// </param>
		/// <param name="SpecificMaturityYear">
		///     For all bond ETFs that take the value &#39;Specific Maturity Year&#39; in the &#39;
		///     average_maturity&#39; field, this field specifies the calendar year.
		/// </param>
		/// <param name="BondCurrencyDenomination">
		///     For all bond ETFs, this field provides additional detail on the currency
		///     denomination of the underlying securities.
		/// </param>
		/// <param name="Laddered">
		///     For bond ETFs, this field identifies those ETFs that specifically hold bonds in a laddered
		///     structure, where the bonds are scheduled to mature in an annual, sequential structure.
		/// </param>
		/// <param name="ZeroCoupon">
		///     For bond ETFs, this field identifies those ETFs that specifically hold zero coupon Treasury
		///     Bills.
		/// </param>
		/// <param name="FloatingRate">For bond ETFs, this field identifies those ETFs that specifically hold floating rate bonds.</param>
		/// <param name="BuildAmericaBonds">
		///     For municipal bond ETFs, this field identifies those ETFs that specifically hold Build
		///     America Bonds.
		/// </param>
		/// <param name="CommodityTypes">
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Commodities&#39;, this field provides
		///     detail on the type of commodities held in the ETF.
		/// </param>
		/// <param name="EnergyType">
		///     For ETFs where &#39;commodity_type&#39; is &#39;Energy&#39;, this field provides detail on the
		///     type of energy exposure provided by the ETF.
		/// </param>
		/// <param name="AgriculturalType">
		///     For ETFs where &#39;commodity_type&#39; is &#39;Agricultural&#39;, this field provides
		///     detail on the type of agricultural exposure provided by the ETF.
		/// </param>
		/// <param name="MetalType">
		///     For ETFs where &#39;commodity_type&#39; is &#39;Gold &amp; Metals&#39;, this field provides
		///     detail on the type of exposure provided by the ETF.
		/// </param>
		/// <param name="InverseLeveraged">This field is populated if the ETF provides inverse or leveraged exposure.</param>
		/// <param name="TargetDateMultiAssetType">
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Target Date / MultiAsset&#39;,
		///     this field provides detail on the type of commodities held in the ETF.
		/// </param>
		/// <param name="CurrencyHedged">This field is populated if the ETF’s strategy involves hedging currency exposure.</param>
		/// <param name="CurrencyPair">
		///     This field is populated if the ETF’s strategy involves providing exposure to the movements
		///     of a currency or involves hedging currency exposure.
		/// </param>
		/// <param name="SocialEnvironmentalType">
		///     This field is populated if the ETF’s strategy involves providing exposure to a
		///     specific social or environmental theme.
		/// </param>
		/// <param name="CleanEnergyType">
		///     This field is populated if the ETF has a value of &#39;Clean Energy&#39; in the &#39;
		///     social_environmental_type&#39; field..
		/// </param>
		/// <param name="DividendType">
		///     This field is populated if the ETF has an intended investment objective of holding
		///     dividend-oriented stocks as stated in the prospectus.
		/// </param>
		/// <param name="RegularDividendPayorType">
		///     This field is populated if the ETF has a value of &#39;Dividend – Regular Payors
		///     &#39; in the &#39;dividend_type&#39; field.
		/// </param>
		/// <param name="HoldsMlPs">
		///     If true, the ETF’s investment objective explicitly specifies that it holds MLPs as an intended
		///     part of its investment strategy.
		/// </param>
		/// <param name="HoldsPreferredStock">
		///     If true, the ETF’s investment objective explicitly specifies that it holds preferred
		///     stock as an intended part of its investment strategy.
		/// </param>
		/// <param name="HoldsClosedEndFunds">
		///     IF true, if the ETF’s investment objective explicitly specifies that it holds closed
		///     end funds as an intended part of its investment strategy.
		/// </param>
		/// <param name="QuantStrategiesType">
		///     This field is populated if the ETF has either an index-linked or active strategy that
		///     is based on a proprietary quantitative strategy.
		/// </param>
		/// <param name="OtherQuantModels">
		///     For ETFs where &#39;quant_strategies_type&#39; is &#39;Other Quant Model&#39;, this
		///     field provides the name of the specific proprietary quant model used as the underlying strategy for the ETF.
		/// </param>
		/// <param name="HedgeFundType">
		///     For ETFs where &#39;other_asset_types&#39; is &#39;Hedge Fund Replication&#39;, this field
		///     provides detail on the type of hedge fund replication strategy.
		/// </param>
		/// <param name="DerivativesBased">
		///     This field is populated if the ETF holds either listed or over-the-counter derivatives
		///     in its portfolio.
		/// </param>
		/// <param name="HoldsAdRs">
		///     If true, he ETF’s investment objective explicitly specifies that it holds American Depositary
		///     Receipts (ADRs) as an intended part of its investment strategy.
		/// </param>
		/// <param name="IndexLinked">This field identifies whether an ETF is index linked or active.</param>
		/// <param name="IncludesShortExposure">
		///     This field is populated if the ETF has short exposure in any of its holdings e.g.
		///     in a long/short or inverse ETF.
		/// </param>
		/// <param name="IndexName">This field identifies the name of the underlying index tracked by the ETF, if applicable.</param>
		/// <param name="ParentIndex">
		///     This field identifies the name of the parent index, which represents the broader universe
		///     from which the index underlying the ETF is created, if applicable.
		/// </param>
		/// <param name="IndexFamily">
		///     This field identifies the index family to which the index underlying the ETF belongs. The
		///     index family is represented as categorized by the index provider.
		/// </param>
		/// <param name="BroaderIndexFamily">
		///     This field identifies the broader index family to which the index underlying the ETF
		///     belongs. The broader index family is represented as categorized by the index provider.
		/// </param>
		/// <param name="IndexProvider">This field identifies the Index provider for the index underlying the ETF, if applicable.</param>
		/// <param name="FundFamily">
		///     This field identifies the fund family to which the ETF belongs, as categorized by the ETF
		///     Sponsor.
		/// </param>
		/// <param name="IndexTicker">This field identifies the OpenFIGI ticker for the Index underlying the ETF.</param>
		/// <param name="EtnIssuingBank">If the product is an Exchange Traded Note (ETN), this field identifies the issuing bank.</param>
		/// <param name="EtnMaturityDate">If the product is an ETN, this field identifies the maturity date for the ETN.</param>
		/// <param name="Livestock">
		///     For ETFs where &#39;commodity_type&#39; is &#39;Livestock&#39;, this field provides detail on
		///     the type of livestock exposure provided by the ETF.
		/// </param>
		/// <param name="DynamicFuturesRoll">
		///     If the product holds futures contracts, this field identifies those products where the
		///     roll strategy is dynamic (rather than entirely rules based), so as to minimize roll costs.
		/// </param>
		/// <param name="IndexProviderCode">
		///     This field provides the First Bridge code for each Index provider, corresponding to the
		///     index underlying the ETF if applicable.
		/// </param>
		/// <param name="SingleCategoryDesignation">
		///     This categorization is created for those users who want every ETF to be
		///     ‘forced’ into a single bucket, so that the assets for all categories will always sum to the total market.
		/// </param>
		/// <param name="RegisteredCountries">
		///     The list of countries where the ETF is legally registered for sale. This may differ
		///     from where the ETF is domiciled or traded, particularly in Europe.
		/// </param>
		/// <param name="IssuingEntityCountryCode">The name of the legal entity that issued the Exchange Traded Product (ETP).</param>
		/// <param name="Ucits">
		///     If true, the Exchange Traded Product (ETP) is Undertakings for the Collective Investment in
		///     Transferable Securities (UCITS) compliant.
		/// </param>
		/// <param name="ReplicationStructure">The replication structure of the Exchange Traded Product (ETP).</param>
		/// <param name="Domicile">2 letter ISO country code for the country where the ETP is domiciled.</param>
		/// <param name="BaseCurrency">
		///     Base currency of the Exchange Traded Product (ETP) in which the net asset value (NAV) is
		///     calculated. Reported using the 3-digit ISO currency code.
		/// </param>
		/// <param name="ListingCurrency">
		///     Listing currency of the Exchange Traded Product (ETP) in which it is traded. Reported
		///     using the 3-digit ISO currency code.
		/// </param>
		/// <param name="FundListingDate">
		///     The date on which the Exchange Traded Product (ETP) or share class of the ETP is listed
		///     on a specific exchange.
		/// </param>
		/// <param name="ListingCountryCode">
		///     2 letter ISO country code for the country where the Exchange Traded Product (ETP) is
		///     listed.
		/// </param>
		/// <param name="ListingRegion">The region in which this specific ETF is listed.</param>
		/// <param name="SmartvsTraditionalBeta">
		///     This field identifies whether an ETF provides &#39;Traditional&#39; beta exposure
		///     or &#39;Smart&#39; beta exposure. ETFs that are active (i.e. non-indexed), leveraged / inverse or have a
		///     proprietary quant model (i.e. that don’t provide indexed exposure to a targeted factor) are classified separately.
		/// </param>
		/// <param name="SmartvsTraditionalBetaLevel2">
		///     This field provides further detail within the traditional and smart beta
		///     categories.
		/// </param>
		/// <param name="IncomeCategory">
		///     Identifies if an Exchange Traded Fund (ETF) falls into a category that is specifically
		///     designed to provide a high yield or income.
		/// </param>
		/// <param name="EtpStructureType">
		///     Classifies Exchange Traded Products (ETPs) into very broad categories based on its legal
		///     structure.
		/// </param>
		/// <param name="MonthEndAssets">Net assets in millions of dollars as of the most recent month end.</param>
		/// <param name="EtfPortfolioTurnover">The percentage of positions turned over in the last 12 months.</param>
		/// <param name="FirstbridgeId">The FirstBridge unique identifier for the Exchange Traded Fund (ETF).</param>
		/// <param name="FirstbridgeParentId">
		///     The FirstBridge unique identifier of the parent Exchange Traded Fund (ETF), if
		///     applicable.
		/// </param>
		/// <param name="NumberOfHoldings">The number of holdings for this Exchange Traded Fund (ETF).</param>
		public ETF(string Id = default, string Name = default, string Ticker = default, string FigiTicker = default,
			string Ric = default, string Isin = default, string Sedol = default, string ExchangeMic = default,
			string Sponsor = default, string Type = default, string Description = default,
			DateTime? InceptionDate = default, DateTime? DataChangeDate = default, DateTime? CloseDate = default,
			bool? IsLiveListed = default, string LegalStructure = default, string IntradayNavTicker = default,
			string PrimaryTicker = default, string PrimaryTickerCountryCode = default,
			string PrimaryListingRegion = default, decimal? NetExpenseRatio = default, string AssetClass = default,
			string OtherAssetTypes = default, string MarketCapRange = default, bool? HoldsOnlyNyseStocks = default,
			bool? HoldsOnlyNasdaqStocks = default, string GrowthValueTilt = default, string GrowthType = default,
			string ValueType = default, string Sector = default, string Industry = default,
			string SubIndustry = default, string CrossSectorTheme = default, string NaturalResourcesType = default,
			bool? ExcludesFinancials = default, bool? ExcludesTechnology = default, string UsOrExcludesUs = default,
			string DevelopedEmerging = default, string SpecializedRegion = default, string Continent = default,
			string LatinAmericaSubGroup = default, string EuropeSubGroup = default, string AsiaSubGroup = default,
			string SpecificCountry = default, string ChinaListingLocation = default, string UsState = default,
			string RealEstate = default, string IndexWeightingScheme = default, string MarketCapWeightingType = default,
			string FundamentalWeightingType = default, string DividendWeightingType = default,
			string BondType = default, string GovernmentBondTypes = default, string MunicipalBondRegion = default,
			bool? MunicipalVrdo = default, string MortgageBondTypes = default, string BondTaxStatus = default,
			string CreditQuality = default, string AverageMaturity = default, int? SpecificMaturityYear = default,
			string BondCurrencyDenomination = default, bool? Laddered = default, bool? ZeroCoupon = default,
			bool? FloatingRate = default, bool? BuildAmericaBonds = default, string CommodityTypes = default,
			string EnergyType = default, string AgriculturalType = default, string MetalType = default,
			string InverseLeveraged = default, string TargetDateMultiAssetType = default,
			bool? CurrencyHedged = default, string CurrencyPair = default, string SocialEnvironmentalType = default,
			string CleanEnergyType = default, string DividendType = default, string RegularDividendPayorType = default,
			bool? HoldsMlPs = default, bool? HoldsPreferredStock = default, bool? HoldsClosedEndFunds = default,
			string QuantStrategiesType = default, string OtherQuantModels = default, string HedgeFundType = default,
			string DerivativesBased = default, bool? HoldsAdRs = default, string IndexLinked = default,
			bool? IncludesShortExposure = default, string IndexName = default, string ParentIndex = default,
			string IndexFamily = default, string BroaderIndexFamily = default, string IndexProvider = default,
			string FundFamily = default, string IndexTicker = default, string EtnIssuingBank = default,
			DateTime? EtnMaturityDate = default, string Livestock = default, bool? DynamicFuturesRoll = default,
			string IndexProviderCode = default, string SingleCategoryDesignation = default,
			string RegisteredCountries = default, string IssuingEntityCountryCode = default, bool? Ucits = default,
			string ReplicationStructure = default, string Domicile = default, string BaseCurrency = default,
			string ListingCurrency = default, DateTime? FundListingDate = default, string ListingCountryCode = default,
			string ListingRegion = default, string SmartvsTraditionalBeta = default,
			string SmartvsTraditionalBetaLevel2 = default, string IncomeCategory = default,
			string EtpStructureType = default, decimal? MonthEndAssets = default,
			decimal? EtfPortfolioTurnover = default, string FirstbridgeId = default,
			string FirstbridgeParentId = default, int? NumberOfHoldings = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.Ticker = Ticker;
			this.FigiTicker = FigiTicker;
			this.Ric = Ric;
			this.Isin = Isin;
			this.Sedol = Sedol;
			this.ExchangeMic = ExchangeMic;
			this.Sponsor = Sponsor;
			this.Type = Type;
			this.Description = Description;
			this.InceptionDate = InceptionDate;
			this.DataChangeDate = DataChangeDate;
			this.CloseDate = CloseDate;
			this.IsLiveListed = IsLiveListed;
			this.LegalStructure = LegalStructure;
			this.IntradayNavTicker = IntradayNavTicker;
			this.PrimaryTicker = PrimaryTicker;
			this.PrimaryTickerCountryCode = PrimaryTickerCountryCode;
			this.PrimaryListingRegion = PrimaryListingRegion;
			this.NetExpenseRatio = NetExpenseRatio;
			this.AssetClass = AssetClass;
			this.OtherAssetTypes = OtherAssetTypes;
			this.MarketCapRange = MarketCapRange;
			this.HoldsOnlyNyseStocks = HoldsOnlyNyseStocks;
			this.HoldsOnlyNasdaqStocks = HoldsOnlyNasdaqStocks;
			this.GrowthValueTilt = GrowthValueTilt;
			this.GrowthType = GrowthType;
			this.ValueType = ValueType;
			this.Sector = Sector;
			this.Industry = Industry;
			this.SubIndustry = SubIndustry;
			this.CrossSectorTheme = CrossSectorTheme;
			this.NaturalResourcesType = NaturalResourcesType;
			this.ExcludesFinancials = ExcludesFinancials;
			this.ExcludesTechnology = ExcludesTechnology;
			this.UsOrExcludesUs = UsOrExcludesUs;
			this.DevelopedEmerging = DevelopedEmerging;
			this.SpecializedRegion = SpecializedRegion;
			this.Continent = Continent;
			this.LatinAmericaSubGroup = LatinAmericaSubGroup;
			this.EuropeSubGroup = EuropeSubGroup;
			this.AsiaSubGroup = AsiaSubGroup;
			this.SpecificCountry = SpecificCountry;
			this.ChinaListingLocation = ChinaListingLocation;
			this.UsState = UsState;
			this.RealEstate = RealEstate;
			this.IndexWeightingScheme = IndexWeightingScheme;
			this.MarketCapWeightingType = MarketCapWeightingType;
			this.FundamentalWeightingType = FundamentalWeightingType;
			this.DividendWeightingType = DividendWeightingType;
			this.BondType = BondType;
			this.GovernmentBondTypes = GovernmentBondTypes;
			this.MunicipalBondRegion = MunicipalBondRegion;
			this.MunicipalVrdo = MunicipalVrdo;
			this.MortgageBondTypes = MortgageBondTypes;
			this.BondTaxStatus = BondTaxStatus;
			this.CreditQuality = CreditQuality;
			this.AverageMaturity = AverageMaturity;
			this.SpecificMaturityYear = SpecificMaturityYear;
			this.BondCurrencyDenomination = BondCurrencyDenomination;
			this.Laddered = Laddered;
			this.ZeroCoupon = ZeroCoupon;
			this.FloatingRate = FloatingRate;
			this.BuildAmericaBonds = BuildAmericaBonds;
			this.CommodityTypes = CommodityTypes;
			this.EnergyType = EnergyType;
			this.AgriculturalType = AgriculturalType;
			this.MetalType = MetalType;
			this.InverseLeveraged = InverseLeveraged;
			this.TargetDateMultiAssetType = TargetDateMultiAssetType;
			this.CurrencyHedged = CurrencyHedged;
			this.CurrencyPair = CurrencyPair;
			this.SocialEnvironmentalType = SocialEnvironmentalType;
			this.CleanEnergyType = CleanEnergyType;
			this.DividendType = DividendType;
			this.RegularDividendPayorType = RegularDividendPayorType;
			this.HoldsMlPs = HoldsMlPs;
			this.HoldsPreferredStock = HoldsPreferredStock;
			this.HoldsClosedEndFunds = HoldsClosedEndFunds;
			this.QuantStrategiesType = QuantStrategiesType;
			this.OtherQuantModels = OtherQuantModels;
			this.HedgeFundType = HedgeFundType;
			this.DerivativesBased = DerivativesBased;
			this.HoldsAdRs = HoldsAdRs;
			this.IndexLinked = IndexLinked;
			this.IncludesShortExposure = IncludesShortExposure;
			this.IndexName = IndexName;
			this.ParentIndex = ParentIndex;
			this.IndexFamily = IndexFamily;
			this.BroaderIndexFamily = BroaderIndexFamily;
			this.IndexProvider = IndexProvider;
			this.FundFamily = FundFamily;
			this.IndexTicker = IndexTicker;
			this.EtnIssuingBank = EtnIssuingBank;
			this.EtnMaturityDate = EtnMaturityDate;
			this.Livestock = Livestock;
			this.DynamicFuturesRoll = DynamicFuturesRoll;
			this.IndexProviderCode = IndexProviderCode;
			this.SingleCategoryDesignation = SingleCategoryDesignation;
			this.RegisteredCountries = RegisteredCountries;
			this.IssuingEntityCountryCode = IssuingEntityCountryCode;
			this.Ucits = Ucits;
			this.ReplicationStructure = ReplicationStructure;
			this.Domicile = Domicile;
			this.BaseCurrency = BaseCurrency;
			this.ListingCurrency = ListingCurrency;
			this.FundListingDate = FundListingDate;
			this.ListingCountryCode = ListingCountryCode;
			this.ListingRegion = ListingRegion;
			this.SmartvsTraditionalBeta = SmartvsTraditionalBeta;
			this.SmartvsTraditionalBetaLevel2 = SmartvsTraditionalBetaLevel2;
			this.IncomeCategory = IncomeCategory;
			this.EtpStructureType = EtpStructureType;
			this.MonthEndAssets = MonthEndAssets;
			this.EtfPortfolioTurnover = EtfPortfolioTurnover;
			this.FirstbridgeId = FirstbridgeId;
			this.FirstbridgeParentId = FirstbridgeParentId;
			this.NumberOfHoldings = NumberOfHoldings;
		}

		/// <summary>
		///     The Intrinio ID of the ETF
		/// </summary>
		/// <value>The Intrinio ID of the ETF</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The common name of the ETF
		/// </summary>
		/// <value>The common name of the ETF</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The common ticker symbol for the ETF
		/// </summary>
		/// <value>The common ticker symbol for the ETF</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The OpenFIGI ticker for the ETF
		/// </summary>
		/// <value>The OpenFIGI ticker for the ETF</value>
		[DataMember(Name = "figi_ticker", EmitDefaultValue = false)]
		public string FigiTicker { get; set; }

		/// <summary>
		///     Reuters Instrument Code (RIC) for the ETF
		/// </summary>
		/// <value>Reuters Instrument Code (RIC) for the ETF</value>
		[DataMember(Name = "ric", EmitDefaultValue = false)]
		public string Ric { get; set; }

		/// <summary>
		///     International Securities Identification Number (ISIN) for the ETF
		/// </summary>
		/// <value>International Securities Identification Number (ISIN) for the ETF</value>
		[DataMember(Name = "isin", EmitDefaultValue = false)]
		public string Isin { get; set; }

		/// <summary>
		///     Stock Exchange Daily Official List (SEDOL) for the ETF
		/// </summary>
		/// <value>Stock Exchange Daily Official List (SEDOL) for the ETF</value>
		[DataMember(Name = "sedol", EmitDefaultValue = false)]
		public string Sedol { get; set; }

		/// <summary>
		///     The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO)
		/// </summary>
		/// <value>The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO)</value>
		[DataMember(Name = "exchange_mic", EmitDefaultValue = false)]
		public string ExchangeMic { get; set; }

		/// <summary>
		///     The fund manager (ETF) or issuing bank (ETN)
		/// </summary>
		/// <value>The fund manager (ETF) or issuing bank (ETN)</value>
		[DataMember(Name = "sponsor", EmitDefaultValue = false)]
		public string Sponsor { get; set; }

		/// <summary>
		///     High-level classification for the ETF based on its intended investment objective
		/// </summary>
		/// <value>High-level classification for the ETF based on its intended investment objective</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		///     The ETF description as published by the ETF sponsor
		/// </summary>
		/// <value>The ETF description as published by the ETF sponsor</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		///     Inception Date for the ETF as published by the ETF sponsor
		/// </summary>
		/// <value>Inception Date for the ETF as published by the ETF sponsor</value>
		[DataMember(Name = "inception_date", EmitDefaultValue = false)]
		
		public DateTime? InceptionDate { get; set; }

		/// <summary>
		///     The last date on which there was a change in a classifications data field for this ETF
		/// </summary>
		/// <value>The last date on which there was a change in a classifications data field for this ETF</value>
		[DataMember(Name = "data_change_date", EmitDefaultValue = false)]
		
		public DateTime? DataChangeDate { get; set; }

		/// <summary>
		///     The date on which this ETF was de-listed if it is no longer listed
		/// </summary>
		/// <value>The date on which this ETF was de-listed if it is no longer listed</value>
		[DataMember(Name = "close_date", EmitDefaultValue = false)]
		
		public DateTime? CloseDate { get; set; }

		/// <summary>
		///     If true, the ETF is still listed on an exchange; if false, the ETF is no longer listed
		/// </summary>
		/// <value>If true, the ETF is still listed on an exchange; if false, the ETF is no longer listed</value>
		[DataMember(Name = "is_live_listed", EmitDefaultValue = false)]
		public bool? IsLiveListed { get; set; }

		/// <summary>
		///     The legal structure as defined in the prospectus
		/// </summary>
		/// <value>The legal structure as defined in the prospectus</value>
		[DataMember(Name = "legal_structure", EmitDefaultValue = false)]
		public string LegalStructure { get; set; }

		/// <summary>
		///     Intra-day NAV ticker for the Exchange Traded Fund (ETF)
		/// </summary>
		/// <value>Intra-day NAV ticker for the Exchange Traded Fund (ETF)</value>
		[DataMember(Name = "intraday_nav_ticker", EmitDefaultValue = false)]
		public string IntradayNavTicker { get; set; }

		/// <summary>
		///     The primary ticker field is used for Exchange Traded Products (ETPs) that have multiple listings and share classes.
		///     If an ETP has multiple listings or share classes, the same primary ticker is assigned to all the listings and share
		///     classes
		/// </summary>
		/// <value>
		///     The primary ticker field is used for Exchange Traded Products (ETPs) that have multiple listings and share
		///     classes. If an ETP has multiple listings or share classes, the same primary ticker is assigned to all the listings
		///     and share classes
		/// </value>
		[DataMember(Name = "primary_ticker", EmitDefaultValue = false)]
		public string PrimaryTicker { get; set; }

		/// <summary>
		///     2 letter ISO country code for the country of the primary listing
		/// </summary>
		/// <value>2 letter ISO country code for the country of the primary listing</value>
		[DataMember(Name = "primary_ticker_country_code", EmitDefaultValue = false)]
		public string PrimaryTickerCountryCode { get; set; }

		/// <summary>
		///     Geographic region in the country of the primary listing falls
		/// </summary>
		/// <value>Geographic region in the country of the primary listing falls</value>
		[DataMember(Name = "primary_listing_region", EmitDefaultValue = false)]
		public string PrimaryListingRegion { get; set; }

		/// <summary>
		///     Gross expense net of Fee Waivers, as a percentage of net assets as published by the ETF Sponsor
		/// </summary>
		/// <value>Gross expense net of Fee Waivers, as a percentage of net assets as published by the ETF Sponsor</value>
		[DataMember(Name = "net_expense_ratio", EmitDefaultValue = false)]
		public decimal? NetExpenseRatio { get; set; }

		/// <summary>
		///     Captures the underlying nature of the securities in the Exchanged Traded Product (ETP)
		/// </summary>
		/// <value>Captures the underlying nature of the securities in the Exchanged Traded Product (ETP)</value>
		[DataMember(Name = "asset_class", EmitDefaultValue = false)]
		public string AssetClass { get; set; }

		/// <summary>
		///     If &#39;asset_class&#39; field is classified as &#39;Other Asset Types&#39; this field captures the specific
		///     category of the underlying assets
		/// </summary>
		/// <value>
		///     If &#39;asset_class&#39; field is classified as &#39;Other Asset Types&#39; this field captures the specific
		///     category of the underlying assets
		/// </value>
		[DataMember(Name = "other_asset_types", EmitDefaultValue = false)]
		public string OtherAssetTypes { get; set; }

		/// <summary>
		///     Equity ETFs are classified as falling into categories based on the description of their investment strategy in the
		///     prospectus.  Examples (&#39;Mega Cap&#39;, &#39;Large Cap&#39;, &#39;Mid Cap&#39;, etc.)
		/// </summary>
		/// <value>
		///     Equity ETFs are classified as falling into categories based on the description of their investment strategy in
		///     the prospectus.  Examples (&#39;Mega Cap&#39;, &#39;Large Cap&#39;, &#39;Mid Cap&#39;, etc.)
		/// </value>
		[DataMember(Name = "market_cap_range", EmitDefaultValue = false)]
		public string MarketCapRange { get; set; }

		/// <summary>
		///     If true, the ETF is an equity ETF and holds only stocks listed on NYSE
		/// </summary>
		/// <value>If true, the ETF is an equity ETF and holds only stocks listed on NYSE</value>
		[DataMember(Name = "holds_only_nyse_stocks", EmitDefaultValue = false)]
		public bool? HoldsOnlyNyseStocks { get; set; }

		/// <summary>
		///     If false, the ETF is an equity ETF and holds only stocks listed on Nasdaq
		/// </summary>
		/// <value>If false, the ETF is an equity ETF and holds only stocks listed on Nasdaq</value>
		[DataMember(Name = "holds_only_nasdaq_stocks", EmitDefaultValue = false)]
		public bool? HoldsOnlyNasdaqStocks { get; set; }

		/// <summary>
		///     Classifies equity ETFs as either &#39;Growth&#39; or Value&#39; based on the stated style tilt in the ETF
		///     prospectus. Equity ETFs that do not have a stated style tilt are classified as &#39;Core / Blend&#39;
		/// </summary>
		/// <value>
		///     Classifies equity ETFs as either &#39;Growth&#39; or Value&#39; based on the stated style tilt in the ETF
		///     prospectus. Equity ETFs that do not have a stated style tilt are classified as &#39;Core / Blend&#39;
		/// </value>
		[DataMember(Name = "growth_value_tilt", EmitDefaultValue = false)]
		public string GrowthValueTilt { get; set; }

		/// <summary>
		///     For ETFs that are classified as &#39;Growth&#39; in &#39;growth_value_tilt&#39;, this field further identifies
		///     those where the stocks in the ETF are both selected and weighted based on their growth (style factor) scores
		/// </summary>
		/// <value>
		///     For ETFs that are classified as &#39;Growth&#39; in &#39;growth_value_tilt&#39;, this field further identifies
		///     those where the stocks in the ETF are both selected and weighted based on their growth (style factor) scores
		/// </value>
		[DataMember(Name = "growth_type", EmitDefaultValue = false)]
		public string GrowthType { get; set; }

		/// <summary>
		///     For ETFs that are classified as &#39;Value&#39; in &#39;growth_value_tilt&#39;, this field further identifies those
		///     where the stocks in the ETF are both selected and weighted based on their value (style factor) scores
		/// </summary>
		/// <value>
		///     For ETFs that are classified as &#39;Value&#39; in &#39;growth_value_tilt&#39;, this field further identifies
		///     those where the stocks in the ETF are both selected and weighted based on their value (style factor) scores
		/// </value>
		[DataMember(Name = "value_type", EmitDefaultValue = false)]
		public string ValueType { get; set; }

		/// <summary>
		///     For equity ETFs that aim to provide targeted exposure to a sector or industry, this field identifies the Sector
		///     that it provides the exposure to
		/// </summary>
		/// <value>
		///     For equity ETFs that aim to provide targeted exposure to a sector or industry, this field identifies the Sector
		///     that it provides the exposure to
		/// </value>
		[DataMember(Name = "sector", EmitDefaultValue = false)]
		public string Sector { get; set; }

		/// <summary>
		///     For equity ETFs that aim to provide targeted exposure to an industry, this field identifies the Industry that it
		///     provides the exposure to.
		/// </summary>
		/// <value>
		///     For equity ETFs that aim to provide targeted exposure to an industry, this field identifies the Industry that it
		///     provides the exposure to.
		/// </value>
		[DataMember(Name = "industry", EmitDefaultValue = false)]
		public string Industry { get; set; }

		/// <summary>
		///     For equity ETFs that aim to provide targeted exposure to a sub-industry, this field identifies the sub-industry
		///     that it provides the exposure to
		/// </summary>
		/// <value>
		///     For equity ETFs that aim to provide targeted exposure to a sub-industry, this field identifies the sub-industry
		///     that it provides the exposure to
		/// </value>
		[DataMember(Name = "sub_industry", EmitDefaultValue = false)]
		public string SubIndustry { get; set; }

		/// <summary>
		///     For equity ETFs that aim to provide targeted exposure to a specific investment theme that cuts across GICS sectors,
		///     this field identifies the specific cross-sector theme.  Examples (&#39;Agri-business&#39;, &#39;Natural Resources
		///     &#39;, &#39;Green Investing&#39;, etc.)
		/// </summary>
		/// <value>
		///     For equity ETFs that aim to provide targeted exposure to a specific investment theme that cuts across GICS
		///     sectors, this field identifies the specific cross-sector theme.  Examples (&#39;Agri-business&#39;, &#39;Natural
		///     Resources&#39;, &#39;Green Investing&#39;, etc.)
		/// </value>
		[DataMember(Name = "cross_sector_theme", EmitDefaultValue = false)]
		public string CrossSectorTheme { get; set; }

		/// <summary>
		///     For ETFs that are classified as &#39;Natural Resources&#39; in the &#39;cross_sector_theme&#39; field, this field
		///     provides further detail on the type of Natural Resources exposure.
		/// </summary>
		/// <value>
		///     For ETFs that are classified as &#39;Natural Resources&#39; in the &#39;cross_sector_theme&#39; field, this
		///     field provides further detail on the type of Natural Resources exposure.
		/// </value>
		[DataMember(Name = "natural_resources_type", EmitDefaultValue = false)]
		public string NaturalResourcesType { get; set; }

		/// <summary>
		///     For equity ETFs, identifies those ETFs where the underlying fund holdings will not hold financials stocks, based on
		///     the funds intended objective
		/// </summary>
		/// <value>
		///     For equity ETFs, identifies those ETFs where the underlying fund holdings will not hold financials stocks, based
		///     on the funds intended objective
		/// </value>
		[DataMember(Name = "excludes_financials", EmitDefaultValue = false)]
		public bool? ExcludesFinancials { get; set; }

		/// <summary>
		///     For equity ETFs, identifies those ETFs where the underlying fund holdings will not hold technology stocks, based on
		///     the funds intended objective
		/// </summary>
		/// <value>
		///     For equity ETFs, identifies those ETFs where the underlying fund holdings will not hold technology stocks, based
		///     on the funds intended objective
		/// </value>
		[DataMember(Name = "excludes_technology", EmitDefaultValue = false)]
		public bool? ExcludesTechnology { get; set; }

		/// <summary>
		///     Takes the value of &#39;Domestic&#39; for US exposure, &#39;International&#39; for non-US exposure and &#39;Global
		///     &#39; for exposure that includes all regions including the US
		/// </summary>
		/// <value>
		///     Takes the value of &#39;Domestic&#39; for US exposure, &#39;International&#39; for non-US exposure and &#39;
		///     Global&#39; for exposure that includes all regions including the US
		/// </value>
		[DataMember(Name = "us_or_excludes_us", EmitDefaultValue = false)]
		public string UsOrExcludesUs { get; set; }

		/// <summary>
		///     This field identifies the stage of development of the markets that the ETF provides exposure to
		/// </summary>
		/// <value>This field identifies the stage of development of the markets that the ETF provides exposure to</value>
		[DataMember(Name = "developed_emerging", EmitDefaultValue = false)]
		public string DevelopedEmerging { get; set; }

		/// <summary>
		///     This field is populated if the ETF provides targeted exposure to a specific type of geography-based grouping that
		///     does not fall into a specific country or continent grouping.  Examples (&#39;BRIC&#39;, &#39;Chindia&#39;, etc.)
		/// </summary>
		/// <value>
		///     This field is populated if the ETF provides targeted exposure to a specific type of geography-based grouping
		///     that does not fall into a specific country or continent grouping.  Examples (&#39;BRIC&#39;, &#39;Chindia&#39;,
		///     etc.)
		/// </value>
		[DataMember(Name = "specialized_region", EmitDefaultValue = false)]
		public string SpecializedRegion { get; set; }

		/// <summary>
		///     This field is populated if the ETF provides targeted exposure to a specific continent or country within that
		///     Continent
		/// </summary>
		/// <value>
		///     This field is populated if the ETF provides targeted exposure to a specific continent or country within that
		///     Continent
		/// </value>
		[DataMember(Name = "continent", EmitDefaultValue = false)]
		public string Continent { get; set; }

		/// <summary>
		///     For ETFs that are classified as &#39;Latin America&#39; in the &#39;continent&#39; field, this field provides
		///     further detail on the type of regional exposure
		/// </summary>
		/// <value>
		///     For ETFs that are classified as &#39;Latin America&#39; in the &#39;continent&#39; field, this field provides
		///     further detail on the type of regional exposure
		/// </value>
		[DataMember(Name = "latin_america_sub_group", EmitDefaultValue = false)]
		public string LatinAmericaSubGroup { get; set; }

		/// <summary>
		///     For ETFs that are classified as &#39;Europe&#39; in the &#39;continent&#39; field, this field provides further
		///     detail on the type of regional exposure
		/// </summary>
		/// <value>
		///     For ETFs that are classified as &#39;Europe&#39; in the &#39;continent&#39; field, this field provides further
		///     detail on the type of regional exposure
		/// </value>
		[DataMember(Name = "europe_sub_group", EmitDefaultValue = false)]
		public string EuropeSubGroup { get; set; }

		/// <summary>
		///     For ETFs that are classified as &#39;Asia&#39; in the &#39;continent&#39; field, this field provides further detail
		///     on the type of regional exposure
		/// </summary>
		/// <value>
		///     For ETFs that are classified as &#39;Asia&#39; in the &#39;continent&#39; field, this field provides further
		///     detail on the type of regional exposure
		/// </value>
		[DataMember(Name = "asia_sub_group", EmitDefaultValue = false)]
		public string AsiaSubGroup { get; set; }

		/// <summary>
		///     This field is populated if the ETF provides targeted exposure to a specific country
		/// </summary>
		/// <value>This field is populated if the ETF provides targeted exposure to a specific country</value>
		[DataMember(Name = "specific_country", EmitDefaultValue = false)]
		public string SpecificCountry { get; set; }

		/// <summary>
		///     For ETFs that are classified as &#39;China&#39; in the &#39;country&#39; field, this field provides further detail
		///     on the type of exposure in the underlying securities
		/// </summary>
		/// <value>
		///     For ETFs that are classified as &#39;China&#39; in the &#39;country&#39; field, this field provides further
		///     detail on the type of exposure in the underlying securities
		/// </value>
		[DataMember(Name = "china_listing_location", EmitDefaultValue = false)]
		public string ChinaListingLocation { get; set; }

		/// <summary>
		///     Takes the value of a US state if the ETF provides targeted exposure to the municipal bonds or equities of companies
		///     operating in a specific state in the US
		/// </summary>
		/// <value>
		///     Takes the value of a US state if the ETF provides targeted exposure to the municipal bonds or equities of
		///     companies operating in a specific state in the US
		/// </value>
		[DataMember(Name = "us_state", EmitDefaultValue = false)]
		public string UsState { get; set; }

		/// <summary>
		///     For ETFs that provide targeted real estate exposure, this field is populated if the ETF provides targeted exposure
		///     to a specific segment of the real estate market
		/// </summary>
		/// <value>
		///     For ETFs that provide targeted real estate exposure, this field is populated if the ETF provides targeted
		///     exposure to a specific segment of the real estate market
		/// </value>
		[DataMember(Name = "real_estate", EmitDefaultValue = false)]
		public string RealEstate { get; set; }

		/// <summary>
		///     For ETFs that track an underlying index, this field provides detail on the index weighting type
		/// </summary>
		/// <value>For ETFs that track an underlying index, this field provides detail on the index weighting type</value>
		[DataMember(Name = "index_weighting_scheme", EmitDefaultValue = false)]
		public string IndexWeightingScheme { get; set; }

		/// <summary>
		///     For ETFs that take the value &#39;Market Cap Weighted&#39; in the &#39;index_weighting_scheme&#39; field, this
		///     field provides detail on the market cap weighting type
		/// </summary>
		/// <value>
		///     For ETFs that take the value &#39;Market Cap Weighted&#39; in the &#39;index_weighting_scheme&#39; field, this
		///     field provides detail on the market cap weighting type
		/// </value>
		[DataMember(Name = "market_cap_weighting_type", EmitDefaultValue = false)]
		public string MarketCapWeightingType { get; set; }

		/// <summary>
		///     For ETFs that take the value ‘Fundamental Weighted’ in the &#39;index_weighting_scheme&#39; field, this field
		///     provides detail on the fundamental weighting methodology
		/// </summary>
		/// <value>
		///     For ETFs that take the value ‘Fundamental Weighted’ in the &#39;index_weighting_scheme&#39; field, this field
		///     provides detail on the fundamental weighting methodology
		/// </value>
		[DataMember(Name = "fundamental_weighting_type", EmitDefaultValue = false)]
		public string FundamentalWeightingType { get; set; }

		/// <summary>
		///     For ETFs that take the value &#39;Dividend Weighted&#39; in the &#39;index_weighting_scheme&#39; field, this field
		///     provides detail on the dividend weighting methodology
		/// </summary>
		/// <value>
		///     For ETFs that take the value &#39;Dividend Weighted&#39; in the &#39;index_weighting_scheme&#39; field, this
		///     field provides detail on the dividend weighting methodology
		/// </value>
		[DataMember(Name = "dividend_weighting_type", EmitDefaultValue = false)]
		public string DividendWeightingType { get; set; }

		/// <summary>
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Bonds&#39;, this field provides detail on the type of bonds held
		///     in the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Bonds&#39;, this field provides detail on the type of bonds
		///     held in the ETF
		/// </value>
		[DataMember(Name = "bond_type", EmitDefaultValue = false)]
		public string BondType { get; set; }

		/// <summary>
		///     For bond ETFs that take the value &#39;Treasury &amp; Government&#39; in &#39;bond_type&#39;, this field provides
		///     detail on the exposure
		/// </summary>
		/// <value>
		///     For bond ETFs that take the value &#39;Treasury &amp; Government&#39; in &#39;bond_type&#39;, this field
		///     provides detail on the exposure
		/// </value>
		[DataMember(Name = "government_bond_types", EmitDefaultValue = false)]
		public string GovernmentBondTypes { get; set; }

		/// <summary>
		///     For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this field provides additional detail
		///     on the geographic exposure
		/// </summary>
		/// <value>
		///     For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this field provides additional
		///     detail on the geographic exposure
		/// </value>
		[DataMember(Name = "municipal_bond_region", EmitDefaultValue = false)]
		public string MunicipalBondRegion { get; set; }

		/// <summary>
		///     For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this field identifies those ETFs that
		///     specifically provide exposure to Variable Rate Demand Obligations
		/// </summary>
		/// <value>
		///     For bond ETFs that take the value &#39;Municipal&#39; in &#39;bond_type&#39;, this field identifies those ETFs
		///     that specifically provide exposure to Variable Rate Demand Obligations
		/// </value>
		[DataMember(Name = "municipal_vrdo", EmitDefaultValue = false)]
		public bool? MunicipalVrdo { get; set; }

		/// <summary>
		///     For bond ETFs that take the value &#39;Mortgage&#39; in &#39;bond_type&#39;, this field provides additional detail
		///     on the type of underlying securities
		/// </summary>
		/// <value>
		///     For bond ETFs that take the value &#39;Mortgage&#39; in &#39;bond_type&#39;, this field provides additional
		///     detail on the type of underlying securities
		/// </value>
		[DataMember(Name = "mortgage_bond_types", EmitDefaultValue = false)]
		public string MortgageBondTypes { get; set; }

		/// <summary>
		///     For all US bond ETFs, this field provides additional detail on the tax treatment of the underlying securities
		/// </summary>
		/// <value>For all US bond ETFs, this field provides additional detail on the tax treatment of the underlying securities</value>
		[DataMember(Name = "bond_tax_status", EmitDefaultValue = false)]
		public string BondTaxStatus { get; set; }

		/// <summary>
		///     For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to securities of a specific
		///     credit quality range
		/// </summary>
		/// <value>
		///     For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to securities of a
		///     specific credit quality range
		/// </value>
		[DataMember(Name = "credit_quality", EmitDefaultValue = false)]
		public string CreditQuality { get; set; }

		/// <summary>
		///     For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to securities of a specific
		///     maturity range
		/// </summary>
		/// <value>
		///     For all bond ETFs, this field helps to identify if the ETF provides targeted exposure to securities of a
		///     specific maturity range
		/// </value>
		[DataMember(Name = "average_maturity", EmitDefaultValue = false)]
		public string AverageMaturity { get; set; }

		/// <summary>
		///     For all bond ETFs that take the value &#39;Specific Maturity Year&#39; in the &#39;average_maturity&#39; field,
		///     this field specifies the calendar year
		/// </summary>
		/// <value>
		///     For all bond ETFs that take the value &#39;Specific Maturity Year&#39; in the &#39;average_maturity&#39; field,
		///     this field specifies the calendar year
		/// </value>
		[DataMember(Name = "specific_maturity_year", EmitDefaultValue = false)]
		public int? SpecificMaturityYear { get; set; }

		/// <summary>
		///     For all bond ETFs, this field provides additional detail on the currency denomination of the underlying securities
		/// </summary>
		/// <value>
		///     For all bond ETFs, this field provides additional detail on the currency denomination of the underlying
		///     securities
		/// </value>
		[DataMember(Name = "bond_currency_denomination", EmitDefaultValue = false)]
		public string BondCurrencyDenomination { get; set; }

		/// <summary>
		///     For bond ETFs, this field identifies those ETFs that specifically hold bonds in a laddered structure, where the
		///     bonds are scheduled to mature in an annual, sequential structure
		/// </summary>
		/// <value>
		///     For bond ETFs, this field identifies those ETFs that specifically hold bonds in a laddered structure, where the
		///     bonds are scheduled to mature in an annual, sequential structure
		/// </value>
		[DataMember(Name = "laddered", EmitDefaultValue = false)]
		public bool? Laddered { get; set; }

		/// <summary>
		///     For bond ETFs, this field identifies those ETFs that specifically hold zero coupon Treasury Bills
		/// </summary>
		/// <value>For bond ETFs, this field identifies those ETFs that specifically hold zero coupon Treasury Bills</value>
		[DataMember(Name = "zero_coupon", EmitDefaultValue = false)]
		public bool? ZeroCoupon { get; set; }

		/// <summary>
		///     For bond ETFs, this field identifies those ETFs that specifically hold floating rate bonds
		/// </summary>
		/// <value>For bond ETFs, this field identifies those ETFs that specifically hold floating rate bonds</value>
		[DataMember(Name = "floating_rate", EmitDefaultValue = false)]
		public bool? FloatingRate { get; set; }

		/// <summary>
		///     For municipal bond ETFs, this field identifies those ETFs that specifically hold Build America Bonds
		/// </summary>
		/// <value>For municipal bond ETFs, this field identifies those ETFs that specifically hold Build America Bonds</value>
		[DataMember(Name = "build_america_bonds", EmitDefaultValue = false)]
		public bool? BuildAmericaBonds { get; set; }

		/// <summary>
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Commodities&#39;, this field provides detail on the type of
		///     commodities held in the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Commodities&#39;, this field provides detail on the type of
		///     commodities held in the ETF
		/// </value>
		[DataMember(Name = "commodity_types", EmitDefaultValue = false)]
		public string CommodityTypes { get; set; }

		/// <summary>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Energy&#39;, this field provides detail on the type of energy
		///     exposure provided by the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Energy&#39;, this field provides detail on the type of energy
		///     exposure provided by the ETF
		/// </value>
		[DataMember(Name = "energy_type", EmitDefaultValue = false)]
		public string EnergyType { get; set; }

		/// <summary>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Agricultural&#39;, this field provides detail on the type of
		///     agricultural exposure provided by the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Agricultural&#39;, this field provides detail on the type of
		///     agricultural exposure provided by the ETF
		/// </value>
		[DataMember(Name = "agricultural_type", EmitDefaultValue = false)]
		public string AgriculturalType { get; set; }

		/// <summary>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Gold &amp; Metals&#39;, this field provides detail on the type of
		///     exposure provided by the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Gold &amp; Metals&#39;, this field provides detail on the type
		///     of exposure provided by the ETF
		/// </value>
		[DataMember(Name = "metal_type", EmitDefaultValue = false)]
		public string MetalType { get; set; }

		/// <summary>
		///     This field is populated if the ETF provides inverse or leveraged exposure
		/// </summary>
		/// <value>This field is populated if the ETF provides inverse or leveraged exposure</value>
		[DataMember(Name = "inverse_leveraged", EmitDefaultValue = false)]
		public string InverseLeveraged { get; set; }

		/// <summary>
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Target Date / MultiAsset&#39;, this field provides detail on the
		///     type of commodities held in the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;asset_class_type&#39; is &#39;Target Date / MultiAsset&#39;, this field provides detail on
		///     the type of commodities held in the ETF
		/// </value>
		[DataMember(Name = "target_date_multi_asset_type", EmitDefaultValue = false)]
		public string TargetDateMultiAssetType { get; set; }

		/// <summary>
		///     This field is populated if the ETF’s strategy involves hedging currency exposure
		/// </summary>
		/// <value>This field is populated if the ETF’s strategy involves hedging currency exposure</value>
		[DataMember(Name = "currency_hedged", EmitDefaultValue = false)]
		public bool? CurrencyHedged { get; set; }

		/// <summary>
		///     This field is populated if the ETF’s strategy involves providing exposure to the movements of a currency or
		///     involves hedging currency exposure
		/// </summary>
		/// <value>
		///     This field is populated if the ETF’s strategy involves providing exposure to the movements of a currency or
		///     involves hedging currency exposure
		/// </value>
		[DataMember(Name = "currency_pair", EmitDefaultValue = false)]
		public string CurrencyPair { get; set; }

		/// <summary>
		///     This field is populated if the ETF’s strategy involves providing exposure to a specific social or environmental
		///     theme
		/// </summary>
		/// <value>
		///     This field is populated if the ETF’s strategy involves providing exposure to a specific social or environmental
		///     theme
		/// </value>
		[DataMember(Name = "social_environmental_type", EmitDefaultValue = false)]
		public string SocialEnvironmentalType { get; set; }

		/// <summary>
		///     This field is populated if the ETF has a value of &#39;Clean Energy&#39; in the &#39;social_environmental_type&#39;
		///     field.
		/// </summary>
		/// <value>
		///     This field is populated if the ETF has a value of &#39;Clean Energy&#39; in the &#39;social_environmental_type
		///     &#39; field.
		/// </value>
		[DataMember(Name = "clean_energy_type", EmitDefaultValue = false)]
		public string CleanEnergyType { get; set; }

		/// <summary>
		///     This field is populated if the ETF has an intended investment objective of holding dividend-oriented stocks as
		///     stated in the prospectus
		/// </summary>
		/// <value>
		///     This field is populated if the ETF has an intended investment objective of holding dividend-oriented stocks as
		///     stated in the prospectus
		/// </value>
		[DataMember(Name = "dividend_type", EmitDefaultValue = false)]
		public string DividendType { get; set; }

		/// <summary>
		///     This field is populated if the ETF has a value of &#39;Dividend – Regular Payors&#39; in the &#39;dividend_type
		///     &#39; field
		/// </summary>
		/// <value>
		///     This field is populated if the ETF has a value of &#39;Dividend – Regular Payors&#39; in the &#39;dividend_type
		///     &#39; field
		/// </value>
		[DataMember(Name = "regular_dividend_payor_type", EmitDefaultValue = false)]
		public string RegularDividendPayorType { get; set; }

		/// <summary>
		///     If true, the ETF’s investment objective explicitly specifies that it holds MLPs as an intended part of its
		///     investment strategy
		/// </summary>
		/// <value>
		///     If true, the ETF’s investment objective explicitly specifies that it holds MLPs as an intended part of its
		///     investment strategy
		/// </value>
		[DataMember(Name = "holds_ml_ps", EmitDefaultValue = false)]
		public bool? HoldsMlPs { get; set; }

		/// <summary>
		///     If true, the ETF’s investment objective explicitly specifies that it holds preferred stock as an intended part of
		///     its investment strategy
		/// </summary>
		/// <value>
		///     If true, the ETF’s investment objective explicitly specifies that it holds preferred stock as an intended part
		///     of its investment strategy
		/// </value>
		[DataMember(Name = "holds_preferred_stock", EmitDefaultValue = false)]
		public bool? HoldsPreferredStock { get; set; }

		/// <summary>
		///     IF true, if the ETF’s investment objective explicitly specifies that it holds closed end funds as an intended part
		///     of its investment strategy
		/// </summary>
		/// <value>
		///     IF true, if the ETF’s investment objective explicitly specifies that it holds closed end funds as an intended
		///     part of its investment strategy
		/// </value>
		[DataMember(Name = "holds_closed_end_funds", EmitDefaultValue = false)]
		public bool? HoldsClosedEndFunds { get; set; }

		/// <summary>
		///     This field is populated if the ETF has either an index-linked or active strategy that is based on a proprietary
		///     quantitative strategy
		/// </summary>
		/// <value>
		///     This field is populated if the ETF has either an index-linked or active strategy that is based on a proprietary
		///     quantitative strategy
		/// </value>
		[DataMember(Name = "quant_strategies_type", EmitDefaultValue = false)]
		public string QuantStrategiesType { get; set; }

		/// <summary>
		///     For ETFs where &#39;quant_strategies_type&#39; is &#39;Other Quant Model&#39;, this field provides the name of the
		///     specific proprietary quant model used as the underlying strategy for the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;quant_strategies_type&#39; is &#39;Other Quant Model&#39;, this field provides the name of
		///     the specific proprietary quant model used as the underlying strategy for the ETF
		/// </value>
		[DataMember(Name = "other_quant_models", EmitDefaultValue = false)]
		public string OtherQuantModels { get; set; }

		/// <summary>
		///     For ETFs where &#39;other_asset_types&#39; is &#39;Hedge Fund Replication&#39;, this field provides detail on the
		///     type of hedge fund replication strategy
		/// </summary>
		/// <value>
		///     For ETFs where &#39;other_asset_types&#39; is &#39;Hedge Fund Replication&#39;, this field provides detail on
		///     the type of hedge fund replication strategy
		/// </value>
		[DataMember(Name = "hedge_fund_type", EmitDefaultValue = false)]
		public string HedgeFundType { get; set; }

		/// <summary>
		///     This field is populated if the ETF holds either listed or over-the-counter derivatives in its portfolio
		/// </summary>
		/// <value>This field is populated if the ETF holds either listed or over-the-counter derivatives in its portfolio</value>
		[DataMember(Name = "derivatives_based", EmitDefaultValue = false)]
		public string DerivativesBased { get; set; }

		/// <summary>
		///     If true, he ETF’s investment objective explicitly specifies that it holds American Depositary Receipts (ADRs) as an
		///     intended part of its investment strategy
		/// </summary>
		/// <value>
		///     If true, he ETF’s investment objective explicitly specifies that it holds American Depositary Receipts (ADRs) as
		///     an intended part of its investment strategy
		/// </value>
		[DataMember(Name = "holds_ad_rs", EmitDefaultValue = false)]
		public bool? HoldsAdRs { get; set; }

		/// <summary>
		///     This field identifies whether an ETF is index linked or active
		/// </summary>
		/// <value>This field identifies whether an ETF is index linked or active</value>
		[DataMember(Name = "index_linked", EmitDefaultValue = false)]
		public string IndexLinked { get; set; }

		/// <summary>
		///     This field is populated if the ETF has short exposure in any of its holdings e.g. in a long/short or inverse ETF
		/// </summary>
		/// <value>This field is populated if the ETF has short exposure in any of its holdings e.g. in a long/short or inverse ETF</value>
		[DataMember(Name = "includes_short_exposure", EmitDefaultValue = false)]
		public bool? IncludesShortExposure { get; set; }

		/// <summary>
		///     This field identifies the name of the underlying index tracked by the ETF, if applicable
		/// </summary>
		/// <value>This field identifies the name of the underlying index tracked by the ETF, if applicable</value>
		[DataMember(Name = "index_name", EmitDefaultValue = false)]
		public string IndexName { get; set; }

		/// <summary>
		///     This field identifies the name of the parent index, which represents the broader universe from which the index
		///     underlying the ETF is created, if applicable
		/// </summary>
		/// <value>
		///     This field identifies the name of the parent index, which represents the broader universe from which the index
		///     underlying the ETF is created, if applicable
		/// </value>
		[DataMember(Name = "parent_index", EmitDefaultValue = false)]
		public string ParentIndex { get; set; }

		/// <summary>
		///     This field identifies the index family to which the index underlying the ETF belongs. The index family is
		///     represented as categorized by the index provider
		/// </summary>
		/// <value>
		///     This field identifies the index family to which the index underlying the ETF belongs. The index family is
		///     represented as categorized by the index provider
		/// </value>
		[DataMember(Name = "index_family", EmitDefaultValue = false)]
		public string IndexFamily { get; set; }

		/// <summary>
		///     This field identifies the broader index family to which the index underlying the ETF belongs. The broader index
		///     family is represented as categorized by the index provider
		/// </summary>
		/// <value>
		///     This field identifies the broader index family to which the index underlying the ETF belongs. The broader index
		///     family is represented as categorized by the index provider
		/// </value>
		[DataMember(Name = "broader_index_family", EmitDefaultValue = false)]
		public string BroaderIndexFamily { get; set; }

		/// <summary>
		///     This field identifies the Index provider for the index underlying the ETF, if applicable
		/// </summary>
		/// <value>This field identifies the Index provider for the index underlying the ETF, if applicable</value>
		[DataMember(Name = "index_provider", EmitDefaultValue = false)]
		public string IndexProvider { get; set; }

		/// <summary>
		///     This field identifies the fund family to which the ETF belongs, as categorized by the ETF Sponsor
		/// </summary>
		/// <value>This field identifies the fund family to which the ETF belongs, as categorized by the ETF Sponsor</value>
		[DataMember(Name = "fund_family", EmitDefaultValue = false)]
		public string FundFamily { get; set; }

		/// <summary>
		///     This field identifies the OpenFIGI ticker for the Index underlying the ETF
		/// </summary>
		/// <value>This field identifies the OpenFIGI ticker for the Index underlying the ETF</value>
		[DataMember(Name = "index_ticker", EmitDefaultValue = false)]
		public string IndexTicker { get; set; }

		/// <summary>
		///     If the product is an Exchange Traded Note (ETN), this field identifies the issuing bank
		/// </summary>
		/// <value>If the product is an Exchange Traded Note (ETN), this field identifies the issuing bank</value>
		[DataMember(Name = "etn_issuing_bank", EmitDefaultValue = false)]
		public string EtnIssuingBank { get; set; }

		/// <summary>
		///     If the product is an ETN, this field identifies the maturity date for the ETN
		/// </summary>
		/// <value>If the product is an ETN, this field identifies the maturity date for the ETN</value>
		[DataMember(Name = "etn_maturity_date", EmitDefaultValue = false)]
		
		public DateTime? EtnMaturityDate { get; set; }

		/// <summary>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Livestock&#39;, this field provides detail on the type of livestock
		///     exposure provided by the ETF
		/// </summary>
		/// <value>
		///     For ETFs where &#39;commodity_type&#39; is &#39;Livestock&#39;, this field provides detail on the type of
		///     livestock exposure provided by the ETF
		/// </value>
		[DataMember(Name = "livestock", EmitDefaultValue = false)]
		public string Livestock { get; set; }

		/// <summary>
		///     If the product holds futures contracts, this field identifies those products where the roll strategy is dynamic
		///     (rather than entirely rules based), so as to minimize roll costs
		/// </summary>
		/// <value>
		///     If the product holds futures contracts, this field identifies those products where the roll strategy is dynamic
		///     (rather than entirely rules based), so as to minimize roll costs
		/// </value>
		[DataMember(Name = "dynamic_futures_roll", EmitDefaultValue = false)]
		public bool? DynamicFuturesRoll { get; set; }

		/// <summary>
		///     This field provides the First Bridge code for each Index provider, corresponding to the index underlying the ETF if
		///     applicable
		/// </summary>
		/// <value>
		///     This field provides the First Bridge code for each Index provider, corresponding to the index underlying the ETF
		///     if applicable
		/// </value>
		[DataMember(Name = "index_provider_code", EmitDefaultValue = false)]
		public string IndexProviderCode { get; set; }

		/// <summary>
		///     This categorization is created for those users who want every ETF to be ‘forced’ into a single bucket, so that the
		///     assets for all categories will always sum to the total market
		/// </summary>
		/// <value>
		///     This categorization is created for those users who want every ETF to be ‘forced’ into a single bucket, so that
		///     the assets for all categories will always sum to the total market
		/// </value>
		[DataMember(Name = "single_category_designation", EmitDefaultValue = false)]
		public string SingleCategoryDesignation { get; set; }

		/// <summary>
		///     The list of countries where the ETF is legally registered for sale. This may differ from where the ETF is domiciled
		///     or traded, particularly in Europe
		/// </summary>
		/// <value>
		///     The list of countries where the ETF is legally registered for sale. This may differ from where the ETF is
		///     domiciled or traded, particularly in Europe
		/// </value>
		[DataMember(Name = "registered_countries", EmitDefaultValue = false)]
		public string RegisteredCountries { get; set; }

		/// <summary>
		///     The name of the legal entity that issued the Exchange Traded Product (ETP)
		/// </summary>
		/// <value>The name of the legal entity that issued the Exchange Traded Product (ETP)</value>
		[DataMember(Name = "issuing_entity_country_code", EmitDefaultValue = false)]
		public string IssuingEntityCountryCode { get; set; }

		/// <summary>
		///     If true, the Exchange Traded Product (ETP) is Undertakings for the Collective Investment in Transferable Securities
		///     (UCITS) compliant
		/// </summary>
		/// <value>
		///     If true, the Exchange Traded Product (ETP) is Undertakings for the Collective Investment in Transferable
		///     Securities (UCITS) compliant
		/// </value>
		[DataMember(Name = "ucits", EmitDefaultValue = false)]
		public bool? Ucits { get; set; }

		/// <summary>
		///     The replication structure of the Exchange Traded Product (ETP)
		/// </summary>
		/// <value>The replication structure of the Exchange Traded Product (ETP)</value>
		[DataMember(Name = "replication_structure", EmitDefaultValue = false)]
		public string ReplicationStructure { get; set; }

		/// <summary>
		///     2 letter ISO country code for the country where the ETP is domiciled
		/// </summary>
		/// <value>2 letter ISO country code for the country where the ETP is domiciled</value>
		[DataMember(Name = "domicile", EmitDefaultValue = false)]
		public string Domicile { get; set; }

		/// <summary>
		///     Base currency of the Exchange Traded Product (ETP) in which the net asset value (NAV) is calculated. Reported using
		///     the 3-digit ISO currency code
		/// </summary>
		/// <value>
		///     Base currency of the Exchange Traded Product (ETP) in which the net asset value (NAV) is calculated. Reported
		///     using the 3-digit ISO currency code
		/// </value>
		[DataMember(Name = "base_currency", EmitDefaultValue = false)]
		public string BaseCurrency { get; set; }

		/// <summary>
		///     Listing currency of the Exchange Traded Product (ETP) in which it is traded. Reported using the 3-digit ISO
		///     currency code
		/// </summary>
		/// <value>
		///     Listing currency of the Exchange Traded Product (ETP) in which it is traded. Reported using the 3-digit ISO
		///     currency code
		/// </value>
		[DataMember(Name = "listing_currency", EmitDefaultValue = false)]
		public string ListingCurrency { get; set; }

		/// <summary>
		///     The date on which the Exchange Traded Product (ETP) or share class of the ETP is listed on a specific exchange
		/// </summary>
		/// <value>The date on which the Exchange Traded Product (ETP) or share class of the ETP is listed on a specific exchange</value>
		[DataMember(Name = "fund_listing_date", EmitDefaultValue = false)]
		
		public DateTime? FundListingDate { get; set; }

		/// <summary>
		///     2 letter ISO country code for the country where the Exchange Traded Product (ETP) is listed
		/// </summary>
		/// <value>2 letter ISO country code for the country where the Exchange Traded Product (ETP) is listed</value>
		[DataMember(Name = "listing_country_code", EmitDefaultValue = false)]
		public string ListingCountryCode { get; set; }

		/// <summary>
		///     The region in which this specific ETF is listed
		/// </summary>
		/// <value>The region in which this specific ETF is listed</value>
		[DataMember(Name = "listing_region", EmitDefaultValue = false)]
		public string ListingRegion { get; set; }

		/// <summary>
		///     This field identifies whether an ETF provides &#39;Traditional&#39; beta exposure or &#39;Smart&#39; beta exposure.
		///     ETFs that are active (i.e. non-indexed), leveraged / inverse or have a proprietary quant model (i.e. that don’t
		///     provide indexed exposure to a targeted factor) are classified separately
		/// </summary>
		/// <value>
		///     This field identifies whether an ETF provides &#39;Traditional&#39; beta exposure or &#39;Smart&#39; beta
		///     exposure. ETFs that are active (i.e. non-indexed), leveraged / inverse or have a proprietary quant model (i.e. that
		///     don’t provide indexed exposure to a targeted factor) are classified separately
		/// </value>
		[DataMember(Name = "smartvs_traditional_beta", EmitDefaultValue = false)]
		public string SmartvsTraditionalBeta { get; set; }

		/// <summary>
		///     This field provides further detail within the traditional and smart beta categories
		/// </summary>
		/// <value>This field provides further detail within the traditional and smart beta categories</value>
		[DataMember(Name = "smartvs_traditional_beta_level2", EmitDefaultValue = false)]
		public string SmartvsTraditionalBetaLevel2 { get; set; }

		/// <summary>
		///     Identifies if an Exchange Traded Fund (ETF) falls into a category that is specifically designed to provide a high
		///     yield or income
		/// </summary>
		/// <value>
		///     Identifies if an Exchange Traded Fund (ETF) falls into a category that is specifically designed to provide a
		///     high yield or income
		/// </value>
		[DataMember(Name = "income_category", EmitDefaultValue = false)]
		public string IncomeCategory { get; set; }

		/// <summary>
		///     Classifies Exchange Traded Products (ETPs) into very broad categories based on its legal structure
		/// </summary>
		/// <value>Classifies Exchange Traded Products (ETPs) into very broad categories based on its legal structure</value>
		[DataMember(Name = "etp_structure_type", EmitDefaultValue = false)]
		public string EtpStructureType { get; set; }

		/// <summary>
		///     Net assets in millions of dollars as of the most recent month end
		/// </summary>
		/// <value>Net assets in millions of dollars as of the most recent month end</value>
		[DataMember(Name = "month_end_assets", EmitDefaultValue = false)]
		public decimal? MonthEndAssets { get; set; }

		/// <summary>
		///     The percentage of positions turned over in the last 12 months
		/// </summary>
		/// <value>The percentage of positions turned over in the last 12 months</value>
		[DataMember(Name = "etf_portfolio_turnover", EmitDefaultValue = false)]
		public decimal? EtfPortfolioTurnover { get; set; }

		/// <summary>
		///     The FirstBridge unique identifier for the Exchange Traded Fund (ETF)
		/// </summary>
		/// <value>The FirstBridge unique identifier for the Exchange Traded Fund (ETF)</value>
		[DataMember(Name = "firstbridge_id", EmitDefaultValue = false)]
		public string FirstbridgeId { get; set; }

		/// <summary>
		///     The FirstBridge unique identifier of the parent Exchange Traded Fund (ETF), if applicable
		/// </summary>
		/// <value>The FirstBridge unique identifier of the parent Exchange Traded Fund (ETF), if applicable</value>
		[DataMember(Name = "firstbridge_parent_id", EmitDefaultValue = false)]
		public string FirstbridgeParentId { get; set; }

		/// <summary>
		///     The number of holdings for this Exchange Traded Fund (ETF)
		/// </summary>
		/// <value>The number of holdings for this Exchange Traded Fund (ETF)</value>
		[DataMember(Name = "number_of_holdings", EmitDefaultValue = false)]
		public int? NumberOfHoldings { get; set; }

		/// <summary>
		///     Returns true if ETF instances are equal
		/// </summary>
		/// <param name="input">Instance of ETF to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ETF input)
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
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					FigiTicker == input.FigiTicker ||
					FigiTicker != null &&
					FigiTicker.Equals(input.FigiTicker)
				) &&
				(
					Ric == input.Ric ||
					Ric != null &&
					Ric.Equals(input.Ric)
				) &&
				(
					Isin == input.Isin ||
					Isin != null &&
					Isin.Equals(input.Isin)
				) &&
				(
					Sedol == input.Sedol ||
					Sedol != null &&
					Sedol.Equals(input.Sedol)
				) &&
				(
					ExchangeMic == input.ExchangeMic ||
					ExchangeMic != null &&
					ExchangeMic.Equals(input.ExchangeMic)
				) &&
				(
					Sponsor == input.Sponsor ||
					Sponsor != null &&
					Sponsor.Equals(input.Sponsor)
				) &&
				(
					Type == input.Type ||
					Type != null &&
					Type.Equals(input.Type)
				) &&
				(
					Description == input.Description ||
					Description != null &&
					Description.Equals(input.Description)
				) &&
				(
					InceptionDate == input.InceptionDate ||
					InceptionDate != null &&
					InceptionDate.Equals(input.InceptionDate)
				) &&
				(
					DataChangeDate == input.DataChangeDate ||
					DataChangeDate != null &&
					DataChangeDate.Equals(input.DataChangeDate)
				) &&
				(
					CloseDate == input.CloseDate ||
					CloseDate != null &&
					CloseDate.Equals(input.CloseDate)
				) &&
				(
					IsLiveListed == input.IsLiveListed ||
					IsLiveListed != null &&
					IsLiveListed.Equals(input.IsLiveListed)
				) &&
				(
					LegalStructure == input.LegalStructure ||
					LegalStructure != null &&
					LegalStructure.Equals(input.LegalStructure)
				) &&
				(
					IntradayNavTicker == input.IntradayNavTicker ||
					IntradayNavTicker != null &&
					IntradayNavTicker.Equals(input.IntradayNavTicker)
				) &&
				(
					PrimaryTicker == input.PrimaryTicker ||
					PrimaryTicker != null &&
					PrimaryTicker.Equals(input.PrimaryTicker)
				) &&
				(
					PrimaryTickerCountryCode == input.PrimaryTickerCountryCode ||
					PrimaryTickerCountryCode != null &&
					PrimaryTickerCountryCode.Equals(input.PrimaryTickerCountryCode)
				) &&
				(
					PrimaryListingRegion == input.PrimaryListingRegion ||
					PrimaryListingRegion != null &&
					PrimaryListingRegion.Equals(input.PrimaryListingRegion)
				) &&
				(
					NetExpenseRatio == input.NetExpenseRatio ||
					NetExpenseRatio != null &&
					NetExpenseRatio.Equals(input.NetExpenseRatio)
				) &&
				(
					AssetClass == input.AssetClass ||
					AssetClass != null &&
					AssetClass.Equals(input.AssetClass)
				) &&
				(
					OtherAssetTypes == input.OtherAssetTypes ||
					OtherAssetTypes != null &&
					OtherAssetTypes.Equals(input.OtherAssetTypes)
				) &&
				(
					MarketCapRange == input.MarketCapRange ||
					MarketCapRange != null &&
					MarketCapRange.Equals(input.MarketCapRange)
				) &&
				(
					HoldsOnlyNyseStocks == input.HoldsOnlyNyseStocks ||
					HoldsOnlyNyseStocks != null &&
					HoldsOnlyNyseStocks.Equals(input.HoldsOnlyNyseStocks)
				) &&
				(
					HoldsOnlyNasdaqStocks == input.HoldsOnlyNasdaqStocks ||
					HoldsOnlyNasdaqStocks != null &&
					HoldsOnlyNasdaqStocks.Equals(input.HoldsOnlyNasdaqStocks)
				) &&
				(
					GrowthValueTilt == input.GrowthValueTilt ||
					GrowthValueTilt != null &&
					GrowthValueTilt.Equals(input.GrowthValueTilt)
				) &&
				(
					GrowthType == input.GrowthType ||
					GrowthType != null &&
					GrowthType.Equals(input.GrowthType)
				) &&
				(
					ValueType == input.ValueType ||
					ValueType != null &&
					ValueType.Equals(input.ValueType)
				) &&
				(
					Sector == input.Sector ||
					Sector != null &&
					Sector.Equals(input.Sector)
				) &&
				(
					Industry == input.Industry ||
					Industry != null &&
					Industry.Equals(input.Industry)
				) &&
				(
					SubIndustry == input.SubIndustry ||
					SubIndustry != null &&
					SubIndustry.Equals(input.SubIndustry)
				) &&
				(
					CrossSectorTheme == input.CrossSectorTheme ||
					CrossSectorTheme != null &&
					CrossSectorTheme.Equals(input.CrossSectorTheme)
				) &&
				(
					NaturalResourcesType == input.NaturalResourcesType ||
					NaturalResourcesType != null &&
					NaturalResourcesType.Equals(input.NaturalResourcesType)
				) &&
				(
					ExcludesFinancials == input.ExcludesFinancials ||
					ExcludesFinancials != null &&
					ExcludesFinancials.Equals(input.ExcludesFinancials)
				) &&
				(
					ExcludesTechnology == input.ExcludesTechnology ||
					ExcludesTechnology != null &&
					ExcludesTechnology.Equals(input.ExcludesTechnology)
				) &&
				(
					UsOrExcludesUs == input.UsOrExcludesUs ||
					UsOrExcludesUs != null &&
					UsOrExcludesUs.Equals(input.UsOrExcludesUs)
				) &&
				(
					DevelopedEmerging == input.DevelopedEmerging ||
					DevelopedEmerging != null &&
					DevelopedEmerging.Equals(input.DevelopedEmerging)
				) &&
				(
					SpecializedRegion == input.SpecializedRegion ||
					SpecializedRegion != null &&
					SpecializedRegion.Equals(input.SpecializedRegion)
				) &&
				(
					Continent == input.Continent ||
					Continent != null &&
					Continent.Equals(input.Continent)
				) &&
				(
					LatinAmericaSubGroup == input.LatinAmericaSubGroup ||
					LatinAmericaSubGroup != null &&
					LatinAmericaSubGroup.Equals(input.LatinAmericaSubGroup)
				) &&
				(
					EuropeSubGroup == input.EuropeSubGroup ||
					EuropeSubGroup != null &&
					EuropeSubGroup.Equals(input.EuropeSubGroup)
				) &&
				(
					AsiaSubGroup == input.AsiaSubGroup ||
					AsiaSubGroup != null &&
					AsiaSubGroup.Equals(input.AsiaSubGroup)
				) &&
				(
					SpecificCountry == input.SpecificCountry ||
					SpecificCountry != null &&
					SpecificCountry.Equals(input.SpecificCountry)
				) &&
				(
					ChinaListingLocation == input.ChinaListingLocation ||
					ChinaListingLocation != null &&
					ChinaListingLocation.Equals(input.ChinaListingLocation)
				) &&
				(
					UsState == input.UsState ||
					UsState != null &&
					UsState.Equals(input.UsState)
				) &&
				(
					RealEstate == input.RealEstate ||
					RealEstate != null &&
					RealEstate.Equals(input.RealEstate)
				) &&
				(
					IndexWeightingScheme == input.IndexWeightingScheme ||
					IndexWeightingScheme != null &&
					IndexWeightingScheme.Equals(input.IndexWeightingScheme)
				) &&
				(
					MarketCapWeightingType == input.MarketCapWeightingType ||
					MarketCapWeightingType != null &&
					MarketCapWeightingType.Equals(input.MarketCapWeightingType)
				) &&
				(
					FundamentalWeightingType == input.FundamentalWeightingType ||
					FundamentalWeightingType != null &&
					FundamentalWeightingType.Equals(input.FundamentalWeightingType)
				) &&
				(
					DividendWeightingType == input.DividendWeightingType ||
					DividendWeightingType != null &&
					DividendWeightingType.Equals(input.DividendWeightingType)
				) &&
				(
					BondType == input.BondType ||
					BondType != null &&
					BondType.Equals(input.BondType)
				) &&
				(
					GovernmentBondTypes == input.GovernmentBondTypes ||
					GovernmentBondTypes != null &&
					GovernmentBondTypes.Equals(input.GovernmentBondTypes)
				) &&
				(
					MunicipalBondRegion == input.MunicipalBondRegion ||
					MunicipalBondRegion != null &&
					MunicipalBondRegion.Equals(input.MunicipalBondRegion)
				) &&
				(
					MunicipalVrdo == input.MunicipalVrdo ||
					MunicipalVrdo != null &&
					MunicipalVrdo.Equals(input.MunicipalVrdo)
				) &&
				(
					MortgageBondTypes == input.MortgageBondTypes ||
					MortgageBondTypes != null &&
					MortgageBondTypes.Equals(input.MortgageBondTypes)
				) &&
				(
					BondTaxStatus == input.BondTaxStatus ||
					BondTaxStatus != null &&
					BondTaxStatus.Equals(input.BondTaxStatus)
				) &&
				(
					CreditQuality == input.CreditQuality ||
					CreditQuality != null &&
					CreditQuality.Equals(input.CreditQuality)
				) &&
				(
					AverageMaturity == input.AverageMaturity ||
					AverageMaturity != null &&
					AverageMaturity.Equals(input.AverageMaturity)
				) &&
				(
					SpecificMaturityYear == input.SpecificMaturityYear ||
					SpecificMaturityYear != null &&
					SpecificMaturityYear.Equals(input.SpecificMaturityYear)
				) &&
				(
					BondCurrencyDenomination == input.BondCurrencyDenomination ||
					BondCurrencyDenomination != null &&
					BondCurrencyDenomination.Equals(input.BondCurrencyDenomination)
				) &&
				(
					Laddered == input.Laddered ||
					Laddered != null &&
					Laddered.Equals(input.Laddered)
				) &&
				(
					ZeroCoupon == input.ZeroCoupon ||
					ZeroCoupon != null &&
					ZeroCoupon.Equals(input.ZeroCoupon)
				) &&
				(
					FloatingRate == input.FloatingRate ||
					FloatingRate != null &&
					FloatingRate.Equals(input.FloatingRate)
				) &&
				(
					BuildAmericaBonds == input.BuildAmericaBonds ||
					BuildAmericaBonds != null &&
					BuildAmericaBonds.Equals(input.BuildAmericaBonds)
				) &&
				(
					CommodityTypes == input.CommodityTypes ||
					CommodityTypes != null &&
					CommodityTypes.Equals(input.CommodityTypes)
				) &&
				(
					EnergyType == input.EnergyType ||
					EnergyType != null &&
					EnergyType.Equals(input.EnergyType)
				) &&
				(
					AgriculturalType == input.AgriculturalType ||
					AgriculturalType != null &&
					AgriculturalType.Equals(input.AgriculturalType)
				) &&
				(
					MetalType == input.MetalType ||
					MetalType != null &&
					MetalType.Equals(input.MetalType)
				) &&
				(
					InverseLeveraged == input.InverseLeveraged ||
					InverseLeveraged != null &&
					InverseLeveraged.Equals(input.InverseLeveraged)
				) &&
				(
					TargetDateMultiAssetType == input.TargetDateMultiAssetType ||
					TargetDateMultiAssetType != null &&
					TargetDateMultiAssetType.Equals(input.TargetDateMultiAssetType)
				) &&
				(
					CurrencyHedged == input.CurrencyHedged ||
					CurrencyHedged != null &&
					CurrencyHedged.Equals(input.CurrencyHedged)
				) &&
				(
					CurrencyPair == input.CurrencyPair ||
					CurrencyPair != null &&
					CurrencyPair.Equals(input.CurrencyPair)
				) &&
				(
					SocialEnvironmentalType == input.SocialEnvironmentalType ||
					SocialEnvironmentalType != null &&
					SocialEnvironmentalType.Equals(input.SocialEnvironmentalType)
				) &&
				(
					CleanEnergyType == input.CleanEnergyType ||
					CleanEnergyType != null &&
					CleanEnergyType.Equals(input.CleanEnergyType)
				) &&
				(
					DividendType == input.DividendType ||
					DividendType != null &&
					DividendType.Equals(input.DividendType)
				) &&
				(
					RegularDividendPayorType == input.RegularDividendPayorType ||
					RegularDividendPayorType != null &&
					RegularDividendPayorType.Equals(input.RegularDividendPayorType)
				) &&
				(
					HoldsMlPs == input.HoldsMlPs ||
					HoldsMlPs != null &&
					HoldsMlPs.Equals(input.HoldsMlPs)
				) &&
				(
					HoldsPreferredStock == input.HoldsPreferredStock ||
					HoldsPreferredStock != null &&
					HoldsPreferredStock.Equals(input.HoldsPreferredStock)
				) &&
				(
					HoldsClosedEndFunds == input.HoldsClosedEndFunds ||
					HoldsClosedEndFunds != null &&
					HoldsClosedEndFunds.Equals(input.HoldsClosedEndFunds)
				) &&
				(
					QuantStrategiesType == input.QuantStrategiesType ||
					QuantStrategiesType != null &&
					QuantStrategiesType.Equals(input.QuantStrategiesType)
				) &&
				(
					OtherQuantModels == input.OtherQuantModels ||
					OtherQuantModels != null &&
					OtherQuantModels.Equals(input.OtherQuantModels)
				) &&
				(
					HedgeFundType == input.HedgeFundType ||
					HedgeFundType != null &&
					HedgeFundType.Equals(input.HedgeFundType)
				) &&
				(
					DerivativesBased == input.DerivativesBased ||
					DerivativesBased != null &&
					DerivativesBased.Equals(input.DerivativesBased)
				) &&
				(
					HoldsAdRs == input.HoldsAdRs ||
					HoldsAdRs != null &&
					HoldsAdRs.Equals(input.HoldsAdRs)
				) &&
				(
					IndexLinked == input.IndexLinked ||
					IndexLinked != null &&
					IndexLinked.Equals(input.IndexLinked)
				) &&
				(
					IncludesShortExposure == input.IncludesShortExposure ||
					IncludesShortExposure != null &&
					IncludesShortExposure.Equals(input.IncludesShortExposure)
				) &&
				(
					IndexName == input.IndexName ||
					IndexName != null &&
					IndexName.Equals(input.IndexName)
				) &&
				(
					ParentIndex == input.ParentIndex ||
					ParentIndex != null &&
					ParentIndex.Equals(input.ParentIndex)
				) &&
				(
					IndexFamily == input.IndexFamily ||
					IndexFamily != null &&
					IndexFamily.Equals(input.IndexFamily)
				) &&
				(
					BroaderIndexFamily == input.BroaderIndexFamily ||
					BroaderIndexFamily != null &&
					BroaderIndexFamily.Equals(input.BroaderIndexFamily)
				) &&
				(
					IndexProvider == input.IndexProvider ||
					IndexProvider != null &&
					IndexProvider.Equals(input.IndexProvider)
				) &&
				(
					FundFamily == input.FundFamily ||
					FundFamily != null &&
					FundFamily.Equals(input.FundFamily)
				) &&
				(
					IndexTicker == input.IndexTicker ||
					IndexTicker != null &&
					IndexTicker.Equals(input.IndexTicker)
				) &&
				(
					EtnIssuingBank == input.EtnIssuingBank ||
					EtnIssuingBank != null &&
					EtnIssuingBank.Equals(input.EtnIssuingBank)
				) &&
				(
					EtnMaturityDate == input.EtnMaturityDate ||
					EtnMaturityDate != null &&
					EtnMaturityDate.Equals(input.EtnMaturityDate)
				) &&
				(
					Livestock == input.Livestock ||
					Livestock != null &&
					Livestock.Equals(input.Livestock)
				) &&
				(
					DynamicFuturesRoll == input.DynamicFuturesRoll ||
					DynamicFuturesRoll != null &&
					DynamicFuturesRoll.Equals(input.DynamicFuturesRoll)
				) &&
				(
					IndexProviderCode == input.IndexProviderCode ||
					IndexProviderCode != null &&
					IndexProviderCode.Equals(input.IndexProviderCode)
				) &&
				(
					SingleCategoryDesignation == input.SingleCategoryDesignation ||
					SingleCategoryDesignation != null &&
					SingleCategoryDesignation.Equals(input.SingleCategoryDesignation)
				) &&
				(
					RegisteredCountries == input.RegisteredCountries ||
					RegisteredCountries != null &&
					RegisteredCountries.Equals(input.RegisteredCountries)
				) &&
				(
					IssuingEntityCountryCode == input.IssuingEntityCountryCode ||
					IssuingEntityCountryCode != null &&
					IssuingEntityCountryCode.Equals(input.IssuingEntityCountryCode)
				) &&
				(
					Ucits == input.Ucits ||
					Ucits != null &&
					Ucits.Equals(input.Ucits)
				) &&
				(
					ReplicationStructure == input.ReplicationStructure ||
					ReplicationStructure != null &&
					ReplicationStructure.Equals(input.ReplicationStructure)
				) &&
				(
					Domicile == input.Domicile ||
					Domicile != null &&
					Domicile.Equals(input.Domicile)
				) &&
				(
					BaseCurrency == input.BaseCurrency ||
					BaseCurrency != null &&
					BaseCurrency.Equals(input.BaseCurrency)
				) &&
				(
					ListingCurrency == input.ListingCurrency ||
					ListingCurrency != null &&
					ListingCurrency.Equals(input.ListingCurrency)
				) &&
				(
					FundListingDate == input.FundListingDate ||
					FundListingDate != null &&
					FundListingDate.Equals(input.FundListingDate)
				) &&
				(
					ListingCountryCode == input.ListingCountryCode ||
					ListingCountryCode != null &&
					ListingCountryCode.Equals(input.ListingCountryCode)
				) &&
				(
					ListingRegion == input.ListingRegion ||
					ListingRegion != null &&
					ListingRegion.Equals(input.ListingRegion)
				) &&
				(
					SmartvsTraditionalBeta == input.SmartvsTraditionalBeta ||
					SmartvsTraditionalBeta != null &&
					SmartvsTraditionalBeta.Equals(input.SmartvsTraditionalBeta)
				) &&
				(
					SmartvsTraditionalBetaLevel2 == input.SmartvsTraditionalBetaLevel2 ||
					SmartvsTraditionalBetaLevel2 != null &&
					SmartvsTraditionalBetaLevel2.Equals(input.SmartvsTraditionalBetaLevel2)
				) &&
				(
					IncomeCategory == input.IncomeCategory ||
					IncomeCategory != null &&
					IncomeCategory.Equals(input.IncomeCategory)
				) &&
				(
					EtpStructureType == input.EtpStructureType ||
					EtpStructureType != null &&
					EtpStructureType.Equals(input.EtpStructureType)
				) &&
				(
					MonthEndAssets == input.MonthEndAssets ||
					MonthEndAssets != null &&
					MonthEndAssets.Equals(input.MonthEndAssets)
				) &&
				(
					EtfPortfolioTurnover == input.EtfPortfolioTurnover ||
					EtfPortfolioTurnover != null &&
					EtfPortfolioTurnover.Equals(input.EtfPortfolioTurnover)
				) &&
				(
					FirstbridgeId == input.FirstbridgeId ||
					FirstbridgeId != null &&
					FirstbridgeId.Equals(input.FirstbridgeId)
				) &&
				(
					FirstbridgeParentId == input.FirstbridgeParentId ||
					FirstbridgeParentId != null &&
					FirstbridgeParentId.Equals(input.FirstbridgeParentId)
				) &&
				(
					NumberOfHoldings == input.NumberOfHoldings ||
					NumberOfHoldings != null &&
					NumberOfHoldings.Equals(input.NumberOfHoldings)
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
			sb.Append("class ETF {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  FigiTicker: ").Append(FigiTicker).Append("\n");
			sb.Append("  Ric: ").Append(Ric).Append("\n");
			sb.Append("  Isin: ").Append(Isin).Append("\n");
			sb.Append("  Sedol: ").Append(Sedol).Append("\n");
			sb.Append("  ExchangeMic: ").Append(ExchangeMic).Append("\n");
			sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  InceptionDate: ").Append(InceptionDate).Append("\n");
			sb.Append("  DataChangeDate: ").Append(DataChangeDate).Append("\n");
			sb.Append("  CloseDate: ").Append(CloseDate).Append("\n");
			sb.Append("  IsLiveListed: ").Append(IsLiveListed).Append("\n");
			sb.Append("  LegalStructure: ").Append(LegalStructure).Append("\n");
			sb.Append("  IntradayNavTicker: ").Append(IntradayNavTicker).Append("\n");
			sb.Append("  PrimaryTicker: ").Append(PrimaryTicker).Append("\n");
			sb.Append("  PrimaryTickerCountryCode: ").Append(PrimaryTickerCountryCode).Append("\n");
			sb.Append("  PrimaryListingRegion: ").Append(PrimaryListingRegion).Append("\n");
			sb.Append("  NetExpenseRatio: ").Append(NetExpenseRatio).Append("\n");
			sb.Append("  AssetClass: ").Append(AssetClass).Append("\n");
			sb.Append("  OtherAssetTypes: ").Append(OtherAssetTypes).Append("\n");
			sb.Append("  MarketCapRange: ").Append(MarketCapRange).Append("\n");
			sb.Append("  HoldsOnlyNyseStocks: ").Append(HoldsOnlyNyseStocks).Append("\n");
			sb.Append("  HoldsOnlyNasdaqStocks: ").Append(HoldsOnlyNasdaqStocks).Append("\n");
			sb.Append("  GrowthValueTilt: ").Append(GrowthValueTilt).Append("\n");
			sb.Append("  GrowthType: ").Append(GrowthType).Append("\n");
			sb.Append("  ValueType: ").Append(ValueType).Append("\n");
			sb.Append("  Sector: ").Append(Sector).Append("\n");
			sb.Append("  Industry: ").Append(Industry).Append("\n");
			sb.Append("  SubIndustry: ").Append(SubIndustry).Append("\n");
			sb.Append("  CrossSectorTheme: ").Append(CrossSectorTheme).Append("\n");
			sb.Append("  NaturalResourcesType: ").Append(NaturalResourcesType).Append("\n");
			sb.Append("  ExcludesFinancials: ").Append(ExcludesFinancials).Append("\n");
			sb.Append("  ExcludesTechnology: ").Append(ExcludesTechnology).Append("\n");
			sb.Append("  UsOrExcludesUs: ").Append(UsOrExcludesUs).Append("\n");
			sb.Append("  DevelopedEmerging: ").Append(DevelopedEmerging).Append("\n");
			sb.Append("  SpecializedRegion: ").Append(SpecializedRegion).Append("\n");
			sb.Append("  Continent: ").Append(Continent).Append("\n");
			sb.Append("  LatinAmericaSubGroup: ").Append(LatinAmericaSubGroup).Append("\n");
			sb.Append("  EuropeSubGroup: ").Append(EuropeSubGroup).Append("\n");
			sb.Append("  AsiaSubGroup: ").Append(AsiaSubGroup).Append("\n");
			sb.Append("  SpecificCountry: ").Append(SpecificCountry).Append("\n");
			sb.Append("  ChinaListingLocation: ").Append(ChinaListingLocation).Append("\n");
			sb.Append("  UsState: ").Append(UsState).Append("\n");
			sb.Append("  RealEstate: ").Append(RealEstate).Append("\n");
			sb.Append("  IndexWeightingScheme: ").Append(IndexWeightingScheme).Append("\n");
			sb.Append("  MarketCapWeightingType: ").Append(MarketCapWeightingType).Append("\n");
			sb.Append("  FundamentalWeightingType: ").Append(FundamentalWeightingType).Append("\n");
			sb.Append("  DividendWeightingType: ").Append(DividendWeightingType).Append("\n");
			sb.Append("  BondType: ").Append(BondType).Append("\n");
			sb.Append("  GovernmentBondTypes: ").Append(GovernmentBondTypes).Append("\n");
			sb.Append("  MunicipalBondRegion: ").Append(MunicipalBondRegion).Append("\n");
			sb.Append("  MunicipalVrdo: ").Append(MunicipalVrdo).Append("\n");
			sb.Append("  MortgageBondTypes: ").Append(MortgageBondTypes).Append("\n");
			sb.Append("  BondTaxStatus: ").Append(BondTaxStatus).Append("\n");
			sb.Append("  CreditQuality: ").Append(CreditQuality).Append("\n");
			sb.Append("  AverageMaturity: ").Append(AverageMaturity).Append("\n");
			sb.Append("  SpecificMaturityYear: ").Append(SpecificMaturityYear).Append("\n");
			sb.Append("  BondCurrencyDenomination: ").Append(BondCurrencyDenomination).Append("\n");
			sb.Append("  Laddered: ").Append(Laddered).Append("\n");
			sb.Append("  ZeroCoupon: ").Append(ZeroCoupon).Append("\n");
			sb.Append("  FloatingRate: ").Append(FloatingRate).Append("\n");
			sb.Append("  BuildAmericaBonds: ").Append(BuildAmericaBonds).Append("\n");
			sb.Append("  CommodityTypes: ").Append(CommodityTypes).Append("\n");
			sb.Append("  EnergyType: ").Append(EnergyType).Append("\n");
			sb.Append("  AgriculturalType: ").Append(AgriculturalType).Append("\n");
			sb.Append("  MetalType: ").Append(MetalType).Append("\n");
			sb.Append("  InverseLeveraged: ").Append(InverseLeveraged).Append("\n");
			sb.Append("  TargetDateMultiAssetType: ").Append(TargetDateMultiAssetType).Append("\n");
			sb.Append("  CurrencyHedged: ").Append(CurrencyHedged).Append("\n");
			sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
			sb.Append("  SocialEnvironmentalType: ").Append(SocialEnvironmentalType).Append("\n");
			sb.Append("  CleanEnergyType: ").Append(CleanEnergyType).Append("\n");
			sb.Append("  DividendType: ").Append(DividendType).Append("\n");
			sb.Append("  RegularDividendPayorType: ").Append(RegularDividendPayorType).Append("\n");
			sb.Append("  HoldsMlPs: ").Append(HoldsMlPs).Append("\n");
			sb.Append("  HoldsPreferredStock: ").Append(HoldsPreferredStock).Append("\n");
			sb.Append("  HoldsClosedEndFunds: ").Append(HoldsClosedEndFunds).Append("\n");
			sb.Append("  QuantStrategiesType: ").Append(QuantStrategiesType).Append("\n");
			sb.Append("  OtherQuantModels: ").Append(OtherQuantModels).Append("\n");
			sb.Append("  HedgeFundType: ").Append(HedgeFundType).Append("\n");
			sb.Append("  DerivativesBased: ").Append(DerivativesBased).Append("\n");
			sb.Append("  HoldsAdRs: ").Append(HoldsAdRs).Append("\n");
			sb.Append("  IndexLinked: ").Append(IndexLinked).Append("\n");
			sb.Append("  IncludesShortExposure: ").Append(IncludesShortExposure).Append("\n");
			sb.Append("  IndexName: ").Append(IndexName).Append("\n");
			sb.Append("  ParentIndex: ").Append(ParentIndex).Append("\n");
			sb.Append("  IndexFamily: ").Append(IndexFamily).Append("\n");
			sb.Append("  BroaderIndexFamily: ").Append(BroaderIndexFamily).Append("\n");
			sb.Append("  IndexProvider: ").Append(IndexProvider).Append("\n");
			sb.Append("  FundFamily: ").Append(FundFamily).Append("\n");
			sb.Append("  IndexTicker: ").Append(IndexTicker).Append("\n");
			sb.Append("  EtnIssuingBank: ").Append(EtnIssuingBank).Append("\n");
			sb.Append("  EtnMaturityDate: ").Append(EtnMaturityDate).Append("\n");
			sb.Append("  Livestock: ").Append(Livestock).Append("\n");
			sb.Append("  DynamicFuturesRoll: ").Append(DynamicFuturesRoll).Append("\n");
			sb.Append("  IndexProviderCode: ").Append(IndexProviderCode).Append("\n");
			sb.Append("  SingleCategoryDesignation: ").Append(SingleCategoryDesignation).Append("\n");
			sb.Append("  RegisteredCountries: ").Append(RegisteredCountries).Append("\n");
			sb.Append("  IssuingEntityCountryCode: ").Append(IssuingEntityCountryCode).Append("\n");
			sb.Append("  Ucits: ").Append(Ucits).Append("\n");
			sb.Append("  ReplicationStructure: ").Append(ReplicationStructure).Append("\n");
			sb.Append("  Domicile: ").Append(Domicile).Append("\n");
			sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
			sb.Append("  ListingCurrency: ").Append(ListingCurrency).Append("\n");
			sb.Append("  FundListingDate: ").Append(FundListingDate).Append("\n");
			sb.Append("  ListingCountryCode: ").Append(ListingCountryCode).Append("\n");
			sb.Append("  ListingRegion: ").Append(ListingRegion).Append("\n");
			sb.Append("  SmartvsTraditionalBeta: ").Append(SmartvsTraditionalBeta).Append("\n");
			sb.Append("  SmartvsTraditionalBetaLevel2: ").Append(SmartvsTraditionalBetaLevel2).Append("\n");
			sb.Append("  IncomeCategory: ").Append(IncomeCategory).Append("\n");
			sb.Append("  EtpStructureType: ").Append(EtpStructureType).Append("\n");
			sb.Append("  MonthEndAssets: ").Append(MonthEndAssets).Append("\n");
			sb.Append("  EtfPortfolioTurnover: ").Append(EtfPortfolioTurnover).Append("\n");
			sb.Append("  FirstbridgeId: ").Append(FirstbridgeId).Append("\n");
			sb.Append("  FirstbridgeParentId: ").Append(FirstbridgeParentId).Append("\n");
			sb.Append("  NumberOfHoldings: ").Append(NumberOfHoldings).Append("\n");
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
			return Equals(input as ETF);
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
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (FigiTicker != null)
					hashCode = hashCode * 59 + FigiTicker.GetHashCode();
				if (Ric != null)
					hashCode = hashCode * 59 + Ric.GetHashCode();
				if (Isin != null)
					hashCode = hashCode * 59 + Isin.GetHashCode();
				if (Sedol != null)
					hashCode = hashCode * 59 + Sedol.GetHashCode();
				if (ExchangeMic != null)
					hashCode = hashCode * 59 + ExchangeMic.GetHashCode();
				if (Sponsor != null)
					hashCode = hashCode * 59 + Sponsor.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				if (Description != null)
					hashCode = hashCode * 59 + Description.GetHashCode();
				if (InceptionDate != null)
					hashCode = hashCode * 59 + InceptionDate.GetHashCode();
				if (DataChangeDate != null)
					hashCode = hashCode * 59 + DataChangeDate.GetHashCode();
				if (CloseDate != null)
					hashCode = hashCode * 59 + CloseDate.GetHashCode();
				if (IsLiveListed != null)
					hashCode = hashCode * 59 + IsLiveListed.GetHashCode();
				if (LegalStructure != null)
					hashCode = hashCode * 59 + LegalStructure.GetHashCode();
				if (IntradayNavTicker != null)
					hashCode = hashCode * 59 + IntradayNavTicker.GetHashCode();
				if (PrimaryTicker != null)
					hashCode = hashCode * 59 + PrimaryTicker.GetHashCode();
				if (PrimaryTickerCountryCode != null)
					hashCode = hashCode * 59 + PrimaryTickerCountryCode.GetHashCode();
				if (PrimaryListingRegion != null)
					hashCode = hashCode * 59 + PrimaryListingRegion.GetHashCode();
				if (NetExpenseRatio != null)
					hashCode = hashCode * 59 + NetExpenseRatio.GetHashCode();
				if (AssetClass != null)
					hashCode = hashCode * 59 + AssetClass.GetHashCode();
				if (OtherAssetTypes != null)
					hashCode = hashCode * 59 + OtherAssetTypes.GetHashCode();
				if (MarketCapRange != null)
					hashCode = hashCode * 59 + MarketCapRange.GetHashCode();
				if (HoldsOnlyNyseStocks != null)
					hashCode = hashCode * 59 + HoldsOnlyNyseStocks.GetHashCode();
				if (HoldsOnlyNasdaqStocks != null)
					hashCode = hashCode * 59 + HoldsOnlyNasdaqStocks.GetHashCode();
				if (GrowthValueTilt != null)
					hashCode = hashCode * 59 + GrowthValueTilt.GetHashCode();
				if (GrowthType != null)
					hashCode = hashCode * 59 + GrowthType.GetHashCode();
				if (ValueType != null)
					hashCode = hashCode * 59 + ValueType.GetHashCode();
				if (Sector != null)
					hashCode = hashCode * 59 + Sector.GetHashCode();
				if (Industry != null)
					hashCode = hashCode * 59 + Industry.GetHashCode();
				if (SubIndustry != null)
					hashCode = hashCode * 59 + SubIndustry.GetHashCode();
				if (CrossSectorTheme != null)
					hashCode = hashCode * 59 + CrossSectorTheme.GetHashCode();
				if (NaturalResourcesType != null)
					hashCode = hashCode * 59 + NaturalResourcesType.GetHashCode();
				if (ExcludesFinancials != null)
					hashCode = hashCode * 59 + ExcludesFinancials.GetHashCode();
				if (ExcludesTechnology != null)
					hashCode = hashCode * 59 + ExcludesTechnology.GetHashCode();
				if (UsOrExcludesUs != null)
					hashCode = hashCode * 59 + UsOrExcludesUs.GetHashCode();
				if (DevelopedEmerging != null)
					hashCode = hashCode * 59 + DevelopedEmerging.GetHashCode();
				if (SpecializedRegion != null)
					hashCode = hashCode * 59 + SpecializedRegion.GetHashCode();
				if (Continent != null)
					hashCode = hashCode * 59 + Continent.GetHashCode();
				if (LatinAmericaSubGroup != null)
					hashCode = hashCode * 59 + LatinAmericaSubGroup.GetHashCode();
				if (EuropeSubGroup != null)
					hashCode = hashCode * 59 + EuropeSubGroup.GetHashCode();
				if (AsiaSubGroup != null)
					hashCode = hashCode * 59 + AsiaSubGroup.GetHashCode();
				if (SpecificCountry != null)
					hashCode = hashCode * 59 + SpecificCountry.GetHashCode();
				if (ChinaListingLocation != null)
					hashCode = hashCode * 59 + ChinaListingLocation.GetHashCode();
				if (UsState != null)
					hashCode = hashCode * 59 + UsState.GetHashCode();
				if (RealEstate != null)
					hashCode = hashCode * 59 + RealEstate.GetHashCode();
				if (IndexWeightingScheme != null)
					hashCode = hashCode * 59 + IndexWeightingScheme.GetHashCode();
				if (MarketCapWeightingType != null)
					hashCode = hashCode * 59 + MarketCapWeightingType.GetHashCode();
				if (FundamentalWeightingType != null)
					hashCode = hashCode * 59 + FundamentalWeightingType.GetHashCode();
				if (DividendWeightingType != null)
					hashCode = hashCode * 59 + DividendWeightingType.GetHashCode();
				if (BondType != null)
					hashCode = hashCode * 59 + BondType.GetHashCode();
				if (GovernmentBondTypes != null)
					hashCode = hashCode * 59 + GovernmentBondTypes.GetHashCode();
				if (MunicipalBondRegion != null)
					hashCode = hashCode * 59 + MunicipalBondRegion.GetHashCode();
				if (MunicipalVrdo != null)
					hashCode = hashCode * 59 + MunicipalVrdo.GetHashCode();
				if (MortgageBondTypes != null)
					hashCode = hashCode * 59 + MortgageBondTypes.GetHashCode();
				if (BondTaxStatus != null)
					hashCode = hashCode * 59 + BondTaxStatus.GetHashCode();
				if (CreditQuality != null)
					hashCode = hashCode * 59 + CreditQuality.GetHashCode();
				if (AverageMaturity != null)
					hashCode = hashCode * 59 + AverageMaturity.GetHashCode();
				if (SpecificMaturityYear != null)
					hashCode = hashCode * 59 + SpecificMaturityYear.GetHashCode();
				if (BondCurrencyDenomination != null)
					hashCode = hashCode * 59 + BondCurrencyDenomination.GetHashCode();
				if (Laddered != null)
					hashCode = hashCode * 59 + Laddered.GetHashCode();
				if (ZeroCoupon != null)
					hashCode = hashCode * 59 + ZeroCoupon.GetHashCode();
				if (FloatingRate != null)
					hashCode = hashCode * 59 + FloatingRate.GetHashCode();
				if (BuildAmericaBonds != null)
					hashCode = hashCode * 59 + BuildAmericaBonds.GetHashCode();
				if (CommodityTypes != null)
					hashCode = hashCode * 59 + CommodityTypes.GetHashCode();
				if (EnergyType != null)
					hashCode = hashCode * 59 + EnergyType.GetHashCode();
				if (AgriculturalType != null)
					hashCode = hashCode * 59 + AgriculturalType.GetHashCode();
				if (MetalType != null)
					hashCode = hashCode * 59 + MetalType.GetHashCode();
				if (InverseLeveraged != null)
					hashCode = hashCode * 59 + InverseLeveraged.GetHashCode();
				if (TargetDateMultiAssetType != null)
					hashCode = hashCode * 59 + TargetDateMultiAssetType.GetHashCode();
				if (CurrencyHedged != null)
					hashCode = hashCode * 59 + CurrencyHedged.GetHashCode();
				if (CurrencyPair != null)
					hashCode = hashCode * 59 + CurrencyPair.GetHashCode();
				if (SocialEnvironmentalType != null)
					hashCode = hashCode * 59 + SocialEnvironmentalType.GetHashCode();
				if (CleanEnergyType != null)
					hashCode = hashCode * 59 + CleanEnergyType.GetHashCode();
				if (DividendType != null)
					hashCode = hashCode * 59 + DividendType.GetHashCode();
				if (RegularDividendPayorType != null)
					hashCode = hashCode * 59 + RegularDividendPayorType.GetHashCode();
				if (HoldsMlPs != null)
					hashCode = hashCode * 59 + HoldsMlPs.GetHashCode();
				if (HoldsPreferredStock != null)
					hashCode = hashCode * 59 + HoldsPreferredStock.GetHashCode();
				if (HoldsClosedEndFunds != null)
					hashCode = hashCode * 59 + HoldsClosedEndFunds.GetHashCode();
				if (QuantStrategiesType != null)
					hashCode = hashCode * 59 + QuantStrategiesType.GetHashCode();
				if (OtherQuantModels != null)
					hashCode = hashCode * 59 + OtherQuantModels.GetHashCode();
				if (HedgeFundType != null)
					hashCode = hashCode * 59 + HedgeFundType.GetHashCode();
				if (DerivativesBased != null)
					hashCode = hashCode * 59 + DerivativesBased.GetHashCode();
				if (HoldsAdRs != null)
					hashCode = hashCode * 59 + HoldsAdRs.GetHashCode();
				if (IndexLinked != null)
					hashCode = hashCode * 59 + IndexLinked.GetHashCode();
				if (IncludesShortExposure != null)
					hashCode = hashCode * 59 + IncludesShortExposure.GetHashCode();
				if (IndexName != null)
					hashCode = hashCode * 59 + IndexName.GetHashCode();
				if (ParentIndex != null)
					hashCode = hashCode * 59 + ParentIndex.GetHashCode();
				if (IndexFamily != null)
					hashCode = hashCode * 59 + IndexFamily.GetHashCode();
				if (BroaderIndexFamily != null)
					hashCode = hashCode * 59 + BroaderIndexFamily.GetHashCode();
				if (IndexProvider != null)
					hashCode = hashCode * 59 + IndexProvider.GetHashCode();
				if (FundFamily != null)
					hashCode = hashCode * 59 + FundFamily.GetHashCode();
				if (IndexTicker != null)
					hashCode = hashCode * 59 + IndexTicker.GetHashCode();
				if (EtnIssuingBank != null)
					hashCode = hashCode * 59 + EtnIssuingBank.GetHashCode();
				if (EtnMaturityDate != null)
					hashCode = hashCode * 59 + EtnMaturityDate.GetHashCode();
				if (Livestock != null)
					hashCode = hashCode * 59 + Livestock.GetHashCode();
				if (DynamicFuturesRoll != null)
					hashCode = hashCode * 59 + DynamicFuturesRoll.GetHashCode();
				if (IndexProviderCode != null)
					hashCode = hashCode * 59 + IndexProviderCode.GetHashCode();
				if (SingleCategoryDesignation != null)
					hashCode = hashCode * 59 + SingleCategoryDesignation.GetHashCode();
				if (RegisteredCountries != null)
					hashCode = hashCode * 59 + RegisteredCountries.GetHashCode();
				if (IssuingEntityCountryCode != null)
					hashCode = hashCode * 59 + IssuingEntityCountryCode.GetHashCode();
				if (Ucits != null)
					hashCode = hashCode * 59 + Ucits.GetHashCode();
				if (ReplicationStructure != null)
					hashCode = hashCode * 59 + ReplicationStructure.GetHashCode();
				if (Domicile != null)
					hashCode = hashCode * 59 + Domicile.GetHashCode();
				if (BaseCurrency != null)
					hashCode = hashCode * 59 + BaseCurrency.GetHashCode();
				if (ListingCurrency != null)
					hashCode = hashCode * 59 + ListingCurrency.GetHashCode();
				if (FundListingDate != null)
					hashCode = hashCode * 59 + FundListingDate.GetHashCode();
				if (ListingCountryCode != null)
					hashCode = hashCode * 59 + ListingCountryCode.GetHashCode();
				if (ListingRegion != null)
					hashCode = hashCode * 59 + ListingRegion.GetHashCode();
				if (SmartvsTraditionalBeta != null)
					hashCode = hashCode * 59 + SmartvsTraditionalBeta.GetHashCode();
				if (SmartvsTraditionalBetaLevel2 != null)
					hashCode = hashCode * 59 + SmartvsTraditionalBetaLevel2.GetHashCode();
				if (IncomeCategory != null)
					hashCode = hashCode * 59 + IncomeCategory.GetHashCode();
				if (EtpStructureType != null)
					hashCode = hashCode * 59 + EtpStructureType.GetHashCode();
				if (MonthEndAssets != null)
					hashCode = hashCode * 59 + MonthEndAssets.GetHashCode();
				if (EtfPortfolioTurnover != null)
					hashCode = hashCode * 59 + EtfPortfolioTurnover.GetHashCode();
				if (FirstbridgeId != null)
					hashCode = hashCode * 59 + FirstbridgeId.GetHashCode();
				if (FirstbridgeParentId != null)
					hashCode = hashCode * 59 + FirstbridgeParentId.GetHashCode();
				if (NumberOfHoldings != null)
					hashCode = hashCode * 59 + NumberOfHoldings.GetHashCode();
				return hashCode;
			}
		}
	}
}