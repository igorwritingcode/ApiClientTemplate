using ApiClient.Core.Http;
using ApiClient.Core.Services;
using ApiClient.Resource;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ApiClient
{
    public class BraviService : BaseClientService
    {
        public BraviService(string baseUrl, HttpClientFactory clientFactory, X509Certificate2 certificate, string version)
            : base (baseUrl, clientFactory, certificate, version)
        {

        }

        private readonly EmailResource emails;

        public virtual EmailResource Emails
        {
            get { return emails; }
        }
    }
}

