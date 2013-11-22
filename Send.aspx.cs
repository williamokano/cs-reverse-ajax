using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsReverseAjax
{
    public partial class Send : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string to = txtTo.Text;
            string message = txtMessage.Text;
            txtTo.Text = to;
            Message reverseAjaxMessage = new Message();
            reverseAjaxMessage.Receiver = to;
            reverseAjaxMessage.Content = message;

            Sender.Instance.SendMessage(reverseAjaxMessage);
        }
    }
}