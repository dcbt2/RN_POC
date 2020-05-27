using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POC_VSTS_Deployment;
using System.IO;

namespace UTBizTalkPocAzDops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMap()
        {
            // Target targetschema = new Target();
            Map map = new Map();

            string Source_XML = @"C:\Users\dcBT2\Documents\GitHub\RN_POC\POC_VSTS_Deployment\UnitTestProject1\UnitTesting\Input\inputfile.xml";
            string Target_XML = @"C:\Users\dcBT2\Documents\GitHub\RN_POC\POC_VSTS_Deployment\UnitTestProject1\UnitTesting\Output\Map_Output.xml";

            map.ValidateOutput = true;
            map.TestMap(Source_XML, Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
                Target_XML, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);

            Assert.IsTrue(File.Exists(Target_XML));
        }
    }
}