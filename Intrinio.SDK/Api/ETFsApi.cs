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
	public class ETFsApi : IETFsApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="ETFsApi" /> class.
		/// </summary>
		/// <returns></returns>
		public ETFsApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="ETFsApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public ETFsApi(Configuration configuration = null)
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
		///     All ETFs Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseETFs</returns>
		public ApiResponseETFs GetAllEtfs(string exchange = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetAllEtfsWithHttpInfo(exchange, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All ETFs Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseETFs</returns>
		public ApiResponse<ApiResponseETFs> GetAllEtfsWithHttpInfo(string exchange = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/etfs";
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


			if (exchange != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
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
				var exception = ExceptionFactory("GetAllEtfs", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
		}

		/// <summary>
		///     All ETFs Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseETFs</returns>
		public async Task<ApiResponseETFs> GetAllEtfsAsync(string exchange = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = await GetAllEtfsAsyncWithHttpInfo(exchange, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All ETFs Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="exchange"> (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
		public async Task<ApiResponse<ApiResponseETFs>> GetAllEtfsAsyncWithHttpInfo(string exchange = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/etfs";
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


			if (exchange != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
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
				var exception = ExceptionFactory("GetAllEtfs", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
		}

		/// <summary>
		///     Lookup ETF Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ETF</returns>
		public ETF GetEtf(string identifier)
		{
			var localVarResponse = GetEtfWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup ETF Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ApiResponse of ETF</returns>
		public ApiResponse<ETF> GetEtfWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtf");

			var localVarPath = "/etfs/{identifier}";
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
				var exception = ExceptionFactory("GetEtf", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ETF>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ETF) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETF)));
		}

		/// <summary>
		///     Lookup ETF Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ETF</returns>
		public async Task<ETF> GetEtfAsync(string identifier)
		{
			var localVarResponse = await GetEtfAsyncWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup ETF Returns the Exchange Traded Fund (ETF) with the given identifier
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (ETF)</returns>
		public async Task<ApiResponse<ETF>> GetEtfAsyncWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtf");

			var localVarPath = "/etfs/{identifier}";
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
				var exception = ExceptionFactory("GetEtf", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ETF>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ETF) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETF)));
		}

		/// <summary>
		///     ETF Analytics Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and
		///     52 week low
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ETFAnalytics</returns>
		public ETFAnalytics GetEtfAnalytics(string identifier)
		{
			var localVarResponse = GetEtfAnalyticsWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     ETF Analytics Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and
		///     52 week low
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ApiResponse of ETFAnalytics</returns>
		public ApiResponse<ETFAnalytics> GetEtfAnalyticsWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling ETFsApi->GetEtfAnalytics");

			var localVarPath = "/etfs/{identifier}/analytics";
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
				var exception = ExceptionFactory("GetEtfAnalytics", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ETFAnalytics>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ETFAnalytics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFAnalytics)));
		}

		/// <summary>
		///     ETF Analytics Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and
		///     52 week low
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ETFAnalytics</returns>
		public async Task<ETFAnalytics> GetEtfAnalyticsAsync(string identifier)
		{
			var localVarResponse = await GetEtfAnalyticsAsyncWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     ETF Analytics Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and
		///     52 week low
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (ETFAnalytics)</returns>
		public async Task<ApiResponse<ETFAnalytics>> GetEtfAnalyticsAsyncWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling ETFsApi->GetEtfAnalytics");

			var localVarPath = "/etfs/{identifier}/analytics";
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
				var exception = ExceptionFactory("GetEtfAnalytics", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ETFAnalytics>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ETFAnalytics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFAnalytics)));
		}

		/// <summary>
		///     ETF Holdings Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseETFHoldings</returns>
		public ApiResponseETFHoldings GetEtfHoldings(string identifier, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetEtfHoldingsWithHttpInfo(identifier, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     ETF Holdings Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseETFHoldings</returns>
		public ApiResponse<ApiResponseETFHoldings> GetEtfHoldingsWithHttpInfo(string identifier, int? pageSize = null,
			string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling ETFsApi->GetEtfHoldings");

			var localVarPath = "/etfs/{identifier}/holdings";
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
				var exception = ExceptionFactory("GetEtfHoldings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseETFHoldings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseETFHoldings)));
		}

		/// <summary>
		///     ETF Holdings Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseETFHoldings</returns>
		public async Task<ApiResponseETFHoldings> GetEtfHoldingsAsync(string identifier, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = await GetEtfHoldingsAsyncWithHttpInfo(identifier, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     ETF Holdings Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseETFHoldings)</returns>
		public async Task<ApiResponse<ApiResponseETFHoldings>> GetEtfHoldingsAsyncWithHttpInfo(string identifier,
			int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling ETFsApi->GetEtfHoldings");

			var localVarPath = "/etfs/{identifier}/holdings";
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
				var exception = ExceptionFactory("GetEtfHoldings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseETFHoldings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseETFHoldings)));
		}

		/// <summary>
		///     Exchange Traded Fund (ETF) stats Returns daily stats for the Exchange Traded Fund (ETF) including net asset value,
		///     beta vs spy, returns, and volatility
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ETFStats</returns>
		public ETFStats GetEtfStats(string identifier)
		{
			var localVarResponse = GetEtfStatsWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Exchange Traded Fund (ETF) stats Returns daily stats for the Exchange Traded Fund (ETF) including net asset value,
		///     beta vs spy, returns, and volatility
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>ApiResponse of ETFStats</returns>
		public ApiResponse<ETFStats> GetEtfStatsWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling ETFsApi->GetEtfStats");

			var localVarPath = "/etfs/{identifier}/stats";
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
				var exception = ExceptionFactory("GetEtfStats", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ETFStats>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ETFStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFStats)));
		}

		/// <summary>
		///     Exchange Traded Fund (ETF) stats Returns daily stats for the Exchange Traded Fund (ETF) including net asset value,
		///     beta vs spy, returns, and volatility
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ETFStats</returns>
		public async Task<ETFStats> GetEtfStatsAsync(string identifier)
		{
			var localVarResponse = await GetEtfStatsAsyncWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Exchange Traded Fund (ETF) stats Returns daily stats for the Exchange Traded Fund (ETF) including net asset value,
		///     beta vs spy, returns, and volatility
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (ETFStats)</returns>
		public async Task<ApiResponse<ETFStats>> GetEtfStatsAsyncWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling ETFsApi->GetEtfStats");

			var localVarPath = "/etfs/{identifier}/stats";
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
				var exception = ExceptionFactory("GetEtfStats", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ETFStats>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ETFStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFStats)));
		}

		/// <summary>
		///     Search ETFs Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>ApiResponseETFs</returns>
		public ApiResponseETFs SearchEtfs(string query)
		{
			var localVarResponse = SearchEtfsWithHttpInfo(query);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search ETFs Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>ApiResponse of ApiResponseETFs</returns>
		public ApiResponse<ApiResponseETFs> SearchEtfsWithHttpInfo(string query)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400, "Missing required parameter 'query' when calling ETFsApi->SearchEtfs");

			var localVarPath = "/etfs/search";
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


			if (query != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

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
				var exception = ExceptionFactory("SearchEtfs", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
		}

		/// <summary>
		///     Search ETFs Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>Task of ApiResponseETFs</returns>
		public async Task<ApiResponseETFs> SearchEtfsAsync(string query)
		{
			var localVarResponse = await SearchEtfsAsyncWithHttpInfo(query);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search ETFs Searches for Exchange Traded Funds (ETFs) matching the text &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query"></param>
		/// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
		public async Task<ApiResponse<ApiResponseETFs>> SearchEtfsAsyncWithHttpInfo(string query)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400, "Missing required parameter 'query' when calling ETFsApi->SearchEtfs");

			var localVarPath = "/etfs/search";
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


			if (query != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

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
				var exception = ExceptionFactory("SearchEtfs", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
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