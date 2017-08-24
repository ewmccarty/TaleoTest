using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using TestTaleo.net.taleo.tstatkinsglobal.candidateservice;
using TestTaleo.net.taleo.tstatkinsglobal.requisitionservice;
using searchableMultilingualSearchOnlyFieldValueSearchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualSearchOnlyFieldValueSearchType;
using searchableStringFieldSearchBehavior = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchBehavior;
using searchableStringFieldSearchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType;


//using searchableStringField = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringField;

//using Application = TestTaleo.net.taleo.tstatkinsglobal.candidateservice.Application;
//using ApplicationRequisition1 = TestTaleo.net.taleo.tstatkinsglobal.candidateservice.ApplicationRequisition1;
//using Candidate = TestTaleo.net.taleo.tstatkinsglobal.candidateservice.Candidate;
//using Requisition = TestTaleo.net.taleo.tstatkinsglobal.candidateservice.Requisition;
//using RequisitionJobInformation = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.RequisitionJobInformation;
//using searchableStringField = TestTaleo.net.taleo.tstatkinsglobal.candidateservice.searchableStringField;
//using searchableStringFieldSearchType = TestTaleo.net.taleo.tstatkinsglobal.candidateservice.searchableStringFieldSearchType;

namespace TestTaleo
{
    public class TaleoService
    {
        private readonly string endpoint;
        private readonly string username;
        private readonly string password;

        public TaleoService(string endpoint, string username, string password)
        {
            this.endpoint = endpoint;
            this.username = username;
            this.password = password;
        }

        private const string TaleoCandidateServiceName = "CandidateService";
        private const string TaleoRequisitionServiceName = "RequisitionService";
        public CandidateService GetCandidateService()
        {
            var url = this.endpoint + "?ServiceName=" + TaleoCandidateServiceName;

            var candidateService = new CandidateService();
            var credCache = new CredentialCache
            {
                {new Uri(endpoint), "Basic", new NetworkCredential(this.username, this.password)}
            };

            candidateService.Credentials = credCache;
            candidateService.Url = url;
            candidateService.PreAuthenticate = true;

            return candidateService;
        }

        public RequisitionService GetRequisitionService()
        {
            var url = this.endpoint + "?ServiceName=" + TaleoRequisitionServiceName;

            var requisitionService = new RequisitionService();
            var credCache = new CredentialCache
            {
                {new Uri(endpoint), "Basic", new NetworkCredential(this.username, this.password)}
            };

            requisitionService.Credentials = credCache;
            requisitionService.Url = url;
            requisitionService.PreAuthenticate = true;

            return requisitionService;
        }

        public void test()
        {
            //var candidate = new Candidate();
            //candidate.EmailAddress = new searchableStringField();
            //candidate.EmailAddress.Value = "jsmith@acme.com";
            //candidate.FirstName = new searchableStringField();
            //candidate.FirstName.Value = "John";
            //candidate.LastName = new searchableStringField();
            //candidate.LastName.Value = "Smith";

            //candidate.Applications = new Application[1] {new Application()};
           


            //candidate.Applications[0].Requisition = new ApplicationRequisition1();

            //candidate.Applications[0].Requisition.Requisition = new Requisition();

            //candidate.Applications[0].Requisition.Requisition.ContestNumber = new searchableStringField();

            //candidate.Applications[0].Requisition.Requisition.ContestNumber.searchType
            // = searchableStringFieldSearchType.search;
            //candidate.Applications[0].Requisition.Requisition.ContestNumber.searchTypeSpecified
            // = true;
            //candidate.Applications[0].Requisition.Requisition.ContestNumber.searchValue
            // = "STE000002";

        }


