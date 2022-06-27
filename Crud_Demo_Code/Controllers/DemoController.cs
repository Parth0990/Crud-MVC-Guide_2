using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Crud_Demo_Code.Controllers
{
    public class DemoController : ApiController
    {

        DbClass obj = new DbClass();
       // Class1 model = new Class1();

        [HttpGet]
        public List<Class1> Get()
        {
            return obj.selectAll();
        }

        [HttpPost]
        public String Post([FromBody] Class1 data )
        {
            return "Rows Inserted: " + obj.enterData(data);
        }
    }
}
