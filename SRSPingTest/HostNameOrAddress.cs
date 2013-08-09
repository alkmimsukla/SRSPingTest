using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace SRSPingTest
{
    public class HostNameOrAddress
    {
        private string hostname;
        private string pcaddress;
        private string moxa;
        private PingReply pc_replyStatus;
        private PingReply mx_replyStatus;

        public string HostName
        {
            get { return hostname; }
            set { hostname = value; }
        }

        public string PCAddress
        {
            get { return pcaddress; }
            set { pcaddress = value; }
        }

        public string Moxa
        {
            get { return moxa; }
            set { moxa = value; }
        }

        public PingReply PC_ReplyStatus
        {
            get { return pc_replyStatus; }
            set { pc_replyStatus = value; }
        }

        public PingReply MX_ReplyStatus
        {
            get { return mx_replyStatus; }
            set { mx_replyStatus = value; }
        }
    }
}
