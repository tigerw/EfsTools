using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5923)]
    [Attributes(9)]
    public class WcdmaRxfIciQCoef67
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
        
    }
}
