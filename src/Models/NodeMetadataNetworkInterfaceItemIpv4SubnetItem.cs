// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HPC.ACM.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NodeMetadataNetworkInterfaceItemIpv4SubnetItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NodeMetadataNetworkInterfaceItemIpv4SubnetItem class.
        /// </summary>
        public NodeMetadataNetworkInterfaceItemIpv4SubnetItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NodeMetadataNetworkInterfaceItemIpv4SubnetItem class.
        /// </summary>
        public NodeMetadataNetworkInterfaceItemIpv4SubnetItem(string address = default(string), string prefix = default(string))
        {
            Address = address;
            Prefix = prefix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

    }
}