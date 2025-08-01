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
    public partial class ChargeItem : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; set; }
#nullable restore
#else
        public string Amount { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The ID of the product that was charged. Null when the product type is &quot;manual&quot;.</summary>
        public int? ProductId { get; set; }
        /// <summary>A unique or representative reference. For example, the domain name that was charged.Or the ID of the subscription or the order ID of the product. Null when the producttype is &quot;manual&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductReference { get; set; }
#nullable restore
#else
        public string ProductReference { get; set; }
#endif
        /// <summary>The type of the product that was charged.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductType { get; set; }
#nullable restore
#else
        public string ProductType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.ChargeItem"/> and sets the default values.
        /// </summary>
        public ChargeItem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.ChargeItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.ChargeItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.ChargeItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amount", n => { Amount = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "product_id", n => { ProductId = n.GetIntValue(); } },
                { "product_reference", n => { ProductReference = n.GetStringValue(); } },
                { "product_type", n => { ProductType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("amount", Amount);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("product_id", ProductId);
            writer.WriteStringValue("product_reference", ProductReference);
            writer.WriteStringValue("product_type", ProductType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
