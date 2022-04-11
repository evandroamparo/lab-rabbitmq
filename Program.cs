// See https://aka.ms/new-console-template for more information
using RabbitMQ.Client;

try
{
    var uri = Environment.GetEnvironmentVariable("AMQP_URL") ?? "amqp://localhost";
    var factory = new ConnectionFactory() { Uri = new Uri(uri) };
    var connection = factory.CreateConnection();
    System.Console.WriteLine("Conectado!");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}