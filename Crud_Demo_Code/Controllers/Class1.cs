using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Demo_Code.Controllers
{
    //Model
    public class Class1
    {

        public int id { get; set; }

        public String name { get; set; }

        public String email { get; set; }
        

        public Class1(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public Class1()
        { }
    }
}