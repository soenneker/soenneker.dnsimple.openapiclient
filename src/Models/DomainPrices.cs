// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DomainPrices : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The domain name that was checked.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; set; }
#nullable restore
#else
        public string Domain { get; set; }
#endif
        /// <summary>True if the domain is a premium domain and thus will have a non-standard registration, renewal, and/or transfer fee.</summary>
        public bool? Premium { get; set; }
        /// <summary>The domain registration price represented as a USD amount with dollars and cents.</summary>
        public float? RegistrationPrice { get; set; }
        /// <summary>The domain renewal price represented as a USD amount with dollars and cents.</summary>
        public float? RenewalPrice { get; set; }
        /// <summary>The domain restore price represented as a USD amount with dollars and cents.</summary>
        public float? RestorePrice { get; set; }
        /// <summary>The domain transfer price represented as a USD amount with dollars and cents.</summary>
        public float? TransferPrice { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.DomainPrices"/> and sets the default values.
        /// </summary>
        public DomainPrices()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.DomainPrices"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.DomainPrices CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.DomainPrices();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "domain", n => { Domain = n.GetStringValue(); } },
                { "premium", n => { Premium = n.GetBoolValue(); } },
                { "registration_price", n => { RegistrationPrice = n.GetFloatValue(); } },
                { "renewal_price", n => { RenewalPrice = n.GetFloatValue(); } },
                { "restore_price", n => { RestorePrice = n.GetFloatValue(); } },
                { "transfer_price", n => { TransferPrice = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("domain", Domain);
            writer.WriteBoolValue("premium", Premium);
            writer.WriteFloatValue("registration_price", RegistrationPrice);
            writer.WriteFloatValue("renewal_price", RenewalPrice);
            writer.WriteFloatValue("restore_price", RestorePrice);
            writer.WriteFloatValue("transfer_price", TransferPrice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
