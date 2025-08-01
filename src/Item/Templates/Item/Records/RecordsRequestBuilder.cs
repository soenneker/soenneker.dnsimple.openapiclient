// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records
{
    /// <summary>
    /// Builds and executes requests for operations under \{account}\templates\{template}\records
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RecordsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.DNSimple.OpenApiClient.item.templates.item.records.item collection</summary>
        /// <param name="position">The template record id</param>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.Item.WithTemplaterecordItemRequestBuilder"/></returns>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.Item.WithTemplaterecordItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("templaterecord", position);
                return new global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.Item.WithTemplaterecordItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.DNSimple.OpenApiClient.item.templates.item.records.item collection</summary>
        /// <param name="position">The template record id</param>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.Item.WithTemplaterecordItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.Item.WithTemplaterecordItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("templaterecord", position);
                return new global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.Item.WithTemplaterecordItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecordsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/templates/{template}/records{?sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecordsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/{account}/templates/{template}/records{?sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the records for a template.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsGetResponse?> GetAsRecordsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder.RecordsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsGetResponse> GetAsRecordsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder.RecordsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsGetResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the records for a template.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsRecordsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder.RecordsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder.RecordsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new template record.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostResponse?> PostAsRecordsPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostResponse> PostAsRecordsPostResponseAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new template record.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsRecordsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse?> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse> PostAsync(global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse>(requestInfo, global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the records for a template.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder.RecordsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder.RecordsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new template record.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the records for a template.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RecordsRequestBuilderGetQueryParameters 
        {
            /// <summary>Sort results. Default sorting is by id ascending.</summary>
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
            /// <summary>Sort results. Default sorting is by id ascending.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RecordsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.DNSimple.OpenApiClient.Item.Templates.Item.Records.RecordsRequestBuilder.RecordsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RecordsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
