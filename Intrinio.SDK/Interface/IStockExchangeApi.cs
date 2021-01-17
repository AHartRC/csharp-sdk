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
	public interface IStockExchangeApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     All Stock Exchanges
		/// </summary>
		/// <remarks>
		///     Returns all Stock Exchanges matching the specified parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseStockExchanges</returns>
		ApiResponseStockExchanges GetAllStockExchanges(string city = null, string country = null,
			string countryCode = null, int? pageSize = null);

		/// <summary>
		///     All Stock Exchanges
		/// </summary>
		/// <remarks>
		///     Returns all Stock Exchanges matching the specified parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseStockExchanges</returns>
		ApiResponse<ApiResponseStockExchanges> GetAllStockExchangesWithHttpInfo(string city = null,
			string country = null, string countryCode = null, int? pageSize = null);

		/// <summary>
		///     Lookup Stock Exchange
		/// </summary>
		/// <remarks>
		///     Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>StockExchange</returns>
		StockExchange GetStockExchangeById(string identifier);

		/// <summary>
		///     Lookup Stock Exchange
		/// </summary>
		/// <remarks>
		///     Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>ApiResponse of StockExchange</returns>
		ApiResponse<StockExchange> GetStockExchangeByIdWithHttpInfo(string identifier);

		/// <summary>
		///     Stock Price Adjustments by Exchange
		/// </summary>
		/// <remarks>
		///     Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
		ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustments(string identifier,
			DateTime? date = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stock Price Adjustments by Exchange
		/// </summary>
		/// <remarks>
		///     Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
		ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsWithHttpInfo(
			string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;
		///     price_date&#x60; (or the latest date that prices are available)
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeStockPrices</returns>
		ApiResponseStockExchangeStockPrices GetStockExchangePrices(string identifier, DateTime? date = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;
		///     price_date&#x60; (or the latest date that prices are available)
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeStockPrices</returns>
		ApiResponse<ApiResponseStockExchangeStockPrices> GetStockExchangePricesWithHttpInfo(string identifier,
			DateTime? date = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Realtime Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeRealtimeStockPrices</returns>
		ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices(string identifier,
			string source = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Realtime Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeRealtimeStockPrices</returns>
		ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesWithHttpInfo(
			string identifier, string source = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Securities by Exchange
		/// </summary>
		/// <remarks>
		///     Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeSecurities</returns>
		ApiResponseStockExchangeSecurities GetStockExchangeSecurities(string identifier, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Securities by Exchange
		/// </summary>
		/// <remarks>
		///     Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeSecurities</returns>
		ApiResponse<ApiResponseStockExchangeSecurities> GetStockExchangeSecuritiesWithHttpInfo(string identifier,
			int? pageSize = null, string nextPage = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     All Stock Exchanges
		/// </summary>
		/// <remarks>
		///     Returns all Stock Exchanges matching the specified parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseStockExchanges</returns>
		Task<ApiResponseStockExchanges> GetAllStockExchangesAsync(string city = null, string country = null,
			string countryCode = null, int? pageSize = null);

		/// <summary>
		///     All Stock Exchanges
		/// </summary>
		/// <remarks>
		///     Returns all Stock Exchanges matching the specified parameters
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchanges)</returns>
		Task<ApiResponse<ApiResponseStockExchanges>> GetAllStockExchangesAsyncWithHttpInfo(string city = null,
			string country = null, string countryCode = null, int? pageSize = null);

		/// <summary>
		///     Lookup Stock Exchange
		/// </summary>
		/// <remarks>
		///     Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>Task of StockExchange</returns>
		Task<StockExchange> GetStockExchangeByIdAsync(string identifier);

		/// <summary>
		///     Lookup Stock Exchange
		/// </summary>
		/// <remarks>
		///     Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>Task of ApiResponse (StockExchange)</returns>
		Task<ApiResponse<StockExchange>> GetStockExchangeByIdAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Stock Price Adjustments by Exchange
		/// </summary>
		/// <remarks>
		///     Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
		Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsAsync(string identifier,
			DateTime? date = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stock Price Adjustments by Exchange
		/// </summary>
		/// <remarks>
		///     Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
		Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>>
			GetStockExchangePriceAdjustmentsAsyncWithHttpInfo(string identifier, DateTime? date = null,
				int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;
		///     price_date&#x60; (or the latest date that prices are available)
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeStockPrices</returns>
		Task<ApiResponseStockExchangeStockPrices> GetStockExchangePricesAsync(string identifier, DateTime? date = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;
		///     price_date&#x60; (or the latest date that prices are available)
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPrices)</returns>
		Task<ApiResponse<ApiResponseStockExchangeStockPrices>> GetStockExchangePricesAsyncWithHttpInfo(
			string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Realtime Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeRealtimeStockPrices</returns>
		Task<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesAsync(string identifier,
			string source = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Realtime Stock Prices by Exchange
		/// </summary>
		/// <remarks>
		///     Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeRealtimeStockPrices)</returns>
		Task<ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>> GetStockExchangeRealtimePricesAsyncWithHttpInfo(
			string identifier, string source = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Securities by Exchange
		/// </summary>
		/// <remarks>
		///     Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeSecurities</returns>
		Task<ApiResponseStockExchangeSecurities> GetStockExchangeSecuritiesAsync(string identifier,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Securities by Exchange
		/// </summary>
		/// <remarks>
		///     Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeSecurities)</returns>
		Task<ApiResponse<ApiResponseStockExchangeSecurities>> GetStockExchangeSecuritiesAsyncWithHttpInfo(
			string identifier, int? pageSize = null, string nextPage = null);

		#endregion Asynchronous Operations
	}
}