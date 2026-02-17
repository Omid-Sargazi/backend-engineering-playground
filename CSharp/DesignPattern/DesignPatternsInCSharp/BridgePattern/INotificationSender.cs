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

    public abstract class Notification
    {
        protected INotificationSender _sender;

        protected Notification(INotificationSender sender)
        {
            _sender = sender;
        }

        public abstract void Notify(string message);
    }
    public class AlertNotification : Notification
    {
        public AlertNotification(INotificationSender sender) : base(sender)
        {
        }

        public override void Notify(string message)
        {
            _sender.Send($"[ALERT] {message}");
        }
    }

    public class ReminderNotification : Notification
    {
        public ReminderNotification(INotificationSender sender) : base(sender)
        {
        }

        public override void Notify(string message)
        {
            _sender.Send($"[REMINDER] {message}");
        }
    }
}
