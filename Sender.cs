using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsReverseAjax
{
    public class Sender
    {
        /// <summary>
        /// Singleton pattern
        /// </summary>
        public static Sender Instance = new Sender();
        private Sender() { }

        private Dictionary<string, Client> receivers = new Dictionary<string, Client>();
        public void SendMessage(Message message)
        {
            if (receivers.ContainsKey(message.Receiver))
            {
                Client client = receivers[message.Receiver];
                client.EnqueueMessage(message);
            }
        }
        public object GetMessage(string receiver)
        {
            if (receivers.ContainsKey(receiver))
            {
                Client client = receivers[receiver];
                return client.DequeueMessage().Content;
            }
            return null;
        }
        public void Join(string receiver)
        {
            receivers[receiver] = new Client();
        }
    }
}