﻿using Newtonsoft.Json;
using PepperDash.Core;
using PepperDash.Essentials.Core;

namespace global_cache_ip2ir_epi
{
    public class Config // this is properties
    {
        [JsonProperty("irFilepath")]
        public string IRFilepath { get; set; }

        [JsonProperty("pulseTime")]
        public uint PulseTime { get; set; }
        [JsonProperty("repeat")]
        public uint Repeat { get; set; }
        /// <summary>
        /// JSON control object: device.properties
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <example>
        /// <code>
        /// 
        /// "control": {
        ///		"method": "tcpIp",
        ///		"tcpSshProperties": {
        ///			"address": "172.22.0.101",
        ///			"port": 4998,
        ///			"username": "admin",
        ///			"password": "password",
        ///			"autoReconnect": true,
        ///			"autoReconnectIntervalMs": 10000
        ///		}
        ///	}
        ///	
        /// </code>
        /// </example>
        [JsonProperty("control")]
        public ControlPropertiesConfig Control { get; set; }
        public CommunicationMonitorConfig Monitor { get; set; }
        public bool EnableBridgeComms { get; set; }

        ///	"brand": "Global Cache",
        //[JsonProperty("brand")]
        //public string Brand { get; set; }
        ///	"model": "iTachIP2IR",
        //[JsonProperty("model")]
        //public string Model { get; set; }

        /// <summary>
        /// Constuctor
        /// </summary>
        /// <remarks>
        /// If using a collection you must instantiate the collection in the constructor
        /// to avoid exceptions when reading the configuration file 
        /// </remarks>
        public Config()
        {
        }
    }
}
