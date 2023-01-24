// <copyright file="CustomQueryAuthenticationManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PetstoreBooksAPI.Standard.Authentication
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using PetstoreBooksAPI.Standard.Http.Request;

    /// <summary>
    /// CustomQueryAuthenticationManager.
    /// </summary>
    internal class CustomQueryAuthenticationManager : ICustomQueryAuthenticationCredentials, IAuthManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomQueryAuthenticationManager"/> class.
        /// </summary>
        /// <param name="apiKey">api-key.</param>
        public CustomQueryAuthenticationManager(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Gets string value for apiKey.
        /// </summary>
        public string ApiKey { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="apiKey"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string apiKey)
        {
            return apiKey.Equals(this.ApiKey);
        }

        /// <inheritdoc/>
        public HttpRequest Apply(HttpRequest httpRequest)
        {
            httpRequest.AddQueryParameters(new Dictionary<string, object>
            {
                { "api-key", this.ApiKey },
            });

            return httpRequest;
        }

        /// <inheritdoc/>
        public Task<HttpRequest> ApplyAsync(HttpRequest httpRequest)
        {
            return Task.FromResult(this.Apply(httpRequest));
        }
    }
}
