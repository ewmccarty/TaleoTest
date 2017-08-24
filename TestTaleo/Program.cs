using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using TestTaleo.net.taleo.tstatkinsglobal.requisitionservice;
//using TestTaleo.net.taleo.tstatkinsglobal.candidateservice;

namespace TestTaleo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var candidateService = new CandidateService();
            //var requisitionService = new RequisitionService();

            var ts = new TaleoService("https://tstatkinsglobal.taleo.net/enterprise/soap", "amberjack.test", "GradWeb2.0");
           
            ts.CreateRequisition();
            //ts.CreateCandidate();

            //XmlWriterSettings setting = new XmlWriterSettings();
            //setting.ConformanceLevel = ConformanceLevel.Auto;
            //XmlSerializer xsSubmit = new XmlSerializer(typeof(Requisition));
            //var subReq = new Requisition();
            //var xml = "";

            //using (var sww = new StringWriter())
            //{
            //    using (XmlWriter writer = XmlWriter.Create(sww))
            //    {
            //        xsSubmit.Serialize(writer, subReq);
            //        xml = sww.ToString(); // Your XML
            //    }
            //}
            // ts.CreateCandidate();
        }
    }
}
