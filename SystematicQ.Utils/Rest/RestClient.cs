using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SystematicQ.Utils.Rest
{
    /// <summary>
    /// Restfull util class for generic request calls
    /// </summary>
    public static class RestClient
    {
        /// <summary>
        /// Execute endpoint 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="endpoint"></param>
        /// <param name="requestParams"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        public static async Task<IResponse<T>> ExecuteEndpointAsync<T>(Method method, string endpoint, Dictionary<string, object> requestParams, Dictionary<string, string> headers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// excute endpoint
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="method"></param>
        /// <param name="endpoint"></param>
        /// <param name="requestBody"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        public static async Task<IResponse<T>> ExecuteEndpointAsync<T>(Method method, string endpoint, object requestBody, Dictionary<string, string> headers)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResponse<T>> ExecuteEndpointAsync<T>(Method method, string endpoint, IRequest request, Dictionary<string, string> headers)
        {
            throw new NotImplementedException();
        }
    }
}
