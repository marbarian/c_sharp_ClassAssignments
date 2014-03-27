using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string fromEmail = txtEmail.Text;
        string fromName = txtName.Text;
        string message = txtComments.Text;
        MailMessage myMessage = new MailMessage();
        myMessage.Subject = "Test Message";
        myMessage.Body = message;
        myMessage.From = new MailAddress(fromEmail, fromName);
        myMessage.To.Add(new MailAddress("joanstudent72@gmail.com", "Joan"));

        SmtpClient myStpClient = new SmtpClient();
        myStpClient.EnableSsl = true;
        myStpClient.Send(myMessage);
    }
}