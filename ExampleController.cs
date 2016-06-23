using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Cors;
using System.Web.Http.Cors;


namespace Microservice4NetAppConsole
{
   [EnableCors(origins: "*", headers: "*", methods: "*")]
   [RoutePrefix("DemoAPI")]//Controller Url definition
      public class ExampleController:ApiController
    {
        [Route("GetExample")]//api route url definition
        public string GetExample()
        {
            return "Here is an Example service content.";
        }
        [Route("GetMax")]
        [HttpGet]
        public long GetTheBiggestNumber()
        {
            return Int64.MaxValue;
        }
         
        [Route("Get_BigNumber")]
        [HttpPost]
       
        public object Get_BigNumber()
        {
            return "Post and then, get a big number:"+Int64.MaxValue.ToString();
        }
        [Route("GetData")]
        [HttpPost]
        public object getData(string token="", string name="", string timeStamp="")
        {
            return new { name = "haha", type = "ff",content="xixi", timeStamp=System.DateTime.UtcNow.ToString("yyyyMMddHHmmssffff") , message_arr= new string[] {"hello","are you ok?","what you want to say to me." } };
        }
    }
}
