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
      public class ExampleController:ApiController
    {
        [Route("Example")]
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
    }
}
