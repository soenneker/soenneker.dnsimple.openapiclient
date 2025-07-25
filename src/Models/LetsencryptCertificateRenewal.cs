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
    public partial class LetsencryptCertificateRenewal : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The auto_renew property</summary>
        public bool? AutoRenew { get; set; }
        /// <summary>A date-time value, representing when the entry was created, formatted as ISO 8601.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The new_certificate_id property</summary>
        public int? NewCertificateId { get; set; }
        /// <summary>The old_certificate_id property</summary>
        public int? OldCertificateId { get; set; }
        /// <summary>The state property</summary>
        public global::Soenneker.DNSimple.OpenApiClient.Models.LetsencryptCertificateRenewal_state? State { get; set; }
        /// <summary>A date-time value, representing when the entry was last updated, formatted as ISO 8601.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.LetsencryptCertificateRenewal"/> and sets the default values.
        /// </summary>
        public LetsencryptCertificateRenewal()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.LetsencryptCertificateRenewal"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.LetsencryptCertificateRenewal CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.LetsencryptCertificateRenewal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auto_renew", n => { AutoRenew = n.GetBoolValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "new_certificate_id", n => { NewCertificateId = n.GetIntValue(); } },
                { "old_certificate_id", n => { OldCertificateId = n.GetIntValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.LetsencryptCertificateRenewal_state>(); } },
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
            writer.WriteBoolValue("auto_renew", AutoRenew);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteIntValue("new_certificate_id", NewCertificateId);
            writer.WriteIntValue("old_certificate_id", OldCertificateId);
            writer.WriteEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.LetsencryptCertificateRenewal_state>("state", State);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
