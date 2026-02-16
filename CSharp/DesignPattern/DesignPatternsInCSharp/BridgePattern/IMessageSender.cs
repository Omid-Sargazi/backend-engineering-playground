using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email Sent!\nSubject: {subject}\nBody: {body}");
        }
    }

    public class SMSSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"SMS Sent!\nSubject: {subject}\nBody: {body}");
        }
    }

    public abstract class Message
    {
        protected IMessageSender messageSender;
        protected Message(IMessageSender sender)
        {
            messageSender = sender;
        }

        public abstract void Send();
    }

    public class AlertMessage : Message
    {
        private string _subject;
        private string _body;
        public AlertMessage(string subject, string body,IMessageSender sender) : base(sender)
        {
            _subject = $"Alert:{subject}";
            _body = body ;
        }

        public override void Send()
        {
            messageSender.SendMessage(_subject, _body);
        }
    }

    public class ErrorMessage : Message
    {
        private string _subject;
        private string _body;

        public ErrorMessage(string subject, string body, IMessageSender sender)
            : base(sender)
        {
            _subject = $"Error: {subject}";
            _body = body;
        }

        public override void Send()
        {
            messageSender.SendMessage(_subject, _body);
        }
    }
}
