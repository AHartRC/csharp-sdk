

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Intrinio.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOptionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns the master list of option contracts for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptions</returns>
        ApiResponseOptions GetOptions (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns the master list of option contracts for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptions</returns>
        ApiResponse<ApiResponseOptions> GetOptionsWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns all options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseOptionsChain</returns>
        ApiResponseOptionsChain GetOptionsChain (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns all options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChain</returns>
        ApiResponse<ApiResponseOptionsChain> GetOptionsChainWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);
        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>ApiResponseOptionsChainRealtime</returns>
        ApiResponseOptionsChainRealtime GetOptionsChainRealtime (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null);

        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainRealtime</returns>
        ApiResponse<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns all option contract expiration dates for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        ApiResponseOptionsExpirations GetOptionsExpirations (string symbol, string after = null, string before = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns all option contract expiration dates for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        ApiResponse<ApiResponseOptionsExpirations> GetOptionsExpirationsWithHttpInfo (string symbol, string after = null, string before = null);
        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionPrices</returns>
        ApiResponseOptionPrices GetOptionsPrices (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionPrices</returns>
        ApiResponse<ApiResponseOptionPrices> GetOptionsPricesWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsPriceRealtime</returns>
        ApiResponseOptionsPriceRealtime GetOptionsPricesRealtime (string identifier, string source = null);

        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPriceRealtime</returns>
        ApiResponse<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeWithHttpInfo (string identifier, string source = null);
        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsStatsRealtime</returns>
        ApiResponseOptionsStatsRealtime GetOptionsStatsRealtime (string identifier, string source = null);

        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsStatsRealtime</returns>
        ApiResponse<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeWithHttpInfo (string identifier, string source = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns the master list of option contracts for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptions</returns>
        System.Threading.Tasks.Task<ApiResponseOptions> GetOptionsAsync (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns the master list of option contracts for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptions)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptions>> GetOptionsAsyncWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns all options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseOptionsChain</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsChain> GetOptionsChainAsync (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns all options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChain)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChain>> GetOptionsChainAsyncWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);
        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeAsync (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null);

        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainRealtime>> GetOptionsChainRealtimeAsyncWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns all option contract expiration dates for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionsExpirationsAsync (string symbol, string after = null, string before = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns all option contract expiration dates for a given symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionsExpirationsAsyncWithHttpInfo (string symbol, string after = null, string before = null);
        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionPrices</returns>
        System.Threading.Tasks.Task<ApiResponseOptionPrices> GetOptionsPricesAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionPrices>> GetOptionsPricesAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPriceRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeAsync (string identifier, string source = null);

        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPriceRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPriceRealtime>> GetOptionsPricesRealtimeAsyncWithHttpInfo (string identifier, string source = null);
        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsStatsRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeAsync (string identifier, string source = null);

        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsStatsRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsStatsRealtime>> GetOptionsStatsRealtimeAsyncWithHttpInfo (string identifier, string source = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OptionsApi : IOptionsApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OptionsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OptionsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Intrinio.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Options Returns the master list of option contracts for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptions</returns>
        public ApiResponseOptions GetOptions (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptions> localVarResponse = GetOptionsWithHttpInfo(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Returns the master list of option contracts for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptions</returns>
        
        
        public ApiResponse< ApiResponseOptions > GetOptionsWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptions");

            var localVarPath = "/options/{symbol}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (expiration != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration", expiration)); // query parameter
            if (expirationAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_after", expirationAfter)); // query parameter
            if (expirationBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_before", expirationBefore)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptions)));
        }

        /// <summary>
        /// Options Returns the master list of option contracts for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptions</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptions> GetOptionsAsync (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptions> localVarResponse = await GetOptionsAsyncWithHttpInfo(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Returns the master list of option contracts for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptions>> GetOptionsAsyncWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptions");

            var localVarPath = "/options/{symbol}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (expiration != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration", expiration)); // query parameter
            if (expirationAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_after", expirationAfter)); // query parameter
            if (expirationBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_before", expirationBefore)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptions)));
        }

        /// <summary>
        /// Options Chain Returns all options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseOptionsChain</returns>
        public ApiResponseOptionsChain GetOptionsChain (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseOptionsChain> localVarResponse = GetOptionsChainWithHttpInfo(symbol, expiration, date, type, strike, strikeGreaterThan, strikeLessThan, moneyness, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Chain Returns all options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChain</returns>
        
        
        public ApiResponse< ApiResponseOptionsChain > GetOptionsChainWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChain");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChain");

            var localVarPath = "/options/chain/{symbol}/{expiration}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsChain", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsChain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChain)));
        }

        /// <summary>
        /// Options Chain Returns all options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseOptionsChain</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsChain> GetOptionsChainAsync (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseOptionsChain> localVarResponse = await GetOptionsChainAsyncWithHttpInfo(symbol, expiration, date, type, strike, strikeGreaterThan, strikeLessThan, moneyness, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Chain Returns all options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChain>> GetOptionsChainAsyncWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChain");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChain");

            var localVarPath = "/options/chain/{symbol}/{expiration}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsChain", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChain>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsChain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChain)));
        }

        /// <summary>
        /// Options Chain Realtime Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>ApiResponseOptionsChainRealtime</returns>
        public ApiResponseOptionsChainRealtime GetOptionsChainRealtime (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null)
        {
             ApiResponse<ApiResponseOptionsChainRealtime> localVarResponse = GetOptionsChainRealtimeWithHttpInfo(symbol, expiration, source, type, strike, strikeGreaterThan, strikeLessThan, volumeGreaterThan, volumeLessThan, openInterestGreaterThan, openInterestLessThan, moneyness);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Chain Realtime Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainRealtime</returns>
        
        
        public ApiResponse< ApiResponseOptionsChainRealtime > GetOptionsChainRealtimeWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChainRealtime");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChainRealtime");

            var localVarPath = "/options/chain/{symbol}/{expiration}/realtime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (volumeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_greater_than", volumeGreaterThan)); // query parameter
            if (volumeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_less_than", volumeLessThan)); // query parameter
            if (openInterestGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_greater_than", openInterestGreaterThan)); // query parameter
            if (openInterestLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_less_than", openInterestLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsChainRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainRealtime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsChainRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainRealtime)));
        }

        /// <summary>
        /// Options Chain Realtime Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeAsync (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null)
        {
             ApiResponse<ApiResponseOptionsChainRealtime> localVarResponse = await GetOptionsChainRealtimeAsyncWithHttpInfo(symbol, expiration, source, type, strike, strikeGreaterThan, strikeLessThan, volumeGreaterThan, volumeLessThan, openInterestGreaterThan, openInterestLessThan, moneyness);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Chain Realtime Returns all realtime options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainRealtime>> GetOptionsChainRealtimeAsyncWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChainRealtime");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChainRealtime");

            var localVarPath = "/options/chain/{symbol}/{expiration}/realtime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (volumeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_greater_than", volumeGreaterThan)); // query parameter
            if (volumeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_less_than", volumeLessThan)); // query parameter
            if (openInterestGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_greater_than", openInterestGreaterThan)); // query parameter
            if (openInterestLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_less_than", openInterestLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsChainRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainRealtime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsChainRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainRealtime)));
        }

        /// <summary>
        /// Options Expirations Returns all option contract expiration dates for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        public ApiResponseOptionsExpirations GetOptionsExpirations (string symbol, string after = null, string before = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = GetOptionsExpirationsWithHttpInfo(symbol, after, before);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Expirations Returns all option contract expiration dates for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        
        
        public ApiResponse< ApiResponseOptionsExpirations > GetOptionsExpirationsWithHttpInfo (string symbol, string after = null, string before = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsExpirations");

            var localVarPath = "/options/expirations/{symbol}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsExpirations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Options Expirations Returns all option contract expiration dates for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionsExpirationsAsync (string symbol, string after = null, string before = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = await GetOptionsExpirationsAsyncWithHttpInfo(symbol, after, before);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Expirations Returns all option contract expiration dates for a given symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionsExpirationsAsyncWithHttpInfo (string symbol, string after = null, string before = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsExpirations");

            var localVarPath = "/options/expirations/{symbol}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsExpirations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Option Prices Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionPrices</returns>
        public ApiResponseOptionPrices GetOptionsPrices (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionPrices> localVarResponse = GetOptionsPricesWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionPrices</returns>
        
        
        public ApiResponse< ApiResponseOptionPrices > GetOptionsPricesWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPrices");

            var localVarPath = "/options/prices/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionPrices>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionPrices)));
        }

        /// <summary>
        /// Option Prices Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionPrices> GetOptionsPricesAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionPrices> localVarResponse = await GetOptionsPricesAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionPrices>> GetOptionsPricesAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPrices");

            var localVarPath = "/options/prices/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionPrices>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionPrices)));
        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsPriceRealtime</returns>
        public ApiResponseOptionsPriceRealtime GetOptionsPricesRealtime (string identifier, string source = null)
        {
             ApiResponse<ApiResponseOptionsPriceRealtime> localVarResponse = GetOptionsPricesRealtimeWithHttpInfo(identifier, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPriceRealtime</returns>
        
        
        public ApiResponse< ApiResponseOptionsPriceRealtime > GetOptionsPricesRealtimeWithHttpInfo (string identifier, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPricesRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsPricesRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPriceRealtime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsPriceRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPriceRealtime)));
        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPriceRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeAsync (string identifier, string source = null)
        {
             ApiResponse<ApiResponseOptionsPriceRealtime> localVarResponse = await GetOptionsPricesRealtimeAsyncWithHttpInfo(identifier, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPriceRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPriceRealtime>> GetOptionsPricesRealtimeAsyncWithHttpInfo (string identifier, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPricesRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsPricesRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPriceRealtime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsPriceRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPriceRealtime)));
        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsStatsRealtime</returns>
        public ApiResponseOptionsStatsRealtime GetOptionsStatsRealtime (string identifier, string source = null)
        {
             ApiResponse<ApiResponseOptionsStatsRealtime> localVarResponse = GetOptionsStatsRealtimeWithHttpInfo(identifier, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsStatsRealtime</returns>
        
        
        public ApiResponse< ApiResponseOptionsStatsRealtime > GetOptionsStatsRealtimeWithHttpInfo (string identifier, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsStatsRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsStatsRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsStatsRealtime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsStatsRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsStatsRealtime)));
        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsStatsRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeAsync (string identifier, string source = null)
        {
             ApiResponse<ApiResponseOptionsStatsRealtime> localVarResponse = await GetOptionsStatsRealtimeAsyncWithHttpInfo(identifier, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsStatsRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsStatsRealtime>> GetOptionsStatsRealtimeAsyncWithHttpInfo (string identifier, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsStatsRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime/stats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsStatsRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsStatsRealtime>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseOptionsStatsRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsStatsRealtime)));
        }

    }
}
