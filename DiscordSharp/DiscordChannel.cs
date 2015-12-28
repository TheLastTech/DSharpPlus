﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordSharp
{
    public class DiscordChannel
    {
        public string type { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string topic { get; set; }
        public bool is_private { get; set; } = false;
        public List<DiscordPermissionOverride> PermissionOverrides { get; set; }

        public DiscordServer parent { get; internal set; }
    }

    public class DiscordPrivateChannel
    {
        public string id { get; set; }
        public DiscordRecipient recipient { get; set; }
    }

    //kinda like the author
    public class DiscordRecipient
    {
        public string username { get; set; }
        public string id { get; set; }
    }

    public class DiscordServer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string owner_id { get; set; }
        public List<DiscordChannel> channels { get; set; }
        public List<DiscordMember> members { get; set; }
        public List<DiscordRole> roles { get; set; }

        public DiscordServer()
        {
            channels = new List<DiscordChannel>();
            members = new List<DiscordMember>();
        }
    }
}
