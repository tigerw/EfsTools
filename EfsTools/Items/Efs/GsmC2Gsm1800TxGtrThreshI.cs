using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025106", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1800TxGtrThreshI
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_GTR_THRESH_DATA_TYPE")]
        [Description("")]
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
        
    }
}