using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFAppli10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpDBContext employeeDBContext = new EmpDBContext();
            GridView1.DataSource = employeeDBContext.Emps;
            GridView1.DataBind();
        }
    }
}