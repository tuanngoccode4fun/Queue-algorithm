using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffer buf = new Buffer();
            buf.SendMessage(new Message("One"));
            buf.SendMessage(new Message("Two"));
            buf.ReceiveMessage();
            buf.SendMessage(new Message("Three"));
            buf.ReceiveMessage();
            buf.SendMessage(new Message("Four"));
            buf.ReceiveMessage();
            buf.ReceiveMessage();
        }
    }

        class Message
        {
            private string messageText;
            public Message(string s)
            {
                messageText = s;
            }
            public override string ToString()
            {
                return messageText;
            }
        }
        class Buffer
        {
            private Queue messageBuffer;
            public void SendMessage(Message m)
            {
                messageBuffer.Enqueue(m);
                Console.WriteLine("send "+ m.ToString());
                Console.ReadKey();
            }
            public void ReceiveMessage()
            {
                Message m = (Message)messageBuffer.Dequeue();
                Console.WriteLine("recived "+ m.ToString());
                Console.ReadKey();
             }
            public Buffer()
            {
                messageBuffer = new Queue();
            }

        }

       

}
