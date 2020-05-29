using ApiClient.Core.Services;
using ApiClient.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiClient.Resource
{
    public class EmailResource
    {
        private readonly IClientService _service;

        public EmailResource(IClientService service)
        {
            _service = service;
        }

        public virtual SendRequest Send(EmailBody body)
        {
   
        }

        


    }

    public class SendRequest : BraviBaseRequest<BraviResponse>
    {
        public EmailBody Body { get; set; }

        public override string RestPath => "send";

        public override string HttpMethod => "POST";

        public SendRequest(IClientService service, EmailBody body) : base(service)
        {
            Body = body;
            //InitParameters();
        }

        //protected override void InitParameters()
        //{
        //    base.InitParameters();

        //    RequestParameters.Add(
        //            "brand", new Parameter
        //            {
        //                Name = "brand",
        //                IsRequired = true,
        //                ParameterType = "query",
        //                DefaultValue = null,
        //                Pattern = null,
        //            });
        //}
    }

    public class BraviResponse
    {

    }

    public class EmailBody
    {

    }
}


