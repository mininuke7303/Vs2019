using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class Index : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            string _IP = Request.UserHostAddress;
            string _ApplicationPath = Request.ApplicationPath;

            Response.Write(_IP);
            Response.Write(_ApplicationPath);
        }
    }
}