// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.Item;
using Soenneker.DNSimple.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores
{
    /// <summary>
    /// Builds and executes requests for operations under \{account}\registrar\domains\{domain}\restores
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RestoresRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.DNSimple.OpenApiClient.item.registrar.domains.item.restores.item collection</summary>
        /// <param name="position">The domain restore id</param>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.Item.WithDomainrestoreItemRequestBuilder"/></returns>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.Item.WithDomainrestoreItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("domainrestore", position);
                return new global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.Item.WithDomainrestoreItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.DNSimple.OpenApiClient.item.registrar.domains.item.restores.item collection</summary>
        /// <param name="position">The domain restore id</param>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.Item.WithDomainrestoreItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.Item.WithDomainrestoreItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("domainrestore", position);
                return new global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.Item.WithDomainrestoreItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RestoresRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/registrar/domains/{domain}/restores", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RestoresRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/registrar/domains/{domain}/restores", rawUrl)
        {
        }
        /// <summary>
        /// Explicitly restores an domain that can not be renewed anymore, if the registry supports this function.Your account must be active for this command to complete successfully. You will be automatically charged the restore fee upon successful restore, so please be careful with this command.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Restores400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Restores401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Restores404Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostResponse?> PostAsRestoresPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostResponse> PostAsRestoresPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.DNSimple.OpenApiClient.Models.Restores400Error.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.DNSimple.OpenApiClient.Models.Restores401Error.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.DNSimple.OpenApiClient.Models.Restores404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Explicitly restores an domain that can not be renewed anymore, if the registry supports this function.Your account must be active for this command to complete successfully. You will be automatically charged the restore fee upon successful restore, so please be careful with this command.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Restores400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Restores401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Restores404Error">When receiving a 404 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsRestoresPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresResponse?> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresResponse> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.DNSimple.OpenApiClient.Models.Restores400Error.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.DNSimple.OpenApiClient.Models.Restores401Error.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.DNSimple.OpenApiClient.Models.Restores404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Explicitly restores an domain that can not be renewed anymore, if the registry supports this function.Your account must be active for this command to complete successfully. You will be automatically charged the restore fee upon successful restore, so please be careful with this command.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.DNSimple.OpenApiClient.Item.Registrar.Domains.Item.Restores.RestoresRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RestoresRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
