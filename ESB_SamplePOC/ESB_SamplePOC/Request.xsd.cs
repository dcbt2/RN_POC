namespace ESB_SamplePOC {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"ESB_SamplePOC",@"Request")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "Item.Quantity", XPath = @"/*[local-name()='Request' and namespace-uri()='ESB_SamplePOC']/*[local-name()='Item' and namespace-uri()='']/*[local-name()='Quantity' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Request"})]
    public sealed class Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""ESB_SamplePOC"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""ESB_SamplePOC"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo root_reference=""Request"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Request"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Request' and namespace-uri()='ESB_SamplePOC']/*[local-name()='Item' and namespace-uri()='']/*[local-name()='Quantity' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ReqID"" type=""xs:string"" />
              <xs:element name=""Date"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Item"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Description"" type=""xs:string"" />
              <xs:element name=""Quantity"" type=""xs:int"" />
              <xs:element name=""UnitPrice"" type=""xs:string"" />
              <xs:element name=""TotalPrice"" type=""xs:string"" />
              <xs:element name=""Country"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Request() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Request";
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
