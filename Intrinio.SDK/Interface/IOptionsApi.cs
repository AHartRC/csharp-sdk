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
	public interface IOptionsApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     Options
		/// </summary>
		/// <remarks>
		///     Returns the master list of option contracts for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="expiration">
		///     The expiration date of the option contract. This will return options contracts with expiration
		///     dates on this date. (optional)
		/// </param>
		/// <param name="expirationAfter">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates after this date. (optional)
		/// </param>
		/// <param name="expirationBefore">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates before this date. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseOptions</returns>
		ApiResponseOptions GetOptions(string symbol, string type = null, decimal? strike = null,
			decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null,
			string expirationAfter = null, string expirationBefore = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Options
		/// </summary>
		/// <remarks>
		///     Returns the master list of option contracts for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="expiration">
		///     The expiration date of the option contract. This will return options contracts with expiration
		///     dates on this date. (optional)
		/// </param>
		/// <param name="expirationAfter">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates after this date. (optional)
		/// </param>
		/// <param name="expirationBefore">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates before this date. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseOptions</returns>
		ApiResponse<ApiResponseOptions> GetOptionsWithHttpInfo(string symbol, string type = null,
			decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null,
			string expiration = null, string expirationAfter = null, string expirationBefore = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Options Chain
		/// </summary>
		/// <remarks>
		///     Returns all options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseOptionsChain</returns>
		ApiResponseOptionsChain GetOptionsChain(string symbol, string expiration, DateTime? date = null,
			string type = null, decimal? strike = null, decimal? strikeGreaterThan = null,
			decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

		/// <summary>
		///     Options Chain
		/// </summary>
		/// <remarks>
		///     Returns all options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseOptionsChain</returns>
		ApiResponse<ApiResponseOptionsChain> GetOptionsChainWithHttpInfo(string symbol, string expiration,
			DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null,
			decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

		/// <summary>
		///     Options Chain Realtime
		/// </summary>
		/// <remarks>
		///     Returns all realtime options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="volumeGreaterThan">
		///     The volume of the option contract. This will return options contracts with volumes
		///     greater than this amount. (optional)
		/// </param>
		/// <param name="volumeLessThan">
		///     The volume of the option contract. This will return options contracts with volumes less
		///     than this amout. (optional)
		/// </param>
		/// <param name="openInterestGreaterThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest greater than this amount. (optional)
		/// </param>
		/// <param name="openInterestLessThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest less than this amount. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data.
		///     (optional)
		/// </param>
		/// <returns>ApiResponseOptionsChainRealtime</returns>
		ApiResponseOptionsChainRealtime GetOptionsChainRealtime(string symbol, string expiration, string source = null,
			string type = null, decimal? strike = null, decimal? strikeGreaterThan = null,
			decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null,
			decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null);

		/// <summary>
		///     Options Chain Realtime
		/// </summary>
		/// <remarks>
		///     Returns all realtime options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="volumeGreaterThan">
		///     The volume of the option contract. This will return options contracts with volumes
		///     greater than this amount. (optional)
		/// </param>
		/// <param name="volumeLessThan">
		///     The volume of the option contract. This will return options contracts with volumes less
		///     than this amout. (optional)
		/// </param>
		/// <param name="openInterestGreaterThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest greater than this amount. (optional)
		/// </param>
		/// <param name="openInterestLessThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest less than this amount. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data.
		///     (optional)
		/// </param>
		/// <returns>ApiResponse of ApiResponseOptionsChainRealtime</returns>
		ApiResponse<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeWithHttpInfo(string symbol,
			string expiration, string source = null, string type = null, decimal? strike = null,
			decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null,
			decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null,
			decimal? openInterestLessThan = null, string moneyness = null);

		/// <summary>
		///     Options Expirations
		/// </summary>
		/// <remarks>
		///     Returns all option contract expiration dates for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="after">Return option contract expiration dates after this date. (optional)</param>
		/// <param name="before">Return option contract expiration dates before this date. (optional)</param>
		/// <returns>ApiResponseOptionsExpirations</returns>
		ApiResponseOptionsExpirations GetOptionsExpirations(string symbol, string after = null, string before = null);

		/// <summary>
		///     Options Expirations
		/// </summary>
		/// <remarks>
		///     Returns all option contract expiration dates for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="after">Return option contract expiration dates after this date. (optional)</param>
		/// <param name="before">Return option contract expiration dates before this date. (optional)</param>
		/// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
		ApiResponse<ApiResponseOptionsExpirations> GetOptionsExpirationsWithHttpInfo(string symbol, string after = null,
			string before = null);

		/// <summary>
		///     Option Prices
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
		/// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseOptionPrices</returns>
		ApiResponseOptionPrices GetOptionsPrices(string identifier, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Option Prices
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
		/// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseOptionPrices</returns>
		ApiResponse<ApiResponseOptionPrices> GetOptionsPricesWithHttpInfo(string identifier, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Option Prices Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>ApiResponseOptionsPriceRealtime</returns>
		ApiResponseOptionsPriceRealtime GetOptionsPricesRealtime(string identifier, string source = null);

		/// <summary>
		///     Option Prices Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>ApiResponse of ApiResponseOptionsPriceRealtime</returns>
		ApiResponse<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeWithHttpInfo(string identifier,
			string source = null);

		/// <summary>
		///     Option Stats Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option
		///     contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>ApiResponseOptionsStatsRealtime</returns>
		ApiResponseOptionsStatsRealtime GetOptionsStatsRealtime(string identifier, string source = null);

		/// <summary>
		///     Option Stats Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option
		///     contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>ApiResponse of ApiResponseOptionsStatsRealtime</returns>
		ApiResponse<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeWithHttpInfo(string identifier,
			string source = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     Options
		/// </summary>
		/// <remarks>
		///     Returns the master list of option contracts for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="expiration">
		///     The expiration date of the option contract. This will return options contracts with expiration
		///     dates on this date. (optional)
		/// </param>
		/// <param name="expirationAfter">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates after this date. (optional)
		/// </param>
		/// <param name="expirationBefore">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates before this date. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseOptions</returns>
		Task<ApiResponseOptions> GetOptionsAsync(string symbol, string type = null, decimal? strike = null,
			decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null,
			string expirationAfter = null, string expirationBefore = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Options
		/// </summary>
		/// <remarks>
		///     Returns the master list of option contracts for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="expiration">
		///     The expiration date of the option contract. This will return options contracts with expiration
		///     dates on this date. (optional)
		/// </param>
		/// <param name="expirationAfter">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates after this date. (optional)
		/// </param>
		/// <param name="expirationBefore">
		///     The expiration date of the option contract. This will return options contracts with
		///     expiration dates before this date. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseOptions)</returns>
		Task<ApiResponse<ApiResponseOptions>> GetOptionsAsyncWithHttpInfo(string symbol, string type = null,
			decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null,
			string expiration = null, string expirationAfter = null, string expirationBefore = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Options Chain
		/// </summary>
		/// <remarks>
		///     Returns all options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseOptionsChain</returns>
		Task<ApiResponseOptionsChain> GetOptionsChainAsync(string symbol, string expiration, DateTime? date = null,
			string type = null, decimal? strike = null, decimal? strikeGreaterThan = null,
			decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

		/// <summary>
		///     Options Chain
		/// </summary>
		/// <remarks>
		///     Returns all options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseOptionsChain)</returns>
		Task<ApiResponse<ApiResponseOptionsChain>> GetOptionsChainAsyncWithHttpInfo(string symbol, string expiration,
			DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null,
			decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

		/// <summary>
		///     Options Chain Realtime
		/// </summary>
		/// <remarks>
		///     Returns all realtime options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="volumeGreaterThan">
		///     The volume of the option contract. This will return options contracts with volumes
		///     greater than this amount. (optional)
		/// </param>
		/// <param name="volumeLessThan">
		///     The volume of the option contract. This will return options contracts with volumes less
		///     than this amout. (optional)
		/// </param>
		/// <param name="openInterestGreaterThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest greater than this amount. (optional)
		/// </param>
		/// <param name="openInterestLessThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest less than this amount. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data.
		///     (optional)
		/// </param>
		/// <returns>Task of ApiResponseOptionsChainRealtime</returns>
		Task<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeAsync(string symbol, string expiration,
			string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null,
			decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null,
			decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null);

		/// <summary>
		///     Options Chain Realtime
		/// </summary>
		/// <remarks>
		///     Returns all realtime options contracts and their prices for the given symbol and expiration date.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="expiration">The expiration date of the options contract</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <param name="type">The option contract type. (optional)</param>
		/// <param name="strike">
		///     The strike price of the option contract. This will return options contracts with strike price
		///     equal to this price. (optional)
		/// </param>
		/// <param name="strikeGreaterThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices greater than this price. (optional)
		/// </param>
		/// <param name="strikeLessThan">
		///     The strike price of the option contract. This will return options contracts with strike
		///     prices less than this price. (optional)
		/// </param>
		/// <param name="volumeGreaterThan">
		///     The volume of the option contract. This will return options contracts with volumes
		///     greater than this amount. (optional)
		/// </param>
		/// <param name="volumeLessThan">
		///     The volume of the option contract. This will return options contracts with volumes less
		///     than this amout. (optional)
		/// </param>
		/// <param name="openInterestGreaterThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest greater than this amount. (optional)
		/// </param>
		/// <param name="openInterestLessThan">
		///     The open interest of the option contract. This will return options contracts with
		///     open interest less than this amount. (optional)
		/// </param>
		/// <param name="moneyness">
		///     The moneyness of the options contracts to return. &#39;all&#39; will return all options
		///     contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike
		///     prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money
		///     &#39; will return options contracts that are out of the money (call options with strike prices above the current
		///     price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options
		///     contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data.
		///     (optional)
		/// </param>
		/// <returns>Task of ApiResponse (ApiResponseOptionsChainRealtime)</returns>
		Task<ApiResponse<ApiResponseOptionsChainRealtime>> GetOptionsChainRealtimeAsyncWithHttpInfo(string symbol,
			string expiration, string source = null, string type = null, decimal? strike = null,
			decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null,
			decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null,
			decimal? openInterestLessThan = null, string moneyness = null);

		/// <summary>
		///     Options Expirations
		/// </summary>
		/// <remarks>
		///     Returns all option contract expiration dates for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="after">Return option contract expiration dates after this date. (optional)</param>
		/// <param name="before">Return option contract expiration dates before this date. (optional)</param>
		/// <returns>Task of ApiResponseOptionsExpirations</returns>
		Task<ApiResponseOptionsExpirations> GetOptionsExpirationsAsync(string symbol, string after = null,
			string before = null);

		/// <summary>
		///     Options Expirations
		/// </summary>
		/// <remarks>
		///     Returns all option contract expiration dates for a given symbol.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
		/// <param name="after">Return option contract expiration dates after this date. (optional)</param>
		/// <param name="before">Return option contract expiration dates before this date. (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
		Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionsExpirationsAsyncWithHttpInfo(string symbol,
			string after = null, string before = null);

		/// <summary>
		///     Option Prices
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
		/// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseOptionPrices</returns>
		Task<ApiResponseOptionPrices> GetOptionsPricesAsync(string identifier, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Option Prices
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
		/// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseOptionPrices)</returns>
		Task<ApiResponse<ApiResponseOptionPrices>> GetOptionsPricesAsyncWithHttpInfo(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Option Prices Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>Task of ApiResponseOptionsPriceRealtime</returns>
		Task<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeAsync(string identifier, string source = null);

		/// <summary>
		///     Option Prices Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option prices for a given option contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseOptionsPriceRealtime)</returns>
		Task<ApiResponse<ApiResponseOptionsPriceRealtime>> GetOptionsPricesRealtimeAsyncWithHttpInfo(string identifier,
			string source = null);

		/// <summary>
		///     Option Stats Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option
		///     contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>Task of ApiResponseOptionsStatsRealtime</returns>
		Task<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeAsync(string identifier, string source = null);

		/// <summary>
		///     Option Stats Realtime
		/// </summary>
		/// <remarks>
		///     Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option
		///     contract identifier.
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
		/// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseOptionsStatsRealtime)</returns>
		Task<ApiResponse<ApiResponseOptionsStatsRealtime>> GetOptionsStatsRealtimeAsyncWithHttpInfo(string identifier,
			string source = null);

		#endregion Asynchronous Operations
	}
}