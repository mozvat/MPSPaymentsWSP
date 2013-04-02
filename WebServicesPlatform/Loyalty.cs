using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;

namespace WebServicesPlatform
{
    public class Loyalty
    {
        public void Process()
        {
            //A Basic GetStatus()
            var webRequest = string.Empty;
            var result = string.Empty;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.cert.mercuryloyalty.com/v3_0/loyalty/GetStatus/?apikey=PAUL&apisecret=f2ee0e69a14c45039c6041b19fd18d88&customeridentifier=4076374996");
            httpWebRequest.ContentType = "text/xml";
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            var response = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);
            string responseString = responseReader.ReadToEnd();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(responseString);
            //* Get elements.
            string emailAddress = xmlDoc.GetElementsByTagName("EmailAddress")[0].InnerText;
            string firstName = xmlDoc.GetElementsByTagName("FirstName")[0].InnerText;
            string lastName = xmlDoc.GetElementsByTagName("LastName")[0].InnerText;
            string mobileNumber = xmlDoc.GetElementsByTagName("MobileNumber")[0].InnerText;
            string currentCredits = xmlDoc.GetElementsByTagName("CurrentCredits")[0].InnerText;
            string lifeTimeCredits = xmlDoc.GetElementsByTagName("LifetimeCredits")[0].InnerText;
            string lifeTimeRevenue = xmlDoc.GetElementsByTagName("LifetimeRevenue")[0].InnerText;
            string rewardsEarned = xmlDoc.GetElementsByTagName("RewardsEarned")[0].InnerText;
        }
    }
}
