using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POC_VSTS_Deployment;
using System.IO;
using System.Xml;

namespace UTBizTalkPocAzDops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateInput()
        {
            Source sourceschema = new Source();
            string Source_XML = @"C:\Users\dcBT2\Documents\GitHub\RN_POC\POC_VSTS_Deployment\UnitTestProject1\UnitTesting\Input\inputfile.xml";
            Assert.IsTrue(sourceschema.ValidateInstance(Source_XML, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
        }

        [TestMethod]
        public void TestMap()
        {
            Source sourceschema = new Source();
            Target targetschema = new Target();
            Map map = new Map();

            string Source_XML = @"C:\Users\dcBT2\Documents\GitHub\RN_POC\POC_VSTS_Deployment\UnitTestProject1\UnitTesting\Input\inputfile.xml";
            string Target_XML = @"C:\Users\dcBT2\Documents\GitHub\RN_POC\POC_VSTS_Deployment\UnitTestProject1\UnitTesting\Output\Map_Output.xml";

            if (File.Exists(Target_XML) == true)
            {
                File.Delete(Target_XML);
            }

            map.ValidateOutput = true;
            map.TestMap(Source_XML, Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
                 Target_XML, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);

            targetschema.ValidateInstance(Target_XML, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);

            XmlDocument xmldocument = new XmlDocument();
            xmldocument.Load(Target_XML);

            XmlNode AddNode = xmldocument.SelectSingleNode("/*[local-name()='Root' and namespace-uri()='http://BizTalk_Server_Project1.Target']/*[local-name()='Add' and namespace-uri()='']");
            string AddNodeValue = AddNode.InnerText;

            XmlNode SubNode = xmldocument.SelectSingleNode("/*[local-name()='Root' and namespace-uri()='http://BizTalk_Server_Project1.Target']/*[local-name()='Sub' and namespace-uri()='']");
            string SubNodeValue = SubNode.InnerText;

            bool AssertResult = false;
            if (AddNodeValue == "250" && SubNodeValue == "1501")
            {
                // Assert.IsTrue(targetschema.ValidateInstance(Target_XML, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
                // Assert.IsTrue(File.Exists(Target_XML));   

                AssertResult = true;
            }

            Assert.IsTrue(AssertResult);
        }
    }
}