﻿using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class ItemEntry
    {
        [Index(true)]
        public uint ID;
        public byte ClassID;
        public byte SubclassID;
        public byte Material;
        public sbyte InventoryType;
        public byte SheatheType;
        public sbyte SoundOverrideSubclassID;
        public int IconFileDataID;
        public byte ItemGroupSoundsID;
        public int ModifiedCraftingReagentItemID;
        public int CraftingQualityID;
    }
}
