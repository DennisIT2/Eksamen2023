using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eksamen1
{
    public partial class Default : System.Web.UI.Page
    {
        private Dblayer dbl = new Dblayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void VisAlleElever_Click(object sender, EventArgs e)
        {

            ElevGridView.DataSource = dbl.GetAllElevDataFromElevByJoin();
            ElevGridView.DataBind();
        }
    }
}