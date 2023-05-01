using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_3_8
{
    internal class SiteLoader
    {
        private static HttpClient httpClient;

        public string siteUri { get; private set; }

        protected SiteLoader(string resourceUrl)
        {
            siteUri = resourceUrl;
        }

        public static HttpClient GetHttpClient(string siteUri) 
        { 
            if (httpClient == null)
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(siteUri);
            }
            return httpClient;
        }

    }
}
