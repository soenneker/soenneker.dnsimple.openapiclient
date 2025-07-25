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
    public partial class Service : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A date-time value, representing when the entry was created, formatted as ISO 8601.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The default subdomain used when creating DNS records</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultSubdomain { get; set; }
#nullable restore
#else
        public string DefaultSubdomain { get; set; }
#endif
        /// <summary>A human-readable description of the one-click service</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>A unique identifier</summary>
        public int? Id { get; set; }
        /// <summary>A human-readable name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Flag indicating whether setup is required</summary>
        public bool? RequiresSetup { get; set; }
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.DNSimple.OpenApiClient.Models.ServiceSetting>? Settings { get; set; }
#nullable restore
#else
        public List<global::Soenneker.DNSimple.OpenApiClient.Models.ServiceSetting> Settings { get; set; }
#endif
        /// <summary>Describes setup requirements</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SetupDescription { get; set; }
#nullable restore
#else
        public string SetupDescription { get; set; }
#endif
        /// <summary>A string identifier that can be used in URLs (always lowercase)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sid { get; set; }
#nullable restore
#else
        public string Sid { get; set; }
#endif
        /// <summary>A date-time value, representing when the entry was last updated, formatted as ISO 8601.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.Service"/> and sets the default values.
        /// </summary>
        public Service()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.Service"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.Service CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.Service();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "default_subdomain", n => { DefaultSubdomain = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "requires_setup", n => { RequiresSetup = n.GetBoolValue(); } },
                { "settings", n => { Settings = n.GetCollectionOfObjectValues<global::Soenneker.DNSimple.OpenApiClient.Models.ServiceSetting>(global::Soenneker.DNSimple.OpenApiClient.Models.ServiceSetting.CreateFromDiscriminatorValue)?.AsList(); } },
                { "setup_description", n => { SetupDescription = n.GetStringValue(); } },
                { "sid", n => { Sid = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("default_subdomain", DefaultSubdomain);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("requires_setup", RequiresSetup);
            writer.WriteCollectionOfObjectValues<global::Soenneker.DNSimple.OpenApiClient.Models.ServiceSetting>("settings", Settings);
            writer.WriteStringValue("setup_description", SetupDescription);
            writer.WriteStringValue("sid", Sid);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
