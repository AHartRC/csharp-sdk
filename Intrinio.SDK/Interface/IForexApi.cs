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
	public interface IForexApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     Forex Currencies
		/// </summary>
		/// <remarks>
		///     Returns a list of forex currencies for which prices are available.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponseForexCurrencies</returns>
		ApiResponseForexCurrencies GetForexCurrencies();

		/// <summary>
		///     Forex Currencies
		/// </summary>
		/// <remarks>
		///     Returns a list of forex currencies for which prices are available.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of ApiResponseForexCurrencies</returns>
		ApiResponse<ApiResponseForexCurrencies> GetForexCurrenciesWithHttpInfo();

		/// <summary>
		///     Forex Currency Pairs
		/// </summary>
		/// <remarks>
		///     Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is
		///     used as the reference is called quote currency and the currency that is quoted in relation is called the base
		///     currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged
		///     for 0.88 British Pounds (quote currency).
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponseForexPairs</returns>
		ApiResponseForexPairs GetForexPairs();

		/// <summary>
		///     Forex Currency Pairs
		/// </summary>
		/// <remarks>
		///     Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is
		///     used as the reference is called quote currency and the currency that is quoted in relation is called the base
		///     currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged
		///     for 0.88 British Pounds (quote currency).
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of ApiResponseForexPairs</returns>
		ApiResponse<ApiResponseForexPairs> GetForexPairsWithHttpInfo();

		/// <summary>
		///     Forex Currency Prices
		/// </summary>
		/// <remarks>
		///     Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pair">The Forex Currency Pair code</param>
		/// <param name="timeframe">The time interval for the quotes</param>
		/// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
		/// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
		/// <param name="startTime">
		///     Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
		/// <param name="endTime">
		///     Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseForexPrices</returns>
		ApiResponseForexPrices GetForexPrices(string pair, string timeframe, string timezone = null,
			DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Forex Currency Prices
		/// </summary>
		/// <remarks>
		///     Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pair">The Forex Currency Pair code</param>
		/// <param name="timeframe">The time interval for the quotes</param>
		/// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
		/// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
		/// <param name="startTime">
		///     Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
		/// <param name="endTime">
		///     Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseForexPrices</returns>
		ApiResponse<ApiResponseForexPrices> GetForexPricesWithHttpInfo(string pair, string timeframe,
			string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null,
			string endTime = null, int? pageSize = null, string nextPage = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     Forex Currencies
		/// </summary>
		/// <remarks>
		///     Returns a list of forex currencies for which prices are available.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponseForexCurrencies</returns>
		Task<ApiResponseForexCurrencies> GetForexCurrenciesAsync();

		/// <summary>
		///     Forex Currencies
		/// </summary>
		/// <remarks>
		///     Returns a list of forex currencies for which prices are available.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (ApiResponseForexCurrencies)</returns>
		Task<ApiResponse<ApiResponseForexCurrencies>> GetForexCurrenciesAsyncWithHttpInfo();

		/// <summary>
		///     Forex Currency Pairs
		/// </summary>
		/// <remarks>
		///     Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is
		///     used as the reference is called quote currency and the currency that is quoted in relation is called the base
		///     currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged
		///     for 0.88 British Pounds (quote currency).
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponseForexPairs</returns>
		Task<ApiResponseForexPairs> GetForexPairsAsync();

		/// <summary>
		///     Forex Currency Pairs
		/// </summary>
		/// <remarks>
		///     Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is
		///     used as the reference is called quote currency and the currency that is quoted in relation is called the base
		///     currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged
		///     for 0.88 British Pounds (quote currency).
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (ApiResponseForexPairs)</returns>
		Task<ApiResponse<ApiResponseForexPairs>> GetForexPairsAsyncWithHttpInfo();

		/// <summary>
		///     Forex Currency Prices
		/// </summary>
		/// <remarks>
		///     Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pair">The Forex Currency Pair code</param>
		/// <param name="timeframe">The time interval for the quotes</param>
		/// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
		/// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
		/// <param name="startTime">
		///     Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
		/// <param name="endTime">
		///     Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseForexPrices</returns>
		Task<ApiResponseForexPrices> GetForexPricesAsync(string pair, string timeframe, string timezone = null,
			DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Forex Currency Prices
		/// </summary>
		/// <remarks>
		///     Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pair">The Forex Currency Pair code</param>
		/// <param name="timeframe">The time interval for the quotes</param>
		/// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
		/// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
		/// <param name="startTime">
		///     Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
		/// <param name="endTime">
		///     Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone)
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseForexPrices)</returns>
		Task<ApiResponse<ApiResponseForexPrices>> GetForexPricesAsyncWithHttpInfo(string pair, string timeframe,
			string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null,
			string endTime = null, int? pageSize = null, string nextPage = null);

		#endregion Asynchronous Operations
	}
}