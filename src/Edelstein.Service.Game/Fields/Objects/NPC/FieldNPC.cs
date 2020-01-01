using System;
using System.Drawing;
using Edelstein.Core.Templates.NPC;
using Edelstein.Core.Utils.Packets;
using Edelstein.Network.Packets;

namespace Edelstein.Service.Game.Fields.Objects.NPC
{
    public class FieldNPC : AbstractFieldLife
    {
        public override FieldObjType Type => FieldObjType.NPC;

        public NPCTemplate Template { get; }

        public int RX0 { get; set; }
        public int RX1 { get; set; }

        public FieldNPC(NPCTemplate template, bool left = true)
        {
            Template = template;
            MoveAction = Convert.ToByte(left);
        }

        public override IPacket GetEnterFieldPacket()
        {
            using var p = new Packet(SendPacketOperations.NpcEnterField);
            p.Encode<int>(ID);
            p.Encode<int>(Template.ID);

            p.Encode<Point>(Position);
            p.Encode<byte>(MoveAction);
            p.Encode<short>(Foothold);

            p.Encode<short>((short) RX0);
            p.Encode<short>((short) RX1);

            p.Encode<bool>(true); // bEnabled
            return p;
        }

        public override IPacket GetLeaveFieldPacket()
        {
            using var p = new Packet(SendPacketOperations.NpcLeaveField);
            p.Encode<int>(ID);
            return p;
        }
    }
}