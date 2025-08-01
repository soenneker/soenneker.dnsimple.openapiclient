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
    public partial class TLD : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>true if the suffix requires auto-renewal and can&apos;t be renewed manually</summary>
        public bool? AutoRenewOnly { get; set; }
        /// <summary>type of data interface required for DNSSEC</summary>
        public global::Soenneker.DNSimple.OpenApiClient.Models.TLD_dnssec_interface_type? DnssecInterfaceType { get; set; }
        /// <summary>true if the suffix supports Internationalized Domain Names (IDN)</summary>
        public bool? Idn { get; set; }
        /// <summary>The minimum_registration property</summary>
        public int? MinimumRegistration { get; set; }
        /// <summary>maximum number of name servers allowed for this TLD</summary>
        public int? NameServerMax { get; set; }
        /// <summary>minimum number of name servers required for this TLD</summary>
        public int? NameServerMin { get; set; }
        /// <summary>true if DNSimple supports registrations for this TLD</summary>
        public bool? RegistrationEnabled { get; set; }
        /// <summary>true if DNSimple supports renewals for this TLD</summary>
        public bool? RenewalEnabled { get; set; }
        /// <summary>The registerable suffix. In most cases the suffix matches a TLD, but there are some cases where the suffix is a subzone of the TLD (e.g. com.au).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TldProp { get; set; }
#nullable restore
#else
        public string TldProp { get; set; }
#endif
        /// <summary>TLD types are: * 1 - gTLD (global TLD) * 2 - ccTLD (country-code TLD) * 3 - newTLD (new global TLD)</summary>
        public int? TldType { get; set; }
        /// <summary>true if DNSimple supports inbound transfers for this TLD</summary>
        public bool? TransferEnabled { get; set; }
        /// <summary>true if the suffix allows WHOIS privacy as a separate component. Some registries may provide WHOIS privacy at registry level by limiting the visibility of certain attributes in the WHOIS response.</summary>
        public bool? WhoisPrivacy { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.TLD"/> and sets the default values.
        /// </summary>
        public TLD()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.DNSimple.OpenApiClient.Models.TLD"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.DNSimple.OpenApiClient.Models.TLD CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.DNSimple.OpenApiClient.Models.TLD();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auto_renew_only", n => { AutoRenewOnly = n.GetBoolValue(); } },
                { "dnssec_interface_type", n => { DnssecInterfaceType = n.GetEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.TLD_dnssec_interface_type>(); } },
                { "idn", n => { Idn = n.GetBoolValue(); } },
                { "minimum_registration", n => { MinimumRegistration = n.GetIntValue(); } },
                { "name_server_max", n => { NameServerMax = n.GetIntValue(); } },
                { "name_server_min", n => { NameServerMin = n.GetIntValue(); } },
                { "registration_enabled", n => { RegistrationEnabled = n.GetBoolValue(); } },
                { "renewal_enabled", n => { RenewalEnabled = n.GetBoolValue(); } },
                { "tld", n => { TldProp = n.GetStringValue(); } },
                { "tld_type", n => { TldType = n.GetIntValue(); } },
                { "transfer_enabled", n => { TransferEnabled = n.GetBoolValue(); } },
                { "whois_privacy", n => { WhoisPrivacy = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("auto_renew_only", AutoRenewOnly);
            writer.WriteEnumValue<global::Soenneker.DNSimple.OpenApiClient.Models.TLD_dnssec_interface_type>("dnssec_interface_type", DnssecInterfaceType);
            writer.WriteBoolValue("idn", Idn);
            writer.WriteIntValue("minimum_registration", MinimumRegistration);
            writer.WriteIntValue("name_server_max", NameServerMax);
            writer.WriteIntValue("name_server_min", NameServerMin);
            writer.WriteBoolValue("registration_enabled", RegistrationEnabled);
            writer.WriteBoolValue("renewal_enabled", RenewalEnabled);
            writer.WriteStringValue("tld", TldProp);
            writer.WriteIntValue("tld_type", TldType);
            writer.WriteBoolValue("transfer_enabled", TransferEnabled);
            writer.WriteBoolValue("whois_privacy", WhoisPrivacy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
