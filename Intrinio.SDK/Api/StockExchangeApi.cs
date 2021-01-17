using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Interface;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Api
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public class StockExchangeApi : IStockExchangeApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="StockExchangeApi" /> class.
		/// </summary>
		/// <returns></returns>
		public StockExchangeApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="StockExchangeApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public StockExchangeApi(Configuration configuration = null)
		{
			if (configuration == null) // use the default one in Configuration
				Configuration = Configuration.Default;
			else
				Configuration = configuration;

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Gets the base path of the API client.
		/// </summary>
		/// <value>The base path</value>
		public string GetBasePath()
		{
			return Configuration.ApiClient.RestClient.BaseUrl.ToString();
		}

		/// <summary>
		///     Gets or sets the configuration object
		/// </summary>
		/// <value>An instance of the Configuration</value>
		public Configuration Configuration { get; set; }

		/// <summary>
		///     Provides a factory method hook for the creation of exceptions.
		/// </summary>
		public ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				return _exceptionFactory;
			}
			set => _exceptionFactory = value;
		}

		/// <summary>
		///     All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseStockExchanges</returns>
		public ApiResponseStockExchanges GetAllStockExchanges(string city = null, string country = null,
			string countryCode = null, int? pageSize = null)
		{
			var localVarResponse = GetAllStockExchangesWithHttpInfo(city, country, countryCode, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseStockExchanges</returns>
		public ApiResponse<ApiResponseStockExchanges> GetAllStockExchangesWithHttpInfo(string city = null,
			string country = null, string countryCode = null, int? pageSize = null)
		{
			var localVarPath = "/stock_exchanges";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (city != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "city", city)); // query parameter
			if (country != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
			if (countryCode != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code",
						countryCode)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetAllStockExchanges", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchanges>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchanges) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchanges)));
		}

		/// <summary>
		///     All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseStockExchanges</returns>
		public async Task<ApiResponseStockExchanges> GetAllStockExchangesAsync(string city = null,
			string country = null, string countryCode = null, int? pageSize = null)
		{
			var localVarResponse = await GetAllStockExchangesAsyncWithHttpInfo(city, country, countryCode, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="city">Filter by city (optional)</param>
		/// <param name="country">Filter by country (optional)</param>
		/// <param name="countryCode">Filter by ISO country code (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchanges)</returns>
		public async Task<ApiResponse<ApiResponseStockExchanges>> GetAllStockExchangesAsyncWithHttpInfo(
			string city = null, string country = null, string countryCode = null, int? pageSize = null)
		{
			var localVarPath = "/stock_exchanges";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (city != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "city", city)); // query parameter
			if (country != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
			if (countryCode != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code",
						countryCode)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetAllStockExchanges", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchanges>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchanges) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchanges)));
		}

		/// <summary>
		///     Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>StockExchange</returns>
		public StockExchange GetStockExchangeById(string identifier)
		{
			var localVarResponse = GetStockExchangeByIdWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>ApiResponse of StockExchange</returns>
		public ApiResponse<StockExchange> GetStockExchangeByIdWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeById");

			var localVarPath = "/stock_exchanges/{identifier}";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangeById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<StockExchange>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(StockExchange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockExchange)));
		}

		/// <summary>
		///     Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>Task of StockExchange</returns>
		public async Task<StockExchange> GetStockExchangeByIdAsync(string identifier)
		{
			var localVarResponse = await GetStockExchangeByIdAsyncWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <returns>Task of ApiResponse (StockExchange)</returns>
		public async Task<ApiResponse<StockExchange>> GetStockExchangeByIdAsyncWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeById");

			var localVarPath = "/stock_exchanges/{identifier}";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangeById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<StockExchange>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(StockExchange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockExchange)));
		}

		/// <summary>
		///     Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
		public ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustments(string identifier,
			DateTime? date = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetStockExchangePriceAdjustmentsWithHttpInfo(identifier, date, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
		public ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsWithHttpInfo(
			string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustments");

			var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (date != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangePriceAdjustments", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeStockPriceAdjustments)));
		}

		/// <summary>
		///     Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
		public async Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsAsync(
			string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse =
				await GetStockExchangePriceAdjustmentsAsyncWithHttpInfo(identifier, date, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return price adjustments (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
		public async Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>>
			GetStockExchangePriceAdjustmentsAsyncWithHttpInfo(string identifier, DateTime? date = null,
				int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustments");

			var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (date != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangePriceAdjustments", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeStockPriceAdjustments)));
		}

		/// <summary>
		///     Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier
		///     &#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeStockPrices</returns>
		public ApiResponseStockExchangeStockPrices GetStockExchangePrices(string identifier, DateTime? date = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetStockExchangePricesWithHttpInfo(identifier, date, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier
		///     &#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeStockPrices</returns>
		public ApiResponse<ApiResponseStockExchangeStockPrices> GetStockExchangePricesWithHttpInfo(string identifier,
			DateTime? date = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePrices");

			var localVarPath = "/stock_exchanges/{identifier}/prices";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (date != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangePrices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeStockPrices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeStockPrices)));
		}

		/// <summary>
		///     Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier
		///     &#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeStockPrices</returns>
		public async Task<ApiResponseStockExchangeStockPrices> GetStockExchangePricesAsync(string identifier,
			DateTime? date = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetStockExchangePricesAsyncWithHttpInfo(identifier, date, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier
		///     &#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="date">The date for which to return prices (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPrices)</returns>
		public async Task<ApiResponse<ApiResponseStockExchangeStockPrices>> GetStockExchangePricesAsyncWithHttpInfo(
			string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePrices");

			var localVarPath = "/stock_exchanges/{identifier}/prices";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (date != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangePrices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeStockPrices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeStockPrices)));
		}

		/// <summary>
		///     Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeRealtimeStockPrices</returns>
		public ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices(string identifier,
			string source = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetStockExchangeRealtimePricesWithHttpInfo(identifier, source, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeRealtimeStockPrices</returns>
		public ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesWithHttpInfo(
			string identifier, string source = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeRealtimePrices");

			var localVarPath = "/stock_exchanges/{identifier}/prices/realtime";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (source != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangeRealtimePrices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeRealtimeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeRealtimeStockPrices)));
		}

		/// <summary>
		///     Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeRealtimeStockPrices</returns>
		public async Task<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesAsync(
			string identifier, string source = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse =
				await GetStockExchangeRealtimePricesAsyncWithHttpInfo(identifier, source, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;
		///     identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="source">
		///     Return realtime prices from the specified data source. If no source is specified, all sources are
		///     used. (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeRealtimeStockPrices)</returns>
		public async Task<ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>>
			GetStockExchangeRealtimePricesAsyncWithHttpInfo(string identifier, string source = null,
				int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeRealtimePrices");

			var localVarPath = "/stock_exchanges/{identifier}/prices/realtime";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (source != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangeRealtimePrices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeRealtimeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeRealtimeStockPrices)));
		}

		/// <summary>
		///     Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockExchangeSecurities</returns>
		public ApiResponseStockExchangeSecurities GetStockExchangeSecurities(string identifier, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = GetStockExchangeSecuritiesWithHttpInfo(identifier, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockExchangeSecurities</returns>
		public ApiResponse<ApiResponseStockExchangeSecurities> GetStockExchangeSecuritiesWithHttpInfo(string identifier,
			int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeSecurities");

			var localVarPath = "/stock_exchanges/{identifier}/securities";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangeSecurities", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeSecurities>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeSecurities) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeSecurities)));
		}

		/// <summary>
		///     Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockExchangeSecurities</returns>
		public async Task<ApiResponseStockExchangeSecurities> GetStockExchangeSecuritiesAsync(string identifier,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetStockExchangeSecuritiesAsyncWithHttpInfo(identifier, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockExchangeSecurities)</returns>
		public async Task<ApiResponse<ApiResponseStockExchangeSecurities>> GetStockExchangeSecuritiesAsyncWithHttpInfo(
			string identifier, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeSecurities");

			var localVarPath = "/stock_exchanges/{identifier}/securities";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetStockExchangeSecurities", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockExchangeSecurities>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockExchangeSecurities) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockExchangeSecurities)));
		}

		/// <summary>
		///     Sets the base path of the API client.
		/// </summary>
		/// <value>The base path</value>
		[Obsolete(
			"SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
		public void SetBasePath(string basePath)
		{
			// do nothing
		}

		/// <summary>
		///     Gets the default header.
		/// </summary>
		/// <returns>Dictionary of HTTP header</returns>
		[Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
		public IDictionary<string, string> DefaultHeader()
		{
			return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
		}

		/// <summary>
		///     Add default header.
		/// </summary>
		/// <param name="key">Header field name.</param>
		/// <param name="value">Header field value.</param>
		/// <returns></returns>
		[Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
		public void AddDefaultHeader(string key, string value)
		{
			Configuration.AddDefaultHeader(key, value);
		}
	}
}