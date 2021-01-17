using System;
using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IZacksApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     Zacks Analyst Ratings
		/// </summary>
		/// <remarks>
		///     Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe.
		///     Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksAnalystRatings</returns>
		ApiResponseZacksAnalystRatings GetZacksAnalystRatings(string identifier = null, DateTime? startDate = null,
			DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null,
			int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null,
			int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null,
			int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null,
			int? totalLess = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Analyst Ratings
		/// </summary>
		/// <remarks>
		///     Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe.
		///     Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksAnalystRatings</returns>
		ApiResponse<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsWithHttpInfo(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null,
			int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null,
			int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null,
			int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null,
			int? totalLess = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks EPS Estimates
		/// </summary>
		/// <remarks>
		///     Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksEPSEstimates</returns>
		ApiResponseZacksEPSEstimates GetZacksEpsEstimates(string identifier = null, DateTime? startDate = null,
			DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null,
			string calendarPeriod = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks EPS Estimates
		/// </summary>
		/// <remarks>
		///     Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksEPSEstimates</returns>
		ApiResponse<ApiResponseZacksEPSEstimates> GetZacksEpsEstimatesWithHttpInfo(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null,
			int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks EPS Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks EPS growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksEPSGrowthRates</returns>
		ApiResponseZacksEPSGrowthRates GetZacksEpsGrowthRates(string company = null, string industryGroupName = null,
			string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks EPS Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks EPS growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksEPSGrowthRates</returns>
		ApiResponse<ApiResponseZacksEPSGrowthRates> GetZacksEpsGrowthRatesWithHttpInfo(string company = null,
			string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks EPS Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks eps surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksEPSSurprises</returns>
		ApiResponseZacksEPSSurprises GetZacksEpsSurprises(DateTime? startDate = null, DateTime? endDate = null,
			decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null,
			decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null,
			decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null,
			decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null,
			decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null,
			decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks EPS Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks eps surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksEPSSurprises</returns>
		ApiResponse<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesWithHttpInfo(DateTime? startDate = null,
			DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null,
			decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null,
			decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null,
			decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null,
			decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null,
			decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks ETF holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksETFHoldings</returns>
		ApiResponseZacksETFHoldings GetZacksEtfHoldings(string etfTicker = null, string holdingSymbol = null,
			decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks ETF holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksETFHoldings</returns>
		ApiResponse<ApiResponseZacksETFHoldings> GetZacksEtfHoldingsWithHttpInfo(string etfTicker = null,
			string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Companies
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding companies data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksInstitutionalHoldingCompanies</returns>
		ApiResponseZacksInstitutionalHoldingCompanies GetZacksInstitutionalHoldingCompanies(string ticker = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Companies
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding companies data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingCompanies</returns>
		ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies> GetZacksInstitutionalHoldingCompaniesWithHttpInfo(
			string ticker = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Owners
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding owners data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksInstitutionalHoldingOwners</returns>
		ApiResponseZacksInstitutionalHoldingOwners GetZacksInstitutionalHoldingOwners(string cik = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Owners
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding owners data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingOwners</returns>
		ApiResponse<ApiResponseZacksInstitutionalHoldingOwners> GetZacksInstitutionalHoldingOwnersWithHttpInfo(
			string cik = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksInstitutionalHoldings</returns>
		ApiResponseZacksInstitutionalHoldings GetZacksInstitutionalHoldings(string ticker = null,
			string ownerCik = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldings</returns>
		ApiResponse<ApiResponseZacksInstitutionalHoldings> GetZacksInstitutionalHoldingsWithHttpInfo(
			string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Long Term Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks long term growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksLongTermGrowthRates</returns>
		ApiResponseZacksLongTermGrowthRates GetZacksLongTermGrowthRates(string identifier = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks Long Term Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks long term growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksLongTermGrowthRates</returns>
		ApiResponse<ApiResponseZacksLongTermGrowthRates> GetZacksLongTermGrowthRatesWithHttpInfo(
			string identifier = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Sales Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks sales surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksSalesSurprises</returns>
		ApiResponseZacksSalesSurprises GetZacksSalesSurprises(DateTime? startDate = null, DateTime? endDate = null,
			decimal? salesActualGreater = null, decimal? salesActualLess = null,
			decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null,
			decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null,
			decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null,
			decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null,
			decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks Sales Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks sales surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksSalesSurprises</returns>
		ApiResponse<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesWithHttpInfo(DateTime? startDate = null,
			DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null,
			decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null,
			decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null,
			decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null,
			decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null,
			decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks Target Price Consensuses
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks target price consensus data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksTargetPriceConsensuses</returns>
		ApiResponseZacksTargetPriceConsensuses GetZacksTargetPriceConsensuses(string identifier = null,
			string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Target Price Consensuses
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks target price consensus data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksTargetPriceConsensuses</returns>
		ApiResponse<ApiResponseZacksTargetPriceConsensuses> GetZacksTargetPriceConsensusesWithHttpInfo(
			string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     Zacks Analyst Ratings
		/// </summary>
		/// <remarks>
		///     Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe.
		///     Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksAnalystRatings</returns>
		Task<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsAsync(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null,
			int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null,
			int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null,
			int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null,
			int? totalLess = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Analyst Ratings
		/// </summary>
		/// <remarks>
		///     Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe.
		///     Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksAnalystRatings)</returns>
		Task<ApiResponse<ApiResponseZacksAnalystRatings>> GetZacksAnalystRatingsAsyncWithHttpInfo(
			string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null,
			decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null,
			int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null,
			int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null,
			int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks EPS Estimates
		/// </summary>
		/// <remarks>
		///     Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksEPSEstimates</returns>
		Task<ApiResponseZacksEPSEstimates> GetZacksEpsEstimatesAsync(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null,
			int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks EPS Estimates
		/// </summary>
		/// <remarks>
		///     Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksEPSEstimates)</returns>
		Task<ApiResponse<ApiResponseZacksEPSEstimates>> GetZacksEpsEstimatesAsyncWithHttpInfo(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null,
			int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks EPS Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks EPS growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksEPSGrowthRates</returns>
		Task<ApiResponseZacksEPSGrowthRates> GetZacksEpsGrowthRatesAsync(string company = null,
			string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks EPS Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks EPS growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksEPSGrowthRates)</returns>
		Task<ApiResponse<ApiResponseZacksEPSGrowthRates>> GetZacksEpsGrowthRatesAsyncWithHttpInfo(string company = null,
			string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks EPS Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks eps surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksEPSSurprises</returns>
		Task<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesAsync(DateTime? startDate = null,
			DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null,
			decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null,
			decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null,
			decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null,
			decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null,
			decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks EPS Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks eps surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksEPSSurprises)</returns>
		Task<ApiResponse<ApiResponseZacksEPSSurprises>> GetZacksEpsSurprisesAsyncWithHttpInfo(
			DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null,
			decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null,
			decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null,
			decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null,
			decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null,
			decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks ETF holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksETFHoldings</returns>
		Task<ApiResponseZacksETFHoldings> GetZacksEtfHoldingsAsync(string etfTicker = null, string holdingSymbol = null,
			decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks ETF holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksETFHoldings)</returns>
		Task<ApiResponse<ApiResponseZacksETFHoldings>> GetZacksEtfHoldingsAsyncWithHttpInfo(string etfTicker = null,
			string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Companies
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding companies data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksInstitutionalHoldingCompanies</returns>
		Task<ApiResponseZacksInstitutionalHoldingCompanies> GetZacksInstitutionalHoldingCompaniesAsync(
			string ticker = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Companies
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding companies data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingCompanies)</returns>
		Task<ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>>
			GetZacksInstitutionalHoldingCompaniesAsyncWithHttpInfo(string ticker = null, int? pageSize = null,
				string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Owners
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding owners data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksInstitutionalHoldingOwners</returns>
		Task<ApiResponseZacksInstitutionalHoldingOwners> GetZacksInstitutionalHoldingOwnersAsync(string cik = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holding Owners
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holding owners data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingOwners)</returns>
		Task<ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>>
			GetZacksInstitutionalHoldingOwnersAsyncWithHttpInfo(string cik = null, int? pageSize = null,
				string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksInstitutionalHoldings</returns>
		Task<ApiResponseZacksInstitutionalHoldings> GetZacksInstitutionalHoldingsAsync(string ticker = null,
			string ownerCik = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Institutional Holdings
		/// </summary>
		/// <remarks>
		///     Returns Zacks institutional holdings data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldings)</returns>
		Task<ApiResponse<ApiResponseZacksInstitutionalHoldings>> GetZacksInstitutionalHoldingsAsyncWithHttpInfo(
			string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Long Term Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks long term growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksLongTermGrowthRates</returns>
		Task<ApiResponseZacksLongTermGrowthRates> GetZacksLongTermGrowthRatesAsync(string identifier = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Long Term Growth Rates
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks long term growth rates
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksLongTermGrowthRates)</returns>
		Task<ApiResponse<ApiResponseZacksLongTermGrowthRates>> GetZacksLongTermGrowthRatesAsyncWithHttpInfo(
			string identifier = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Sales Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks sales surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksSalesSurprises</returns>
		Task<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesAsync(DateTime? startDate = null,
			DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null,
			decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null,
			decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null,
			decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null,
			decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null,
			decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Zacks Sales Surprises
		/// </summary>
		/// <remarks>
		///     Returns Zacks sales surprise data for all Securities.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksSalesSurprises)</returns>
		Task<ApiResponse<ApiResponseZacksSalesSurprises>> GetZacksSalesSurprisesAsyncWithHttpInfo(
			DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null,
			decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null,
			decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null,
			decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null,
			decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null,
			decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null,
			decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Target Price Consensuses
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks target price consensus data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksTargetPriceConsensuses</returns>
		Task<ApiResponseZacksTargetPriceConsensuses> GetZacksTargetPriceConsensusesAsync(string identifier = null,
			string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Zacks Target Price Consensuses
		/// </summary>
		/// <remarks>
		///     Returns the latest Zacks target price consensus data
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksTargetPriceConsensuses)</returns>
		Task<ApiResponse<ApiResponseZacksTargetPriceConsensuses>> GetZacksTargetPriceConsensusesAsyncWithHttpInfo(
			string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null);

		#endregion Asynchronous Operations
	}
}