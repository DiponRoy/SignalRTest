using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using SDT.Db.Models;
using SDT.Hubs;
using SDT.Uow;

namespace SDT.Controllers.Api
{
    public class DevTestsController : SdtApiController
    {
        public DevTestsController(ISdtUow uow) : base(uow)
        {
        }

        private IHubContext Hub()
        {
            return Hub<DevTestsHub>();
        }

        // GET api/devtests
        public IEnumerable<DevTest> Get()
        {
            return Uow.Db.DevTests.ToList();
        }

        // GET api/devtests/5
        public DevTest Get(int id)
        {
            return Uow.Db.DevTests.First(x => x.Id == id);
        }

        // POST api/devtests
        public void Post([FromBody]DevTest entity)
        {
            Uow.Db.DevTests.Add(entity);
            Uow.Db.SaveChanges();

            Hub().Clients.All.Create(entity);
        }

        // PUT api/devtests/5
        public void Put(int id, [FromBody]DevTest entity)
        {
            var devtest = Uow.Db.DevTests.First(x => x.Id == id);
            devtest.CampaingnName = entity.CampaingnName;
            devtest.Date = entity.Date;
            devtest.Clicks = entity.Clicks;
            devtest.Conversions = entity.Conversions;
            devtest.Impressions = entity.Impressions;
            devtest.AffiliateName = entity.AffiliateName;
            Uow.Db.SaveChanges();

            Hub().Clients.All.Update(devtest);

        }

        // DELETE api/devtests/5
        public void Delete(int id)
        {
            var entity = Uow.Db.DevTests.First(x => x.Id == id);
            Uow.Db.DevTests.Remove(entity);
            Uow.Db.SaveChanges();

            Hub().Clients.All.Remove(entity);
        }
    }
}
