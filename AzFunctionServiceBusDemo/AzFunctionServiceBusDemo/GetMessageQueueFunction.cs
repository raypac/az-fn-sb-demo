using System.Diagnostics;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzFunctionServiceBusDemo
{
    public static class GetMessageQueueFunction
    {
        [FunctionName("GetMessageQueueFunction")]
        public static void Run([ServiceBusTrigger("timeentry-ns-queue", Connection = "AzServiceBusConnStr")]string myQueueItem, 
            ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
            Debug.Write(myQueueItem);
        }
    }
}
