﻿namespace WindowsGSM.GameServer
{
    class CSGO : Type.SRCDS
    {
        public const string FullName = "Counter-Strike: Global Offensive Dedicated Server";
        public override string defaultmap { get { return "de_dust2"; } }
        public override string additional { get { return "-tickrate 64 -usercon +game_type 0 +game_mode 0 +mapgroup mg_active"; } }
        public override string Game { get { return "csgo"; } }
        public override string AppId { get { return "740"; } }

        public CSGO(Functions.ServerConfig serverData) : base(serverData)
        {
            base.serverData = serverData;
        }
    }
}
