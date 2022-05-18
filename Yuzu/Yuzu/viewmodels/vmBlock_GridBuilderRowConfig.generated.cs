using YuzuDelivery.Umbraco.BlockList;
using YuzuDelivery.Umbraco.Core;
using YuzuDelivery.Umbraco.Forms;
//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.23.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace YuzuDelivery.ViewModels
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v13.0.0.0)")]
    [YuzuMap("GridBuilderRowConfig")]
    public partial class vmBlock_GridBuilderRowConfig 
    {
        [Newtonsoft.Json.JsonProperty("string", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string String { get; set; }
    
        [Newtonsoft.Json.JsonProperty("boolean", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Boolean { get; set; }
    
        [Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("enumString", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public vmSub_GridBuilderRowConfigVmBlock_GridBuilderRowConfigEnumString EnumString { get; set; }
    
        [Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public vmBlock_DataImage Image { get; set; }
    
        [Newtonsoft.Json.JsonProperty("link", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public vmBlock_DataLink Link { get; set; }
    
        [Newtonsoft.Json.JsonProperty("_ref", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string _ref { get; set; }
    
        [Newtonsoft.Json.JsonProperty("_modifiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> _modifiers { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum vmSub_GridBuilderRowConfigVmBlock_GridBuilderRowConfigEnumString
    {
        [System.Runtime.Serialization.EnumMember(Value = @"value1")]
        Value1 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"value2")]
        Value2 = 1,
    
    }
}