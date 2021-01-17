using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IFundamentalsApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     Fundamental by ID
		/// </summary>
		/// <remarks>
		///     Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>Fundamental</returns>
		Fundamental GetFundamentalById(string id);

		/// <summary>
		///     Fundamental by ID
		/// </summary>
		/// <remarks>
		///     Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>ApiResponse of Fundamental</returns>
		ApiResponse<Fundamental> GetFundamentalByIdWithHttpInfo(string id);

		/// <summary>
		///     Reported Financials
		/// </summary>
		/// <remarks>
		///     Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponseReportedFinancials</returns>
		ApiResponseReportedFinancials GetFundamentalReportedFinancials(string id);

		/// <summary>
		///     Reported Financials
		/// </summary>
		/// <remarks>
		///     Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponse of ApiResponseReportedFinancials</returns>
		ApiResponse<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsWithHttpInfo(string id);

		/// <summary>
		///     Standardized Financials
		/// </summary>
		/// <remarks>
		///     Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure
		///     the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized
		///     financials are to facilitate comparability across a single company’s fundamentals and across all companies&#39;
		///     fundamentals.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponseStandardizedFinancials</returns>
		ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials(string id);

		/// <summary>
		///     Standardized Financials
		/// </summary>
		/// <remarks>
		///     Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure
		///     the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized
		///     financials are to facilitate comparability across a single company’s fundamentals and across all companies&#39;
		///     fundamentals.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponse of ApiResponseStandardizedFinancials</returns>
		ApiResponse<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsWithHttpInfo(string id);

		/// <summary>
		///     Lookup Fundamental
		/// </summary>
		/// <remarks>
		///     Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>Fundamental</returns>
		Fundamental LookupFundamental(string identifier, string statementCode, int? fiscalYear, string fiscalPeriod);

		/// <summary>
		///     Lookup Fundamental
		/// </summary>
		/// <remarks>
		///     Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>ApiResponse of Fundamental</returns>
		ApiResponse<Fundamental> LookupFundamentalWithHttpInfo(string identifier, string statementCode, int? fiscalYear,
			string fiscalPeriod);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     Fundamental by ID
		/// </summary>
		/// <remarks>
		///     Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>Task of Fundamental</returns>
		Task<Fundamental> GetFundamentalByIdAsync(string id);

		/// <summary>
		///     Fundamental by ID
		/// </summary>
		/// <remarks>
		///     Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>Task of ApiResponse (Fundamental)</returns>
		Task<ApiResponse<Fundamental>> GetFundamentalByIdAsyncWithHttpInfo(string id);

		/// <summary>
		///     Reported Financials
		/// </summary>
		/// <remarks>
		///     Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponseReportedFinancials</returns>
		Task<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsAsync(string id);

		/// <summary>
		///     Reported Financials
		/// </summary>
		/// <remarks>
		///     Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponse (ApiResponseReportedFinancials)</returns>
		Task<ApiResponse<ApiResponseReportedFinancials>> GetFundamentalReportedFinancialsAsyncWithHttpInfo(string id);

		/// <summary>
		///     Standardized Financials
		/// </summary>
		/// <remarks>
		///     Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure
		///     the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized
		///     financials are to facilitate comparability across a single company’s fundamentals and across all companies&#39;
		///     fundamentals.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponseStandardizedFinancials</returns>
		Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsAsync(string id);

		/// <summary>
		///     Standardized Financials
		/// </summary>
		/// <remarks>
		///     Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure
		///     the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized
		///     financials are to facilitate comparability across a single company’s fundamentals and across all companies&#39;
		///     fundamentals.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponse (ApiResponseStandardizedFinancials)</returns>
		Task<ApiResponse<ApiResponseStandardizedFinancials>>
			GetFundamentalStandardizedFinancialsAsyncWithHttpInfo(string id);

		/// <summary>
		///     Lookup Fundamental
		/// </summary>
		/// <remarks>
		///     Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>Task of Fundamental</returns>
		Task<Fundamental> LookupFundamentalAsync(string identifier, string statementCode, int? fiscalYear,
			string fiscalPeriod);

		/// <summary>
		///     Lookup Fundamental
		/// </summary>
		/// <remarks>
		///     Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>Task of ApiResponse (Fundamental)</returns>
		Task<ApiResponse<Fundamental>> LookupFundamentalAsyncWithHttpInfo(string identifier, string statementCode,
			int? fiscalYear, string fiscalPeriod);

		#endregion Asynchronous Operations
	}
}