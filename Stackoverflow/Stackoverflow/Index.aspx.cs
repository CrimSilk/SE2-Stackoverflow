using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stackoverflow
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseHandler handler = new DatabaseHandler();
            handler.WriteData("INSERT INTO ACCOUNT (id, email, password, name) VALUES (22, 'bennier', '123123wefwef', 'bennie')");
        }
    }
}