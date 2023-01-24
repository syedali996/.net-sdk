// <copyright file="PetstoreBooksAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PetstoreBooksAPI.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using PetstoreBooksAPI.Standard.Authentication;
    using PetstoreBooksAPI.Standard.Controllers;
    using PetstoreBooksAPI.Standard.Http.Client;
    using PetstoreBooksAPI.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class PetstoreBooksAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Server, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Server, string>>
        {
            {
                Environment.Production, new Dictionary<Server, string>
                {
                    { Server.Default, "https://api.nytimes.com/svc/books/v3" },
                    { Server.Server1, "https://petstore.swagger.io/v2" },
                    { Server.Server2, "http://petstore.swagger.io/v2" },
                    { Server.AuthServer, "https://petstore.swagger.io/oauth" },
                }
            },
        };

        private readonly IDictionary<string, IAuthManager> authManagers;
        private readonly IHttpClient httpClient;
        private readonly CustomQueryAuthenticationManager customQueryAuthenticationManager;

        private readonly Lazy<APIController> client;
        private readonly Lazy<PetController> pet;
        private readonly Lazy<StoreController> store;
        private readonly Lazy<UserController> user;

        private PetstoreBooksAPIClient(
            Environment environment,
            string apiKey,
            IDictionary<string, IAuthManager> authManagers,
            IHttpClient httpClient,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpClient = httpClient;
            this.authManagers = (authManagers == null) ? new Dictionary<string, IAuthManager>() : new Dictionary<string, IAuthManager>(authManagers);
            this.HttpClientConfiguration = httpClientConfiguration;

            this.client = new Lazy<APIController>(
                () => new APIController(this, this.httpClient, this.authManagers));
            this.pet = new Lazy<PetController>(
                () => new PetController(this, this.httpClient, this.authManagers));
            this.store = new Lazy<StoreController>(
                () => new StoreController(this, this.httpClient, this.authManagers));
            this.user = new Lazy<UserController>(
                () => new UserController(this, this.httpClient, this.authManagers));

            if (this.authManagers.ContainsKey("global"))
            {
                this.customQueryAuthenticationManager = (CustomQueryAuthenticationManager)this.authManagers["global"];
            }

            if (!this.authManagers.ContainsKey("global")
                || !this.CustomQueryAuthenticationCredentials.Equals(apiKey))
            {
                this.customQueryAuthenticationManager = new CustomQueryAuthenticationManager(apiKey);
                this.authManagers["global"] = this.customQueryAuthenticationManager;
            }
        }

        /// <summary>
        /// Gets APIController controller.
        /// </summary>
        public APIController APIController => this.client.Value;

        /// <summary>
        /// Gets PetController controller.
        /// </summary>
        public PetController PetController => this.pet.Value;

        /// <summary>
        /// Gets StoreController controller.
        /// </summary>
        public StoreController StoreController => this.store.Value;

        /// <summary>
        /// Gets UserController controller.
        /// </summary>
        public UserController UserController => this.user.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets auth managers.
        /// </summary>
        internal IDictionary<string, IAuthManager> AuthManagers => this.authManagers;

        /// <summary>
        /// Gets http client.
        /// </summary>
        internal IHttpClient HttpClient => this.httpClient;

        /// <summary>
        /// Gets the credentials to use with CustomQueryAuthentication.
        /// </summary>
        public ICustomQueryAuthenticationCredentials CustomQueryAuthenticationCredentials => this.customQueryAuthenticationManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            StringBuilder url = new StringBuilder(EnvironmentsMap[this.Environment][alias]);
            ApiHelper.AppendUrlWithTemplateParameters(url, this.GetBaseUriParameters());

            return url.ToString();
        }

        /// <summary>
        /// Creates an object of the PetstoreBooksAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .CustomQueryAuthenticationCredentials(this.customQueryAuthenticationManager.ApiKey)
                .HttpClient(this.httpClient)
                .AuthManagers(this.authManagers)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> PetstoreBooksAPIClient.</returns>
        internal static PetstoreBooksAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("PETSTORE_BOOKS_API_STANDARD_ENVIRONMENT");
            string apiKey = System.Environment.GetEnvironmentVariable("PETSTORE_BOOKS_API_STANDARD_API_KEY");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (apiKey != null)
            {
                builder.CustomQueryAuthenticationCredentials(apiKey);
            }

            return builder.Build();
        }

        /// <summary>
        /// Makes a list of the BaseURL parameters.
        /// </summary>
        /// <returns>Returns the parameters list.</returns>
        private List<KeyValuePair<string, object>> GetBaseUriParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = PetstoreBooksAPI.Standard.Environment.Production;
            private string apiKey = "S36VNES3R5jDxeBwfdVeWvqKUQoWem8l";
            private IDictionary<string, IAuthManager> authManagers = new Dictionary<string, IAuthManager>();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private IHttpClient httpClient;

            /// <summary>
            /// Sets credentials for CustomQueryAuthentication.
            /// </summary>
            /// <param name="apiKey">ApiKey.</param>
            /// <returns>Builder.</returns>
            public Builder CustomQueryAuthenticationCredentials(string apiKey)
            {
                this.apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

            /// <summary>
            /// Sets the IHttpClient for the Builder.
            /// </summary>
            /// <param name="httpClient"> http client. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpClient(IHttpClient httpClient)
            {
                this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            /// <summary>
            /// Sets the authentication managers for the Builder.
            /// </summary>
            /// <param name="authManagers"> auth managers. </param>
            /// <returns>Builder.</returns>
            internal Builder AuthManagers(IDictionary<string, IAuthManager> authManagers)
            {
                this.authManagers = authManagers ?? throw new ArgumentNullException(nameof(authManagers));
                return this;
            }

            /// <summary>
            /// Creates an object of the PetstoreBooksAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>PetstoreBooksAPIClient.</returns>
            public PetstoreBooksAPIClient Build()
            {
                this.httpClient = new HttpClientWrapper(this.httpClientConfig.Build());

                return new PetstoreBooksAPIClient(
                    this.environment,
                    this.apiKey,
                    this.authManagers,
                    this.httpClient,
                    this.httpClientConfig.Build());
            }
        }
    }
}
