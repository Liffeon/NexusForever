using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;

namespace NexusForever.WorldServer.Network.Message.Model
{
    [Message(GameMessageOpcode.ClientRequestAMPReset, MessageDirection.Client)]
    public class ClientRequestAMPReset : IReadable
    {
        public byte ActionSetIndex { get; private set; }
        public byte Unknown0 { get; private set; }
        public uint Unknown1 { get; private set; }
        

        public void Read(GamePacketReader reader)
        {
            ActionSetIndex = reader.ReadByte(3u);
            Unknown0 = reader.ReadByte(3u);
            Unknown1 = reader.ReadUInt();
        }
    }
}