        public void CreateRequisition()
        {
            var requisitionService = GetRequisitionService();

            //requisitionService.update();

            var req = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.Requisition();
            //Set the search key
            req.ContestNumber = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringField();
            req.ContestNumber.Value = "INT-REQ-SRC-CS-122";
            req.ContestNumber.searchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType.searchAndValue;
            req.ContestNumber.searchTypeSpecified = true;
            req.ContestNumber.searchValue = req.ContestNumber.Value;

            //Creation of the Job Information
            req.JobInformation = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.RequisitionJobInformation();
            req.JobInformation.JobInformation = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.JobInformation();
            req.JobInformation.JobInformation.Title = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue[1];
            req.JobInformation.JobInformation.Title[0] = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue();
            req.JobInformation.JobInformation.Title[0].locale = "en";
            req.JobInformation.JobInformation.Title[0].searchValue = "Test Job 1";
            req.JobInformation.JobInformation.Title[0].searchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType.search;
            req.JobInformation.JobInformation.Title[0].searchTypeSpecified = true;
            req.JobInformation.JobInformation.Title[0].Value = "Test Job 1";
            req.JobInformation.JobInformation.Title[0].searchTypeSpecified = false;


           


            req.JobInformation.JobInformation.JobField = new net.taleo.tstatkinsglobal.requisitionservice.JobInformationJobField();
            req.JobInformation.JobInformation.JobField.JobField = new net.taleo.tstatkinsglobal.requisitionservice.JobField();
            //req.JobInformation.JobInformation.JobField.JobField.Name = new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue[1]
            //    {new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue()};

            //req.JobInformation.JobInformation.JobField.JobField.Name = new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue[1]
            //    {new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue()};
            //req.JobInformation.JobInformation.JobField.JobField.Name[0].locale = "en";
            //req.JobInformation.JobInformation.JobField.JobField.Name[0].searchValue = "Commercial";
            //req.JobInformation.JobInformation.JobField.JobField.Name[0].searchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType.search;
            //req.JobInformation.JobInformation.JobField.JobField.Name[0].searchTypeSpecified = true;
            //req.JobInformation.JobInformation.JobField.JobField.Name[0].Value = "Commercial";
            //req.JobInformation.JobInformation.JobField.JobField.Name[0].searchTarget = ".";
            //req.JobInformation.JobInformation.JobField.JobField.Name[0].searchBehaviorSpecified = false;


            //////req.Position = new net.taleo.tstatkinsglobal.requisitionservice.RequisitionPosition();
            //////req.Position.RecruitingPosition = new net.taleo.tstatkinsglobal.requisitionservice.RecruitingPosition();
            //////req.Position.RecruitingPosition.JobPosition = new net.taleo.tstatkinsglobal.requisitionservice.RecruitingPositionJobPosition();
            //////req.Position.RecruitingPosition.JobPosition.Position = new net.taleo.tstatkinsglobal.requisitionservice.Position();
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization = new net.taleo.tstatkinsglobal.requisitionservice.PositionOrganization();
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization = new net.taleo.tstatkinsglobal.requisitionservice.Organization();
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name = new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue[1] {new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue()};
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].locale = "en";
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].searchValue = "ATKINS UK";
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].searchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType.searchAndValue;
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].searchTypeSpecified = true;
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].Value = "ATKINS UK";
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].searchTarget = ".";
            //////req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].searchBehaviorSpecified = false;
            //req.Position.RecruitingPosition.JobPosition.Position.Organization.Organization.Name[0].searchBehavior = searchableStringFieldSearchBehavior.lax;
            /// 
            /// 
            //////req.JobInformation.JobInformation.Organization = new net.taleo.tstatkinsglobal.requisitionservice.JobInformationOrganization();
            //////req.JobInformation.JobInformation.Organization.Organization = new net.taleo.tstatkinsglobal.requisitionservice.Organization();
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID = new net.taleo.tstatkinsglobal.requisitionservice.searchableStringField();
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID.Value = "AD-MW0001 ";
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID.searchValue = "AD-MW0001 ";
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID.searchBehavior = searchableStringFieldSearchBehavior.lax;
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID.searchBehaviorSpecified = true;
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID.searchTarget = ".";
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID.searchType = searchableStringFieldSearchType.searchAndValue;
            //////req.JobInformation.JobInformation.Organization.Organization.CustomerID.searchTypeSpecified = true;


            req.BaseJobTemplate = new net.taleo.tstatkinsglobal.requisitionservice.RequisitionBaseJobTemplate();
            req.BaseJobTemplate.JobTemplate = new net.taleo.tstatkinsglobal.requisitionservice.JobTemplate();
            req.BaseJobTemplate.JobTemplate.JobCode = new net.taleo.tstatkinsglobal.requisitionservice.searchableStringField();
            req.BaseJobTemplate.JobTemplate.JobCode.Value = "12345";
            req.BaseJobTemplate.JobTemplate.JobCode.searchValue = "12345";
            req.BaseJobTemplate.JobTemplate.JobCode.searchTypeSpecified = true;
            req.BaseJobTemplate.JobTemplate.JobCode.searchType = searchableStringFieldSearchType.search;
            req.BaseJobTemplate.JobTemplate.JobCode.searchTarget = ".";

            //////req.Position = new net.taleo.tstatkinsglobal.requisitionservice.RequisitionPosition();
            //////req.Position.RecruitingPosition = new net.taleo.tstatkinsglobal.requisitionservice.RecruitingPosition();
            //////req.Position.RecruitingPosition.JobPosition = new net.taleo.tstatkinsglobal.requisitionservice.RecruitingPositionJobPosition();
            //////req.Position.RecruitingPosition.JobPosition.Position = new net.taleo.tstatkinsglobal.requisitionservice.Position();
            //////req.Position.RecruitingPosition.JobTemplat


            //req.JobInformation.JobInformation.Organization.Organization.Name[0].locale = "en";
            //req.JobInformation.JobInformation.Organization.Organization.Name[0].searchValue = "ATKINS UK";
            //req.JobInformation.JobInformation.Organization.Organization.Name[0].searchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType.searchAndValue;
            //req.JobInformation.JobInformation.Organization.Organization.Name[0].searchTypeSpecified = true;
            //req.JobInformation.JobInformation.Organization.Organization.Name[0].Value = "ATKINS UK";
            //req.JobInformation.JobInformation.Organization.Organization.Name[0].searchTarget = ".";
            //req.JobInformation.JobInformation.Organization.Organization.Name[0].searchBehaviorSpecified = true;
            //req.JobInformation.JobInformation.Organization.Organization.Name[0].searchBehavior = searchableStringFieldSearchBehavior.lax;

            //req.JobInformation.JobInformation.PrimaryLocation = new net.taleo.tstatkinsglobal.requisitionservice.JobInformationPrimaryLocation();
            //req.JobInformation.JobInformation.PrimaryLocation.Location = new net.taleo.tstatkinsglobal.requisitionservice.Location();
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name = new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue[1] {new net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue() };
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name[0].locale = "en";
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name[0].searchValue = "United Kingdom";
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name[0].searchType = TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType.search;
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name[0].searchTypeSpecified = true;
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name[0].Value = "United Kingdom";
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name[0].searchTarget = ".";
            //req.JobInformation.JobInformation.PrimaryLocation.Location.Name[0].searchBehaviorSpecified = false;

            //req.JobInformation.JobInformation.JobGrade = new net.taleo.tstatkinsglobal.requisitionservice.searchableStringField();
            //req.JobInformation.JobInformation.JobGrade.Value = "01 - 01";
            //req.JobInformation.JobInformation.JobGrade.searchBehaviorSpecified = false;
            //req.JobInformation.JobInformation.JobGrade.searchTypeSpecified = true;
            //req.JobInformation.JobInformation.JobGrade.searchType = searchableStringFieldSearchType.search;
            //req.JobInformation.JobInformation.JobGrade.searchTarget = ".";
            //req.JobInformation.JobInformation.JobGrade.searchValue = "01 - 01";


            //req.HiringManager = new net.taleo.tstatkinsglobal.requisitionservice.RequisitionHiringManager();
            //req.HiringManager.User = new net.taleo.tstatkinsglobal.requisitionservice.User();

            //req.HiringManager.User.CorrespondenceEmail = new net.taleo.tstatkinsglobal.requisitionservice.searchableStringField();
            //req.HiringManager.User.CorrespondenceEmail.Value = "adrian.sutcliffe@weareamberjack.com";
            //req.HiringManager.User.CorrespondenceEmail.searchBehaviorSpecified = false;
            //req.HiringManager.User.CorrespondenceEmail.searchTypeSpecified = true;
            //req.HiringManager.User.CorrespondenceEmail.searchType = searchableStringFieldSearchType.search;
            //req.HiringManager.User.CorrespondenceEmail.searchTarget = ".";
            //req.HiringManager.User.CorrespondenceEmail.searchValue = "adrian.sutcliffe@weareamberjack.com";

            //req.HiringManager.User.UserAccount.UserAccount.Groups[0].OLFCoverageAreas[0].Locations

            //req.HiringManager.User.UserAccount.UserAccount.Groups[0].OLFCoverageAreas[0].Organizations

            //Getting Started Standard Type Basics
            //User Guide Taleo Web Services 12A 23
            // Creation of an UDF element in the requisition
            ////var udfs = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.UDFs[1];
            ////req.JobInformation.JobInformation.UDFs = udfs;
            ////req.JobInformation.JobInformation.UDFs[0] = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.UDFs();
            //req.JobInformation.JobInformation.UDFs[0] = "LUDS_5fLogistics_5fRWT_2bCS";
            // Creation of the UDSElement
            ////var udsElement = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.UDSElement();
            ////var desc = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue[1];
            ////udsElement.Description = desc;
            ////udsElement.Description[0] = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableMultilingualStringFieldValue();
            ////udsElement.Description[0].locale = "en";
            ////udsElement.Description[0].searchValue = "LUD CANM 1";
            ////udsElement.Description[0].searchType =
            //// TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.searchableStringFieldSearchType.search;
            ////udsElement.Description[0].searchTypeSpecified = true;
            ////// Add the UDSElement to the UDFs
            ////req.JobInformation.JobInformation.UDFs[0].Items = new TestTaleo.net.taleo.tstatkinsglobal.requisitionservice.UDSElement[1];
            ////req.JobInformation.JobInformation.UDFs[0].Items[0] = udsElement;

            //try
            //{
            // Invoke the requisition create service.
            var xml = Serialize(req);
           var result = requisitionService.create(req);
            //}
            //catch (Exception e)
            //{
            //    e.Message.ToString();
            //}

        }

        public static string Serialize<T>(T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public void CreateCandidate()
        {
            var candidateService = GetCandidateService();

            var candidate = new net.taleo.tstatkinsglobal.candidateservice.Candidate();
            candidate.Prefix = "Mr";
            candidate.EmailAddress = new net.taleo.tstatkinsglobal.candidateservice.searchableStringField();
            candidate.EmailAddress.Value = "jsmith@acme.com";
            candidate.FirstName = new net.taleo.tstatkinsglobal.candidateservice.searchableStringField();
            candidate.FirstName.Value = "John";
            candidate.LastName = new net.taleo.tstatkinsglobal.candidateservice.searchableStringField();
            candidate.LastName.Value = "Smith";
            candidate.Applications = new net.taleo.tstatkinsglobal.candidateservice.Application[1] { new net.taleo.tstatkinsglobal.candidateservice.Application() };



            candidate.Applications[0].Requisition = new net.taleo.tstatkinsglobal.candidateservice.ApplicationRequisition1[] { new net.taleo.tstatkinsglobal.candidateservice.ApplicationRequisition1() };

            candidate.Applications[0].Requisition[0].Requisition = new net.taleo.tstatkinsglobal.candidateservice.Requisition();

            candidate.Applications[0].Requisition[0].Requisition.ContestNumber = new net.taleo.tstatkinsglobal.candidateservice.searchableStringField();

            candidate.Applications[0].Requisition[0].Requisition.ContestNumber.searchType
             = net.taleo.tstatkinsglobal.candidateservice.searchableStringFieldSearchType.search;
            candidate.Applications[0].Requisition[0].Requisition.ContestNumber.searchTypeSpecified
             = true;
            candidate.Applications[0].Requisition[0].Requisition.ContestNumber.searchValue
             = "STE000002";

            var result = candidateService.create(candidate);

            //candidateService.referApplicationByAgent(Int64.Parse(result.ToString()), "adrian.sutcliffe@weareamberjack.com", new string[] { "STE000002" });
        }

    }
}