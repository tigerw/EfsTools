using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024898", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB33TxCarrierFeedthroughComp
    {
        [ElementsCount(2)]
        [ElementType("int16")]
        [Description("")]
        public short[] TxCarrierFeedthroughCompType { get; set; }
        
    }
}
