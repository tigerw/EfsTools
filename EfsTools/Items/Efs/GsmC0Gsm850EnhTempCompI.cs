using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025108", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm850EnhTempComp
    {
        [ElementsCount(256)]
        [ElementType("int16")]
        [Description("")]
        public short[] TempcompTable { get; set; }
        
    }
}
