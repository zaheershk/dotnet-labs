namespace Api.Services
{
    using Microsoft.Extensions.Hosting;
    using System.Threading;
    using System.Threading.Tasks;
    using System;
    using Api.Models;
    using Newtonsoft.Json;
    using Confluent.Kafka;

    public class ProcessOrdersService : BackgroundService
    {
        private readonly ConsumerConfig consumerConfig;
        private readonly ProducerConfig producerConfig;

        public ProcessOrdersService(ConsumerConfig consumerConfig, ProducerConfig producerConfig)
        {
            this.producerConfig = producerConfig;
            this.consumerConfig = consumerConfig;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("OrderProcessing Service Started");

            while (!stoppingToken.IsCancellationRequested)
            {
                var consumerHelper = new ConsumerWrapper(consumerConfig, "orderrequests");
                string orderRequest = consumerHelper.ReadMessage();

                if (string.IsNullOrWhiteSpace(orderRequest))
                {
                    Console.WriteLine("No message available!");
                    return;
                }

                //Deserilaize 
                OrderRequest order = JsonConvert.DeserializeObject<OrderRequest>(orderRequest);
                if (order == null)
                {
                    Console.WriteLine("Order details not available!");
                    return;
                }

                //TODO:: Process Order
                Console.WriteLine($"Info: OrderHandler => Processing the order for {order.productname}");
                order.status = OrderStatus.COMPLETED;

                //Write to ReadyToShip Queue

                var producerWrapper = new ProducerWrapper(producerConfig, "readytoship");
                await producerWrapper.WriteMessage(JsonConvert.SerializeObject(order));
            }
        }
    }
}