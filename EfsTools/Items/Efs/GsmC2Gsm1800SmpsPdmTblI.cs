using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025090", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1800SmpsPdmTbl
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_SMPS_PDM_DATA_TYPE")]
        [Description("")]
        public GsmTxSmpsPdmDataType SmpsPdmData { get; set; }
        
    }
}
