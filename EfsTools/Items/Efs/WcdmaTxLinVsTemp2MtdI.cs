using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020484", true, 0xE1FF)]
    [Attributes(9)]
    public class WcdmaTxLinVsTemp2Mtd
    {
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
