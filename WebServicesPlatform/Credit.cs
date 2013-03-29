using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WebServicesPlatform
{


    public static class Credit
    {
        public static string Process(string dsiCreditRequest, string transactionPassword)
        {
            string rawResult = string.Empty;
            string sanitizedResult = string.Empty;
            MPS_WebServices.wsSoapClient proxy = new MPS_WebServices.wsSoapClient();
            try
            {
                proxy.Endpoint.Address = new EndpointAddress(ProcessingEnvironment.Instance.EndPoint);
                rawResult = proxy.CreditTransaction(dsiCreditRequest.Trim(), transactionPassword);
                if (Response.Approved(rawResult))
                {
                    sanitizedResult = Response.SanitizeXMLResults(rawResult);
                }
                else //This will return a reason of the non-approval
                {
                    sanitizedResult = rawResult;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return sanitizedResult;
        }
    }
}
