using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
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
	public class ForexApi : IForexApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="ForexApi" /> class.
		/// </summary>
		/// <returns></returns>
		public ForexApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="ForexApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public ForexApi(Configuration configuration = null)
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
		///     Forex Currencies Returns a list of forex currencies for which prices are available.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponseForexCurrencies</returns>
		public ApiResponseForexCurrencies GetForexCurrencies()
		{
			var localVarResponse = GetForexCurrenciesWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		///     Forex Currencies Returns a list of forex currencies for which prices are available.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of ApiResponseForexCurrencies</returns>
		public ApiResponse<ApiResponseForexCurrencies> GetForexCurrenciesWithHttpInfo()
		{
			var localVarPath = "/forex/currencies";
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
				var exception = ExceptionFactory("GetForexCurrencies", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseForexCurrencies>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseForexCurrencies) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseForexCurrencies)));
		}

		/// <summary>
		///     Forex Currencies Returns a list of forex currencies for which prices are available.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponseForexCurrencies</returns>
		public async Task<ApiResponseForexCurrencies> GetForexCurrenciesAsync()
		{
			var localVarResponse = await GetForexCurrenciesAsyncWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		///     Forex Currencies Returns a list of forex currencies for which prices are available.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (ApiResponseForexCurrencies)</returns>
		public async Task<ApiResponse<ApiResponseForexCurrencies>> GetForexCurrenciesAsyncWithHttpInfo()
		{
			var localVarPath = "/forex/currencies";
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
				var exception = ExceptionFactory("GetForexCurrencies", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseForexCurrencies>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseForexCurrencies) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseForexCurrencies)));
		}

		/// <summary>
		///     Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data.
		///     The currency that is used as the reference is called quote currency and the currency that is quoted in relation is
		///     called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can
		///     be exchanged for 0.88 British Pounds (quote currency).
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponseForexPairs</returns>
		public ApiResponseForexPairs GetForexPairs()
		{
			var localVarResponse = GetForexPairsWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		///     Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data.
		///     The currency that is used as the reference is called quote currency and the currency that is quoted in relation is
		///     called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can
		///     be exchanged for 0.88 British Pounds (quote currency).
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse of ApiResponseForexPairs</returns>
		public ApiResponse<ApiResponseForexPairs> GetForexPairsWithHttpInfo()
		{
			var localVarPath = "/forex/pairs";
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
				var exception = ExceptionFactory("GetForexPairs", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseForexPairs>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseForexPairs) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseForexPairs)));
		}

		/// <summary>
		///     Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data.
		///     The currency that is used as the reference is called quote currency and the currency that is quoted in relation is
		///     called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can
		///     be exchanged for 0.88 British Pounds (quote currency).
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponseForexPairs</returns>
		public async Task<ApiResponseForexPairs> GetForexPairsAsync()
		{
			var localVarResponse = await GetForexPairsAsyncWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		///     Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data.
		///     The currency that is used as the reference is called quote currency and the currency that is quoted in relation is
		///     called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can
		///     be exchanged for 0.88 British Pounds (quote currency).
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (ApiResponseForexPairs)</returns>
		public async Task<ApiResponse<ApiResponseForexPairs>> GetForexPairsAsyncWithHttpInfo()
		{
			var localVarPath = "/forex/pairs";
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
				var exception = ExceptionFactory("GetForexPairs", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseForexPairs>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseForexPairs) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseForexPairs)));
		}

		/// <summary>
		///     Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </summary>
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
		public ApiResponseForexPrices GetForexPrices(string pair, string timeframe, string timezone = null,
			DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetForexPricesWithHttpInfo(pair, timeframe, timezone, startDate, startTime, endDate,
				endTime, pageSize, nextPage);
			return localVarResponse.Data;
		}

		public ApiResponse<ApiResponseForexPrices> GetForexPricesWithHttpInfo(string pair, string timeframe,
			string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null,
			string endTime = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'pair' is set
			if (pair == null)
				throw new ApiException(400, "Missing required parameter 'pair' when calling ForexApi->GetForexPrices");
			// verify the required parameter 'timeframe' is set
			if (timeframe == null)
				throw new ApiException(400,
					"Missing required parameter 'timeframe' when calling ForexApi->GetForexPrices");

			var localVarPath = "/forex/prices/{pair}/{timeframe}";
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

			if (startTime != null && startDate != null)
				if (validateTimeParam(startTime))
				{
					var startTimeSpan = TimeSpan.Parse(startTime);
					startDate = startDate.Value.Add(startTimeSpan);
				}

			if (endTime != null && endDate != null)
				if (validateTimeParam(endTime))
				{
					var endTimeSpan = TimeSpan.Parse(endTime);
					endDate = endDate.Value.Add(endTimeSpan);
				}

			if (pair != null)
				localVarPathParams.Add("pair", Configuration.ApiClient.ParameterToString(pair)); // path parameter
			if (timeframe != null)
				localVarPathParams.Add("timeframe",
					Configuration.ApiClient.ParameterToString(timeframe)); // path parameter
			if (timezone != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (startTime != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (endTime != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
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
				var exception = ExceptionFactory("GetForexPrices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseForexPrices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseForexPrices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseForexPrices)));
		}

		/// <summary>
		///     Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </summary>
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
		public async Task<ApiResponseForexPrices> GetForexPricesAsync(string pair, string timeframe,
			string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null,
			string endTime = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetForexPricesAsyncWithHttpInfo(pair, timeframe, timezone, startDate,
				startTime, endDate, endTime, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </summary>
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
		public async Task<ApiResponse<ApiResponseForexPrices>> GetForexPricesAsyncWithHttpInfo(string pair,
			string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null,
			DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'pair' is set
			if (pair == null)
				throw new ApiException(400, "Missing required parameter 'pair' when calling ForexApi->GetForexPrices");
			// verify the required parameter 'timeframe' is set
			if (timeframe == null)
				throw new ApiException(400,
					"Missing required parameter 'timeframe' when calling ForexApi->GetForexPrices");

			var localVarPath = "/forex/prices/{pair}/{timeframe}";
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

			if (startTime != null && startDate != null)
				if (validateTimeParam(startTime))
				{
					var startTimeSpan = TimeSpan.Parse(startTime);
					startDate = startDate.Value.Add(startTimeSpan);
				}

			if (endTime != null && endDate != null)
				if (validateTimeParam(endTime))
				{
					var endTimeSpan = TimeSpan.Parse(endTime);
					endDate = endDate.Value.Add(endTimeSpan);
				}

			if (pair != null)
				localVarPathParams.Add("pair", Configuration.ApiClient.ParameterToString(pair)); // path parameter
			if (timeframe != null)
				localVarPathParams.Add("timeframe",
					Configuration.ApiClient.ParameterToString(timeframe)); // path parameter
			if (timezone != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (startTime != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (endTime != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
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
				var exception = ExceptionFactory("GetForexPrices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseForexPrices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseForexPrices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseForexPrices)));
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

		/// <summary>
		///     Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
		/// </summary>
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
		private static bool validateTimeParam(string time)
		{
			var validTimePattern = @"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$";
			var validTimeRegex = new Regex(validTimePattern);
			var invalidTime = !validTimeRegex.IsMatch(time);

			if (invalidTime)
				throw new ArgumentException("Time must be in the format 'hh:mm'");
			return true;
		}
	}
}