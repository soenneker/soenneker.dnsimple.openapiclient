// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.DNSimple.OpenApiClient.Item.Domains.Item;
using Soenneker.DNSimple.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Item.Domains
{
    /// <summary>
    /// Builds and executes requests for operations under \{account}\domains
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DomainsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.DNSimple.OpenApiClient.item.domains.item collection</summary>
        /// <param name="position">The domain name or id</param>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.WithDomainItemRequestBuilder"/></returns>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.WithDomainItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("domain", position);
                return new global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.WithDomainItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DomainsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/domains{?name_like*,registrant_id*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DomainsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/domains{?name_like*,registrant_id*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the domains in the account.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsGetResponse?> GetAsDomainsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsGetResponse> GetAsDomainsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsGetResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the domains in the account.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsDomainsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a domain and the corresponding zone into the account.When creating a domain using Solo or Teams subscription, the DNS servicesfor the zone will be automatically enabled and this will be charged on yourfollowing subscription renewal invoices.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Domains400Error">When receiving a 400 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostResponse?> PostAsDomainsPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostResponse> PostAsDomainsPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.DNSimple.OpenApiClient.Models.Domains400Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a domain and the corresponding zone into the account.When creating a domain using Solo or Teams subscription, the DNS servicesfor the zone will be automatically enabled and this will be charged on yourfollowing subscription renewal invoices.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Domains400Error">When receiving a 400 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsDomainsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse?> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.DNSimple.OpenApiClient.Models.Domains400Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the domains in the account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a domain and the corresponding zone into the account.When creating a domain using Solo or Teams subscription, the DNS servicesfor the zone will be automatically enabled and this will be charged on yourfollowing subscription renewal invoices.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the domains in the account.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DomainsRequestBuilderGetQueryParameters 
        {
            /// <summary>Only include results with a name field containing the given string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name_like")]
            public string? NameLike { get; set; }
#nullable restore
#else
            [QueryParameter("name_like")]
            public string NameLike { get; set; }
#endif
            /// <summary>Only include results with the registrant_id field matching the given value</summary>
            [QueryParameter("registrant_id")]
            public int? RegistrantId { get; set; }
            /// <summary>Sort results. Default sorting is ascending by name.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>Sort results. Default sorting is ascending by name.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.DNSimple.OpenApiClient.Item.Domains.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DomainsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.DomainsRequestBuilder.DomainsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DomainsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
