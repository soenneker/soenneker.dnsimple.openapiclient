// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.DNSimple.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink
{
    /// <summary>
    /// Builds and executes requests for operations under \{account}\secondary_dns\primaries\{primaryserver}\unlink
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UnlinkRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnlinkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/secondary_dns/primaries/{primaryserver}/unlink", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnlinkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/secondary_dns/primaries/{primaryserver}/unlink", rawUrl)
        {
        }
        /// <summary>
        /// Unlink the primary server from a secondary zone.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkPutResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Unlink400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Unlink404Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkPutResponse?> PutAsUnlinkPutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkPutResponse> PutAsUnlinkPutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.DNSimple.OpenApiClient.Models.Unlink400Error.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.DNSimple.OpenApiClient.Models.Unlink404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkPutResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Unlink the primary server from a secondary zone.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Unlink400Error">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Unlink404Error">When receiving a 404 status code</exception>
        [Obsolete("This method is obsolete. Use PutAsUnlinkPutResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkResponse?> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkResponse> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.DNSimple.OpenApiClient.Models.Unlink400Error.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.DNSimple.OpenApiClient.Models.Unlink404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Unlink the primary server from a secondary zone.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.DNSimple.OpenApiClient.Item.Secondary_dns.Primaries.Item.Unlink.UnlinkRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UnlinkRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
