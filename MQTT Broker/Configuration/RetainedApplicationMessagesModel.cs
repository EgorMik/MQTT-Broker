using System;
using System.Collections.Generic;
using System.Text;

namespace MQTT_Broker.Configuration
{
    public class RetainedApplicationMessagesModel
    {
        public bool Persist { get; set; } = false;

        public int WriteInterval { get; set; } = 10;

        public string Path { get; set; }
    }
}
