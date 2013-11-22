using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace CsReverseAjax
{
    public class Client
    {
        private ManualResetEvent messageEvent = new ManualResetEvent(false);
        private Queue<Message> messageQueue = new Queue<Message>();

        public void EnqueueMessage(Message message)
        {
            lock (messageQueue)
            {
                messageQueue.Enqueue(message);
                messageEvent.Set();
            }
        }

        public Message DequeueMessage()
        {
            messageEvent.WaitOne();
            lock (messageQueue)
            {
                if (messageQueue.Count == 1)
                    messageEvent.Reset();
                return messageQueue.Dequeue();
            }
        }

    }
}