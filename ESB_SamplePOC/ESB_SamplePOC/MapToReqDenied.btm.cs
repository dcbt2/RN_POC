namespace ESB_SamplePOC {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ESB_SamplePOC.Request", typeof(global::ESB_SamplePOC.Request))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ESB_SamplePOC.RequestDenied", typeof(global::ESB_SamplePOC.RequestDenied))]
    public sealed class MapToReqDenied : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""ESB_SamplePOC"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Request"" />
  </xsl:template>
  <xsl:template match=""/ns0:Request"">
    <xsl:variable name=""var:v1"" select=""userCSharp:MathDivide(string(Item/TotalPrice/text()) , string(Item/UnitPrice/text()))"" />
    <ns0:DeclineReq>
      <ReqID>
        <xsl:value-of select=""Header/ReqID/text()"" />
      </ReqID>
      <Qty>
        <xsl:value-of select=""Item/Quantity/text()"" />
      </Qty>
      <Division>
        <xsl:value-of select=""$var:v1"" />
      </Division>
      <xsl:variable name=""var:v2"" select=""ScriptNS0:DBLookup(0 , string(Item/Country/text()) , &quot;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ESB_SamplePOC;Data Source=VM2&quot; , &quot;Table_10&quot; , &quot;Field1&quot;)"" />
      <xsl:variable name=""var:v3"" select=""ScriptNS0:DBValueExtract(string($var:v2) , &quot;Field2&quot;)"" />
      <CountryCode>
        <xsl:value-of select=""$var:v3"" />
      </CountryCode>
    </ns0:DeclineReq>
    <xsl:variable name=""var:v4"" select=""ScriptNS0:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string MathDivide(string val1, string val2)
{
	string retval = """";
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		if (d2 != 0)
		{
			double ret = d1 / d2;
			retval = ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
	}
	return retval;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"ESB_SamplePOC.Request";
        
        private const global::ESB_SamplePOC.Request _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ESB_SamplePOC.RequestDenied";
        
        private const global::ESB_SamplePOC.RequestDenied _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"ESB_SamplePOC.Request";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ESB_SamplePOC.RequestDenied";
                return _TrgSchemas;
            }
        }
    }
}
