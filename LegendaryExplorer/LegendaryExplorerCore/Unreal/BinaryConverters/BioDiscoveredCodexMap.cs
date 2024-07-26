﻿namespace LegendaryExplorerCore.Unreal.BinaryConverters
{
    public class BioDiscoveredCodexMap : ObjectBinary
    {
        public int unk;

        protected override void Serialize(SerializingContainer sc)
        {
            sc.Serialize(ref unk);
        }

        public static BioDiscoveredCodexMap Create() => new();
    }
}
