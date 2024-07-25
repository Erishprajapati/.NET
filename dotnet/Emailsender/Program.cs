// See https://aka.ms/new-console-template for more information


using system;
using System.Collections.Generic;
public interface IMessageSender
{
    void SendMessage(string message);`
}

public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email with message: {message}");
    }
}

public class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS with message: {message}");
    }
}

public class MessageService
{
    private IMessageSender _messageSender;

    public MessageService(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void Send(string message)
    {
        _messageSender.SendMessage(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IMessageSender> messageSenders = new List<IMessageSender>
        {
            new EmailSender(),
            new SmsSender()
        };

        foreach (var sender in messageSenders)
        {
            MessageService messageService = new MessageService(sender);
            messageService.Send("Hello world!");
        }
    }
}
