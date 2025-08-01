// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.Item;
using Soenneker.DNSimple.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals
{
    /// <summary>
    /// Builds and executes requests for operations under \{account}\domains\{domain}\certificates\letsencrypt\{certificate-id}\renewals
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RenewalsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.DNSimple.OpenApiClient.item.domains.item.certificates.letsencrypt.item.renewals.item collection</summary>
        /// <param name="position">The certificate renewal order id received by `purchaseRenewalLetsencryptCertificate`.</param>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.Item.WithRenewalItemRequestBuilder"/></returns>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.Item.WithRenewalItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("renewalId", position);
                return new global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.Item.WithRenewalItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.DNSimple.OpenApiClient.item.domains.item.certificates.letsencrypt.item.renewals.item collection</summary>
        /// <param name="position">The certificate renewal order id received by `purchaseRenewalLetsencryptCertificate`.</param>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.Item.WithRenewalItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.Item.WithRenewalItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("renewalId", position);
                return new global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.Item.WithRenewalItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RenewalsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/domains/{domain}/certificates/letsencrypt/{certificate%2Did}/renewals", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RenewalsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/domains/{domain}/certificates/letsencrypt/{certificate%2Did}/renewals", rawUrl)
        {
        }
        /// <summary>
        /// Renews a [Let&apos;s Encrypt](https://dnsimple.com/letsencrypt) certificate ordered with DNSimple.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Renewals404Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostResponse?> PostAsRenewalsPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostResponse> PostAsRenewalsPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.DNSimple.OpenApiClient.Models.Renewals404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Renews a [Let&apos;s Encrypt](https://dnsimple.com/letsencrypt) certificate ordered with DNSimple.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.DNSimple.OpenApiClient.Models.Renewals404Error">When receiving a 404 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsRenewalsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsResponse?> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsResponse> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.DNSimple.OpenApiClient.Models.Renewals404Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Renews a [Let&apos;s Encrypt](https://dnsimple.com/letsencrypt) certificate ordered with DNSimple.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.Item.Renewals.RenewalsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RenewalsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
