using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6982)]
    [Attributes(9)]
    public class Wcdma1500TxRotAnglePaState01
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
        
    }
}
