using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsReverseAjax
{
    public partial class Receive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSetReceiverName_Click(object sender, EventArgs e)
        {
            string receiverName = txtReceiver.Text;
            divSetNick.Visible = false;
            divReceive.Visible = true;
            ltrReceiver.Text = receiverName;
            Sender.Instance.Join(receiverName);
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            //Register the script start
            ClientScript.RegisterStartupScript(this.GetType(), "StartReverseAjax", "reverseAjax();", true);
        }

    }
}