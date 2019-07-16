using System;

using Nexmo.Api;
using Nexmo.Api.ClientMethods;
using NexmoSMSApi;
namespace NexmoSMSApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goind to send Text message using Nexmo");

            var client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "your-api-key",
                ApiSecret = "your-api-secret"
            });
            var results = client.SMS.Send(request: new Nexmo.Api.SMS.SMSRequest
            {
                from = "Acme Inc",
                to = "your-number",
                text = "A test SMS sent using the SMS API MR MInaam"
            });

            if (results.messages.Count >= 1)
            {
                if (results.messages[0].status == "0")
                    Console.WriteLine("Message sent successfully.");
                else
                    Console.WriteLine("Message failed with error:"+results.messages[0].error_text);
            }

        }
    }
}
