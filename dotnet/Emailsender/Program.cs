// See https://aka.ms/new-console-template for more information


// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public interface IPaymentProcessor
{
    void SendMessage(string message);
}

public class CreditCardPaymentPocessor : IPaymentProcessor
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending credit payment message: {message}");
    }
}

public class PaypalPaymentProcessor : IPaymentProcessor
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending paypal payment message: {message}");
    }
}

public class BitcoinPaymentProcessor : IPaymentProcessor
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending bitcoin payment message: {message}"); // Corrected 'console' to 'Console'
    }
}

public class MessageService
{
    private IPaymentProcessor _messageSender;

    public MessageService(IPaymentProcessor messageSender)
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
        List<IPaymentProcessor> messageSenders = new List<IPaymentProcessor>
        {
            new CreditCardPaymentPocessor(),
            new PaypalPaymentProcessor(),
            new BitcoinPaymentProcessor()
        };

        foreach (var sender in messageSenders)
        {
            MessageService messageService = new MessageService(sender);
            messageService.Send("Hello world!");
        }
    }
}
