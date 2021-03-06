using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(702)]
    [Attributes(9)]
    public class DigitalMisCompAOffset
    {
        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int Value { get; set; }
        
    }
}
