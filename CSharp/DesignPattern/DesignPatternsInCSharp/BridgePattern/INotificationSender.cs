using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern
{
    public interface INotificationSender
    {
        void Send(string message);
    }

    public class EmailSender2 : INotificationSender
    {
        public void Send(string message)
        {
            throw new NotImplementedException();
        }
    }

    public class SmsSender2 : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
