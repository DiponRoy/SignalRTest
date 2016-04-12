using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
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

        protected IHubContext Hub<THub>() where THub : Hub
        {
            var hubContext = new Lazy<IHubContext>(() => GlobalHost.ConnectionManager.GetHubContext<THub>());
            return hubContext.Value;
        }
    }
}
