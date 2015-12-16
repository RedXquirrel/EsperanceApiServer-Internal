using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EsperanceAPIServer.Controllers
{
    [RoutePrefix("api/Tests")]
    public class TestsController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Item.CreateTests());
        }

    }

    #region Helpers

    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public static List<Item> CreateTests()
        {
            List<Item> ItemList = new List<Item> 
            {
                new Item {ItemID = 0, ItemName = "Alpha" },
                new Item {ItemID = 1, ItemName = "Bravo" },
            };

            return ItemList;
        }
    }

    #endregion
}
