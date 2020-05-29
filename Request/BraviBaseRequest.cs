using ApiClient.Core.Request;
using ApiClient.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClient.Request
{
    public abstract class BraviBaseRequest<TResponse> : ClientServiceRequest<TResponse>
    {
        protected BraviBaseRequest(IClientService service) : base(service)
        {
        }

        //default and common parameters
        //identifies car api and gives privileges
        public virtual string Key { get; set; }
    }
}
