using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDT.Uow;

namespace SDT.Controllers.Api
{
    public abstract class SdtApiController : ApiController
    {
        public ISdtUow Uow;
        protected SdtApiController(ISdtUow uow)
        {
            Uow = uow;
        }
    }
}
