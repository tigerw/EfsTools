using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1892)]
    [Attributes(9)]
    public class DiagDebugControl
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}