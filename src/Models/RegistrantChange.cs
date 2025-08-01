// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class RegistrantChange : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account_id property</summary>
        public int? AccountId { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contact_id property</summary>
        public int? ContactId { get; set; }
        /// <summary>A date-time value, representing when the entry was created, formatted as ISO 8601.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The domain_id property</summary>
        public int? DomainId { get; set; }
        /// <summary>The extended_attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.DNSimple.OpenApiClient.Models.TradeExtendedAttributes? ExtendedAttributes { get; set; }
#nullable restore
#else
        public global::Soenneker.DNSimple.OpenApiClient.Models.TradeExtendedAttributes ExtendedAttributes { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>A date value formatted as ISO 8601.</summary>
        public Date? IrtLockLiftedBy { get; set; }
        /// <summary>The registry_owner_change property</summary>
        public bool? RegistryOwnerChange { get; set; }
        /// <summary>The state property</summary>
        public global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChange_state? State { get; set; }
        /// <summary>A date-time value, representing when the entry was last updated, formatted as ISO 8601.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChange"/> and sets the default values.
        /// </summary>
        public RegistrantChange()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChange"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChange CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_id", n => { AccountId = n.GetIntValue(); } },
                { "contact_id", n => { ContactId = n.GetIntValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "domain_id", n => { DomainId = n.GetIntValue(); } },
                { "extended_attributes", n => { ExtendedAttributes = n.GetObjectValue<global::Soenneker.DNSimple.OpenApiClient.Models.TradeExtendedAttributes>(global::Soenneker.DNSimple.OpenApiClient.Models.TradeExtendedAttributes.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "irt_lock_lifted_by", n => { IrtLockLiftedBy = n.GetDateValue(); } },
                { "registry_owner_change", n => { RegistryOwnerChange = n.GetBoolValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChange_state>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("account_id", AccountId);
            writer.WriteIntValue("contact_id", ContactId);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("domain_id", DomainId);
            writer.WriteObjectValue<global::Soenneker.DNSimple.OpenApiClient.Models.TradeExtendedAttributes>("extended_attributes", ExtendedAttributes);
            writer.WriteIntValue("id", Id);
            writer.WriteDateValue("irt_lock_lifted_by", IrtLockLiftedBy);
            writer.WriteBoolValue("registry_owner_change", RegistryOwnerChange);
            writer.WriteEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.RegistrantChange_state>("state", State);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
