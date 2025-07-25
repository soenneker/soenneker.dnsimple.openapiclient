// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class LetsencryptPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The certificate alternate names</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AlternateNames { get; set; }
#nullable restore
#else
        public List<string> AlternateNames { get; set; }
#endif
        /// <summary>Enable the auto-renewal of the certificate</summary>
        public bool? AutoRenew { get; set; }
        /// <summary>The certificate name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Optional string to determine the signature algorithm to be used. Either `ECDSA` or `RSA`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignatureAlgorithm { get; set; }
#nullable restore
#else
        public string SignatureAlgorithm { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.LetsencryptPostRequestBody"/> and sets the default values.
        /// </summary>
        public LetsencryptPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            Name = "www";
            SignatureAlgorithm = "ECDSA";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.LetsencryptPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.LetsencryptPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Item.Domains.Item.Certificates.Letsencrypt.LetsencryptPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alternate_names", n => { AlternateNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "auto_renew", n => { AutoRenew = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "signature_algorithm", n => { SignatureAlgorithm = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("alternate_names", AlternateNames);
            writer.WriteBoolValue("auto_renew", AutoRenew);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("signature_algorithm", SignatureAlgorithm);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
