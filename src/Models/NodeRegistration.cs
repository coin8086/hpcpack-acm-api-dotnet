// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HPC.ACM.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class NodeRegistration
    {
        /// <summary>
        /// Initializes a new instance of the NodeRegistration class.
        /// </summary>
        public NodeRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeRegistration class.
        /// </summary>
        public NodeRegistration(string nodeName = default(string), int? coreCount = default(int?), int? socketCount = default(int?), int? memoryMegabytes = default(int?), IList<NodeGpu> gpuInfo = default(IList<NodeGpu>), IList<NodeNetwork> networksInfo = default(IList<NodeNetwork>), string distroInfo = default(string))
        {
            NodeName = nodeName;
            CoreCount = coreCount;
            SocketCount = socketCount;
            MemoryMegabytes = memoryMegabytes;
            GpuInfo = gpuInfo;
            NetworksInfo = networksInfo;
            DistroInfo = distroInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "coreCount")]
        public int? CoreCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "socketCount")]
        public int? SocketCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "memoryMegabytes")]
        public int? MemoryMegabytes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gpuInfo")]
        public IList<NodeGpu> GpuInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "networksInfo")]
        public IList<NodeNetwork> NetworksInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "distroInfo")]
        public string DistroInfo { get; set; }

    }
}