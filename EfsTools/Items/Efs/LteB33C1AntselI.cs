using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024885", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33C1Antsel
    {
        [ElementsCount(4)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] C1Antsel { get; set; }
        
    }
}
