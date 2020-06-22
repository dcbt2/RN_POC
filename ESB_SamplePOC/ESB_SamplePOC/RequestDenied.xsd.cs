namespace ESB_SamplePOC {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"ESB_SamplePOC",@"DeclineReq")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DeclineReq"})]
    public sealed class RequestDenied : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""ESB_SamplePOC"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""ESB_SamplePOC"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DeclineReq"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ReqID"" type=""xs:string"" />
        <xs:element name=""Qty"" type=""xs:unsignedInt"" />
        <xs:element name=""Division"" type=""xs:decimal"" />
        <xs:element name=""CountryCode"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RequestDenied() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DeclineReq";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
