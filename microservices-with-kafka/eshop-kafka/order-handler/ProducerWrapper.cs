namespace Api
{
    using Confluent.Kafka;
    using System;
    using System.Threading.Tasks;

    public class ProducerWrapper
    {
        private string _topicName;
        private ProducerConfig _config;
        private static readonly Random rand = new Random();

        public ProducerWrapper(ProducerConfig config, string topicName)
        {
            _topicName = topicName;
            _config = config;
        }

        public async Task WriteMessage(string message)
        {
            using var producer = new ProducerBuilder<string, string>(_config)
                    .SetErrorHandler((_, e) => Console.WriteLine("Exception:" + e))
                    .Build();

            var dr = await producer.ProduceAsync(_topicName, new Message<string, string>()
            {
                Key = rand.Next(5).ToString(),
                Value = message
            });

            Console.WriteLine($"KAFKA => Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
            return;
        }
    }
}