using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrCommunicationChannel
    {
        public long ChId { get; set; }
        public short ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string Notes { get; set; }
    }
}
