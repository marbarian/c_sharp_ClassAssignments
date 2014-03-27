using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudySession : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFlip_Click(object sender, EventArgs e)
    {
        txtCard.Enabled = true;
        if (txtCard.Text == "Question Here")
            txtCard.Text = "Answer Here";
        else
            txtCard.Text = "Question Here";
        txtCard.Enabled = false;
    }
}