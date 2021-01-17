using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;
using Intrinio.SDK.Model.Search;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public class IndexApi : IIndexApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="IndexApi" /> class.
		/// </summary>
		/// <returns></returns>
		public IndexApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="IndexApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public IndexApi(Configuration configuration = null)
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
		///     All Economic Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseEconomicIndices</returns>
		public ApiResponseEconomicIndices GetAllEconomicIndices(int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetAllEconomicIndicesWithHttpInfo(pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Economic Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseEconomicIndices</returns>
		public ApiResponse<ApiResponseEconomicIndices> GetAllEconomicIndicesWithHttpInfo(int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/indices/economic";
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
				var exception = ExceptionFactory("GetAllEconomicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseEconomicIndices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseEconomicIndices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseEconomicIndices)));
		}

		/// <summary>
		///     All Economic Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseEconomicIndices</returns>
		public async Task<ApiResponseEconomicIndices> GetAllEconomicIndicesAsync(int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = await GetAllEconomicIndicesAsyncWithHttpInfo(pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Economic Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseEconomicIndices)</returns>
		public async Task<ApiResponse<ApiResponseEconomicIndices>> GetAllEconomicIndicesAsyncWithHttpInfo(
			int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/indices/economic";
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
				var exception = ExceptionFactory("GetAllEconomicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseEconomicIndices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseEconomicIndices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseEconomicIndices)));
		}

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSICIndices</returns>
		public ApiResponseSICIndices GetAllSicIndices(int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetAllSicIndicesWithHttpInfo(pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSICIndices</returns>
		public ApiResponse<ApiResponseSICIndices> GetAllSicIndicesWithHttpInfo(int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/indices/sic";
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
				var exception = ExceptionFactory("GetAllSicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseSICIndices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseSICIndices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseSICIndices)));
		}

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSICIndices</returns>
		public async Task<ApiResponseSICIndices> GetAllSicIndicesAsync(int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetAllSicIndicesAsyncWithHttpInfo(pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSICIndices)</returns>
		public async Task<ApiResponse<ApiResponseSICIndices>> GetAllSicIndicesAsyncWithHttpInfo(int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/indices/sic";
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
				var exception = ExceptionFactory("GetAllSicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseSICIndices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseSICIndices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseSICIndices)));
		}

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockMarketIndices</returns>
		public ApiResponseStockMarketIndices GetAllStockMarketIndices(int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetAllStockMarketIndicesWithHttpInfo(pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockMarketIndices</returns>
		public ApiResponse<ApiResponseStockMarketIndices> GetAllStockMarketIndicesWithHttpInfo(int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/indices/stock_market";
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
				var exception = ExceptionFactory("GetAllStockMarketIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockMarketIndices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockMarketIndices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockMarketIndices)));
		}

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockMarketIndices</returns>
		public async Task<ApiResponseStockMarketIndices> GetAllStockMarketIndicesAsync(int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = await GetAllStockMarketIndicesAsyncWithHttpInfo(pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockMarketIndices)</returns>
		public async Task<ApiResponse<ApiResponseStockMarketIndices>> GetAllStockMarketIndicesAsyncWithHttpInfo(
			int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/indices/stock_market";
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
				var exception = ExceptionFactory("GetAllStockMarketIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockMarketIndices>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockMarketIndices) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockMarketIndices)));
		}

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>EconomicIndex</returns>
		public EconomicIndex GetEconomicIndexById(string identifier)
		{
			var localVarResponse = GetEconomicIndexByIdWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>ApiResponse of EconomicIndex</returns>
		public ApiResponse<EconomicIndex> GetEconomicIndexByIdWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexById");

			var localVarPath = "/indices/economic/{identifier}";
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
				var exception = ExceptionFactory("GetEconomicIndexById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<EconomicIndex>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(EconomicIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EconomicIndex)));
		}

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of EconomicIndex</returns>
		public async Task<EconomicIndex> GetEconomicIndexByIdAsync(string identifier)
		{
			var localVarResponse = await GetEconomicIndexByIdAsyncWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (EconomicIndex)</returns>
		public async Task<ApiResponse<EconomicIndex>> GetEconomicIndexByIdAsyncWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexById");

			var localVarPath = "/indices/economic/{identifier}";
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
				var exception = ExceptionFactory("GetEconomicIndexById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<EconomicIndex>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(EconomicIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EconomicIndex)));
		}

		/// <summary>
		///     Data Point (Number) for an Economic Index Returns a numeric value for the given &#x60;tag&#x60; for the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>decimal?</returns>
		public decimal? GetEconomicIndexDataPointNumber(string identifier, string tag)
		{
			var localVarResponse = GetEconomicIndexDataPointNumberWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Number) for an Economic Index Returns a numeric value for the given &#x60;tag&#x60; for the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>ApiResponse of decimal?</returns>
		public ApiResponse<decimal?> GetEconomicIndexDataPointNumberWithHttpInfo(string identifier, string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointNumber");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetEconomicIndexDataPointNumber");

			var localVarPath = "/indices/economic/{identifier}/data_point/{tag}/number";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetEconomicIndexDataPointNumber", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<decimal?>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
		}

		/// <summary>
		///     Data Point (Number) for an Economic Index Returns a numeric value for the given &#x60;tag&#x60; for the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>Task of decimal?</returns>
		public async Task<decimal?> GetEconomicIndexDataPointNumberAsync(string identifier, string tag)
		{
			var localVarResponse = await GetEconomicIndexDataPointNumberAsyncWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Number) for an Economic Index Returns a numeric value for the given &#x60;tag&#x60; for the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>Task of ApiResponse (decimal?)</returns>
		public async Task<ApiResponse<decimal?>> GetEconomicIndexDataPointNumberAsyncWithHttpInfo(string identifier,
			string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointNumber");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetEconomicIndexDataPointNumber");

			var localVarPath = "/indices/economic/{identifier}/data_point/{tag}/number";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetEconomicIndexDataPointNumber", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<decimal?>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
		}

		/// <summary>
		///     Data Point (Text) for an Economic Index Returns a text value for the given &#x60;tag&#x60; for the Economic Index
		///     with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>string</returns>
		public string GetEconomicIndexDataPointText(string identifier, string tag)
		{
			var localVarResponse = GetEconomicIndexDataPointTextWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Text) for an Economic Index Returns a text value for the given &#x60;tag&#x60; for the Economic Index
		///     with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of string</returns>
		public ApiResponse<string> GetEconomicIndexDataPointTextWithHttpInfo(string identifier, string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointText");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetEconomicIndexDataPointText");

			var localVarPath = "/indices/economic/{identifier}/data_point/{tag}/text";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetEconomicIndexDataPointText", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<string>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
		}

		/// <summary>
		///     Data Point (Text) for an Economic Index Returns a text value for the given &#x60;tag&#x60; for the Economic Index
		///     with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of string</returns>
		public async Task<string> GetEconomicIndexDataPointTextAsync(string identifier, string tag)
		{
			var localVarResponse = await GetEconomicIndexDataPointTextAsyncWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Text) for an Economic Index Returns a text value for the given &#x60;tag&#x60; for the Economic Index
		///     with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (string)</returns>
		public async Task<ApiResponse<string>> GetEconomicIndexDataPointTextAsyncWithHttpInfo(string identifier,
			string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexDataPointText");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetEconomicIndexDataPointText");

			var localVarPath = "/indices/economic/{identifier}/data_point/{tag}/text";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetEconomicIndexDataPointText", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<string>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
		}

		/// <summary>
		///     Historical Data for an Economic Index Returns historical values for the given &#x60;tag&#x60; and the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseEconomicIndexHistoricalData</returns>
		public ApiResponseEconomicIndexHistoricalData GetEconomicIndexHistoricalData(string identifier, string tag,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetEconomicIndexHistoricalDataWithHttpInfo(identifier, tag, type, startDate, endDate,
				sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data for an Economic Index Returns historical values for the given &#x60;tag&#x60; and the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseEconomicIndexHistoricalData</returns>
		public ApiResponse<ApiResponseEconomicIndexHistoricalData> GetEconomicIndexHistoricalDataWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetEconomicIndexHistoricalData");

			var localVarPath = "/indices/economic/{identifier}/historical_data/{tag}";
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
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetEconomicIndexHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseEconomicIndexHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseEconomicIndexHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseEconomicIndexHistoricalData)));
		}

		/// <summary>
		///     Historical Data for an Economic Index Returns historical values for the given &#x60;tag&#x60; and the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseEconomicIndexHistoricalData</returns>
		public async Task<ApiResponseEconomicIndexHistoricalData> GetEconomicIndexHistoricalDataAsync(string identifier,
			string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetEconomicIndexHistoricalDataAsyncWithHttpInfo(identifier, tag, type,
				startDate, endDate, sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data for an Economic Index Returns historical values for the given &#x60;tag&#x60; and the Economic
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseEconomicIndexHistoricalData)</returns>
		public async Task<ApiResponse<ApiResponseEconomicIndexHistoricalData>>
			GetEconomicIndexHistoricalDataAsyncWithHttpInfo(string identifier, string tag, string type = null,
				DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null,
				string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetEconomicIndexHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetEconomicIndexHistoricalData");

			var localVarPath = "/indices/economic/{identifier}/historical_data/{tag}";
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
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetEconomicIndexHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseEconomicIndexHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseEconomicIndexHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseEconomicIndexHistoricalData)));
		}

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>SICIndex</returns>
		public SICIndex GetSicIndexById(string identifier)
		{
			var localVarResponse = GetSicIndexByIdWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>ApiResponse of SICIndex</returns>
		public ApiResponse<SICIndex> GetSicIndexByIdWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexById");

			var localVarPath = "/indices/sic/{identifier}";
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
				var exception = ExceptionFactory("GetSicIndexById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<SICIndex>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(SICIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SICIndex)));
		}

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of SICIndex</returns>
		public async Task<SICIndex> GetSicIndexByIdAsync(string identifier)
		{
			var localVarResponse = await GetSicIndexByIdAsyncWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (SICIndex)</returns>
		public async Task<ApiResponse<SICIndex>> GetSicIndexByIdAsyncWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexById");

			var localVarPath = "/indices/sic/{identifier}";
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
				var exception = ExceptionFactory("GetSicIndexById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<SICIndex>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(SICIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SICIndex)));
		}

		/// <summary>
		///     Data Point (Number) for an SIC Index Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with
		///     the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>decimal?</returns>
		public decimal? GetSicIndexDataPointNumber(string identifier, string tag)
		{
			var localVarResponse = GetSicIndexDataPointNumberWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Number) for an SIC Index Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with
		///     the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of decimal?</returns>
		public ApiResponse<decimal?> GetSicIndexDataPointNumberWithHttpInfo(string identifier, string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointNumber");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetSicIndexDataPointNumber");

			var localVarPath = "/indices/sic/{identifier}/data_point/{tag}/number";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetSicIndexDataPointNumber", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<decimal?>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
		}

		/// <summary>
		///     Data Point (Number) for an SIC Index Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with
		///     the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of decimal?</returns>
		public async Task<decimal?> GetSicIndexDataPointNumberAsync(string identifier, string tag)
		{
			var localVarResponse = await GetSicIndexDataPointNumberAsyncWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Number) for an SIC Index Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with
		///     the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (decimal?)</returns>
		public async Task<ApiResponse<decimal?>> GetSicIndexDataPointNumberAsyncWithHttpInfo(string identifier,
			string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointNumber");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetSicIndexDataPointNumber");

			var localVarPath = "/indices/sic/{identifier}/data_point/{tag}/number";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetSicIndexDataPointNumber", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<decimal?>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
		}

		/// <summary>
		///     Data Point (Text) for an SIC Index Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>string</returns>
		public string GetSicIndexDataPointText(string identifier, string tag)
		{
			var localVarResponse = GetSicIndexDataPointTextWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Text) for an SIC Index Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of string</returns>
		public ApiResponse<string> GetSicIndexDataPointTextWithHttpInfo(string identifier, string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointText");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetSicIndexDataPointText");

			var localVarPath = "/indices/sic/{identifier}/data_point/{tag}/text";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetSicIndexDataPointText", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<string>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
		}

		/// <summary>
		///     Data Point (Text) for an SIC Index Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of string</returns>
		public async Task<string> GetSicIndexDataPointTextAsync(string identifier, string tag)
		{
			var localVarResponse = await GetSicIndexDataPointTextAsyncWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Text) for an SIC Index Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (string)</returns>
		public async Task<ApiResponse<string>> GetSicIndexDataPointTextAsyncWithHttpInfo(string identifier, string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexDataPointText");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetSicIndexDataPointText");

			var localVarPath = "/indices/sic/{identifier}/data_point/{tag}/text";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetSicIndexDataPointText", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<string>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
		}

		/// <summary>
		///     Historical Data for an SIC Index Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSICIndexHistoricalData</returns>
		public ApiResponseSICIndexHistoricalData GetSicIndexHistoricalData(string identifier, string tag,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetSicIndexHistoricalDataWithHttpInfo(identifier, tag, type, startDate, endDate,
				sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data for an SIC Index Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSICIndexHistoricalData</returns>
		public ApiResponse<ApiResponseSICIndexHistoricalData> GetSicIndexHistoricalDataWithHttpInfo(string identifier,
			string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetSicIndexHistoricalData");

			var localVarPath = "/indices/sic/{identifier}/historical_data/{tag}";
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
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetSicIndexHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseSICIndexHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseSICIndexHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseSICIndexHistoricalData)));
		}

		/// <summary>
		///     Historical Data for an SIC Index Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSICIndexHistoricalData</returns>
		public async Task<ApiResponseSICIndexHistoricalData> GetSicIndexHistoricalDataAsync(string identifier,
			string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetSicIndexHistoricalDataAsyncWithHttpInfo(identifier, tag, type, startDate,
				endDate, sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data for an SIC Index Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the
		///     given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSICIndexHistoricalData)</returns>
		public async Task<ApiResponse<ApiResponseSICIndexHistoricalData>> GetSicIndexHistoricalDataAsyncWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetSicIndexHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetSicIndexHistoricalData");

			var localVarPath = "/indices/sic/{identifier}/historical_data/{tag}";
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
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetSicIndexHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseSICIndexHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseSICIndexHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseSICIndexHistoricalData)));
		}

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>StockMarketIndex</returns>
		public StockMarketIndex GetStockMarketIndexById(string identifier)
		{
			var localVarResponse = GetStockMarketIndexByIdWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>ApiResponse of StockMarketIndex</returns>
		public ApiResponse<StockMarketIndex> GetStockMarketIndexByIdWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexById");

			var localVarPath = "/indices/stock_market/{identifier}";
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
				var exception = ExceptionFactory("GetStockMarketIndexById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<StockMarketIndex>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(StockMarketIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockMarketIndex)));
		}

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of StockMarketIndex</returns>
		public async Task<StockMarketIndex> GetStockMarketIndexByIdAsync(string identifier)
		{
			var localVarResponse = await GetStockMarketIndexByIdAsyncWithHttpInfo(identifier);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (StockMarketIndex)</returns>
		public async Task<ApiResponse<StockMarketIndex>> GetStockMarketIndexByIdAsyncWithHttpInfo(string identifier)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexById");

			var localVarPath = "/indices/stock_market/{identifier}";
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
				var exception = ExceptionFactory("GetStockMarketIndexById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<StockMarketIndex>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(StockMarketIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockMarketIndex)));
		}

		/// <summary>
		///     Data Point (Number) for Stock Market Index Returns a numeric value for the given &#x60;tag&#x60; for the Stock
		///     Market Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>decimal?</returns>
		public decimal? GetStockMarketIndexDataPointNumber(string identifier, string tag)
		{
			var localVarResponse = GetStockMarketIndexDataPointNumberWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Number) for Stock Market Index Returns a numeric value for the given &#x60;tag&#x60; for the Stock
		///     Market Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of decimal?</returns>
		public ApiResponse<decimal?> GetStockMarketIndexDataPointNumberWithHttpInfo(string identifier, string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointNumber");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetStockMarketIndexDataPointNumber");

			var localVarPath = "/indices/stock_market/{identifier}/data_point/{tag}/number";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetStockMarketIndexDataPointNumber", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<decimal?>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
		}

		/// <summary>
		///     Data Point (Number) for Stock Market Index Returns a numeric value for the given &#x60;tag&#x60; for the Stock
		///     Market Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of decimal?</returns>
		public async Task<decimal?> GetStockMarketIndexDataPointNumberAsync(string identifier, string tag)
		{
			var localVarResponse = await GetStockMarketIndexDataPointNumberAsyncWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Number) for Stock Market Index Returns a numeric value for the given &#x60;tag&#x60; for the Stock
		///     Market Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (decimal?)</returns>
		public async Task<ApiResponse<decimal?>> GetStockMarketIndexDataPointNumberAsyncWithHttpInfo(string identifier,
			string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointNumber");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetStockMarketIndexDataPointNumber");

			var localVarPath = "/indices/stock_market/{identifier}/data_point/{tag}/number";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetStockMarketIndexDataPointNumber", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<decimal?>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
		}

		/// <summary>
		///     Data Point (Text) for Stock Market Index Returns a text value for the given &#x60;tag&#x60; for the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>string</returns>
		public string GetStockMarketIndexDataPointText(string identifier, string tag)
		{
			var localVarResponse = GetStockMarketIndexDataPointTextWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Text) for Stock Market Index Returns a text value for the given &#x60;tag&#x60; for the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of string</returns>
		public ApiResponse<string> GetStockMarketIndexDataPointTextWithHttpInfo(string identifier, string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointText");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetStockMarketIndexDataPointText");

			var localVarPath = "/indices/stock_market/{identifier}/data_point/{tag}/text";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetStockMarketIndexDataPointText", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<string>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
		}

		/// <summary>
		///     Data Point (Text) for Stock Market Index Returns a text value for the given &#x60;tag&#x60; for the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of string</returns>
		public async Task<string> GetStockMarketIndexDataPointTextAsync(string identifier, string tag)
		{
			var localVarResponse = await GetStockMarketIndexDataPointTextAsyncWithHttpInfo(identifier, tag);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Data Point (Text) for Stock Market Index Returns a text value for the given &#x60;tag&#x60; for the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (string)</returns>
		public async Task<ApiResponse<string>> GetStockMarketIndexDataPointTextAsyncWithHttpInfo(string identifier,
			string tag)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexDataPointText");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetStockMarketIndexDataPointText");

			var localVarPath = "/indices/stock_market/{identifier}/data_point/{tag}/text";
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
				"text/plain; charset=utf-8"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

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
				var exception = ExceptionFactory("GetStockMarketIndexDataPointText", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<string>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
		}

		/// <summary>
		///     Historical Data for Stock Market Index Returns historical values for the given &#x60;tag&#x60; and the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockMarketIndexHistoricalData</returns>
		public ApiResponseStockMarketIndexHistoricalData GetStockMarketIndexHistoricalData(string identifier,
			string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetStockMarketIndexHistoricalDataWithHttpInfo(identifier, tag, type, startDate,
				endDate, sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data for Stock Market Index Returns historical values for the given &#x60;tag&#x60; and the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockMarketIndexHistoricalData</returns>
		public ApiResponse<ApiResponseStockMarketIndexHistoricalData> GetStockMarketIndexHistoricalDataWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetStockMarketIndexHistoricalData");

			var localVarPath = "/indices/stock_market/{identifier}/historical_data/{tag}";
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
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetStockMarketIndexHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockMarketIndexHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockMarketIndexHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockMarketIndexHistoricalData)));
		}

		/// <summary>
		///     Historical Data for Stock Market Index Returns historical values for the given &#x60;tag&#x60; and the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockMarketIndexHistoricalData</returns>
		public async Task<ApiResponseStockMarketIndexHistoricalData> GetStockMarketIndexHistoricalDataAsync(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetStockMarketIndexHistoricalDataAsyncWithHttpInfo(identifier, tag, type,
				startDate, endDate, sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data for Stock Market Index Returns historical values for the given &#x60;tag&#x60; and the Stock Market
		///     Index with the given &#x60;identifier&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockMarketIndexHistoricalData)</returns>
		public async Task<ApiResponse<ApiResponseStockMarketIndexHistoricalData>>
			GetStockMarketIndexHistoricalDataAsyncWithHttpInfo(string identifier, string tag, string type = null,
				DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null,
				string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling IndexApi->GetStockMarketIndexHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling IndexApi->GetStockMarketIndexHistoricalData");

			var localVarPath = "/indices/stock_market/{identifier}/historical_data/{tag}";
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
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetStockMarketIndexHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockMarketIndexHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockMarketIndexHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockMarketIndexHistoricalData)));
		}

		/// <summary>
		///     Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseEconomicIndicesSearch</returns>
		public ApiResponseEconomicIndicesSearch SearchEconomicIndices(string query, int? pageSize = null)
		{
			var localVarResponse = SearchEconomicIndicesWithHttpInfo(query, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseEconomicIndicesSearch</returns>
		public ApiResponse<ApiResponseEconomicIndicesSearch> SearchEconomicIndicesWithHttpInfo(string query,
			int? pageSize = null)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400,
					"Missing required parameter 'query' when calling IndexApi->SearchEconomicIndices");

			var localVarPath = "/indices/economic/search";
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
				var exception = ExceptionFactory("SearchEconomicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseEconomicIndicesSearch>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseEconomicIndicesSearch) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseEconomicIndicesSearch)));
		}

		/// <summary>
		///     Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseEconomicIndicesSearch</returns>
		public async Task<ApiResponseEconomicIndicesSearch> SearchEconomicIndicesAsync(string query,
			int? pageSize = null)
		{
			var localVarResponse = await SearchEconomicIndicesAsyncWithHttpInfo(query, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search Economic Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseEconomicIndicesSearch)</returns>
		public async Task<ApiResponse<ApiResponseEconomicIndicesSearch>> SearchEconomicIndicesAsyncWithHttpInfo(
			string query, int? pageSize = null)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400,
					"Missing required parameter 'query' when calling IndexApi->SearchEconomicIndices");

			var localVarPath = "/indices/economic/search";
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
				var exception = ExceptionFactory("SearchEconomicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseEconomicIndicesSearch>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseEconomicIndicesSearch) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseEconomicIndicesSearch)));
		}

		/// <summary>
		///     Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseSICIndicesSearch</returns>
		public ApiResponseSICIndicesSearch SearchSicIndices(string query, int? pageSize = null)
		{
			var localVarResponse = SearchSicIndicesWithHttpInfo(query, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseSICIndicesSearch</returns>
		public ApiResponse<ApiResponseSICIndicesSearch> SearchSicIndicesWithHttpInfo(string query, int? pageSize = null)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400,
					"Missing required parameter 'query' when calling IndexApi->SearchSicIndices");

			var localVarPath = "/indices/sic/search";
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
				var exception = ExceptionFactory("SearchSicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseSICIndicesSearch>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseSICIndicesSearch) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseSICIndicesSearch)));
		}

		/// <summary>
		///     Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseSICIndicesSearch</returns>
		public async Task<ApiResponseSICIndicesSearch> SearchSicIndicesAsync(string query, int? pageSize = null)
		{
			var localVarResponse = await SearchSicIndicesAsyncWithHttpInfo(query, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search SIC Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseSICIndicesSearch)</returns>
		public async Task<ApiResponse<ApiResponseSICIndicesSearch>> SearchSicIndicesAsyncWithHttpInfo(string query,
			int? pageSize = null)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400,
					"Missing required parameter 'query' when calling IndexApi->SearchSicIndices");

			var localVarPath = "/indices/sic/search";
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
				var exception = ExceptionFactory("SearchSicIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseSICIndicesSearch>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseSICIndicesSearch) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseSICIndicesSearch)));
		}

		/// <summary>
		///     Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseStockMarketIndicesSearch</returns>
		public ApiResponseStockMarketIndicesSearch SearchStockMarketsIndices(string query, int? pageSize = null)
		{
			var localVarResponse = SearchStockMarketsIndicesWithHttpInfo(query, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseStockMarketIndicesSearch</returns>
		public ApiResponse<ApiResponseStockMarketIndicesSearch> SearchStockMarketsIndicesWithHttpInfo(string query,
			int? pageSize = null)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400,
					"Missing required parameter 'query' when calling IndexApi->SearchStockMarketsIndices");

			var localVarPath = "/indices/stock_market/search";
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
				var exception = ExceptionFactory("SearchStockMarketsIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockMarketIndicesSearch>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockMarketIndicesSearch) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockMarketIndicesSearch)));
		}

		/// <summary>
		///     Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseStockMarketIndicesSearch</returns>
		public async Task<ApiResponseStockMarketIndicesSearch> SearchStockMarketsIndicesAsync(string query,
			int? pageSize = null)
		{
			var localVarResponse = await SearchStockMarketsIndicesAsyncWithHttpInfo(query, pageSize);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Search Stock Market Indices Searches for indices using the text in &#x60;query&#x60;
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockMarketIndicesSearch)</returns>
		public async Task<ApiResponse<ApiResponseStockMarketIndicesSearch>> SearchStockMarketsIndicesAsyncWithHttpInfo(
			string query, int? pageSize = null)
		{
			// verify the required parameter 'query' is set
			if (query == null)
				throw new ApiException(400,
					"Missing required parameter 'query' when calling IndexApi->SearchStockMarketsIndices");

			var localVarPath = "/indices/stock_market/search";
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
				var exception = ExceptionFactory("SearchStockMarketsIndices", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStockMarketIndicesSearch>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStockMarketIndicesSearch) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStockMarketIndicesSearch)));
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