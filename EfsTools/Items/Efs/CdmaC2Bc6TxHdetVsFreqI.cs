using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024783", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc6TxHdetVsFreq
    {
        [ElementsCount(16)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] HdetVsFreq { get; set; }
        
    }
}
