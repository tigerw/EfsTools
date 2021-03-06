using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024856", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33MaxTxPower
    {
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MaxTxPower { get; set; }
        
    }
}
