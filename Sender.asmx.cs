using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CsReverseAjax
{
    /// <summary>
    /// Summary description for Sender1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class Sender1 : System.Web.Services.WebService
    {

        //[System.Web.Script.Services.ScriptMethod(ResponseFormat=System.Web.Script.Services.ResponseFormat.Json)]
        [WebMethod]
        public string ReceiveMessage(string receiver)
        {
            //Do a cast to string because this Message content it's an "object" object, that allows any king of object
            //I choose to do that way because I can receive other kind of objects and return it as a
            //JSON object, just uncommenting the second property of this method
            return (string)Sender.Instance.GetMessage(receiver);
        }
    }
}
