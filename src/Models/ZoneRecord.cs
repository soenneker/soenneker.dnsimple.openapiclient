// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.DNSimple.OpenApiClient.Models
{
    /// <summary>
    /// A single DNS record in a zone.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ZoneRecord : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content/value of the record (e.g., IP address for A records, hostname for CNAME records).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Content { get; set; }
#nullable restore
#else
        public string Content { get; set; }
#endif
        /// <summary>A date-time value, representing when the entry was created, formatted as ISO 8601.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The unique identifier for the record.</summary>
        public int? Id { get; set; }
        /// <summary>The name of the record (e.g., &quot;www&quot; for www.example.com).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>If present represents the zone record this record relates to. The parent record is the master record, when the parent is updated or deleted the related record is also updated or deleted. An example of child record is the TXT descriptive record created for an ALIAS record.</summary>
        public int? ParentId { get; set; }
        /// <summary>The priority value for MX and SRV records. Lower values have higher priority.</summary>
        public int? Priority { get; set; }
        /// <summary>The regions where this record is active. If empty, the record is active in all regions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecordRegion?>? Regions { get; set; }
#nullable restore
#else
        public List<global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecordRegion?> Regions { get; set; }
#endif
        /// <summary>Returns true if a record is a system generated record and thus is not modifiable.</summary>
        public bool? SystemRecord { get; set; }
        /// <summary>The Time To Live (TTL) value for the entry, in seconds.</summary>
        public int? Ttl { get; set; }
        /// <summary>The type of DNS record. Supported DNS record types are listed below. Note that some record types may only be available on specific plans.</summary>
        public global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecordType? Type { get; set; }
        /// <summary>A date-time value, representing when the entry was last updated, formatted as ISO 8601.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The unique identifier of the zone this record belongs to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ZoneId { get; set; }
#nullable restore
#else
        public string ZoneId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecord"/> and sets the default values.
        /// </summary>
        public ZoneRecord()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "content", n => { Content = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "parent_id", n => { ParentId = n.GetIntValue(); } },
                { "priority", n => { Priority = n.GetIntValue(); } },
                { "regions", n => { Regions = n.GetCollectionOfEnumValues<global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecordRegion>()?.AsList(); } },
                { "system_record", n => { SystemRecord = n.GetBoolValue(); } },
                { "ttl", n => { Ttl = n.GetIntValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecordType>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "zone_id", n => { ZoneId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("content", Content);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("parent_id", ParentId);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfEnumValues<global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecordRegion>("regions", Regions);
            writer.WriteBoolValue("system_record", SystemRecord);
            writer.WriteIntValue("ttl", Ttl);
            writer.WriteEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.ZoneRecordType>("type", Type);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("zone_id", ZoneId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
