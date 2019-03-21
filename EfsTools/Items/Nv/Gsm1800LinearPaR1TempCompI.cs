using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6351)]
    [Attributes(9)]
    public class Gsm1800LinearPaR1TempCompI
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}