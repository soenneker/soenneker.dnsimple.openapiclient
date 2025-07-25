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
    public partial class RegistrantChangeCheck : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contact_id property</summary>
        public int? ContactId { get; set; }
        /// <summary>The domain_id property</summary>
        public int? DomainId { get; set; }
        /// <summary>The extended_attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.DNSimple.OpenApiClient.Models.ExtendedAttribute>? ExtendedAttributes { get; set; }
#nullable restore
#else
        public List<global::Soenneker.DNSimple.OpenApiClient.Models.ExtendedAttribute> ExtendedAttributes { get; set; }
#endif
        /// <summary>The registry_owner_change property</summary>
        public bool? RegistryOwnerChange { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChangeCheck"/> and sets the default values.
        /// </summary>
        public RegistrantChangeCheck()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChangeCheck"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChangeCheck CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChangeCheck();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "contact_id", n => { ContactId = n.GetIntValue(); } },
                { "domain_id", n => { DomainId = n.GetIntValue(); } },
                { "extended_attributes", n => { ExtendedAttributes = n.GetCollectionOfObjectValues<global::Soenneker.DNSimple.OpenApiClient.Models.ExtendedAttribute>(global::Soenneker.DNSimple.OpenApiClient.Models.ExtendedAttribute.CreateFromDiscriminatorValue)?.AsList(); } },
                { "registry_owner_change", n => { RegistryOwnerChange = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("contact_id", ContactId);
            writer.WriteIntValue("domain_id", DomainId);
            writer.WriteCollectionOfObjectValues<global::Soenneker.DNSimple.OpenApiClient.Models.ExtendedAttribute>("extended_attributes", ExtendedAttributes);
            writer.WriteBoolValue("registry_owner_change", RegistryOwnerChange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
