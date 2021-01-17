using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IETFsApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     All ETFs
		/// </summary>
		/// <remarks>
		///     Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseETFs</returns>
		ApiResponseETFs GetAllEtfs(string exchange = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All ETFs
		/// </summary>
		/// <remarks>
		///     Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseETFs</returns>
		ApiResponse<ApiResponseETFs> GetAllEtfsWithHttpInfo(string exchange = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Lookup ETF
		/// </summary>
		/// <remarks>
		///     Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ETF</returns>
		ETF GetEtf(string identifier);

		/// <summary>
		///     Lookup ETF
		/// </summary>
		/// <remarks>
		///     Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ApiResponse of ETF</returns>
		ApiResponse<ETF> GetEtfWithHttpInfo(string identifier);

		/// <summary>
		///     ETF Analytics
		/// </summary>
		/// <remarks>
		///     Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and 52 week low
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ETFAnalytics</returns>
		ETFAnalytics GetEtfAnalytics(string identifier);

		/// <summary>
		///     ETF Analytics
		/// </summary>
		/// <remarks>
		///     Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and 52 week low
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ApiResponse of ETFAnalytics</returns>
		ApiResponse<ETFAnalytics> GetEtfAnalyticsWithHttpInfo(string identifier);

		/// <summary>
		///     ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseETFHoldings</returns>
		ApiResponseETFHoldings GetEtfHoldings(string identifier, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseETFHoldings</returns>
		ApiResponse<ApiResponseETFHoldings> GetEtfHoldingsWithHttpInfo(string identifier, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Exchange Traded Fund (ETF) stats
		/// </summary>
		/// <remarks>
		///     Returns daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and
		///     volatility
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ETFStats</returns>
		ETFStats GetEtfStats(string identifier);

		/// <summary>
		///     Exchange Traded Fund (ETF) stats
		/// </summary>
		/// <remarks>
		///     Returns daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and
		///     volatility
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ApiResponse of ETFStats</returns>
		ApiResponse<ETFStats> GetEtfStatsWithHttpInfo(string identifier);

		/// <summary>
		///     Search ETFs
		/// </summary>
		/// <remarks>
		///     Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>ApiResponseETFs</returns>
		ApiResponseETFs SearchEtfs(string query);

		/// <summary>
		///     Search ETFs
		/// </summary>
		/// <remarks>
		///     Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>ApiResponse of ApiResponseETFs</returns>
		ApiResponse<ApiResponseETFs> SearchEtfsWithHttpInfo(string query);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     All ETFs
		/// </summary>
		/// <remarks>
		///     Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseETFs</returns>
		Task<ApiResponseETFs> GetAllEtfsAsync(string exchange = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All ETFs
		/// </summary>
		/// <remarks>
		///     Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
		Task<ApiResponse<ApiResponseETFs>> GetAllEtfsAsyncWithHttpInfo(string exchange = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Lookup ETF
		/// </summary>
		/// <remarks>
		///     Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ETF</returns>
		Task<ETF> GetEtfAsync(string identifier);

		/// <summary>
		///     Lookup ETF
		/// </summary>
		/// <remarks>
		///     Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (ETF)</returns>
		Task<ApiResponse<ETF>> GetEtfAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     ETF Analytics
		/// </summary>
		/// <remarks>
		///     Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and 52 week low
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ETFAnalytics</returns>
		Task<ETFAnalytics> GetEtfAnalyticsAsync(string identifier);

		/// <summary>
		///     ETF Analytics
		/// </summary>
		/// <remarks>
		///     Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and 52 week low
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (ETFAnalytics)</returns>
		Task<ApiResponse<ETFAnalytics>> GetEtfAnalyticsAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseETFHoldings</returns>
		Task<ApiResponseETFHoldings> GetEtfHoldingsAsync(string identifier, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     ETF Holdings
		/// </summary>
		/// <remarks>
		///     Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseETFHoldings)</returns>
		Task<ApiResponse<ApiResponseETFHoldings>> GetEtfHoldingsAsyncWithHttpInfo(string identifier,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Exchange Traded Fund (ETF) stats
		/// </summary>
		/// <remarks>
		///     Returns daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and
		///     volatility
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ETFStats</returns>
		Task<ETFStats> GetEtfStatsAsync(string identifier);

		/// <summary>
		///     Exchange Traded Fund (ETF) stats
		/// </summary>
		/// <remarks>
		///     Returns daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and
		///     volatility
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (ETFStats)</returns>
		Task<ApiResponse<ETFStats>> GetEtfStatsAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Search ETFs
		/// </summary>
		/// <remarks>
		///     Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>Task of ApiResponseETFs</returns>
		Task<ApiResponseETFs> SearchEtfsAsync(string query);

		/// <summary>
		///     Search ETFs
		/// </summary>
		/// <remarks>
		///     Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
		Task<ApiResponse<ApiResponseETFs>> SearchEtfsAsyncWithHttpInfo(string query);

		#endregion Asynchronous Operations
	}
}